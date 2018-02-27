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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class MediaEntryOrderBy : StringEnum
	{
		public static readonly MediaEntryOrderBy CREATED_AT_ASC = new MediaEntryOrderBy("+createdAt");
		public static readonly MediaEntryOrderBy DURATION_ASC = new MediaEntryOrderBy("+duration");
		public static readonly MediaEntryOrderBy END_DATE_ASC = new MediaEntryOrderBy("+endDate");
		public static readonly MediaEntryOrderBy LAST_PLAYED_AT_ASC = new MediaEntryOrderBy("+lastPlayedAt");
		public static readonly MediaEntryOrderBy MEDIA_TYPE_ASC = new MediaEntryOrderBy("+mediaType");
		public static readonly MediaEntryOrderBy MODERATION_COUNT_ASC = new MediaEntryOrderBy("+moderationCount");
		public static readonly MediaEntryOrderBy NAME_ASC = new MediaEntryOrderBy("+name");
		public static readonly MediaEntryOrderBy PARTNER_SORT_VALUE_ASC = new MediaEntryOrderBy("+partnerSortValue");
		public static readonly MediaEntryOrderBy PLAYS_ASC = new MediaEntryOrderBy("+plays");
		public static readonly MediaEntryOrderBy RANK_ASC = new MediaEntryOrderBy("+rank");
		public static readonly MediaEntryOrderBy RECENT_ASC = new MediaEntryOrderBy("+recent");
		public static readonly MediaEntryOrderBy START_DATE_ASC = new MediaEntryOrderBy("+startDate");
		public static readonly MediaEntryOrderBy TOTAL_RANK_ASC = new MediaEntryOrderBy("+totalRank");
		public static readonly MediaEntryOrderBy UPDATED_AT_ASC = new MediaEntryOrderBy("+updatedAt");
		public static readonly MediaEntryOrderBy VIEWS_ASC = new MediaEntryOrderBy("+views");
		public static readonly MediaEntryOrderBy WEIGHT_ASC = new MediaEntryOrderBy("+weight");
		public static readonly MediaEntryOrderBy CREATED_AT_DESC = new MediaEntryOrderBy("-createdAt");
		public static readonly MediaEntryOrderBy DURATION_DESC = new MediaEntryOrderBy("-duration");
		public static readonly MediaEntryOrderBy END_DATE_DESC = new MediaEntryOrderBy("-endDate");
		public static readonly MediaEntryOrderBy LAST_PLAYED_AT_DESC = new MediaEntryOrderBy("-lastPlayedAt");
		public static readonly MediaEntryOrderBy MEDIA_TYPE_DESC = new MediaEntryOrderBy("-mediaType");
		public static readonly MediaEntryOrderBy MODERATION_COUNT_DESC = new MediaEntryOrderBy("-moderationCount");
		public static readonly MediaEntryOrderBy NAME_DESC = new MediaEntryOrderBy("-name");
		public static readonly MediaEntryOrderBy PARTNER_SORT_VALUE_DESC = new MediaEntryOrderBy("-partnerSortValue");
		public static readonly MediaEntryOrderBy PLAYS_DESC = new MediaEntryOrderBy("-plays");
		public static readonly MediaEntryOrderBy RANK_DESC = new MediaEntryOrderBy("-rank");
		public static readonly MediaEntryOrderBy RECENT_DESC = new MediaEntryOrderBy("-recent");
		public static readonly MediaEntryOrderBy START_DATE_DESC = new MediaEntryOrderBy("-startDate");
		public static readonly MediaEntryOrderBy TOTAL_RANK_DESC = new MediaEntryOrderBy("-totalRank");
		public static readonly MediaEntryOrderBy UPDATED_AT_DESC = new MediaEntryOrderBy("-updatedAt");
		public static readonly MediaEntryOrderBy VIEWS_DESC = new MediaEntryOrderBy("-views");
		public static readonly MediaEntryOrderBy WEIGHT_DESC = new MediaEntryOrderBy("-weight");

		private MediaEntryOrderBy(string name) : base(name) { }
	}
}
