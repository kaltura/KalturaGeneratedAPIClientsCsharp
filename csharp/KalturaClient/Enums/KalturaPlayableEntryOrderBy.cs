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
	public sealed class KalturaPlayableEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPlayableEntryOrderBy CREATED_AT_ASC = new KalturaPlayableEntryOrderBy("+createdAt");
		public static readonly KalturaPlayableEntryOrderBy DURATION_ASC = new KalturaPlayableEntryOrderBy("+duration");
		public static readonly KalturaPlayableEntryOrderBy END_DATE_ASC = new KalturaPlayableEntryOrderBy("+endDate");
		public static readonly KalturaPlayableEntryOrderBy LAST_PLAYED_AT_ASC = new KalturaPlayableEntryOrderBy("+lastPlayedAt");
		public static readonly KalturaPlayableEntryOrderBy MODERATION_COUNT_ASC = new KalturaPlayableEntryOrderBy("+moderationCount");
		public static readonly KalturaPlayableEntryOrderBy NAME_ASC = new KalturaPlayableEntryOrderBy("+name");
		public static readonly KalturaPlayableEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaPlayableEntryOrderBy("+partnerSortValue");
		public static readonly KalturaPlayableEntryOrderBy PLAYS_ASC = new KalturaPlayableEntryOrderBy("+plays");
		public static readonly KalturaPlayableEntryOrderBy RANK_ASC = new KalturaPlayableEntryOrderBy("+rank");
		public static readonly KalturaPlayableEntryOrderBy RECENT_ASC = new KalturaPlayableEntryOrderBy("+recent");
		public static readonly KalturaPlayableEntryOrderBy START_DATE_ASC = new KalturaPlayableEntryOrderBy("+startDate");
		public static readonly KalturaPlayableEntryOrderBy TOTAL_RANK_ASC = new KalturaPlayableEntryOrderBy("+totalRank");
		public static readonly KalturaPlayableEntryOrderBy UPDATED_AT_ASC = new KalturaPlayableEntryOrderBy("+updatedAt");
		public static readonly KalturaPlayableEntryOrderBy VIEWS_ASC = new KalturaPlayableEntryOrderBy("+views");
		public static readonly KalturaPlayableEntryOrderBy WEIGHT_ASC = new KalturaPlayableEntryOrderBy("+weight");
		public static readonly KalturaPlayableEntryOrderBy CREATED_AT_DESC = new KalturaPlayableEntryOrderBy("-createdAt");
		public static readonly KalturaPlayableEntryOrderBy DURATION_DESC = new KalturaPlayableEntryOrderBy("-duration");
		public static readonly KalturaPlayableEntryOrderBy END_DATE_DESC = new KalturaPlayableEntryOrderBy("-endDate");
		public static readonly KalturaPlayableEntryOrderBy LAST_PLAYED_AT_DESC = new KalturaPlayableEntryOrderBy("-lastPlayedAt");
		public static readonly KalturaPlayableEntryOrderBy MODERATION_COUNT_DESC = new KalturaPlayableEntryOrderBy("-moderationCount");
		public static readonly KalturaPlayableEntryOrderBy NAME_DESC = new KalturaPlayableEntryOrderBy("-name");
		public static readonly KalturaPlayableEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaPlayableEntryOrderBy("-partnerSortValue");
		public static readonly KalturaPlayableEntryOrderBy PLAYS_DESC = new KalturaPlayableEntryOrderBy("-plays");
		public static readonly KalturaPlayableEntryOrderBy RANK_DESC = new KalturaPlayableEntryOrderBy("-rank");
		public static readonly KalturaPlayableEntryOrderBy RECENT_DESC = new KalturaPlayableEntryOrderBy("-recent");
		public static readonly KalturaPlayableEntryOrderBy START_DATE_DESC = new KalturaPlayableEntryOrderBy("-startDate");
		public static readonly KalturaPlayableEntryOrderBy TOTAL_RANK_DESC = new KalturaPlayableEntryOrderBy("-totalRank");
		public static readonly KalturaPlayableEntryOrderBy UPDATED_AT_DESC = new KalturaPlayableEntryOrderBy("-updatedAt");
		public static readonly KalturaPlayableEntryOrderBy VIEWS_DESC = new KalturaPlayableEntryOrderBy("-views");
		public static readonly KalturaPlayableEntryOrderBy WEIGHT_DESC = new KalturaPlayableEntryOrderBy("-weight");

		private KalturaPlayableEntryOrderBy(string name) : base(name) { }
	}
}
