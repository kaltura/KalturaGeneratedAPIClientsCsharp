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
	public class KalturaCategory : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _ParentId = Int32.MinValue;
		private int _Depth = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _FullName = null;
		private string _FullIds = null;
		private int _EntriesCount = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _Description = null;
		private string _Tags = null;
		private KalturaAppearInListType _AppearInList = (KalturaAppearInListType)Int32.MinValue;
		private KalturaPrivacyType _Privacy = (KalturaPrivacyType)Int32.MinValue;
		private KalturaInheritanceType _InheritanceType = (KalturaInheritanceType)Int32.MinValue;
		private KalturaUserJoinPolicyType _UserJoinPolicy = (KalturaUserJoinPolicyType)Int32.MinValue;
		private KalturaCategoryUserPermissionLevel _DefaultPermissionLevel = (KalturaCategoryUserPermissionLevel)Int32.MinValue;
		private string _Owner = null;
		private int _DirectEntriesCount = Int32.MinValue;
		private string _ReferenceId = null;
		private KalturaContributionPolicyType _ContributionPolicy = (KalturaContributionPolicyType)Int32.MinValue;
		private int _MembersCount = Int32.MinValue;
		private int _PendingMembersCount = Int32.MinValue;
		private string _PrivacyContext = null;
		private string _PrivacyContexts = null;
		private KalturaCategoryStatus _Status = (KalturaCategoryStatus)Int32.MinValue;
		private int _InheritedParentId = Int32.MinValue;
		private int _PartnerSortValue = Int32.MinValue;
		private string _PartnerData = null;
		private KalturaCategoryOrderBy _DefaultOrderBy = null;
		private int _DirectSubCategoriesCount = Int32.MinValue;
		private KalturaNullableBoolean _Moderation = (KalturaNullableBoolean)Int32.MinValue;
		private int _PendingEntriesCount = Int32.MinValue;
		private KalturaNullableBoolean _IsAggregationCategory = (KalturaNullableBoolean)Int32.MinValue;
		private string _AggregationCategories = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public int Depth
		{
			get { return _Depth; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
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
		public string FullName
		{
			get { return _FullName; }
		}
		public string FullIds
		{
			get { return _FullIds; }
		}
		public int EntriesCount
		{
			get { return _EntriesCount; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public KalturaAppearInListType AppearInList
		{
			get { return _AppearInList; }
			set 
			{ 
				_AppearInList = value;
				OnPropertyChanged("AppearInList");
			}
		}
		public KalturaPrivacyType Privacy
		{
			get { return _Privacy; }
			set 
			{ 
				_Privacy = value;
				OnPropertyChanged("Privacy");
			}
		}
		public KalturaInheritanceType InheritanceType
		{
			get { return _InheritanceType; }
			set 
			{ 
				_InheritanceType = value;
				OnPropertyChanged("InheritanceType");
			}
		}
		public KalturaUserJoinPolicyType UserJoinPolicy
		{
			get { return _UserJoinPolicy; }
		}
		public KalturaCategoryUserPermissionLevel DefaultPermissionLevel
		{
			get { return _DefaultPermissionLevel; }
			set 
			{ 
				_DefaultPermissionLevel = value;
				OnPropertyChanged("DefaultPermissionLevel");
			}
		}
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		public int DirectEntriesCount
		{
			get { return _DirectEntriesCount; }
		}
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
			}
		}
		public KalturaContributionPolicyType ContributionPolicy
		{
			get { return _ContributionPolicy; }
			set 
			{ 
				_ContributionPolicy = value;
				OnPropertyChanged("ContributionPolicy");
			}
		}
		public int MembersCount
		{
			get { return _MembersCount; }
		}
		public int PendingMembersCount
		{
			get { return _PendingMembersCount; }
		}
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
			}
		}
		public string PrivacyContexts
		{
			get { return _PrivacyContexts; }
		}
		public KalturaCategoryStatus Status
		{
			get { return _Status; }
		}
		public int InheritedParentId
		{
			get { return _InheritedParentId; }
		}
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public KalturaCategoryOrderBy DefaultOrderBy
		{
			get { return _DefaultOrderBy; }
			set 
			{ 
				_DefaultOrderBy = value;
				OnPropertyChanged("DefaultOrderBy");
			}
		}
		public int DirectSubCategoriesCount
		{
			get { return _DirectSubCategoriesCount; }
		}
		public KalturaNullableBoolean Moderation
		{
			get { return _Moderation; }
			set 
			{ 
				_Moderation = value;
				OnPropertyChanged("Moderation");
			}
		}
		public int PendingEntriesCount
		{
			get { return _PendingEntriesCount; }
		}
		public KalturaNullableBoolean IsAggregationCategory
		{
			get { return _IsAggregationCategory; }
			set 
			{ 
				_IsAggregationCategory = value;
				OnPropertyChanged("IsAggregationCategory");
			}
		}
		public string AggregationCategories
		{
			get { return _AggregationCategories; }
			set 
			{ 
				_AggregationCategories = value;
				OnPropertyChanged("AggregationCategories");
			}
		}
		#endregion

		#region CTor
		public KalturaCategory()
		{
		}

		public KalturaCategory(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "parentId":
						this._ParentId = ParseInt(txt);
						continue;
					case "depth":
						this._Depth = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "fullName":
						this._FullName = txt;
						continue;
					case "fullIds":
						this._FullIds = txt;
						continue;
					case "entriesCount":
						this._EntriesCount = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "appearInList":
						this._AppearInList = (KalturaAppearInListType)ParseEnum(typeof(KalturaAppearInListType), txt);
						continue;
					case "privacy":
						this._Privacy = (KalturaPrivacyType)ParseEnum(typeof(KalturaPrivacyType), txt);
						continue;
					case "inheritanceType":
						this._InheritanceType = (KalturaInheritanceType)ParseEnum(typeof(KalturaInheritanceType), txt);
						continue;
					case "userJoinPolicy":
						this._UserJoinPolicy = (KalturaUserJoinPolicyType)ParseEnum(typeof(KalturaUserJoinPolicyType), txt);
						continue;
					case "defaultPermissionLevel":
						this._DefaultPermissionLevel = (KalturaCategoryUserPermissionLevel)ParseEnum(typeof(KalturaCategoryUserPermissionLevel), txt);
						continue;
					case "owner":
						this._Owner = txt;
						continue;
					case "directEntriesCount":
						this._DirectEntriesCount = ParseInt(txt);
						continue;
					case "referenceId":
						this._ReferenceId = txt;
						continue;
					case "contributionPolicy":
						this._ContributionPolicy = (KalturaContributionPolicyType)ParseEnum(typeof(KalturaContributionPolicyType), txt);
						continue;
					case "membersCount":
						this._MembersCount = ParseInt(txt);
						continue;
					case "pendingMembersCount":
						this._PendingMembersCount = ParseInt(txt);
						continue;
					case "privacyContext":
						this._PrivacyContext = txt;
						continue;
					case "privacyContexts":
						this._PrivacyContexts = txt;
						continue;
					case "status":
						this._Status = (KalturaCategoryStatus)ParseEnum(typeof(KalturaCategoryStatus), txt);
						continue;
					case "inheritedParentId":
						this._InheritedParentId = ParseInt(txt);
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(txt);
						continue;
					case "partnerData":
						this._PartnerData = txt;
						continue;
					case "defaultOrderBy":
						this._DefaultOrderBy = (KalturaCategoryOrderBy)KalturaStringEnum.Parse(typeof(KalturaCategoryOrderBy), txt);
						continue;
					case "directSubCategoriesCount":
						this._DirectSubCategoriesCount = ParseInt(txt);
						continue;
					case "moderation":
						this._Moderation = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "pendingEntriesCount":
						this._PendingEntriesCount = ParseInt(txt);
						continue;
					case "isAggregationCategory":
						this._IsAggregationCategory = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "aggregationCategories":
						this._AggregationCategories = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategory");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("parentId", this.ParentId);
			kparams.AddIfNotNull("depth", this.Depth);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("fullName", this.FullName);
			kparams.AddIfNotNull("fullIds", this.FullIds);
			kparams.AddIfNotNull("entriesCount", this.EntriesCount);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("appearInList", this.AppearInList);
			kparams.AddIfNotNull("privacy", this.Privacy);
			kparams.AddIfNotNull("inheritanceType", this.InheritanceType);
			kparams.AddIfNotNull("userJoinPolicy", this.UserJoinPolicy);
			kparams.AddIfNotNull("defaultPermissionLevel", this.DefaultPermissionLevel);
			kparams.AddIfNotNull("owner", this.Owner);
			kparams.AddIfNotNull("directEntriesCount", this.DirectEntriesCount);
			kparams.AddIfNotNull("referenceId", this.ReferenceId);
			kparams.AddIfNotNull("contributionPolicy", this.ContributionPolicy);
			kparams.AddIfNotNull("membersCount", this.MembersCount);
			kparams.AddIfNotNull("pendingMembersCount", this.PendingMembersCount);
			kparams.AddIfNotNull("privacyContext", this.PrivacyContext);
			kparams.AddIfNotNull("privacyContexts", this.PrivacyContexts);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("inheritedParentId", this.InheritedParentId);
			kparams.AddIfNotNull("partnerSortValue", this.PartnerSortValue);
			kparams.AddIfNotNull("partnerData", this.PartnerData);
			kparams.AddIfNotNull("defaultOrderBy", this.DefaultOrderBy);
			kparams.AddIfNotNull("directSubCategoriesCount", this.DirectSubCategoriesCount);
			kparams.AddIfNotNull("moderation", this.Moderation);
			kparams.AddIfNotNull("pendingEntriesCount", this.PendingEntriesCount);
			kparams.AddIfNotNull("isAggregationCategory", this.IsAggregationCategory);
			kparams.AddIfNotNull("aggregationCategories", this.AggregationCategories);
			return kparams;
		}
		#endregion
	}
}

