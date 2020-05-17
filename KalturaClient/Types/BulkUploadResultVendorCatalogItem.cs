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
	public class BulkUploadResultVendorCatalogItem : BulkUploadResult
	{
		#region Constants
		public const string VENDOR_CATALOG_ITEM_ID = "vendorCatalogItemId";
		public const string VENDOR_PARTNER_ID = "vendorPartnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string SERVICE_FEATURE = "serviceFeature";
		public const string SERVICE_TYPE = "serviceType";
		public const string TURN_AROUND_TIME = "turnAroundTime";
		public const string SOURCE_LANGUAGE = "sourceLanguage";
		public const string TARGET_LANGUAGE = "targetLanguage";
		public const string OUTPUT_FORMAT = "outputFormat";
		public const string ENABLE_SPEAKER_ID = "enableSpeakerId";
		public const string FIXED_PRICE_ADDONS = "fixedPriceAddons";
		public const string PRICING = "pricing";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string CLEAR_AUDIO_FLAVOR_PARAMS_ID = "clearAudioFlavorParamsId";
		#endregion

		#region Private Fields
		private int _VendorCatalogItemId = Int32.MinValue;
		private int _VendorPartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private VendorServiceFeature _ServiceFeature = (VendorServiceFeature)Int32.MinValue;
		private VendorServiceType _ServiceType = (VendorServiceType)Int32.MinValue;
		private VendorServiceTurnAroundTime _TurnAroundTime = (VendorServiceTurnAroundTime)Int32.MinValue;
		private CatalogItemLanguage _SourceLanguage = null;
		private CatalogItemLanguage _TargetLanguage = null;
		private VendorCatalogItemOutputFormat _OutputFormat = (VendorCatalogItemOutputFormat)Int32.MinValue;
		private NullableBoolean _EnableSpeakerId = (NullableBoolean)Int32.MinValue;
		private int _FixedPriceAddons = Int32.MinValue;
		private VendorCatalogItemPricing _Pricing;
		private int _FlavorParamsId = Int32.MinValue;
		private int _ClearAudioFlavorParamsId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int VendorCatalogItemId
		{
			get { return _VendorCatalogItemId; }
			set 
			{ 
				_VendorCatalogItemId = value;
				OnPropertyChanged("VendorCatalogItemId");
			}
		}
		[JsonProperty]
		public int VendorPartnerId
		{
			get { return _VendorPartnerId; }
			set 
			{ 
				_VendorPartnerId = value;
				OnPropertyChanged("VendorPartnerId");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public VendorServiceFeature ServiceFeature
		{
			get { return _ServiceFeature; }
			set 
			{ 
				_ServiceFeature = value;
				OnPropertyChanged("ServiceFeature");
			}
		}
		[JsonProperty]
		public VendorServiceType ServiceType
		{
			get { return _ServiceType; }
			set 
			{ 
				_ServiceType = value;
				OnPropertyChanged("ServiceType");
			}
		}
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTime
		{
			get { return _TurnAroundTime; }
			set 
			{ 
				_TurnAroundTime = value;
				OnPropertyChanged("TurnAroundTime");
			}
		}
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
		public CatalogItemLanguage TargetLanguage
		{
			get { return _TargetLanguage; }
			set 
			{ 
				_TargetLanguage = value;
				OnPropertyChanged("TargetLanguage");
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
		[JsonProperty]
		public VendorCatalogItemPricing Pricing
		{
			get { return _Pricing; }
			set 
			{ 
				_Pricing = value;
				OnPropertyChanged("Pricing");
			}
		}
		[JsonProperty]
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		[JsonProperty]
		public int ClearAudioFlavorParamsId
		{
			get { return _ClearAudioFlavorParamsId; }
			set 
			{ 
				_ClearAudioFlavorParamsId = value;
				OnPropertyChanged("ClearAudioFlavorParamsId");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultVendorCatalogItem()
		{
		}

		public BulkUploadResultVendorCatalogItem(JToken node) : base(node)
		{
			if(node["vendorCatalogItemId"] != null)
			{
				this._VendorCatalogItemId = ParseInt(node["vendorCatalogItemId"].Value<string>());
			}
			if(node["vendorPartnerId"] != null)
			{
				this._VendorPartnerId = ParseInt(node["vendorPartnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["serviceFeature"] != null)
			{
				this._ServiceFeature = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeature"].Value<string>());
			}
			if(node["serviceType"] != null)
			{
				this._ServiceType = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceType"].Value<string>());
			}
			if(node["turnAroundTime"] != null)
			{
				this._TurnAroundTime = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTime"].Value<string>());
			}
			if(node["sourceLanguage"] != null)
			{
				this._SourceLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguage"].Value<string>());
			}
			if(node["targetLanguage"] != null)
			{
				this._TargetLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["targetLanguage"].Value<string>());
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
			if(node["pricing"] != null)
			{
				this._Pricing = ObjectFactory.Create<VendorCatalogItemPricing>(node["pricing"]);
			}
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
			if(node["clearAudioFlavorParamsId"] != null)
			{
				this._ClearAudioFlavorParamsId = ParseInt(node["clearAudioFlavorParamsId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultVendorCatalogItem");
			kparams.AddIfNotNull("vendorCatalogItemId", this._VendorCatalogItemId);
			kparams.AddIfNotNull("vendorPartnerId", this._VendorPartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("serviceFeature", this._ServiceFeature);
			kparams.AddIfNotNull("serviceType", this._ServiceType);
			kparams.AddIfNotNull("turnAroundTime", this._TurnAroundTime);
			kparams.AddIfNotNull("sourceLanguage", this._SourceLanguage);
			kparams.AddIfNotNull("targetLanguage", this._TargetLanguage);
			kparams.AddIfNotNull("outputFormat", this._OutputFormat);
			kparams.AddIfNotNull("enableSpeakerId", this._EnableSpeakerId);
			kparams.AddIfNotNull("fixedPriceAddons", this._FixedPriceAddons);
			kparams.AddIfNotNull("pricing", this._Pricing);
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			kparams.AddIfNotNull("clearAudioFlavorParamsId", this._ClearAudioFlavorParamsId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VENDOR_CATALOG_ITEM_ID:
					return "VendorCatalogItemId";
				case VENDOR_PARTNER_ID:
					return "VendorPartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case SERVICE_FEATURE:
					return "ServiceFeature";
				case SERVICE_TYPE:
					return "ServiceType";
				case TURN_AROUND_TIME:
					return "TurnAroundTime";
				case SOURCE_LANGUAGE:
					return "SourceLanguage";
				case TARGET_LANGUAGE:
					return "TargetLanguage";
				case OUTPUT_FORMAT:
					return "OutputFormat";
				case ENABLE_SPEAKER_ID:
					return "EnableSpeakerId";
				case FIXED_PRICE_ADDONS:
					return "FixedPriceAddons";
				case PRICING:
					return "Pricing";
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				case CLEAR_AUDIO_FLAVOR_PARAMS_ID:
					return "ClearAudioFlavorParamsId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

