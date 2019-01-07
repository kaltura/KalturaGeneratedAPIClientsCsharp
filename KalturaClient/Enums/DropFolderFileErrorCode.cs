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
	public sealed class DropFolderFileErrorCode : StringEnum
	{
		public static readonly DropFolderFileErrorCode ERROR_ADDING_BULK_UPLOAD = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_ADDING_BULK_UPLOAD");
		public static readonly DropFolderFileErrorCode ERROR_ADD_CONTENT_RESOURCE = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_ADD_CONTENT_RESOURCE");
		public static readonly DropFolderFileErrorCode ERROR_IN_BULK_UPLOAD = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_IN_BULK_UPLOAD");
		public static readonly DropFolderFileErrorCode ERROR_WRITING_TEMP_FILE = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_WRITING_TEMP_FILE");
		public static readonly DropFolderFileErrorCode LOCAL_FILE_WRONG_CHECKSUM = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_CHECKSUM");
		public static readonly DropFolderFileErrorCode LOCAL_FILE_WRONG_SIZE = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_SIZE");
		public static readonly DropFolderFileErrorCode MALFORMED_XML_FILE = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.MALFORMED_XML_FILE");
		public static readonly DropFolderFileErrorCode XML_FILE_SIZE_EXCEED_LIMIT = new DropFolderFileErrorCode("dropFolderXmlBulkUpload.XML_FILE_SIZE_EXCEED_LIMIT");
		public static readonly DropFolderFileErrorCode ERROR_UPDATE_ENTRY = new DropFolderFileErrorCode("1");
		public static readonly DropFolderFileErrorCode ERROR_ADD_ENTRY = new DropFolderFileErrorCode("2");
		public static readonly DropFolderFileErrorCode FLAVOR_NOT_FOUND = new DropFolderFileErrorCode("3");
		public static readonly DropFolderFileErrorCode FLAVOR_MISSING_IN_FILE_NAME = new DropFolderFileErrorCode("4");
		public static readonly DropFolderFileErrorCode SLUG_REGEX_NO_MATCH = new DropFolderFileErrorCode("5");
		public static readonly DropFolderFileErrorCode ERROR_READING_FILE = new DropFolderFileErrorCode("6");
		public static readonly DropFolderFileErrorCode ERROR_DOWNLOADING_FILE = new DropFolderFileErrorCode("7");
		public static readonly DropFolderFileErrorCode ERROR_UPDATE_FILE = new DropFolderFileErrorCode("8");
		public static readonly DropFolderFileErrorCode ERROR_ADDING_CONTENT_PROCESSOR = new DropFolderFileErrorCode("10");
		public static readonly DropFolderFileErrorCode ERROR_IN_CONTENT_PROCESSOR = new DropFolderFileErrorCode("11");
		public static readonly DropFolderFileErrorCode ERROR_DELETING_FILE = new DropFolderFileErrorCode("12");
		public static readonly DropFolderFileErrorCode FILE_NO_MATCH = new DropFolderFileErrorCode("13");

		private DropFolderFileErrorCode(string name) : base(name) { }
	}
}
