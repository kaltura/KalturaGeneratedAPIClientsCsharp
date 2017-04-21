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
	public sealed class DropFolderFileOrderBy : StringEnum
	{
		public static readonly DropFolderFileOrderBy CREATED_AT_ASC = new DropFolderFileOrderBy("+createdAt");
		public static readonly DropFolderFileOrderBy FILE_NAME_ASC = new DropFolderFileOrderBy("+fileName");
		public static readonly DropFolderFileOrderBy FILE_SIZE_ASC = new DropFolderFileOrderBy("+fileSize");
		public static readonly DropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new DropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly DropFolderFileOrderBy ID_ASC = new DropFolderFileOrderBy("+id");
		public static readonly DropFolderFileOrderBy PARSED_FLAVOR_ASC = new DropFolderFileOrderBy("+parsedFlavor");
		public static readonly DropFolderFileOrderBy PARSED_SLUG_ASC = new DropFolderFileOrderBy("+parsedSlug");
		public static readonly DropFolderFileOrderBy UPDATED_AT_ASC = new DropFolderFileOrderBy("+updatedAt");
		public static readonly DropFolderFileOrderBy CREATED_AT_DESC = new DropFolderFileOrderBy("-createdAt");
		public static readonly DropFolderFileOrderBy FILE_NAME_DESC = new DropFolderFileOrderBy("-fileName");
		public static readonly DropFolderFileOrderBy FILE_SIZE_DESC = new DropFolderFileOrderBy("-fileSize");
		public static readonly DropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new DropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly DropFolderFileOrderBy ID_DESC = new DropFolderFileOrderBy("-id");
		public static readonly DropFolderFileOrderBy PARSED_FLAVOR_DESC = new DropFolderFileOrderBy("-parsedFlavor");
		public static readonly DropFolderFileOrderBy PARSED_SLUG_DESC = new DropFolderFileOrderBy("-parsedSlug");
		public static readonly DropFolderFileOrderBy UPDATED_AT_DESC = new DropFolderFileOrderBy("-updatedAt");

		private DropFolderFileOrderBy(string name) : base(name) { }
	}
}
