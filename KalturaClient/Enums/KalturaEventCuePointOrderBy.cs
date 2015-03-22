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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaEventCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaEventCuePointOrderBy CREATED_AT_ASC = new KalturaEventCuePointOrderBy("+createdAt");
		public static readonly KalturaEventCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaEventCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaEventCuePointOrderBy START_TIME_ASC = new KalturaEventCuePointOrderBy("+startTime");
		public static readonly KalturaEventCuePointOrderBy TRIGGERED_AT_ASC = new KalturaEventCuePointOrderBy("+triggeredAt");
		public static readonly KalturaEventCuePointOrderBy UPDATED_AT_ASC = new KalturaEventCuePointOrderBy("+updatedAt");
		public static readonly KalturaEventCuePointOrderBy CREATED_AT_DESC = new KalturaEventCuePointOrderBy("-createdAt");
		public static readonly KalturaEventCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaEventCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaEventCuePointOrderBy START_TIME_DESC = new KalturaEventCuePointOrderBy("-startTime");
		public static readonly KalturaEventCuePointOrderBy TRIGGERED_AT_DESC = new KalturaEventCuePointOrderBy("-triggeredAt");
		public static readonly KalturaEventCuePointOrderBy UPDATED_AT_DESC = new KalturaEventCuePointOrderBy("-updatedAt");

		private KalturaEventCuePointOrderBy(string name) : base(name) { }
	}
}
