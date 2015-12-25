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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaConditionType : KalturaStringEnum
	{
		public static readonly KalturaConditionType EVENT_NOTIFICATION_FIELD = new KalturaConditionType("eventNotification.BooleanField");
		public static readonly KalturaConditionType EVENT_NOTIFICATION_OBJECT_CHANGED = new KalturaConditionType("eventNotification.ObjectChanged");
		public static readonly KalturaConditionType METADATA_FIELD_CHANGED = new KalturaConditionType("metadata.FieldChanged");
		public static readonly KalturaConditionType METADATA_FIELD_COMPARE = new KalturaConditionType("metadata.FieldCompare");
		public static readonly KalturaConditionType METADATA_FIELD_MATCH = new KalturaConditionType("metadata.FieldMatch");
		public static readonly KalturaConditionType AUTHENTICATED = new KalturaConditionType("1");
		public static readonly KalturaConditionType COUNTRY = new KalturaConditionType("2");
		public static readonly KalturaConditionType IP_ADDRESS = new KalturaConditionType("3");
		public static readonly KalturaConditionType SITE = new KalturaConditionType("4");
		public static readonly KalturaConditionType USER_AGENT = new KalturaConditionType("5");
		public static readonly KalturaConditionType FIELD_MATCH = new KalturaConditionType("6");
		public static readonly KalturaConditionType FIELD_COMPARE = new KalturaConditionType("7");
		public static readonly KalturaConditionType ASSET_PROPERTIES_COMPARE = new KalturaConditionType("8");
		public static readonly KalturaConditionType USER_ROLE = new KalturaConditionType("9");
		public static readonly KalturaConditionType GEO_DISTANCE = new KalturaConditionType("10");
		public static readonly KalturaConditionType OR_OPERATOR = new KalturaConditionType("11");
		public static readonly KalturaConditionType HASH = new KalturaConditionType("12");
		public static readonly KalturaConditionType DELIVERY_PROFILE = new KalturaConditionType("13");
		public static readonly KalturaConditionType ACTIVE_EDGE_VALIDATE = new KalturaConditionType("14");

		private KalturaConditionType(string name) : base(name) { }
	}
}
