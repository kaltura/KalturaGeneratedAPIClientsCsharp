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
	public sealed class KalturaLiveStreamAdminEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamAdminEntryOrderBy CREATED_AT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+createdAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy DURATION_ASC = new KalturaLiveStreamAdminEntryOrderBy("+duration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy END_DATE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+endDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy FIRST_BROADCAST_ASC = new KalturaLiveStreamAdminEntryOrderBy("+firstBroadcast");
		public static readonly KalturaLiveStreamAdminEntryOrderBy LAST_BROADCAST_ASC = new KalturaLiveStreamAdminEntryOrderBy("+lastBroadcast");
		public static readonly KalturaLiveStreamAdminEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MEDIA_TYPE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+mediaType");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MODERATION_COUNT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+moderationCount");
		public static readonly KalturaLiveStreamAdminEntryOrderBy NAME_ASC = new KalturaLiveStreamAdminEntryOrderBy("+name");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+partnerSortValue");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PLAYS_ASC = new KalturaLiveStreamAdminEntryOrderBy("+plays");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RANK_ASC = new KalturaLiveStreamAdminEntryOrderBy("+rank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RECENT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+recent");
		public static readonly KalturaLiveStreamAdminEntryOrderBy START_DATE_ASC = new KalturaLiveStreamAdminEntryOrderBy("+startDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy TOTAL_RANK_ASC = new KalturaLiveStreamAdminEntryOrderBy("+totalRank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy UPDATED_AT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+updatedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy VIEWS_ASC = new KalturaLiveStreamAdminEntryOrderBy("+views");
		public static readonly KalturaLiveStreamAdminEntryOrderBy WEIGHT_ASC = new KalturaLiveStreamAdminEntryOrderBy("+weight");
		public static readonly KalturaLiveStreamAdminEntryOrderBy CREATED_AT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-createdAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy DURATION_DESC = new KalturaLiveStreamAdminEntryOrderBy("-duration");
		public static readonly KalturaLiveStreamAdminEntryOrderBy END_DATE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-endDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy FIRST_BROADCAST_DESC = new KalturaLiveStreamAdminEntryOrderBy("-firstBroadcast");
		public static readonly KalturaLiveStreamAdminEntryOrderBy LAST_BROADCAST_DESC = new KalturaLiveStreamAdminEntryOrderBy("-lastBroadcast");
		public static readonly KalturaLiveStreamAdminEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MEDIA_TYPE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-mediaType");
		public static readonly KalturaLiveStreamAdminEntryOrderBy MODERATION_COUNT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-moderationCount");
		public static readonly KalturaLiveStreamAdminEntryOrderBy NAME_DESC = new KalturaLiveStreamAdminEntryOrderBy("-name");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-partnerSortValue");
		public static readonly KalturaLiveStreamAdminEntryOrderBy PLAYS_DESC = new KalturaLiveStreamAdminEntryOrderBy("-plays");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RANK_DESC = new KalturaLiveStreamAdminEntryOrderBy("-rank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy RECENT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-recent");
		public static readonly KalturaLiveStreamAdminEntryOrderBy START_DATE_DESC = new KalturaLiveStreamAdminEntryOrderBy("-startDate");
		public static readonly KalturaLiveStreamAdminEntryOrderBy TOTAL_RANK_DESC = new KalturaLiveStreamAdminEntryOrderBy("-totalRank");
		public static readonly KalturaLiveStreamAdminEntryOrderBy UPDATED_AT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-updatedAt");
		public static readonly KalturaLiveStreamAdminEntryOrderBy VIEWS_DESC = new KalturaLiveStreamAdminEntryOrderBy("-views");
		public static readonly KalturaLiveStreamAdminEntryOrderBy WEIGHT_DESC = new KalturaLiveStreamAdminEntryOrderBy("-weight");

		private KalturaLiveStreamAdminEntryOrderBy(string name) : base(name) { }
	}
}
