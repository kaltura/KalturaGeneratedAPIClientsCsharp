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
namespace Kaltura.Enums
{
	public sealed class LiveStreamAdminEntryCompareAttribute : StringEnum
	{
		public static readonly LiveStreamAdminEntryCompareAttribute ACCESS_CONTROL_ID = new LiveStreamAdminEntryCompareAttribute("accessControlId");
		public static readonly LiveStreamAdminEntryCompareAttribute CREATED_AT = new LiveStreamAdminEntryCompareAttribute("createdAt");
		public static readonly LiveStreamAdminEntryCompareAttribute END_DATE = new LiveStreamAdminEntryCompareAttribute("endDate");
		public static readonly LiveStreamAdminEntryCompareAttribute LAST_PLAYED_AT = new LiveStreamAdminEntryCompareAttribute("lastPlayedAt");
		public static readonly LiveStreamAdminEntryCompareAttribute MEDIA_DATE = new LiveStreamAdminEntryCompareAttribute("mediaDate");
		public static readonly LiveStreamAdminEntryCompareAttribute MEDIA_TYPE = new LiveStreamAdminEntryCompareAttribute("mediaType");
		public static readonly LiveStreamAdminEntryCompareAttribute MODERATION_COUNT = new LiveStreamAdminEntryCompareAttribute("moderationCount");
		public static readonly LiveStreamAdminEntryCompareAttribute MODERATION_STATUS = new LiveStreamAdminEntryCompareAttribute("moderationStatus");
		public static readonly LiveStreamAdminEntryCompareAttribute MS_DURATION = new LiveStreamAdminEntryCompareAttribute("msDuration");
		public static readonly LiveStreamAdminEntryCompareAttribute PARTNER_ID = new LiveStreamAdminEntryCompareAttribute("partnerId");
		public static readonly LiveStreamAdminEntryCompareAttribute PARTNER_SORT_VALUE = new LiveStreamAdminEntryCompareAttribute("partnerSortValue");
		public static readonly LiveStreamAdminEntryCompareAttribute PLAYS = new LiveStreamAdminEntryCompareAttribute("plays");
		public static readonly LiveStreamAdminEntryCompareAttribute RANK = new LiveStreamAdminEntryCompareAttribute("rank");
		public static readonly LiveStreamAdminEntryCompareAttribute REPLACEMENT_STATUS = new LiveStreamAdminEntryCompareAttribute("replacementStatus");
		public static readonly LiveStreamAdminEntryCompareAttribute START_DATE = new LiveStreamAdminEntryCompareAttribute("startDate");
		public static readonly LiveStreamAdminEntryCompareAttribute STATUS = new LiveStreamAdminEntryCompareAttribute("status");
		public static readonly LiveStreamAdminEntryCompareAttribute TOTAL_RANK = new LiveStreamAdminEntryCompareAttribute("totalRank");
		public static readonly LiveStreamAdminEntryCompareAttribute TYPE = new LiveStreamAdminEntryCompareAttribute("type");
		public static readonly LiveStreamAdminEntryCompareAttribute UPDATED_AT = new LiveStreamAdminEntryCompareAttribute("updatedAt");
		public static readonly LiveStreamAdminEntryCompareAttribute VIEWS = new LiveStreamAdminEntryCompareAttribute("views");

		private LiveStreamAdminEntryCompareAttribute(string name) : base(name) { }
	}
}
