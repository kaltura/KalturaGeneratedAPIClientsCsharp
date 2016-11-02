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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public sealed class KalturaRecordScheduleEventOrderBy : KalturaStringEnum
	{
		public static readonly KalturaRecordScheduleEventOrderBy CREATED_AT_ASC = new KalturaRecordScheduleEventOrderBy("+createdAt");
		public static readonly KalturaRecordScheduleEventOrderBy END_DATE_ASC = new KalturaRecordScheduleEventOrderBy("+endDate");
		public static readonly KalturaRecordScheduleEventOrderBy PRIORITY_ASC = new KalturaRecordScheduleEventOrderBy("+priority");
		public static readonly KalturaRecordScheduleEventOrderBy START_DATE_ASC = new KalturaRecordScheduleEventOrderBy("+startDate");
		public static readonly KalturaRecordScheduleEventOrderBy SUMMARY_ASC = new KalturaRecordScheduleEventOrderBy("+summary");
		public static readonly KalturaRecordScheduleEventOrderBy UPDATED_AT_ASC = new KalturaRecordScheduleEventOrderBy("+updatedAt");
		public static readonly KalturaRecordScheduleEventOrderBy CREATED_AT_DESC = new KalturaRecordScheduleEventOrderBy("-createdAt");
		public static readonly KalturaRecordScheduleEventOrderBy END_DATE_DESC = new KalturaRecordScheduleEventOrderBy("-endDate");
		public static readonly KalturaRecordScheduleEventOrderBy PRIORITY_DESC = new KalturaRecordScheduleEventOrderBy("-priority");
		public static readonly KalturaRecordScheduleEventOrderBy START_DATE_DESC = new KalturaRecordScheduleEventOrderBy("-startDate");
		public static readonly KalturaRecordScheduleEventOrderBy SUMMARY_DESC = new KalturaRecordScheduleEventOrderBy("-summary");
		public static readonly KalturaRecordScheduleEventOrderBy UPDATED_AT_DESC = new KalturaRecordScheduleEventOrderBy("-updatedAt");

		private KalturaRecordScheduleEventOrderBy(string name) : base(name) { }
	}
}
