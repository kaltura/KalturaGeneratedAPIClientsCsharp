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
	public sealed class BaseEntryOrderBy : StringEnum
	{
		public static readonly BaseEntryOrderBy CREATED_AT_ASC = new BaseEntryOrderBy("+createdAt");
		public static readonly BaseEntryOrderBy END_DATE_ASC = new BaseEntryOrderBy("+endDate");
		public static readonly BaseEntryOrderBy MODERATION_COUNT_ASC = new BaseEntryOrderBy("+moderationCount");
		public static readonly BaseEntryOrderBy NAME_ASC = new BaseEntryOrderBy("+name");
		public static readonly BaseEntryOrderBy PARTNER_SORT_VALUE_ASC = new BaseEntryOrderBy("+partnerSortValue");
		public static readonly BaseEntryOrderBy RANK_ASC = new BaseEntryOrderBy("+rank");
		public static readonly BaseEntryOrderBy RECENT_ASC = new BaseEntryOrderBy("+recent");
		public static readonly BaseEntryOrderBy START_DATE_ASC = new BaseEntryOrderBy("+startDate");
		public static readonly BaseEntryOrderBy TOTAL_RANK_ASC = new BaseEntryOrderBy("+totalRank");
		public static readonly BaseEntryOrderBy UPDATED_AT_ASC = new BaseEntryOrderBy("+updatedAt");
		public static readonly BaseEntryOrderBy WEIGHT_ASC = new BaseEntryOrderBy("+weight");
		public static readonly BaseEntryOrderBy CREATED_AT_DESC = new BaseEntryOrderBy("-createdAt");
		public static readonly BaseEntryOrderBy END_DATE_DESC = new BaseEntryOrderBy("-endDate");
		public static readonly BaseEntryOrderBy MODERATION_COUNT_DESC = new BaseEntryOrderBy("-moderationCount");
		public static readonly BaseEntryOrderBy NAME_DESC = new BaseEntryOrderBy("-name");
		public static readonly BaseEntryOrderBy PARTNER_SORT_VALUE_DESC = new BaseEntryOrderBy("-partnerSortValue");
		public static readonly BaseEntryOrderBy RANK_DESC = new BaseEntryOrderBy("-rank");
		public static readonly BaseEntryOrderBy RECENT_DESC = new BaseEntryOrderBy("-recent");
		public static readonly BaseEntryOrderBy START_DATE_DESC = new BaseEntryOrderBy("-startDate");
		public static readonly BaseEntryOrderBy TOTAL_RANK_DESC = new BaseEntryOrderBy("-totalRank");
		public static readonly BaseEntryOrderBy UPDATED_AT_DESC = new BaseEntryOrderBy("-updatedAt");
		public static readonly BaseEntryOrderBy WEIGHT_DESC = new BaseEntryOrderBy("-weight");

		private BaseEntryOrderBy(string name) : base(name) { }
	}
}
