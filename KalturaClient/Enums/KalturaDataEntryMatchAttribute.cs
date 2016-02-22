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
	public sealed class KalturaDataEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaDataEntryMatchAttribute ADMIN_TAGS = new KalturaDataEntryMatchAttribute("adminTags");
		public static readonly KalturaDataEntryMatchAttribute CATEGORIES_IDS = new KalturaDataEntryMatchAttribute("categoriesIds");
		public static readonly KalturaDataEntryMatchAttribute CREATOR_ID = new KalturaDataEntryMatchAttribute("creatorId");
		public static readonly KalturaDataEntryMatchAttribute DESCRIPTION = new KalturaDataEntryMatchAttribute("description");
		public static readonly KalturaDataEntryMatchAttribute GROUP_ID = new KalturaDataEntryMatchAttribute("groupId");
		public static readonly KalturaDataEntryMatchAttribute ID = new KalturaDataEntryMatchAttribute("id");
		public static readonly KalturaDataEntryMatchAttribute NAME = new KalturaDataEntryMatchAttribute("name");
		public static readonly KalturaDataEntryMatchAttribute REFERENCE_ID = new KalturaDataEntryMatchAttribute("referenceId");
		public static readonly KalturaDataEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaDataEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaDataEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaDataEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaDataEntryMatchAttribute SEARCH_TEXT = new KalturaDataEntryMatchAttribute("searchText");
		public static readonly KalturaDataEntryMatchAttribute TAGS = new KalturaDataEntryMatchAttribute("tags");
		public static readonly KalturaDataEntryMatchAttribute USER_ID = new KalturaDataEntryMatchAttribute("userId");

		private KalturaDataEntryMatchAttribute(string name) : base(name) { }
	}
}
