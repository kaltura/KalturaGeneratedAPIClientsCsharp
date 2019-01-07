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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class LiveEntryCompareAttribute : StringEnum
	{
		public static readonly LiveEntryCompareAttribute ACCESS_CONTROL_ID = new LiveEntryCompareAttribute("accessControlId");
		public static readonly LiveEntryCompareAttribute CREATED_AT = new LiveEntryCompareAttribute("createdAt");
		public static readonly LiveEntryCompareAttribute END_DATE = new LiveEntryCompareAttribute("endDate");
		public static readonly LiveEntryCompareAttribute LAST_PLAYED_AT = new LiveEntryCompareAttribute("lastPlayedAt");
		public static readonly LiveEntryCompareAttribute MEDIA_DATE = new LiveEntryCompareAttribute("mediaDate");
		public static readonly LiveEntryCompareAttribute MEDIA_TYPE = new LiveEntryCompareAttribute("mediaType");
		public static readonly LiveEntryCompareAttribute MODERATION_COUNT = new LiveEntryCompareAttribute("moderationCount");
		public static readonly LiveEntryCompareAttribute MODERATION_STATUS = new LiveEntryCompareAttribute("moderationStatus");
		public static readonly LiveEntryCompareAttribute MS_DURATION = new LiveEntryCompareAttribute("msDuration");
		public static readonly LiveEntryCompareAttribute PARTNER_ID = new LiveEntryCompareAttribute("partnerId");
		public static readonly LiveEntryCompareAttribute PARTNER_SORT_VALUE = new LiveEntryCompareAttribute("partnerSortValue");
		public static readonly LiveEntryCompareAttribute PLAYS = new LiveEntryCompareAttribute("plays");
		public static readonly LiveEntryCompareAttribute RANK = new LiveEntryCompareAttribute("rank");
		public static readonly LiveEntryCompareAttribute REPLACEMENT_STATUS = new LiveEntryCompareAttribute("replacementStatus");
		public static readonly LiveEntryCompareAttribute START_DATE = new LiveEntryCompareAttribute("startDate");
		public static readonly LiveEntryCompareAttribute STATUS = new LiveEntryCompareAttribute("status");
		public static readonly LiveEntryCompareAttribute TOTAL_RANK = new LiveEntryCompareAttribute("totalRank");
		public static readonly LiveEntryCompareAttribute TYPE = new LiveEntryCompareAttribute("type");
		public static readonly LiveEntryCompareAttribute UPDATED_AT = new LiveEntryCompareAttribute("updatedAt");
		public static readonly LiveEntryCompareAttribute VIEWS = new LiveEntryCompareAttribute("views");

		private LiveEntryCompareAttribute(string name) : base(name) { }
	}
}
