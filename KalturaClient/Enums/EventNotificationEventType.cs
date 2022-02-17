// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class EventNotificationEventType : StringEnum
	{
		public static readonly EventNotificationEventType INTEGRATION_JOB_CLOSED = new EventNotificationEventType("integrationEventNotifications.INTEGRATION_JOB_CLOSED");
		public static readonly EventNotificationEventType BATCH_JOB_STATUS = new EventNotificationEventType("1");
		public static readonly EventNotificationEventType OBJECT_ADDED = new EventNotificationEventType("2");
		public static readonly EventNotificationEventType OBJECT_CHANGED = new EventNotificationEventType("3");
		public static readonly EventNotificationEventType OBJECT_COPIED = new EventNotificationEventType("4");
		public static readonly EventNotificationEventType OBJECT_CREATED = new EventNotificationEventType("5");
		public static readonly EventNotificationEventType OBJECT_DATA_CHANGED = new EventNotificationEventType("6");
		public static readonly EventNotificationEventType OBJECT_DELETED = new EventNotificationEventType("7");
		public static readonly EventNotificationEventType OBJECT_ERASED = new EventNotificationEventType("8");
		public static readonly EventNotificationEventType OBJECT_READY_FOR_REPLACMENT = new EventNotificationEventType("9");
		public static readonly EventNotificationEventType OBJECT_SAVED = new EventNotificationEventType("10");
		public static readonly EventNotificationEventType OBJECT_UPDATED = new EventNotificationEventType("11");
		public static readonly EventNotificationEventType OBJECT_REPLACED = new EventNotificationEventType("12");
		public static readonly EventNotificationEventType OBJECT_READY_FOR_INDEX = new EventNotificationEventType("13");

		private EventNotificationEventType(string name) : base(name) { }
	}
}
