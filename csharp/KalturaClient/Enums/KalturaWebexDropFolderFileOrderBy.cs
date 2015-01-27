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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaWebexDropFolderFileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaWebexDropFolderFileOrderBy CREATED_AT_ASC = new KalturaWebexDropFolderFileOrderBy("+createdAt");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_NAME_ASC = new KalturaWebexDropFolderFileOrderBy("+fileName");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_SIZE_ASC = new KalturaWebexDropFolderFileOrderBy("+fileSize");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new KalturaWebexDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly KalturaWebexDropFolderFileOrderBy ID_ASC = new KalturaWebexDropFolderFileOrderBy("+id");
		public static readonly KalturaWebexDropFolderFileOrderBy PARSED_FLAVOR_ASC = new KalturaWebexDropFolderFileOrderBy("+parsedFlavor");
		public static readonly KalturaWebexDropFolderFileOrderBy PARSED_SLUG_ASC = new KalturaWebexDropFolderFileOrderBy("+parsedSlug");
		public static readonly KalturaWebexDropFolderFileOrderBy UPDATED_AT_ASC = new KalturaWebexDropFolderFileOrderBy("+updatedAt");
		public static readonly KalturaWebexDropFolderFileOrderBy CREATED_AT_DESC = new KalturaWebexDropFolderFileOrderBy("-createdAt");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_NAME_DESC = new KalturaWebexDropFolderFileOrderBy("-fileName");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_SIZE_DESC = new KalturaWebexDropFolderFileOrderBy("-fileSize");
		public static readonly KalturaWebexDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new KalturaWebexDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly KalturaWebexDropFolderFileOrderBy ID_DESC = new KalturaWebexDropFolderFileOrderBy("-id");
		public static readonly KalturaWebexDropFolderFileOrderBy PARSED_FLAVOR_DESC = new KalturaWebexDropFolderFileOrderBy("-parsedFlavor");
		public static readonly KalturaWebexDropFolderFileOrderBy PARSED_SLUG_DESC = new KalturaWebexDropFolderFileOrderBy("-parsedSlug");
		public static readonly KalturaWebexDropFolderFileOrderBy UPDATED_AT_DESC = new KalturaWebexDropFolderFileOrderBy("-updatedAt");

		private KalturaWebexDropFolderFileOrderBy(string name) : base(name) { }
	}
}
