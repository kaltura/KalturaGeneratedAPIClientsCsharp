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
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public DistributionProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public DistributionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public DistributionProfileActionStatus SubmitEnabled
		{
			get { return _SubmitEnabled; }
			set 
			{ 
				_SubmitEnabled = value;
				OnPropertyChanged("SubmitEnabled");
			}
		}
		public DistributionProfileActionStatus UpdateEnabled
		{
			get { return _UpdateEnabled; }
			set 
			{ 
				_UpdateEnabled = value;
				OnPropertyChanged("UpdateEnabled");
			}
		}
		public DistributionProfileActionStatus DeleteEnabled
		{
			get { return _DeleteEnabled; }
			set 
			{ 
				_DeleteEnabled = value;
				OnPropertyChanged("DeleteEnabled");
			}
		}
		public DistributionProfileActionStatus ReportEnabled
		{
			get { return _ReportEnabled; }
			set 
			{ 
				_ReportEnabled = value;
				OnPropertyChanged("ReportEnabled");
			}
		}
		public string AutoCreateFlavors
		{
			get { return _AutoCreateFlavors; }
			set 
			{ 
				_AutoCreateFlavors = value;
				OnPropertyChanged("AutoCreateFlavors");
			}
		}
		public string AutoCreateThumb
		{
			get { return _AutoCreateThumb; }
			set 
			{ 
				_AutoCreateThumb = value;
				OnPropertyChanged("AutoCreateThumb");
			}
		}
		public string OptionalFlavorParamsIds
		{
			get { return _OptionalFlavorParamsIds; }
			set 
			{ 
				_OptionalFlavorParamsIds = value;
				OnPropertyChanged("OptionalFlavorParamsIds");
			}
		}
		public string RequiredFlavorParamsIds
		{
			get { return _RequiredFlavorParamsIds; }
			set 
			{ 
				_RequiredFlavorParamsIds = value;
				OnPropertyChanged("RequiredFlavorParamsIds");
			}
		}
		public IList<DistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		public IList<DistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		public IList<AssetDistributionRule> OptionalAssetDistributionRules
		{
			get { return _OptionalAssetDistributionRules; }
			set 
			{ 
				_OptionalAssetDistributionRules = value;
				OnPropertyChanged("OptionalAssetDistributionRules");
			}
		}
		public IList<AssetDistributionRule> RequiredAssetDistributionRules
		{
			get { return _RequiredAssetDistributionRules; }
			set 
			{ 
				_RequiredAssetDistributionRules = value;
				OnPropertyChanged("RequiredAssetDistributionRules");
			}
		}
		public int SunriseDefaultOffset
		{
			get { return _SunriseDefaultOffset; }
			set 
			{ 
				_SunriseDefaultOffset = value;
				OnPropertyChanged("SunriseDefaultOffset");
			}
		}
		public int SunsetDefaultOffset
		{
			get { return _SunsetDefaultOffset; }
			set 
			{ 
				_SunsetDefaultOffset = value;
				OnPropertyChanged("SunsetDefaultOffset");
			}
		}
		public int RecommendedStorageProfileForDownload
		{
			get { return _RecommendedStorageProfileForDownload; }
			set 
			{ 
				_RecommendedStorageProfileForDownload = value;
				OnPropertyChanged("RecommendedStorageProfileForDownload");
			}
		}
		public int RecommendedDcForDownload
		{
			get { return _RecommendedDcForDownload; }
			set 
			{ 
				_RecommendedDcForDownload = value;
				OnPropertyChanged("RecommendedDcForDownload");
			}
		}
		public int RecommendedDcForExecute
		{
			get { return _RecommendedDcForExecute; }
			set 
			{ 
				_RecommendedDcForExecute = value;
				OnPropertyChanged("RecommendedDcForExecute");
			}
		}
		#endregion

		#region CTor
		public DistributionProfile()
		{
		}

		public DistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "providerType":
						this._ProviderType = (DistributionProviderType)StringEnum.Parse(typeof(DistributionProviderType), propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (DistributionProfileStatus)ParseEnum(typeof(DistributionProfileStatus), propertyNode.InnerText);
						continue;
					case "submitEnabled":
						this._SubmitEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), propertyNode.InnerText);
						continue;
					case "updateEnabled":
						this._UpdateEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), propertyNode.InnerText);
						continue;
					case "deleteEnabled":
						this._DeleteEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), propertyNode.InnerText);
						continue;
					case "reportEnabled":
						this._ReportEnabled = (DistributionProfileActionStatus)ParseEnum(typeof(DistributionProfileActionStatus), propertyNode.InnerText);
						continue;
					case "autoCreateFlavors":
						this._AutoCreateFlavors = propertyNode.InnerText;
						continue;
					case "autoCreateThumb":
						this._AutoCreateThumb = propertyNode.InnerText;
						continue;
					case "optionalFlavorParamsIds":
						this._OptionalFlavorParamsIds = propertyNode.InnerText;
						continue;
					case "requiredFlavorParamsIds":
						this._RequiredFlavorParamsIds = propertyNode.InnerText;
						continue;
					case "optionalThumbDimensions":
						this._OptionalThumbDimensions = new List<DistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
						}
						continue;
					case "requiredThumbDimensions":
						this._RequiredThumbDimensions = new List<DistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredThumbDimensions.Add(ObjectFactory.Create<DistributionThumbDimensions>(arrayNode));
						}
						continue;
					case "optionalAssetDistributionRules":
						this._OptionalAssetDistributionRules = new List<AssetDistributionRule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalAssetDistributionRules.Add(ObjectFactory.Create<AssetDistributionRule>(arrayNode));
						}
						continue;
					case "requiredAssetDistributionRules":
						this._RequiredAssetDistributionRules = new List<AssetDistributionRule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredAssetDistributionRules.Add(ObjectFactory.Create<AssetDistributionRule>(arrayNode));
						}
						continue;
					case "sunriseDefaultOffset":
						this._SunriseDefaultOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "sunsetDefaultOffset":
						this._SunsetDefaultOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "recommendedStorageProfileForDownload":
						this._RecommendedStorageProfileForDownload = ParseInt(propertyNode.InnerText);
						continue;
					case "recommendedDcForDownload":
						this._RecommendedDcForDownload = ParseInt(propertyNode.InnerText);
						continue;
					case "recommendedDcForExecute":
						this._RecommendedDcForExecute = ParseInt(propertyNode.InnerText);
						continue;
				}
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

