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
	public sealed class BaseEntryCompareAttribute : StringEnum
	{
		public static readonly BaseEntryCompareAttribute ACCESS_CONTROL_ID = new BaseEntryCompareAttribute("accessControlId");
		public static readonly BaseEntryCompareAttribute CREATED_AT = new BaseEntryCompareAttribute("createdAt");
		public static readonly BaseEntryCompareAttribute END_DATE = new BaseEntryCompareAttribute("endDate");
		public static readonly BaseEntryCompareAttribute MODERATION_COUNT = new BaseEntryCompareAttribute("moderationCount");
		public static readonly BaseEntryCompareAttribute MODERATION_STATUS = new BaseEntryCompareAttribute("moderationStatus");
		public static readonly BaseEntryCompareAttribute PARTNER_ID = new BaseEntryCompareAttribute("partnerId");
		public static readonly BaseEntryCompareAttribute PARTNER_SORT_VALUE = new BaseEntryCompareAttribute("partnerSortValue");
		public static readonly BaseEntryCompareAttribute RANK = new BaseEntryCompareAttribute("rank");
		public static readonly BaseEntryCompareAttribute REPLACEMENT_STATUS = new BaseEntryCompareAttribute("replacementStatus");
		public static readonly BaseEntryCompareAttribute START_DATE = new BaseEntryCompareAttribute("startDate");
		public static readonly BaseEntryCompareAttribute STATUS = new BaseEntryCompareAttribute("status");
		public static readonly BaseEntryCompareAttribute TOTAL_RANK = new BaseEntryCompareAttribute("totalRank");
		public static readonly BaseEntryCompareAttribute TYPE = new BaseEntryCompareAttribute("type");
		public static readonly BaseEntryCompareAttribute UPDATED_AT = new BaseEntryCompareAttribute("updatedAt");

		private BaseEntryCompareAttribute(string name) : base(name) { }
	}
}
