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
	public sealed class KalturaDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaDropFolderOrderBy CREATED_AT_ASC = new KalturaDropFolderOrderBy("+createdAt");
		public static readonly KalturaDropFolderOrderBy ID_ASC = new KalturaDropFolderOrderBy("+id");
		public static readonly KalturaDropFolderOrderBy NAME_ASC = new KalturaDropFolderOrderBy("+name");
		public static readonly KalturaDropFolderOrderBy UPDATED_AT_ASC = new KalturaDropFolderOrderBy("+updatedAt");
		public static readonly KalturaDropFolderOrderBy CREATED_AT_DESC = new KalturaDropFolderOrderBy("-createdAt");
		public static readonly KalturaDropFolderOrderBy ID_DESC = new KalturaDropFolderOrderBy("-id");
		public static readonly KalturaDropFolderOrderBy NAME_DESC = new KalturaDropFolderOrderBy("-name");
		public static readonly KalturaDropFolderOrderBy UPDATED_AT_DESC = new KalturaDropFolderOrderBy("-updatedAt");

		private KalturaDropFolderOrderBy(string name) : base(name) { }
	}
}
