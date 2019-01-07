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
	public sealed class CodeCuePointOrderBy : StringEnum
	{
		public static readonly CodeCuePointOrderBy CREATED_AT_ASC = new CodeCuePointOrderBy("+createdAt");
		public static readonly CodeCuePointOrderBy DURATION_ASC = new CodeCuePointOrderBy("+duration");
		public static readonly CodeCuePointOrderBy END_TIME_ASC = new CodeCuePointOrderBy("+endTime");
		public static readonly CodeCuePointOrderBy PARTNER_SORT_VALUE_ASC = new CodeCuePointOrderBy("+partnerSortValue");
		public static readonly CodeCuePointOrderBy START_TIME_ASC = new CodeCuePointOrderBy("+startTime");
		public static readonly CodeCuePointOrderBy TRIGGERED_AT_ASC = new CodeCuePointOrderBy("+triggeredAt");
		public static readonly CodeCuePointOrderBy UPDATED_AT_ASC = new CodeCuePointOrderBy("+updatedAt");
		public static readonly CodeCuePointOrderBy CREATED_AT_DESC = new CodeCuePointOrderBy("-createdAt");
		public static readonly CodeCuePointOrderBy DURATION_DESC = new CodeCuePointOrderBy("-duration");
		public static readonly CodeCuePointOrderBy END_TIME_DESC = new CodeCuePointOrderBy("-endTime");
		public static readonly CodeCuePointOrderBy PARTNER_SORT_VALUE_DESC = new CodeCuePointOrderBy("-partnerSortValue");
		public static readonly CodeCuePointOrderBy START_TIME_DESC = new CodeCuePointOrderBy("-startTime");
		public static readonly CodeCuePointOrderBy TRIGGERED_AT_DESC = new CodeCuePointOrderBy("-triggeredAt");
		public static readonly CodeCuePointOrderBy UPDATED_AT_DESC = new CodeCuePointOrderBy("-updatedAt");

		private CodeCuePointOrderBy(string name) : base(name) { }
	}
}
