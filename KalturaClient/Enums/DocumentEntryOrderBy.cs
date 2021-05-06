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
	public sealed class DocumentEntryOrderBy : StringEnum
	{
		public static readonly DocumentEntryOrderBy CREATED_AT_ASC = new DocumentEntryOrderBy("+createdAt");
		public static readonly DocumentEntryOrderBy END_DATE_ASC = new DocumentEntryOrderBy("+endDate");
		public static readonly DocumentEntryOrderBy MODERATION_COUNT_ASC = new DocumentEntryOrderBy("+moderationCount");
		public static readonly DocumentEntryOrderBy NAME_ASC = new DocumentEntryOrderBy("+name");
		public static readonly DocumentEntryOrderBy PARTNER_SORT_VALUE_ASC = new DocumentEntryOrderBy("+partnerSortValue");
		public static readonly DocumentEntryOrderBy RANK_ASC = new DocumentEntryOrderBy("+rank");
		public static readonly DocumentEntryOrderBy RECENT_ASC = new DocumentEntryOrderBy("+recent");
		public static readonly DocumentEntryOrderBy START_DATE_ASC = new DocumentEntryOrderBy("+startDate");
		public static readonly DocumentEntryOrderBy TOTAL_RANK_ASC = new DocumentEntryOrderBy("+totalRank");
		public static readonly DocumentEntryOrderBy UPDATED_AT_ASC = new DocumentEntryOrderBy("+updatedAt");
		public static readonly DocumentEntryOrderBy WEIGHT_ASC = new DocumentEntryOrderBy("+weight");
		public static readonly DocumentEntryOrderBy CREATED_AT_DESC = new DocumentEntryOrderBy("-createdAt");
		public static readonly DocumentEntryOrderBy END_DATE_DESC = new DocumentEntryOrderBy("-endDate");
		public static readonly DocumentEntryOrderBy MODERATION_COUNT_DESC = new DocumentEntryOrderBy("-moderationCount");
		public static readonly DocumentEntryOrderBy NAME_DESC = new DocumentEntryOrderBy("-name");
		public static readonly DocumentEntryOrderBy PARTNER_SORT_VALUE_DESC = new DocumentEntryOrderBy("-partnerSortValue");
		public static readonly DocumentEntryOrderBy RANK_DESC = new DocumentEntryOrderBy("-rank");
		public static readonly DocumentEntryOrderBy RECENT_DESC = new DocumentEntryOrderBy("-recent");
		public static readonly DocumentEntryOrderBy START_DATE_DESC = new DocumentEntryOrderBy("-startDate");
		public static readonly DocumentEntryOrderBy TOTAL_RANK_DESC = new DocumentEntryOrderBy("-totalRank");
		public static readonly DocumentEntryOrderBy UPDATED_AT_DESC = new DocumentEntryOrderBy("-updatedAt");
		public static readonly DocumentEntryOrderBy WEIGHT_DESC = new DocumentEntryOrderBy("-weight");

		private DocumentEntryOrderBy(string name) : base(name) { }
	}
}
