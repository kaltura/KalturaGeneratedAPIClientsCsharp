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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaPlaylistCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaPlaylistCompareAttribute ACCESS_CONTROL_ID = new KalturaPlaylistCompareAttribute("accessControlId");
		public static readonly KalturaPlaylistCompareAttribute CREATED_AT = new KalturaPlaylistCompareAttribute("createdAt");
		public static readonly KalturaPlaylistCompareAttribute END_DATE = new KalturaPlaylistCompareAttribute("endDate");
		public static readonly KalturaPlaylistCompareAttribute MODERATION_COUNT = new KalturaPlaylistCompareAttribute("moderationCount");
		public static readonly KalturaPlaylistCompareAttribute MODERATION_STATUS = new KalturaPlaylistCompareAttribute("moderationStatus");
		public static readonly KalturaPlaylistCompareAttribute PARTNER_ID = new KalturaPlaylistCompareAttribute("partnerId");
		public static readonly KalturaPlaylistCompareAttribute PARTNER_SORT_VALUE = new KalturaPlaylistCompareAttribute("partnerSortValue");
		public static readonly KalturaPlaylistCompareAttribute RANK = new KalturaPlaylistCompareAttribute("rank");
		public static readonly KalturaPlaylistCompareAttribute REPLACEMENT_STATUS = new KalturaPlaylistCompareAttribute("replacementStatus");
		public static readonly KalturaPlaylistCompareAttribute START_DATE = new KalturaPlaylistCompareAttribute("startDate");
		public static readonly KalturaPlaylistCompareAttribute STATUS = new KalturaPlaylistCompareAttribute("status");
		public static readonly KalturaPlaylistCompareAttribute TOTAL_RANK = new KalturaPlaylistCompareAttribute("totalRank");
		public static readonly KalturaPlaylistCompareAttribute TYPE = new KalturaPlaylistCompareAttribute("type");
		public static readonly KalturaPlaylistCompareAttribute UPDATED_AT = new KalturaPlaylistCompareAttribute("updatedAt");

		private KalturaPlaylistCompareAttribute(string name) : base(name) { }
	}
}
