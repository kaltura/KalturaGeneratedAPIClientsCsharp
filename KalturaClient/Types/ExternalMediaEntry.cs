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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ExternalMediaEntry : MediaEntry
	{
		#region Constants
		public const string EXTERNAL_SOURCE_TYPE = "externalSourceType";
		public const string ASSET_PARAMS_IDS = "assetParamsIds";
		#endregion

		#region Private Fields
		private ExternalMediaSourceType _ExternalSourceType = null;
		private string _AssetParamsIds = null;
		#endregion

		#region Properties
		[JsonProperty]
		public ExternalMediaSourceType ExternalSourceType
		{
			get { return _ExternalSourceType; }
			set 
			{ 
				_ExternalSourceType = value;
				OnPropertyChanged("ExternalSourceType");
			}
		}
		[JsonProperty]
		public string AssetParamsIds
		{
			get { return _AssetParamsIds; }
			private set 
			{ 
				_AssetParamsIds = value;
				OnPropertyChanged("AssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public ExternalMediaEntry()
		{
		}

		public ExternalMediaEntry(JToken node) : base(node)
		{
			if(node["externalSourceType"] != null)
			{
				this._ExternalSourceType = (ExternalMediaSourceType)StringEnum.Parse(typeof(ExternalMediaSourceType), node["externalSourceType"].Value<string>());
			}
			if(node["assetParamsIds"] != null)
			{
				this._AssetParamsIds = node["assetParamsIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExternalMediaEntry");
			kparams.AddIfNotNull("externalSourceType", this._ExternalSourceType);
			kparams.AddIfNotNull("assetParamsIds", this._AssetParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXTERNAL_SOURCE_TYPE:
					return "ExternalSourceType";
				case ASSET_PARAMS_IDS:
					return "AssetParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

