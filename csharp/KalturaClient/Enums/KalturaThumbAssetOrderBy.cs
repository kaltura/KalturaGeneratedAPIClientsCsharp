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
	public sealed class KalturaThumbAssetOrderBy : KalturaStringEnum
	{
		public static readonly KalturaThumbAssetOrderBy CREATED_AT_ASC = new KalturaThumbAssetOrderBy("+createdAt");
		public static readonly KalturaThumbAssetOrderBy DELETED_AT_ASC = new KalturaThumbAssetOrderBy("+deletedAt");
		public static readonly KalturaThumbAssetOrderBy SIZE_ASC = new KalturaThumbAssetOrderBy("+size");
		public static readonly KalturaThumbAssetOrderBy UPDATED_AT_ASC = new KalturaThumbAssetOrderBy("+updatedAt");
		public static readonly KalturaThumbAssetOrderBy CREATED_AT_DESC = new KalturaThumbAssetOrderBy("-createdAt");
		public static readonly KalturaThumbAssetOrderBy DELETED_AT_DESC = new KalturaThumbAssetOrderBy("-deletedAt");
		public static readonly KalturaThumbAssetOrderBy SIZE_DESC = new KalturaThumbAssetOrderBy("-size");
		public static readonly KalturaThumbAssetOrderBy UPDATED_AT_DESC = new KalturaThumbAssetOrderBy("-updatedAt");

		private KalturaThumbAssetOrderBy(string name) : base(name) { }
	}
}
