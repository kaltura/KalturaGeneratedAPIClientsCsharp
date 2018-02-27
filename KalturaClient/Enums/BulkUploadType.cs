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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class BulkUploadType : StringEnum
	{
		public static readonly BulkUploadType CSV = new BulkUploadType("bulkUploadCsv.CSV");
		public static readonly BulkUploadType FILTER = new BulkUploadType("bulkUploadFilter.FILTER");
		public static readonly BulkUploadType XML = new BulkUploadType("bulkUploadXml.XML");
		public static readonly BulkUploadType DROP_FOLDER_XML = new BulkUploadType("dropFolderXmlBulkUpload.DROP_FOLDER_XML");
		public static readonly BulkUploadType ICAL = new BulkUploadType("scheduleBulkUpload.ICAL");
		public static readonly BulkUploadType DROP_FOLDER_ICAL = new BulkUploadType("scheduleDropFolder.DROP_FOLDER_ICAL");

		private BulkUploadType(string name) : base(name) { }
	}
}
