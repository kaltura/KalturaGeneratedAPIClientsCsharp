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
namespace Kaltura.Enums
{
	public sealed class BaseEntryMatchAttribute : StringEnum
	{
		public static readonly BaseEntryMatchAttribute ADMIN_TAGS = new BaseEntryMatchAttribute("adminTags");
		public static readonly BaseEntryMatchAttribute CATEGORIES_IDS = new BaseEntryMatchAttribute("categoriesIds");
		public static readonly BaseEntryMatchAttribute CREATOR_ID = new BaseEntryMatchAttribute("creatorId");
		public static readonly BaseEntryMatchAttribute DESCRIPTION = new BaseEntryMatchAttribute("description");
		public static readonly BaseEntryMatchAttribute GROUP_ID = new BaseEntryMatchAttribute("groupId");
		public static readonly BaseEntryMatchAttribute ID = new BaseEntryMatchAttribute("id");
		public static readonly BaseEntryMatchAttribute NAME = new BaseEntryMatchAttribute("name");
		public static readonly BaseEntryMatchAttribute REFERENCE_ID = new BaseEntryMatchAttribute("referenceId");
		public static readonly BaseEntryMatchAttribute REPLACED_ENTRY_ID = new BaseEntryMatchAttribute("replacedEntryId");
		public static readonly BaseEntryMatchAttribute REPLACING_ENTRY_ID = new BaseEntryMatchAttribute("replacingEntryId");
		public static readonly BaseEntryMatchAttribute SEARCH_TEXT = new BaseEntryMatchAttribute("searchText");
		public static readonly BaseEntryMatchAttribute TAGS = new BaseEntryMatchAttribute("tags");
		public static readonly BaseEntryMatchAttribute USER_ID = new BaseEntryMatchAttribute("userId");

		private BaseEntryMatchAttribute(string name) : base(name) { }
	}
}
