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
	public sealed class KalturaCodeCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaCodeCuePointOrderBy CREATED_AT_ASC = new KalturaCodeCuePointOrderBy("+createdAt");
		public static readonly KalturaCodeCuePointOrderBy DURATION_ASC = new KalturaCodeCuePointOrderBy("+duration");
		public static readonly KalturaCodeCuePointOrderBy END_TIME_ASC = new KalturaCodeCuePointOrderBy("+endTime");
		public static readonly KalturaCodeCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaCodeCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaCodeCuePointOrderBy START_TIME_ASC = new KalturaCodeCuePointOrderBy("+startTime");
		public static readonly KalturaCodeCuePointOrderBy TRIGGERED_AT_ASC = new KalturaCodeCuePointOrderBy("+triggeredAt");
		public static readonly KalturaCodeCuePointOrderBy UPDATED_AT_ASC = new KalturaCodeCuePointOrderBy("+updatedAt");
		public static readonly KalturaCodeCuePointOrderBy CREATED_AT_DESC = new KalturaCodeCuePointOrderBy("-createdAt");
		public static readonly KalturaCodeCuePointOrderBy DURATION_DESC = new KalturaCodeCuePointOrderBy("-duration");
		public static readonly KalturaCodeCuePointOrderBy END_TIME_DESC = new KalturaCodeCuePointOrderBy("-endTime");
		public static readonly KalturaCodeCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaCodeCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaCodeCuePointOrderBy START_TIME_DESC = new KalturaCodeCuePointOrderBy("-startTime");
		public static readonly KalturaCodeCuePointOrderBy TRIGGERED_AT_DESC = new KalturaCodeCuePointOrderBy("-triggeredAt");
		public static readonly KalturaCodeCuePointOrderBy UPDATED_AT_DESC = new KalturaCodeCuePointOrderBy("-updatedAt");

		private KalturaCodeCuePointOrderBy(string name) : base(name) { }
	}
}
