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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class AnnotationOrderBy : StringEnum
	{
		public static readonly AnnotationOrderBy CREATED_AT_ASC = new AnnotationOrderBy("+createdAt");
		public static readonly AnnotationOrderBy DURATION_ASC = new AnnotationOrderBy("+duration");
		public static readonly AnnotationOrderBy END_TIME_ASC = new AnnotationOrderBy("+endTime");
		public static readonly AnnotationOrderBy INT_ID_ASC = new AnnotationOrderBy("+intId");
		public static readonly AnnotationOrderBy PARTNER_SORT_VALUE_ASC = new AnnotationOrderBy("+partnerSortValue");
		public static readonly AnnotationOrderBy START_TIME_ASC = new AnnotationOrderBy("+startTime");
		public static readonly AnnotationOrderBy TRIGGERED_AT_ASC = new AnnotationOrderBy("+triggeredAt");
		public static readonly AnnotationOrderBy UPDATED_AT_ASC = new AnnotationOrderBy("+updatedAt");
		public static readonly AnnotationOrderBy CREATED_AT_DESC = new AnnotationOrderBy("-createdAt");
		public static readonly AnnotationOrderBy DURATION_DESC = new AnnotationOrderBy("-duration");
		public static readonly AnnotationOrderBy END_TIME_DESC = new AnnotationOrderBy("-endTime");
		public static readonly AnnotationOrderBy INT_ID_DESC = new AnnotationOrderBy("-intId");
		public static readonly AnnotationOrderBy PARTNER_SORT_VALUE_DESC = new AnnotationOrderBy("-partnerSortValue");
		public static readonly AnnotationOrderBy START_TIME_DESC = new AnnotationOrderBy("-startTime");
		public static readonly AnnotationOrderBy TRIGGERED_AT_DESC = new AnnotationOrderBy("-triggeredAt");
		public static readonly AnnotationOrderBy UPDATED_AT_DESC = new AnnotationOrderBy("-updatedAt");

		private AnnotationOrderBy(string name) : base(name) { }
	}
}
