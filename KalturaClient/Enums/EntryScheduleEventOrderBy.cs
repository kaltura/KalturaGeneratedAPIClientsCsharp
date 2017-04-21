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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class EntryScheduleEventOrderBy : StringEnum
	{
		public static readonly EntryScheduleEventOrderBy CREATED_AT_ASC = new EntryScheduleEventOrderBy("+createdAt");
		public static readonly EntryScheduleEventOrderBy END_DATE_ASC = new EntryScheduleEventOrderBy("+endDate");
		public static readonly EntryScheduleEventOrderBy PRIORITY_ASC = new EntryScheduleEventOrderBy("+priority");
		public static readonly EntryScheduleEventOrderBy START_DATE_ASC = new EntryScheduleEventOrderBy("+startDate");
		public static readonly EntryScheduleEventOrderBy SUMMARY_ASC = new EntryScheduleEventOrderBy("+summary");
		public static readonly EntryScheduleEventOrderBy UPDATED_AT_ASC = new EntryScheduleEventOrderBy("+updatedAt");
		public static readonly EntryScheduleEventOrderBy CREATED_AT_DESC = new EntryScheduleEventOrderBy("-createdAt");
		public static readonly EntryScheduleEventOrderBy END_DATE_DESC = new EntryScheduleEventOrderBy("-endDate");
		public static readonly EntryScheduleEventOrderBy PRIORITY_DESC = new EntryScheduleEventOrderBy("-priority");
		public static readonly EntryScheduleEventOrderBy START_DATE_DESC = new EntryScheduleEventOrderBy("-startDate");
		public static readonly EntryScheduleEventOrderBy SUMMARY_DESC = new EntryScheduleEventOrderBy("-summary");
		public static readonly EntryScheduleEventOrderBy UPDATED_AT_DESC = new EntryScheduleEventOrderBy("-updatedAt");

		private EntryScheduleEventOrderBy(string name) : base(name) { }
	}
}
