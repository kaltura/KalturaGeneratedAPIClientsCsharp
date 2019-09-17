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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class DropFolderType : StringEnum
	{
		public static readonly DropFolderType FEED = new DropFolderType("FeedDropFolder.FEED");
		public static readonly DropFolderType TR_RDS_COMPANY = new DropFolderType("TrRdsSyncDropFolder.TR_RDS_COMPANY");
		public static readonly DropFolderType TR_RDS_TMCTERM = new DropFolderType("TrRdsSyncDropFolder.TR_RDS_TMCTERM");
		public static readonly DropFolderType WEBEX = new DropFolderType("WebexDropFolder.WEBEX");
		public static readonly DropFolderType LOCAL = new DropFolderType("1");
		public static readonly DropFolderType FTP = new DropFolderType("2");
		public static readonly DropFolderType SCP = new DropFolderType("3");
		public static readonly DropFolderType SFTP = new DropFolderType("4");
		public static readonly DropFolderType S3 = new DropFolderType("6");

		private DropFolderType(string name) : base(name) { }
	}
}
