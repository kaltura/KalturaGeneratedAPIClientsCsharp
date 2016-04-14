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
	public sealed class KalturaScheduleEventRecurrenceFrequency : KalturaStringEnum
	{
		public static readonly KalturaScheduleEventRecurrenceFrequency DAILY = new KalturaScheduleEventRecurrenceFrequency("days");
		public static readonly KalturaScheduleEventRecurrenceFrequency HOURLY = new KalturaScheduleEventRecurrenceFrequency("hours");
		public static readonly KalturaScheduleEventRecurrenceFrequency MINUTELY = new KalturaScheduleEventRecurrenceFrequency("minutes");
		public static readonly KalturaScheduleEventRecurrenceFrequency MONTHLY = new KalturaScheduleEventRecurrenceFrequency("months");
		public static readonly KalturaScheduleEventRecurrenceFrequency SECONDLY = new KalturaScheduleEventRecurrenceFrequency("seconds");
		public static readonly KalturaScheduleEventRecurrenceFrequency WEEKLY = new KalturaScheduleEventRecurrenceFrequency("weeks");
		public static readonly KalturaScheduleEventRecurrenceFrequency YEARLY = new KalturaScheduleEventRecurrenceFrequency("years");

		private KalturaScheduleEventRecurrenceFrequency(string name) : base(name) { }
	}
}
