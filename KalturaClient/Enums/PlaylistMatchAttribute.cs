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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class PlaylistMatchAttribute : StringEnum
	{
		public static readonly PlaylistMatchAttribute ADMIN_TAGS = new PlaylistMatchAttribute("adminTags");
		public static readonly PlaylistMatchAttribute CATEGORIES_IDS = new PlaylistMatchAttribute("categoriesIds");
		public static readonly PlaylistMatchAttribute CREATOR_ID = new PlaylistMatchAttribute("creatorId");
		public static readonly PlaylistMatchAttribute DESCRIPTION = new PlaylistMatchAttribute("description");
		public static readonly PlaylistMatchAttribute GROUP_ID = new PlaylistMatchAttribute("groupId");
		public static readonly PlaylistMatchAttribute ID = new PlaylistMatchAttribute("id");
		public static readonly PlaylistMatchAttribute NAME = new PlaylistMatchAttribute("name");
		public static readonly PlaylistMatchAttribute REFERENCE_ID = new PlaylistMatchAttribute("referenceId");
		public static readonly PlaylistMatchAttribute REPLACED_ENTRY_ID = new PlaylistMatchAttribute("replacedEntryId");
		public static readonly PlaylistMatchAttribute REPLACING_ENTRY_ID = new PlaylistMatchAttribute("replacingEntryId");
		public static readonly PlaylistMatchAttribute SEARCH_TEXT = new PlaylistMatchAttribute("searchText");
		public static readonly PlaylistMatchAttribute TAGS = new PlaylistMatchAttribute("tags");
		public static readonly PlaylistMatchAttribute USER_ID = new PlaylistMatchAttribute("userId");

		private PlaylistMatchAttribute(string name) : base(name) { }
	}
}
