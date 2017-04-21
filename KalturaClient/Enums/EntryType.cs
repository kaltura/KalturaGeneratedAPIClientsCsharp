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
	public sealed class EntryType : StringEnum
	{
		public static readonly EntryType AUTOMATIC = new EntryType("-1");
		public static readonly EntryType EXTERNAL_MEDIA = new EntryType("externalMedia.externalMedia");
		public static readonly EntryType MEDIA_CLIP = new EntryType("1");
		public static readonly EntryType MIX = new EntryType("2");
		public static readonly EntryType PLAYLIST = new EntryType("5");
		public static readonly EntryType DATA = new EntryType("6");
		public static readonly EntryType LIVE_STREAM = new EntryType("7");
		public static readonly EntryType LIVE_CHANNEL = new EntryType("8");
		public static readonly EntryType DOCUMENT = new EntryType("10");

		private EntryType(string name) : base(name) { }
	}
}
