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
	public sealed class KalturaLiveStreamEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaLiveStreamEntryCompareAttribute("accessControlId");
		public static readonly KalturaLiveStreamEntryCompareAttribute CREATED_AT = new KalturaLiveStreamEntryCompareAttribute("createdAt");
		public static readonly KalturaLiveStreamEntryCompareAttribute END_DATE = new KalturaLiveStreamEntryCompareAttribute("endDate");
		public static readonly KalturaLiveStreamEntryCompareAttribute LAST_PLAYED_AT = new KalturaLiveStreamEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaLiveStreamEntryCompareAttribute MEDIA_DATE = new KalturaLiveStreamEntryCompareAttribute("mediaDate");
		public static readonly KalturaLiveStreamEntryCompareAttribute MEDIA_TYPE = new KalturaLiveStreamEntryCompareAttribute("mediaType");
		public static readonly KalturaLiveStreamEntryCompareAttribute MODERATION_COUNT = new KalturaLiveStreamEntryCompareAttribute("moderationCount");
		public static readonly KalturaLiveStreamEntryCompareAttribute MODERATION_STATUS = new KalturaLiveStreamEntryCompareAttribute("moderationStatus");
		public static readonly KalturaLiveStreamEntryCompareAttribute MS_DURATION = new KalturaLiveStreamEntryCompareAttribute("msDuration");
		public static readonly KalturaLiveStreamEntryCompareAttribute PARTNER_ID = new KalturaLiveStreamEntryCompareAttribute("partnerId");
		public static readonly KalturaLiveStreamEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaLiveStreamEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaLiveStreamEntryCompareAttribute PLAYS = new KalturaLiveStreamEntryCompareAttribute("plays");
		public static readonly KalturaLiveStreamEntryCompareAttribute RANK = new KalturaLiveStreamEntryCompareAttribute("rank");
		public static readonly KalturaLiveStreamEntryCompareAttribute REPLACEMENT_STATUS = new KalturaLiveStreamEntryCompareAttribute("replacementStatus");
		public static readonly KalturaLiveStreamEntryCompareAttribute START_DATE = new KalturaLiveStreamEntryCompareAttribute("startDate");
		public static readonly KalturaLiveStreamEntryCompareAttribute STATUS = new KalturaLiveStreamEntryCompareAttribute("status");
		public static readonly KalturaLiveStreamEntryCompareAttribute TOTAL_RANK = new KalturaLiveStreamEntryCompareAttribute("totalRank");
		public static readonly KalturaLiveStreamEntryCompareAttribute TYPE = new KalturaLiveStreamEntryCompareAttribute("type");
		public static readonly KalturaLiveStreamEntryCompareAttribute UPDATED_AT = new KalturaLiveStreamEntryCompareAttribute("updatedAt");
		public static readonly KalturaLiveStreamEntryCompareAttribute VIEWS = new KalturaLiveStreamEntryCompareAttribute("views");

		private KalturaLiveStreamEntryCompareAttribute(string name) : base(name) { }
	}
}
