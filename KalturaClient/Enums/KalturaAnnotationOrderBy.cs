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
	public sealed class KalturaAnnotationOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAnnotationOrderBy CREATED_AT_ASC = new KalturaAnnotationOrderBy("+createdAt");
		public static readonly KalturaAnnotationOrderBy DURATION_ASC = new KalturaAnnotationOrderBy("+duration");
		public static readonly KalturaAnnotationOrderBy END_TIME_ASC = new KalturaAnnotationOrderBy("+endTime");
		public static readonly KalturaAnnotationOrderBy PARTNER_SORT_VALUE_ASC = new KalturaAnnotationOrderBy("+partnerSortValue");
		public static readonly KalturaAnnotationOrderBy START_TIME_ASC = new KalturaAnnotationOrderBy("+startTime");
		public static readonly KalturaAnnotationOrderBy TRIGGERED_AT_ASC = new KalturaAnnotationOrderBy("+triggeredAt");
		public static readonly KalturaAnnotationOrderBy UPDATED_AT_ASC = new KalturaAnnotationOrderBy("+updatedAt");
		public static readonly KalturaAnnotationOrderBy CREATED_AT_DESC = new KalturaAnnotationOrderBy("-createdAt");
		public static readonly KalturaAnnotationOrderBy DURATION_DESC = new KalturaAnnotationOrderBy("-duration");
		public static readonly KalturaAnnotationOrderBy END_TIME_DESC = new KalturaAnnotationOrderBy("-endTime");
		public static readonly KalturaAnnotationOrderBy PARTNER_SORT_VALUE_DESC = new KalturaAnnotationOrderBy("-partnerSortValue");
		public static readonly KalturaAnnotationOrderBy START_TIME_DESC = new KalturaAnnotationOrderBy("-startTime");
		public static readonly KalturaAnnotationOrderBy TRIGGERED_AT_DESC = new KalturaAnnotationOrderBy("-triggeredAt");
		public static readonly KalturaAnnotationOrderBy UPDATED_AT_DESC = new KalturaAnnotationOrderBy("-updatedAt");

		private KalturaAnnotationOrderBy(string name) : base(name) { }
	}
}
