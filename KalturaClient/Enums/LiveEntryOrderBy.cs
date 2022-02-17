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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class LiveEntryOrderBy : StringEnum
	{
		public static readonly LiveEntryOrderBy CREATED_AT_ASC = new LiveEntryOrderBy("+createdAt");
		public static readonly LiveEntryOrderBy DURATION_ASC = new LiveEntryOrderBy("+duration");
		public static readonly LiveEntryOrderBy END_DATE_ASC = new LiveEntryOrderBy("+endDate");
		public static readonly LiveEntryOrderBy FIRST_BROADCAST_ASC = new LiveEntryOrderBy("+firstBroadcast");
		public static readonly LiveEntryOrderBy LAST_BROADCAST_ASC = new LiveEntryOrderBy("+lastBroadcast");
		public static readonly LiveEntryOrderBy LAST_PLAYED_AT_ASC = new LiveEntryOrderBy("+lastPlayedAt");
		public static readonly LiveEntryOrderBy MEDIA_TYPE_ASC = new LiveEntryOrderBy("+mediaType");
		public static readonly LiveEntryOrderBy MODERATION_COUNT_ASC = new LiveEntryOrderBy("+moderationCount");
		public static readonly LiveEntryOrderBy NAME_ASC = new LiveEntryOrderBy("+name");
		public static readonly LiveEntryOrderBy PARTNER_SORT_VALUE_ASC = new LiveEntryOrderBy("+partnerSortValue");
		public static readonly LiveEntryOrderBy PLAYS_ASC = new LiveEntryOrderBy("+plays");
		public static readonly LiveEntryOrderBy RANK_ASC = new LiveEntryOrderBy("+rank");
		public static readonly LiveEntryOrderBy RECENT_ASC = new LiveEntryOrderBy("+recent");
		public static readonly LiveEntryOrderBy START_DATE_ASC = new LiveEntryOrderBy("+startDate");
		public static readonly LiveEntryOrderBy TOTAL_RANK_ASC = new LiveEntryOrderBy("+totalRank");
		public static readonly LiveEntryOrderBy UPDATED_AT_ASC = new LiveEntryOrderBy("+updatedAt");
		public static readonly LiveEntryOrderBy VIEWS_ASC = new LiveEntryOrderBy("+views");
		public static readonly LiveEntryOrderBy WEIGHT_ASC = new LiveEntryOrderBy("+weight");
		public static readonly LiveEntryOrderBy CREATED_AT_DESC = new LiveEntryOrderBy("-createdAt");
		public static readonly LiveEntryOrderBy DURATION_DESC = new LiveEntryOrderBy("-duration");
		public static readonly LiveEntryOrderBy END_DATE_DESC = new LiveEntryOrderBy("-endDate");
		public static readonly LiveEntryOrderBy FIRST_BROADCAST_DESC = new LiveEntryOrderBy("-firstBroadcast");
		public static readonly LiveEntryOrderBy LAST_BROADCAST_DESC = new LiveEntryOrderBy("-lastBroadcast");
		public static readonly LiveEntryOrderBy LAST_PLAYED_AT_DESC = new LiveEntryOrderBy("-lastPlayedAt");
		public static readonly LiveEntryOrderBy MEDIA_TYPE_DESC = new LiveEntryOrderBy("-mediaType");
		public static readonly LiveEntryOrderBy MODERATION_COUNT_DESC = new LiveEntryOrderBy("-moderationCount");
		public static readonly LiveEntryOrderBy NAME_DESC = new LiveEntryOrderBy("-name");
		public static readonly LiveEntryOrderBy PARTNER_SORT_VALUE_DESC = new LiveEntryOrderBy("-partnerSortValue");
		public static readonly LiveEntryOrderBy PLAYS_DESC = new LiveEntryOrderBy("-plays");
		public static readonly LiveEntryOrderBy RANK_DESC = new LiveEntryOrderBy("-rank");
		public static readonly LiveEntryOrderBy RECENT_DESC = new LiveEntryOrderBy("-recent");
		public static readonly LiveEntryOrderBy START_DATE_DESC = new LiveEntryOrderBy("-startDate");
		public static readonly LiveEntryOrderBy TOTAL_RANK_DESC = new LiveEntryOrderBy("-totalRank");
		public static readonly LiveEntryOrderBy UPDATED_AT_DESC = new LiveEntryOrderBy("-updatedAt");
		public static readonly LiveEntryOrderBy VIEWS_DESC = new LiveEntryOrderBy("-views");
		public static readonly LiveEntryOrderBy WEIGHT_DESC = new LiveEntryOrderBy("-weight");

		private LiveEntryOrderBy(string name) : base(name) { }
	}
}
