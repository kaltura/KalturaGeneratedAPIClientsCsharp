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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public sealed class KalturaLiveChannelCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveChannelCompareAttribute ACCESS_CONTROL_ID = new KalturaLiveChannelCompareAttribute("accessControlId");
		public static readonly KalturaLiveChannelCompareAttribute CREATED_AT = new KalturaLiveChannelCompareAttribute("createdAt");
		public static readonly KalturaLiveChannelCompareAttribute END_DATE = new KalturaLiveChannelCompareAttribute("endDate");
		public static readonly KalturaLiveChannelCompareAttribute LAST_PLAYED_AT = new KalturaLiveChannelCompareAttribute("lastPlayedAt");
		public static readonly KalturaLiveChannelCompareAttribute MEDIA_DATE = new KalturaLiveChannelCompareAttribute("mediaDate");
		public static readonly KalturaLiveChannelCompareAttribute MEDIA_TYPE = new KalturaLiveChannelCompareAttribute("mediaType");
		public static readonly KalturaLiveChannelCompareAttribute MODERATION_COUNT = new KalturaLiveChannelCompareAttribute("moderationCount");
		public static readonly KalturaLiveChannelCompareAttribute MODERATION_STATUS = new KalturaLiveChannelCompareAttribute("moderationStatus");
		public static readonly KalturaLiveChannelCompareAttribute MS_DURATION = new KalturaLiveChannelCompareAttribute("msDuration");
		public static readonly KalturaLiveChannelCompareAttribute PARTNER_ID = new KalturaLiveChannelCompareAttribute("partnerId");
		public static readonly KalturaLiveChannelCompareAttribute PARTNER_SORT_VALUE = new KalturaLiveChannelCompareAttribute("partnerSortValue");
		public static readonly KalturaLiveChannelCompareAttribute PLAYS = new KalturaLiveChannelCompareAttribute("plays");
		public static readonly KalturaLiveChannelCompareAttribute RANK = new KalturaLiveChannelCompareAttribute("rank");
		public static readonly KalturaLiveChannelCompareAttribute REPLACEMENT_STATUS = new KalturaLiveChannelCompareAttribute("replacementStatus");
		public static readonly KalturaLiveChannelCompareAttribute START_DATE = new KalturaLiveChannelCompareAttribute("startDate");
		public static readonly KalturaLiveChannelCompareAttribute STATUS = new KalturaLiveChannelCompareAttribute("status");
		public static readonly KalturaLiveChannelCompareAttribute TOTAL_RANK = new KalturaLiveChannelCompareAttribute("totalRank");
		public static readonly KalturaLiveChannelCompareAttribute TYPE = new KalturaLiveChannelCompareAttribute("type");
		public static readonly KalturaLiveChannelCompareAttribute UPDATED_AT = new KalturaLiveChannelCompareAttribute("updatedAt");
		public static readonly KalturaLiveChannelCompareAttribute VIEWS = new KalturaLiveChannelCompareAttribute("views");

		private KalturaLiveChannelCompareAttribute(string name) : base(name) { }
	}
}
