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
	public sealed class KalturaDocumentEntryCompareAttribute : KalturaStringEnum
	{
		public static readonly KalturaDocumentEntryCompareAttribute ACCESS_CONTROL_ID = new KalturaDocumentEntryCompareAttribute("accessControlId");
		public static readonly KalturaDocumentEntryCompareAttribute CREATED_AT = new KalturaDocumentEntryCompareAttribute("createdAt");
		public static readonly KalturaDocumentEntryCompareAttribute END_DATE = new KalturaDocumentEntryCompareAttribute("endDate");
		public static readonly KalturaDocumentEntryCompareAttribute MODERATION_COUNT = new KalturaDocumentEntryCompareAttribute("moderationCount");
		public static readonly KalturaDocumentEntryCompareAttribute MODERATION_STATUS = new KalturaDocumentEntryCompareAttribute("moderationStatus");
		public static readonly KalturaDocumentEntryCompareAttribute PARTNER_ID = new KalturaDocumentEntryCompareAttribute("partnerId");
		public static readonly KalturaDocumentEntryCompareAttribute PARTNER_SORT_VALUE = new KalturaDocumentEntryCompareAttribute("partnerSortValue");
		public static readonly KalturaDocumentEntryCompareAttribute RANK = new KalturaDocumentEntryCompareAttribute("rank");
		public static readonly KalturaDocumentEntryCompareAttribute REPLACEMENT_STATUS = new KalturaDocumentEntryCompareAttribute("replacementStatus");
		public static readonly KalturaDocumentEntryCompareAttribute START_DATE = new KalturaDocumentEntryCompareAttribute("startDate");
		public static readonly KalturaDocumentEntryCompareAttribute STATUS = new KalturaDocumentEntryCompareAttribute("status");
		public static readonly KalturaDocumentEntryCompareAttribute TOTAL_RANK = new KalturaDocumentEntryCompareAttribute("totalRank");
		public static readonly KalturaDocumentEntryCompareAttribute TYPE = new KalturaDocumentEntryCompareAttribute("type");
		public static readonly KalturaDocumentEntryCompareAttribute UPDATED_AT = new KalturaDocumentEntryCompareAttribute("updatedAt");

		private KalturaDocumentEntryCompareAttribute(string name) : base(name) { }
	}
}
