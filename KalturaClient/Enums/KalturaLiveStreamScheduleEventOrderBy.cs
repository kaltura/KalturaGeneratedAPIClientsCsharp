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
	public sealed class KalturaLiveStreamScheduleEventOrderBy : KalturaStringEnum
	{
		public static readonly KalturaLiveStreamScheduleEventOrderBy CREATED_AT_ASC = new KalturaLiveStreamScheduleEventOrderBy("+createdAt");
		public static readonly KalturaLiveStreamScheduleEventOrderBy END_DATE_ASC = new KalturaLiveStreamScheduleEventOrderBy("+endDate");
		public static readonly KalturaLiveStreamScheduleEventOrderBy PRIORITY_ASC = new KalturaLiveStreamScheduleEventOrderBy("+priority");
		public static readonly KalturaLiveStreamScheduleEventOrderBy START_DATE_ASC = new KalturaLiveStreamScheduleEventOrderBy("+startDate");
		public static readonly KalturaLiveStreamScheduleEventOrderBy SUMMARY_ASC = new KalturaLiveStreamScheduleEventOrderBy("+summary");
		public static readonly KalturaLiveStreamScheduleEventOrderBy UPDATED_AT_ASC = new KalturaLiveStreamScheduleEventOrderBy("+updatedAt");
		public static readonly KalturaLiveStreamScheduleEventOrderBy CREATED_AT_DESC = new KalturaLiveStreamScheduleEventOrderBy("-createdAt");
		public static readonly KalturaLiveStreamScheduleEventOrderBy END_DATE_DESC = new KalturaLiveStreamScheduleEventOrderBy("-endDate");
		public static readonly KalturaLiveStreamScheduleEventOrderBy PRIORITY_DESC = new KalturaLiveStreamScheduleEventOrderBy("-priority");
		public static readonly KalturaLiveStreamScheduleEventOrderBy START_DATE_DESC = new KalturaLiveStreamScheduleEventOrderBy("-startDate");
		public static readonly KalturaLiveStreamScheduleEventOrderBy SUMMARY_DESC = new KalturaLiveStreamScheduleEventOrderBy("-summary");
		public static readonly KalturaLiveStreamScheduleEventOrderBy UPDATED_AT_DESC = new KalturaLiveStreamScheduleEventOrderBy("-updatedAt");

		private KalturaLiveStreamScheduleEventOrderBy(string name) : base(name) { }
	}
}
