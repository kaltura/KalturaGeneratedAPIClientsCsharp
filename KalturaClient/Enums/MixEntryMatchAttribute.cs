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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class MixEntryMatchAttribute : StringEnum
	{
		public static readonly MixEntryMatchAttribute ADMIN_TAGS = new MixEntryMatchAttribute("adminTags");
		public static readonly MixEntryMatchAttribute CATEGORIES_IDS = new MixEntryMatchAttribute("categoriesIds");
		public static readonly MixEntryMatchAttribute CREATOR_ID = new MixEntryMatchAttribute("creatorId");
		public static readonly MixEntryMatchAttribute DESCRIPTION = new MixEntryMatchAttribute("description");
		public static readonly MixEntryMatchAttribute DURATION_TYPE = new MixEntryMatchAttribute("durationType");
		public static readonly MixEntryMatchAttribute GROUP_ID = new MixEntryMatchAttribute("groupId");
		public static readonly MixEntryMatchAttribute ID = new MixEntryMatchAttribute("id");
		public static readonly MixEntryMatchAttribute NAME = new MixEntryMatchAttribute("name");
		public static readonly MixEntryMatchAttribute REFERENCE_ID = new MixEntryMatchAttribute("referenceId");
		public static readonly MixEntryMatchAttribute REPLACED_ENTRY_ID = new MixEntryMatchAttribute("replacedEntryId");
		public static readonly MixEntryMatchAttribute REPLACING_ENTRY_ID = new MixEntryMatchAttribute("replacingEntryId");
		public static readonly MixEntryMatchAttribute SEARCH_TEXT = new MixEntryMatchAttribute("searchText");
		public static readonly MixEntryMatchAttribute TAGS = new MixEntryMatchAttribute("tags");
		public static readonly MixEntryMatchAttribute USER_ID = new MixEntryMatchAttribute("userId");

		private MixEntryMatchAttribute(string name) : base(name) { }
	}
}
