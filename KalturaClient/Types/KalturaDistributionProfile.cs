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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaDistributionProfile : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaDistributionProviderType _ProviderType = null;
		private string _Name = null;
		private KalturaDistributionProfileStatus _Status = (KalturaDistributionProfileStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _SubmitEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _UpdateEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _DeleteEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private KalturaDistributionProfileActionStatus _ReportEnabled = (KalturaDistributionProfileActionStatus)Int32.MinValue;
		private string _AutoCreateFlavors = null;
		private string _AutoCreateThumb = null;
		private string _OptionalFlavorParamsIds = null;
		private string _RequiredFlavorParamsIds = null;
		private IList<KalturaDistributionThumbDimensions> _OptionalThumbDimensions;
		private IList<KalturaDistributionThumbDimensions> _RequiredThumbDimensions;
		private IList<KalturaAssetDistributionRule> _OptionalAssetDistributionRules;
		private IList<KalturaAssetDistributionRule> _RequiredAssetDistributionRules;
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
		public KalturaDistributionProviderType ProviderType
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
		public KalturaDistributionProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaDistributionProfileActionStatus SubmitEnabled
		{
			get { return _SubmitEnabled; }
			set 
			{ 
				_SubmitEnabled = value;
				OnPropertyChanged("SubmitEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus UpdateEnabled
		{
			get { return _UpdateEnabled; }
			set 
			{ 
				_UpdateEnabled = value;
				OnPropertyChanged("UpdateEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus DeleteEnabled
		{
			get { return _DeleteEnabled; }
			set 
			{ 
				_DeleteEnabled = value;
				OnPropertyChanged("DeleteEnabled");
			}
		}
		public KalturaDistributionProfileActionStatus ReportEnabled
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
		public new IList<KalturaDistributionThumbDimensions> OptionalThumbDimensions
		{
			get { return _OptionalThumbDimensions; }
			set 
			{ 
				_OptionalThumbDimensions = value;
				OnPropertyChanged("OptionalThumbDimensions");
			}
		}
		public new IList<KalturaDistributionThumbDimensions> RequiredThumbDimensions
		{
			get { return _RequiredThumbDimensions; }
			set 
			{ 
				_RequiredThumbDimensions = value;
				OnPropertyChanged("RequiredThumbDimensions");
			}
		}
		public new IList<KalturaAssetDistributionRule> OptionalAssetDistributionRules
		{
			get { return _OptionalAssetDistributionRules; }
			set 
			{ 
				_OptionalAssetDistributionRules = value;
				OnPropertyChanged("OptionalAssetDistributionRules");
			}
		}
		public new IList<KalturaAssetDistributionRule> RequiredAssetDistributionRules
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
		public KalturaDistributionProfile()
		{
		}

		public KalturaDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "providerType":
						this._ProviderType = (KalturaDistributionProviderType)KalturaStringEnum.Parse(typeof(KalturaDistributionProviderType), txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "status":
						this._Status = (KalturaDistributionProfileStatus)ParseEnum(typeof(KalturaDistributionProfileStatus), txt);
						continue;
					case "submitEnabled":
						this._SubmitEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "updateEnabled":
						this._UpdateEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "deleteEnabled":
						this._DeleteEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "reportEnabled":
						this._ReportEnabled = (KalturaDistributionProfileActionStatus)ParseEnum(typeof(KalturaDistributionProfileActionStatus), txt);
						continue;
					case "autoCreateFlavors":
						this._AutoCreateFlavors = txt;
						continue;
					case "autoCreateThumb":
						this._AutoCreateThumb = txt;
						continue;
					case "optionalFlavorParamsIds":
						this._OptionalFlavorParamsIds = txt;
						continue;
					case "requiredFlavorParamsIds":
						this._RequiredFlavorParamsIds = txt;
						continue;
					case "optionalThumbDimensions":
						this._OptionalThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionThumbDimensions"));
						}
						continue;
					case "requiredThumbDimensions":
						this._RequiredThumbDimensions = new List<KalturaDistributionThumbDimensions>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredThumbDimensions.Add((KalturaDistributionThumbDimensions)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionThumbDimensions"));
						}
						continue;
					case "optionalAssetDistributionRules":
						this._OptionalAssetDistributionRules = new List<KalturaAssetDistributionRule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._OptionalAssetDistributionRules.Add((KalturaAssetDistributionRule)KalturaObjectFactory.Create(arrayNode, "KalturaAssetDistributionRule"));
						}
						continue;
					case "requiredAssetDistributionRules":
						this._RequiredAssetDistributionRules = new List<KalturaAssetDistributionRule>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredAssetDistributionRules.Add((KalturaAssetDistributionRule)KalturaObjectFactory.Create(arrayNode, "KalturaAssetDistributionRule"));
						}
						continue;
					case "sunriseDefaultOffset":
						this._SunriseDefaultOffset = ParseInt(txt);
						continue;
					case "sunsetDefaultOffset":
						this._SunsetDefaultOffset = ParseInt(txt);
						continue;
					case "recommendedStorageProfileForDownload":
						this._RecommendedStorageProfileForDownload = ParseInt(txt);
						continue;
					case "recommendedDcForDownload":
						this._RecommendedDcForDownload = ParseInt(txt);
						continue;
					case "recommendedDcForExecute":
						this._RecommendedDcForExecute = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

