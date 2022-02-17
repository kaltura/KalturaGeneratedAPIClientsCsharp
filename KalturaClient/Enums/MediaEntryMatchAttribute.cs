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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class MediaEntryMatchAttribute : StringEnum
	{
		public static readonly MediaEntryMatchAttribute ADMIN_TAGS = new MediaEntryMatchAttribute("adminTags");
		public static readonly MediaEntryMatchAttribute CATEGORIES_IDS = new MediaEntryMatchAttribute("categoriesIds");
		public static readonly MediaEntryMatchAttribute CREATOR_ID = new MediaEntryMatchAttribute("creatorId");
		public static readonly MediaEntryMatchAttribute DESCRIPTION = new MediaEntryMatchAttribute("description");
		public static readonly MediaEntryMatchAttribute DURATION_TYPE = new MediaEntryMatchAttribute("durationType");
		public static readonly MediaEntryMatchAttribute FLAVOR_PARAMS_IDS = new MediaEntryMatchAttribute("flavorParamsIds");
		public static readonly MediaEntryMatchAttribute GROUP_ID = new MediaEntryMatchAttribute("groupId");
		public static readonly MediaEntryMatchAttribute ID = new MediaEntryMatchAttribute("id");
		public static readonly MediaEntryMatchAttribute NAME = new MediaEntryMatchAttribute("name");
		public static readonly MediaEntryMatchAttribute REFERENCE_ID = new MediaEntryMatchAttribute("referenceId");
		public static readonly MediaEntryMatchAttribute REPLACED_ENTRY_ID = new MediaEntryMatchAttribute("replacedEntryId");
		public static readonly MediaEntryMatchAttribute REPLACING_ENTRY_ID = new MediaEntryMatchAttribute("replacingEntryId");
		public static readonly MediaEntryMatchAttribute SEARCH_TEXT = new MediaEntryMatchAttribute("searchText");
		public static readonly MediaEntryMatchAttribute TAGS = new MediaEntryMatchAttribute("tags");
		public static readonly MediaEntryMatchAttribute USER_ID = new MediaEntryMatchAttribute("userId");

		private MediaEntryMatchAttribute(string name) : base(name) { }
	}
}
