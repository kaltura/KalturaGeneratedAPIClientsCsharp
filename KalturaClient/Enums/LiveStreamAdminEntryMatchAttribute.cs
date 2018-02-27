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
	public sealed class LiveStreamAdminEntryMatchAttribute : StringEnum
	{
		public static readonly LiveStreamAdminEntryMatchAttribute ADMIN_TAGS = new LiveStreamAdminEntryMatchAttribute("adminTags");
		public static readonly LiveStreamAdminEntryMatchAttribute CATEGORIES_IDS = new LiveStreamAdminEntryMatchAttribute("categoriesIds");
		public static readonly LiveStreamAdminEntryMatchAttribute CREATOR_ID = new LiveStreamAdminEntryMatchAttribute("creatorId");
		public static readonly LiveStreamAdminEntryMatchAttribute DESCRIPTION = new LiveStreamAdminEntryMatchAttribute("description");
		public static readonly LiveStreamAdminEntryMatchAttribute DURATION_TYPE = new LiveStreamAdminEntryMatchAttribute("durationType");
		public static readonly LiveStreamAdminEntryMatchAttribute FLAVOR_PARAMS_IDS = new LiveStreamAdminEntryMatchAttribute("flavorParamsIds");
		public static readonly LiveStreamAdminEntryMatchAttribute GROUP_ID = new LiveStreamAdminEntryMatchAttribute("groupId");
		public static readonly LiveStreamAdminEntryMatchAttribute ID = new LiveStreamAdminEntryMatchAttribute("id");
		public static readonly LiveStreamAdminEntryMatchAttribute NAME = new LiveStreamAdminEntryMatchAttribute("name");
		public static readonly LiveStreamAdminEntryMatchAttribute REFERENCE_ID = new LiveStreamAdminEntryMatchAttribute("referenceId");
		public static readonly LiveStreamAdminEntryMatchAttribute REPLACED_ENTRY_ID = new LiveStreamAdminEntryMatchAttribute("replacedEntryId");
		public static readonly LiveStreamAdminEntryMatchAttribute REPLACING_ENTRY_ID = new LiveStreamAdminEntryMatchAttribute("replacingEntryId");
		public static readonly LiveStreamAdminEntryMatchAttribute SEARCH_TEXT = new LiveStreamAdminEntryMatchAttribute("searchText");
		public static readonly LiveStreamAdminEntryMatchAttribute TAGS = new LiveStreamAdminEntryMatchAttribute("tags");
		public static readonly LiveStreamAdminEntryMatchAttribute USER_ID = new LiveStreamAdminEntryMatchAttribute("userId");

		private LiveStreamAdminEntryMatchAttribute(string name) : base(name) { }
	}
}
