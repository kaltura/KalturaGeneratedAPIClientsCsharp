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
	public sealed class KalturaDropFolderErrorCode : KalturaStringEnum
	{
		public static readonly KalturaDropFolderErrorCode ERROR_CONNECT = new KalturaDropFolderErrorCode("1");
		public static readonly KalturaDropFolderErrorCode ERROR_AUTENTICATE = new KalturaDropFolderErrorCode("2");
		public static readonly KalturaDropFolderErrorCode ERROR_GET_PHISICAL_FILE_LIST = new KalturaDropFolderErrorCode("3");
		public static readonly KalturaDropFolderErrorCode ERROR_GET_DB_FILE_LIST = new KalturaDropFolderErrorCode("4");
		public static readonly KalturaDropFolderErrorCode DROP_FOLDER_APP_ERROR = new KalturaDropFolderErrorCode("5");
		public static readonly KalturaDropFolderErrorCode CONTENT_MATCH_POLICY_UNDEFINED = new KalturaDropFolderErrorCode("6");

		private KalturaDropFolderErrorCode(string name) : base(name) { }
	}
}
