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
	public sealed class KalturaRemoteDropFolderOrderBy : KalturaStringEnum
	{
		public static readonly KalturaRemoteDropFolderOrderBy CREATED_AT_ASC = new KalturaRemoteDropFolderOrderBy("+createdAt");
		public static readonly KalturaRemoteDropFolderOrderBy ID_ASC = new KalturaRemoteDropFolderOrderBy("+id");
		public static readonly KalturaRemoteDropFolderOrderBy NAME_ASC = new KalturaRemoteDropFolderOrderBy("+name");
		public static readonly KalturaRemoteDropFolderOrderBy UPDATED_AT_ASC = new KalturaRemoteDropFolderOrderBy("+updatedAt");
		public static readonly KalturaRemoteDropFolderOrderBy CREATED_AT_DESC = new KalturaRemoteDropFolderOrderBy("-createdAt");
		public static readonly KalturaRemoteDropFolderOrderBy ID_DESC = new KalturaRemoteDropFolderOrderBy("-id");
		public static readonly KalturaRemoteDropFolderOrderBy NAME_DESC = new KalturaRemoteDropFolderOrderBy("-name");
		public static readonly KalturaRemoteDropFolderOrderBy UPDATED_AT_DESC = new KalturaRemoteDropFolderOrderBy("-updatedAt");

		private KalturaRemoteDropFolderOrderBy(string name) : base(name) { }
	}
}
