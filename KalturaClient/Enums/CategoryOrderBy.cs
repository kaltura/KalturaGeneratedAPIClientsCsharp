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
// Copyright (C) 2006-2021  Kaltura Inc.
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
namespace Kaltura.Enums
{
	public sealed class CategoryOrderBy : StringEnum
	{
		public static readonly CategoryOrderBy CREATED_AT_ASC = new CategoryOrderBy("+createdAt");
		public static readonly CategoryOrderBy DEPTH_ASC = new CategoryOrderBy("+depth");
		public static readonly CategoryOrderBy DIRECT_ENTRIES_COUNT_ASC = new CategoryOrderBy("+directEntriesCount");
		public static readonly CategoryOrderBy DIRECT_SUB_CATEGORIES_COUNT_ASC = new CategoryOrderBy("+directSubCategoriesCount");
		public static readonly CategoryOrderBy ENTRIES_COUNT_ASC = new CategoryOrderBy("+entriesCount");
		public static readonly CategoryOrderBy FULL_NAME_ASC = new CategoryOrderBy("+fullName");
		public static readonly CategoryOrderBy MEMBERS_COUNT_ASC = new CategoryOrderBy("+membersCount");
		public static readonly CategoryOrderBy NAME_ASC = new CategoryOrderBy("+name");
		public static readonly CategoryOrderBy PARTNER_SORT_VALUE_ASC = new CategoryOrderBy("+partnerSortValue");
		public static readonly CategoryOrderBy UPDATED_AT_ASC = new CategoryOrderBy("+updatedAt");
		public static readonly CategoryOrderBy CREATED_AT_DESC = new CategoryOrderBy("-createdAt");
		public static readonly CategoryOrderBy DEPTH_DESC = new CategoryOrderBy("-depth");
		public static readonly CategoryOrderBy DIRECT_ENTRIES_COUNT_DESC = new CategoryOrderBy("-directEntriesCount");
		public static readonly CategoryOrderBy DIRECT_SUB_CATEGORIES_COUNT_DESC = new CategoryOrderBy("-directSubCategoriesCount");
		public static readonly CategoryOrderBy ENTRIES_COUNT_DESC = new CategoryOrderBy("-entriesCount");
		public static readonly CategoryOrderBy FULL_NAME_DESC = new CategoryOrderBy("-fullName");
		public static readonly CategoryOrderBy MEMBERS_COUNT_DESC = new CategoryOrderBy("-membersCount");
		public static readonly CategoryOrderBy NAME_DESC = new CategoryOrderBy("-name");
		public static readonly CategoryOrderBy PARTNER_SORT_VALUE_DESC = new CategoryOrderBy("-partnerSortValue");
		public static readonly CategoryOrderBy UPDATED_AT_DESC = new CategoryOrderBy("-updatedAt");

		private CategoryOrderBy(string name) : base(name) { }
	}
}
