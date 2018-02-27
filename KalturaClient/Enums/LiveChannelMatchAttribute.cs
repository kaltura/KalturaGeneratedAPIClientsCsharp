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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class LiveChannelMatchAttribute : StringEnum
	{
		public static readonly LiveChannelMatchAttribute ADMIN_TAGS = new LiveChannelMatchAttribute("adminTags");
		public static readonly LiveChannelMatchAttribute CATEGORIES_IDS = new LiveChannelMatchAttribute("categoriesIds");
		public static readonly LiveChannelMatchAttribute CREATOR_ID = new LiveChannelMatchAttribute("creatorId");
		public static readonly LiveChannelMatchAttribute DESCRIPTION = new LiveChannelMatchAttribute("description");
		public static readonly LiveChannelMatchAttribute DURATION_TYPE = new LiveChannelMatchAttribute("durationType");
		public static readonly LiveChannelMatchAttribute FLAVOR_PARAMS_IDS = new LiveChannelMatchAttribute("flavorParamsIds");
		public static readonly LiveChannelMatchAttribute GROUP_ID = new LiveChannelMatchAttribute("groupId");
		public static readonly LiveChannelMatchAttribute ID = new LiveChannelMatchAttribute("id");
		public static readonly LiveChannelMatchAttribute NAME = new LiveChannelMatchAttribute("name");
		public static readonly LiveChannelMatchAttribute REFERENCE_ID = new LiveChannelMatchAttribute("referenceId");
		public static readonly LiveChannelMatchAttribute REPLACED_ENTRY_ID = new LiveChannelMatchAttribute("replacedEntryId");
		public static readonly LiveChannelMatchAttribute REPLACING_ENTRY_ID = new LiveChannelMatchAttribute("replacingEntryId");
		public static readonly LiveChannelMatchAttribute SEARCH_TEXT = new LiveChannelMatchAttribute("searchText");
		public static readonly LiveChannelMatchAttribute TAGS = new LiveChannelMatchAttribute("tags");
		public static readonly LiveChannelMatchAttribute USER_ID = new LiveChannelMatchAttribute("userId");

		private LiveChannelMatchAttribute(string name) : base(name) { }
	}
}
