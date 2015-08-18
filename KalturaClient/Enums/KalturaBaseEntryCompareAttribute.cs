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
// Copyright (C) 2006-2015  Kaltura Inc.
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
namespace Kaltura
{
	public sealed class KalturaBaseEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaBaseEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaBaseEntryCompareAttribute("accessControlId");
		public static readonly KalturaBaseEntryCompareAttribute CREATED_AT = new KalturaBaseEntryCompareAttribute("createdAt");
		public static readonly KalturaBaseEntryCompareAttribute END_DATE = new KalturaBaseEntryCompareAttribute("endDate");
		public static readonly KalturaBaseEntryCompareAttribute MODERATION_COUNT = new KalturaBaseEntryCompareAttribute("moderationCount");
		public static readonly KalturaBaseEntryCompareAttribute MODERATION_STATUS = new KalturaBaseEntryCompareAttribute("moderationStatus");
		public static readonly KalturaBaseEntryCompareAttribute PARTNER_ID = new KalturaBaseEntryCompareAttribute("partnerId");
		public static readonly KalturaBaseEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaBaseEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaBaseEntryCompareAttribute RANK = new KalturaBaseEntryCompareAttribute("rank");
		public static readonly KalturaBaseEntryCompareAttribute REPLACEMENT_STATUS = new KalturaBaseEntryCompareAttribute("replacementStatus");
		public static readonly KalturaBaseEntryCompareAttribute START_DATE = new KalturaBaseEntryCompareAttribute("startDate");
		public static readonly KalturaBaseEntryCompareAttribute STATUS = new KalturaBaseEntryCompareAttribute("status");
		public static readonly KalturaBaseEntryCompareAttribute TOTAL_RANK = new KalturaBaseEntryCompareAttribute("totalRank");
		public static readonly KalturaBaseEntryCompareAttribute TYPE = new KalturaBaseEntryCompareAttribute("type");
		public static readonly KalturaBaseEntryCompareAttribute UPDATED_AT = new KalturaBaseEntryCompareAttribute("updatedAt");

		private KalturaBaseEntryCompareAttribute(string name) : base(name) { }
	}
}
