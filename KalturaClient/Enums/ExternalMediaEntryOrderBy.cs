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
	public sealed class ExternalMediaEntryOrderBy : StringEnum
	{
		public static readonly ExternalMediaEntryOrderBy CREATED_AT_ASC = new ExternalMediaEntryOrderBy("+createdAt");
		public static readonly ExternalMediaEntryOrderBy DURATION_ASC = new ExternalMediaEntryOrderBy("+duration");
		public static readonly ExternalMediaEntryOrderBy END_DATE_ASC = new ExternalMediaEntryOrderBy("+endDate");
		public static readonly ExternalMediaEntryOrderBy LAST_PLAYED_AT_ASC = new ExternalMediaEntryOrderBy("+lastPlayedAt");
		public static readonly ExternalMediaEntryOrderBy MEDIA_TYPE_ASC = new ExternalMediaEntryOrderBy("+mediaType");
		public static readonly ExternalMediaEntryOrderBy MODERATION_COUNT_ASC = new ExternalMediaEntryOrderBy("+moderationCount");
		public static readonly ExternalMediaEntryOrderBy NAME_ASC = new ExternalMediaEntryOrderBy("+name");
		public static readonly ExternalMediaEntryOrderBy PARTNER_SORT_VALUE_ASC = new ExternalMediaEntryOrderBy("+partnerSortValue");
		public static readonly ExternalMediaEntryOrderBy PLAYS_ASC = new ExternalMediaEntryOrderBy("+plays");
		public static readonly ExternalMediaEntryOrderBy RANK_ASC = new ExternalMediaEntryOrderBy("+rank");
		public static readonly ExternalMediaEntryOrderBy RECENT_ASC = new ExternalMediaEntryOrderBy("+recent");
		public static readonly ExternalMediaEntryOrderBy START_DATE_ASC = new ExternalMediaEntryOrderBy("+startDate");
		public static readonly ExternalMediaEntryOrderBy TOTAL_RANK_ASC = new ExternalMediaEntryOrderBy("+totalRank");
		public static readonly ExternalMediaEntryOrderBy UPDATED_AT_ASC = new ExternalMediaEntryOrderBy("+updatedAt");
		public static readonly ExternalMediaEntryOrderBy VIEWS_ASC = new ExternalMediaEntryOrderBy("+views");
		public static readonly ExternalMediaEntryOrderBy WEIGHT_ASC = new ExternalMediaEntryOrderBy("+weight");
		public static readonly ExternalMediaEntryOrderBy CREATED_AT_DESC = new ExternalMediaEntryOrderBy("-createdAt");
		public static readonly ExternalMediaEntryOrderBy DURATION_DESC = new ExternalMediaEntryOrderBy("-duration");
		public static readonly ExternalMediaEntryOrderBy END_DATE_DESC = new ExternalMediaEntryOrderBy("-endDate");
		public static readonly ExternalMediaEntryOrderBy LAST_PLAYED_AT_DESC = new ExternalMediaEntryOrderBy("-lastPlayedAt");
		public static readonly ExternalMediaEntryOrderBy MEDIA_TYPE_DESC = new ExternalMediaEntryOrderBy("-mediaType");
		public static readonly ExternalMediaEntryOrderBy MODERATION_COUNT_DESC = new ExternalMediaEntryOrderBy("-moderationCount");
		public static readonly ExternalMediaEntryOrderBy NAME_DESC = new ExternalMediaEntryOrderBy("-name");
		public static readonly ExternalMediaEntryOrderBy PARTNER_SORT_VALUE_DESC = new ExternalMediaEntryOrderBy("-partnerSortValue");
		public static readonly ExternalMediaEntryOrderBy PLAYS_DESC = new ExternalMediaEntryOrderBy("-plays");
		public static readonly ExternalMediaEntryOrderBy RANK_DESC = new ExternalMediaEntryOrderBy("-rank");
		public static readonly ExternalMediaEntryOrderBy RECENT_DESC = new ExternalMediaEntryOrderBy("-recent");
		public static readonly ExternalMediaEntryOrderBy START_DATE_DESC = new ExternalMediaEntryOrderBy("-startDate");
		public static readonly ExternalMediaEntryOrderBy TOTAL_RANK_DESC = new ExternalMediaEntryOrderBy("-totalRank");
		public static readonly ExternalMediaEntryOrderBy UPDATED_AT_DESC = new ExternalMediaEntryOrderBy("-updatedAt");
		public static readonly ExternalMediaEntryOrderBy VIEWS_DESC = new ExternalMediaEntryOrderBy("-views");
		public static readonly ExternalMediaEntryOrderBy WEIGHT_DESC = new ExternalMediaEntryOrderBy("-weight");

		private ExternalMediaEntryOrderBy(string name) : base(name) { }
	}
}
