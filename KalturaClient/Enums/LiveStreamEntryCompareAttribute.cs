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
	public sealed class LiveStreamEntryCompareAttribute : StringEnum
	{
		public static readonly LiveStreamEntryCompareAttribute ACCESS_CONTROL_ID = new LiveStreamEntryCompareAttribute("accessControlId");
		public static readonly LiveStreamEntryCompareAttribute CREATED_AT = new LiveStreamEntryCompareAttribute("createdAt");
		public static readonly LiveStreamEntryCompareAttribute END_DATE = new LiveStreamEntryCompareAttribute("endDate");
		public static readonly LiveStreamEntryCompareAttribute LAST_PLAYED_AT = new LiveStreamEntryCompareAttribute("lastPlayedAt");
		public static readonly LiveStreamEntryCompareAttribute MEDIA_DATE = new LiveStreamEntryCompareAttribute("mediaDate");
		public static readonly LiveStreamEntryCompareAttribute MEDIA_TYPE = new LiveStreamEntryCompareAttribute("mediaType");
		public static readonly LiveStreamEntryCompareAttribute MODERATION_COUNT = new LiveStreamEntryCompareAttribute("moderationCount");
		public static readonly LiveStreamEntryCompareAttribute MODERATION_STATUS = new LiveStreamEntryCompareAttribute("moderationStatus");
		public static readonly LiveStreamEntryCompareAttribute MS_DURATION = new LiveStreamEntryCompareAttribute("msDuration");
		public static readonly LiveStreamEntryCompareAttribute PARTNER_ID = new LiveStreamEntryCompareAttribute("partnerId");
		public static readonly LiveStreamEntryCompareAttribute PARTNER_SORT_VALUE = new LiveStreamEntryCompareAttribute("partnerSortValue");
		public static readonly LiveStreamEntryCompareAttribute PLAYS = new LiveStreamEntryCompareAttribute("plays");
		public static readonly LiveStreamEntryCompareAttribute RANK = new LiveStreamEntryCompareAttribute("rank");
		public static readonly LiveStreamEntryCompareAttribute REPLACEMENT_STATUS = new LiveStreamEntryCompareAttribute("replacementStatus");
		public static readonly LiveStreamEntryCompareAttribute START_DATE = new LiveStreamEntryCompareAttribute("startDate");
		public static readonly LiveStreamEntryCompareAttribute STATUS = new LiveStreamEntryCompareAttribute("status");
		public static readonly LiveStreamEntryCompareAttribute TOTAL_RANK = new LiveStreamEntryCompareAttribute("totalRank");
		public static readonly LiveStreamEntryCompareAttribute TYPE = new LiveStreamEntryCompareAttribute("type");
		public static readonly LiveStreamEntryCompareAttribute UPDATED_AT = new LiveStreamEntryCompareAttribute("updatedAt");
		public static readonly LiveStreamEntryCompareAttribute VIEWS = new LiveStreamEntryCompareAttribute("views");

		private LiveStreamEntryCompareAttribute(string name) : base(name) { }
	}
}
