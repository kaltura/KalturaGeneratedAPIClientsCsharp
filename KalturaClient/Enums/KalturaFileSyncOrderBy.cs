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
	public sealed class KalturaFileSyncOrderBy : KalturaStringEnum
	{
		public static readonly KalturaFileSyncOrderBy CREATED_AT_ASC = new KalturaFileSyncOrderBy("+createdAt");
		public static readonly KalturaFileSyncOrderBy FILE_SIZE_ASC = new KalturaFileSyncOrderBy("+fileSize");
		public static readonly KalturaFileSyncOrderBy READY_AT_ASC = new KalturaFileSyncOrderBy("+readyAt");
		public static readonly KalturaFileSyncOrderBy SYNC_TIME_ASC = new KalturaFileSyncOrderBy("+syncTime");
		public static readonly KalturaFileSyncOrderBy UPDATED_AT_ASC = new KalturaFileSyncOrderBy("+updatedAt");
		public static readonly KalturaFileSyncOrderBy VERSION_ASC = new KalturaFileSyncOrderBy("+version");
		public static readonly KalturaFileSyncOrderBy CREATED_AT_DESC = new KalturaFileSyncOrderBy("-createdAt");
		public static readonly KalturaFileSyncOrderBy FILE_SIZE_DESC = new KalturaFileSyncOrderBy("-fileSize");
		public static readonly KalturaFileSyncOrderBy READY_AT_DESC = new KalturaFileSyncOrderBy("-readyAt");
		public static readonly KalturaFileSyncOrderBy SYNC_TIME_DESC = new KalturaFileSyncOrderBy("-syncTime");
		public static readonly KalturaFileSyncOrderBy UPDATED_AT_DESC = new KalturaFileSyncOrderBy("-updatedAt");
		public static readonly KalturaFileSyncOrderBy VERSION_DESC = new KalturaFileSyncOrderBy("-version");

		private KalturaFileSyncOrderBy(string name) : base(name) { }
	}
}
