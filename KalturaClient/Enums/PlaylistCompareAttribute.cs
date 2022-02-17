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
	public sealed class PlaylistCompareAttribute : StringEnum
	{
		public static readonly PlaylistCompareAttribute ACCESS_CONTROL_ID = new PlaylistCompareAttribute("accessControlId");
		public static readonly PlaylistCompareAttribute CREATED_AT = new PlaylistCompareAttribute("createdAt");
		public static readonly PlaylistCompareAttribute END_DATE = new PlaylistCompareAttribute("endDate");
		public static readonly PlaylistCompareAttribute MODERATION_COUNT = new PlaylistCompareAttribute("moderationCount");
		public static readonly PlaylistCompareAttribute MODERATION_STATUS = new PlaylistCompareAttribute("moderationStatus");
		public static readonly PlaylistCompareAttribute PARTNER_ID = new PlaylistCompareAttribute("partnerId");
		public static readonly PlaylistCompareAttribute PARTNER_SORT_VALUE = new PlaylistCompareAttribute("partnerSortValue");
		public static readonly PlaylistCompareAttribute RANK = new PlaylistCompareAttribute("rank");
		public static readonly PlaylistCompareAttribute REPLACEMENT_STATUS = new PlaylistCompareAttribute("replacementStatus");
		public static readonly PlaylistCompareAttribute START_DATE = new PlaylistCompareAttribute("startDate");
		public static readonly PlaylistCompareAttribute STATUS = new PlaylistCompareAttribute("status");
		public static readonly PlaylistCompareAttribute TOTAL_RANK = new PlaylistCompareAttribute("totalRank");
		public static readonly PlaylistCompareAttribute TYPE = new PlaylistCompareAttribute("type");
		public static readonly PlaylistCompareAttribute UPDATED_AT = new PlaylistCompareAttribute("updatedAt");

		private PlaylistCompareAttribute(string name) : base(name) { }
	}
}
