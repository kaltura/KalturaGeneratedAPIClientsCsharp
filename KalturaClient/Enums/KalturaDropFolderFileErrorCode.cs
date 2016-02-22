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
// Copyright (C) 2006-2016  Kaltura Inc.
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
namespace Kaltura
{
	public sealed class KalturaDropFolderFileErrorCode : KalturaStringEnum
	{
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADDING_BULK_UPLOAD = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_ADDING_BULK_UPLOAD");
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADD_CONTENT_RESOURCE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_ADD_CONTENT_RESOURCE");
		public static readonly KalturaDropFolderFileErrorCode ERROR_IN_BULK_UPLOAD = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_IN_BULK_UPLOAD");
		public static readonly KalturaDropFolderFileErrorCode ERROR_WRITING_TEMP_FILE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.ERROR_WRITING_TEMP_FILE");
		public static readonly KalturaDropFolderFileErrorCode LOCAL_FILE_WRONG_CHECKSUM = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_CHECKSUM");
		public static readonly KalturaDropFolderFileErrorCode LOCAL_FILE_WRONG_SIZE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.LOCAL_FILE_WRONG_SIZE");
		public static readonly KalturaDropFolderFileErrorCode MALFORMED_XML_FILE = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.MALFORMED_XML_FILE");
		public static readonly KalturaDropFolderFileErrorCode XML_FILE_SIZE_EXCEED_LIMIT = new KalturaDropFolderFileErrorCode("dropFolderXmlBulkUpload.XML_FILE_SIZE_EXCEED_LIMIT");
		public static readonly KalturaDropFolderFileErrorCode ERROR_UPDATE_ENTRY = new KalturaDropFolderFileErrorCode("1");
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADD_ENTRY = new KalturaDropFolderFileErrorCode("2");
		public static readonly KalturaDropFolderFileErrorCode FLAVOR_NOT_FOUND = new KalturaDropFolderFileErrorCode("3");
		public static readonly KalturaDropFolderFileErrorCode FLAVOR_MISSING_IN_FILE_NAME = new KalturaDropFolderFileErrorCode("4");
		public static readonly KalturaDropFolderFileErrorCode SLUG_REGEX_NO_MATCH = new KalturaDropFolderFileErrorCode("5");
		public static readonly KalturaDropFolderFileErrorCode ERROR_READING_FILE = new KalturaDropFolderFileErrorCode("6");
		public static readonly KalturaDropFolderFileErrorCode ERROR_DOWNLOADING_FILE = new KalturaDropFolderFileErrorCode("7");
		public static readonly KalturaDropFolderFileErrorCode ERROR_UPDATE_FILE = new KalturaDropFolderFileErrorCode("8");
		public static readonly KalturaDropFolderFileErrorCode ERROR_ADDING_CONTENT_PROCESSOR = new KalturaDropFolderFileErrorCode("10");
		public static readonly KalturaDropFolderFileErrorCode ERROR_IN_CONTENT_PROCESSOR = new KalturaDropFolderFileErrorCode("11");
		public static readonly KalturaDropFolderFileErrorCode ERROR_DELETING_FILE = new KalturaDropFolderFileErrorCode("12");
		public static readonly KalturaDropFolderFileErrorCode FILE_NO_MATCH = new KalturaDropFolderFileErrorCode("13");

		private KalturaDropFolderFileErrorCode(string name) : base(name) { }
	}
}
