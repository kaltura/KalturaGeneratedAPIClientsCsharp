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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class BulkUploadAction : StringEnum
	{
		public static readonly BulkUploadAction CANCEL = new BulkUploadAction("scheduleBulkUpload.CANCEL");
		public static readonly BulkUploadAction ADD = new BulkUploadAction("1");
		public static readonly BulkUploadAction UPDATE = new BulkUploadAction("2");
		public static readonly BulkUploadAction DELETE = new BulkUploadAction("3");
		public static readonly BulkUploadAction REPLACE = new BulkUploadAction("4");
		public static readonly BulkUploadAction TRANSFORM_XSLT = new BulkUploadAction("5");
		public static readonly BulkUploadAction ADD_OR_UPDATE = new BulkUploadAction("6");
		public static readonly BulkUploadAction ACTIVATE = new BulkUploadAction("7");
		public static readonly BulkUploadAction REJECT = new BulkUploadAction("8");

		private BulkUploadAction(string name) : base(name) { }
	}
}
