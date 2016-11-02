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
	public sealed class KalturaScheduleEventOrderBy : KalturaStringEnum
	{
		public static readonly KalturaScheduleEventOrderBy CREATED_AT_ASC = new KalturaScheduleEventOrderBy("+createdAt");
		public static readonly KalturaScheduleEventOrderBy END_DATE_ASC = new KalturaScheduleEventOrderBy("+endDate");
		public static readonly KalturaScheduleEventOrderBy PRIORITY_ASC = new KalturaScheduleEventOrderBy("+priority");
		public static readonly KalturaScheduleEventOrderBy START_DATE_ASC = new KalturaScheduleEventOrderBy("+startDate");
		public static readonly KalturaScheduleEventOrderBy SUMMARY_ASC = new KalturaScheduleEventOrderBy("+summary");
		public static readonly KalturaScheduleEventOrderBy UPDATED_AT_ASC = new KalturaScheduleEventOrderBy("+updatedAt");
		public static readonly KalturaScheduleEventOrderBy CREATED_AT_DESC = new KalturaScheduleEventOrderBy("-createdAt");
		public static readonly KalturaScheduleEventOrderBy END_DATE_DESC = new KalturaScheduleEventOrderBy("-endDate");
		public static readonly KalturaScheduleEventOrderBy PRIORITY_DESC = new KalturaScheduleEventOrderBy("-priority");
		public static readonly KalturaScheduleEventOrderBy START_DATE_DESC = new KalturaScheduleEventOrderBy("-startDate");
		public static readonly KalturaScheduleEventOrderBy SUMMARY_DESC = new KalturaScheduleEventOrderBy("-summary");
		public static readonly KalturaScheduleEventOrderBy UPDATED_AT_DESC = new KalturaScheduleEventOrderBy("-updatedAt");

		private KalturaScheduleEventOrderBy(string name) : base(name) { }
	}
}
