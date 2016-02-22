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
	public sealed class KalturaExternalMediaEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaExternalMediaEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaExternalMediaEntryCompareAttribute("accessControlId");
		public static readonly KalturaExternalMediaEntryCompareAttribute CREATED_AT = new KalturaExternalMediaEntryCompareAttribute("createdAt");
		public static readonly KalturaExternalMediaEntryCompareAttribute END_DATE = new KalturaExternalMediaEntryCompareAttribute("endDate");
		public static readonly KalturaExternalMediaEntryCompareAttribute LAST_PLAYED_AT = new KalturaExternalMediaEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaExternalMediaEntryCompareAttribute MEDIA_DATE = new KalturaExternalMediaEntryCompareAttribute("mediaDate");
		public static readonly KalturaExternalMediaEntryCompareAttribute MEDIA_TYPE = new KalturaExternalMediaEntryCompareAttribute("mediaType");
		public static readonly KalturaExternalMediaEntryCompareAttribute MODERATION_COUNT = new KalturaExternalMediaEntryCompareAttribute("moderationCount");
		public static readonly KalturaExternalMediaEntryCompareAttribute MODERATION_STATUS = new KalturaExternalMediaEntryCompareAttribute("moderationStatus");
		public static readonly KalturaExternalMediaEntryCompareAttribute MS_DURATION = new KalturaExternalMediaEntryCompareAttribute("msDuration");
		public static readonly KalturaExternalMediaEntryCompareAttribute PARTNER_ID = new KalturaExternalMediaEntryCompareAttribute("partnerId");
		public static readonly KalturaExternalMediaEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaExternalMediaEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaExternalMediaEntryCompareAttribute PLAYS = new KalturaExternalMediaEntryCompareAttribute("plays");
		public static readonly KalturaExternalMediaEntryCompareAttribute RANK = new KalturaExternalMediaEntryCompareAttribute("rank");
		public static readonly KalturaExternalMediaEntryCompareAttribute REPLACEMENT_STATUS = new KalturaExternalMediaEntryCompareAttribute("replacementStatus");
		public static readonly KalturaExternalMediaEntryCompareAttribute START_DATE = new KalturaExternalMediaEntryCompareAttribute("startDate");
		public static readonly KalturaExternalMediaEntryCompareAttribute STATUS = new KalturaExternalMediaEntryCompareAttribute("status");
		public static readonly KalturaExternalMediaEntryCompareAttribute TOTAL_RANK = new KalturaExternalMediaEntryCompareAttribute("totalRank");
		public static readonly KalturaExternalMediaEntryCompareAttribute TYPE = new KalturaExternalMediaEntryCompareAttribute("type");
		public static readonly KalturaExternalMediaEntryCompareAttribute UPDATED_AT = new KalturaExternalMediaEntryCompareAttribute("updatedAt");
		public static readonly KalturaExternalMediaEntryCompareAttribute VIEWS = new KalturaExternalMediaEntryCompareAttribute("views");

		private KalturaExternalMediaEntryCompareAttribute(string name) : base(name) { }
	}
}
