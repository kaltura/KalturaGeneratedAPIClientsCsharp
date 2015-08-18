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
// Copyright (C) 2006-2015  Kaltura Inc.
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
namespace Kaltura
{
	public sealed class KalturaPlayableEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaPlayableEntryMatchAttribute ADMIN_TAGS = new KalturaPlayableEntryMatchAttribute("adminTags");
		public static readonly KalturaPlayableEntryMatchAttribute CATEGORIES_IDS = new KalturaPlayableEntryMatchAttribute("categoriesIds");
		public static readonly KalturaPlayableEntryMatchAttribute CREATOR_ID = new KalturaPlayableEntryMatchAttribute("creatorId");
		public static readonly KalturaPlayableEntryMatchAttribute DESCRIPTION = new KalturaPlayableEntryMatchAttribute("description");
		public static readonly KalturaPlayableEntryMatchAttribute DURATION_TYPE = new KalturaPlayableEntryMatchAttribute("durationType");
		public static readonly KalturaPlayableEntryMatchAttribute GROUP_ID = new KalturaPlayableEntryMatchAttribute("groupId");
		public static readonly KalturaPlayableEntryMatchAttribute ID = new KalturaPlayableEntryMatchAttribute("id");
		public static readonly KalturaPlayableEntryMatchAttribute NAME = new KalturaPlayableEntryMatchAttribute("name");
		public static readonly KalturaPlayableEntryMatchAttribute REFERENCE_ID = new KalturaPlayableEntryMatchAttribute("referenceId");
		public static readonly KalturaPlayableEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaPlayableEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaPlayableEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaPlayableEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaPlayableEntryMatchAttribute SEARCH_TEXT = new KalturaPlayableEntryMatchAttribute("searchText");
		public static readonly KalturaPlayableEntryMatchAttribute TAGS = new KalturaPlayableEntryMatchAttribute("tags");
		public static readonly KalturaPlayableEntryMatchAttribute USER_ID = new KalturaPlayableEntryMatchAttribute("userId");

		private KalturaPlayableEntryMatchAttribute(string name) : base(name) { }
	}
}
