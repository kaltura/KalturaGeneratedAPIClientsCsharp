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
	public sealed class KalturaLiveEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveEntryOrderBy CREATED_AT_ASC = new KalturaLiveEntryOrderBy("+createdAt");
		public static readonly KalturaLiveEntryOrderBy DURATION_ASC = new KalturaLiveEntryOrderBy("+duration");
		public static readonly KalturaLiveEntryOrderBy END_DATE_ASC = new KalturaLiveEntryOrderBy("+endDate");
		public static readonly KalturaLiveEntryOrderBy FIRST_BROADCAST_ASC = new KalturaLiveEntryOrderBy("+firstBroadcast");
		public static readonly KalturaLiveEntryOrderBy LAST_BROADCAST_ASC = new KalturaLiveEntryOrderBy("+lastBroadcast");
		public static readonly KalturaLiveEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaLiveEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaLiveEntryOrderBy MEDIA_TYPE_ASC = new KalturaLiveEntryOrderBy("+mediaType");
		public static readonly KalturaLiveEntryOrderBy MODERATION_COUNT_ASC = new KalturaLiveEntryOrderBy("+moderationCount");
		public static readonly KalturaLiveEntryOrderBy NAME_ASC = new KalturaLiveEntryOrderBy("+name");
		public static readonly KalturaLiveEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveEntryOrderBy("+partnerSortValue");
		public static readonly KalturaLiveEntryOrderBy PLAYS_ASC = new KalturaLiveEntryOrderBy("+plays");
		public static readonly KalturaLiveEntryOrderBy RANK_ASC = new KalturaLiveEntryOrderBy("+rank");
		public static readonly KalturaLiveEntryOrderBy RECENT_ASC = new KalturaLiveEntryOrderBy("+recent");
		public static readonly KalturaLiveEntryOrderBy START_DATE_ASC = new KalturaLiveEntryOrderBy("+startDate");
		public static readonly KalturaLiveEntryOrderBy TOTAL_RANK_ASC = new KalturaLiveEntryOrderBy("+totalRank");
		public static readonly KalturaLiveEntryOrderBy UPDATED_AT_ASC = new KalturaLiveEntryOrderBy("+updatedAt");
		public static readonly KalturaLiveEntryOrderBy VIEWS_ASC = new KalturaLiveEntryOrderBy("+views");
		public static readonly KalturaLiveEntryOrderBy WEIGHT_ASC = new KalturaLiveEntryOrderBy("+weight");
		public static readonly KalturaLiveEntryOrderBy CREATED_AT_DESC = new KalturaLiveEntryOrderBy("-createdAt");
		public static readonly KalturaLiveEntryOrderBy DURATION_DESC = new KalturaLiveEntryOrderBy("-duration");
		public static readonly KalturaLiveEntryOrderBy END_DATE_DESC = new KalturaLiveEntryOrderBy("-endDate");
		public static readonly KalturaLiveEntryOrderBy FIRST_BROADCAST_DESC = new KalturaLiveEntryOrderBy("-firstBroadcast");
		public static readonly KalturaLiveEntryOrderBy LAST_BROADCAST_DESC = new KalturaLiveEntryOrderBy("-lastBroadcast");
		public static readonly KalturaLiveEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaLiveEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaLiveEntryOrderBy MEDIA_TYPE_DESC = new KalturaLiveEntryOrderBy("-mediaType");
		public static readonly KalturaLiveEntryOrderBy MODERATION_COUNT_DESC = new KalturaLiveEntryOrderBy("-moderationCount");
		public static readonly KalturaLiveEntryOrderBy NAME_DESC = new KalturaLiveEntryOrderBy("-name");
		public static readonly KalturaLiveEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveEntryOrderBy("-partnerSortValue");
		public static readonly KalturaLiveEntryOrderBy PLAYS_DESC = new KalturaLiveEntryOrderBy("-plays");
		public static readonly KalturaLiveEntryOrderBy RANK_DESC = new KalturaLiveEntryOrderBy("-rank");
		public static readonly KalturaLiveEntryOrderBy RECENT_DESC = new KalturaLiveEntryOrderBy("-recent");
		public static readonly KalturaLiveEntryOrderBy START_DATE_DESC = new KalturaLiveEntryOrderBy("-startDate");
		public static readonly KalturaLiveEntryOrderBy TOTAL_RANK_DESC = new KalturaLiveEntryOrderBy("-totalRank");
		public static readonly KalturaLiveEntryOrderBy UPDATED_AT_DESC = new KalturaLiveEntryOrderBy("-updatedAt");
		public static readonly KalturaLiveEntryOrderBy VIEWS_DESC = new KalturaLiveEntryOrderBy("-views");
		public static readonly KalturaLiveEntryOrderBy WEIGHT_DESC = new KalturaLiveEntryOrderBy("-weight");

		private KalturaLiveEntryOrderBy(string name) : base(name) { }
	}
}
