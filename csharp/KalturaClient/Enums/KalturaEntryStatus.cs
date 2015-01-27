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
	public sealed class KalturaEntryStatus : KalturaStringEnum
	{
		public static readonly KalturaEntryStatus ERROR_IMPORTING = new KalturaEntryStatus("-2");
		public static readonly KalturaEntryStatus ERROR_CONVERTING = new KalturaEntryStatus("-1");
		public static readonly KalturaEntryStatus SCAN_FAILURE = new KalturaEntryStatus("virusScan.ScanFailure");
		public static readonly KalturaEntryStatus IMPORT = new KalturaEntryStatus("0");
		public static readonly KalturaEntryStatus INFECTED = new KalturaEntryStatus("virusScan.Infected");
		public static readonly KalturaEntryStatus PRECONVERT = new KalturaEntryStatus("1");
		public static readonly KalturaEntryStatus READY = new KalturaEntryStatus("2");
		public static readonly KalturaEntryStatus DELETED = new KalturaEntryStatus("3");
		public static readonly KalturaEntryStatus PENDING = new KalturaEntryStatus("4");
		public static readonly KalturaEntryStatus MODERATE = new KalturaEntryStatus("5");
		public static readonly KalturaEntryStatus BLOCKED = new KalturaEntryStatus("6");
		public static readonly KalturaEntryStatus NO_CONTENT = new KalturaEntryStatus("7");

		private KalturaEntryStatus(string name) : base(name) { }
	}
}
