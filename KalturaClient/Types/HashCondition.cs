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
	public class HashCondition : Condition
	{
		#region Constants
		public const string HASH_NAME = "hashName";
		public const string HASH_SECRET = "hashSecret";
		#endregion

		#region Private Fields
		private string _HashName = null;
		private string _HashSecret = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string HashName
		{
			get { return _HashName; }
			set 
			{ 
				_HashName = value;
				OnPropertyChanged("HashName");
			}
		}
		[JsonProperty]
		public string HashSecret
		{
			get { return _HashSecret; }
			set 
			{ 
				_HashSecret = value;
				OnPropertyChanged("HashSecret");
			}
		}
		#endregion

		#region CTor
		public HashCondition()
		{
		}

		public HashCondition(JToken node) : base(node)
		{
			if(node["hashName"] != null)
			{
				this._HashName = node["hashName"].Value<string>();
			}
			if(node["hashSecret"] != null)
			{
				this._HashSecret = node["hashSecret"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHashCondition");
			kparams.AddIfNotNull("hashName", this._HashName);
			kparams.AddIfNotNull("hashSecret", this._HashSecret);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HASH_NAME:
					return "HashName";
				case HASH_SECRET:
					return "HashSecret";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

