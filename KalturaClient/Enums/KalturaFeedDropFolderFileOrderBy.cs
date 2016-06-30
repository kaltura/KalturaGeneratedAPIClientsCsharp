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
	public sealed class KalturaFeedDropFolderFileOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFeedDropFolderFileOrderBy CREATED_AT_ASC = new KalturaFeedDropFolderFileOrderBy("+createdAt");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_NAME_ASC = new KalturaFeedDropFolderFileOrderBy("+fileName");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_SIZE_ASC = new KalturaFeedDropFolderFileOrderBy("+fileSize");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_ASC = new KalturaFeedDropFolderFileOrderBy("+fileSizeLastSetAt");
		public static readonly KalturaFeedDropFolderFileOrderBy ID_ASC = new KalturaFeedDropFolderFileOrderBy("+id");
		public static readonly KalturaFeedDropFolderFileOrderBy PARSED_FLAVOR_ASC = new KalturaFeedDropFolderFileOrderBy("+parsedFlavor");
		public static readonly KalturaFeedDropFolderFileOrderBy PARSED_SLUG_ASC = new KalturaFeedDropFolderFileOrderBy("+parsedSlug");
		public static readonly KalturaFeedDropFolderFileOrderBy UPDATED_AT_ASC = new KalturaFeedDropFolderFileOrderBy("+updatedAt");
		public static readonly KalturaFeedDropFolderFileOrderBy CREATED_AT_DESC = new KalturaFeedDropFolderFileOrderBy("-createdAt");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_NAME_DESC = new KalturaFeedDropFolderFileOrderBy("-fileName");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_SIZE_DESC = new KalturaFeedDropFolderFileOrderBy("-fileSize");
		public static readonly KalturaFeedDropFolderFileOrderBy FILE_SIZE_LAST_SET_AT_DESC = new KalturaFeedDropFolderFileOrderBy("-fileSizeLastSetAt");
		public static readonly KalturaFeedDropFolderFileOrderBy ID_DESC = new KalturaFeedDropFolderFileOrderBy("-id");
		public static readonly KalturaFeedDropFolderFileOrderBy PARSED_FLAVOR_DESC = new KalturaFeedDropFolderFileOrderBy("-parsedFlavor");
		public static readonly KalturaFeedDropFolderFileOrderBy PARSED_SLUG_DESC = new KalturaFeedDropFolderFileOrderBy("-parsedSlug");
		public static readonly KalturaFeedDropFolderFileOrderBy UPDATED_AT_DESC = new KalturaFeedDropFolderFileOrderBy("-updatedAt");

		private KalturaFeedDropFolderFileOrderBy(string name) : base(name) { }
	}
}
