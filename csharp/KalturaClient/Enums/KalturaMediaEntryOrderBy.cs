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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaMediaEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaMediaEntryOrderBy CREATED_AT_ASC = new KalturaMediaEntryOrderBy("+createdAt");
		public static readonly KalturaMediaEntryOrderBy DURATION_ASC = new KalturaMediaEntryOrderBy("+duration");
		public static readonly KalturaMediaEntryOrderBy END_DATE_ASC = new KalturaMediaEntryOrderBy("+endDate");
		public static readonly KalturaMediaEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaMediaEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaMediaEntryOrderBy MEDIA_TYPE_ASC = new KalturaMediaEntryOrderBy("+mediaType");
		public static readonly KalturaMediaEntryOrderBy MODERATION_COUNT_ASC = new KalturaMediaEntryOrderBy("+moderationCount");
		public static readonly KalturaMediaEntryOrderBy NAME_ASC = new KalturaMediaEntryOrderBy("+name");
		public static readonly KalturaMediaEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaMediaEntryOrderBy("+partnerSortValue");
		public static readonly KalturaMediaEntryOrderBy PLAYS_ASC = new KalturaMediaEntryOrderBy("+plays");
		public static readonly KalturaMediaEntryOrderBy RANK_ASC = new KalturaMediaEntryOrderBy("+rank");
		public static readonly KalturaMediaEntryOrderBy RECENT_ASC = new KalturaMediaEntryOrderBy("+recent");
		public static readonly KalturaMediaEntryOrderBy START_DATE_ASC = new KalturaMediaEntryOrderBy("+startDate");
		public static readonly KalturaMediaEntryOrderBy TOTAL_RANK_ASC = new KalturaMediaEntryOrderBy("+totalRank");
		public static readonly KalturaMediaEntryOrderBy UPDATED_AT_ASC = new KalturaMediaEntryOrderBy("+updatedAt");
		public static readonly KalturaMediaEntryOrderBy VIEWS_ASC = new KalturaMediaEntryOrderBy("+views");
		public static readonly KalturaMediaEntryOrderBy WEIGHT_ASC = new KalturaMediaEntryOrderBy("+weight");
		public static readonly KalturaMediaEntryOrderBy CREATED_AT_DESC = new KalturaMediaEntryOrderBy("-createdAt");
		public static readonly KalturaMediaEntryOrderBy DURATION_DESC = new KalturaMediaEntryOrderBy("-duration");
		public static readonly KalturaMediaEntryOrderBy END_DATE_DESC = new KalturaMediaEntryOrderBy("-endDate");
		public static readonly KalturaMediaEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaMediaEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaMediaEntryOrderBy MEDIA_TYPE_DESC = new KalturaMediaEntryOrderBy("-mediaType");
		public static readonly KalturaMediaEntryOrderBy MODERATION_COUNT_DESC = new KalturaMediaEntryOrderBy("-moderationCount");
		public static readonly KalturaMediaEntryOrderBy NAME_DESC = new KalturaMediaEntryOrderBy("-name");
		public static readonly KalturaMediaEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaMediaEntryOrderBy("-partnerSortValue");
		public static readonly KalturaMediaEntryOrderBy PLAYS_DESC = new KalturaMediaEntryOrderBy("-plays");
		public static readonly KalturaMediaEntryOrderBy RANK_DESC = new KalturaMediaEntryOrderBy("-rank");
		public static readonly KalturaMediaEntryOrderBy RECENT_DESC = new KalturaMediaEntryOrderBy("-recent");
		public static readonly KalturaMediaEntryOrderBy START_DATE_DESC = new KalturaMediaEntryOrderBy("-startDate");
		public static readonly KalturaMediaEntryOrderBy TOTAL_RANK_DESC = new KalturaMediaEntryOrderBy("-totalRank");
		public static readonly KalturaMediaEntryOrderBy UPDATED_AT_DESC = new KalturaMediaEntryOrderBy("-updatedAt");
		public static readonly KalturaMediaEntryOrderBy VIEWS_DESC = new KalturaMediaEntryOrderBy("-views");
		public static readonly KalturaMediaEntryOrderBy WEIGHT_DESC = new KalturaMediaEntryOrderBy("-weight");

		private KalturaMediaEntryOrderBy(string name) : base(name) { }
	}
}
