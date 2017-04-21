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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class EntryStatus : StringEnum
	{
		public static readonly EntryStatus ERROR_IMPORTING = new EntryStatus("-2");
		public static readonly EntryStatus ERROR_CONVERTING = new EntryStatus("-1");
		public static readonly EntryStatus SCAN_FAILURE = new EntryStatus("virusScan.ScanFailure");
		public static readonly EntryStatus IMPORT = new EntryStatus("0");
		public static readonly EntryStatus INFECTED = new EntryStatus("virusScan.Infected");
		public static readonly EntryStatus PRECONVERT = new EntryStatus("1");
		public static readonly EntryStatus READY = new EntryStatus("2");
		public static readonly EntryStatus DELETED = new EntryStatus("3");
		public static readonly EntryStatus PENDING = new EntryStatus("4");
		public static readonly EntryStatus MODERATE = new EntryStatus("5");
		public static readonly EntryStatus BLOCKED = new EntryStatus("6");
		public static readonly EntryStatus NO_CONTENT = new EntryStatus("7");

		private EntryStatus(string name) : base(name) { }
	}
}
