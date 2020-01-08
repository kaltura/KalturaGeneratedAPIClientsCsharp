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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class PlayableEntryOrderBy : StringEnum
	{
		public static readonly PlayableEntryOrderBy CREATED_AT_ASC = new PlayableEntryOrderBy("+createdAt");
		public static readonly PlayableEntryOrderBy DURATION_ASC = new PlayableEntryOrderBy("+duration");
		public static readonly PlayableEntryOrderBy END_DATE_ASC = new PlayableEntryOrderBy("+endDate");
		public static readonly PlayableEntryOrderBy LAST_PLAYED_AT_ASC = new PlayableEntryOrderBy("+lastPlayedAt");
		public static readonly PlayableEntryOrderBy MODERATION_COUNT_ASC = new PlayableEntryOrderBy("+moderationCount");
		public static readonly PlayableEntryOrderBy NAME_ASC = new PlayableEntryOrderBy("+name");
		public static readonly PlayableEntryOrderBy PARTNER_SORT_VALUE_ASC = new PlayableEntryOrderBy("+partnerSortValue");
		public static readonly PlayableEntryOrderBy PLAYS_ASC = new PlayableEntryOrderBy("+plays");
		public static readonly PlayableEntryOrderBy RANK_ASC = new PlayableEntryOrderBy("+rank");
		public static readonly PlayableEntryOrderBy RECENT_ASC = new PlayableEntryOrderBy("+recent");
		public static readonly PlayableEntryOrderBy START_DATE_ASC = new PlayableEntryOrderBy("+startDate");
		public static readonly PlayableEntryOrderBy TOTAL_RANK_ASC = new PlayableEntryOrderBy("+totalRank");
		public static readonly PlayableEntryOrderBy UPDATED_AT_ASC = new PlayableEntryOrderBy("+updatedAt");
		public static readonly PlayableEntryOrderBy VIEWS_ASC = new PlayableEntryOrderBy("+views");
		public static readonly PlayableEntryOrderBy WEIGHT_ASC = new PlayableEntryOrderBy("+weight");
		public static readonly PlayableEntryOrderBy CREATED_AT_DESC = new PlayableEntryOrderBy("-createdAt");
		public static readonly PlayableEntryOrderBy DURATION_DESC = new PlayableEntryOrderBy("-duration");
		public static readonly PlayableEntryOrderBy END_DATE_DESC = new PlayableEntryOrderBy("-endDate");
		public static readonly PlayableEntryOrderBy LAST_PLAYED_AT_DESC = new PlayableEntryOrderBy("-lastPlayedAt");
		public static readonly PlayableEntryOrderBy MODERATION_COUNT_DESC = new PlayableEntryOrderBy("-moderationCount");
		public static readonly PlayableEntryOrderBy NAME_DESC = new PlayableEntryOrderBy("-name");
		public static readonly PlayableEntryOrderBy PARTNER_SORT_VALUE_DESC = new PlayableEntryOrderBy("-partnerSortValue");
		public static readonly PlayableEntryOrderBy PLAYS_DESC = new PlayableEntryOrderBy("-plays");
		public static readonly PlayableEntryOrderBy RANK_DESC = new PlayableEntryOrderBy("-rank");
		public static readonly PlayableEntryOrderBy RECENT_DESC = new PlayableEntryOrderBy("-recent");
		public static readonly PlayableEntryOrderBy START_DATE_DESC = new PlayableEntryOrderBy("-startDate");
		public static readonly PlayableEntryOrderBy TOTAL_RANK_DESC = new PlayableEntryOrderBy("-totalRank");
		public static readonly PlayableEntryOrderBy UPDATED_AT_DESC = new PlayableEntryOrderBy("-updatedAt");
		public static readonly PlayableEntryOrderBy VIEWS_DESC = new PlayableEntryOrderBy("-views");
		public static readonly PlayableEntryOrderBy WEIGHT_DESC = new PlayableEntryOrderBy("-weight");

		private PlayableEntryOrderBy(string name) : base(name) { }
	}
}
