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
	public sealed class FeedDropFolderFileOrderBy : StringEnum
	{
		public static readonly FeedDropFolderFileOrderBy CREATED_AT_ASC = new FeedDropFolderFileOrderBy("+createdAt");
		public static readonly FeedDropFolderFileOrderBy FILE_NAME_ASC = new FeedDropFolderFileOrderBy("+fileName");
		public static readonly FeedDropFolderFileOrderBy FILE_SIZE_ASC = new FeedDropFolderFileOrderBy("+fileSize");
		public static readonly FeedDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new FeedDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly FeedDropFolderFileOrderBy ID_ASC = new FeedDropFolderFileOrderBy("+id");
		public static readonly FeedDropFolderFileOrderBy PARSED_FLAVOR_ASC = new FeedDropFolderFileOrderBy("+parsedFlavor");
		public static readonly FeedDropFolderFileOrderBy PARSED_SLUG_ASC = new FeedDropFolderFileOrderBy("+parsedSlug");
		public static readonly FeedDropFolderFileOrderBy UPDATED_AT_ASC = new FeedDropFolderFileOrderBy("+updatedAt");
		public static readonly FeedDropFolderFileOrderBy CREATED_AT_DESC = new FeedDropFolderFileOrderBy("-createdAt");
		public static readonly FeedDropFolderFileOrderBy FILE_NAME_DESC = new FeedDropFolderFileOrderBy("-fileName");
		public static readonly FeedDropFolderFileOrderBy FILE_SIZE_DESC = new FeedDropFolderFileOrderBy("-fileSize");
		public static readonly FeedDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new FeedDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly FeedDropFolderFileOrderBy ID_DESC = new FeedDropFolderFileOrderBy("-id");
		public static readonly FeedDropFolderFileOrderBy PARSED_FLAVOR_DESC = new FeedDropFolderFileOrderBy("-parsedFlavor");
		public static readonly FeedDropFolderFileOrderBy PARSED_SLUG_DESC = new FeedDropFolderFileOrderBy("-parsedSlug");
		public static readonly FeedDropFolderFileOrderBy UPDATED_AT_DESC = new FeedDropFolderFileOrderBy("-updatedAt");

		private FeedDropFolderFileOrderBy(string name) : base(name) { }
	}
}
