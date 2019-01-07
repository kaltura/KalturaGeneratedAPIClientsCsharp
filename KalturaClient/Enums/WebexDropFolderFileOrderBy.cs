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
	public sealed class WebexDropFolderFileOrderBy : StringEnum
	{
		public static readonly WebexDropFolderFileOrderBy CREATED_AT_ASC = new WebexDropFolderFileOrderBy("+createdAt");
		public static readonly WebexDropFolderFileOrderBy FILE_NAME_ASC = new WebexDropFolderFileOrderBy("+fileName");
		public static readonly WebexDropFolderFileOrderBy FILE_SIZE_ASC = new WebexDropFolderFileOrderBy("+fileSize");
		public static readonly WebexDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new WebexDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly WebexDropFolderFileOrderBy ID_ASC = new WebexDropFolderFileOrderBy("+id");
		public static readonly WebexDropFolderFileOrderBy PARSED_FLAVOR_ASC = new WebexDropFolderFileOrderBy("+parsedFlavor");
		public static readonly WebexDropFolderFileOrderBy PARSED_SLUG_ASC = new WebexDropFolderFileOrderBy("+parsedSlug");
		public static readonly WebexDropFolderFileOrderBy UPDATED_AT_ASC = new WebexDropFolderFileOrderBy("+updatedAt");
		public static readonly WebexDropFolderFileOrderBy CREATED_AT_DESC = new WebexDropFolderFileOrderBy("-createdAt");
		public static readonly WebexDropFolderFileOrderBy FILE_NAME_DESC = new WebexDropFolderFileOrderBy("-fileName");
		public static readonly WebexDropFolderFileOrderBy FILE_SIZE_DESC = new WebexDropFolderFileOrderBy("-fileSize");
		public static readonly WebexDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new WebexDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly WebexDropFolderFileOrderBy ID_DESC = new WebexDropFolderFileOrderBy("-id");
		public static readonly WebexDropFolderFileOrderBy PARSED_FLAVOR_DESC = new WebexDropFolderFileOrderBy("-parsedFlavor");
		public static readonly WebexDropFolderFileOrderBy PARSED_SLUG_DESC = new WebexDropFolderFileOrderBy("-parsedSlug");
		public static readonly WebexDropFolderFileOrderBy UPDATED_AT_DESC = new WebexDropFolderFileOrderBy("-updatedAt");

		private WebexDropFolderFileOrderBy(string name) : base(name) { }
	}
}
