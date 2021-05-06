// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
	public class PlayReadyLicenseDetails : ObjectBase
	{
		#region Constants
		public const string POLICY = "policy";
		public const string BEGIN_DATE = "beginDate";
		public const string EXPIRATION_DATE = "expirationDate";
		public const string REMOVAL_DATE = "removalDate";
		#endregion

		#region Private Fields
		private PlayReadyPolicy _Policy;
		private int _BeginDate = Int32.MinValue;
		private int _ExpirationDate = Int32.MinValue;
		private int _RemovalDate = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public PlayReadyPolicy Policy
		{
			get { return _Policy; }
			set 
			{ 
				_Policy = value;
				OnPropertyChanged("Policy");
			}
		}
		[JsonProperty]
		public int BeginDate
		{
			get { return _BeginDate; }
			set 
			{ 
				_BeginDate = value;
				OnPropertyChanged("BeginDate");
			}
		}
		[JsonProperty]
		public int ExpirationDate
		{
			get { return _ExpirationDate; }
			set 
			{ 
				_ExpirationDate = value;
				OnPropertyChanged("ExpirationDate");
			}
		}
		[JsonProperty]
		public int RemovalDate
		{
			get { return _RemovalDate; }
			set 
			{ 
				_RemovalDate = value;
				OnPropertyChanged("RemovalDate");
			}
		}
		#endregion

		#region CTor
		public PlayReadyLicenseDetails()
		{
		}

		public PlayReadyLicenseDetails(JToken node) : base(node)
		{
			if(node["policy"] != null)
			{
				this._Policy = ObjectFactory.Create<PlayReadyPolicy>(node["policy"]);
			}
			if(node["beginDate"] != null)
			{
				this._BeginDate = ParseInt(node["beginDate"].Value<string>());
			}
			if(node["expirationDate"] != null)
			{
				this._ExpirationDate = ParseInt(node["expirationDate"].Value<string>());
			}
			if(node["removalDate"] != null)
			{
				this._RemovalDate = ParseInt(node["removalDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPlayReadyLicenseDetails");
			kparams.AddIfNotNull("policy", this._Policy);
			kparams.AddIfNotNull("beginDate", this._BeginDate);
			kparams.AddIfNotNull("expirationDate", this._ExpirationDate);
			kparams.AddIfNotNull("removalDate", this._RemovalDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case POLICY:
					return "Policy";
				case BEGIN_DATE:
					return "BeginDate";
				case EXPIRATION_DATE:
					return "ExpirationDate";
				case REMOVAL_DATE:
					return "RemovalDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

