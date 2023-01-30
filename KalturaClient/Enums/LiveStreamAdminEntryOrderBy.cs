// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class LiveStreamAdminEntryOrderBy : StringEnum
	{
		public static readonly LiveStreamAdminEntryOrderBy CREATED_AT_ASC = new LiveStreamAdminEntryOrderBy("+createdAt");
		public static readonly LiveStreamAdminEntryOrderBy DURATION_ASC = new LiveStreamAdminEntryOrderBy("+duration");
		public static readonly LiveStreamAdminEntryOrderBy END_DATE_ASC = new LiveStreamAdminEntryOrderBy("+endDate");
		public static readonly LiveStreamAdminEntryOrderBy FIRST_BROADCAST_ASC = new LiveStreamAdminEntryOrderBy("+firstBroadcast");
		public static readonly LiveStreamAdminEntryOrderBy LAST_BROADCAST_ASC = new LiveStreamAdminEntryOrderBy("+lastBroadcast");
		public static readonly LiveStreamAdminEntryOrderBy LAST_PLAYED_AT_ASC = new LiveStreamAdminEntryOrderBy("+lastPlayedAt");
		public static readonly LiveStreamAdminEntryOrderBy MEDIA_TYPE_ASC = new LiveStreamAdminEntryOrderBy("+mediaType");
		public static readonly LiveStreamAdminEntryOrderBy MODERATION_COUNT_ASC = new LiveStreamAdminEntryOrderBy("+moderationCount");
		public static readonly LiveStreamAdminEntryOrderBy NAME_ASC = new LiveStreamAdminEntryOrderBy("+name");
		public static readonly LiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_ASC = new LiveStreamAdminEntryOrderBy("+partnerSortValue");
		public static readonly LiveStreamAdminEntryOrderBy PLAYS_ASC = new LiveStreamAdminEntryOrderBy("+plays");
		public static readonly LiveStreamAdminEntryOrderBy RANK_ASC = new LiveStreamAdminEntryOrderBy("+rank");
		public static readonly LiveStreamAdminEntryOrderBy RECENT_ASC = new LiveStreamAdminEntryOrderBy("+recent");
		public static readonly LiveStreamAdminEntryOrderBy START_DATE_ASC = new LiveStreamAdminEntryOrderBy("+startDate");
		public static readonly LiveStreamAdminEntryOrderBy TOTAL_RANK_ASC = new LiveStreamAdminEntryOrderBy("+totalRank");
		public static readonly LiveStreamAdminEntryOrderBy UPDATED_AT_ASC = new LiveStreamAdminEntryOrderBy("+updatedAt");
		public static readonly LiveStreamAdminEntryOrderBy VIEWS_ASC = new LiveStreamAdminEntryOrderBy("+views");
		public static readonly LiveStreamAdminEntryOrderBy WEIGHT_ASC = new LiveStreamAdminEntryOrderBy("+weight");
		public static readonly LiveStreamAdminEntryOrderBy CREATED_AT_DESC = new LiveStreamAdminEntryOrderBy("-createdAt");
		public static readonly LiveStreamAdminEntryOrderBy DURATION_DESC = new LiveStreamAdminEntryOrderBy("-duration");
		public static readonly LiveStreamAdminEntryOrderBy END_DATE_DESC = new LiveStreamAdminEntryOrderBy("-endDate");
		public static readonly LiveStreamAdminEntryOrderBy FIRST_BROADCAST_DESC = new LiveStreamAdminEntryOrderBy("-firstBroadcast");
		public static readonly LiveStreamAdminEntryOrderBy LAST_BROADCAST_DESC = new LiveStreamAdminEntryOrderBy("-lastBroadcast");
		public static readonly LiveStreamAdminEntryOrderBy LAST_PLAYED_AT_DESC = new LiveStreamAdminEntryOrderBy("-lastPlayedAt");
		public static readonly LiveStreamAdminEntryOrderBy MEDIA_TYPE_DESC = new LiveStreamAdminEntryOrderBy("-mediaType");
		public static readonly LiveStreamAdminEntryOrderBy MODERATION_COUNT_DESC = new LiveStreamAdminEntryOrderBy("-moderationCount");
		public static readonly LiveStreamAdminEntryOrderBy NAME_DESC = new LiveStreamAdminEntryOrderBy("-name");
		public static readonly LiveStreamAdminEntryOrderBy PARTNER_SORT_VALUE_DESC = new LiveStreamAdminEntryOrderBy("-partnerSortValue");
		public static readonly LiveStreamAdminEntryOrderBy PLAYS_DESC = new LiveStreamAdminEntryOrderBy("-plays");
		public static readonly LiveStreamAdminEntryOrderBy RANK_DESC = new LiveStreamAdminEntryOrderBy("-rank");
		public static readonly LiveStreamAdminEntryOrderBy RECENT_DESC = new LiveStreamAdminEntryOrderBy("-recent");
		public static readonly LiveStreamAdminEntryOrderBy START_DATE_DESC = new LiveStreamAdminEntryOrderBy("-startDate");
		public static readonly LiveStreamAdminEntryOrderBy TOTAL_RANK_DESC = new LiveStreamAdminEntryOrderBy("-totalRank");
		public static readonly LiveStreamAdminEntryOrderBy UPDATED_AT_DESC = new LiveStreamAdminEntryOrderBy("-updatedAt");
		public static readonly LiveStreamAdminEntryOrderBy VIEWS_DESC = new LiveStreamAdminEntryOrderBy("-views");
		public static readonly LiveStreamAdminEntryOrderBy WEIGHT_DESC = new LiveStreamAdminEntryOrderBy("-weight");

		private LiveStreamAdminEntryOrderBy(string name) : base(name) { }
	}
}
