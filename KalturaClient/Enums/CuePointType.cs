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
	public sealed class CuePointType : StringEnum
	{
		public static readonly CuePointType AD = new CuePointType("adCuePoint.Ad");
		public static readonly CuePointType ANNOTATION = new CuePointType("annotation.Annotation");
		public static readonly CuePointType CODE = new CuePointType("codeCuePoint.Code");
		public static readonly CuePointType EVENT = new CuePointType("eventCuePoint.Event");
		public static readonly CuePointType QUIZ_ANSWER = new CuePointType("quiz.QUIZ_ANSWER");
		public static readonly CuePointType QUIZ_QUESTION = new CuePointType("quiz.QUIZ_QUESTION");
		public static readonly CuePointType THUMB = new CuePointType("thumbCuePoint.Thumb");

		private CuePointType(string name) : base(name) { }
	}
}
