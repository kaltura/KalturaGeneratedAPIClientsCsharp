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
namespace Kaltura
{
	public sealed class KalturaCategoryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCategoryOrderBy CREATED_AT_ASC = new KalturaCategoryOrderBy("+createdAt");
		public static readonly KalturaCategoryOrderBy DEPTH_ASC = new KalturaCategoryOrderBy("+depth");
		public static readonly KalturaCategoryOrderBy DIRECT_ENTRIES_COUNT_ASC = new KalturaCategoryOrderBy("+directEntriesCount");
		public static readonly KalturaCategoryOrderBy DIRECT_SUB_CATEGORIES_COUNT_ASC = new KalturaCategoryOrderBy("+directSubCategoriesCount");
		public static readonly KalturaCategoryOrderBy ENTRIES_COUNT_ASC = new KalturaCategoryOrderBy("+entriesCount");
		public static readonly KalturaCategoryOrderBy FULL_NAME_ASC = new KalturaCategoryOrderBy("+fullName");
		public static readonly KalturaCategoryOrderBy MEMBERS_COUNT_ASC = new KalturaCategoryOrderBy("+membersCount");
		public static readonly KalturaCategoryOrderBy NAME_ASC = new KalturaCategoryOrderBy("+name");
		public static readonly KalturaCategoryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaCategoryOrderBy("+partnerSortValue");
		public static readonly KalturaCategoryOrderBy UPDATED_AT_ASC = new KalturaCategoryOrderBy("+updatedAt");
		public static readonly KalturaCategoryOrderBy CREATED_AT_DESC = new KalturaCategoryOrderBy("-createdAt");
		public static readonly KalturaCategoryOrderBy DEPTH_DESC = new KalturaCategoryOrderBy("-depth");
		public static readonly KalturaCategoryOrderBy DIRECT_ENTRIES_COUNT_DESC = new KalturaCategoryOrderBy("-directEntriesCount");
		public static readonly KalturaCategoryOrderBy DIRECT_SUB_CATEGORIES_COUNT_DESC = new KalturaCategoryOrderBy("-directSubCategoriesCount");
		public static readonly KalturaCategoryOrderBy ENTRIES_COUNT_DESC = new KalturaCategoryOrderBy("-entriesCount");
		public static readonly KalturaCategoryOrderBy FULL_NAME_DESC = new KalturaCategoryOrderBy("-fullName");
		public static readonly KalturaCategoryOrderBy MEMBERS_COUNT_DESC = new KalturaCategoryOrderBy("-membersCount");
		public static readonly KalturaCategoryOrderBy NAME_DESC = new KalturaCategoryOrderBy("-name");
		public static readonly KalturaCategoryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaCategoryOrderBy("-partnerSortValue");
		public static readonly KalturaCategoryOrderBy UPDATED_AT_DESC = new KalturaCategoryOrderBy("-updatedAt");

		private KalturaCategoryOrderBy(string name) : base(name) { }
	}
}
