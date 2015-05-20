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
	public sealed class KalturaDataEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDataEntryOrderBy CREATED_AT_ASC = new KalturaDataEntryOrderBy("+createdAt");
		public static readonly KalturaDataEntryOrderBy END_DATE_ASC = new KalturaDataEntryOrderBy("+endDate");
		public static readonly KalturaDataEntryOrderBy MODERATION_COUNT_ASC = new KalturaDataEntryOrderBy("+moderationCount");
		public static readonly KalturaDataEntryOrderBy NAME_ASC = new KalturaDataEntryOrderBy("+name");
		public static readonly KalturaDataEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaDataEntryOrderBy("+partnerSortValue");
		public static readonly KalturaDataEntryOrderBy RANK_ASC = new KalturaDataEntryOrderBy("+rank");
		public static readonly KalturaDataEntryOrderBy RECENT_ASC = new KalturaDataEntryOrderBy("+recent");
		public static readonly KalturaDataEntryOrderBy START_DATE_ASC = new KalturaDataEntryOrderBy("+startDate");
		public static readonly KalturaDataEntryOrderBy TOTAL_RANK_ASC = new KalturaDataEntryOrderBy("+totalRank");
		public static readonly KalturaDataEntryOrderBy UPDATED_AT_ASC = new KalturaDataEntryOrderBy("+updatedAt");
		public static readonly KalturaDataEntryOrderBy WEIGHT_ASC = new KalturaDataEntryOrderBy("+weight");
		public static readonly KalturaDataEntryOrderBy CREATED_AT_DESC = new KalturaDataEntryOrderBy("-createdAt");
		public static readonly KalturaDataEntryOrderBy END_DATE_DESC = new KalturaDataEntryOrderBy("-endDate");
		public static readonly KalturaDataEntryOrderBy MODERATION_COUNT_DESC = new KalturaDataEntryOrderBy("-moderationCount");
		public static readonly KalturaDataEntryOrderBy NAME_DESC = new KalturaDataEntryOrderBy("-name");
		public static readonly KalturaDataEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaDataEntryOrderBy("-partnerSortValue");
		public static readonly KalturaDataEntryOrderBy RANK_DESC = new KalturaDataEntryOrderBy("-rank");
		public static readonly KalturaDataEntryOrderBy RECENT_DESC = new KalturaDataEntryOrderBy("-recent");
		public static readonly KalturaDataEntryOrderBy START_DATE_DESC = new KalturaDataEntryOrderBy("-startDate");
		public static readonly KalturaDataEntryOrderBy TOTAL_RANK_DESC = new KalturaDataEntryOrderBy("-totalRank");
		public static readonly KalturaDataEntryOrderBy UPDATED_AT_DESC = new KalturaDataEntryOrderBy("-updatedAt");
		public static readonly KalturaDataEntryOrderBy WEIGHT_DESC = new KalturaDataEntryOrderBy("-weight");

		private KalturaDataEntryOrderBy(string name) : base(name) { }
	}
}
