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
	public sealed class KalturaExternalMediaEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaExternalMediaEntryMatchAttribute ADMIN_TAGS = new KalturaExternalMediaEntryMatchAttribute("adminTags");
		public static readonly KalturaExternalMediaEntryMatchAttribute CATEGORIES_IDS = new KalturaExternalMediaEntryMatchAttribute("categoriesIds");
		public static readonly KalturaExternalMediaEntryMatchAttribute CREATOR_ID = new KalturaExternalMediaEntryMatchAttribute("creatorId");
		public static readonly KalturaExternalMediaEntryMatchAttribute DESCRIPTION = new KalturaExternalMediaEntryMatchAttribute("description");
		public static readonly KalturaExternalMediaEntryMatchAttribute DURATION_TYPE = new KalturaExternalMediaEntryMatchAttribute("durationType");
		public static readonly KalturaExternalMediaEntryMatchAttribute FLAVOR_PARAMS_IDS = new KalturaExternalMediaEntryMatchAttribute("flavorParamsIds");
		public static readonly KalturaExternalMediaEntryMatchAttribute GROUP_ID = new KalturaExternalMediaEntryMatchAttribute("groupId");
		public static readonly KalturaExternalMediaEntryMatchAttribute ID = new KalturaExternalMediaEntryMatchAttribute("id");
		public static readonly KalturaExternalMediaEntryMatchAttribute NAME = new KalturaExternalMediaEntryMatchAttribute("name");
		public static readonly KalturaExternalMediaEntryMatchAttribute REFERENCE_ID = new KalturaExternalMediaEntryMatchAttribute("referenceId");
		public static readonly KalturaExternalMediaEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaExternalMediaEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaExternalMediaEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaExternalMediaEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaExternalMediaEntryMatchAttribute SEARCH_TEXT = new KalturaExternalMediaEntryMatchAttribute("searchText");
		public static readonly KalturaExternalMediaEntryMatchAttribute TAGS = new KalturaExternalMediaEntryMatchAttribute("tags");
		public static readonly KalturaExternalMediaEntryMatchAttribute USER_ID = new KalturaExternalMediaEntryMatchAttribute("userId");

		private KalturaExternalMediaEntryMatchAttribute(string name) : base(name) { }
	}
}
