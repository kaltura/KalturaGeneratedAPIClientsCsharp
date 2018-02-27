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
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public string IdNotIn
		{
			get { return _IdNotIn; }
			set 
			{ 
				_IdNotIn = value;
				OnPropertyChanged("IdNotIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public string NameMultiLikeOr
		{
			get { return _NameMultiLikeOr; }
			set 
			{ 
				_NameMultiLikeOr = value;
				OnPropertyChanged("NameMultiLikeOr");
			}
		}
		public string NameMultiLikeAnd
		{
			get { return _NameMultiLikeAnd; }
			set 
			{ 
				_NameMultiLikeAnd = value;
				OnPropertyChanged("NameMultiLikeAnd");
			}
		}
		public string NameEqual
		{
			get { return _NameEqual; }
			set 
			{ 
				_NameEqual = value;
				OnPropertyChanged("NameEqual");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public string UserIdNotIn
		{
			get { return _UserIdNotIn; }
			set 
			{ 
				_UserIdNotIn = value;
				OnPropertyChanged("UserIdNotIn");
			}
		}
		public string CreatorIdEqual
		{
			get { return _CreatorIdEqual; }
			set 
			{ 
				_CreatorIdEqual = value;
				OnPropertyChanged("CreatorIdEqual");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public string AdminTagsLike
		{
			get { return _AdminTagsLike; }
			set 
			{ 
				_AdminTagsLike = value;
				OnPropertyChanged("AdminTagsLike");
			}
		}
		public string AdminTagsMultiLikeOr
		{
			get { return _AdminTagsMultiLikeOr; }
			set 
			{ 
				_AdminTagsMultiLikeOr = value;
				OnPropertyChanged("AdminTagsMultiLikeOr");
			}
		}
		public string AdminTagsMultiLikeAnd
		{
			get { return _AdminTagsMultiLikeAnd; }
			set 
			{ 
				_AdminTagsMultiLikeAnd = value;
				OnPropertyChanged("AdminTagsMultiLikeAnd");
			}
		}
		public string CategoriesMatchAnd
		{
			get { return _CategoriesMatchAnd; }
			set 
			{ 
				_CategoriesMatchAnd = value;
				OnPropertyChanged("CategoriesMatchAnd");
			}
		}
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		public string CategoriesNotContains
		{
			get { return _CategoriesNotContains; }
			set 
			{ 
				_CategoriesNotContains = value;
				OnPropertyChanged("CategoriesNotContains");
			}
		}
		public string CategoriesIdsMatchAnd
		{
			get { return _CategoriesIdsMatchAnd; }
			set 
			{ 
				_CategoriesIdsMatchAnd = value;
				OnPropertyChanged("CategoriesIdsMatchAnd");
			}
		}
		public string CategoriesIdsMatchOr
		{
			get { return _CategoriesIdsMatchOr; }
			set 
			{ 
				_CategoriesIdsMatchOr = value;
				OnPropertyChanged("CategoriesIdsMatchOr");
			}
		}
		public string CategoriesIdsNotContains
		{
			get { return _CategoriesIdsNotContains; }
			set 
			{ 
				_CategoriesIdsNotContains = value;
				OnPropertyChanged("CategoriesIdsNotContains");
			}
		}
		public NullableBoolean CategoriesIdsEmpty
		{
			get { return _CategoriesIdsEmpty; }
			set 
			{ 
				_CategoriesIdsEmpty = value;
				OnPropertyChanged("CategoriesIdsEmpty");
			}
		}
		public EntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public EntryStatus StatusNotEqual
		{
			get { return _StatusNotEqual; }
			set 
			{ 
				_StatusNotEqual = value;
				OnPropertyChanged("StatusNotEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		public EntryModerationStatus ModerationStatusEqual
		{
			get { return _ModerationStatusEqual; }
			set 
			{ 
				_ModerationStatusEqual = value;
				OnPropertyChanged("ModerationStatusEqual");
			}
		}
		public EntryModerationStatus ModerationStatusNotEqual
		{
			get { return _ModerationStatusNotEqual; }
			set 
			{ 
				_ModerationStatusNotEqual = value;
				OnPropertyChanged("ModerationStatusNotEqual");
			}
		}
		public string ModerationStatusIn
		{
			get { return _ModerationStatusIn; }
			set 
			{ 
				_ModerationStatusIn = value;
				OnPropertyChanged("ModerationStatusIn");
			}
		}
		public string ModerationStatusNotIn
		{
			get { return _ModerationStatusNotIn; }
			set 
			{ 
				_ModerationStatusNotIn = value;
				OnPropertyChanged("ModerationStatusNotIn");
			}
		}
		public EntryType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int TotalRankLessThanOrEqual
		{
			get { return _TotalRankLessThanOrEqual; }
			set 
			{ 
				_TotalRankLessThanOrEqual = value;
				OnPropertyChanged("TotalRankLessThanOrEqual");
			}
		}
		public int TotalRankGreaterThanOrEqual
		{
			get { return _TotalRankGreaterThanOrEqual; }
			set 
			{ 
				_TotalRankGreaterThanOrEqual = value;
				OnPropertyChanged("TotalRankGreaterThanOrEqual");
			}
		}
		public int GroupIdEqual
		{
			get { return _GroupIdEqual; }
			set 
			{ 
				_GroupIdEqual = value;
				OnPropertyChanged("GroupIdEqual");
			}
		}
		public string SearchTextMatchAnd
		{
			get { return _SearchTextMatchAnd; }
			set 
			{ 
				_SearchTextMatchAnd = value;
				OnPropertyChanged("SearchTextMatchAnd");
			}
		}
		public string SearchTextMatchOr
		{
			get { return _SearchTextMatchOr; }
			set 
			{ 
				_SearchTextMatchOr = value;
				OnPropertyChanged("SearchTextMatchOr");
			}
		}
		public int AccessControlIdEqual
		{
			get { return _AccessControlIdEqual; }
			set 
			{ 
				_AccessControlIdEqual = value;
				OnPropertyChanged("AccessControlIdEqual");
			}
		}
		public string AccessControlIdIn
		{
			get { return _AccessControlIdIn; }
			set 
			{ 
				_AccessControlIdIn = value;
				OnPropertyChanged("AccessControlIdIn");
			}
		}
		public int StartDateGreaterThanOrEqual
		{
			get { return _StartDateGreaterThanOrEqual; }
			set 
			{ 
				_StartDateGreaterThanOrEqual = value;
				OnPropertyChanged("StartDateGreaterThanOrEqual");
			}
		}
		public int StartDateLessThanOrEqual
		{
			get { return _StartDateLessThanOrEqual; }
			set 
			{ 
				_StartDateLessThanOrEqual = value;
				OnPropertyChanged("StartDateLessThanOrEqual");
			}
		}
		public int StartDateGreaterThanOrEqualOrNull
		{
			get { return _StartDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_StartDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateGreaterThanOrEqualOrNull");
			}
		}
		public int StartDateLessThanOrEqualOrNull
		{
			get { return _StartDateLessThanOrEqualOrNull; }
			set 
			{ 
				_StartDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("StartDateLessThanOrEqualOrNull");
			}
		}
		public int EndDateGreaterThanOrEqual
		{
			get { return _EndDateGreaterThanOrEqual; }
			set 
			{ 
				_EndDateGreaterThanOrEqual = value;
				OnPropertyChanged("EndDateGreaterThanOrEqual");
			}
		}
		public int EndDateLessThanOrEqual
		{
			get { return _EndDateLessThanOrEqual; }
			set 
			{ 
				_EndDateLessThanOrEqual = value;
				OnPropertyChanged("EndDateLessThanOrEqual");
			}
		}
		public int EndDateGreaterThanOrEqualOrNull
		{
			get { return _EndDateGreaterThanOrEqualOrNull; }
			set 
			{ 
				_EndDateGreaterThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateGreaterThanOrEqualOrNull");
			}
		}
		public int EndDateLessThanOrEqualOrNull
		{
			get { return _EndDateLessThanOrEqualOrNull; }
			set 
			{ 
				_EndDateLessThanOrEqualOrNull = value;
				OnPropertyChanged("EndDateLessThanOrEqualOrNull");
			}
		}
		public string ReferenceIdEqual
		{
			get { return _ReferenceIdEqual; }
			set 
			{ 
				_ReferenceIdEqual = value;
				OnPropertyChanged("ReferenceIdEqual");
			}
		}
		public string ReferenceIdIn
		{
			get { return _ReferenceIdIn; }
			set 
			{ 
				_ReferenceIdIn = value;
				OnPropertyChanged("ReferenceIdIn");
			}
		}
		public string ReplacingEntryIdEqual
		{
			get { return _ReplacingEntryIdEqual; }
			set 
			{ 
				_ReplacingEntryIdEqual = value;
				OnPropertyChanged("ReplacingEntryIdEqual");
			}
		}
		public string ReplacingEntryIdIn
		{
			get { return _ReplacingEntryIdIn; }
			set 
			{ 
				_ReplacingEntryIdIn = value;
				OnPropertyChanged("ReplacingEntryIdIn");
			}
		}
		public string ReplacedEntryIdEqual
		{
			get { return _ReplacedEntryIdEqual; }
			set 
			{ 
				_ReplacedEntryIdEqual = value;
				OnPropertyChanged("ReplacedEntryIdEqual");
			}
		}
		public string ReplacedEntryIdIn
		{
			get { return _ReplacedEntryIdIn; }
			set 
			{ 
				_ReplacedEntryIdIn = value;
				OnPropertyChanged("ReplacedEntryIdIn");
			}
		}
		public EntryReplacementStatus ReplacementStatusEqual
		{
			get { return _ReplacementStatusEqual; }
			set 
			{ 
				_ReplacementStatusEqual = value;
				OnPropertyChanged("ReplacementStatusEqual");
			}
		}
		public string ReplacementStatusIn
		{
			get { return _ReplacementStatusIn; }
			set 
			{ 
				_ReplacementStatusIn = value;
				OnPropertyChanged("ReplacementStatusIn");
			}
		}
		public int PartnerSortValueGreaterThanOrEqual
		{
			get { return _PartnerSortValueGreaterThanOrEqual; }
			set 
			{ 
				_PartnerSortValueGreaterThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueGreaterThanOrEqual");
			}
		}
		public int PartnerSortValueLessThanOrEqual
		{
			get { return _PartnerSortValueLessThanOrEqual; }
			set 
			{ 
				_PartnerSortValueLessThanOrEqual = value;
				OnPropertyChanged("PartnerSortValueLessThanOrEqual");
			}
		}
		public string RootEntryIdEqual
		{
			get { return _RootEntryIdEqual; }
			set 
			{ 
				_RootEntryIdEqual = value;
				OnPropertyChanged("RootEntryIdEqual");
			}
		}
		public string RootEntryIdIn
		{
			get { return _RootEntryIdIn; }
			set 
			{ 
				_RootEntryIdIn = value;
				OnPropertyChanged("RootEntryIdIn");
			}
		}
		public string ParentEntryIdEqual
		{
			get { return _ParentEntryIdEqual; }
			set 
			{ 
				_ParentEntryIdEqual = value;
				OnPropertyChanged("ParentEntryIdEqual");
			}
		}
		public string EntitledUsersEditMatchAnd
		{
			get { return _EntitledUsersEditMatchAnd; }
			set 
			{ 
				_EntitledUsersEditMatchAnd = value;
				OnPropertyChanged("EntitledUsersEditMatchAnd");
			}
		}
		public string EntitledUsersEditMatchOr
		{
			get { return _EntitledUsersEditMatchOr; }
			set 
			{ 
				_EntitledUsersEditMatchOr = value;
				OnPropertyChanged("EntitledUsersEditMatchOr");
			}
		}
		public string EntitledUsersPublishMatchAnd
		{
			get { return _EntitledUsersPublishMatchAnd; }
			set 
			{ 
				_EntitledUsersPublishMatchAnd = value;
				OnPropertyChanged("EntitledUsersPublishMatchAnd");
			}
		}
		public string EntitledUsersPublishMatchOr
		{
			get { return _EntitledUsersPublishMatchOr; }
			set 
			{ 
				_EntitledUsersPublishMatchOr = value;
				OnPropertyChanged("EntitledUsersPublishMatchOr");
			}
		}
		public string EntitledUsersViewMatchAnd
		{
			get { return _EntitledUsersViewMatchAnd; }
			set 
			{ 
				_EntitledUsersViewMatchAnd = value;
				OnPropertyChanged("EntitledUsersViewMatchAnd");
			}
		}
		public string EntitledUsersViewMatchOr
		{
			get { return _EntitledUsersViewMatchOr; }
			set 
			{ 
				_EntitledUsersViewMatchOr = value;
				OnPropertyChanged("EntitledUsersViewMatchOr");
			}
		}
		public string TagsNameMultiLikeOr
		{
			get { return _TagsNameMultiLikeOr; }
			set 
			{ 
				_TagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsNameMultiLikeOr");
			}
		}
		public string TagsAdminTagsMultiLikeOr
		{
			get { return _TagsAdminTagsMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeOr");
			}
		}
		public string TagsAdminTagsNameMultiLikeOr
		{
			get { return _TagsAdminTagsNameMultiLikeOr; }
			set 
			{ 
				_TagsAdminTagsNameMultiLikeOr = value;
				OnPropertyChanged("TagsAdminTagsNameMultiLikeOr");
			}
		}
		public string TagsNameMultiLikeAnd
		{
			get { return _TagsNameMultiLikeAnd; }
			set 
			{ 
				_TagsNameMultiLikeAnd = value;
				OnPropertyChanged("TagsNameMultiLikeAnd");
			}
		}
		public string TagsAdminTagsMultiLikeAnd
		{
			get { return _TagsAdminTagsMultiLikeAnd; }
			set 
			{ 
				_TagsAdminTagsMultiLikeAnd = value;
				OnPropertyChanged("TagsAdminTagsMultiLikeAnd");
			}
		}
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

		public BaseEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "idNotIn":
						this._IdNotIn = propertyNode.InnerText;
						continue;
					case "nameLike":
						this._NameLike = propertyNode.InnerText;
						continue;
					case "nameMultiLikeOr":
						this._NameMultiLikeOr = propertyNode.InnerText;
						continue;
					case "nameMultiLikeAnd":
						this._NameMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "nameEqual":
						this._NameEqual = propertyNode.InnerText;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = propertyNode.InnerText;
						continue;
					case "userIdEqual":
						this._UserIdEqual = propertyNode.InnerText;
						continue;
					case "userIdIn":
						this._UserIdIn = propertyNode.InnerText;
						continue;
					case "userIdNotIn":
						this._UserIdNotIn = propertyNode.InnerText;
						continue;
					case "creatorIdEqual":
						this._CreatorIdEqual = propertyNode.InnerText;
						continue;
					case "tagsLike":
						this._TagsLike = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "adminTagsLike":
						this._AdminTagsLike = propertyNode.InnerText;
						continue;
					case "adminTagsMultiLikeOr":
						this._AdminTagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "adminTagsMultiLikeAnd":
						this._AdminTagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "categoriesMatchAnd":
						this._CategoriesMatchAnd = propertyNode.InnerText;
						continue;
					case "categoriesMatchOr":
						this._CategoriesMatchOr = propertyNode.InnerText;
						continue;
					case "categoriesNotContains":
						this._CategoriesNotContains = propertyNode.InnerText;
						continue;
					case "categoriesIdsMatchAnd":
						this._CategoriesIdsMatchAnd = propertyNode.InnerText;
						continue;
					case "categoriesIdsMatchOr":
						this._CategoriesIdsMatchOr = propertyNode.InnerText;
						continue;
					case "categoriesIdsNotContains":
						this._CategoriesIdsNotContains = propertyNode.InnerText;
						continue;
					case "categoriesIdsEmpty":
						this._CategoriesIdsEmpty = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "statusEqual":
						this._StatusEqual = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), propertyNode.InnerText);
						continue;
					case "statusNotEqual":
						this._StatusNotEqual = (EntryStatus)StringEnum.Parse(typeof(EntryStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "statusNotIn":
						this._StatusNotIn = propertyNode.InnerText;
						continue;
					case "moderationStatusEqual":
						this._ModerationStatusEqual = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), propertyNode.InnerText);
						continue;
					case "moderationStatusNotEqual":
						this._ModerationStatusNotEqual = (EntryModerationStatus)ParseEnum(typeof(EntryModerationStatus), propertyNode.InnerText);
						continue;
					case "moderationStatusIn":
						this._ModerationStatusIn = propertyNode.InnerText;
						continue;
					case "moderationStatusNotIn":
						this._ModerationStatusNotIn = propertyNode.InnerText;
						continue;
					case "typeEqual":
						this._TypeEqual = (EntryType)StringEnum.Parse(typeof(EntryType), propertyNode.InnerText);
						continue;
					case "typeIn":
						this._TypeIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "totalRankLessThanOrEqual":
						this._TotalRankLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "totalRankGreaterThanOrEqual":
						this._TotalRankGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "groupIdEqual":
						this._GroupIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "searchTextMatchAnd":
						this._SearchTextMatchAnd = propertyNode.InnerText;
						continue;
					case "searchTextMatchOr":
						this._SearchTextMatchOr = propertyNode.InnerText;
						continue;
					case "accessControlIdEqual":
						this._AccessControlIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "accessControlIdIn":
						this._AccessControlIdIn = propertyNode.InnerText;
						continue;
					case "startDateGreaterThanOrEqual":
						this._StartDateGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "startDateLessThanOrEqual":
						this._StartDateLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "startDateGreaterThanOrEqualOrNull":
						this._StartDateGreaterThanOrEqualOrNull = ParseInt(propertyNode.InnerText);
						continue;
					case "startDateLessThanOrEqualOrNull":
						this._StartDateLessThanOrEqualOrNull = ParseInt(propertyNode.InnerText);
						continue;
					case "endDateGreaterThanOrEqual":
						this._EndDateGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "endDateLessThanOrEqual":
						this._EndDateLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "endDateGreaterThanOrEqualOrNull":
						this._EndDateGreaterThanOrEqualOrNull = ParseInt(propertyNode.InnerText);
						continue;
					case "endDateLessThanOrEqualOrNull":
						this._EndDateLessThanOrEqualOrNull = ParseInt(propertyNode.InnerText);
						continue;
					case "referenceIdEqual":
						this._ReferenceIdEqual = propertyNode.InnerText;
						continue;
					case "referenceIdIn":
						this._ReferenceIdIn = propertyNode.InnerText;
						continue;
					case "replacingEntryIdEqual":
						this._ReplacingEntryIdEqual = propertyNode.InnerText;
						continue;
					case "replacingEntryIdIn":
						this._ReplacingEntryIdIn = propertyNode.InnerText;
						continue;
					case "replacedEntryIdEqual":
						this._ReplacedEntryIdEqual = propertyNode.InnerText;
						continue;
					case "replacedEntryIdIn":
						this._ReplacedEntryIdIn = propertyNode.InnerText;
						continue;
					case "replacementStatusEqual":
						this._ReplacementStatusEqual = (EntryReplacementStatus)StringEnum.Parse(typeof(EntryReplacementStatus), propertyNode.InnerText);
						continue;
					case "replacementStatusIn":
						this._ReplacementStatusIn = propertyNode.InnerText;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this._PartnerSortValueGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this._PartnerSortValueLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "rootEntryIdEqual":
						this._RootEntryIdEqual = propertyNode.InnerText;
						continue;
					case "rootEntryIdIn":
						this._RootEntryIdIn = propertyNode.InnerText;
						continue;
					case "parentEntryIdEqual":
						this._ParentEntryIdEqual = propertyNode.InnerText;
						continue;
					case "entitledUsersEditMatchAnd":
						this._EntitledUsersEditMatchAnd = propertyNode.InnerText;
						continue;
					case "entitledUsersEditMatchOr":
						this._EntitledUsersEditMatchOr = propertyNode.InnerText;
						continue;
					case "entitledUsersPublishMatchAnd":
						this._EntitledUsersPublishMatchAnd = propertyNode.InnerText;
						continue;
					case "entitledUsersPublishMatchOr":
						this._EntitledUsersPublishMatchOr = propertyNode.InnerText;
						continue;
					case "entitledUsersViewMatchAnd":
						this._EntitledUsersViewMatchAnd = propertyNode.InnerText;
						continue;
					case "entitledUsersViewMatchOr":
						this._EntitledUsersViewMatchOr = propertyNode.InnerText;
						continue;
					case "tagsNameMultiLikeOr":
						this._TagsNameMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsAdminTagsMultiLikeOr":
						this._TagsAdminTagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsAdminTagsNameMultiLikeOr":
						this._TagsAdminTagsNameMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsNameMultiLikeAnd":
						this._TagsNameMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "tagsAdminTagsMultiLikeAnd":
						this._TagsAdminTagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "tagsAdminTagsNameMultiLikeAnd":
						this._TagsAdminTagsNameMultiLikeAnd = propertyNode.InnerText;
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

