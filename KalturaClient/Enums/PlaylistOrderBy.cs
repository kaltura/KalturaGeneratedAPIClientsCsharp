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
	public sealed class PlaylistOrderBy : StringEnum
	{
		public static readonly PlaylistOrderBy CREATED_AT_ASC = new PlaylistOrderBy("+createdAt");
		public static readonly PlaylistOrderBy END_DATE_ASC = new PlaylistOrderBy("+endDate");
		public static readonly PlaylistOrderBy MODERATION_COUNT_ASC = new PlaylistOrderBy("+moderationCount");
		public static readonly PlaylistOrderBy NAME_ASC = new PlaylistOrderBy("+name");
		public static readonly PlaylistOrderBy PARTNER_SORT_VALUE_ASC = new PlaylistOrderBy("+partnerSortValue");
		public static readonly PlaylistOrderBy RANK_ASC = new PlaylistOrderBy("+rank");
		public static readonly PlaylistOrderBy RECENT_ASC = new PlaylistOrderBy("+recent");
		public static readonly PlaylistOrderBy START_DATE_ASC = new PlaylistOrderBy("+startDate");
		public static readonly PlaylistOrderBy TOTAL_RANK_ASC = new PlaylistOrderBy("+totalRank");
		public static readonly PlaylistOrderBy UPDATED_AT_ASC = new PlaylistOrderBy("+updatedAt");
		public static readonly PlaylistOrderBy WEIGHT_ASC = new PlaylistOrderBy("+weight");
		public static readonly PlaylistOrderBy CREATED_AT_DESC = new PlaylistOrderBy("-createdAt");
		public static readonly PlaylistOrderBy END_DATE_DESC = new PlaylistOrderBy("-endDate");
		public static readonly PlaylistOrderBy MODERATION_COUNT_DESC = new PlaylistOrderBy("-moderationCount");
		public static readonly PlaylistOrderBy NAME_DESC = new PlaylistOrderBy("-name");
		public static readonly PlaylistOrderBy PARTNER_SORT_VALUE_DESC = new PlaylistOrderBy("-partnerSortValue");
		public static readonly PlaylistOrderBy RANK_DESC = new PlaylistOrderBy("-rank");
		public static readonly PlaylistOrderBy RECENT_DESC = new PlaylistOrderBy("-recent");
		public static readonly PlaylistOrderBy START_DATE_DESC = new PlaylistOrderBy("-startDate");
		public static readonly PlaylistOrderBy TOTAL_RANK_DESC = new PlaylistOrderBy("-totalRank");
		public static readonly PlaylistOrderBy UPDATED_AT_DESC = new PlaylistOrderBy("-updatedAt");
		public static readonly PlaylistOrderBy WEIGHT_DESC = new PlaylistOrderBy("-weight");

		private PlaylistOrderBy(string name) : base(name) { }
	}
}
