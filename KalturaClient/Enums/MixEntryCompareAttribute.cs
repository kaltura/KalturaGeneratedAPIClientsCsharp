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
	public sealed class MixEntryCompareAttribute : StringEnum
	{
		public static readonly MixEntryCompareAttribute ACCESS_CONTROL_ID = new MixEntryCompareAttribute("accessControlId");
		public static readonly MixEntryCompareAttribute CREATED_AT = new MixEntryCompareAttribute("createdAt");
		public static readonly MixEntryCompareAttribute END_DATE = new MixEntryCompareAttribute("endDate");
		public static readonly MixEntryCompareAttribute LAST_PLAYED_AT = new MixEntryCompareAttribute("lastPlayedAt");
		public static readonly MixEntryCompareAttribute MODERATION_COUNT = new MixEntryCompareAttribute("moderationCount");
		public static readonly MixEntryCompareAttribute MODERATION_STATUS = new MixEntryCompareAttribute("moderationStatus");
		public static readonly MixEntryCompareAttribute MS_DURATION = new MixEntryCompareAttribute("msDuration");
		public static readonly MixEntryCompareAttribute PARTNER_ID = new MixEntryCompareAttribute("partnerId");
		public static readonly MixEntryCompareAttribute PARTNER_SORT_VALUE = new MixEntryCompareAttribute("partnerSortValue");
		public static readonly MixEntryCompareAttribute PLAYS = new MixEntryCompareAttribute("plays");
		public static readonly MixEntryCompareAttribute RANK = new MixEntryCompareAttribute("rank");
		public static readonly MixEntryCompareAttribute REPLACEMENT_STATUS = new MixEntryCompareAttribute("replacementStatus");
		public static readonly MixEntryCompareAttribute START_DATE = new MixEntryCompareAttribute("startDate");
		public static readonly MixEntryCompareAttribute STATUS = new MixEntryCompareAttribute("status");
		public static readonly MixEntryCompareAttribute TOTAL_RANK = new MixEntryCompareAttribute("totalRank");
		public static readonly MixEntryCompareAttribute TYPE = new MixEntryCompareAttribute("type");
		public static readonly MixEntryCompareAttribute UPDATED_AT = new MixEntryCompareAttribute("updatedAt");
		public static readonly MixEntryCompareAttribute VIEWS = new MixEntryCompareAttribute("views");

		private MixEntryCompareAttribute(string name) : base(name) { }
	}
}
