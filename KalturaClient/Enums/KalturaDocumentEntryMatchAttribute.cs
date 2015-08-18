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
	public sealed class KalturaDocumentEntryMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaDocumentEntryMatchAttribute ADMIN_TAGS = new KalturaDocumentEntryMatchAttribute("adminTags");
		public static readonly KalturaDocumentEntryMatchAttribute CATEGORIES_IDS = new KalturaDocumentEntryMatchAttribute("categoriesIds");
		public static readonly KalturaDocumentEntryMatchAttribute CREATOR_ID = new KalturaDocumentEntryMatchAttribute("creatorId");
		public static readonly KalturaDocumentEntryMatchAttribute DESCRIPTION = new KalturaDocumentEntryMatchAttribute("description");
		public static readonly KalturaDocumentEntryMatchAttribute GROUP_ID = new KalturaDocumentEntryMatchAttribute("groupId");
		public static readonly KalturaDocumentEntryMatchAttribute ID = new KalturaDocumentEntryMatchAttribute("id");
		public static readonly KalturaDocumentEntryMatchAttribute NAME = new KalturaDocumentEntryMatchAttribute("name");
		public static readonly KalturaDocumentEntryMatchAttribute REFERENCE_ID = new KalturaDocumentEntryMatchAttribute("referenceId");
		public static readonly KalturaDocumentEntryMatchAttribute REPLACED_ENTRY_ID = new KalturaDocumentEntryMatchAttribute("replacedEntryId");
		public static readonly KalturaDocumentEntryMatchAttribute REPLACING_ENTRY_ID = new KalturaDocumentEntryMatchAttribute("replacingEntryId");
		public static readonly KalturaDocumentEntryMatchAttribute SEARCH_TEXT = new KalturaDocumentEntryMatchAttribute("searchText");
		public static readonly KalturaDocumentEntryMatchAttribute TAGS = new KalturaDocumentEntryMatchAttribute("tags");
		public static readonly KalturaDocumentEntryMatchAttribute USER_ID = new KalturaDocumentEntryMatchAttribute("userId");

		private KalturaDocumentEntryMatchAttribute(string name) : base(name) { }
	}
}
