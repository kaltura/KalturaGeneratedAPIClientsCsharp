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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class DistributionProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_ID = "partnerId";
		public const string PROVIDER_TYPE = "providerType";
		public const string NAME = "name";
		public const string STATUS = "status";
		public const string SUBMIT_ENABLED = "submitEnabled";
		public const string UPDATE_ENABLED = "updateEnabled";
		public const string DELETE_ENABLED = "deleteEnabled";
		public const string REPORT_ENABLED = "reportEnabled";
		public const string AUTO_CREATE_FLAVORS = "autoCreateFlavors";
		public const string AUTO_CREATE_THUMB = "autoCreateThumb";
		public const string OPTIONAL_FLAVOR_PARAMS_IDS = "optionalFlavorParamsIds";
		public const string REQUIRED_FLAVOR_PARAMS_IDS = "requiredFlavorParamsIds";
		public const string OPTIONAL_THUMB_DIMENSIONS = "optionalThumbDimensions";
		public const string REQUIRED_THUMB_DIMENSIONS = "requiredThumbDimensions";
		public const string OPTIONAL_ASSET_DISTRIBUTION_RULES = "optionalAssetDistributionRules";
		public const string REQUIRED_ASSET_DISTRIBUTION_RULES = "requiredAssetDistributionRules";
		public const string SUNRISE_DEFAULT_OFFSET = "sunriseDefaultOffset";
		public const string SUNSET_DEFAULT_OFFSET = "sunsetDefaultOffset";
		public const string RECOMMENDED_STORAGE_PROFILE_FOR_DOWNLOAD = "recommendedStorageProfileForDownload";
		public const string RECOMMENDED_DC_FOR_DOWNLOAD = "recommendedDcForDownload";
		public const string RECOMMENDED_DC_FOR_EXECUTE = "recommendedDcForExecute";
		public const string DISTRIBUTE_TRIGGER = "distributeTrigger";
		public const string SUPPORT_IMAGE_ENTRY = "supportImageEntry";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private DistributionProviderType _ProviderType = null;
		private string _Name = null;
		private DistributionProfileStatus _Status = (DistributionProfileStatus)Int32.MinValue;
		private DistributionProfileActionStatus _SubmitEnabled = (DistributionProfileActionStatus)Int32.MinValue;
		private DistributionProfileActionStatus _UpdateEnabled = (DistributionProfileActionStatus)Int32.MinValue;
		private DistributionProfileActionStatus _DeleteEnabled = (DistributionProfileActionStatus)Int32.MinValue;
		private DistributionProfileActionStatus _ReportEnabled = (DistributionProfileActionStatus)Int32.MinValue;
		private string _AutoCreateFlavors = null;
		private string _AutoCreateThumb = null;
		private string _OptionalFlavorParamsIds = null;
		private string _RequiredFlavorParamsIds = null;
		private IList<DistributionThumbDimensions> _OptionalThumbDimensions;
		private IList<DistributionThumbDimensions> _RequiredThumbDimensions;
		private IList<AssetDistributionRule> _OptionalAssetDistributionRules;
		private IList<AssetDistributionRule> _RequiredAssetDistributionRules;
		private int _SunriseDefaultOffset = Int32.MinValue;
		private int _SunsetDefaultOffset = Int32.MinValue;
		private int _RecommendedStorageProfileForDownload = Int32.MinValue;
		private int _RecommendedDcForDownload = Int32.MinValue;
		private int _RecommendedDcForExecute = Int32.MinValue;
		private DistributeTrigger _DistributeTrigger = (DistributeTrigger)Int32.MinValue;
		private bool? _SupportImageEntry = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use ProviderTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use SubmitEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProfileActionStatus SubmitEnabled
		{
			get { return _SubmitEnabled; }
			set 
			{ 
				_SubmitEnabled = value;
				OnPropertyChanged("SubmitEnabled");
			}
		}
		/// <summary>
		/// Use UpdateEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProfileActionStatus UpdateEnabled
		{
			get { return _UpdateEnabled; }
			set 
			{ 
				_UpdateEnabled = value;
				OnPropertyChanged("UpdateEnabled");
			}
		}
		/// <summary>
		/// Use DeleteEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProfileActionStatus DeleteEnabled
		{
			get { return _DeleteEnabled; }
			set 
			{ 
				_DeleteEnabled = value;
				OnPropertyChanged("DeleteEnabled");
			}
		}
		/// <summary>
		/// Use ReportEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributionProfileActionStatus ReportEnabled
		{
			get { return _ReportEnabled; }
			set 
			{ 
				_ReportEnabled = value;
				OnPropertyChanged("ReportEnabled");
			}
		}
		/// <summary>
		/// Use AutoCreateFlavorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AutoCreateFlavors
		{
			get { return _AutoCreateFlavors; }
			set 
			{ 
				_AutoCreateFlavors = value;
				OnPropertyChanged("AutoCreateFlavors");
			}
		}
		/// <summary>
		/// Use AutoCreateThumbAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AutoCreateThumb
		{
			get { return _AutoCreateThumb; }
			set 
			{ 
				_AutoCreateThumb = value;
				OnPropertyChanged("AutoCreateThumb");
			}
		}
		/// <summary>
		/// Use OptionalFlavorParamsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		/// <summary>
		/// Use RequiredFlavorParamsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		/// <summary>
		/// Use OptionalThumbDimensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<DistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		/// <summary>
		/// Use RequiredThumbDimensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<DistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		/// <summary>
		/// Use OptionalAssetDistributionRulesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<AssetDistributionRule> OptionalAssetDistributionRules
		{
			get { return _OptionalAssetDistributionRules; }
			set 
			{ 
				_OptionalAssetDistributionRules = value;
				OnPropertyChanged("OptionalAssetDistributionRules");
			}
		}
		/// <summary>
		/// Use RequiredAssetDistributionRulesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<AssetDistributionRule> RequiredAssetDistributionRules
		{
			get { return _RequiredAssetDistributionRules; }
			set 
			{ 
				_RequiredAssetDistributionRules = value;
				OnPropertyChanged("RequiredAssetDistributionRules");
			}
		}
		/// <summary>
		/// Use SunriseDefaultOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SunriseDefaultOffset
		{
			get { return _SunriseDefaultOffset; }
			set 
			{ 
				_SunriseDefaultOffset = value;
				OnPropertyChanged("SunriseDefaultOffset");
			}
		}
		/// <summary>
		/// Use SunsetDefaultOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SunsetDefaultOffset
		{
			get { return _SunsetDefaultOffset; }
			set 
			{ 
				_SunsetDefaultOffset = value;
				OnPropertyChanged("SunsetDefaultOffset");
			}
		}
		/// <summary>
		/// Use RecommendedStorageProfileForDownloadAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecommendedStorageProfileForDownload
		{
			get { return _RecommendedStorageProfileForDownload; }
			set 
			{ 
				_RecommendedStorageProfileForDownload = value;
				OnPropertyChanged("RecommendedStorageProfileForDownload");
			}
		}
		/// <summary>
		/// Use RecommendedDcForDownloadAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecommendedDcForDownload
		{
			get { return _RecommendedDcForDownload; }
			set 
			{ 
				_RecommendedDcForDownload = value;
				OnPropertyChanged("RecommendedDcForDownload");
			}
		}
		/// <summary>
		/// Use RecommendedDcForExecuteAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RecommendedDcForExecute
		{
			get { return _RecommendedDcForExecute; }
			set 
			{ 
				_RecommendedDcForExecute = value;
				OnPropertyChanged("RecommendedDcForExecute");
			}
		}
		/// <summary>
		/// Use DistributeTriggerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DistributeTrigger DistributeTrigger
		{
			get { return _DistributeTrigger; }
			set 
			{ 
				_DistributeTrigger = value;
				OnPropertyChanged("DistributeTrigger");
			}
		}
		/// <summary>
		/// Use SupportImageEntryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? SupportImageEntry
		{
			get { return _SupportImageEntry; }
			private set 
			{ 
				_SupportImageEntry = value;
				OnPropertyChanged("SupportImageEntry");
			}
		}
		#endregion

		#region CTor
		public DistributionProfile()
		{
		}

		public DistributionProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["providerType"] != null)
			{
				this._ProviderType = (DistributionProviderType)StringEnum.Parse(typeof(DistributionProviderType), node["providerType"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (DistributionProfileStatus)ParseEnum(typeof(DistributionProfileStatus), node["status"].Value<string>());
			}
			if(node["submitEnabled"] != null)
			{
				this._SubmitEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), node["submitEnabled"].Value<string>());
			}
			if(node["updateEnabled"] != null)
			{
				this._UpdateEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), node["updateEnabled"].Value<string>());
			}
			if(node["deleteEnabled"] != null)
			{
				this._DeleteEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), node["deleteEnabled"].Value<string>());
			}
			if(node["reportEnabled"] != null)
			{
				this._ReportEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), node["reportEnabled"].Value<string>());
			}
			if(node["autoCreateFlavors"] != null)
			{
				this._AutoCreateFlavors = node["autoCreateFlavors"].Value<string>();
			}
			if(node["autoCreateThumb"] != null)
			{
				this._AutoCreateThumb = node["autoCreateThumb"].Value<string>();
			}
			if(node["optionalFlavorParamsIds"] != null)
			{
				this._OptionalFlavorParamsIds = node["optionalFlavorParamsIds"].Value<string>();
			}
			if(node["requiredFlavorParamsIds"] != null)
			{
				this._RequiredFlavorParamsIds = node["requiredFlavorParamsIds"].Value<string>();
			}
			if(node["optionalThumbDimensions"] != null)
			{
				this._OptionalThumbDimensions = new List<DistributionThumbDimensions>();
				foreach(var arrayNode in node["optionalThumbDimensions"].Children())
				{
					this._OptionalThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
				}
			}
			if(node["requiredThumbDimensions"] != null)
			{
				this._RequiredThumbDimensions = new List<DistributionThumbDimensions>();
				foreach(var arrayNode in node["requiredThumbDimensions"].Children())
				{
					this._RequiredThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
				}
			}
			if(node["optionalAssetDistributionRules"] != null)
			{
				this._OptionalAssetDistributionRules = new List<AssetDistributionRule>();
				foreach(var arrayNode in node["optionalAssetDistributionRules"].Children())
				{
					this._OptionalAssetDistributionRules.Add(ObjectFactory.Create<AssetDistributionRule>(arrayNode));
				}
			}
			if(node["requiredAssetDistributionRules"] != null)
			{
				this._RequiredAssetDistributionRules = new List<AssetDistributionRule>();
				foreach(var arrayNode in node["requiredAssetDistributionRules"].Children())
				{
					this._RequiredAssetDistributionRules.Add(ObjectFactory.Create<AssetDistributionRule>(arrayNode));
				}
			}
			if(node["sunriseDefaultOffset"] != null)
			{
				this._SunriseDefaultOffset = ParseInt(node["sunriseDefaultOffset"].Value<string>());
			}
			if(node["sunsetDefaultOffset"] != null)
			{
				this._SunsetDefaultOffset = ParseInt(node["sunsetDefaultOffset"].Value<string>());
			}
			if(node["recommendedStorageProfileForDownload"] != null)
			{
				this._RecommendedStorageProfileForDownload = ParseInt(node["recommendedStorageProfileForDownload"].Value<string>());
			}
			if(node["recommendedDcForDownload"] != null)
			{
				this._RecommendedDcForDownload = ParseInt(node["recommendedDcForDownload"].Value<string>());
			}
			if(node["recommendedDcForExecute"] != null)
			{
				this._RecommendedDcForExecute = ParseInt(node["recommendedDcForExecute"].Value<string>());
			}
			if(node["distributeTrigger"] != null)
			{
				this._DistributeTrigger = (DistributeTrigger)ParseEnum(typeof(DistributeTrigger), node["distributeTrigger"].Value<string>());
			}
			if(node["supportImageEntry"] != null)
			{
				this._SupportImageEntry = ParseBool(node["supportImageEntry"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDistributionProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("providerType", this._ProviderType);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("submitEnabled", this._SubmitEnabled);
			kparams.AddIfNotNull("updateEnabled", this._UpdateEnabled);
			kparams.AddIfNotNull("deleteEnabled", this._DeleteEnabled);
			kparams.AddIfNotNull("reportEnabled", this._ReportEnabled);
			kparams.AddIfNotNull("autoCreateFlavors", this._AutoCreateFlavors);
			kparams.AddIfNotNull("autoCreateThumb", this._AutoCreateThumb);
			kparams.AddIfNotNull("optionalFlavorParamsIds", this._OptionalFlavorParamsIds);
			kparams.AddIfNotNull("requiredFlavorParamsIds", this._RequiredFlavorParamsIds);
			kparams.AddIfNotNull("optionalThumbDimensions", this._OptionalThumbDimensions);
			kparams.AddIfNotNull("requiredThumbDimensions", this._RequiredThumbDimensions);
			kparams.AddIfNotNull("optionalAssetDistributionRules", this._OptionalAssetDistributionRules);
			kparams.AddIfNotNull("requiredAssetDistributionRules", this._RequiredAssetDistributionRules);
			kparams.AddIfNotNull("sunriseDefaultOffset", this._SunriseDefaultOffset);
			kparams.AddIfNotNull("sunsetDefaultOffset", this._SunsetDefaultOffset);
			kparams.AddIfNotNull("recommendedStorageProfileForDownload", this._RecommendedStorageProfileForDownload);
			kparams.AddIfNotNull("recommendedDcForDownload", this._RecommendedDcForDownload);
			kparams.AddIfNotNull("recommendedDcForExecute", this._RecommendedDcForExecute);
			kparams.AddIfNotNull("distributeTrigger", this._DistributeTrigger);
			kparams.AddIfNotNull("supportImageEntry", this._SupportImageEntry);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_ID:
					return "PartnerId";
				case PROVIDER_TYPE:
					return "ProviderType";
				case NAME:
					return "Name";
				case STATUS:
					return "Status";
				case SUBMIT_ENABLED:
					return "SubmitEnabled";
				case UPDATE_ENABLED:
					return "UpdateEnabled";
				case DELETE_ENABLED:
					return "DeleteEnabled";
				case REPORT_ENABLED:
					return "ReportEnabled";
				case AUTO_CREATE_FLAVORS:
					return "AutoCreateFlavors";
				case AUTO_CREATE_THUMB:
					return "AutoCreateThumb";
				case OPTIONAL_FLAVOR_PARAMS_IDS:
					return "OptionalFlavorParamsIds";
				case REQUIRED_FLAVOR_PARAMS_IDS:
					return "RequiredFlavorParamsIds";
				case OPTIONAL_THUMB_DIMENSIONS:
					return "OptionalThumbDimensions";
				case REQUIRED_THUMB_DIMENSIONS:
					return "RequiredThumbDimensions";
				case OPTIONAL_ASSET_DISTRIBUTION_RULES:
					return "OptionalAssetDistributionRules";
				case REQUIRED_ASSET_DISTRIBUTION_RULES:
					return "RequiredAssetDistributionRules";
				case SUNRISE_DEFAULT_OFFSET:
					return "SunriseDefaultOffset";
				case SUNSET_DEFAULT_OFFSET:
					return "SunsetDefaultOffset";
				case RECOMMENDED_STORAGE_PROFILE_FOR_DOWNLOAD:
					return "RecommendedStorageProfileForDownload";
				case RECOMMENDED_DC_FOR_DOWNLOAD:
					return "RecommendedDcForDownload";
				case RECOMMENDED_DC_FOR_EXECUTE:
					return "RecommendedDcForExecute";
				case DISTRIBUTE_TRIGGER:
					return "DistributeTrigger";
				case SUPPORT_IMAGE_ENTRY:
					return "SupportImageEntry";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

