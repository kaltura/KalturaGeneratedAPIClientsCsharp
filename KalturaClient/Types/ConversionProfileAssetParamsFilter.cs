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
	public class ConversionProfileAssetParamsFilter : ConversionProfileAssetParamsBaseFilter
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID_FILTER = "conversionProfileIdFilter";
		public const string ASSET_PARAMS_ID_FILTER = "assetParamsIdFilter";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private ConversionProfileFilter _ConversionProfileIdFilter;
		private AssetParamsFilter _AssetParamsIdFilter;
		private ConversionProfileAssetParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public ConversionProfileFilter ConversionProfileIdFilter
		{
			get { return _ConversionProfileIdFilter; }
			set 
			{ 
				_ConversionProfileIdFilter = value;
				OnPropertyChanged("ConversionProfileIdFilter");
			}
		}
		[JsonProperty]
		public AssetParamsFilter AssetParamsIdFilter
		{
			get { return _AssetParamsIdFilter; }
			set 
			{ 
				_AssetParamsIdFilter = value;
				OnPropertyChanged("AssetParamsIdFilter");
			}
		}
		[JsonProperty]
		public new ConversionProfileAssetParamsOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public ConversionProfileAssetParamsFilter()
		{
		}

		public ConversionProfileAssetParamsFilter(JToken node) : base(node)
		{
			if(node["conversionProfileIdFilter"] != null)
			{
				this._ConversionProfileIdFilter = ObjectFactory.Create<ConversionProfileFilter>(node["conversionProfileIdFilter"]);
			}
			if(node["assetParamsIdFilter"] != null)
			{
				this._AssetParamsIdFilter = ObjectFactory.Create<AssetParamsFilter>(node["assetParamsIdFilter"]);
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (ConversionProfileAssetParamsOrderBy)StringEnum.Parse(typeof(ConversionProfileAssetParamsOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConversionProfileAssetParamsFilter");
			kparams.AddIfNotNull("conversionProfileIdFilter", this._ConversionProfileIdFilter);
			kparams.AddIfNotNull("assetParamsIdFilter", this._AssetParamsIdFilter);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONVERSION_PROFILE_ID_FILTER:
					return "ConversionProfileIdFilter";
				case ASSET_PARAMS_ID_FILTER:
					return "AssetParamsIdFilter";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

