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
	public sealed class ExternalMediaEntryCompareAttribute : StringEnum
	{
		public static readonly ExternalMediaEntryCompareAttribute ACCESS_CONTROL_ID = new ExternalMediaEntryCompareAttribute("accessControlId");
		public static readonly ExternalMediaEntryCompareAttribute CREATED_AT = new ExternalMediaEntryCompareAttribute("createdAt");
		public static readonly ExternalMediaEntryCompareAttribute END_DATE = new ExternalMediaEntryCompareAttribute("endDate");
		public static readonly ExternalMediaEntryCompareAttribute LAST_PLAYED_AT = new ExternalMediaEntryCompareAttribute("lastPlayedAt");
		public static readonly ExternalMediaEntryCompareAttribute MEDIA_DATE = new ExternalMediaEntryCompareAttribute("mediaDate");
		public static readonly ExternalMediaEntryCompareAttribute MEDIA_TYPE = new ExternalMediaEntryCompareAttribute("mediaType");
		public static readonly ExternalMediaEntryCompareAttribute MODERATION_COUNT = new ExternalMediaEntryCompareAttribute("moderationCount");
		public static readonly ExternalMediaEntryCompareAttribute MODERATION_STATUS = new ExternalMediaEntryCompareAttribute("moderationStatus");
		public static readonly ExternalMediaEntryCompareAttribute MS_DURATION = new ExternalMediaEntryCompareAttribute("msDuration");
		public static readonly ExternalMediaEntryCompareAttribute PARTNER_ID = new ExternalMediaEntryCompareAttribute("partnerId");
		public static readonly ExternalMediaEntryCompareAttribute PARTNER_SORT_VALUE = new ExternalMediaEntryCompareAttribute("partnerSortValue");
		public static readonly ExternalMediaEntryCompareAttribute PLAYS = new ExternalMediaEntryCompareAttribute("plays");
		public static readonly ExternalMediaEntryCompareAttribute RANK = new ExternalMediaEntryCompareAttribute("rank");
		public static readonly ExternalMediaEntryCompareAttribute REPLACEMENT_STATUS = new ExternalMediaEntryCompareAttribute("replacementStatus");
		public static readonly ExternalMediaEntryCompareAttribute START_DATE = new ExternalMediaEntryCompareAttribute("startDate");
		public static readonly ExternalMediaEntryCompareAttribute STATUS = new ExternalMediaEntryCompareAttribute("status");
		public static readonly ExternalMediaEntryCompareAttribute TOTAL_RANK = new ExternalMediaEntryCompareAttribute("totalRank");
		public static readonly ExternalMediaEntryCompareAttribute TYPE = new ExternalMediaEntryCompareAttribute("type");
		public static readonly ExternalMediaEntryCompareAttribute UPDATED_AT = new ExternalMediaEntryCompareAttribute("updatedAt");
		public static readonly ExternalMediaEntryCompareAttribute VIEWS = new ExternalMediaEntryCompareAttribute("views");

		private ExternalMediaEntryCompareAttribute(string name) : base(name) { }
	}
}
