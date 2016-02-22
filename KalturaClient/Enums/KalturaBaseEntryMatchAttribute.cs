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
	public sealed class KalturaBaseEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaBaseEntryMatchAttribute ADMIN_TAGS = new KalturaBaseEntryMatchAttribute("adminTags");
		public static readonly KalturaBaseEntryMatchAttribute CATEGORIES_IDS = new KalturaBaseEntryMatchAttribute("categoriesIds");
		public static readonly KalturaBaseEntryMatchAttribute CREATOR_ID = new KalturaBaseEntryMatchAttribute("creatorId");
		public static readonly KalturaBaseEntryMatchAttribute DESCRIPTION = new KalturaBaseEntryMatchAttribute("description");
		public static readonly KalturaBaseEntryMatchAttribute GROUP_ID = new KalturaBaseEntryMatchAttribute("groupId");
		public static readonly KalturaBaseEntryMatchAttribute ID = new KalturaBaseEntryMatchAttribute("id");
		public static readonly KalturaBaseEntryMatchAttribute NAME = new KalturaBaseEntryMatchAttribute("name");
		public static readonly KalturaBaseEntryMatchAttribute REFERENCE_ID = new KalturaBaseEntryMatchAttribute("referenceId");
		public static readonly KalturaBaseEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaBaseEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaBaseEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaBaseEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaBaseEntryMatchAttribute SEARCH_TEXT = new KalturaBaseEntryMatchAttribute("searchText");
		public static readonly KalturaBaseEntryMatchAttribute TAGS = new KalturaBaseEntryMatchAttribute("tags");
		public static readonly KalturaBaseEntryMatchAttribute USER_ID = new KalturaBaseEntryMatchAttribute("userId");

		private KalturaBaseEntryMatchAttribute(string name) : base(name) { }
	}
}
