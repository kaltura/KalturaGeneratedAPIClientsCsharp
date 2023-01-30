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
	public sealed class LiveStreamEntryOrderBy : StringEnum
	{
		public static readonly LiveStreamEntryOrderBy CREATED_AT_ASC = new LiveStreamEntryOrderBy("+createdAt");
		public static readonly LiveStreamEntryOrderBy DURATION_ASC = new LiveStreamEntryOrderBy("+duration");
		public static readonly LiveStreamEntryOrderBy END_DATE_ASC = new LiveStreamEntryOrderBy("+endDate");
		public static readonly LiveStreamEntryOrderBy FIRST_BROADCAST_ASC = new LiveStreamEntryOrderBy("+firstBroadcast");
		public static readonly LiveStreamEntryOrderBy LAST_BROADCAST_ASC = new LiveStreamEntryOrderBy("+lastBroadcast");
		public static readonly LiveStreamEntryOrderBy LAST_PLAYED_AT_ASC = new LiveStreamEntryOrderBy("+lastPlayedAt");
		public static readonly LiveStreamEntryOrderBy MEDIA_TYPE_ASC = new LiveStreamEntryOrderBy("+mediaType");
		public static readonly LiveStreamEntryOrderBy MODERATION_COUNT_ASC = new LiveStreamEntryOrderBy("+moderationCount");
		public static readonly LiveStreamEntryOrderBy NAME_ASC = new LiveStreamEntryOrderBy("+name");
		public static readonly LiveStreamEntryOrderBy PARTNER_SORT_VALUE_ASC = new LiveStreamEntryOrderBy("+partnerSortValue");
		public static readonly LiveStreamEntryOrderBy PLAYS_ASC = new LiveStreamEntryOrderBy("+plays");
		public static readonly LiveStreamEntryOrderBy RANK_ASC = new LiveStreamEntryOrderBy("+rank");
		public static readonly LiveStreamEntryOrderBy RECENT_ASC = new LiveStreamEntryOrderBy("+recent");
		public static readonly LiveStreamEntryOrderBy START_DATE_ASC = new LiveStreamEntryOrderBy("+startDate");
		public static readonly LiveStreamEntryOrderBy TOTAL_RANK_ASC = new LiveStreamEntryOrderBy("+totalRank");
		public static readonly LiveStreamEntryOrderBy UPDATED_AT_ASC = new LiveStreamEntryOrderBy("+updatedAt");
		public static readonly LiveStreamEntryOrderBy VIEWS_ASC = new LiveStreamEntryOrderBy("+views");
		public static readonly LiveStreamEntryOrderBy WEIGHT_ASC = new LiveStreamEntryOrderBy("+weight");
		public static readonly LiveStreamEntryOrderBy CREATED_AT_DESC = new LiveStreamEntryOrderBy("-createdAt");
		public static readonly LiveStreamEntryOrderBy DURATION_DESC = new LiveStreamEntryOrderBy("-duration");
		public static readonly LiveStreamEntryOrderBy END_DATE_DESC = new LiveStreamEntryOrderBy("-endDate");
		public static readonly LiveStreamEntryOrderBy FIRST_BROADCAST_DESC = new LiveStreamEntryOrderBy("-firstBroadcast");
		public static readonly LiveStreamEntryOrderBy LAST_BROADCAST_DESC = new LiveStreamEntryOrderBy("-lastBroadcast");
		public static readonly LiveStreamEntryOrderBy LAST_PLAYED_AT_DESC = new LiveStreamEntryOrderBy("-lastPlayedAt");
		public static readonly LiveStreamEntryOrderBy MEDIA_TYPE_DESC = new LiveStreamEntryOrderBy("-mediaType");
		public static readonly LiveStreamEntryOrderBy MODERATION_COUNT_DESC = new LiveStreamEntryOrderBy("-moderationCount");
		public static readonly LiveStreamEntryOrderBy NAME_DESC = new LiveStreamEntryOrderBy("-name");
		public static readonly LiveStreamEntryOrderBy PARTNER_SORT_VALUE_DESC = new LiveStreamEntryOrderBy("-partnerSortValue");
		public static readonly LiveStreamEntryOrderBy PLAYS_DESC = new LiveStreamEntryOrderBy("-plays");
		public static readonly LiveStreamEntryOrderBy RANK_DESC = new LiveStreamEntryOrderBy("-rank");
		public static readonly LiveStreamEntryOrderBy RECENT_DESC = new LiveStreamEntryOrderBy("-recent");
		public static readonly LiveStreamEntryOrderBy START_DATE_DESC = new LiveStreamEntryOrderBy("-startDate");
		public static readonly LiveStreamEntryOrderBy TOTAL_RANK_DESC = new LiveStreamEntryOrderBy("-totalRank");
		public static readonly LiveStreamEntryOrderBy UPDATED_AT_DESC = new LiveStreamEntryOrderBy("-updatedAt");
		public static readonly LiveStreamEntryOrderBy VIEWS_DESC = new LiveStreamEntryOrderBy("-views");
		public static readonly LiveStreamEntryOrderBy WEIGHT_DESC = new LiveStreamEntryOrderBy("-weight");

		private LiveStreamEntryOrderBy(string name) : base(name) { }
	}
}
