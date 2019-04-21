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
	public sealed class EventCuePointOrderBy : StringEnum
	{
		public static readonly EventCuePointOrderBy CREATED_AT_ASC = new EventCuePointOrderBy("+createdAt");
		public static readonly EventCuePointOrderBy INT_ID_ASC = new EventCuePointOrderBy("+intId");
		public static readonly EventCuePointOrderBy PARTNER_SORT_VALUE_ASC = new EventCuePointOrderBy("+partnerSortValue");
		public static readonly EventCuePointOrderBy START_TIME_ASC = new EventCuePointOrderBy("+startTime");
		public static readonly EventCuePointOrderBy TRIGGERED_AT_ASC = new EventCuePointOrderBy("+triggeredAt");
		public static readonly EventCuePointOrderBy UPDATED_AT_ASC = new EventCuePointOrderBy("+updatedAt");
		public static readonly EventCuePointOrderBy CREATED_AT_DESC = new EventCuePointOrderBy("-createdAt");
		public static readonly EventCuePointOrderBy INT_ID_DESC = new EventCuePointOrderBy("-intId");
		public static readonly EventCuePointOrderBy PARTNER_SORT_VALUE_DESC = new EventCuePointOrderBy("-partnerSortValue");
		public static readonly EventCuePointOrderBy START_TIME_DESC = new EventCuePointOrderBy("-startTime");
		public static readonly EventCuePointOrderBy TRIGGERED_AT_DESC = new EventCuePointOrderBy("-triggeredAt");
		public static readonly EventCuePointOrderBy UPDATED_AT_DESC = new EventCuePointOrderBy("-updatedAt");

		private EventCuePointOrderBy(string name) : base(name) { }
	}
}
