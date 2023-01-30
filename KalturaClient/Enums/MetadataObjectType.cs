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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class MetadataObjectType : StringEnum
	{
		public static readonly MetadataObjectType AD_CUE_POINT = new MetadataObjectType("adCuePointMetadata.AdCuePoint");
		public static readonly MetadataObjectType ANNOTATION = new MetadataObjectType("annotationMetadata.Annotation");
		public static readonly MetadataObjectType CODE_CUE_POINT = new MetadataObjectType("codeCuePointMetadata.CodeCuePoint");
		public static readonly MetadataObjectType ANSWER_CUE_POINT = new MetadataObjectType("quiz.AnswerCuePoint");
		public static readonly MetadataObjectType QUESTION_CUE_POINT = new MetadataObjectType("quiz.QuestionCuePoint");
		public static readonly MetadataObjectType THUMB_CUE_POINT = new MetadataObjectType("thumbCuePointMetadata.thumbCuePoint");
		public static readonly MetadataObjectType ENTRY = new MetadataObjectType("1");
		public static readonly MetadataObjectType CATEGORY = new MetadataObjectType("2");
		public static readonly MetadataObjectType USER = new MetadataObjectType("3");
		public static readonly MetadataObjectType PARTNER = new MetadataObjectType("4");
		public static readonly MetadataObjectType DYNAMIC_OBJECT = new MetadataObjectType("5");
		public static readonly MetadataObjectType USER_ENTRY = new MetadataObjectType("6");

		private MetadataObjectType(string name) : base(name) { }
	}
}
