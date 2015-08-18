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
	public sealed class KalturaDataEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaDataEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaDataEntryCompareAttribute("accessControlId");
		public static readonly KalturaDataEntryCompareAttribute CREATED_AT = new KalturaDataEntryCompareAttribute("createdAt");
		public static readonly KalturaDataEntryCompareAttribute END_DATE = new KalturaDataEntryCompareAttribute("endDate");
		public static readonly KalturaDataEntryCompareAttribute MODERATION_COUNT = new KalturaDataEntryCompareAttribute("moderationCount");
		public static readonly KalturaDataEntryCompareAttribute MODERATION_STATUS = new KalturaDataEntryCompareAttribute("moderationStatus");
		public static readonly KalturaDataEntryCompareAttribute PARTNER_ID = new KalturaDataEntryCompareAttribute("partnerId");
		public static readonly KalturaDataEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaDataEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaDataEntryCompareAttribute RANK = new KalturaDataEntryCompareAttribute("rank");
		public static readonly KalturaDataEntryCompareAttribute REPLACEMENT_STATUS = new KalturaDataEntryCompareAttribute("replacementStatus");
		public static readonly KalturaDataEntryCompareAttribute START_DATE = new KalturaDataEntryCompareAttribute("startDate");
		public static readonly KalturaDataEntryCompareAttribute STATUS = new KalturaDataEntryCompareAttribute("status");
		public static readonly KalturaDataEntryCompareAttribute TOTAL_RANK = new KalturaDataEntryCompareAttribute("totalRank");
		public static readonly KalturaDataEntryCompareAttribute TYPE = new KalturaDataEntryCompareAttribute("type");
		public static readonly KalturaDataEntryCompareAttribute UPDATED_AT = new KalturaDataEntryCompareAttribute("updatedAt");

		private KalturaDataEntryCompareAttribute(string name) : base(name) { }
	}
}
