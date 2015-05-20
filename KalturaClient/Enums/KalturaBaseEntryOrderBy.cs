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
	public sealed class KalturaBaseEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBaseEntryOrderBy CREATED_AT_ASC = new KalturaBaseEntryOrderBy("+createdAt");
		public static readonly KalturaBaseEntryOrderBy END_DATE_ASC = new KalturaBaseEntryOrderBy("+endDate");
		public static readonly KalturaBaseEntryOrderBy MODERATION_COUNT_ASC = new KalturaBaseEntryOrderBy("+moderationCount");
		public static readonly KalturaBaseEntryOrderBy NAME_ASC = new KalturaBaseEntryOrderBy("+name");
		public static readonly KalturaBaseEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaBaseEntryOrderBy("+partnerSortValue");
		public static readonly KalturaBaseEntryOrderBy RANK_ASC = new KalturaBaseEntryOrderBy("+rank");
		public static readonly KalturaBaseEntryOrderBy RECENT_ASC = new KalturaBaseEntryOrderBy("+recent");
		public static readonly KalturaBaseEntryOrderBy START_DATE_ASC = new KalturaBaseEntryOrderBy("+startDate");
		public static readonly KalturaBaseEntryOrderBy TOTAL_RANK_ASC = new KalturaBaseEntryOrderBy("+totalRank");
		public static readonly KalturaBaseEntryOrderBy UPDATED_AT_ASC = new KalturaBaseEntryOrderBy("+updatedAt");
		public static readonly KalturaBaseEntryOrderBy WEIGHT_ASC = new KalturaBaseEntryOrderBy("+weight");
		public static readonly KalturaBaseEntryOrderBy CREATED_AT_DESC = new KalturaBaseEntryOrderBy("-createdAt");
		public static readonly KalturaBaseEntryOrderBy END_DATE_DESC = new KalturaBaseEntryOrderBy("-endDate");
		public static readonly KalturaBaseEntryOrderBy MODERATION_COUNT_DESC = new KalturaBaseEntryOrderBy("-moderationCount");
		public static readonly KalturaBaseEntryOrderBy NAME_DESC = new KalturaBaseEntryOrderBy("-name");
		public static readonly KalturaBaseEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaBaseEntryOrderBy("-partnerSortValue");
		public static readonly KalturaBaseEntryOrderBy RANK_DESC = new KalturaBaseEntryOrderBy("-rank");
		public static readonly KalturaBaseEntryOrderBy RECENT_DESC = new KalturaBaseEntryOrderBy("-recent");
		public static readonly KalturaBaseEntryOrderBy START_DATE_DESC = new KalturaBaseEntryOrderBy("-startDate");
		public static readonly KalturaBaseEntryOrderBy TOTAL_RANK_DESC = new KalturaBaseEntryOrderBy("-totalRank");
		public static readonly KalturaBaseEntryOrderBy UPDATED_AT_DESC = new KalturaBaseEntryOrderBy("-updatedAt");
		public static readonly KalturaBaseEntryOrderBy WEIGHT_DESC = new KalturaBaseEntryOrderBy("-weight");

		private KalturaBaseEntryOrderBy(string name) : base(name) { }
	}
}
