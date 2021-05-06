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
	public sealed class DocumentEntryCompareAttribute : StringEnum
	{
		public static readonly DocumentEntryCompareAttribute ACCESS_CONTROL_ID = new DocumentEntryCompareAttribute("accessControlId");
		public static readonly DocumentEntryCompareAttribute CREATED_AT = new DocumentEntryCompareAttribute("createdAt");
		public static readonly DocumentEntryCompareAttribute END_DATE = new DocumentEntryCompareAttribute("endDate");
		public static readonly DocumentEntryCompareAttribute MODERATION_COUNT = new DocumentEntryCompareAttribute("moderationCount");
		public static readonly DocumentEntryCompareAttribute MODERATION_STATUS = new DocumentEntryCompareAttribute("moderationStatus");
		public static readonly DocumentEntryCompareAttribute PARTNER_ID = new DocumentEntryCompareAttribute("partnerId");
		public static readonly DocumentEntryCompareAttribute PARTNER_SORT_VALUE = new DocumentEntryCompareAttribute("partnerSortValue");
		public static readonly DocumentEntryCompareAttribute RANK = new DocumentEntryCompareAttribute("rank");
		public static readonly DocumentEntryCompareAttribute REPLACEMENT_STATUS = new DocumentEntryCompareAttribute("replacementStatus");
		public static readonly DocumentEntryCompareAttribute START_DATE = new DocumentEntryCompareAttribute("startDate");
		public static readonly DocumentEntryCompareAttribute STATUS = new DocumentEntryCompareAttribute("status");
		public static readonly DocumentEntryCompareAttribute TOTAL_RANK = new DocumentEntryCompareAttribute("totalRank");
		public static readonly DocumentEntryCompareAttribute TYPE = new DocumentEntryCompareAttribute("type");
		public static readonly DocumentEntryCompareAttribute UPDATED_AT = new DocumentEntryCompareAttribute("updatedAt");

		private DocumentEntryCompareAttribute(string name) : base(name) { }
	}
}
