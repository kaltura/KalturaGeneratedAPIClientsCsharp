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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaDocumentEntryOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDocumentEntryOrderBy CREATED_AT_ASC = new KalturaDocumentEntryOrderBy("+createdAt");
		public static readonly KalturaDocumentEntryOrderBy END_DATE_ASC = new KalturaDocumentEntryOrderBy("+endDate");
		public static readonly KalturaDocumentEntryOrderBy MODERATION_COUNT_ASC = new KalturaDocumentEntryOrderBy("+moderationCount");
		public static readonly KalturaDocumentEntryOrderBy NAME_ASC = new KalturaDocumentEntryOrderBy("+name");
		public static readonly KalturaDocumentEntryOrderBy PARTNER_SORT_VALUE_ASC = new KalturaDocumentEntryOrderBy("+partnerSortValue");
		public static readonly KalturaDocumentEntryOrderBy RANK_ASC = new KalturaDocumentEntryOrderBy("+rank");
		public static readonly KalturaDocumentEntryOrderBy RECENT_ASC = new KalturaDocumentEntryOrderBy("+recent");
		public static readonly KalturaDocumentEntryOrderBy START_DATE_ASC = new KalturaDocumentEntryOrderBy("+startDate");
		public static readonly KalturaDocumentEntryOrderBy TOTAL_RANK_ASC = new KalturaDocumentEntryOrderBy("+totalRank");
		public static readonly KalturaDocumentEntryOrderBy UPDATED_AT_ASC = new KalturaDocumentEntryOrderBy("+updatedAt");
		public static readonly KalturaDocumentEntryOrderBy WEIGHT_ASC = new KalturaDocumentEntryOrderBy("+weight");
		public static readonly KalturaDocumentEntryOrderBy CREATED_AT_DESC = new KalturaDocumentEntryOrderBy("-createdAt");
		public static readonly KalturaDocumentEntryOrderBy END_DATE_DESC = new KalturaDocumentEntryOrderBy("-endDate");
		public static readonly KalturaDocumentEntryOrderBy MODERATION_COUNT_DESC = new KalturaDocumentEntryOrderBy("-moderationCount");
		public static readonly KalturaDocumentEntryOrderBy NAME_DESC = new KalturaDocumentEntryOrderBy("-name");
		public static readonly KalturaDocumentEntryOrderBy PARTNER_SORT_VALUE_DESC = new KalturaDocumentEntryOrderBy("-partnerSortValue");
		public static readonly KalturaDocumentEntryOrderBy RANK_DESC = new KalturaDocumentEntryOrderBy("-rank");
		public static readonly KalturaDocumentEntryOrderBy RECENT_DESC = new KalturaDocumentEntryOrderBy("-recent");
		public static readonly KalturaDocumentEntryOrderBy START_DATE_DESC = new KalturaDocumentEntryOrderBy("-startDate");
		public static readonly KalturaDocumentEntryOrderBy TOTAL_RANK_DESC = new KalturaDocumentEntryOrderBy("-totalRank");
		public static readonly KalturaDocumentEntryOrderBy UPDATED_AT_DESC = new KalturaDocumentEntryOrderBy("-updatedAt");
		public static readonly KalturaDocumentEntryOrderBy WEIGHT_DESC = new KalturaDocumentEntryOrderBy("-weight");

		private KalturaDocumentEntryOrderBy(string name) : base(name) { }
	}
}
