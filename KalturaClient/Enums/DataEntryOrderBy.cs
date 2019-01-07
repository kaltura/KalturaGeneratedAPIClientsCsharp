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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class DataEntryOrderBy : StringEnum
	{
		public static readonly DataEntryOrderBy CREATED_AT_ASC = new DataEntryOrderBy("+createdAt");
		public static readonly DataEntryOrderBy END_DATE_ASC = new DataEntryOrderBy("+endDate");
		public static readonly DataEntryOrderBy MODERATION_COUNT_ASC = new DataEntryOrderBy("+moderationCount");
		public static readonly DataEntryOrderBy NAME_ASC = new DataEntryOrderBy("+name");
		public static readonly DataEntryOrderBy PARTNER_SORT_VALUE_ASC = new DataEntryOrderBy("+partnerSortValue");
		public static readonly DataEntryOrderBy RANK_ASC = new DataEntryOrderBy("+rank");
		public static readonly DataEntryOrderBy RECENT_ASC = new DataEntryOrderBy("+recent");
		public static readonly DataEntryOrderBy START_DATE_ASC = new DataEntryOrderBy("+startDate");
		public static readonly DataEntryOrderBy TOTAL_RANK_ASC = new DataEntryOrderBy("+totalRank");
		public static readonly DataEntryOrderBy UPDATED_AT_ASC = new DataEntryOrderBy("+updatedAt");
		public static readonly DataEntryOrderBy WEIGHT_ASC = new DataEntryOrderBy("+weight");
		public static readonly DataEntryOrderBy CREATED_AT_DESC = new DataEntryOrderBy("-createdAt");
		public static readonly DataEntryOrderBy END_DATE_DESC = new DataEntryOrderBy("-endDate");
		public static readonly DataEntryOrderBy MODERATION_COUNT_DESC = new DataEntryOrderBy("-moderationCount");
		public static readonly DataEntryOrderBy NAME_DESC = new DataEntryOrderBy("-name");
		public static readonly DataEntryOrderBy PARTNER_SORT_VALUE_DESC = new DataEntryOrderBy("-partnerSortValue");
		public static readonly DataEntryOrderBy RANK_DESC = new DataEntryOrderBy("-rank");
		public static readonly DataEntryOrderBy RECENT_DESC = new DataEntryOrderBy("-recent");
		public static readonly DataEntryOrderBy START_DATE_DESC = new DataEntryOrderBy("-startDate");
		public static readonly DataEntryOrderBy TOTAL_RANK_DESC = new DataEntryOrderBy("-totalRank");
		public static readonly DataEntryOrderBy UPDATED_AT_DESC = new DataEntryOrderBy("-updatedAt");
		public static readonly DataEntryOrderBy WEIGHT_DESC = new DataEntryOrderBy("-weight");

		private DataEntryOrderBy(string name) : base(name) { }
	}
}
