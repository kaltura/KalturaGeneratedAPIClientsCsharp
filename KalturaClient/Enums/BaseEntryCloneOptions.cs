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
	public sealed class BaseEntryCloneOptions : StringEnum
	{
		public static readonly BaseEntryCloneOptions AD_CUE_POINTS = new BaseEntryCloneOptions("adCuePoint.AD_CUE_POINTS");
		public static readonly BaseEntryCloneOptions ANNOTATION_CUE_POINTS = new BaseEntryCloneOptions("annotation.ANNOTATION_CUE_POINTS");
		public static readonly BaseEntryCloneOptions CODE_CUE_POINTS = new BaseEntryCloneOptions("codeCuePoint.CODE_CUE_POINTS");
		public static readonly BaseEntryCloneOptions THUMB_CUE_POINTS = new BaseEntryCloneOptions("thumbCuePoint.THUMB_CUE_POINTS");
		public static readonly BaseEntryCloneOptions USERS = new BaseEntryCloneOptions("1");
		public static readonly BaseEntryCloneOptions CATEGORIES = new BaseEntryCloneOptions("2");
		public static readonly BaseEntryCloneOptions CHILD_ENTRIES = new BaseEntryCloneOptions("3");
		public static readonly BaseEntryCloneOptions ACCESS_CONTROL = new BaseEntryCloneOptions("4");
		public static readonly BaseEntryCloneOptions METADATA = new BaseEntryCloneOptions("5");
		public static readonly BaseEntryCloneOptions FLAVORS = new BaseEntryCloneOptions("6");
		public static readonly BaseEntryCloneOptions CAPTIONS = new BaseEntryCloneOptions("7");

		private BaseEntryCloneOptions(string name) : base(name) { }
	}
}
