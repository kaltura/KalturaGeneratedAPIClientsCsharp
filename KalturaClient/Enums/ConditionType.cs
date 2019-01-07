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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class ConditionType : StringEnum
	{
		public static readonly ConditionType EVENT_NOTIFICATION_FIELD = new ConditionType("eventNotification.BooleanField");
		public static readonly ConditionType EVENT_NOTIFICATION_OBJECT_CHANGED = new ConditionType("eventNotification.ObjectChanged");
		public static readonly ConditionType METADATA_FIELD_CHANGED = new ConditionType("metadata.FieldChanged");
		public static readonly ConditionType METADATA_FIELD_COMPARE = new ConditionType("metadata.FieldCompare");
		public static readonly ConditionType METADATA_FIELD_MATCH = new ConditionType("metadata.FieldMatch");
		public static readonly ConditionType AUTHENTICATED = new ConditionType("1");
		public static readonly ConditionType COUNTRY = new ConditionType("2");
		public static readonly ConditionType IP_ADDRESS = new ConditionType("3");
		public static readonly ConditionType SITE = new ConditionType("4");
		public static readonly ConditionType USER_AGENT = new ConditionType("5");
		public static readonly ConditionType FIELD_MATCH = new ConditionType("6");
		public static readonly ConditionType FIELD_COMPARE = new ConditionType("7");
		public static readonly ConditionType ASSET_PROPERTIES_COMPARE = new ConditionType("8");
		public static readonly ConditionType USER_ROLE = new ConditionType("9");
		public static readonly ConditionType GEO_DISTANCE = new ConditionType("10");
		public static readonly ConditionType OR_OPERATOR = new ConditionType("11");
		public static readonly ConditionType HASH = new ConditionType("12");
		public static readonly ConditionType DELIVERY_PROFILE = new ConditionType("13");
		public static readonly ConditionType ACTIVE_EDGE_VALIDATE = new ConditionType("14");
		public static readonly ConditionType ANONYMOUS_IP = new ConditionType("15");
		public static readonly ConditionType ASSET_TYPE = new ConditionType("16");

		private ConditionType(string name) : base(name) { }
	}
}
