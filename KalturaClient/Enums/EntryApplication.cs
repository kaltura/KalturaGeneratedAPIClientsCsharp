// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class EntryApplication : StringEnum
	{
		public static readonly EntryApplication KMC = new EntryApplication("0");
		public static readonly EntryApplication KMS = new EntryApplication("1");
		public static readonly EntryApplication KAF = new EntryApplication("2");
		public static readonly EntryApplication PITCH = new EntryApplication("3");
		public static readonly EntryApplication KMS_GO = new EntryApplication("4");
		public static readonly EntryApplication WEBCAST_APP = new EntryApplication("5");
		public static readonly EntryApplication PERSONAL_CAPTURE = new EntryApplication("6");
		public static readonly EntryApplication KALTURA_MEETING = new EntryApplication("7");

		private EntryApplication(string name) : base(name) { }
	}
}
