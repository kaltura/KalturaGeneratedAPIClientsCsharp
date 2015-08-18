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
	public sealed class KalturaLiveEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveEntryMatchAttribute ADMIN_TAGS = new KalturaLiveEntryMatchAttribute("adminTags");
		public static readonly KalturaLiveEntryMatchAttribute CATEGORIES_IDS = new KalturaLiveEntryMatchAttribute("categoriesIds");
		public static readonly KalturaLiveEntryMatchAttribute CREATOR_ID = new KalturaLiveEntryMatchAttribute("creatorId");
		public static readonly KalturaLiveEntryMatchAttribute DESCRIPTION = new KalturaLiveEntryMatchAttribute("description");
		public static readonly KalturaLiveEntryMatchAttribute DURATION_TYPE = new KalturaLiveEntryMatchAttribute("durationType");
		public static readonly KalturaLiveEntryMatchAttribute FLAVOR_PARAMS_IDS = new KalturaLiveEntryMatchAttribute("flavorParamsIds");
		public static readonly KalturaLiveEntryMatchAttribute GROUP_ID = new KalturaLiveEntryMatchAttribute("groupId");
		public static readonly KalturaLiveEntryMatchAttribute ID = new KalturaLiveEntryMatchAttribute("id");
		public static readonly KalturaLiveEntryMatchAttribute NAME = new KalturaLiveEntryMatchAttribute("name");
		public static readonly KalturaLiveEntryMatchAttribute REFERENCE_ID = new KalturaLiveEntryMatchAttribute("referenceId");
		public static readonly KalturaLiveEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaLiveEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaLiveEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaLiveEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaLiveEntryMatchAttribute SEARCH_TEXT = new KalturaLiveEntryMatchAttribute("searchText");
		public static readonly KalturaLiveEntryMatchAttribute TAGS = new KalturaLiveEntryMatchAttribute("tags");
		public static readonly KalturaLiveEntryMatchAttribute USER_ID = new KalturaLiveEntryMatchAttribute("userId");

		private KalturaLiveEntryMatchAttribute(string name) : base(name) { }
	}
}
