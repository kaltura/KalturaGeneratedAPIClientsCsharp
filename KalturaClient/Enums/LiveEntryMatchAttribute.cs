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
	public sealed class LiveEntryMatchAttribute : StringEnum
	{
		public static readonly LiveEntryMatchAttribute ADMIN_TAGS = new LiveEntryMatchAttribute("adminTags");
		public static readonly LiveEntryMatchAttribute CATEGORIES_IDS = new LiveEntryMatchAttribute("categoriesIds");
		public static readonly LiveEntryMatchAttribute CREATOR_ID = new LiveEntryMatchAttribute("creatorId");
		public static readonly LiveEntryMatchAttribute DESCRIPTION = new LiveEntryMatchAttribute("description");
		public static readonly LiveEntryMatchAttribute DURATION_TYPE = new LiveEntryMatchAttribute("durationType");
		public static readonly LiveEntryMatchAttribute FLAVOR_PARAMS_IDS = new LiveEntryMatchAttribute("flavorParamsIds");
		public static readonly LiveEntryMatchAttribute GROUP_ID = new LiveEntryMatchAttribute("groupId");
		public static readonly LiveEntryMatchAttribute ID = new LiveEntryMatchAttribute("id");
		public static readonly LiveEntryMatchAttribute NAME = new LiveEntryMatchAttribute("name");
		public static readonly LiveEntryMatchAttribute REFERENCE_ID = new LiveEntryMatchAttribute("referenceId");
		public static readonly LiveEntryMatchAttribute REPLACED_ENTRY_ID = new LiveEntryMatchAttribute("replacedEntryId");
		public static readonly LiveEntryMatchAttribute REPLACING_ENTRY_ID = new LiveEntryMatchAttribute("replacingEntryId");
		public static readonly LiveEntryMatchAttribute SEARCH_TEXT = new LiveEntryMatchAttribute("searchText");
		public static readonly LiveEntryMatchAttribute TAGS = new LiveEntryMatchAttribute("tags");
		public static readonly LiveEntryMatchAttribute USER_ID = new LiveEntryMatchAttribute("userId");

		private LiveEntryMatchAttribute(string name) : base(name) { }
	}
}
