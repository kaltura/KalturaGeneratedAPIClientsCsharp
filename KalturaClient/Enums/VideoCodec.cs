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
	public sealed class VideoCodec : StringEnum
	{
		public static readonly VideoCodec NONE = new VideoCodec("");
		public static readonly VideoCodec APCH = new VideoCodec("apch");
		public static readonly VideoCodec APCN = new VideoCodec("apcn");
		public static readonly VideoCodec APCO = new VideoCodec("apco");
		public static readonly VideoCodec APCS = new VideoCodec("apcs");
		public static readonly VideoCodec AV1 = new VideoCodec("av1");
		public static readonly VideoCodec COPY = new VideoCodec("copy");
		public static readonly VideoCodec DNXHD = new VideoCodec("dnxhd");
		public static readonly VideoCodec DV = new VideoCodec("dv");
		public static readonly VideoCodec FLV = new VideoCodec("flv");
		public static readonly VideoCodec H263 = new VideoCodec("h263");
		public static readonly VideoCodec H264 = new VideoCodec("h264");
		public static readonly VideoCodec H264B = new VideoCodec("h264b");
		public static readonly VideoCodec H264H = new VideoCodec("h264h");
		public static readonly VideoCodec H264M = new VideoCodec("h264m");
		public static readonly VideoCodec H265 = new VideoCodec("h265");
		public static readonly VideoCodec MPEG2 = new VideoCodec("mpeg2");
		public static readonly VideoCodec MPEG4 = new VideoCodec("mpeg4");
		public static readonly VideoCodec THEORA = new VideoCodec("theora");
		public static readonly VideoCodec VP6 = new VideoCodec("vp6");
		public static readonly VideoCodec VP8 = new VideoCodec("vp8");
		public static readonly VideoCodec VP9 = new VideoCodec("vp9");
		public static readonly VideoCodec WMV2 = new VideoCodec("wmv2");
		public static readonly VideoCodec WMV3 = new VideoCodec("wmv3");
		public static readonly VideoCodec WVC1A = new VideoCodec("wvc1a");

		private VideoCodec(string name) : base(name) { }
	}
}
