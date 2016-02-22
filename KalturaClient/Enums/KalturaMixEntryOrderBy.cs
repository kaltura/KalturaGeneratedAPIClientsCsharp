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
	public sealed class KalturaMixEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMixEntryOrderBy CREATED_AT_ASC = new KalturaMixEntryOrderBy("+createdAt");
		public static readonly KalturaMixEntryOrderBy DURATION_ASC = new KalturaMixEntryOrderBy("+duration");
		public static readonly KalturaMixEntryOrderBy END_DATE_ASC = new KalturaMixEntryOrderBy("+endDate");
		public static readonly KalturaMixEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaMixEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaMixEntryOrderBy MODERATION_COUNT_ASC = new KalturaMixEntryOrderBy("+moderationCount");
		public static readonly KalturaMixEntryOrderBy NAME_ASC = new KalturaMixEntryOrderBy("+name");
		public static readonly KalturaMixEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaMixEntryOrderBy("+partnerSortValue");
		public static readonly KalturaMixEntryOrderBy PLAYS_ASC = new KalturaMixEntryOrderBy("+plays");
		public static readonly KalturaMixEntryOrderBy RANK_ASC = new KalturaMixEntryOrderBy("+rank");
		public static readonly KalturaMixEntryOrderBy RECENT_ASC = new KalturaMixEntryOrderBy("+recent");
		public static readonly KalturaMixEntryOrderBy START_DATE_ASC = new KalturaMixEntryOrderBy("+startDate");
		public static readonly KalturaMixEntryOrderBy TOTAL_RANK_ASC = new KalturaMixEntryOrderBy("+totalRank");
		public static readonly KalturaMixEntryOrderBy UPDATED_AT_ASC = new KalturaMixEntryOrderBy("+updatedAt");
		public static readonly KalturaMixEntryOrderBy VIEWS_ASC = new KalturaMixEntryOrderBy("+views");
		public static readonly KalturaMixEntryOrderBy WEIGHT_ASC = new KalturaMixEntryOrderBy("+weight");
		public static readonly KalturaMixEntryOrderBy CREATED_AT_DESC = new KalturaMixEntryOrderBy("-createdAt");
		public static readonly KalturaMixEntryOrderBy DURATION_DESC = new KalturaMixEntryOrderBy("-duration");
		public static readonly KalturaMixEntryOrderBy END_DATE_DESC = new KalturaMixEntryOrderBy("-endDate");
		public static readonly KalturaMixEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaMixEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaMixEntryOrderBy MODERATION_COUNT_DESC = new KalturaMixEntryOrderBy("-moderationCount");
		public static readonly KalturaMixEntryOrderBy NAME_DESC = new KalturaMixEntryOrderBy("-name");
		public static readonly KalturaMixEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaMixEntryOrderBy("-partnerSortValue");
		public static readonly KalturaMixEntryOrderBy PLAYS_DESC = new KalturaMixEntryOrderBy("-plays");
		public static readonly KalturaMixEntryOrderBy RANK_DESC = new KalturaMixEntryOrderBy("-rank");
		public static readonly KalturaMixEntryOrderBy RECENT_DESC = new KalturaMixEntryOrderBy("-recent");
		public static readonly KalturaMixEntryOrderBy START_DATE_DESC = new KalturaMixEntryOrderBy("-startDate");
		public static readonly KalturaMixEntryOrderBy TOTAL_RANK_DESC = new KalturaMixEntryOrderBy("-totalRank");
		public static readonly KalturaMixEntryOrderBy UPDATED_AT_DESC = new KalturaMixEntryOrderBy("-updatedAt");
		public static readonly KalturaMixEntryOrderBy VIEWS_DESC = new KalturaMixEntryOrderBy("-views");
		public static readonly KalturaMixEntryOrderBy WEIGHT_DESC = new KalturaMixEntryOrderBy("-weight");

		private KalturaMixEntryOrderBy(string name) : base(name) { }
	}
}
