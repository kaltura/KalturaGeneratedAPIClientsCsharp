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
	public sealed class WebexDropFolderOrderBy : StringEnum
	{
		public static readonly WebexDropFolderOrderBy CREATED_AT_ASC = new WebexDropFolderOrderBy("+createdAt");
		public static readonly WebexDropFolderOrderBy ID_ASC = new WebexDropFolderOrderBy("+id");
		public static readonly WebexDropFolderOrderBy NAME_ASC = new WebexDropFolderOrderBy("+name");
		public static readonly WebexDropFolderOrderBy UPDATED_AT_ASC = new WebexDropFolderOrderBy("+updatedAt");
		public static readonly WebexDropFolderOrderBy CREATED_AT_DESC = new WebexDropFolderOrderBy("-createdAt");
		public static readonly WebexDropFolderOrderBy ID_DESC = new WebexDropFolderOrderBy("-id");
		public static readonly WebexDropFolderOrderBy NAME_DESC = new WebexDropFolderOrderBy("-name");
		public static readonly WebexDropFolderOrderBy UPDATED_AT_DESC = new WebexDropFolderOrderBy("-updatedAt");

		private WebexDropFolderOrderBy(string name) : base(name) { }
	}
}
