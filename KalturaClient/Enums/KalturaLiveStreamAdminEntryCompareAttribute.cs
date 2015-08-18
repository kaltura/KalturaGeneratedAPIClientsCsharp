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
	public sealed class KalturaLiveStreamAdminEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaLiveStreamAdminEntryCompareAttribute("accessControlId");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute CREATED_AT = new KalturaLiveStreamAdminEntryCompareAttribute("createdAt");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute END_DATE = new KalturaLiveStreamAdminEntryCompareAttribute("endDate");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute LAST_PLAYED_AT = new KalturaLiveStreamAdminEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute MEDIA_DATE = new KalturaLiveStreamAdminEntryCompareAttribute("mediaDate");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute MEDIA_TYPE = new KalturaLiveStreamAdminEntryCompareAttribute("mediaType");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute MODERATION_COUNT = new KalturaLiveStreamAdminEntryCompareAttribute("moderationCount");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute MODERATION_STATUS = new KalturaLiveStreamAdminEntryCompareAttribute("moderationStatus");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute MS_DURATION = new KalturaLiveStreamAdminEntryCompareAttribute("msDuration");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute PARTNER_ID = new KalturaLiveStreamAdminEntryCompareAttribute("partnerId");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaLiveStreamAdminEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute PLAYS = new KalturaLiveStreamAdminEntryCompareAttribute("plays");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute RANK = new KalturaLiveStreamAdminEntryCompareAttribute("rank");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute REPLACEMENT_STATUS = new KalturaLiveStreamAdminEntryCompareAttribute("replacementStatus");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute START_DATE = new KalturaLiveStreamAdminEntryCompareAttribute("startDate");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute STATUS = new KalturaLiveStreamAdminEntryCompareAttribute("status");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute TOTAL_RANK = new KalturaLiveStreamAdminEntryCompareAttribute("totalRank");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute TYPE = new KalturaLiveStreamAdminEntryCompareAttribute("type");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute UPDATED_AT = new KalturaLiveStreamAdminEntryCompareAttribute("updatedAt");
		public static readonly KalturaLiveStreamAdminEntryCompareAttribute VIEWS = new KalturaLiveStreamAdminEntryCompareAttribute("views");

		private KalturaLiveStreamAdminEntryCompareAttribute(string name) : base(name) { }
	}
}
