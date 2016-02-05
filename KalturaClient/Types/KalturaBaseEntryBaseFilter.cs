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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaBaseEntryBaseFilter : KalturaRelatedFilter
	{
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
		private KalturaNullableBoolean _CategoriesIdsEmpty = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaEntryStatus _StatusEqual = null;
		private KalturaEntryStatus _StatusNotEqual = null;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private KalturaEntryModerationStatus _ModerationStatusEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private KalturaEntryModerationStatus _ModerationStatusNotEqual = (KalturaEntryModerationStatus)Int32.MinValue;
		private string _ModerationStatusIn = null;
		private string _ModerationStatusNotIn = null;
		private KalturaEntryType _TypeEqual = null;
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
		private KalturaEntryReplacementStatus _ReplacementStatusEqual = null;
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
		public KalturaNullableBoolean CategoriesIdsEmpty
		{
			get { return _CategoriesIdsEmpty; }
			set 
			{ 
				_CategoriesIdsEmpty = value;
				OnPropertyChanged("CategoriesIdsEmpty");
			}
		}
		public KalturaEntryStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public KalturaEntryStatus StatusNotEqual
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
		public KalturaEntryModerationStatus ModerationStatusEqual
		{
			get { return _ModerationStatusEqual; }
			set 
			{ 
				_ModerationStatusEqual = value;
				OnPropertyChanged("ModerationStatusEqual");
			}
		}
		public KalturaEntryModerationStatus ModerationStatusNotEqual
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
		public KalturaEntryType TypeEqual
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
		public KalturaEntryReplacementStatus ReplacementStatusEqual
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
		public KalturaBaseEntryBaseFilter()
		{
		}

		public KalturaBaseEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = txt;
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "idNotIn":
						this.IdNotIn = txt;
						continue;
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "nameMultiLikeOr":
						this.NameMultiLikeOr = txt;
						continue;
					case "nameMultiLikeAnd":
						this.NameMultiLikeAnd = txt;
						continue;
					case "nameEqual":
						this.NameEqual = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "userIdEqual":
						this.UserIdEqual = txt;
						continue;
					case "userIdIn":
						this.UserIdIn = txt;
						continue;
					case "creatorIdEqual":
						this.CreatorIdEqual = txt;
						continue;
					case "tagsLike":
						this.TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "adminTagsLike":
						this.AdminTagsLike = txt;
						continue;
					case "adminTagsMultiLikeOr":
						this.AdminTagsMultiLikeOr = txt;
						continue;
					case "adminTagsMultiLikeAnd":
						this.AdminTagsMultiLikeAnd = txt;
						continue;
					case "categoriesMatchAnd":
						this.CategoriesMatchAnd = txt;
						continue;
					case "categoriesMatchOr":
						this.CategoriesMatchOr = txt;
						continue;
					case "categoriesNotContains":
						this.CategoriesNotContains = txt;
						continue;
					case "categoriesIdsMatchAnd":
						this.CategoriesIdsMatchAnd = txt;
						continue;
					case "categoriesIdsMatchOr":
						this.CategoriesIdsMatchOr = txt;
						continue;
					case "categoriesIdsNotContains":
						this.CategoriesIdsNotContains = txt;
						continue;
					case "categoriesIdsEmpty":
						this.CategoriesIdsEmpty = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusNotEqual":
						this.StatusNotEqual = (KalturaEntryStatus)KalturaStringEnum.Parse(typeof(KalturaEntryStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
						continue;
					case "moderationStatusEqual":
						this.ModerationStatusEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusNotEqual":
						this.ModerationStatusNotEqual = (KalturaEntryModerationStatus)ParseEnum(typeof(KalturaEntryModerationStatus), txt);
						continue;
					case "moderationStatusIn":
						this.ModerationStatusIn = txt;
						continue;
					case "moderationStatusNotIn":
						this.ModerationStatusNotIn = txt;
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaEntryType)KalturaStringEnum.Parse(typeof(KalturaEntryType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "totalRankLessThanOrEqual":
						this.TotalRankLessThanOrEqual = ParseInt(txt);
						continue;
					case "totalRankGreaterThanOrEqual":
						this.TotalRankGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "groupIdEqual":
						this.GroupIdEqual = ParseInt(txt);
						continue;
					case "searchTextMatchAnd":
						this.SearchTextMatchAnd = txt;
						continue;
					case "searchTextMatchOr":
						this.SearchTextMatchOr = txt;
						continue;
					case "accessControlIdEqual":
						this.AccessControlIdEqual = ParseInt(txt);
						continue;
					case "accessControlIdIn":
						this.AccessControlIdIn = txt;
						continue;
					case "startDateGreaterThanOrEqual":
						this.StartDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqual":
						this.StartDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "startDateGreaterThanOrEqualOrNull":
						this.StartDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "startDateLessThanOrEqualOrNull":
						this.StartDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqual":
						this.EndDateGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqual":
						this.EndDateLessThanOrEqual = ParseInt(txt);
						continue;
					case "endDateGreaterThanOrEqualOrNull":
						this.EndDateGreaterThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "endDateLessThanOrEqualOrNull":
						this.EndDateLessThanOrEqualOrNull = ParseInt(txt);
						continue;
					case "referenceIdEqual":
						this.ReferenceIdEqual = txt;
						continue;
					case "referenceIdIn":
						this.ReferenceIdIn = txt;
						continue;
					case "replacingEntryIdEqual":
						this.ReplacingEntryIdEqual = txt;
						continue;
					case "replacingEntryIdIn":
						this.ReplacingEntryIdIn = txt;
						continue;
					case "replacedEntryIdEqual":
						this.ReplacedEntryIdEqual = txt;
						continue;
					case "replacedEntryIdIn":
						this.ReplacedEntryIdIn = txt;
						continue;
					case "replacementStatusEqual":
						this.ReplacementStatusEqual = (KalturaEntryReplacementStatus)KalturaStringEnum.Parse(typeof(KalturaEntryReplacementStatus), txt);
						continue;
					case "replacementStatusIn":
						this.ReplacementStatusIn = txt;
						continue;
					case "partnerSortValueGreaterThanOrEqual":
						this.PartnerSortValueGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "partnerSortValueLessThanOrEqual":
						this.PartnerSortValueLessThanOrEqual = ParseInt(txt);
						continue;
					case "rootEntryIdEqual":
						this.RootEntryIdEqual = txt;
						continue;
					case "rootEntryIdIn":
						this.RootEntryIdIn = txt;
						continue;
					case "parentEntryIdEqual":
						this.ParentEntryIdEqual = txt;
						continue;
					case "entitledUsersEditMatchAnd":
						this.EntitledUsersEditMatchAnd = txt;
						continue;
					case "entitledUsersEditMatchOr":
						this.EntitledUsersEditMatchOr = txt;
						continue;
					case "entitledUsersPublishMatchAnd":
						this.EntitledUsersPublishMatchAnd = txt;
						continue;
					case "entitledUsersPublishMatchOr":
						this.EntitledUsersPublishMatchOr = txt;
						continue;
					case "tagsNameMultiLikeOr":
						this.TagsNameMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsMultiLikeOr":
						this.TagsAdminTagsMultiLikeOr = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeOr":
						this.TagsAdminTagsNameMultiLikeOr = txt;
						continue;
					case "tagsNameMultiLikeAnd":
						this.TagsNameMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsMultiLikeAnd":
						this.TagsAdminTagsMultiLikeAnd = txt;
						continue;
					case "tagsAdminTagsNameMultiLikeAnd":
						this.TagsAdminTagsNameMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseEntryBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("idNotIn", this.IdNotIn);
			kparams.AddIfNotNull("nameLike", this.NameLike);
			kparams.AddIfNotNull("nameMultiLikeOr", this.NameMultiLikeOr);
			kparams.AddIfNotNull("nameMultiLikeAnd", this.NameMultiLikeAnd);
			kparams.AddIfNotNull("nameEqual", this.NameEqual);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIfNotNull("userIdEqual", this.UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this.UserIdIn);
			kparams.AddIfNotNull("creatorIdEqual", this.CreatorIdEqual);
			kparams.AddIfNotNull("tagsLike", this.TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("adminTagsLike", this.AdminTagsLike);
			kparams.AddIfNotNull("adminTagsMultiLikeOr", this.AdminTagsMultiLikeOr);
			kparams.AddIfNotNull("adminTagsMultiLikeAnd", this.AdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("categoriesMatchAnd", this.CategoriesMatchAnd);
			kparams.AddIfNotNull("categoriesMatchOr", this.CategoriesMatchOr);
			kparams.AddIfNotNull("categoriesNotContains", this.CategoriesNotContains);
			kparams.AddIfNotNull("categoriesIdsMatchAnd", this.CategoriesIdsMatchAnd);
			kparams.AddIfNotNull("categoriesIdsMatchOr", this.CategoriesIdsMatchOr);
			kparams.AddIfNotNull("categoriesIdsNotContains", this.CategoriesIdsNotContains);
			kparams.AddIfNotNull("categoriesIdsEmpty", this.CategoriesIdsEmpty);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusNotEqual", this.StatusNotEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("statusNotIn", this.StatusNotIn);
			kparams.AddIfNotNull("moderationStatusEqual", this.ModerationStatusEqual);
			kparams.AddIfNotNull("moderationStatusNotEqual", this.ModerationStatusNotEqual);
			kparams.AddIfNotNull("moderationStatusIn", this.ModerationStatusIn);
			kparams.AddIfNotNull("moderationStatusNotIn", this.ModerationStatusNotIn);
			kparams.AddIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddIfNotNull("typeIn", this.TypeIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("totalRankLessThanOrEqual", this.TotalRankLessThanOrEqual);
			kparams.AddIfNotNull("totalRankGreaterThanOrEqual", this.TotalRankGreaterThanOrEqual);
			kparams.AddIfNotNull("groupIdEqual", this.GroupIdEqual);
			kparams.AddIfNotNull("searchTextMatchAnd", this.SearchTextMatchAnd);
			kparams.AddIfNotNull("searchTextMatchOr", this.SearchTextMatchOr);
			kparams.AddIfNotNull("accessControlIdEqual", this.AccessControlIdEqual);
			kparams.AddIfNotNull("accessControlIdIn", this.AccessControlIdIn);
			kparams.AddIfNotNull("startDateGreaterThanOrEqual", this.StartDateGreaterThanOrEqual);
			kparams.AddIfNotNull("startDateLessThanOrEqual", this.StartDateLessThanOrEqual);
			kparams.AddIfNotNull("startDateGreaterThanOrEqualOrNull", this.StartDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("startDateLessThanOrEqualOrNull", this.StartDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateGreaterThanOrEqual", this.EndDateGreaterThanOrEqual);
			kparams.AddIfNotNull("endDateLessThanOrEqual", this.EndDateLessThanOrEqual);
			kparams.AddIfNotNull("endDateGreaterThanOrEqualOrNull", this.EndDateGreaterThanOrEqualOrNull);
			kparams.AddIfNotNull("endDateLessThanOrEqualOrNull", this.EndDateLessThanOrEqualOrNull);
			kparams.AddIfNotNull("referenceIdEqual", this.ReferenceIdEqual);
			kparams.AddIfNotNull("referenceIdIn", this.ReferenceIdIn);
			kparams.AddIfNotNull("replacingEntryIdEqual", this.ReplacingEntryIdEqual);
			kparams.AddIfNotNull("replacingEntryIdIn", this.ReplacingEntryIdIn);
			kparams.AddIfNotNull("replacedEntryIdEqual", this.ReplacedEntryIdEqual);
			kparams.AddIfNotNull("replacedEntryIdIn", this.ReplacedEntryIdIn);
			kparams.AddIfNotNull("replacementStatusEqual", this.ReplacementStatusEqual);
			kparams.AddIfNotNull("replacementStatusIn", this.ReplacementStatusIn);
			kparams.AddIfNotNull("partnerSortValueGreaterThanOrEqual", this.PartnerSortValueGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerSortValueLessThanOrEqual", this.PartnerSortValueLessThanOrEqual);
			kparams.AddIfNotNull("rootEntryIdEqual", this.RootEntryIdEqual);
			kparams.AddIfNotNull("rootEntryIdIn", this.RootEntryIdIn);
			kparams.AddIfNotNull("parentEntryIdEqual", this.ParentEntryIdEqual);
			kparams.AddIfNotNull("entitledUsersEditMatchAnd", this.EntitledUsersEditMatchAnd);
			kparams.AddIfNotNull("entitledUsersEditMatchOr", this.EntitledUsersEditMatchOr);
			kparams.AddIfNotNull("entitledUsersPublishMatchAnd", this.EntitledUsersPublishMatchAnd);
			kparams.AddIfNotNull("entitledUsersPublishMatchOr", this.EntitledUsersPublishMatchOr);
			kparams.AddIfNotNull("tagsNameMultiLikeOr", this.TagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeOr", this.TagsAdminTagsMultiLikeOr);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeOr", this.TagsAdminTagsNameMultiLikeOr);
			kparams.AddIfNotNull("tagsNameMultiLikeAnd", this.TagsNameMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsMultiLikeAnd", this.TagsAdminTagsMultiLikeAnd);
			kparams.AddIfNotNull("tagsAdminTagsNameMultiLikeAnd", this.TagsAdminTagsNameMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

