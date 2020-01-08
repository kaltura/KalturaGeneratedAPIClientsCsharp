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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class LiveAssetOrderBy : StringEnum
	{
		public static readonly LiveAssetOrderBy CREATED_AT_ASC = new LiveAssetOrderBy("+createdAt");
		public static readonly LiveAssetOrderBy DELETED_AT_ASC = new LiveAssetOrderBy("+deletedAt");
		public static readonly LiveAssetOrderBy SIZE_ASC = new LiveAssetOrderBy("+size");
		public static readonly LiveAssetOrderBy UPDATED_AT_ASC = new LiveAssetOrderBy("+updatedAt");
		public static readonly LiveAssetOrderBy CREATED_AT_DESC = new LiveAssetOrderBy("-createdAt");
		public static readonly LiveAssetOrderBy DELETED_AT_DESC = new LiveAssetOrderBy("-deletedAt");
		public static readonly LiveAssetOrderBy SIZE_DESC = new LiveAssetOrderBy("-size");
		public static readonly LiveAssetOrderBy UPDATED_AT_DESC = new LiveAssetOrderBy("-updatedAt");

		private LiveAssetOrderBy(string name) : base(name) { }
	}
}
