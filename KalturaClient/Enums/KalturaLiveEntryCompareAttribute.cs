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
	public sealed class KalturaLiveEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaLiveEntryCompareAttribute("accessControlId");
		public static readonly KalturaLiveEntryCompareAttribute CREATED_AT = new KalturaLiveEntryCompareAttribute("createdAt");
		public static readonly KalturaLiveEntryCompareAttribute END_DATE = new KalturaLiveEntryCompareAttribute("endDate");
		public static readonly KalturaLiveEntryCompareAttribute LAST_PLAYED_AT = new KalturaLiveEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaLiveEntryCompareAttribute MEDIA_DATE = new KalturaLiveEntryCompareAttribute("mediaDate");
		public static readonly KalturaLiveEntryCompareAttribute MEDIA_TYPE = new KalturaLiveEntryCompareAttribute("mediaType");
		public static readonly KalturaLiveEntryCompareAttribute MODERATION_COUNT = new KalturaLiveEntryCompareAttribute("moderationCount");
		public static readonly KalturaLiveEntryCompareAttribute MODERATION_STATUS = new KalturaLiveEntryCompareAttribute("moderationStatus");
		public static readonly KalturaLiveEntryCompareAttribute MS_DURATION = new KalturaLiveEntryCompareAttribute("msDuration");
		public static readonly KalturaLiveEntryCompareAttribute PARTNER_ID = new KalturaLiveEntryCompareAttribute("partnerId");
		public static readonly KalturaLiveEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaLiveEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaLiveEntryCompareAttribute PLAYS = new KalturaLiveEntryCompareAttribute("plays");
		public static readonly KalturaLiveEntryCompareAttribute RANK = new KalturaLiveEntryCompareAttribute("rank");
		public static readonly KalturaLiveEntryCompareAttribute REPLACEMENT_STATUS = new KalturaLiveEntryCompareAttribute("replacementStatus");
		public static readonly KalturaLiveEntryCompareAttribute START_DATE = new KalturaLiveEntryCompareAttribute("startDate");
		public static readonly KalturaLiveEntryCompareAttribute STATUS = new KalturaLiveEntryCompareAttribute("status");
		public static readonly KalturaLiveEntryCompareAttribute TOTAL_RANK = new KalturaLiveEntryCompareAttribute("totalRank");
		public static readonly KalturaLiveEntryCompareAttribute TYPE = new KalturaLiveEntryCompareAttribute("type");
		public static readonly KalturaLiveEntryCompareAttribute UPDATED_AT = new KalturaLiveEntryCompareAttribute("updatedAt");
		public static readonly KalturaLiveEntryCompareAttribute VIEWS = new KalturaLiveEntryCompareAttribute("views");

		private KalturaLiveEntryCompareAttribute(string name) : base(name) { }
	}
}
