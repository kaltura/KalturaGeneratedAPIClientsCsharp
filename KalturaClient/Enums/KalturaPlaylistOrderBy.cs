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
	public sealed class KalturaPlaylistOrderBy : KalturaStringEnum
	{
		public static readonly KalturaPlaylistOrderBy CREATED_AT_ASC = new KalturaPlaylistOrderBy("+createdAt");
		public static readonly KalturaPlaylistOrderBy END_DATE_ASC = new KalturaPlaylistOrderBy("+endDate");
		public static readonly KalturaPlaylistOrderBy MODERATION_COUNT_ASC = new KalturaPlaylistOrderBy("+moderationCount");
		public static readonly KalturaPlaylistOrderBy NAME_ASC = new KalturaPlaylistOrderBy("+name");
		public static readonly KalturaPlaylistOrderBy PARTNER_SORT_VALUE_ASC = new KalturaPlaylistOrderBy("+partnerSortValue");
		public static readonly KalturaPlaylistOrderBy RANK_ASC = new KalturaPlaylistOrderBy("+rank");
		public static readonly KalturaPlaylistOrderBy RECENT_ASC = new KalturaPlaylistOrderBy("+recent");
		public static readonly KalturaPlaylistOrderBy START_DATE_ASC = new KalturaPlaylistOrderBy("+startDate");
		public static readonly KalturaPlaylistOrderBy TOTAL_RANK_ASC = new KalturaPlaylistOrderBy("+totalRank");
		public static readonly KalturaPlaylistOrderBy UPDATED_AT_ASC = new KalturaPlaylistOrderBy("+updatedAt");
		public static readonly KalturaPlaylistOrderBy WEIGHT_ASC = new KalturaPlaylistOrderBy("+weight");
		public static readonly KalturaPlaylistOrderBy CREATED_AT_DESC = new KalturaPlaylistOrderBy("-createdAt");
		public static readonly KalturaPlaylistOrderBy END_DATE_DESC = new KalturaPlaylistOrderBy("-endDate");
		public static readonly KalturaPlaylistOrderBy MODERATION_COUNT_DESC = new KalturaPlaylistOrderBy("-moderationCount");
		public static readonly KalturaPlaylistOrderBy NAME_DESC = new KalturaPlaylistOrderBy("-name");
		public static readonly KalturaPlaylistOrderBy PARTNER_SORT_VALUE_DESC = new KalturaPlaylistOrderBy("-partnerSortValue");
		public static readonly KalturaPlaylistOrderBy RANK_DESC = new KalturaPlaylistOrderBy("-rank");
		public static readonly KalturaPlaylistOrderBy RECENT_DESC = new KalturaPlaylistOrderBy("-recent");
		public static readonly KalturaPlaylistOrderBy START_DATE_DESC = new KalturaPlaylistOrderBy("-startDate");
		public static readonly KalturaPlaylistOrderBy TOTAL_RANK_DESC = new KalturaPlaylistOrderBy("-totalRank");
		public static readonly KalturaPlaylistOrderBy UPDATED_AT_DESC = new KalturaPlaylistOrderBy("-updatedAt");
		public static readonly KalturaPlaylistOrderBy WEIGHT_DESC = new KalturaPlaylistOrderBy("-weight");

		private KalturaPlaylistOrderBy(string name) : base(name) { }
	}
}
