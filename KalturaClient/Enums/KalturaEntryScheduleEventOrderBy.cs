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
	public sealed class KalturaEntryScheduleEventOrderBy : KalturaStringEnum
	{
		public static readonly KalturaEntryScheduleEventOrderBy CREATED_AT_ASC = new KalturaEntryScheduleEventOrderBy("+createdAt");
		public static readonly KalturaEntryScheduleEventOrderBy END_DATE_ASC = new KalturaEntryScheduleEventOrderBy("+endDate");
		public static readonly KalturaEntryScheduleEventOrderBy PRIORITY_ASC = new KalturaEntryScheduleEventOrderBy("+priority");
		public static readonly KalturaEntryScheduleEventOrderBy START_DATE_ASC = new KalturaEntryScheduleEventOrderBy("+startDate");
		public static readonly KalturaEntryScheduleEventOrderBy UPDATED_AT_ASC = new KalturaEntryScheduleEventOrderBy("+updatedAt");
		public static readonly KalturaEntryScheduleEventOrderBy CREATED_AT_DESC = new KalturaEntryScheduleEventOrderBy("-createdAt");
		public static readonly KalturaEntryScheduleEventOrderBy END_DATE_DESC = new KalturaEntryScheduleEventOrderBy("-endDate");
		public static readonly KalturaEntryScheduleEventOrderBy PRIORITY_DESC = new KalturaEntryScheduleEventOrderBy("-priority");
		public static readonly KalturaEntryScheduleEventOrderBy START_DATE_DESC = new KalturaEntryScheduleEventOrderBy("-startDate");
		public static readonly KalturaEntryScheduleEventOrderBy UPDATED_AT_DESC = new KalturaEntryScheduleEventOrderBy("-updatedAt");

		private KalturaEntryScheduleEventOrderBy(string name) : base(name) { }
	}
}
