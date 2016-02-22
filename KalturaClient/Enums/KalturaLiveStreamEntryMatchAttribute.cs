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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public sealed class KalturaLiveStreamEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamEntryMatchAttribute ADMIN_TAGS = new KalturaLiveStreamEntryMatchAttribute("adminTags");
		public static readonly KalturaLiveStreamEntryMatchAttribute CATEGORIES_IDS = new KalturaLiveStreamEntryMatchAttribute("categoriesIds");
		public static readonly KalturaLiveStreamEntryMatchAttribute CREATOR_ID = new KalturaLiveStreamEntryMatchAttribute("creatorId");
		public static readonly KalturaLiveStreamEntryMatchAttribute DESCRIPTION = new KalturaLiveStreamEntryMatchAttribute("description");
		public static readonly KalturaLiveStreamEntryMatchAttribute DURATION_TYPE = new KalturaLiveStreamEntryMatchAttribute("durationType");
		public static readonly KalturaLiveStreamEntryMatchAttribute FLAVOR_PARAMS_IDS = new KalturaLiveStreamEntryMatchAttribute("flavorParamsIds");
		public static readonly KalturaLiveStreamEntryMatchAttribute GROUP_ID = new KalturaLiveStreamEntryMatchAttribute("groupId");
		public static readonly KalturaLiveStreamEntryMatchAttribute ID = new KalturaLiveStreamEntryMatchAttribute("id");
		public static readonly KalturaLiveStreamEntryMatchAttribute NAME = new KalturaLiveStreamEntryMatchAttribute("name");
		public static readonly KalturaLiveStreamEntryMatchAttribute REFERENCE_ID = new KalturaLiveStreamEntryMatchAttribute("referenceId");
		public static readonly KalturaLiveStreamEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaLiveStreamEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaLiveStreamEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaLiveStreamEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaLiveStreamEntryMatchAttribute SEARCH_TEXT = new KalturaLiveStreamEntryMatchAttribute("searchText");
		public static readonly KalturaLiveStreamEntryMatchAttribute TAGS = new KalturaLiveStreamEntryMatchAttribute("tags");
		public static readonly KalturaLiveStreamEntryMatchAttribute USER_ID = new KalturaLiveStreamEntryMatchAttribute("userId");

		private KalturaLiveStreamEntryMatchAttribute(string name) : base(name) { }
	}
}
