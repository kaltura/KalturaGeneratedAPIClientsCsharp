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
	public sealed class KalturaPlayableEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaPlayableEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaPlayableEntryCompareAttribute("accessControlId");
		public static readonly KalturaPlayableEntryCompareAttribute CREATED_AT = new KalturaPlayableEntryCompareAttribute("createdAt");
		public static readonly KalturaPlayableEntryCompareAttribute END_DATE = new KalturaPlayableEntryCompareAttribute("endDate");
		public static readonly KalturaPlayableEntryCompareAttribute LAST_PLAYED_AT = new KalturaPlayableEntryCompareAttribute("lastPlayedAt");
		public static readonly KalturaPlayableEntryCompareAttribute MODERATION_COUNT = new KalturaPlayableEntryCompareAttribute("moderationCount");
		public static readonly KalturaPlayableEntryCompareAttribute MODERATION_STATUS = new KalturaPlayableEntryCompareAttribute("moderationStatus");
		public static readonly KalturaPlayableEntryCompareAttribute MS_DURATION = new KalturaPlayableEntryCompareAttribute("msDuration");
		public static readonly KalturaPlayableEntryCompareAttribute PARTNER_ID = new KalturaPlayableEntryCompareAttribute("partnerId");
		public static readonly KalturaPlayableEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaPlayableEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaPlayableEntryCompareAttribute PLAYS = new KalturaPlayableEntryCompareAttribute("plays");
		public static readonly KalturaPlayableEntryCompareAttribute RANK = new KalturaPlayableEntryCompareAttribute("rank");
		public static readonly KalturaPlayableEntryCompareAttribute REPLACEMENT_STATUS = new KalturaPlayableEntryCompareAttribute("replacementStatus");
		public static readonly KalturaPlayableEntryCompareAttribute START_DATE = new KalturaPlayableEntryCompareAttribute("startDate");
		public static readonly KalturaPlayableEntryCompareAttribute STATUS = new KalturaPlayableEntryCompareAttribute("status");
		public static readonly KalturaPlayableEntryCompareAttribute TOTAL_RANK = new KalturaPlayableEntryCompareAttribute("totalRank");
		public static readonly KalturaPlayableEntryCompareAttribute TYPE = new KalturaPlayableEntryCompareAttribute("type");
		public static readonly KalturaPlayableEntryCompareAttribute UPDATED_AT = new KalturaPlayableEntryCompareAttribute("updatedAt");
		public static readonly KalturaPlayableEntryCompareAttribute VIEWS = new KalturaPlayableEntryCompareAttribute("views");

		private KalturaPlayableEntryCompareAttribute(string name) : base(name) { }
	}
}
