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
	public sealed class KalturaPlaylistMatchAttribute : KalturaStringEnum
	{
		public static readonly KalturaPlaylistMatchAttribute ADMIN_TAGS = new KalturaPlaylistMatchAttribute("adminTags");
		public static readonly KalturaPlaylistMatchAttribute CATEGORIES_IDS = new KalturaPlaylistMatchAttribute("categoriesIds");
		public static readonly KalturaPlaylistMatchAttribute CREATOR_ID = new KalturaPlaylistMatchAttribute("creatorId");
		public static readonly KalturaPlaylistMatchAttribute DESCRIPTION = new KalturaPlaylistMatchAttribute("description");
		public static readonly KalturaPlaylistMatchAttribute GROUP_ID = new KalturaPlaylistMatchAttribute("groupId");
		public static readonly KalturaPlaylistMatchAttribute ID = new KalturaPlaylistMatchAttribute("id");
		public static readonly KalturaPlaylistMatchAttribute NAME = new KalturaPlaylistMatchAttribute("name");
		public static readonly KalturaPlaylistMatchAttribute REFERENCE_ID = new KalturaPlaylistMatchAttribute("referenceId");
		public static readonly KalturaPlaylistMatchAttribute REPLACED_ENTRY_ID = new KalturaPlaylistMatchAttribute("replacedEntryId");
		public static readonly KalturaPlaylistMatchAttribute REPLACING_ENTRY_ID = new KalturaPlaylistMatchAttribute("replacingEntryId");
		public static readonly KalturaPlaylistMatchAttribute SEARCH_TEXT = new KalturaPlaylistMatchAttribute("searchText");
		public static readonly KalturaPlaylistMatchAttribute TAGS = new KalturaPlaylistMatchAttribute("tags");
		public static readonly KalturaPlaylistMatchAttribute USER_ID = new KalturaPlaylistMatchAttribute("userId");

		private KalturaPlaylistMatchAttribute(string name) : base(name) { }
	}
}
