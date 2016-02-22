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
	public sealed class KalturaEventNotificationEventType : KalturaStringEnum
	{
		public static readonly KalturaEventNotificationEventType BATCH_JOB_STATUS = new KalturaEventNotificationEventType("1");
		public static readonly KalturaEventNotificationEventType OBJECT_ADDED = new KalturaEventNotificationEventType("2");
		public static readonly KalturaEventNotificationEventType OBJECT_CHANGED = new KalturaEventNotificationEventType("3");
		public static readonly KalturaEventNotificationEventType OBJECT_COPIED = new KalturaEventNotificationEventType("4");
		public static readonly KalturaEventNotificationEventType OBJECT_CREATED = new KalturaEventNotificationEventType("5");
		public static readonly KalturaEventNotificationEventType OBJECT_DATA_CHANGED = new KalturaEventNotificationEventType("6");
		public static readonly KalturaEventNotificationEventType OBJECT_DELETED = new KalturaEventNotificationEventType("7");
		public static readonly KalturaEventNotificationEventType OBJECT_ERASED = new KalturaEventNotificationEventType("8");
		public static readonly KalturaEventNotificationEventType OBJECT_READY_FOR_REPLACMENT = new KalturaEventNotificationEventType("9");
		public static readonly KalturaEventNotificationEventType OBJECT_SAVED = new KalturaEventNotificationEventType("10");
		public static readonly KalturaEventNotificationEventType OBJECT_UPDATED = new KalturaEventNotificationEventType("11");
		public static readonly KalturaEventNotificationEventType OBJECT_REPLACED = new KalturaEventNotificationEventType("12");
		public static readonly KalturaEventNotificationEventType OBJECT_READY_FOR_INDEX = new KalturaEventNotificationEventType("13");

		private KalturaEventNotificationEventType(string name) : base(name) { }
	}
}
