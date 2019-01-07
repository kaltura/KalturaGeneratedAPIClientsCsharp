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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class MixEntryOrderBy : StringEnum
	{
		public static readonly MixEntryOrderBy CREATED_AT_ASC = new MixEntryOrderBy("+createdAt");
		public static readonly MixEntryOrderBy DURATION_ASC = new MixEntryOrderBy("+duration");
		public static readonly MixEntryOrderBy END_DATE_ASC = new MixEntryOrderBy("+endDate");
		public static readonly MixEntryOrderBy LAST_PLAYED_AT_ASC = new MixEntryOrderBy("+lastPlayedAt");
		public static readonly MixEntryOrderBy MODERATION_COUNT_ASC = new MixEntryOrderBy("+moderationCount");
		public static readonly MixEntryOrderBy NAME_ASC = new MixEntryOrderBy("+name");
		public static readonly MixEntryOrderBy PARTNER_SORT_VALUE_ASC = new MixEntryOrderBy("+partnerSortValue");
		public static readonly MixEntryOrderBy PLAYS_ASC = new MixEntryOrderBy("+plays");
		public static readonly MixEntryOrderBy RANK_ASC = new MixEntryOrderBy("+rank");
		public static readonly MixEntryOrderBy RECENT_ASC = new MixEntryOrderBy("+recent");
		public static readonly MixEntryOrderBy START_DATE_ASC = new MixEntryOrderBy("+startDate");
		public static readonly MixEntryOrderBy TOTAL_RANK_ASC = new MixEntryOrderBy("+totalRank");
		public static readonly MixEntryOrderBy UPDATED_AT_ASC = new MixEntryOrderBy("+updatedAt");
		public static readonly MixEntryOrderBy VIEWS_ASC = new MixEntryOrderBy("+views");
		public static readonly MixEntryOrderBy WEIGHT_ASC = new MixEntryOrderBy("+weight");
		public static readonly MixEntryOrderBy CREATED_AT_DESC = new MixEntryOrderBy("-createdAt");
		public static readonly MixEntryOrderBy DURATION_DESC = new MixEntryOrderBy("-duration");
		public static readonly MixEntryOrderBy END_DATE_DESC = new MixEntryOrderBy("-endDate");
		public static readonly MixEntryOrderBy LAST_PLAYED_AT_DESC = new MixEntryOrderBy("-lastPlayedAt");
		public static readonly MixEntryOrderBy MODERATION_COUNT_DESC = new MixEntryOrderBy("-moderationCount");
		public static readonly MixEntryOrderBy NAME_DESC = new MixEntryOrderBy("-name");
		public static readonly MixEntryOrderBy PARTNER_SORT_VALUE_DESC = new MixEntryOrderBy("-partnerSortValue");
		public static readonly MixEntryOrderBy PLAYS_DESC = new MixEntryOrderBy("-plays");
		public static readonly MixEntryOrderBy RANK_DESC = new MixEntryOrderBy("-rank");
		public static readonly MixEntryOrderBy RECENT_DESC = new MixEntryOrderBy("-recent");
		public static readonly MixEntryOrderBy START_DATE_DESC = new MixEntryOrderBy("-startDate");
		public static readonly MixEntryOrderBy TOTAL_RANK_DESC = new MixEntryOrderBy("-totalRank");
		public static readonly MixEntryOrderBy UPDATED_AT_DESC = new MixEntryOrderBy("-updatedAt");
		public static readonly MixEntryOrderBy VIEWS_DESC = new MixEntryOrderBy("-views");
		public static readonly MixEntryOrderBy WEIGHT_DESC = new MixEntryOrderBy("-weight");

		private MixEntryOrderBy(string name) : base(name) { }
	}
}
