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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class RecordScheduleEventOrderBy : StringEnum
	{
		public static readonly RecordScheduleEventOrderBy CREATED_AT_ASC = new RecordScheduleEventOrderBy("+createdAt");
		public static readonly RecordScheduleEventOrderBy END_DATE_ASC = new RecordScheduleEventOrderBy("+endDate");
		public static readonly RecordScheduleEventOrderBy PRIORITY_ASC = new RecordScheduleEventOrderBy("+priority");
		public static readonly RecordScheduleEventOrderBy START_DATE_ASC = new RecordScheduleEventOrderBy("+startDate");
		public static readonly RecordScheduleEventOrderBy SUMMARY_ASC = new RecordScheduleEventOrderBy("+summary");
		public static readonly RecordScheduleEventOrderBy UPDATED_AT_ASC = new RecordScheduleEventOrderBy("+updatedAt");
		public static readonly RecordScheduleEventOrderBy CREATED_AT_DESC = new RecordScheduleEventOrderBy("-createdAt");
		public static readonly RecordScheduleEventOrderBy END_DATE_DESC = new RecordScheduleEventOrderBy("-endDate");
		public static readonly RecordScheduleEventOrderBy PRIORITY_DESC = new RecordScheduleEventOrderBy("-priority");
		public static readonly RecordScheduleEventOrderBy START_DATE_DESC = new RecordScheduleEventOrderBy("-startDate");
		public static readonly RecordScheduleEventOrderBy SUMMARY_DESC = new RecordScheduleEventOrderBy("-summary");
		public static readonly RecordScheduleEventOrderBy UPDATED_AT_DESC = new RecordScheduleEventOrderBy("-updatedAt");

		private RecordScheduleEventOrderBy(string name) : base(name) { }
	}
}
