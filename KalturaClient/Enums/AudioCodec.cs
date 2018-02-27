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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public sealed class AudioCodec : StringEnum
	{
		public static readonly AudioCodec NONE = new AudioCodec("");
		public static readonly AudioCodec AAC = new AudioCodec("aac");
		public static readonly AudioCodec AACHE = new AudioCodec("aache");
		public static readonly AudioCodec AC3 = new AudioCodec("ac3");
		public static readonly AudioCodec AMRNB = new AudioCodec("amrnb");
		public static readonly AudioCodec COPY = new AudioCodec("copy");
		public static readonly AudioCodec EAC3 = new AudioCodec("eac3");
		public static readonly AudioCodec MP3 = new AudioCodec("mp3");
		public static readonly AudioCodec MPEG2 = new AudioCodec("mpeg2");
		public static readonly AudioCodec PCM = new AudioCodec("pcm");
		public static readonly AudioCodec VORBIS = new AudioCodec("vorbis");
		public static readonly AudioCodec WMA = new AudioCodec("wma");
		public static readonly AudioCodec WMAPRO = new AudioCodec("wmapro");

		private AudioCodec(string name) : base(name) { }
	}
}
