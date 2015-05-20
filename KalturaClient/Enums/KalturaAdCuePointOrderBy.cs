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
	public sealed class KalturaAdCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaAdCuePointOrderBy CREATED_AT_ASC = new KalturaAdCuePointOrderBy("+createdAt");
		public static readonly KalturaAdCuePointOrderBy DURATION_ASC = new KalturaAdCuePointOrderBy("+duration");
		public static readonly KalturaAdCuePointOrderBy END_TIME_ASC = new KalturaAdCuePointOrderBy("+endTime");
		public static readonly KalturaAdCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaAdCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaAdCuePointOrderBy START_TIME_ASC = new KalturaAdCuePointOrderBy("+startTime");
		public static readonly KalturaAdCuePointOrderBy TRIGGERED_AT_ASC = new KalturaAdCuePointOrderBy("+triggeredAt");
		public static readonly KalturaAdCuePointOrderBy UPDATED_AT_ASC = new KalturaAdCuePointOrderBy("+updatedAt");
		public static readonly KalturaAdCuePointOrderBy CREATED_AT_DESC = new KalturaAdCuePointOrderBy("-createdAt");
		public static readonly KalturaAdCuePointOrderBy DURATION_DESC = new KalturaAdCuePointOrderBy("-duration");
		public static readonly KalturaAdCuePointOrderBy END_TIME_DESC = new KalturaAdCuePointOrderBy("-endTime");
		public static readonly KalturaAdCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaAdCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaAdCuePointOrderBy START_TIME_DESC = new KalturaAdCuePointOrderBy("-startTime");
		public static readonly KalturaAdCuePointOrderBy TRIGGERED_AT_DESC = new KalturaAdCuePointOrderBy("-triggeredAt");
		public static readonly KalturaAdCuePointOrderBy UPDATED_AT_DESC = new KalturaAdCuePointOrderBy("-updatedAt");

		private KalturaAdCuePointOrderBy(string name) : base(name) { }
	}
}
