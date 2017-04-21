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
	public sealed class ExternalMediaEntryMatchAttribute : StringEnum
	{
		public static readonly ExternalMediaEntryMatchAttribute ADMIN_TAGS = new ExternalMediaEntryMatchAttribute("adminTags");
		public static readonly ExternalMediaEntryMatchAttribute CATEGORIES_IDS = new ExternalMediaEntryMatchAttribute("categoriesIds");
		public static readonly ExternalMediaEntryMatchAttribute CREATOR_ID = new ExternalMediaEntryMatchAttribute("creatorId");
		public static readonly ExternalMediaEntryMatchAttribute DESCRIPTION = new ExternalMediaEntryMatchAttribute("description");
		public static readonly ExternalMediaEntryMatchAttribute DURATION_TYPE = new ExternalMediaEntryMatchAttribute("durationType");
		public static readonly ExternalMediaEntryMatchAttribute FLAVOR_PARAMS_IDS = new ExternalMediaEntryMatchAttribute("flavorParamsIds");
		public static readonly ExternalMediaEntryMatchAttribute GROUP_ID = new ExternalMediaEntryMatchAttribute("groupId");
		public static readonly ExternalMediaEntryMatchAttribute ID = new ExternalMediaEntryMatchAttribute("id");
		public static readonly ExternalMediaEntryMatchAttribute NAME = new ExternalMediaEntryMatchAttribute("name");
		public static readonly ExternalMediaEntryMatchAttribute REFERENCE_ID = new ExternalMediaEntryMatchAttribute("referenceId");
		public static readonly ExternalMediaEntryMatchAttribute REPLACED_ENTRY_ID = new ExternalMediaEntryMatchAttribute("replacedEntryId");
		public static readonly ExternalMediaEntryMatchAttribute REPLACING_ENTRY_ID = new ExternalMediaEntryMatchAttribute("replacingEntryId");
		public static readonly ExternalMediaEntryMatchAttribute SEARCH_TEXT = new ExternalMediaEntryMatchAttribute("searchText");
		public static readonly ExternalMediaEntryMatchAttribute TAGS = new ExternalMediaEntryMatchAttribute("tags");
		public static readonly ExternalMediaEntryMatchAttribute USER_ID = new ExternalMediaEntryMatchAttribute("userId");

		private ExternalMediaEntryMatchAttribute(string name) : base(name) { }
	}
}
