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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class AssetOrderBy : StringEnum
	{
		public static readonly AssetOrderBy CREATED_AT_ASC = new AssetOrderBy("+createdAt");
		public static readonly AssetOrderBy DELETED_AT_ASC = new AssetOrderBy("+deletedAt");
		public static readonly AssetOrderBy SIZE_ASC = new AssetOrderBy("+size");
		public static readonly AssetOrderBy UPDATED_AT_ASC = new AssetOrderBy("+updatedAt");
		public static readonly AssetOrderBy CREATED_AT_DESC = new AssetOrderBy("-createdAt");
		public static readonly AssetOrderBy DELETED_AT_DESC = new AssetOrderBy("-deletedAt");
		public static readonly AssetOrderBy SIZE_DESC = new AssetOrderBy("-size");
		public static readonly AssetOrderBy UPDATED_AT_DESC = new AssetOrderBy("-updatedAt");

		private AssetOrderBy(string name) : base(name) { }
	}
}
