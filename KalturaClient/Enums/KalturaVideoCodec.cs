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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public sealed class KalturaVideoCodec : KalturaStringEnum
	{
		public static readonly KalturaVideoCodec NONE = new KalturaVideoCodec("");
		public static readonly KalturaVideoCodec APCH = new KalturaVideoCodec("apch");
		public static readonly KalturaVideoCodec APCN = new KalturaVideoCodec("apcn");
		public static readonly KalturaVideoCodec APCO = new KalturaVideoCodec("apco");
		public static readonly KalturaVideoCodec APCS = new KalturaVideoCodec("apcs");
		public static readonly KalturaVideoCodec COPY = new KalturaVideoCodec("copy");
		public static readonly KalturaVideoCodec DNXHD = new KalturaVideoCodec("dnxhd");
		public static readonly KalturaVideoCodec DV = new KalturaVideoCodec("dv");
		public static readonly KalturaVideoCodec FLV = new KalturaVideoCodec("flv");
		public static readonly KalturaVideoCodec H263 = new KalturaVideoCodec("h263");
		public static readonly KalturaVideoCodec H264 = new KalturaVideoCodec("h264");
		public static readonly KalturaVideoCodec H264B = new KalturaVideoCodec("h264b");
		public static readonly KalturaVideoCodec H264H = new KalturaVideoCodec("h264h");
		public static readonly KalturaVideoCodec H264M = new KalturaVideoCodec("h264m");
		public static readonly KalturaVideoCodec H265 = new KalturaVideoCodec("h265");
		public static readonly KalturaVideoCodec MPEG2 = new KalturaVideoCodec("mpeg2");
		public static readonly KalturaVideoCodec MPEG4 = new KalturaVideoCodec("mpeg4");
		public static readonly KalturaVideoCodec THEORA = new KalturaVideoCodec("theora");
		public static readonly KalturaVideoCodec VP6 = new KalturaVideoCodec("vp6");
		public static readonly KalturaVideoCodec VP8 = new KalturaVideoCodec("vp8");
		public static readonly KalturaVideoCodec VP9 = new KalturaVideoCodec("vp9");
		public static readonly KalturaVideoCodec WMV2 = new KalturaVideoCodec("wmv2");
		public static readonly KalturaVideoCodec WMV3 = new KalturaVideoCodec("wmv3");
		public static readonly KalturaVideoCodec WVC1A = new KalturaVideoCodec("wvc1a");

		private KalturaVideoCodec(string name) : base(name) { }
	}
}
