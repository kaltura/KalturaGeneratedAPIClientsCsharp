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
	public sealed class KalturaLiveChannelOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveChannelOrderBy CREATED_AT_ASC = new KalturaLiveChannelOrderBy("+createdAt");
		public static readonly KalturaLiveChannelOrderBy DURATION_ASC = new KalturaLiveChannelOrderBy("+duration");
		public static readonly KalturaLiveChannelOrderBy END_DATE_ASC = new KalturaLiveChannelOrderBy("+endDate");
		public static readonly KalturaLiveChannelOrderBy FIRST_BROADCAST_ASC = new KalturaLiveChannelOrderBy("+firstBroadcast");
		public static readonly KalturaLiveChannelOrderBy LAST_BROADCAST_ASC = new KalturaLiveChannelOrderBy("+lastBroadcast");
		public static readonly KalturaLiveChannelOrderBy LAST_PLAYED_AT_ASC = new KalturaLiveChannelOrderBy("+lastPlayedAt");
		public static readonly KalturaLiveChannelOrderBy MEDIA_TYPE_ASC = new KalturaLiveChannelOrderBy("+mediaType");
		public static readonly KalturaLiveChannelOrderBy MODERATION_COUNT_ASC = new KalturaLiveChannelOrderBy("+moderationCount");
		public static readonly KalturaLiveChannelOrderBy NAME_ASC = new KalturaLiveChannelOrderBy("+name");
		public static readonly KalturaLiveChannelOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveChannelOrderBy("+partnerSortValue");
		public static readonly KalturaLiveChannelOrderBy PLAYS_ASC = new KalturaLiveChannelOrderBy("+plays");
		public static readonly KalturaLiveChannelOrderBy RANK_ASC = new KalturaLiveChannelOrderBy("+rank");
		public static readonly KalturaLiveChannelOrderBy RECENT_ASC = new KalturaLiveChannelOrderBy("+recent");
		public static readonly KalturaLiveChannelOrderBy START_DATE_ASC = new KalturaLiveChannelOrderBy("+startDate");
		public static readonly KalturaLiveChannelOrderBy TOTAL_RANK_ASC = new KalturaLiveChannelOrderBy("+totalRank");
		public static readonly KalturaLiveChannelOrderBy UPDATED_AT_ASC = new KalturaLiveChannelOrderBy("+updatedAt");
		public static readonly KalturaLiveChannelOrderBy VIEWS_ASC = new KalturaLiveChannelOrderBy("+views");
		public static readonly KalturaLiveChannelOrderBy WEIGHT_ASC = new KalturaLiveChannelOrderBy("+weight");
		public static readonly KalturaLiveChannelOrderBy CREATED_AT_DESC = new KalturaLiveChannelOrderBy("-createdAt");
		public static readonly KalturaLiveChannelOrderBy DURATION_DESC = new KalturaLiveChannelOrderBy("-duration");
		public static readonly KalturaLiveChannelOrderBy END_DATE_DESC = new KalturaLiveChannelOrderBy("-endDate");
		public static readonly KalturaLiveChannelOrderBy FIRST_BROADCAST_DESC = new KalturaLiveChannelOrderBy("-firstBroadcast");
		public static readonly KalturaLiveChannelOrderBy LAST_BROADCAST_DESC = new KalturaLiveChannelOrderBy("-lastBroadcast");
		public static readonly KalturaLiveChannelOrderBy LAST_PLAYED_AT_DESC = new KalturaLiveChannelOrderBy("-lastPlayedAt");
		public static readonly KalturaLiveChannelOrderBy MEDIA_TYPE_DESC = new KalturaLiveChannelOrderBy("-mediaType");
		public static readonly KalturaLiveChannelOrderBy MODERATION_COUNT_DESC = new KalturaLiveChannelOrderBy("-moderationCount");
		public static readonly KalturaLiveChannelOrderBy NAME_DESC = new KalturaLiveChannelOrderBy("-name");
		public static readonly KalturaLiveChannelOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveChannelOrderBy("-partnerSortValue");
		public static readonly KalturaLiveChannelOrderBy PLAYS_DESC = new KalturaLiveChannelOrderBy("-plays");
		public static readonly KalturaLiveChannelOrderBy RANK_DESC = new KalturaLiveChannelOrderBy("-rank");
		public static readonly KalturaLiveChannelOrderBy RECENT_DESC = new KalturaLiveChannelOrderBy("-recent");
		public static readonly KalturaLiveChannelOrderBy START_DATE_DESC = new KalturaLiveChannelOrderBy("-startDate");
		public static readonly KalturaLiveChannelOrderBy TOTAL_RANK_DESC = new KalturaLiveChannelOrderBy("-totalRank");
		public static readonly KalturaLiveChannelOrderBy UPDATED_AT_DESC = new KalturaLiveChannelOrderBy("-updatedAt");
		public static readonly KalturaLiveChannelOrderBy VIEWS_DESC = new KalturaLiveChannelOrderBy("-views");
		public static readonly KalturaLiveChannelOrderBy WEIGHT_DESC = new KalturaLiveChannelOrderBy("-weight");

		private KalturaLiveChannelOrderBy(string name) : base(name) { }
	}
}
