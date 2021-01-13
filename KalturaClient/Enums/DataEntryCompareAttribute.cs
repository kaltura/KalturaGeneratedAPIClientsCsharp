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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class DataEntryCompareAttribute : StringEnum
	{
		public static readonly DataEntryCompareAttribute ACCESS_CONTROL_ID = new DataEntryCompareAttribute("accessControlId");
		public static readonly DataEntryCompareAttribute CREATED_AT = new DataEntryCompareAttribute("createdAt");
		public static readonly DataEntryCompareAttribute END_DATE = new DataEntryCompareAttribute("endDate");
		public static readonly DataEntryCompareAttribute MODERATION_COUNT = new DataEntryCompareAttribute("moderationCount");
		public static readonly DataEntryCompareAttribute MODERATION_STATUS = new DataEntryCompareAttribute("moderationStatus");
		public static readonly DataEntryCompareAttribute PARTNER_ID = new DataEntryCompareAttribute("partnerId");
		public static readonly DataEntryCompareAttribute PARTNER_SORT_VALUE = new DataEntryCompareAttribute("partnerSortValue");
		public static readonly DataEntryCompareAttribute RANK = new DataEntryCompareAttribute("rank");
		public static readonly DataEntryCompareAttribute REPLACEMENT_STATUS = new DataEntryCompareAttribute("replacementStatus");
		public static readonly DataEntryCompareAttribute START_DATE = new DataEntryCompareAttribute("startDate");
		public static readonly DataEntryCompareAttribute STATUS = new DataEntryCompareAttribute("status");
		public static readonly DataEntryCompareAttribute TOTAL_RANK = new DataEntryCompareAttribute("totalRank");
		public static readonly DataEntryCompareAttribute TYPE = new DataEntryCompareAttribute("type");
		public static readonly DataEntryCompareAttribute UPDATED_AT = new DataEntryCompareAttribute("updatedAt");

		private DataEntryCompareAttribute(string name) : base(name) { }
	}
}
