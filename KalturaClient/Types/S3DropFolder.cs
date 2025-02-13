// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class S3DropFolder : DropFolder
	{
		#region Constants
		public const string S3HOST = "s3Host";
		public const string S3REGION = "s3Region";
		public const string S3USER_ID = "s3UserId";
		public const string S3PASSWORD = "s3Password";
		#endregion

		#region Private Fields
		private string _S3Host = null;
		private string _S3Region = null;
		private string _S3UserId = null;
		private string _S3Password = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string S3Host
		{
			get { return _S3Host; }
			set 
			{ 
				_S3Host = value;
				OnPropertyChanged("S3Host");
			}
		}
		[JsonProperty]
		public string S3Region
		{
			get { return _S3Region; }
			set 
			{ 
				_S3Region = value;
				OnPropertyChanged("S3Region");
			}
		}
		[JsonProperty]
		public string S3UserId
		{
			get { return _S3UserId; }
			set 
			{ 
				_S3UserId = value;
				OnPropertyChanged("S3UserId");
			}
		}
		[JsonProperty]
		public string S3Password
		{
			get { return _S3Password; }
			set 
			{ 
				_S3Password = value;
				OnPropertyChanged("S3Password");
			}
		}
		#endregion

		#region CTor
		public S3DropFolder()
		{
		}

		public S3DropFolder(JToken node) : base(node)
		{
			if(node["s3Host"] != null)
			{
				this._S3Host = node["s3Host"].Value<string>();
			}
			if(node["s3Region"] != null)
			{
				this._S3Region = node["s3Region"].Value<string>();
			}
			if(node["s3UserId"] != null)
			{
				this._S3UserId = node["s3UserId"].Value<string>();
			}
			if(node["s3Password"] != null)
			{
				this._S3Password = node["s3Password"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaS3DropFolder");
			kparams.AddIfNotNull("s3Host", this._S3Host);
			kparams.AddIfNotNull("s3Region", this._S3Region);
			kparams.AddIfNotNull("s3UserId", this._S3UserId);
			kparams.AddIfNotNull("s3Password", this._S3Password);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case S3HOST:
					return "S3Host";
				case S3REGION:
					return "S3Region";
				case S3USER_ID:
					return "S3UserId";
				case S3PASSWORD:
					return "S3Password";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

