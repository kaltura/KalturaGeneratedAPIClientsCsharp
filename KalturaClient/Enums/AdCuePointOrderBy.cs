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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class AdCuePointOrderBy : StringEnum
	{
		public static readonly AdCuePointOrderBy CREATED_AT_ASC = new AdCuePointOrderBy("+createdAt");
		public static readonly AdCuePointOrderBy DURATION_ASC = new AdCuePointOrderBy("+duration");
		public static readonly AdCuePointOrderBy END_TIME_ASC = new AdCuePointOrderBy("+endTime");
		public static readonly AdCuePointOrderBy INT_ID_ASC = new AdCuePointOrderBy("+intId");
		public static readonly AdCuePointOrderBy PARTNER_SORT_VALUE_ASC = new AdCuePointOrderBy("+partnerSortValue");
		public static readonly AdCuePointOrderBy START_TIME_ASC = new AdCuePointOrderBy("+startTime");
		public static readonly AdCuePointOrderBy TRIGGERED_AT_ASC = new AdCuePointOrderBy("+triggeredAt");
		public static readonly AdCuePointOrderBy UPDATED_AT_ASC = new AdCuePointOrderBy("+updatedAt");
		public static readonly AdCuePointOrderBy CREATED_AT_DESC = new AdCuePointOrderBy("-createdAt");
		public static readonly AdCuePointOrderBy DURATION_DESC = new AdCuePointOrderBy("-duration");
		public static readonly AdCuePointOrderBy END_TIME_DESC = new AdCuePointOrderBy("-endTime");
		public static readonly AdCuePointOrderBy INT_ID_DESC = new AdCuePointOrderBy("-intId");
		public static readonly AdCuePointOrderBy PARTNER_SORT_VALUE_DESC = new AdCuePointOrderBy("-partnerSortValue");
		public static readonly AdCuePointOrderBy START_TIME_DESC = new AdCuePointOrderBy("-startTime");
		public static readonly AdCuePointOrderBy TRIGGERED_AT_DESC = new AdCuePointOrderBy("-triggeredAt");
		public static readonly AdCuePointOrderBy UPDATED_AT_DESC = new AdCuePointOrderBy("-updatedAt");

		private AdCuePointOrderBy(string name) : base(name) { }
	}
}
