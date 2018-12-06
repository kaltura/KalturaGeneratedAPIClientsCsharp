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
	public class Category : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARENT_ID = "parentId";
		public const string DEPTH = "depth";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string FULL_NAME = "fullName";
		public const string FULL_IDS = "fullIds";
		public const string ENTRIES_COUNT = "entriesCount";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string APPEAR_IN_LIST = "appearInList";
		public const string PRIVACY = "privacy";
		public const string INHERITANCE_TYPE = "inheritanceType";
		public const string USER_JOIN_POLICY = "userJoinPolicy";
		public const string DEFAULT_PERMISSION_LEVEL = "defaultPermissionLevel";
		public const string OWNER = "owner";
		public const string DIRECT_ENTRIES_COUNT = "directEntriesCount";
		public const string REFERENCE_ID = "referenceId";
		public const string CONTRIBUTION_POLICY = "contributionPolicy";
		public const string MEMBERS_COUNT = "membersCount";
		public const string PENDING_MEMBERS_COUNT = "pendingMembersCount";
		public const string PRIVACY_CONTEXT = "privacyContext";
		public const string PRIVACY_CONTEXTS = "privacyContexts";
		public const string STATUS = "status";
		public const string INHERITED_PARENT_ID = "inheritedParentId";
		public const string PARTNER_SORT_VALUE = "partnerSortValue";
		public const string PARTNER_DATA = "partnerData";
		public const string DEFAULT_ORDER_BY = "defaultOrderBy";
		public const string DIRECT_SUB_CATEGORIES_COUNT = "directSubCategoriesCount";
		public const string MODERATION = "moderation";
		public const string PENDING_ENTRIES_COUNT = "pendingEntriesCount";
		public const string IS_AGGREGATION_CATEGORY = "isAggregationCategory";
		public const string AGGREGATION_CATEGORIES = "aggregationCategories";
		#endregion

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
		private AppearInListType _AppearInList = (AppearInListType)Int32.MinValue;
		private PrivacyType _Privacy = (PrivacyType)Int32.MinValue;
		private InheritanceType _InheritanceType = (InheritanceType)Int32.MinValue;
		private UserJoinPolicyType _UserJoinPolicy = (UserJoinPolicyType)Int32.MinValue;
		private CategoryUserPermissionLevel _DefaultPermissionLevel = (CategoryUserPermissionLevel)Int32.MinValue;
		private string _Owner = null;
		private int _DirectEntriesCount = Int32.MinValue;
		private string _ReferenceId = null;
		private ContributionPolicyType _ContributionPolicy = (ContributionPolicyType)Int32.MinValue;
		private int _MembersCount = Int32.MinValue;
		private int _PendingMembersCount = Int32.MinValue;
		private string _PrivacyContext = null;
		private string _PrivacyContexts = null;
		private CategoryStatus _Status = (CategoryStatus)Int32.MinValue;
		private int _InheritedParentId = Int32.MinValue;
		private int _PartnerSortValue = Int32.MinValue;
		private string _PartnerData = null;
		private CategoryOrderBy _DefaultOrderBy = null;
		private int _DirectSubCategoriesCount = Int32.MinValue;
		private NullableBoolean _Moderation = (NullableBoolean)Int32.MinValue;
		private int _PendingEntriesCount = Int32.MinValue;
		private NullableBoolean _IsAggregationCategory = (NullableBoolean)Int32.MinValue;
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
		public AppearInListType AppearInList
		{
			get { return _AppearInList; }
			set 
			{ 
				_AppearInList = value;
				OnPropertyChanged("AppearInList");
			}
		}
		public PrivacyType Privacy
		{
			get { return _Privacy; }
			set 
			{ 
				_Privacy = value;
				OnPropertyChanged("Privacy");
			}
		}
		public InheritanceType InheritanceType
		{
			get { return _InheritanceType; }
			set 
			{ 
				_InheritanceType = value;
				OnPropertyChanged("InheritanceType");
			}
		}
		public UserJoinPolicyType UserJoinPolicy
		{
			get { return _UserJoinPolicy; }
		}
		public CategoryUserPermissionLevel DefaultPermissionLevel
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
		public ContributionPolicyType ContributionPolicy
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
		public CategoryStatus Status
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
		public CategoryOrderBy DefaultOrderBy
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
		public NullableBoolean Moderation
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
		public NullableBoolean IsAggregationCategory
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
		public Category()
		{
		}

		public Category(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "parentId":
						this._ParentId = ParseInt(propertyNode.InnerText);
						continue;
					case "depth":
						this._Depth = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "fullName":
						this._FullName = propertyNode.InnerText;
						continue;
					case "fullIds":
						this._FullIds = propertyNode.InnerText;
						continue;
					case "entriesCount":
						this._EntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "appearInList":
						this._AppearInList = (AppearInListType)ParseEnum(typeof(AppearInListType), propertyNode.InnerText);
						continue;
					case "privacy":
						this._Privacy = (PrivacyType)ParseEnum(typeof(PrivacyType), propertyNode.InnerText);
						continue;
					case "inheritanceType":
						this._InheritanceType = (InheritanceType)ParseEnum(typeof(InheritanceType), propertyNode.InnerText);
						continue;
					case "userJoinPolicy":
						this._UserJoinPolicy = (UserJoinPolicyType)ParseEnum(typeof(UserJoinPolicyType), propertyNode.InnerText);
						continue;
					case "defaultPermissionLevel":
						this._DefaultPermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), propertyNode.InnerText);
						continue;
					case "owner":
						this._Owner = propertyNode.InnerText;
						continue;
					case "directEntriesCount":
						this._DirectEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "referenceId":
						this._ReferenceId = propertyNode.InnerText;
						continue;
					case "contributionPolicy":
						this._ContributionPolicy = (ContributionPolicyType)ParseEnum(typeof(ContributionPolicyType), propertyNode.InnerText);
						continue;
					case "membersCount":
						this._MembersCount = ParseInt(propertyNode.InnerText);
						continue;
					case "pendingMembersCount":
						this._PendingMembersCount = ParseInt(propertyNode.InnerText);
						continue;
					case "privacyContext":
						this._PrivacyContext = propertyNode.InnerText;
						continue;
					case "privacyContexts":
						this._PrivacyContexts = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (CategoryStatus)ParseEnum(typeof(CategoryStatus), propertyNode.InnerText);
						continue;
					case "inheritedParentId":
						this._InheritedParentId = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "defaultOrderBy":
						this._DefaultOrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), propertyNode.InnerText);
						continue;
					case "directSubCategoriesCount":
						this._DirectSubCategoriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "moderation":
						this._Moderation = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "pendingEntriesCount":
						this._PendingEntriesCount = ParseInt(propertyNode.InnerText);
						continue;
					case "isAggregationCategory":
						this._IsAggregationCategory = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "aggregationCategories":
						this._AggregationCategories = propertyNode.InnerText;
						continue;
				}
			}
		}

		public Category(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._ParentId = data.TryGetValueSafe<int>("parentId");
			    this._Depth = data.TryGetValueSafe<int>("depth");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._FullName = data.TryGetValueSafe<string>("fullName");
			    this._FullIds = data.TryGetValueSafe<string>("fullIds");
			    this._EntriesCount = data.TryGetValueSafe<int>("entriesCount");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._AppearInList = (AppearInListType)ParseEnum(typeof(AppearInListType), data.TryGetValueSafe<int>("appearInList"));
			    this._Privacy = (PrivacyType)ParseEnum(typeof(PrivacyType), data.TryGetValueSafe<int>("privacy"));
			    this._InheritanceType = (InheritanceType)ParseEnum(typeof(InheritanceType), data.TryGetValueSafe<int>("inheritanceType"));
			    this._UserJoinPolicy = (UserJoinPolicyType)ParseEnum(typeof(UserJoinPolicyType), data.TryGetValueSafe<int>("userJoinPolicy"));
			    this._DefaultPermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), data.TryGetValueSafe<int>("defaultPermissionLevel"));
			    this._Owner = data.TryGetValueSafe<string>("owner");
			    this._DirectEntriesCount = data.TryGetValueSafe<int>("directEntriesCount");
			    this._ReferenceId = data.TryGetValueSafe<string>("referenceId");
			    this._ContributionPolicy = (ContributionPolicyType)ParseEnum(typeof(ContributionPolicyType), data.TryGetValueSafe<int>("contributionPolicy"));
			    this._MembersCount = data.TryGetValueSafe<int>("membersCount");
			    this._PendingMembersCount = data.TryGetValueSafe<int>("pendingMembersCount");
			    this._PrivacyContext = data.TryGetValueSafe<string>("privacyContext");
			    this._PrivacyContexts = data.TryGetValueSafe<string>("privacyContexts");
			    this._Status = (CategoryStatus)ParseEnum(typeof(CategoryStatus), data.TryGetValueSafe<int>("status"));
			    this._InheritedParentId = data.TryGetValueSafe<int>("inheritedParentId");
			    this._PartnerSortValue = data.TryGetValueSafe<int>("partnerSortValue");
			    this._PartnerData = data.TryGetValueSafe<string>("partnerData");
			    this._DefaultOrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), data.TryGetValueSafe<string>("defaultOrderBy"));
			    this._DirectSubCategoriesCount = data.TryGetValueSafe<int>("directSubCategoriesCount");
			    this._Moderation = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("moderation"));
			    this._PendingEntriesCount = data.TryGetValueSafe<int>("pendingEntriesCount");
			    this._IsAggregationCategory = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("isAggregationCategory"));
			    this._AggregationCategories = data.TryGetValueSafe<string>("aggregationCategories");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategory");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("depth", this._Depth);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("fullName", this._FullName);
			kparams.AddIfNotNull("fullIds", this._FullIds);
			kparams.AddIfNotNull("entriesCount", this._EntriesCount);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("appearInList", this._AppearInList);
			kparams.AddIfNotNull("privacy", this._Privacy);
			kparams.AddIfNotNull("inheritanceType", this._InheritanceType);
			kparams.AddIfNotNull("userJoinPolicy", this._UserJoinPolicy);
			kparams.AddIfNotNull("defaultPermissionLevel", this._DefaultPermissionLevel);
			kparams.AddIfNotNull("owner", this._Owner);
			kparams.AddIfNotNull("directEntriesCount", this._DirectEntriesCount);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("contributionPolicy", this._ContributionPolicy);
			kparams.AddIfNotNull("membersCount", this._MembersCount);
			kparams.AddIfNotNull("pendingMembersCount", this._PendingMembersCount);
			kparams.AddIfNotNull("privacyContext", this._PrivacyContext);
			kparams.AddIfNotNull("privacyContexts", this._PrivacyContexts);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("inheritedParentId", this._InheritedParentId);
			kparams.AddIfNotNull("partnerSortValue", this._PartnerSortValue);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("defaultOrderBy", this._DefaultOrderBy);
			kparams.AddIfNotNull("directSubCategoriesCount", this._DirectSubCategoriesCount);
			kparams.AddIfNotNull("moderation", this._Moderation);
			kparams.AddIfNotNull("pendingEntriesCount", this._PendingEntriesCount);
			kparams.AddIfNotNull("isAggregationCategory", this._IsAggregationCategory);
			kparams.AddIfNotNull("aggregationCategories", this._AggregationCategories);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARENT_ID:
					return "ParentId";
				case DEPTH:
					return "Depth";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case FULL_NAME:
					return "FullName";
				case FULL_IDS:
					return "FullIds";
				case ENTRIES_COUNT:
					return "EntriesCount";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case APPEAR_IN_LIST:
					return "AppearInList";
				case PRIVACY:
					return "Privacy";
				case INHERITANCE_TYPE:
					return "InheritanceType";
				case USER_JOIN_POLICY:
					return "UserJoinPolicy";
				case DEFAULT_PERMISSION_LEVEL:
					return "DefaultPermissionLevel";
				case OWNER:
					return "Owner";
				case DIRECT_ENTRIES_COUNT:
					return "DirectEntriesCount";
				case REFERENCE_ID:
					return "ReferenceId";
				case CONTRIBUTION_POLICY:
					return "ContributionPolicy";
				case MEMBERS_COUNT:
					return "MembersCount";
				case PENDING_MEMBERS_COUNT:
					return "PendingMembersCount";
				case PRIVACY_CONTEXT:
					return "PrivacyContext";
				case PRIVACY_CONTEXTS:
					return "PrivacyContexts";
				case STATUS:
					return "Status";
				case INHERITED_PARENT_ID:
					return "InheritedParentId";
				case PARTNER_SORT_VALUE:
					return "PartnerSortValue";
				case PARTNER_DATA:
					return "PartnerData";
				case DEFAULT_ORDER_BY:
					return "DefaultOrderBy";
				case DIRECT_SUB_CATEGORIES_COUNT:
					return "DirectSubCategoriesCount";
				case MODERATION:
					return "Moderation";
				case PENDING_ENTRIES_COUNT:
					return "PendingEntriesCount";
				case IS_AGGREGATION_CATEGORY:
					return "IsAggregationCategory";
				case AGGREGATION_CATEGORIES:
					return "AggregationCategories";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

