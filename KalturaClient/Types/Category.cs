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
// Copyright (C) 2006-2022  Kaltura Inc.
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
		public const string ADMIN_TAGS = "adminTags";
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
		private string _AdminTags = null;
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
		/// Use ParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		/// <summary>
		/// Use DepthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Depth
		{
			get { return _Depth; }
			private set 
			{ 
				_Depth = value;
				OnPropertyChanged("Depth");
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
		/// Use FullNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FullName
		{
			get { return _FullName; }
			private set 
			{ 
				_FullName = value;
				OnPropertyChanged("FullName");
			}
		}
		/// <summary>
		/// Use FullIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FullIds
		{
			get { return _FullIds; }
			private set 
			{ 
				_FullIds = value;
				OnPropertyChanged("FullIds");
			}
		}
		/// <summary>
		/// Use EntriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EntriesCount
		{
			get { return _EntriesCount; }
			private set 
			{ 
				_EntriesCount = value;
				OnPropertyChanged("EntriesCount");
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
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		/// <summary>
		/// Use AppearInListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AppearInListType AppearInList
		{
			get { return _AppearInList; }
			set 
			{ 
				_AppearInList = value;
				OnPropertyChanged("AppearInList");
			}
		}
		/// <summary>
		/// Use PrivacyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PrivacyType Privacy
		{
			get { return _Privacy; }
			set 
			{ 
				_Privacy = value;
				OnPropertyChanged("Privacy");
			}
		}
		/// <summary>
		/// Use InheritanceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public InheritanceType InheritanceType
		{
			get { return _InheritanceType; }
			set 
			{ 
				_InheritanceType = value;
				OnPropertyChanged("InheritanceType");
			}
		}
		/// <summary>
		/// Use UserJoinPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserJoinPolicyType UserJoinPolicy
		{
			get { return _UserJoinPolicy; }
			private set 
			{ 
				_UserJoinPolicy = value;
				OnPropertyChanged("UserJoinPolicy");
			}
		}
		/// <summary>
		/// Use DefaultPermissionLevelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CategoryUserPermissionLevel DefaultPermissionLevel
		{
			get { return _DefaultPermissionLevel; }
			set 
			{ 
				_DefaultPermissionLevel = value;
				OnPropertyChanged("DefaultPermissionLevel");
			}
		}
		/// <summary>
		/// Use OwnerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Owner
		{
			get { return _Owner; }
			set 
			{ 
				_Owner = value;
				OnPropertyChanged("Owner");
			}
		}
		/// <summary>
		/// Use DirectEntriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DirectEntriesCount
		{
			get { return _DirectEntriesCount; }
			private set 
			{ 
				_DirectEntriesCount = value;
				OnPropertyChanged("DirectEntriesCount");
			}
		}
		/// <summary>
		/// Use ReferenceIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
			}
		}
		/// <summary>
		/// Use ContributionPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ContributionPolicyType ContributionPolicy
		{
			get { return _ContributionPolicy; }
			set 
			{ 
				_ContributionPolicy = value;
				OnPropertyChanged("ContributionPolicy");
			}
		}
		/// <summary>
		/// Use MembersCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MembersCount
		{
			get { return _MembersCount; }
			private set 
			{ 
				_MembersCount = value;
				OnPropertyChanged("MembersCount");
			}
		}
		/// <summary>
		/// Use PendingMembersCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PendingMembersCount
		{
			get { return _PendingMembersCount; }
			private set 
			{ 
				_PendingMembersCount = value;
				OnPropertyChanged("PendingMembersCount");
			}
		}
		/// <summary>
		/// Use PrivacyContextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrivacyContext
		{
			get { return _PrivacyContext; }
			set 
			{ 
				_PrivacyContext = value;
				OnPropertyChanged("PrivacyContext");
			}
		}
		/// <summary>
		/// Use PrivacyContextsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrivacyContexts
		{
			get { return _PrivacyContexts; }
			private set 
			{ 
				_PrivacyContexts = value;
				OnPropertyChanged("PrivacyContexts");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CategoryStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use InheritedParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int InheritedParentId
		{
			get { return _InheritedParentId; }
			private set 
			{ 
				_InheritedParentId = value;
				OnPropertyChanged("InheritedParentId");
			}
		}
		/// <summary>
		/// Use PartnerSortValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use DefaultOrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CategoryOrderBy DefaultOrderBy
		{
			get { return _DefaultOrderBy; }
			set 
			{ 
				_DefaultOrderBy = value;
				OnPropertyChanged("DefaultOrderBy");
			}
		}
		/// <summary>
		/// Use DirectSubCategoriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DirectSubCategoriesCount
		{
			get { return _DirectSubCategoriesCount; }
			private set 
			{ 
				_DirectSubCategoriesCount = value;
				OnPropertyChanged("DirectSubCategoriesCount");
			}
		}
		/// <summary>
		/// Use ModerationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean Moderation
		{
			get { return _Moderation; }
			set 
			{ 
				_Moderation = value;
				OnPropertyChanged("Moderation");
			}
		}
		/// <summary>
		/// Use PendingEntriesCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PendingEntriesCount
		{
			get { return _PendingEntriesCount; }
			private set 
			{ 
				_PendingEntriesCount = value;
				OnPropertyChanged("PendingEntriesCount");
			}
		}
		/// <summary>
		/// Use IsAggregationCategoryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsAggregationCategory
		{
			get { return _IsAggregationCategory; }
			set 
			{ 
				_IsAggregationCategory = value;
				OnPropertyChanged("IsAggregationCategory");
			}
		}
		/// <summary>
		/// Use AggregationCategoriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AggregationCategories
		{
			get { return _AggregationCategories; }
			set 
			{ 
				_AggregationCategories = value;
				OnPropertyChanged("AggregationCategories");
			}
		}
		/// <summary>
		/// Use AdminTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminTags
		{
			get { return _AdminTags; }
			set 
			{ 
				_AdminTags = value;
				OnPropertyChanged("AdminTags");
			}
		}
		#endregion

		#region CTor
		public Category()
		{
		}

		public Category(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["parentId"] != null)
			{
				this._ParentId = ParseInt(node["parentId"].Value<string>());
			}
			if(node["depth"] != null)
			{
				this._Depth = ParseInt(node["depth"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["fullName"] != null)
			{
				this._FullName = node["fullName"].Value<string>();
			}
			if(node["fullIds"] != null)
			{
				this._FullIds = node["fullIds"].Value<string>();
			}
			if(node["entriesCount"] != null)
			{
				this._EntriesCount = ParseInt(node["entriesCount"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["appearInList"] != null)
			{
				this._AppearInList = (AppearInListType)ParseEnum(typeof(AppearInListType), node["appearInList"].Value<string>());
			}
			if(node["privacy"] != null)
			{
				this._Privacy = (PrivacyType)ParseEnum(typeof(PrivacyType), node["privacy"].Value<string>());
			}
			if(node["inheritanceType"] != null)
			{
				this._InheritanceType = (InheritanceType)ParseEnum(typeof(InheritanceType), node["inheritanceType"].Value<string>());
			}
			if(node["userJoinPolicy"] != null)
			{
				this._UserJoinPolicy = (UserJoinPolicyType)ParseEnum(typeof(UserJoinPolicyType), node["userJoinPolicy"].Value<string>());
			}
			if(node["defaultPermissionLevel"] != null)
			{
				this._DefaultPermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), node["defaultPermissionLevel"].Value<string>());
			}
			if(node["owner"] != null)
			{
				this._Owner = node["owner"].Value<string>();
			}
			if(node["directEntriesCount"] != null)
			{
				this._DirectEntriesCount = ParseInt(node["directEntriesCount"].Value<string>());
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["contributionPolicy"] != null)
			{
				this._ContributionPolicy = (ContributionPolicyType)ParseEnum(typeof(ContributionPolicyType), node["contributionPolicy"].Value<string>());
			}
			if(node["membersCount"] != null)
			{
				this._MembersCount = ParseInt(node["membersCount"].Value<string>());
			}
			if(node["pendingMembersCount"] != null)
			{
				this._PendingMembersCount = ParseInt(node["pendingMembersCount"].Value<string>());
			}
			if(node["privacyContext"] != null)
			{
				this._PrivacyContext = node["privacyContext"].Value<string>();
			}
			if(node["privacyContexts"] != null)
			{
				this._PrivacyContexts = node["privacyContexts"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (CategoryStatus)ParseEnum(typeof(CategoryStatus), node["status"].Value<string>());
			}
			if(node["inheritedParentId"] != null)
			{
				this._InheritedParentId = ParseInt(node["inheritedParentId"].Value<string>());
			}
			if(node["partnerSortValue"] != null)
			{
				this._PartnerSortValue = ParseInt(node["partnerSortValue"].Value<string>());
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["defaultOrderBy"] != null)
			{
				this._DefaultOrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), node["defaultOrderBy"].Value<string>());
			}
			if(node["directSubCategoriesCount"] != null)
			{
				this._DirectSubCategoriesCount = ParseInt(node["directSubCategoriesCount"].Value<string>());
			}
			if(node["moderation"] != null)
			{
				this._Moderation = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["moderation"].Value<string>());
			}
			if(node["pendingEntriesCount"] != null)
			{
				this._PendingEntriesCount = ParseInt(node["pendingEntriesCount"].Value<string>());
			}
			if(node["isAggregationCategory"] != null)
			{
				this._IsAggregationCategory = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isAggregationCategory"].Value<string>());
			}
			if(node["aggregationCategories"] != null)
			{
				this._AggregationCategories = node["aggregationCategories"].Value<string>();
			}
			if(node["adminTags"] != null)
			{
				this._AdminTags = node["adminTags"].Value<string>();
			}
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
			kparams.AddIfNotNull("adminTags", this._AdminTags);
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
				case ADMIN_TAGS:
					return "AdminTags";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

