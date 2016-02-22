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
	public sealed class KalturaDropFolderFileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDropFolderFileOrderBy CREATED_AT_ASC = new KalturaDropFolderFileOrderBy("+createdAt");
		public static readonly KalturaDropFolderFileOrderBy FILE_NAME_ASC = new KalturaDropFolderFileOrderBy("+fileName");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_ASC = new KalturaDropFolderFileOrderBy("+fileSize");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new KalturaDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly KalturaDropFolderFileOrderBy ID_ASC = new KalturaDropFolderFileOrderBy("+id");
		public static readonly KalturaDropFolderFileOrderBy PARSED_FLAVOR_ASC = new KalturaDropFolderFileOrderBy("+parsedFlavor");
		public static readonly KalturaDropFolderFileOrderBy PARSED_SLUG_ASC = new KalturaDropFolderFileOrderBy("+parsedSlug");
		public static readonly KalturaDropFolderFileOrderBy UPDATED_AT_ASC = new KalturaDropFolderFileOrderBy("+updatedAt");
		public static readonly KalturaDropFolderFileOrderBy CREATED_AT_DESC = new KalturaDropFolderFileOrderBy("-createdAt");
		public static readonly KalturaDropFolderFileOrderBy FILE_NAME_DESC = new KalturaDropFolderFileOrderBy("-fileName");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_DESC = new KalturaDropFolderFileOrderBy("-fileSize");
		public static readonly KalturaDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new KalturaDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly KalturaDropFolderFileOrderBy ID_DESC = new KalturaDropFolderFileOrderBy("-id");
		public static readonly KalturaDropFolderFileOrderBy PARSED_FLAVOR_DESC = new KalturaDropFolderFileOrderBy("-parsedFlavor");
		public static readonly KalturaDropFolderFileOrderBy PARSED_SLUG_DESC = new KalturaDropFolderFileOrderBy("-parsedSlug");
		public static readonly KalturaDropFolderFileOrderBy UPDATED_AT_DESC = new KalturaDropFolderFileOrderBy("-updatedAt");

		private KalturaDropFolderFileOrderBy(string name) : base(name) { }
	}
}
