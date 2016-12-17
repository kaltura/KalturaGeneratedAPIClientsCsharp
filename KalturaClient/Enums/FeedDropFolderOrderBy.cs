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
namespace Kaltura.Enums
{
	public sealed class FeedDropFolderOrderBy : StringEnum
	{
		public static readonly FeedDropFolderOrderBy CREATED_AT_ASC = new FeedDropFolderOrderBy("+createdAt");
		public static readonly FeedDropFolderOrderBy ID_ASC = new FeedDropFolderOrderBy("+id");
		public static readonly FeedDropFolderOrderBy NAME_ASC = new FeedDropFolderOrderBy("+name");
		public static readonly FeedDropFolderOrderBy UPDATED_AT_ASC = new FeedDropFolderOrderBy("+updatedAt");
		public static readonly FeedDropFolderOrderBy CREATED_AT_DESC = new FeedDropFolderOrderBy("-createdAt");
		public static readonly FeedDropFolderOrderBy ID_DESC = new FeedDropFolderOrderBy("-id");
		public static readonly FeedDropFolderOrderBy NAME_DESC = new FeedDropFolderOrderBy("-name");
		public static readonly FeedDropFolderOrderBy UPDATED_AT_DESC = new FeedDropFolderOrderBy("-updatedAt");

		private FeedDropFolderOrderBy(string name) : base(name) { }
	}
}
