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
	public sealed class SchemaType : StringEnum
	{
		public static readonly SchemaType BULK_UPLOAD_RESULT_XML = new SchemaType("bulkUploadXml.bulkUploadResultXML");
		public static readonly SchemaType BULK_UPLOAD_XML = new SchemaType("bulkUploadXml.bulkUploadXML");
		public static readonly SchemaType INGEST_API = new SchemaType("cuePoint.ingestAPI");
		public static readonly SchemaType SERVE_API = new SchemaType("cuePoint.serveAPI");
		public static readonly SchemaType DROP_FOLDER_XML = new SchemaType("dropFolderXmlBulkUpload.dropFolderXml");
		public static readonly SchemaType SYNDICATION = new SchemaType("syndication");

		private SchemaType(string name) : base(name) { }
	}
}
