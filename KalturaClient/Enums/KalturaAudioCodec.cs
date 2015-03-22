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
	public sealed class KalturaAudioCodec : KalturaStringEnum
	{
		public static readonly KalturaAudioCodec NONE = new KalturaAudioCodec("");
		public static readonly KalturaAudioCodec AAC = new KalturaAudioCodec("aac");
		public static readonly KalturaAudioCodec AACHE = new KalturaAudioCodec("aache");
		public static readonly KalturaAudioCodec AC3 = new KalturaAudioCodec("ac3");
		public static readonly KalturaAudioCodec AMRNB = new KalturaAudioCodec("amrnb");
		public static readonly KalturaAudioCodec COPY = new KalturaAudioCodec("copy");
		public static readonly KalturaAudioCodec MP3 = new KalturaAudioCodec("mp3");
		public static readonly KalturaAudioCodec MPEG2 = new KalturaAudioCodec("mpeg2");
		public static readonly KalturaAudioCodec PCM = new KalturaAudioCodec("pcm");
		public static readonly KalturaAudioCodec VORBIS = new KalturaAudioCodec("vorbis");
		public static readonly KalturaAudioCodec WMA = new KalturaAudioCodec("wma");
		public static readonly KalturaAudioCodec WMAPRO = new KalturaAudioCodec("wmapro");

		private KalturaAudioCodec(string name) : base(name) { }
	}
}
