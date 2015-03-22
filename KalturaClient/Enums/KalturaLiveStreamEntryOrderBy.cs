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
	public sealed class KalturaLiveStreamEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamEntryOrderBy CREATED_AT_ASC = new KalturaLiveStreamEntryOrderBy("+createdAt");
		public static readonly KalturaLiveStreamEntryOrderBy DURATION_ASC = new KalturaLiveStreamEntryOrderBy("+duration");
		public static readonly KalturaLiveStreamEntryOrderBy END_DATE_ASC = new KalturaLiveStreamEntryOrderBy("+endDate");
		public static readonly KalturaLiveStreamEntryOrderBy FIRST_BROADCAST_ASC = new KalturaLiveStreamEntryOrderBy("+firstBroadcast");
		public static readonly KalturaLiveStreamEntryOrderBy LAST_BROADCAST_ASC = new KalturaLiveStreamEntryOrderBy("+lastBroadcast");
		public static readonly KalturaLiveStreamEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaLiveStreamEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaLiveStreamEntryOrderBy MEDIA_TYPE_ASC = new KalturaLiveStreamEntryOrderBy("+mediaType");
		public static readonly KalturaLiveStreamEntryOrderBy MODERATION_COUNT_ASC = new KalturaLiveStreamEntryOrderBy("+moderationCount");
		public static readonly KalturaLiveStreamEntryOrderBy NAME_ASC = new KalturaLiveStreamEntryOrderBy("+name");
		public static readonly KalturaLiveStreamEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveStreamEntryOrderBy("+partnerSortValue");
		public static readonly KalturaLiveStreamEntryOrderBy PLAYS_ASC = new KalturaLiveStreamEntryOrderBy("+plays");
		public static readonly KalturaLiveStreamEntryOrderBy RANK_ASC = new KalturaLiveStreamEntryOrderBy("+rank");
		public static readonly KalturaLiveStreamEntryOrderBy RECENT_ASC = new KalturaLiveStreamEntryOrderBy("+recent");
		public static readonly KalturaLiveStreamEntryOrderBy START_DATE_ASC = new KalturaLiveStreamEntryOrderBy("+startDate");
		public static readonly KalturaLiveStreamEntryOrderBy TOTAL_RANK_ASC = new KalturaLiveStreamEntryOrderBy("+totalRank");
		public static readonly KalturaLiveStreamEntryOrderBy UPDATED_AT_ASC = new KalturaLiveStreamEntryOrderBy("+updatedAt");
		public static readonly KalturaLiveStreamEntryOrderBy VIEWS_ASC = new KalturaLiveStreamEntryOrderBy("+views");
		public static readonly KalturaLiveStreamEntryOrderBy WEIGHT_ASC = new KalturaLiveStreamEntryOrderBy("+weight");
		public static readonly KalturaLiveStreamEntryOrderBy CREATED_AT_DESC = new KalturaLiveStreamEntryOrderBy("-createdAt");
		public static readonly KalturaLiveStreamEntryOrderBy DURATION_DESC = new KalturaLiveStreamEntryOrderBy("-duration");
		public static readonly KalturaLiveStreamEntryOrderBy END_DATE_DESC = new KalturaLiveStreamEntryOrderBy("-endDate");
		public static readonly KalturaLiveStreamEntryOrderBy FIRST_BROADCAST_DESC = new KalturaLiveStreamEntryOrderBy("-firstBroadcast");
		public static readonly KalturaLiveStreamEntryOrderBy LAST_BROADCAST_DESC = new KalturaLiveStreamEntryOrderBy("-lastBroadcast");
		public static readonly KalturaLiveStreamEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaLiveStreamEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaLiveStreamEntryOrderBy MEDIA_TYPE_DESC = new KalturaLiveStreamEntryOrderBy("-mediaType");
		public static readonly KalturaLiveStreamEntryOrderBy MODERATION_COUNT_DESC = new KalturaLiveStreamEntryOrderBy("-moderationCount");
		public static readonly KalturaLiveStreamEntryOrderBy NAME_DESC = new KalturaLiveStreamEntryOrderBy("-name");
		public static readonly KalturaLiveStreamEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveStreamEntryOrderBy("-partnerSortValue");
		public static readonly KalturaLiveStreamEntryOrderBy PLAYS_DESC = new KalturaLiveStreamEntryOrderBy("-plays");
		public static readonly KalturaLiveStreamEntryOrderBy RANK_DESC = new KalturaLiveStreamEntryOrderBy("-rank");
		public static readonly KalturaLiveStreamEntryOrderBy RECENT_DESC = new KalturaLiveStreamEntryOrderBy("-recent");
		public static readonly KalturaLiveStreamEntryOrderBy START_DATE_DESC = new KalturaLiveStreamEntryOrderBy("-startDate");
		public static readonly KalturaLiveStreamEntryOrderBy TOTAL_RANK_DESC = new KalturaLiveStreamEntryOrderBy("-totalRank");
		public static readonly KalturaLiveStreamEntryOrderBy UPDATED_AT_DESC = new KalturaLiveStreamEntryOrderBy("-updatedAt");
		public static readonly KalturaLiveStreamEntryOrderBy VIEWS_DESC = new KalturaLiveStreamEntryOrderBy("-views");
		public static readonly KalturaLiveStreamEntryOrderBy WEIGHT_DESC = new KalturaLiveStreamEntryOrderBy("-weight");

		private KalturaLiveStreamEntryOrderBy(string name) : base(name) { }
	}
}
