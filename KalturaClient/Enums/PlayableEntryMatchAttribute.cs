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
	public sealed class PlayableEntryMatchAttribute : StringEnum
	{
		public static readonly PlayableEntryMatchAttribute ADMIN_TAGS = new PlayableEntryMatchAttribute("adminTags");
		public static readonly PlayableEntryMatchAttribute CATEGORIES_IDS = new PlayableEntryMatchAttribute("categoriesIds");
		public static readonly PlayableEntryMatchAttribute CREATOR_ID = new PlayableEntryMatchAttribute("creatorId");
		public static readonly PlayableEntryMatchAttribute DESCRIPTION = new PlayableEntryMatchAttribute("description");
		public static readonly PlayableEntryMatchAttribute DURATION_TYPE = new PlayableEntryMatchAttribute("durationType");
		public static readonly PlayableEntryMatchAttribute GROUP_ID = new PlayableEntryMatchAttribute("groupId");
		public static readonly PlayableEntryMatchAttribute ID = new PlayableEntryMatchAttribute("id");
		public static readonly PlayableEntryMatchAttribute NAME = new PlayableEntryMatchAttribute("name");
		public static readonly PlayableEntryMatchAttribute REFERENCE_ID = new PlayableEntryMatchAttribute("referenceId");
		public static readonly PlayableEntryMatchAttribute REPLACED_ENTRY_ID = new PlayableEntryMatchAttribute("replacedEntryId");
		public static readonly PlayableEntryMatchAttribute REPLACING_ENTRY_ID = new PlayableEntryMatchAttribute("replacingEntryId");
		public static readonly PlayableEntryMatchAttribute SEARCH_TEXT = new PlayableEntryMatchAttribute("searchText");
		public static readonly PlayableEntryMatchAttribute TAGS = new PlayableEntryMatchAttribute("tags");
		public static readonly PlayableEntryMatchAttribute USER_ID = new PlayableEntryMatchAttribute("userId");

		private PlayableEntryMatchAttribute(string name) : base(name) { }
	}
}
