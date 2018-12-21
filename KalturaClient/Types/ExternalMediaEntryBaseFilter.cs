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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class ExternalMediaEntryBaseFilter : MediaEntryFilter
	{
		#region Constants
		public const string EXTERNAL_SOURCE_TYPE_EQUAL = "externalSourceTypeEqual";
		public const string EXTERNAL_SOURCE_TYPE_IN = "externalSourceTypeIn";
		public const string ASSET_PARAMS_IDS_MATCH_OR = "assetParamsIdsMatchOr";
		public const string ASSET_PARAMS_IDS_MATCH_AND = "assetParamsIdsMatchAnd";
		#endregion

		#region Private Fields
		private ExternalMediaSourceType _ExternalSourceTypeEqual = null;
		private string _ExternalSourceTypeIn = null;
		private string _AssetParamsIdsMatchOr = null;
		private string _AssetParamsIdsMatchAnd = null;
		#endregion

		#region Properties
		[JsonProperty]
		public ExternalMediaSourceType ExternalSourceTypeEqual
		{
			get { return _ExternalSourceTypeEqual; }
			set 
			{ 
				_ExternalSourceTypeEqual = value;
				OnPropertyChanged("ExternalSourceTypeEqual");
			}
		}
		[JsonProperty]
		public string ExternalSourceTypeIn
		{
			get { return _ExternalSourceTypeIn; }
			set 
			{ 
				_ExternalSourceTypeIn = value;
				OnPropertyChanged("ExternalSourceTypeIn");
			}
		}
		[JsonProperty]
		public string AssetParamsIdsMatchOr
		{
			get { return _AssetParamsIdsMatchOr; }
			set 
			{ 
				_AssetParamsIdsMatchOr = value;
				OnPropertyChanged("AssetParamsIdsMatchOr");
			}
		}
		[JsonProperty]
		public string AssetParamsIdsMatchAnd
		{
			get { return _AssetParamsIdsMatchAnd; }
			set 
			{ 
				_AssetParamsIdsMatchAnd = value;
				OnPropertyChanged("AssetParamsIdsMatchAnd");
			}
		}
		#endregion

		#region CTor
		public ExternalMediaEntryBaseFilter()
		{
		}

		public ExternalMediaEntryBaseFilter(JToken node) : base(node)
		{
			if(node["externalSourceTypeEqual"] != null)
			{
				this._ExternalSourceTypeEqual = (ExternalMediaSourceType)StringEnum.Parse(typeof(ExternalMediaSourceType), node["externalSourceTypeEqual"].Value<string>());
			}
			if(node["externalSourceTypeIn"] != null)
			{
				this._ExternalSourceTypeIn = node["externalSourceTypeIn"].Value<string>();
			}
			if(node["assetParamsIdsMatchOr"] != null)
			{
				this._AssetParamsIdsMatchOr = node["assetParamsIdsMatchOr"].Value<string>();
			}
			if(node["assetParamsIdsMatchAnd"] != null)
			{
				this._AssetParamsIdsMatchAnd = node["assetParamsIdsMatchAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExternalMediaEntryBaseFilter");
			kparams.AddIfNotNull("externalSourceTypeEqual", this._ExternalSourceTypeEqual);
			kparams.AddIfNotNull("externalSourceTypeIn", this._ExternalSourceTypeIn);
			kparams.AddIfNotNull("assetParamsIdsMatchOr", this._AssetParamsIdsMatchOr);
			kparams.AddIfNotNull("assetParamsIdsMatchAnd", this._AssetParamsIdsMatchAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXTERNAL_SOURCE_TYPE_EQUAL:
					return "ExternalSourceTypeEqual";
				case EXTERNAL_SOURCE_TYPE_IN:
					return "ExternalSourceTypeIn";
				case ASSET_PARAMS_IDS_MATCH_OR:
					return "AssetParamsIdsMatchOr";
				case ASSET_PARAMS_IDS_MATCH_AND:
					return "AssetParamsIdsMatchAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

