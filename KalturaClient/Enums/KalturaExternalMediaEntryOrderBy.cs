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
	public sealed class KalturaExternalMediaEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaExternalMediaEntryOrderBy CREATED_AT_ASC = new KalturaExternalMediaEntryOrderBy("+createdAt");
		public static readonly KalturaExternalMediaEntryOrderBy DURATION_ASC = new KalturaExternalMediaEntryOrderBy("+duration");
		public static readonly KalturaExternalMediaEntryOrderBy END_DATE_ASC = new KalturaExternalMediaEntryOrderBy("+endDate");
		public static readonly KalturaExternalMediaEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaExternalMediaEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaExternalMediaEntryOrderBy MEDIA_TYPE_ASC = new KalturaExternalMediaEntryOrderBy("+mediaType");
		public static readonly KalturaExternalMediaEntryOrderBy MODERATION_COUNT_ASC = new KalturaExternalMediaEntryOrderBy("+moderationCount");
		public static readonly KalturaExternalMediaEntryOrderBy NAME_ASC = new KalturaExternalMediaEntryOrderBy("+name");
		public static readonly KalturaExternalMediaEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaExternalMediaEntryOrderBy("+partnerSortValue");
		public static readonly KalturaExternalMediaEntryOrderBy PLAYS_ASC = new KalturaExternalMediaEntryOrderBy("+plays");
		public static readonly KalturaExternalMediaEntryOrderBy RANK_ASC = new KalturaExternalMediaEntryOrderBy("+rank");
		public static readonly KalturaExternalMediaEntryOrderBy RECENT_ASC = new KalturaExternalMediaEntryOrderBy("+recent");
		public static readonly KalturaExternalMediaEntryOrderBy START_DATE_ASC = new KalturaExternalMediaEntryOrderBy("+startDate");
		public static readonly KalturaExternalMediaEntryOrderBy TOTAL_RANK_ASC = new KalturaExternalMediaEntryOrderBy("+totalRank");
		public static readonly KalturaExternalMediaEntryOrderBy UPDATED_AT_ASC = new KalturaExternalMediaEntryOrderBy("+updatedAt");
		public static readonly KalturaExternalMediaEntryOrderBy VIEWS_ASC = new KalturaExternalMediaEntryOrderBy("+views");
		public static readonly KalturaExternalMediaEntryOrderBy WEIGHT_ASC = new KalturaExternalMediaEntryOrderBy("+weight");
		public static readonly KalturaExternalMediaEntryOrderBy CREATED_AT_DESC = new KalturaExternalMediaEntryOrderBy("-createdAt");
		public static readonly KalturaExternalMediaEntryOrderBy DURATION_DESC = new KalturaExternalMediaEntryOrderBy("-duration");
		public static readonly KalturaExternalMediaEntryOrderBy END_DATE_DESC = new KalturaExternalMediaEntryOrderBy("-endDate");
		public static readonly KalturaExternalMediaEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaExternalMediaEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaExternalMediaEntryOrderBy MEDIA_TYPE_DESC = new KalturaExternalMediaEntryOrderBy("-mediaType");
		public static readonly KalturaExternalMediaEntryOrderBy MODERATION_COUNT_DESC = new KalturaExternalMediaEntryOrderBy("-moderationCount");
		public static readonly KalturaExternalMediaEntryOrderBy NAME_DESC = new KalturaExternalMediaEntryOrderBy("-name");
		public static readonly KalturaExternalMediaEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaExternalMediaEntryOrderBy("-partnerSortValue");
		public static readonly KalturaExternalMediaEntryOrderBy PLAYS_DESC = new KalturaExternalMediaEntryOrderBy("-plays");
		public static readonly KalturaExternalMediaEntryOrderBy RANK_DESC = new KalturaExternalMediaEntryOrderBy("-rank");
		public static readonly KalturaExternalMediaEntryOrderBy RECENT_DESC = new KalturaExternalMediaEntryOrderBy("-recent");
		public static readonly KalturaExternalMediaEntryOrderBy START_DATE_DESC = new KalturaExternalMediaEntryOrderBy("-startDate");
		public static readonly KalturaExternalMediaEntryOrderBy TOTAL_RANK_DESC = new KalturaExternalMediaEntryOrderBy("-totalRank");
		public static readonly KalturaExternalMediaEntryOrderBy UPDATED_AT_DESC = new KalturaExternalMediaEntryOrderBy("-updatedAt");
		public static readonly KalturaExternalMediaEntryOrderBy VIEWS_DESC = new KalturaExternalMediaEntryOrderBy("-views");
		public static readonly KalturaExternalMediaEntryOrderBy WEIGHT_DESC = new KalturaExternalMediaEntryOrderBy("-weight");

		private KalturaExternalMediaEntryOrderBy(string name) : base(name) { }
	}
}
