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
	public sealed class LiveStreamEntryMatchAttribute : StringEnum
	{
		public static readonly LiveStreamEntryMatchAttribute ADMIN_TAGS = new LiveStreamEntryMatchAttribute("adminTags");
		public static readonly LiveStreamEntryMatchAttribute CATEGORIES_IDS = new LiveStreamEntryMatchAttribute("categoriesIds");
		public static readonly LiveStreamEntryMatchAttribute CREATOR_ID = new LiveStreamEntryMatchAttribute("creatorId");
		public static readonly LiveStreamEntryMatchAttribute DESCRIPTION = new LiveStreamEntryMatchAttribute("description");
		public static readonly LiveStreamEntryMatchAttribute DURATION_TYPE = new LiveStreamEntryMatchAttribute("durationType");
		public static readonly LiveStreamEntryMatchAttribute FLAVOR_PARAMS_IDS = new LiveStreamEntryMatchAttribute("flavorParamsIds");
		public static readonly LiveStreamEntryMatchAttribute GROUP_ID = new LiveStreamEntryMatchAttribute("groupId");
		public static readonly LiveStreamEntryMatchAttribute ID = new LiveStreamEntryMatchAttribute("id");
		public static readonly LiveStreamEntryMatchAttribute NAME = new LiveStreamEntryMatchAttribute("name");
		public static readonly LiveStreamEntryMatchAttribute REFERENCE_ID = new LiveStreamEntryMatchAttribute("referenceId");
		public static readonly LiveStreamEntryMatchAttribute REPLACED_ENTRY_ID = new LiveStreamEntryMatchAttribute("replacedEntryId");
		public static readonly LiveStreamEntryMatchAttribute REPLACING_ENTRY_ID = new LiveStreamEntryMatchAttribute("replacingEntryId");
		public static readonly LiveStreamEntryMatchAttribute SEARCH_TEXT = new LiveStreamEntryMatchAttribute("searchText");
		public static readonly LiveStreamEntryMatchAttribute TAGS = new LiveStreamEntryMatchAttribute("tags");
		public static readonly LiveStreamEntryMatchAttribute USER_ID = new LiveStreamEntryMatchAttribute("userId");

		private LiveStreamEntryMatchAttribute(string name) : base(name) { }
	}
}
