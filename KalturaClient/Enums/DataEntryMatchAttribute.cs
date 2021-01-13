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
	public sealed class DataEntryMatchAttribute : StringEnum
	{
		public static readonly DataEntryMatchAttribute ADMIN_TAGS = new DataEntryMatchAttribute("adminTags");
		public static readonly DataEntryMatchAttribute CATEGORIES_IDS = new DataEntryMatchAttribute("categoriesIds");
		public static readonly DataEntryMatchAttribute CREATOR_ID = new DataEntryMatchAttribute("creatorId");
		public static readonly DataEntryMatchAttribute DESCRIPTION = new DataEntryMatchAttribute("description");
		public static readonly DataEntryMatchAttribute GROUP_ID = new DataEntryMatchAttribute("groupId");
		public static readonly DataEntryMatchAttribute ID = new DataEntryMatchAttribute("id");
		public static readonly DataEntryMatchAttribute NAME = new DataEntryMatchAttribute("name");
		public static readonly DataEntryMatchAttribute REFERENCE_ID = new DataEntryMatchAttribute("referenceId");
		public static readonly DataEntryMatchAttribute REPLACED_ENTRY_ID = new DataEntryMatchAttribute("replacedEntryId");
		public static readonly DataEntryMatchAttribute REPLACING_ENTRY_ID = new DataEntryMatchAttribute("replacingEntryId");
		public static readonly DataEntryMatchAttribute SEARCH_TEXT = new DataEntryMatchAttribute("searchText");
		public static readonly DataEntryMatchAttribute TAGS = new DataEntryMatchAttribute("tags");
		public static readonly DataEntryMatchAttribute USER_ID = new DataEntryMatchAttribute("userId");

		private DataEntryMatchAttribute(string name) : base(name) { }
	}
}
