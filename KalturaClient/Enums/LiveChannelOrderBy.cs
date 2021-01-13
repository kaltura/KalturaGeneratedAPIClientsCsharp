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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class LiveChannelOrderBy : StringEnum
	{
		public static readonly LiveChannelOrderBy CREATED_AT_ASC = new LiveChannelOrderBy("+createdAt");
		public static readonly LiveChannelOrderBy DURATION_ASC = new LiveChannelOrderBy("+duration");
		public static readonly LiveChannelOrderBy END_DATE_ASC = new LiveChannelOrderBy("+endDate");
		public static readonly LiveChannelOrderBy FIRST_BROADCAST_ASC = new LiveChannelOrderBy("+firstBroadcast");
		public static readonly LiveChannelOrderBy LAST_BROADCAST_ASC = new LiveChannelOrderBy("+lastBroadcast");
		public static readonly LiveChannelOrderBy LAST_PLAYED_AT_ASC = new LiveChannelOrderBy("+lastPlayedAt");
		public static readonly LiveChannelOrderBy MEDIA_TYPE_ASC = new LiveChannelOrderBy("+mediaType");
		public static readonly LiveChannelOrderBy MODERATION_COUNT_ASC = new LiveChannelOrderBy("+moderationCount");
		public static readonly LiveChannelOrderBy NAME_ASC = new LiveChannelOrderBy("+name");
		public static readonly LiveChannelOrderBy PARTNER_SORT_VALUE_ASC = new LiveChannelOrderBy("+partnerSortValue");
		public static readonly LiveChannelOrderBy PLAYS_ASC = new LiveChannelOrderBy("+plays");
		public static readonly LiveChannelOrderBy RANK_ASC = new LiveChannelOrderBy("+rank");
		public static readonly LiveChannelOrderBy RECENT_ASC = new LiveChannelOrderBy("+recent");
		public static readonly LiveChannelOrderBy START_DATE_ASC = new LiveChannelOrderBy("+startDate");
		public static readonly LiveChannelOrderBy TOTAL_RANK_ASC = new LiveChannelOrderBy("+totalRank");
		public static readonly LiveChannelOrderBy UPDATED_AT_ASC = new LiveChannelOrderBy("+updatedAt");
		public static readonly LiveChannelOrderBy VIEWS_ASC = new LiveChannelOrderBy("+views");
		public static readonly LiveChannelOrderBy WEIGHT_ASC = new LiveChannelOrderBy("+weight");
		public static readonly LiveChannelOrderBy CREATED_AT_DESC = new LiveChannelOrderBy("-createdAt");
		public static readonly LiveChannelOrderBy DURATION_DESC = new LiveChannelOrderBy("-duration");
		public static readonly LiveChannelOrderBy END_DATE_DESC = new LiveChannelOrderBy("-endDate");
		public static readonly LiveChannelOrderBy FIRST_BROADCAST_DESC = new LiveChannelOrderBy("-firstBroadcast");
		public static readonly LiveChannelOrderBy LAST_BROADCAST_DESC = new LiveChannelOrderBy("-lastBroadcast");
		public static readonly LiveChannelOrderBy LAST_PLAYED_AT_DESC = new LiveChannelOrderBy("-lastPlayedAt");
		public static readonly LiveChannelOrderBy MEDIA_TYPE_DESC = new LiveChannelOrderBy("-mediaType");
		public static readonly LiveChannelOrderBy MODERATION_COUNT_DESC = new LiveChannelOrderBy("-moderationCount");
		public static readonly LiveChannelOrderBy NAME_DESC = new LiveChannelOrderBy("-name");
		public static readonly LiveChannelOrderBy PARTNER_SORT_VALUE_DESC = new LiveChannelOrderBy("-partnerSortValue");
		public static readonly LiveChannelOrderBy PLAYS_DESC = new LiveChannelOrderBy("-plays");
		public static readonly LiveChannelOrderBy RANK_DESC = new LiveChannelOrderBy("-rank");
		public static readonly LiveChannelOrderBy RECENT_DESC = new LiveChannelOrderBy("-recent");
		public static readonly LiveChannelOrderBy START_DATE_DESC = new LiveChannelOrderBy("-startDate");
		public static readonly LiveChannelOrderBy TOTAL_RANK_DESC = new LiveChannelOrderBy("-totalRank");
		public static readonly LiveChannelOrderBy UPDATED_AT_DESC = new LiveChannelOrderBy("-updatedAt");
		public static readonly LiveChannelOrderBy VIEWS_DESC = new LiveChannelOrderBy("-views");
		public static readonly LiveChannelOrderBy WEIGHT_DESC = new LiveChannelOrderBy("-weight");

		private LiveChannelOrderBy(string name) : base(name) { }
	}
}
