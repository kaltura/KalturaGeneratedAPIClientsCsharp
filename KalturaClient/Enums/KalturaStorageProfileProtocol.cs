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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaStorageProfileProtocol : KalturaStringEnum
	{
		public static readonly KalturaStorageProfileProtocol KONTIKI = new KalturaStorageProfileProtocol("kontiki.KONTIKI");
		public static readonly KalturaStorageProfileProtocol KALTURA_DC = new KalturaStorageProfileProtocol("0");
		public static readonly KalturaStorageProfileProtocol FTP = new KalturaStorageProfileProtocol("1");
		public static readonly KalturaStorageProfileProtocol SCP = new KalturaStorageProfileProtocol("2");
		public static readonly KalturaStorageProfileProtocol SFTP = new KalturaStorageProfileProtocol("3");
		public static readonly KalturaStorageProfileProtocol S3 = new KalturaStorageProfileProtocol("6");
		public static readonly KalturaStorageProfileProtocol LOCAL = new KalturaStorageProfileProtocol("7");

		private KalturaStorageProfileProtocol(string name) : base(name) { }
	}
}
