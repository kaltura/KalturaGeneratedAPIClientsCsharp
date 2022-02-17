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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class AnswerCuePointOrderBy : StringEnum
	{
		public static readonly AnswerCuePointOrderBy CREATED_AT_ASC = new AnswerCuePointOrderBy("+createdAt");
		public static readonly AnswerCuePointOrderBy INT_ID_ASC = new AnswerCuePointOrderBy("+intId");
		public static readonly AnswerCuePointOrderBy PARTNER_SORT_VALUE_ASC = new AnswerCuePointOrderBy("+partnerSortValue");
		public static readonly AnswerCuePointOrderBy START_TIME_ASC = new AnswerCuePointOrderBy("+startTime");
		public static readonly AnswerCuePointOrderBy TRIGGERED_AT_ASC = new AnswerCuePointOrderBy("+triggeredAt");
		public static readonly AnswerCuePointOrderBy UPDATED_AT_ASC = new AnswerCuePointOrderBy("+updatedAt");
		public static readonly AnswerCuePointOrderBy CREATED_AT_DESC = new AnswerCuePointOrderBy("-createdAt");
		public static readonly AnswerCuePointOrderBy INT_ID_DESC = new AnswerCuePointOrderBy("-intId");
		public static readonly AnswerCuePointOrderBy PARTNER_SORT_VALUE_DESC = new AnswerCuePointOrderBy("-partnerSortValue");
		public static readonly AnswerCuePointOrderBy START_TIME_DESC = new AnswerCuePointOrderBy("-startTime");
		public static readonly AnswerCuePointOrderBy TRIGGERED_AT_DESC = new AnswerCuePointOrderBy("-triggeredAt");
		public static readonly AnswerCuePointOrderBy UPDATED_AT_DESC = new AnswerCuePointOrderBy("-updatedAt");

		private AnswerCuePointOrderBy(string name) : base(name) { }
	}
}
