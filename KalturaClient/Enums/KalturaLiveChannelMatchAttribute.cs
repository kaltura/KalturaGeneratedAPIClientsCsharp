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
	public sealed class KalturaLiveChannelMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveChannelMatchAttribute ADMIN_TAGS = new KalturaLiveChannelMatchAttribute("adminTags");
		public static readonly KalturaLiveChannelMatchAttribute CATEGORIES_IDS = new KalturaLiveChannelMatchAttribute("categoriesIds");
		public static readonly KalturaLiveChannelMatchAttribute CREATOR_ID = new KalturaLiveChannelMatchAttribute("creatorId");
		public static readonly KalturaLiveChannelMatchAttribute DESCRIPTION = new KalturaLiveChannelMatchAttribute("description");
		public static readonly KalturaLiveChannelMatchAttribute DURATION_TYPE = new KalturaLiveChannelMatchAttribute("durationType");
		public static readonly KalturaLiveChannelMatchAttribute FLAVOR_PARAMS_IDS = new KalturaLiveChannelMatchAttribute("flavorParamsIds");
		public static readonly KalturaLiveChannelMatchAttribute GROUP_ID = new KalturaLiveChannelMatchAttribute("groupId");
		public static readonly KalturaLiveChannelMatchAttribute ID = new KalturaLiveChannelMatchAttribute("id");
		public static readonly KalturaLiveChannelMatchAttribute NAME = new KalturaLiveChannelMatchAttribute("name");
		public static readonly KalturaLiveChannelMatchAttribute REFERENCE_ID = new KalturaLiveChannelMatchAttribute("referenceId");
		public static readonly KalturaLiveChannelMatchAttribute REPLACED_ENTRY_ID = new KalturaLiveChannelMatchAttribute("replacedEntryId");
		public static readonly KalturaLiveChannelMatchAttribute REPLACING_ENTRY_ID = new KalturaLiveChannelMatchAttribute("replacingEntryId");
		public static readonly KalturaLiveChannelMatchAttribute SEARCH_TEXT = new KalturaLiveChannelMatchAttribute("searchText");
		public static readonly KalturaLiveChannelMatchAttribute TAGS = new KalturaLiveChannelMatchAttribute("tags");
		public static readonly KalturaLiveChannelMatchAttribute USER_ID = new KalturaLiveChannelMatchAttribute("userId");

		private KalturaLiveChannelMatchAttribute(string name) : base(name) { }
	}
}
