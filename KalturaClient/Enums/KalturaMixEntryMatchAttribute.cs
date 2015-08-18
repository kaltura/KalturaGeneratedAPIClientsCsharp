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
	public sealed class KalturaMixEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaMixEntryMatchAttribute ADMIN_TAGS = new KalturaMixEntryMatchAttribute("adminTags");
		public static readonly KalturaMixEntryMatchAttribute CATEGORIES_IDS = new KalturaMixEntryMatchAttribute("categoriesIds");
		public static readonly KalturaMixEntryMatchAttribute CREATOR_ID = new KalturaMixEntryMatchAttribute("creatorId");
		public static readonly KalturaMixEntryMatchAttribute DESCRIPTION = new KalturaMixEntryMatchAttribute("description");
		public static readonly KalturaMixEntryMatchAttribute DURATION_TYPE = new KalturaMixEntryMatchAttribute("durationType");
		public static readonly KalturaMixEntryMatchAttribute GROUP_ID = new KalturaMixEntryMatchAttribute("groupId");
		public static readonly KalturaMixEntryMatchAttribute ID = new KalturaMixEntryMatchAttribute("id");
		public static readonly KalturaMixEntryMatchAttribute NAME = new KalturaMixEntryMatchAttribute("name");
		public static readonly KalturaMixEntryMatchAttribute REFERENCE_ID = new KalturaMixEntryMatchAttribute("referenceId");
		public static readonly KalturaMixEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaMixEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaMixEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaMixEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaMixEntryMatchAttribute SEARCH_TEXT = new KalturaMixEntryMatchAttribute("searchText");
		public static readonly KalturaMixEntryMatchAttribute TAGS = new KalturaMixEntryMatchAttribute("tags");
		public static readonly KalturaMixEntryMatchAttribute USER_ID = new KalturaMixEntryMatchAttribute("userId");

		private KalturaMixEntryMatchAttribute(string name) : base(name) { }
	}
}
