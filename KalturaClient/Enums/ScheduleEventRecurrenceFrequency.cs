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
	public sealed class ScheduleEventRecurrenceFrequency : StringEnum
	{
		public static readonly ScheduleEventRecurrenceFrequency DAILY = new ScheduleEventRecurrenceFrequency("days");
		public static readonly ScheduleEventRecurrenceFrequency HOURLY = new ScheduleEventRecurrenceFrequency("hours");
		public static readonly ScheduleEventRecurrenceFrequency MINUTELY = new ScheduleEventRecurrenceFrequency("minutes");
		public static readonly ScheduleEventRecurrenceFrequency MONTHLY = new ScheduleEventRecurrenceFrequency("months");
		public static readonly ScheduleEventRecurrenceFrequency SECONDLY = new ScheduleEventRecurrenceFrequency("seconds");
		public static readonly ScheduleEventRecurrenceFrequency WEEKLY = new ScheduleEventRecurrenceFrequency("weeks");
		public static readonly ScheduleEventRecurrenceFrequency YEARLY = new ScheduleEventRecurrenceFrequency("years");

		private ScheduleEventRecurrenceFrequency(string name) : base(name) { }
	}
}
