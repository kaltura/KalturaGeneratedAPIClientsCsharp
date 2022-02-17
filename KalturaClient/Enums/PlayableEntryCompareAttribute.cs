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
	public sealed class PlayableEntryCompareAttribute : StringEnum
	{
		public static readonly PlayableEntryCompareAttribute ACCESS_CONTROL_ID = new PlayableEntryCompareAttribute("accessControlId");
		public static readonly PlayableEntryCompareAttribute CREATED_AT = new PlayableEntryCompareAttribute("createdAt");
		public static readonly PlayableEntryCompareAttribute END_DATE = new PlayableEntryCompareAttribute("endDate");
		public static readonly PlayableEntryCompareAttribute LAST_PLAYED_AT = new PlayableEntryCompareAttribute("lastPlayedAt");
		public static readonly PlayableEntryCompareAttribute MODERATION_COUNT = new PlayableEntryCompareAttribute("moderationCount");
		public static readonly PlayableEntryCompareAttribute MODERATION_STATUS = new PlayableEntryCompareAttribute("moderationStatus");
		public static readonly PlayableEntryCompareAttribute MS_DURATION = new PlayableEntryCompareAttribute("msDuration");
		public static readonly PlayableEntryCompareAttribute PARTNER_ID = new PlayableEntryCompareAttribute("partnerId");
		public static readonly PlayableEntryCompareAttribute PARTNER_SORT_VALUE = new PlayableEntryCompareAttribute("partnerSortValue");
		public static readonly PlayableEntryCompareAttribute PLAYS = new PlayableEntryCompareAttribute("plays");
		public static readonly PlayableEntryCompareAttribute RANK = new PlayableEntryCompareAttribute("rank");
		public static readonly PlayableEntryCompareAttribute REPLACEMENT_STATUS = new PlayableEntryCompareAttribute("replacementStatus");
		public static readonly PlayableEntryCompareAttribute START_DATE = new PlayableEntryCompareAttribute("startDate");
		public static readonly PlayableEntryCompareAttribute STATUS = new PlayableEntryCompareAttribute("status");
		public static readonly PlayableEntryCompareAttribute TOTAL_RANK = new PlayableEntryCompareAttribute("totalRank");
		public static readonly PlayableEntryCompareAttribute TYPE = new PlayableEntryCompareAttribute("type");
		public static readonly PlayableEntryCompareAttribute UPDATED_AT = new PlayableEntryCompareAttribute("updatedAt");
		public static readonly PlayableEntryCompareAttribute VIEWS = new PlayableEntryCompareAttribute("views");

		private PlayableEntryCompareAttribute(string name) : base(name) { }
	}
}
