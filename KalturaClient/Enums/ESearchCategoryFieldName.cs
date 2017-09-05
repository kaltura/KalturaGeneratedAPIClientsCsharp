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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class ESearchCategoryFieldName : StringEnum
	{
		public static readonly ESearchCategoryFieldName CATEGORY_CONTRIBUTION_POLICY = new ESearchCategoryFieldName("contribution_policy");
		public static readonly ESearchCategoryFieldName CATEGORY_CREATED_AT = new ESearchCategoryFieldName("created_at");
		public static readonly ESearchCategoryFieldName CATEGORY_DEPTH = new ESearchCategoryFieldName("depth");
		public static readonly ESearchCategoryFieldName CATEGORY_DESCRIPTION = new ESearchCategoryFieldName("description");
		public static readonly ESearchCategoryFieldName CATEGORY_DIRECT_ENTRIES_COUNT = new ESearchCategoryFieldName("direct_entries_count");
		public static readonly ESearchCategoryFieldName CATEGORY_DIRECT_SUB_CATEGORIES_COUNT = new ESearchCategoryFieldName("direct_sub_categories_count");
		public static readonly ESearchCategoryFieldName CATEGORY_DISPLAY_IN_SEARCH = new ESearchCategoryFieldName("display_in_search");
		public static readonly ESearchCategoryFieldName CATEGORY_ENTRIES_COUNT = new ESearchCategoryFieldName("entries_count");
		public static readonly ESearchCategoryFieldName CATEGORY_FULL_IDS = new ESearchCategoryFieldName("full_ids");
		public static readonly ESearchCategoryFieldName CATEGORY_FULL_NAME = new ESearchCategoryFieldName("full_name");
		public static readonly ESearchCategoryFieldName CATEGORY_INHERITANCE_TYPE = new ESearchCategoryFieldName("inheritance_type");
		public static readonly ESearchCategoryFieldName CATEGORY_INHERITED_PARENT_ID = new ESearchCategoryFieldName("inherited_parent_id");
		public static readonly ESearchCategoryFieldName CATEGORY_KUSER_ID = new ESearchCategoryFieldName("kuser_id");
		public static readonly ESearchCategoryFieldName CATEGORY_KUSER_IDS = new ESearchCategoryFieldName("kuser_ids");
		public static readonly ESearchCategoryFieldName CATEGORY_MEMBERS_COUNT = new ESearchCategoryFieldName("members_count");
		public static readonly ESearchCategoryFieldName CATEGORY_MODERATION = new ESearchCategoryFieldName("moderation");
		public static readonly ESearchCategoryFieldName CATEGORY_NAME = new ESearchCategoryFieldName("name");
		public static readonly ESearchCategoryFieldName CATEGORY_PARENT_ID = new ESearchCategoryFieldName("parent_id");
		public static readonly ESearchCategoryFieldName CATEGORY_PENDING_ENTRIES_COUNT = new ESearchCategoryFieldName("pending_entries_count");
		public static readonly ESearchCategoryFieldName CATEGORY_PENDING_MEMBERS_COUNT = new ESearchCategoryFieldName("pending_members_count");
		public static readonly ESearchCategoryFieldName CATEGORY_PRIVACY = new ESearchCategoryFieldName("privacy");
		public static readonly ESearchCategoryFieldName CATEGORY_PRIVACY_CONTEXT = new ESearchCategoryFieldName("privacy_context");
		public static readonly ESearchCategoryFieldName CATEGORY_PRIVACY_CONTEXTS = new ESearchCategoryFieldName("privacy_contexts");
		public static readonly ESearchCategoryFieldName CATEGORY_REFERENCE_ID = new ESearchCategoryFieldName("reference_id");
		public static readonly ESearchCategoryFieldName CATEGORY_TAGS = new ESearchCategoryFieldName("tags");
		public static readonly ESearchCategoryFieldName CATEGORY_UPDATED_AT = new ESearchCategoryFieldName("updated_at");

		private ESearchCategoryFieldName(string name) : base(name) { }
	}
}
