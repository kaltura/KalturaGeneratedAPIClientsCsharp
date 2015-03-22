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
	public sealed class KalturaThumbCuePointOrderBy : KalturaStringEnum
	{
		public static readonly KalturaThumbCuePointOrderBy CREATED_AT_ASC = new KalturaThumbCuePointOrderBy("+createdAt");
		public static readonly KalturaThumbCuePointOrderBy PARTNER_SORT_VALUE_ASC = new KalturaThumbCuePointOrderBy("+partnerSortValue");
		public static readonly KalturaThumbCuePointOrderBy START_TIME_ASC = new KalturaThumbCuePointOrderBy("+startTime");
		public static readonly KalturaThumbCuePointOrderBy TRIGGERED_AT_ASC = new KalturaThumbCuePointOrderBy("+triggeredAt");
		public static readonly KalturaThumbCuePointOrderBy UPDATED_AT_ASC = new KalturaThumbCuePointOrderBy("+updatedAt");
		public static readonly KalturaThumbCuePointOrderBy CREATED_AT_DESC = new KalturaThumbCuePointOrderBy("-createdAt");
		public static readonly KalturaThumbCuePointOrderBy PARTNER_SORT_VALUE_DESC = new KalturaThumbCuePointOrderBy("-partnerSortValue");
		public static readonly KalturaThumbCuePointOrderBy START_TIME_DESC = new KalturaThumbCuePointOrderBy("-startTime");
		public static readonly KalturaThumbCuePointOrderBy TRIGGERED_AT_DESC = new KalturaThumbCuePointOrderBy("-triggeredAt");
		public static readonly KalturaThumbCuePointOrderBy UPDATED_AT_DESC = new KalturaThumbCuePointOrderBy("-updatedAt");

		private KalturaThumbCuePointOrderBy(string name) : base(name) { }
	}
}
