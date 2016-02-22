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
	public sealed class KalturaMediaEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaMediaEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaMediaEntryCompareAttribute("accessControlId");
		public static readonly KalturaMediaEntryCompareAttribute CREATED_AT = new KalturaMediaEntryCompareAttribute("createdAt");
		public static readonly KalturaMediaEntryCompareAttribute END_DATE = new KalturaMediaEntryCompareAttribute("endDate");
		public static readonly KalturaMediaEntryCompareAttribute LAST_PLAYED_AT = new KalturaMediaEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaMediaEntryCompareAttribute MEDIA_DATE = new KalturaMediaEntryCompareAttribute("mediaDate");
		public static readonly KalturaMediaEntryCompareAttribute MEDIA_TYPE = new KalturaMediaEntryCompareAttribute("mediaType");
		public static readonly KalturaMediaEntryCompareAttribute MODERATION_COUNT = new KalturaMediaEntryCompareAttribute("moderationCount");
		public static readonly KalturaMediaEntryCompareAttribute MODERATION_STATUS = new KalturaMediaEntryCompareAttribute("moderationStatus");
		public static readonly KalturaMediaEntryCompareAttribute MS_DURATION = new KalturaMediaEntryCompareAttribute("msDuration");
		public static readonly KalturaMediaEntryCompareAttribute PARTNER_ID = new KalturaMediaEntryCompareAttribute("partnerId");
		public static readonly KalturaMediaEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaMediaEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaMediaEntryCompareAttribute PLAYS = new KalturaMediaEntryCompareAttribute("plays");
		public static readonly KalturaMediaEntryCompareAttribute RANK = new KalturaMediaEntryCompareAttribute("rank");
		public static readonly KalturaMediaEntryCompareAttribute REPLACEMENT_STATUS = new KalturaMediaEntryCompareAttribute("replacementStatus");
		public static readonly KalturaMediaEntryCompareAttribute START_DATE = new KalturaMediaEntryCompareAttribute("startDate");
		public static readonly KalturaMediaEntryCompareAttribute STATUS = new KalturaMediaEntryCompareAttribute("status");
		public static readonly KalturaMediaEntryCompareAttribute TOTAL_RANK = new KalturaMediaEntryCompareAttribute("totalRank");
		public static readonly KalturaMediaEntryCompareAttribute TYPE = new KalturaMediaEntryCompareAttribute("type");
		public static readonly KalturaMediaEntryCompareAttribute UPDATED_AT = new KalturaMediaEntryCompareAttribute("updatedAt");
		public static readonly KalturaMediaEntryCompareAttribute VIEWS = new KalturaMediaEntryCompareAttribute("views");

		private KalturaMediaEntryCompareAttribute(string name) : base(name) { }
	}
}
