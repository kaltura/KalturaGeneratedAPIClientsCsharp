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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public sealed class KalturaWidevineFlavorAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaWidevineFlavorAssetOrderBy CREATED_AT_ASC = new KalturaWidevineFlavorAssetOrderBy("+createdAt");
		public static readonly KalturaWidevineFlavorAssetOrderBy DELETED_AT_ASC = new KalturaWidevineFlavorAssetOrderBy("+deletedAt");
		public static readonly KalturaWidevineFlavorAssetOrderBy SIZE_ASC = new KalturaWidevineFlavorAssetOrderBy("+size");
		public static readonly KalturaWidevineFlavorAssetOrderBy UPDATED_AT_ASC = new KalturaWidevineFlavorAssetOrderBy("+updatedAt");
		public static readonly KalturaWidevineFlavorAssetOrderBy CREATED_AT_DESC = new KalturaWidevineFlavorAssetOrderBy("-createdAt");
		public static readonly KalturaWidevineFlavorAssetOrderBy DELETED_AT_DESC = new KalturaWidevineFlavorAssetOrderBy("-deletedAt");
		public static readonly KalturaWidevineFlavorAssetOrderBy SIZE_DESC = new KalturaWidevineFlavorAssetOrderBy("-size");
		public static readonly KalturaWidevineFlavorAssetOrderBy UPDATED_AT_DESC = new KalturaWidevineFlavorAssetOrderBy("-updatedAt");

		private KalturaWidevineFlavorAssetOrderBy(string name) : base(name) { }
	}
}
