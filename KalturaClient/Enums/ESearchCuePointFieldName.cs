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
	public sealed class ESearchCuePointFieldName : StringEnum
	{
		public static readonly ESearchCuePointFieldName ANSWERS = new ESearchCuePointFieldName("answers");
		public static readonly ESearchCuePointFieldName END_TIME = new ESearchCuePointFieldName("end_time");
		public static readonly ESearchCuePointFieldName EXPLANATION = new ESearchCuePointFieldName("explanation");
		public static readonly ESearchCuePointFieldName HINT = new ESearchCuePointFieldName("hint");
		public static readonly ESearchCuePointFieldName ID = new ESearchCuePointFieldName("id");
		public static readonly ESearchCuePointFieldName NAME = new ESearchCuePointFieldName("name");
		public static readonly ESearchCuePointFieldName QUESTION = new ESearchCuePointFieldName("question");
		public static readonly ESearchCuePointFieldName START_TIME = new ESearchCuePointFieldName("start_time");
		public static readonly ESearchCuePointFieldName SUB_TYPE = new ESearchCuePointFieldName("sub_type");
		public static readonly ESearchCuePointFieldName TAGS = new ESearchCuePointFieldName("tags");
		public static readonly ESearchCuePointFieldName TEXT = new ESearchCuePointFieldName("text");
		public static readonly ESearchCuePointFieldName TYPE = new ESearchCuePointFieldName("type");

		private ESearchCuePointFieldName(string name) : base(name) { }
	}
}
