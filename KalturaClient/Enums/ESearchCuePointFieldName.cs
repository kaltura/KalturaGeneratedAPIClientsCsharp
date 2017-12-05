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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public static readonly ESearchCuePointFieldName CUE_POINT_ANSWERS = new ESearchCuePointFieldName("cue_points.cue_point_answers");
		public static readonly ESearchCuePointFieldName CUE_POINT_END_TIME = new ESearchCuePointFieldName("cue_points.cue_point_end_time");
		public static readonly ESearchCuePointFieldName CUE_POINT_EXPLANATION = new ESearchCuePointFieldName("cue_points.cue_point_explanation");
		public static readonly ESearchCuePointFieldName CUE_POINT_HINT = new ESearchCuePointFieldName("cue_points.cue_point_hint");
		public static readonly ESearchCuePointFieldName CUE_POINT_ID = new ESearchCuePointFieldName("cue_points.cue_point_id");
		public static readonly ESearchCuePointFieldName CUE_POINT_NAME = new ESearchCuePointFieldName("cue_points.cue_point_name");
		public static readonly ESearchCuePointFieldName CUE_POINT_QUESTION = new ESearchCuePointFieldName("cue_points.cue_point_question");
		public static readonly ESearchCuePointFieldName CUE_POINT_START_TIME = new ESearchCuePointFieldName("cue_points.cue_point_start_time");
		public static readonly ESearchCuePointFieldName CUE_POINT_SUB_TYPE = new ESearchCuePointFieldName("cue_points.cue_point_sub_type");
		public static readonly ESearchCuePointFieldName CUE_POINT_TAGS = new ESearchCuePointFieldName("cue_points.cue_point_tags");
		public static readonly ESearchCuePointFieldName CUE_POINT_TEXT = new ESearchCuePointFieldName("cue_points.cue_point_text");

		private ESearchCuePointFieldName(string name) : base(name) { }
	}
}
