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
	public sealed class FileSyncOrderBy : StringEnum
	{
		public static readonly FileSyncOrderBy CREATED_AT_ASC = new FileSyncOrderBy("+createdAt");
		public static readonly FileSyncOrderBy FILE_SIZE_ASC = new FileSyncOrderBy("+fileSize");
		public static readonly FileSyncOrderBy READY_AT_ASC = new FileSyncOrderBy("+readyAt");
		public static readonly FileSyncOrderBy SYNC_TIME_ASC = new FileSyncOrderBy("+syncTime");
		public static readonly FileSyncOrderBy UPDATED_AT_ASC = new FileSyncOrderBy("+updatedAt");
		public static readonly FileSyncOrderBy VERSION_ASC = new FileSyncOrderBy("+version");
		public static readonly FileSyncOrderBy CREATED_AT_DESC = new FileSyncOrderBy("-createdAt");
		public static readonly FileSyncOrderBy FILE_SIZE_DESC = new FileSyncOrderBy("-fileSize");
		public static readonly FileSyncOrderBy READY_AT_DESC = new FileSyncOrderBy("-readyAt");
		public static readonly FileSyncOrderBy SYNC_TIME_DESC = new FileSyncOrderBy("-syncTime");
		public static readonly FileSyncOrderBy UPDATED_AT_DESC = new FileSyncOrderBy("-updatedAt");
		public static readonly FileSyncOrderBy VERSION_DESC = new FileSyncOrderBy("-version");

		private FileSyncOrderBy(string name) : base(name) { }
	}
}
