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
	public class BaseEntryBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string ID_NOT_IN = "idNotIn";
		public const string NAME_LIKE = "nameLike";
		public const string NAME_MULTI_LIKE_OR = "nameMultiLikeOr";
		public const string NAME_MULTI_LIKE_AND = "nameMultiLikeAnd";
		public const string NAME_EQUAL = "nameEqual";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string USER_ID_NOT_IN = "userIdNotIn";
		public const string CREATOR_ID_EQUAL = "creatorIdEqual";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string ADMIN_TAGS_LIKE = "adminTagsLike";
		public const string ADMIN_TAGS_MULTI_LIKE_OR = "adminTagsMultiLikeOr";
		public const string ADMIN_TAGS_MULTI_LIKE_AND = "adminTagsMultiLikeAnd";
		public const string CATEGORIES_MATCH_AND = "categoriesMatchAnd";
		public const string CATEGORIES_MATCH_OR = "categoriesMatchOr";
		public const string CATEGORIES_NOT_CONTAINS = "categoriesNotContains";
		public const string CATEGORIES_IDS_MATCH_AND = "categoriesIdsMatchAnd";
		public const string CATEGORIES_IDS_MATCH_OR = "categoriesIdsMatchOr";
		public const string CATEGORIES_IDS_NOT_CONTAINS = "categoriesIdsNotContains";
		public const string CATEGORIES_IDS_EMPTY = "categoriesIdsEmpty";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_NOT_EQUAL = "statusNotEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_NOT_IN = "statusNotIn";
		public const string MODERATION_STATUS_EQUAL = "moderationStatusEqual";
		public const string MODERATION_STATUS_NOT_EQUAL = "moderationStatusNotEqual";
		public const string MODERATION_STATUS_IN = "moderationStatusIn";
		public const string MODERATION_STATUS_NOT_IN = "moderationStatusNotIn";
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string TOTAL_RANK_LESS_THAN_OR_EQUAL = "totalRankLessThanOrEqual";
		public const string TOTAL_RANK_GREATER_THAN_OR_EQUAL = "totalRankGreaterThanOrEqual";
		public const string GROUP_ID_EQUAL = "groupIdEqual";
		public const string SEARCH_TEXT_MATCH_AND = "searchTextMatchAnd";
		public const string SEARCH_TEXT_MATCH_OR = "searchTextMatchOr";
		public const string ACCESS_CONTROL_ID_EQUAL = "accessControlIdEqual";
		public const string ACCESS_CONTROL_ID_IN = "accessControlIdIn";
		public const string START_DATE_GREATER_THAN_OR_EQUAL = "startDateGreaterThanOrEqual";
		public const string START_DATE_LESS_THAN_OR_EQUAL = "startDateLessThanOrEqual";
		public const string START_DATE_GREATER_THAN_OR_EQUAL_OR_NULL = "startDateGreaterThanOrEqualOrNull";
		public const string START_DATE_LESS_THAN_OR_EQUAL_OR_NULL = "startDateLessThanOrEqualOrNull";
		public const string END_DATE_GREATER_THAN_OR_EQUAL = "endDateGreaterThanOrEqual";
		public const string END_DATE_LESS_THAN_OR_EQUAL = "endDateLessThanOrEqual";
		public const string END_DATE_GREATER_THAN_OR_EQUAL_OR_NULL = "endDateGreaterThanOrEqualOrNull";
		public const string END_DATE_LESS_THAN_OR_EQUAL_OR_NULL = "endDateLessThanOrEqualOrNull";
		public const string REFERENCE_ID_EQUAL = "referenceIdEqual";
		public const string REFERENCE_ID_IN = "referenceIdIn";
		public const string REPLACING_ENTRY_ID_EQUAL = "replacingEntryIdEqual";
		public const string REPLACING_ENTRY_ID_IN = "replacingEntryIdIn";
		public const string REPLACED_ENTRY_ID_EQUAL = "replacedEntryIdEqual";
		public const string REPLACED_ENTRY_ID_IN = "replacedEntryIdIn";
		public const string REPLACEMENT_STATUS_EQUAL = "replacementStatusEqual";
		public const string REPLACEMENT_STATUS_IN = "replacementStatusIn";
		public const string PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL = "partnerSortValueGreaterThanOrEqual";
		public const string PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL = "partnerSortValueLessThanOrEqual";
		public const string ROOT_ENTRY_ID_EQUAL = "rootEntryIdEqual";
		public const string ROOT_ENTRY_ID_IN = "rootEntryIdIn";
		public const string PARENT_ENTRY_ID_EQUAL = "parentEntryIdEqual";
		public const string ENTITLED_USERS_EDIT_MATCH_AND = "entitledUsersEditMatchAnd";
		public const string ENTITLED_USERS_EDIT_MATCH_OR = "entitledUsersEditMatchOr";
		public const string ENTITLED_USERS_PUBLISH_MATCH_AND = "entitledUsersPublishMatchAnd";
		public const string ENTITLED_USERS_PUBLISH_MATCH_OR = "entitledUsersPublishMatchOr";
		public const string ENTITLED_USERS_VIEW_MATCH_AND = "entitledUsersViewMatchAnd";
		public const string ENTITLED_USERS_VIEW_MATCH_OR = "entitledUsersViewMatchOr";
		public const string TAGS_NAME_MULTI_LIKE_OR = "tagsNameMultiLikeOr";
		public const string TAGS_ADMIN_TAGS_MULTI_LIKE_OR = "tagsAdminTagsMultiLikeOr";
		public const string TAGS_ADMIN_TAGS_NAME_MULTI_LIKE_OR = "tagsAdminTagsNameMultiLikeOr";
		public const string TAGS_NAME_MULTI_LIKE_AND = "tagsNameMultiLikeAnd";
		public const string TAGS_ADMIN_TAGS_MULTI_LIKE_AND = "tagsAdminTagsMultiLikeAnd";
		public const string TAGS_ADMIN_TAGS_NAME_MULTI_LIKE_AND = "tagsAdminTagsNameMultiLikeAnd";
		#endregion

		#region Private Fields
		private string _IdEqual = null;
		private string _IdIn = null;
		private string _IdNotIn = null;
		private string _NameLike = null;
		private string _NameMultiLikeOr = null;
		private string _NameMultiLikeAnd = null;
		private string _NameEqual = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private string _UserIdNotIn = null;
		private string _CreatorIdEqual = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private string _AdminTagsLike = null;
		private string _AdminTagsMultiLikeOr = null;
		private string _AdminTagsMultiLikeAnd = null;
		private string _CategoriesMatchAnd = null;
		private string _CategoriesMatchOr = null;
		private string _CategoriesNotContains = null;
		private string _CategoriesIdsMatchAnd = null;
		private string _CategoriesIdsMatchOr = null;
		private string _CategoriesIdsNotContains = null;
		private NullableBoolean _CategoriesIdsEmpty = (NullableBoolean)Int32.MinValue;
		private EntryStatus _StatusEqual = null;
		private EntryStatus _StatusNotEqual = null;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private EntryModerationStatus _ModerationStatusEqual = (EntryModerationStatus)Int32.MinValue;
		private EntryModerationStatus _ModerationStatusNotEqual = (EntryModerationStatus)Int32.MinValue;
		private string _ModerationStatusIn = null;
		private string _ModerationStatusNotIn = null;
		private EntryType _TypeEqual = null;
		private string _TypeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _TotalRankLessThanOrEqual = Int32.MinValue;
		private int _TotalRankGreaterThanOrEqual = Int32.MinValue;
		private int _GroupIdEqual = Int32.MinValue;
		private string _SearchTextMatchAnd = null;
		private string _SearchTextMatchOr = null;
		private int _AccessControlIdEqual = Int32.MinValue;
		private string _AccessControlIdIn = null;
		private int _StartDateGreaterThanOrEqual = Int32.MinValue;
		private int _StartDateLessThanOrEqual = Int32.MinValue;
		private int _StartDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _StartDateLessThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateGreaterThanOrEqual = Int32.MinValue;
		private int _EndDateLessThanOrEqual = Int32.MinValue;
		private int _EndDateGreaterThanOrEqualOrNull = Int32.MinValue;
		private int _EndDateLessThanOrEqualOrNull = Int32.MinValue;
		private string _ReferenceIdEqual = null;
		private string _ReferenceIdIn = null;
		private string _ReplacingEntryIdEqual = null;
		private string _ReplacingEntryIdIn = null;
		private string _ReplacedEntryIdEqual = null;
		private string _ReplacedEntryIdIn = null;
		private EntryReplacementStatus _ReplacementStatusEqual = null;
		private string _ReplacementStatusIn = null;
		private int _PartnerSortValueGreaterThanOrEqual = Int32.MinValue;
		private int _PartnerSortValueLessThanOrEqual = Int32.MinValue;
		private string _RootEntryIdEqual = null;
		private string _RootEntryIdIn = null;
		private string _ParentEntryIdEqual = null;
		private string _EntitledUsersEditMatchAnd = null;
		private string _EntitledUsersEditMatchOr = null;
		private string _EntitledUsersPublishMatchAnd = null;
		private string _EntitledUsersPublishMatchOr = null;
		private string _EntitledUsersViewMatchAnd = null;
		private string _EntitledUsersViewMatchOr = null;
		private string _TagsNameMultiLikeOr = null;
		private string _TagsAdminTagsMultiLikeOr = null;
		private string _TagsAdminTagsNameMultiLikeOr = null;
		private string _TagsNameMultiLikeAnd = null;
		private string _TagsAdminTagsMultiLikeAnd = null;
		private string _TagsAdminTagsNameMultiLikeAnd = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		[JsonProperty]
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		[JsonProperty]
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		[JsonProperty]
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		[JsonProperty]
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		[JsonProperty]
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		[JsonProperty]
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		[JsonProperty]
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		[JsonProperty]
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		[JsonProperty]
		public string UserIdNotIn
		{
			get { return _UserIdNotIn; }
			set 
			{ 
				_UserIdNotIn = value;
				OnPropertyChanged("UserIdNotIn");
			}
		}
		[JsonProperty]
		public string CreatorIdEqual
		{
			get { return _CreatorIdEqual; }
			set 
			{ 
				_CreatorIdEqual = value;
				OnPropertyChanged("CreatorIdEqual");
			}
		}
		[JsonProperty]
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string AdminTagsLike
		{
			get { return _AdminTagsLike; }
			set 
			{ 
				_AdminTagsLike = value;
				OnPropertyChanged("AdminTagsLike");
			}
		}
		[JsonProperty]
		public string AdminTagsMultiLikeOr
		{
			get { return _AdminTagsMultiLikeOr; }
			set 
			{ 
				_AdminTagsMultiLikeOr = value;
				OnPropertyChanged("AdminTagsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string AdminTagsMultiLikeAnd
		{
			get { return _AdminTagsMultiLikeAnd; }
			set 
			{ 
				_AdminTagsMultiLikeAnd = value;
				OnPropertyChanged("AdminTagsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string CategoriesMatchAnd
		{
			get { return _CategoriesMatchAnd; }
			set 
			{ 
				_CategoriesMatchAnd = value;
				OnPropertyChanged("CategoriesMatchAnd");
			}
		}
		[JsonProperty]
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		[JsonProperty]
		public string CategoriesNotContains
		{
			get { return _CategoriesNotContains; }
			set 
			{ 
				_CategoriesNotContains = value;
				OnPropertyChanged("CategoriesNotContains");
			}
		}
		[JsonProperty]
		public string CategoriesIdsMatchAnd
		{
			get { return _CategoriesIdsMatchAnd; }
			set 
			{ 
				_CategoriesIdsMatchAnd = value;
				OnPropertyChanged("CategoriesIdsMatchAnd");
			}
		}
		[JsonProperty]
		public string CategoriesIdsMatchOr
		{
			get { return _CategoriesIdsMatchOr; }
			set 
			{ 
				_CategoriesIdsMatchOr = value;
				OnPropertyChanged("CategoriesIdsMatchOr");
			}
		}
		[JsonProperty]
		public string CategoriesIdsNotContains
		{
			get { return _CategoriesIdsNotContains; }
			set 
			{ 
				_CategoriesIdsNotContains = value;
				OnPropertyChanged("CategoriesIdsNotContains");
			}
		}
		[JsonProperty]
		public NullableBoolean CategoriesIdsEmpty
		{
			get { return _CategoriesIdsEmpty; }
			set 
			{ 
				_CategoriesIdsEmpty = value;
				OnPropertyChanged("CategoriesIdsEmpty");
			}
		}
		[JsonProperty]
		public EntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public EntryStatus StatusNotEqual
		{
			get { return _StatusNotEqual; }
			set 
			{ 
				_StatusNotEqual = value;
				OnPropertyChanged("StatusNotEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		[JsonProperty]
		public EntryModerationStatus ModerationStatusEqual
		{
			get { return _ModerationStatusEqual; }
			set 
			{ 
				_ModerationStatusEqual = value;
				OnPropertyChanged("ModerationStatusEqual");
			}
		}
		[JsonProperty]
		public EntryModerationStatus ModerationStatusNotEqual
		{
			get { return _ModerationStatusNotEqual; }
			set 
			{ 
				_ModerationStatusNotEqual = value;
				OnPropertyChanged("ModerationStatusNotEqual");
			}
		}
		[JsonProperty]
		public string ModerationStatusIn
		{
			get { return _ModerationStatusIn; }
			set 
			{ 
				_ModerationStatusIn = value;
				OnPropertyChanged("ModerationStatusIn");
			}
		}
		[JsonProperty]
		public string ModerationStatusNotIn
		{
			get { return _ModerationStatusNotIn; }
			set 
			{ 
				_ModerationStatusNotIn = value;
				OnPropertyChanged("ModerationStatusNotIn");
			}
		}
		[JsonProperty]
		public EntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		[JsonProperty]
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int TotalRankLessThanOrEqual
		{
			get { return _TotalRankLessThanOrEqual; }
			set 
			{ 
				_TotalRankLessThanOrEqual = value;
				OnPropertyChanged("TotalRankLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int TotalRankGreaterThanOrEqual
		{
			get { return _TotalRankGreaterThanOrEqual; }
			set 
			{ 
				_TotalRankGreaterThanOrEqual = value;
				OnPropertyChanged("TotalRankGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int GroupIdEqual
		{
			get { return _GroupIdEqual; }
			set 
			{ 
				_GroupIdEqual = value;
				OnPropertyChanged("GroupIdEqual");
			}
		}
		[JsonProperty]
		public string SearchTextMatchAnd
		{
			get { return _SearchTextMatchAnd; }
			set 
			{ 
				_SearchTextMatchAnd = value;
				OnPropertyChanged("SearchTextMatchAnd");
			}
		}
		[JsonProperty]
		public string SearchTextMatchOr
		{
			get { return _SearchTextMatchOr; }
			set 
			{ 
				_SearchTextMatchOr = value;
				OnPropertyChanged("SearchTextMatchOr");
			}
		}
		[JsonProperty]
		public int AccessControlIdEqual
		{
			get { return _AccessControlIdEqual; }
			set 
			{ 
				_AccessControlIdEqual = value;
				OnPropertyChanged("AccessControlIdEqual");
			}
		}
		[JsonProperty]
		public string AccessControlIdIn
		{
			get { return _AccessControlIdIn; }
			set 
			{ 
				_AccessControlIdIn = value;
				OnPropertyChanged("AccessControlIdIn");
			}
		}
		[JsonProperty]
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int StartDateGreaterThanOrEqualOrNull
		{
			get { return _StartDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_StartDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateGreaterThanOrEqualOrNull");
			}
		}
		[JsonProperty]
		public int StartDateLessThanOrEqualOrNull
		{
			get { return _StartDateLessThanOrEqualOrNull; }
			set 
			{ 
				_StartDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateLessThanOrEqualOrNull");
			}
		}
		[JsonProperty]
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int EndDateGreaterThanOrEqualOrNull
		{
			get { return _EndDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_EndDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateGreaterThanOrEqualOrNull");
			}
		}
		[JsonProperty]
		public int EndDateLessThanOrEqualOrNull
		{
			get { return _EndDateLessThanOrEqualOrNull; }
			set 
			{ 
				_EndDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateLessThanOrEqualOrNull");
			}
		}
		[JsonProperty]
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		[JsonProperty]
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		[JsonProperty]
		public string ReplacingEntryIdEqual
		{
			get { return _ReplacingEntryIdEqual; }
			set 
			{ 
				_ReplacingEntryIdEqual = value;
				OnPropertyChanged("ReplacingEntryIdEqual");
			}
		}
		[JsonProperty]
		public string ReplacingEntryIdIn
		{
			get { return _ReplacingEntryIdIn; }
			set 
			{ 
				_ReplacingEntryIdIn = value;
				OnPropertyChanged("ReplacingEntryIdIn");
			}
		}
		[JsonProperty]
		public string ReplacedEntryIdEqual
		{
			get { return _ReplacedEntryIdEqual; }
			set 
			{ 
				_ReplacedEntryIdEqual = value;
				OnPropertyChanged("ReplacedEntryIdEqual");
			}
		}
		[JsonProperty]
		public string ReplacedEntryIdIn
		{
			get { return _ReplacedEntryIdIn; }
			set 
			{ 
				_ReplacedEntryIdIn = value;
				OnPropertyChanged("ReplacedEntryIdIn");
			}
		}
		[JsonProperty]
		public EntryReplacementStatus ReplacementStatusEqual
		{
			get { return _ReplacementStatusEqual; }
			set 
			{ 
				_ReplacementStatusEqual = value;
				OnPropertyChanged("ReplacementStatusEqual");
			}
		}
		[JsonProperty]
		public string ReplacementStatusIn
		{
			get { return _ReplacementStatusIn; }
			set 
			{ 
				_ReplacementStatusIn = value;
				OnPropertyChanged("ReplacementStatusIn");
			}
		}
		[JsonProperty]
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		[JsonProperty]
		public string RootEntryIdEqual
		{
			get { return _RootEntryIdEqual; }
			set 
			{ 
				_RootEntryIdEqual = value;
				OnPropertyChanged("RootEntryIdEqual");
			}
		}
		[JsonProperty]
		public string RootEntryIdIn
		{
			get { return _RootEntryIdIn; }
			set 
			{ 
				_RootEntryIdIn = value;
				OnPropertyChanged("RootEntryIdIn");
			}
		}
		[JsonProperty]
		public string ParentEntryIdEqual
		{
			get { return _ParentEntryIdEqual; }
			set 
			{ 
				_ParentEntryIdEqual = value;
				OnPropertyChanged("ParentEntryIdEqual");
			}
		}
		[JsonProperty]
		public string EntitledUsersEditMatchAnd
		{
			get { return _EntitledUsersEditMatchAnd; }
			set 
			{ 
				_EntitledUsersEditMatchAnd = value;
				OnPropertyChanged("EntitledUsersEditMatchAnd");
			}
		}
		[JsonProperty]
		public string EntitledUsersEditMatchOr
		{
			get { return _EntitledUsersEditMatchOr; }
			set 
			{ 
				_EntitledUsersEditMatchOr = value;
				OnPropertyChanged("EntitledUsersEditMatchOr");
			}
		}
		[JsonProperty]
		public string EntitledUsersPublishMatchAnd
		{
			get { return _EntitledUsersPublishMatchAnd; }
			set 
			{ 
				_EntitledUsersPublishMatchAnd = value;
				OnPropertyChanged("EntitledUsersPublishMatchAnd");
			}
		}
		[JsonProperty]
		public string EntitledUsersPublishMatchOr
		{
			get { return _EntitledUsersPublishMatchOr; }
			set 
			{ 
				_EntitledUsersPublishMatchOr = value;
				OnPropertyChanged("EntitledUsersPublishMatchOr");
			}
		}
		[JsonProperty]
		public string EntitledUsersViewMatchAnd
		{
			get { return _EntitledUsersViewMatchAnd; }
			set 
			{ 
				_EntitledUsersViewMatchAnd = value;
				OnPropertyChanged("EntitledUsersViewMatchAnd");
			}
		}
		[JsonProperty]
		public string EntitledUsersViewMatchOr
		{
			get { return _EntitledUsersViewMatchOr; }
			set 
			{ 
				_EntitledUsersViewMatchOr = value;
				OnPropertyChanged("EntitledUsersViewMatchOr");
			}
		}
		[JsonProperty]
		public string TagsNameMultiLikeOr
		{
			get { return _TagsNameMultiLikeOr; }
			set 
			{ 
				_TagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsNameMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsAdminTagsMultiLikeOr
		{
			get { return _TagsAdminTagsMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsAdminTagsNameMultiLikeOr
		{
			get { return _TagsAdminTagsNameMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsNameMultiLikeAnd
		{
			get { return _TagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsNameMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string TagsAdminTagsMultiLikeAnd
		{
			get { return _TagsAdminTagsMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string TagsAdminTagsNameMultiLikeAnd
		{
			get { return _TagsAdminTagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public BaseEntryBaseFilter()
		{
		}

		public BaseEntryBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = node["idEqual"].Value<string>();
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["idNotIn"] != null)
			{
				this._IdNotIn = node["idNotIn"].Value<string>();
			}
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["nameMultiLikeOr"] != null)
			{
				this._NameMultiLikeOr = node["nameMultiLikeOr"].Value<string>();
			}
			if(node["nameMultiLikeAnd"] != null)
			{
				this._NameMultiLikeAnd = node["nameMultiLikeAnd"].Value<string>();
			}
			if(node["nameEqual"] != null)
			{
				this._NameEqual = node["nameEqual"].Value<string>();
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["userIdIn"] != null)
			{
				this._UserIdIn = node["userIdIn"].Value<string>();
			}
			if(node["userIdNotIn"] != null)
			{
				this._UserIdNotIn = node["userIdNotIn"].Value<string>();
			}
			if(node["creatorIdEqual"] != null)
			{
				this._CreatorIdEqual = node["creatorIdEqual"].Value<string>();
			}
			if(node["tagsLike"] != null)
			{
				this._TagsLike = node["tagsLike"].Value<string>();
			}
			if(node["tagsMultiLikeOr"] != null)
			{
				this._TagsMultiLikeOr = node["tagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsMultiLikeAnd"] != null)
			{
				this._TagsMultiLikeAnd = node["tagsMultiLikeAnd"].Value<string>();
			}
			if(node["adminTagsLike"] != null)
			{
				this._AdminTagsLike = node["adminTagsLike"].Value<string>();
			}
			if(node["adminTagsMultiLikeOr"] != null)
			{
				this._AdminTagsMultiLikeOr = node["adminTagsMultiLikeOr"].Value<string>();
			}
			if(node["adminTagsMultiLikeAnd"] != null)
			{
				this._AdminTagsMultiLikeAnd = node["adminTagsMultiLikeAnd"].Value<string>();
			}
			if(node["categoriesMatchAnd"] != null)
			{
				this._CategoriesMatchAnd = node["categoriesMatchAnd"].Value<string>();
			}
			if(node["categoriesMatchOr"] != null)
			{
				this._CategoriesMatchOr = node["categoriesMatchOr"].Value<string>();
			}
			if(node["categoriesNotContains"] != null)
			{
				this._CategoriesNotContains = node["categoriesNotContains"].Value<string>();
			}
			if(node["categoriesIdsMatchAnd"] != null)
			{
				this._CategoriesIdsMatchAnd = node["categoriesIdsMatchAnd"].Value<string>();
			}
			if(node["categoriesIdsMatchOr"] != null)
			{
				this._CategoriesIdsMatchOr = node["categoriesIdsMatchOr"].Value<string>();
			}
			if(node["categoriesIdsNotContains"] != null)
			{
				this._CategoriesIdsNotContains = node["categoriesIdsNotContains"].Value<string>();
			}
			if(node["categoriesIdsEmpty"] != null)
			{
				this._CategoriesIdsEmpty = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["categoriesIdsEmpty"].Value<string>());
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusNotEqual"] != null)
			{
				this._StatusNotEqual = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), node["statusNotEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["statusNotIn"] != null)
			{
				this._StatusNotIn = node["statusNotIn"].Value<string>();
			}
			if(node["moderationStatusEqual"] != null)
			{
				this._ModerationStatusEqual = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), node["moderationStatusEqual"].Value<string>());
			}
			if(node["moderationStatusNotEqual"] != null)
			{
				this._ModerationStatusNotEqual = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), node["moderationStatusNotEqual"].Value<string>());
			}
			if(node["moderationStatusIn"] != null)
			{
				this._ModerationStatusIn = node["moderationStatusIn"].Value<string>();
			}
			if(node["moderationStatusNotIn"] != null)
			{
				this._ModerationStatusNotIn = node["moderationStatusNotIn"].Value<string>();
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (EntryType)StringEnum.Parse(typeof(EntryType), node["typeEqual"].Value<string>());
			}
			if(node["typeIn"] != null)
			{
				this._TypeIn = node["typeIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["totalRankLessThanOrEqual"] != null)
			{
				this._TotalRankLessThanOrEqual = ParseInt(node["totalRankLessThanOrEqual"].Value<string>());
			}
			if(node["totalRankGreaterThanOrEqual"] != null)
			{
				this._TotalRankGreaterThanOrEqual = ParseInt(node["totalRankGreaterThanOrEqual"].Value<string>());
			}
			if(node["groupIdEqual"] != null)
			{
				this._GroupIdEqual = ParseInt(node["groupIdEqual"].Value<string>());
			}
			if(node["searchTextMatchAnd"] != null)
			{
				this._SearchTextMatchAnd = node["searchTextMatchAnd"].Value<string>();
			}
			if(node["searchTextMatchOr"] != null)
			{
				this._SearchTextMatchOr = node["searchTextMatchOr"].Value<string>();
			}
			if(node["accessControlIdEqual"] != null)
			{
				this._AccessControlIdEqual = ParseInt(node["accessControlIdEqual"].Value<string>());
			}
			if(node["accessControlIdIn"] != null)
			{
				this._AccessControlIdIn = node["accessControlIdIn"].Value<string>();
			}
			if(node["startDateGreaterThanOrEqual"] != null)
			{
				this._StartDateGreaterThanOrEqual = ParseInt(node["startDateGreaterThanOrEqual"].Value<string>());
			}
			if(node["startDateLessThanOrEqual"] != null)
			{
				this._StartDateLessThanOrEqual = ParseInt(node["startDateLessThanOrEqual"].Value<string>());
			}
			if(node["startDateGreaterThanOrEqualOrNull"] != null)
			{
				this._StartDateGreaterThanOrEqualOrNull = ParseInt(node["startDateGreaterThanOrEqualOrNull"].Value<string>());
			}
			if(node["startDateLessThanOrEqualOrNull"] != null)
			{
				this._StartDateLessThanOrEqualOrNull = ParseInt(node["startDateLessThanOrEqualOrNull"].Value<string>());
			}
			if(node["endDateGreaterThanOrEqual"] != null)
			{
				this._EndDateGreaterThanOrEqual = ParseInt(node["endDateGreaterThanOrEqual"].Value<string>());
			}
			if(node["endDateLessThanOrEqual"] != null)
			{
				this._EndDateLessThanOrEqual = ParseInt(node["endDateLessThanOrEqual"].Value<string>());
			}
			if(node["endDateGreaterThanOrEqualOrNull"] != null)
			{
				this._EndDateGreaterThanOrEqualOrNull = ParseInt(node["endDateGreaterThanOrEqualOrNull"].Value<string>());
			}
			if(node["endDateLessThanOrEqualOrNull"] != null)
			{
				this._EndDateLessThanOrEqualOrNull = ParseInt(node["endDateLessThanOrEqualOrNull"].Value<string>());
			}
			if(node["referenceIdEqual"] != null)
			{
				this._ReferenceIdEqual = node["referenceIdEqual"].Value<string>();
			}
			if(node["referenceIdIn"] != null)
			{
				this._ReferenceIdIn = node["referenceIdIn"].Value<string>();
			}
			if(node["replacingEntryIdEqual"] != null)
			{
				this._ReplacingEntryIdEqual = node["replacingEntryIdEqual"].Value<string>();
			}
			if(node["replacingEntryIdIn"] != null)
			{
				this._ReplacingEntryIdIn = node["replacingEntryIdIn"].Value<string>();
			}
			if(node["replacedEntryIdEqual"] != null)
			{
				this._ReplacedEntryIdEqual = node["replacedEntryIdEqual"].Value<string>();
			}
			if(node["replacedEntryIdIn"] != null)
			{
				this._ReplacedEntryIdIn = node["replacedEntryIdIn"].Value<string>();
			}
			if(node["replacementStatusEqual"] != null)
			{
				this._ReplacementStatusEqual = (EntryReplacementStatus)StringEnum.Parse(typeof(EntryReplacementStatus), node["replacementStatusEqual"].Value<string>());
			}
			if(node["replacementStatusIn"] != null)
			{
				this._ReplacementStatusIn = node["replacementStatusIn"].Value<string>();
			}
			if(node["partnerSortValueGreaterThanOrEqual"] != null)
			{
				this._PartnerSortValueGreaterThanOrEqual = ParseInt(node["partnerSortValueGreaterThanOrEqual"].Value<string>());
			}
			if(node["partnerSortValueLessThanOrEqual"] != null)
			{
				this._PartnerSortValueLessThanOrEqual = ParseInt(node["partnerSortValueLessThanOrEqual"].Value<string>());
			}
			if(node["rootEntryIdEqual"] != null)
			{
				this._RootEntryIdEqual = node["rootEntryIdEqual"].Value<string>();
			}
			if(node["rootEntryIdIn"] != null)
			{
				this._RootEntryIdIn = node["rootEntryIdIn"].Value<string>();
			}
			if(node["parentEntryIdEqual"] != null)
			{
				this._ParentEntryIdEqual = node["parentEntryIdEqual"].Value<string>();
			}
			if(node["entitledUsersEditMatchAnd"] != null)
			{
				this._EntitledUsersEditMatchAnd = node["entitledUsersEditMatchAnd"].Value<string>();
			}
			if(node["entitledUsersEditMatchOr"] != null)
			{
				this._EntitledUsersEditMatchOr = node["entitledUsersEditMatchOr"].Value<string>();
			}
			if(node["entitledUsersPublishMatchAnd"] != null)
			{
				this._EntitledUsersPublishMatchAnd = node["entitledUsersPublishMatchAnd"].Value<string>();
			}
			if(node["entitledUsersPublishMatchOr"] != null)
			{
				this._EntitledUsersPublishMatchOr = node["entitledUsersPublishMatchOr"].Value<string>();
			}
			if(node["entitledUsersViewMatchAnd"] != null)
			{
				this._EntitledUsersViewMatchAnd = node["entitledUsersViewMatchAnd"].Value<string>();
			}
			if(node["entitledUsersViewMatchOr"] != null)
			{
				this._EntitledUsersViewMatchOr = node["entitledUsersViewMatchOr"].Value<string>();
			}
			if(node["tagsNameMultiLikeOr"] != null)
			{
				this._TagsNameMultiLikeOr = node["tagsNameMultiLikeOr"].Value<string>();
			}
			if(node["tagsAdminTagsMultiLikeOr"] != null)
			{
				this._TagsAdminTagsMultiLikeOr = node["tagsAdminTagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsAdminTagsNameMultiLikeOr"] != null)
			{
				this._TagsAdminTagsNameMultiLikeOr = node["tagsAdminTagsNameMultiLikeOr"].Value<string>();
			}
			if(node["tagsNameMultiLikeAnd"] != null)
			{
				this._TagsNameMultiLikeAnd = node["tagsNameMultiLikeAnd"].Value<string>();
			}
			if(node["tagsAdminTagsMultiLikeAnd"] != null)
			{
				this._TagsAdminTagsMultiLikeAnd = node["tagsAdminTagsMultiLikeAnd"].Value<string>();
			}
			if(node["tagsAdminTagsNameMultiLikeAnd"] != null)
			{
				this._TagsAdminTagsNameMultiLikeAnd = node["tagsAdminTagsNameMultiLikeAnd"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseEntryBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("idNotIn", this._IdNotIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("nameMultiLikeOr", this._NameMultiLikeOr);
			kparams.AddIfNotNull("nameMultiLikeAnd", this._NameMultiLikeAnd);
			kparams.AddIfNotNull("nameEqual", this._NameEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("userIdNotIn", this._UserIdNotIn);
			kparams.AddIfNotNull("creatorIdEqual", this._CreatorIdEqual);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("adminTagsLike", this._AdminTagsLike);
			kparams.AddIfNotNull("adminTagsMultiLikeOr", this._AdminTagsMultiLikeOr);
			kparams.AddIfNotNull("adminTagsMultiLikeAnd", this._AdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("categoriesMatchAnd", this._CategoriesMatchAnd);
			kparams.AddIfNotNull("categoriesMatchOr", this._CategoriesMatchOr);
			kparams.AddIfNotNull("categoriesNotContains", this._CategoriesNotContains);
			kparams.AddIfNotNull("categoriesIdsMatchAnd", this._CategoriesIdsMatchAnd);
			kparams.AddIfNotNull("categoriesIdsMatchOr", this._CategoriesIdsMatchOr);
			kparams.AddIfNotNull("categoriesIdsNotContains", this._CategoriesIdsNotContains);
			kparams.AddIfNotNull("categoriesIdsEmpty", this._CategoriesIdsEmpty);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusNotEqual", this._StatusNotEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			kparams.AddIfNotNull("moderationStatusEqual", this._ModerationStatusEqual);
			kparams.AddIfNotNull("moderationStatusNotEqual", this._ModerationStatusNotEqual);
			kparams.AddIfNotNull("moderationStatusIn", this._ModerationStatusIn);
			kparams.AddIfNotNull("moderationStatusNotIn", this._ModerationStatusNotIn);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("totalRankLessThanOrEqual", this._TotalRankLessThanOrEqual);
			kparams.AddIfNotNull("totalRankGreaterThanOrEqual", this._TotalRankGreaterThanOrEqual);
			kparams.AddIfNotNull("groupIdEqual", this._GroupIdEqual);
			kparams.AddIfNotNull("searchTextMatchAnd", this._SearchTextMatchAnd);
			kparams.AddIfNotNull("searchTextMatchOr", this._SearchTextMatchOr);
			kparams.AddIfNotNull("accessControlIdEqual", this._AccessControlIdEqual);
			kparams.AddIfNotNull("accessControlIdIn", this._AccessControlIdIn);
			kparams.AddIfNotNull("startDateGreaterThanOrEqual", this._StartDateGreaterThanOrEqual);
			kparams.AddIfNotNull("startDateLessThanOrEqual", this._StartDateLessThanOrEqual);
			kparams.AddIfNotNull("startDateGreaterThanOrEqualOrNull", this._StartDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("startDateLessThanOrEqualOrNull", this._StartDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateGreaterThanOrEqual", this._EndDateGreaterThanOrEqual);
			kparams.AddIfNotNull("endDateLessThanOrEqual", this._EndDateLessThanOrEqual);
			kparams.AddIfNotNull("endDateGreaterThanOrEqualOrNull", this._EndDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateLessThanOrEqualOrNull", this._EndDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("referenceIdEqual", this._ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdIn", this._ReferenceIdIn);
			kparams.AddIfNotNull("replacingEntryIdEqual", this._ReplacingEntryIdEqual);
			kparams.AddIfNotNull("replacingEntryIdIn", this._ReplacingEntryIdIn);
			kparams.AddIfNotNull("replacedEntryIdEqual", this._ReplacedEntryIdEqual);
			kparams.AddIfNotNull("replacedEntryIdIn", this._ReplacedEntryIdIn);
			kparams.AddIfNotNull("replacementStatusEqual", this._ReplacementStatusEqual);
			kparams.AddIfNotNull("replacementStatusIn", this._ReplacementStatusIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this._PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this._PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("rootEntryIdEqual", this._RootEntryIdEqual);
			kparams.AddIfNotNull("rootEntryIdIn", this._RootEntryIdIn);
			kparams.AddIfNotNull("parentEntryIdEqual", this._ParentEntryIdEqual);
			kparams.AddIfNotNull("entitledUsersEditMatchAnd", this._EntitledUsersEditMatchAnd);
			kparams.AddIfNotNull("entitledUsersEditMatchOr", this._EntitledUsersEditMatchOr);
			kparams.AddIfNotNull("entitledUsersPublishMatchAnd", this._EntitledUsersPublishMatchAnd);
			kparams.AddIfNotNull("entitledUsersPublishMatchOr", this._EntitledUsersPublishMatchOr);
			kparams.AddIfNotNull("entitledUsersViewMatchAnd", this._EntitledUsersViewMatchAnd);
			kparams.AddIfNotNull("entitledUsersViewMatchOr", this._EntitledUsersViewMatchOr);
			kparams.AddIfNotNull("tagsNameMultiLikeOr", this._TagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeOr", this._TagsAdminTagsMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeOr", this._TagsAdminTagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsNameMultiLikeAnd", this._TagsNameMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeAnd", this._TagsAdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeAnd", this._TagsAdminTagsNameMultiLikeAnd);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case ID_NOT_IN:
					return "IdNotIn";
				case NAME_LIKE:
					return "NameLike";
				case NAME_MULTI_LIKE_OR:
					return "NameMultiLikeOr";
				case NAME_MULTI_LIKE_AND:
					return "NameMultiLikeAnd";
				case NAME_EQUAL:
					return "NameEqual";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case USER_ID_NOT_IN:
					return "UserIdNotIn";
				case CREATOR_ID_EQUAL:
					return "CreatorIdEqual";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case ADMIN_TAGS_LIKE:
					return "AdminTagsLike";
				case ADMIN_TAGS_MULTI_LIKE_OR:
					return "AdminTagsMultiLikeOr";
				case ADMIN_TAGS_MULTI_LIKE_AND:
					return "AdminTagsMultiLikeAnd";
				case CATEGORIES_MATCH_AND:
					return "CategoriesMatchAnd";
				case CATEGORIES_MATCH_OR:
					return "CategoriesMatchOr";
				case CATEGORIES_NOT_CONTAINS:
					return "CategoriesNotContains";
				case CATEGORIES_IDS_MATCH_AND:
					return "CategoriesIdsMatchAnd";
				case CATEGORIES_IDS_MATCH_OR:
					return "CategoriesIdsMatchOr";
				case CATEGORIES_IDS_NOT_CONTAINS:
					return "CategoriesIdsNotContains";
				case CATEGORIES_IDS_EMPTY:
					return "CategoriesIdsEmpty";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_NOT_EQUAL:
					return "StatusNotEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_NOT_IN:
					return "StatusNotIn";
				case MODERATION_STATUS_EQUAL:
					return "ModerationStatusEqual";
				case MODERATION_STATUS_NOT_EQUAL:
					return "ModerationStatusNotEqual";
				case MODERATION_STATUS_IN:
					return "ModerationStatusIn";
				case MODERATION_STATUS_NOT_IN:
					return "ModerationStatusNotIn";
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case TOTAL_RANK_LESS_THAN_OR_EQUAL:
					return "TotalRankLessThanOrEqual";
				case TOTAL_RANK_GREATER_THAN_OR_EQUAL:
					return "TotalRankGreaterThanOrEqual";
				case GROUP_ID_EQUAL:
					return "GroupIdEqual";
				case SEARCH_TEXT_MATCH_AND:
					return "SearchTextMatchAnd";
				case SEARCH_TEXT_MATCH_OR:
					return "SearchTextMatchOr";
				case ACCESS_CONTROL_ID_EQUAL:
					return "AccessControlIdEqual";
				case ACCESS_CONTROL_ID_IN:
					return "AccessControlIdIn";
				case START_DATE_GREATER_THAN_OR_EQUAL:
					return "StartDateGreaterThanOrEqual";
				case START_DATE_LESS_THAN_OR_EQUAL:
					return "StartDateLessThanOrEqual";
				case START_DATE_GREATER_THAN_OR_EQUAL_OR_NULL:
					return "StartDateGreaterThanOrEqualOrNull";
				case START_DATE_LESS_THAN_OR_EQUAL_OR_NULL:
					return "StartDateLessThanOrEqualOrNull";
				case END_DATE_GREATER_THAN_OR_EQUAL:
					return "EndDateGreaterThanOrEqual";
				case END_DATE_LESS_THAN_OR_EQUAL:
					return "EndDateLessThanOrEqual";
				case END_DATE_GREATER_THAN_OR_EQUAL_OR_NULL:
					return "EndDateGreaterThanOrEqualOrNull";
				case END_DATE_LESS_THAN_OR_EQUAL_OR_NULL:
					return "EndDateLessThanOrEqualOrNull";
				case REFERENCE_ID_EQUAL:
					return "ReferenceIdEqual";
				case REFERENCE_ID_IN:
					return "ReferenceIdIn";
				case REPLACING_ENTRY_ID_EQUAL:
					return "ReplacingEntryIdEqual";
				case REPLACING_ENTRY_ID_IN:
					return "ReplacingEntryIdIn";
				case REPLACED_ENTRY_ID_EQUAL:
					return "ReplacedEntryIdEqual";
				case REPLACED_ENTRY_ID_IN:
					return "ReplacedEntryIdIn";
				case REPLACEMENT_STATUS_EQUAL:
					return "ReplacementStatusEqual";
				case REPLACEMENT_STATUS_IN:
					return "ReplacementStatusIn";
				case PARTNER_SORT_VALUE_GREATER_THAN_OR_EQUAL:
					return "PartnerSortValueGreaterThanOrEqual";
				case PARTNER_SORT_VALUE_LESS_THAN_OR_EQUAL:
					return "PartnerSortValueLessThanOrEqual";
				case ROOT_ENTRY_ID_EQUAL:
					return "RootEntryIdEqual";
				case ROOT_ENTRY_ID_IN:
					return "RootEntryIdIn";
				case PARENT_ENTRY_ID_EQUAL:
					return "ParentEntryIdEqual";
				case ENTITLED_USERS_EDIT_MATCH_AND:
					return "EntitledUsersEditMatchAnd";
				case ENTITLED_USERS_EDIT_MATCH_OR:
					return "EntitledUsersEditMatchOr";
				case ENTITLED_USERS_PUBLISH_MATCH_AND:
					return "EntitledUsersPublishMatchAnd";
				case ENTITLED_USERS_PUBLISH_MATCH_OR:
					return "EntitledUsersPublishMatchOr";
				case ENTITLED_USERS_VIEW_MATCH_AND:
					return "EntitledUsersViewMatchAnd";
				case ENTITLED_USERS_VIEW_MATCH_OR:
					return "EntitledUsersViewMatchOr";
				case TAGS_NAME_MULTI_LIKE_OR:
					return "TagsNameMultiLikeOr";
				case TAGS_ADMIN_TAGS_MULTI_LIKE_OR:
					return "TagsAdminTagsMultiLikeOr";
				case TAGS_ADMIN_TAGS_NAME_MULTI_LIKE_OR:
					return "TagsAdminTagsNameMultiLikeOr";
				case TAGS_NAME_MULTI_LIKE_AND:
					return "TagsNameMultiLikeAnd";
				case TAGS_ADMIN_TAGS_MULTI_LIKE_AND:
					return "TagsAdminTagsMultiLikeAnd";
				case TAGS_ADMIN_TAGS_NAME_MULTI_LIKE_AND:
					return "TagsAdminTagsNameMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

