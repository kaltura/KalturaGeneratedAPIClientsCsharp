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
	public sealed class LiveChannelCompareAttribute : StringEnum
	{
		public static readonly LiveChannelCompareAttribute ACCESS_CONTROL_ID = new LiveChannelCompareAttribute("accessControlId");
		public static readonly LiveChannelCompareAttribute CREATED_AT = new LiveChannelCompareAttribute("createdAt");
		public static readonly LiveChannelCompareAttribute END_DATE = new LiveChannelCompareAttribute("endDate");
		public static readonly LiveChannelCompareAttribute LAST_PLAYED_AT = new LiveChannelCompareAttribute("lastPlayedAt");
		public static readonly LiveChannelCompareAttribute MEDIA_DATE = new LiveChannelCompareAttribute("mediaDate");
		public static readonly LiveChannelCompareAttribute MEDIA_TYPE = new LiveChannelCompareAttribute("mediaType");
		public static readonly LiveChannelCompareAttribute MODERATION_COUNT = new LiveChannelCompareAttribute("moderationCount");
		public static readonly LiveChannelCompareAttribute MODERATION_STATUS = new LiveChannelCompareAttribute("moderationStatus");
		public static readonly LiveChannelCompareAttribute MS_DURATION = new LiveChannelCompareAttribute("msDuration");
		public static readonly LiveChannelCompareAttribute PARTNER_ID = new LiveChannelCompareAttribute("partnerId");
		public static readonly LiveChannelCompareAttribute PARTNER_SORT_VALUE = new LiveChannelCompareAttribute("partnerSortValue");
		public static readonly LiveChannelCompareAttribute PLAYS = new LiveChannelCompareAttribute("plays");
		public static readonly LiveChannelCompareAttribute RANK = new LiveChannelCompareAttribute("rank");
		public static readonly LiveChannelCompareAttribute REPLACEMENT_STATUS = new LiveChannelCompareAttribute("replacementStatus");
		public static readonly LiveChannelCompareAttribute START_DATE = new LiveChannelCompareAttribute("startDate");
		public static readonly LiveChannelCompareAttribute STATUS = new LiveChannelCompareAttribute("status");
		public static readonly LiveChannelCompareAttribute TOTAL_RANK = new LiveChannelCompareAttribute("totalRank");
		public static readonly LiveChannelCompareAttribute TYPE = new LiveChannelCompareAttribute("type");
		public static readonly LiveChannelCompareAttribute UPDATED_AT = new LiveChannelCompareAttribute("updatedAt");
		public static readonly LiveChannelCompareAttribute VIEWS = new LiveChannelCompareAttribute("views");

		private LiveChannelCompareAttribute(string name) : base(name) { }
	}
}
