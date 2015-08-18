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
	public sealed class KalturaMediaEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaMediaEntryMatchAttribute ADMIN_TAGS = new KalturaMediaEntryMatchAttribute("adminTags");
		public static readonly KalturaMediaEntryMatchAttribute CATEGORIES_IDS = new KalturaMediaEntryMatchAttribute("categoriesIds");
		public static readonly KalturaMediaEntryMatchAttribute CREATOR_ID = new KalturaMediaEntryMatchAttribute("creatorId");
		public static readonly KalturaMediaEntryMatchAttribute DESCRIPTION = new KalturaMediaEntryMatchAttribute("description");
		public static readonly KalturaMediaEntryMatchAttribute DURATION_TYPE = new KalturaMediaEntryMatchAttribute("durationType");
		public static readonly KalturaMediaEntryMatchAttribute FLAVOR_PARAMS_IDS = new KalturaMediaEntryMatchAttribute("flavorParamsIds");
		public static readonly KalturaMediaEntryMatchAttribute GROUP_ID = new KalturaMediaEntryMatchAttribute("groupId");
		public static readonly KalturaMediaEntryMatchAttribute ID = new KalturaMediaEntryMatchAttribute("id");
		public static readonly KalturaMediaEntryMatchAttribute NAME = new KalturaMediaEntryMatchAttribute("name");
		public static readonly KalturaMediaEntryMatchAttribute REFERENCE_ID = new KalturaMediaEntryMatchAttribute("referenceId");
		public static readonly KalturaMediaEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaMediaEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaMediaEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaMediaEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaMediaEntryMatchAttribute SEARCH_TEXT = new KalturaMediaEntryMatchAttribute("searchText");
		public static readonly KalturaMediaEntryMatchAttribute TAGS = new KalturaMediaEntryMatchAttribute("tags");
		public static readonly KalturaMediaEntryMatchAttribute USER_ID = new KalturaMediaEntryMatchAttribute("userId");

		private KalturaMediaEntryMatchAttribute(string name) : base(name) { }
	}
}
