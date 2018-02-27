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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class MediaEntryCompareAttribute : StringEnum
	{
		public static readonly MediaEntryCompareAttribute ACCESS_CONTROL_ID = new MediaEntryCompareAttribute("accessControlId");
		public static readonly MediaEntryCompareAttribute CREATED_AT = new MediaEntryCompareAttribute("createdAt");
		public static readonly MediaEntryCompareAttribute END_DATE = new MediaEntryCompareAttribute("endDate");
		public static readonly MediaEntryCompareAttribute LAST_PLAYED_AT = new MediaEntryCompareAttribute("lastPlayedAt");
		public static readonly MediaEntryCompareAttribute MEDIA_DATE = new MediaEntryCompareAttribute("mediaDate");
		public static readonly MediaEntryCompareAttribute MEDIA_TYPE = new MediaEntryCompareAttribute("mediaType");
		public static readonly MediaEntryCompareAttribute MODERATION_COUNT = new MediaEntryCompareAttribute("moderationCount");
		public static readonly MediaEntryCompareAttribute MODERATION_STATUS = new MediaEntryCompareAttribute("moderationStatus");
		public static readonly MediaEntryCompareAttribute MS_DURATION = new MediaEntryCompareAttribute("msDuration");
		public static readonly MediaEntryCompareAttribute PARTNER_ID = new MediaEntryCompareAttribute("partnerId");
		public static readonly MediaEntryCompareAttribute PARTNER_SORT_VALUE = new MediaEntryCompareAttribute("partnerSortValue");
		public static readonly MediaEntryCompareAttribute PLAYS = new MediaEntryCompareAttribute("plays");
		public static readonly MediaEntryCompareAttribute RANK = new MediaEntryCompareAttribute("rank");
		public static readonly MediaEntryCompareAttribute REPLACEMENT_STATUS = new MediaEntryCompareAttribute("replacementStatus");
		public static readonly MediaEntryCompareAttribute START_DATE = new MediaEntryCompareAttribute("startDate");
		public static readonly MediaEntryCompareAttribute STATUS = new MediaEntryCompareAttribute("status");
		public static readonly MediaEntryCompareAttribute TOTAL_RANK = new MediaEntryCompareAttribute("totalRank");
		public static readonly MediaEntryCompareAttribute TYPE = new MediaEntryCompareAttribute("type");
		public static readonly MediaEntryCompareAttribute UPDATED_AT = new MediaEntryCompareAttribute("updatedAt");
		public static readonly MediaEntryCompareAttribute VIEWS = new MediaEntryCompareAttribute("views");

		private MediaEntryCompareAttribute(string name) : base(name) { }
	}
}
