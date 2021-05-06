// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class ESearchCategoryOrderByFieldName : StringEnum
	{
		public static readonly ESearchCategoryOrderByFieldName CREATED_AT = new ESearchCategoryOrderByFieldName("created_at");
		public static readonly ESearchCategoryOrderByFieldName ENTRIES_COUNT = new ESearchCategoryOrderByFieldName("entries_count");
		public static readonly ESearchCategoryOrderByFieldName MEMBERS_COUNT = new ESearchCategoryOrderByFieldName("members_count");
		public static readonly ESearchCategoryOrderByFieldName NAME = new ESearchCategoryOrderByFieldName("name");
		public static readonly ESearchCategoryOrderByFieldName UPDATED_AT = new ESearchCategoryOrderByFieldName("updated_at");

		private ESearchCategoryOrderByFieldName(string name) : base(name) { }
	}
}
