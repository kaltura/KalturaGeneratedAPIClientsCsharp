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
	public sealed class DocumentEntryMatchAttribute : StringEnum
	{
		public static readonly DocumentEntryMatchAttribute ADMIN_TAGS = new DocumentEntryMatchAttribute("adminTags");
		public static readonly DocumentEntryMatchAttribute CATEGORIES_IDS = new DocumentEntryMatchAttribute("categoriesIds");
		public static readonly DocumentEntryMatchAttribute CREATOR_ID = new DocumentEntryMatchAttribute("creatorId");
		public static readonly DocumentEntryMatchAttribute DESCRIPTION = new DocumentEntryMatchAttribute("description");
		public static readonly DocumentEntryMatchAttribute GROUP_ID = new DocumentEntryMatchAttribute("groupId");
		public static readonly DocumentEntryMatchAttribute ID = new DocumentEntryMatchAttribute("id");
		public static readonly DocumentEntryMatchAttribute NAME = new DocumentEntryMatchAttribute("name");
		public static readonly DocumentEntryMatchAttribute REFERENCE_ID = new DocumentEntryMatchAttribute("referenceId");
		public static readonly DocumentEntryMatchAttribute REPLACED_ENTRY_ID = new DocumentEntryMatchAttribute("replacedEntryId");
		public static readonly DocumentEntryMatchAttribute REPLACING_ENTRY_ID = new DocumentEntryMatchAttribute("replacingEntryId");
		public static readonly DocumentEntryMatchAttribute SEARCH_TEXT = new DocumentEntryMatchAttribute("searchText");
		public static readonly DocumentEntryMatchAttribute TAGS = new DocumentEntryMatchAttribute("tags");
		public static readonly DocumentEntryMatchAttribute USER_ID = new DocumentEntryMatchAttribute("userId");

		private DocumentEntryMatchAttribute(string name) : base(name) { }
	}
}
