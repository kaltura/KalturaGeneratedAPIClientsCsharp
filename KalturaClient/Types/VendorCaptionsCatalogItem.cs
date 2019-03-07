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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class VendorCaptionsCatalogItem : VendorCatalogItem
	{
		#region Constants
		public const string SOURCE_LANGUAGE = "sourceLanguage";
		public const string OUTPUT_FORMAT = "outputFormat";
		public const string ENABLE_SPEAKER_ID = "enableSpeakerId";
		public const string FIXED_PRICE_ADDONS = "fixedPriceAddons";
		#endregion

		#region Private Fields
		private CatalogItemLanguage _SourceLanguage = null;
		private VendorCatalogItemOutputFormat _OutputFormat = (VendorCatalogItemOutputFormat)Int32.MinValue;
		private NullableBoolean _EnableSpeakerId = (NullableBoolean)Int32.MinValue;
		private int _FixedPriceAddons = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public CatalogItemLanguage SourceLanguage
		{
			get { return _SourceLanguage; }
			set 
			{ 
				_SourceLanguage = value;
				OnPropertyChanged("SourceLanguage");
			}
		}
		[JsonProperty]
		public VendorCatalogItemOutputFormat OutputFormat
		{
			get { return _OutputFormat; }
			set 
			{ 
				_OutputFormat = value;
				OnPropertyChanged("OutputFormat");
			}
		}
		[JsonProperty]
		public NullableBoolean EnableSpeakerId
		{
			get { return _EnableSpeakerId; }
			set 
			{ 
				_EnableSpeakerId = value;
				OnPropertyChanged("EnableSpeakerId");
			}
		}
		[JsonProperty]
		public int FixedPriceAddons
		{
			get { return _FixedPriceAddons; }
			set 
			{ 
				_FixedPriceAddons = value;
				OnPropertyChanged("FixedPriceAddons");
			}
		}
		#endregion

		#region CTor
		public VendorCaptionsCatalogItem()
		{
		}

		public VendorCaptionsCatalogItem(JToken node) : base(node)
		{
			if(node["sourceLanguage"] != null)
			{
				this._SourceLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguage"].Value<string>());
			}
			if(node["outputFormat"] != null)
			{
				this._OutputFormat = (VendorCatalogItemOutputFormat)ParseEnum(typeof(VendorCatalogItemOutputFormat), node["outputFormat"].Value<string>());
			}
			if(node["enableSpeakerId"] != null)
			{
				this._EnableSpeakerId = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enableSpeakerId"].Value<string>());
			}
			if(node["fixedPriceAddons"] != null)
			{
				this._FixedPriceAddons = ParseInt(node["fixedPriceAddons"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCaptionsCatalogItem");
			kparams.AddIfNotNull("sourceLanguage", this._SourceLanguage);
			kparams.AddIfNotNull("outputFormat", this._OutputFormat);
			kparams.AddIfNotNull("enableSpeakerId", this._EnableSpeakerId);
			kparams.AddIfNotNull("fixedPriceAddons", this._FixedPriceAddons);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_LANGUAGE:
					return "SourceLanguage";
				case OUTPUT_FORMAT:
					return "OutputFormat";
				case ENABLE_SPEAKER_ID:
					return "EnableSpeakerId";
				case FIXED_PRICE_ADDONS:
					return "FixedPriceAddons";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

