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
	public class UrlTokenizerKs : UrlTokenizer
	{
		#region Constants
		public const string USE_PATH = "usePath";
		public const string ADDITIONAL_URIS = "additionalUris";
		#endregion

		#region Private Fields
		private bool? _UsePath = null;
		private string _AdditionalUris = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? UsePath
		{
			get { return _UsePath; }
			set 
			{ 
				_UsePath = value;
				OnPropertyChanged("UsePath");
			}
		}
		[JsonProperty]
		public string AdditionalUris
		{
			get { return _AdditionalUris; }
			set 
			{ 
				_AdditionalUris = value;
				OnPropertyChanged("AdditionalUris");
			}
		}
		#endregion

		#region CTor
		public UrlTokenizerKs()
		{
		}

		public UrlTokenizerKs(JToken node) : base(node)
		{
			if(node["usePath"] != null)
			{
				this._UsePath = ParseBool(node["usePath"].Value<string>());
			}
			if(node["additionalUris"] != null)
			{
				this._AdditionalUris = node["additionalUris"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUrlTokenizerKs");
			kparams.AddIfNotNull("usePath", this._UsePath);
			kparams.AddIfNotNull("additionalUris", this._AdditionalUris);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USE_PATH:
					return "UsePath";
				case ADDITIONAL_URIS:
					return "AdditionalUris";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

