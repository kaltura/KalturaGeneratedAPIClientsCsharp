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
	public sealed class KalturaLiveStreamAdminEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute ADMIN_TAGS = new KalturaLiveStreamAdminEntryMatchAttribute("adminTags");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute CATEGORIES_IDS = new KalturaLiveStreamAdminEntryMatchAttribute("categoriesIds");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute CREATOR_ID = new KalturaLiveStreamAdminEntryMatchAttribute("creatorId");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute DESCRIPTION = new KalturaLiveStreamAdminEntryMatchAttribute("description");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute DURATION_TYPE = new KalturaLiveStreamAdminEntryMatchAttribute("durationType");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute FLAVOR_PARAMS_IDS = new KalturaLiveStreamAdminEntryMatchAttribute("flavorParamsIds");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute GROUP_ID = new KalturaLiveStreamAdminEntryMatchAttribute("groupId");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute ID = new KalturaLiveStreamAdminEntryMatchAttribute("id");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute NAME = new KalturaLiveStreamAdminEntryMatchAttribute("name");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute REFERENCE_ID = new KalturaLiveStreamAdminEntryMatchAttribute("referenceId");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaLiveStreamAdminEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaLiveStreamAdminEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute SEARCH_TEXT = new KalturaLiveStreamAdminEntryMatchAttribute("searchText");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute TAGS = new KalturaLiveStreamAdminEntryMatchAttribute("tags");
		public static readonly KalturaLiveStreamAdminEntryMatchAttribute USER_ID = new KalturaLiveStreamAdminEntryMatchAttribute("userId");

		private KalturaLiveStreamAdminEntryMatchAttribute(string name) : base(name) { }
	}
}
