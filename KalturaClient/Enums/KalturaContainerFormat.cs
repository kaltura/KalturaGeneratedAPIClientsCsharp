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
	public sealed class KalturaContainerFormat : KalturaStringEnum
	{
		public static readonly KalturaContainerFormat _3GP = new KalturaContainerFormat("3gp");
		public static readonly KalturaContainerFormat APPLEHTTP = new KalturaContainerFormat("applehttp");
		public static readonly KalturaContainerFormat AVI = new KalturaContainerFormat("avi");
		public static readonly KalturaContainerFormat BMP = new KalturaContainerFormat("bmp");
		public static readonly KalturaContainerFormat COPY = new KalturaContainerFormat("copy");
		public static readonly KalturaContainerFormat FLV = new KalturaContainerFormat("flv");
		public static readonly KalturaContainerFormat HLS = new KalturaContainerFormat("hls");
		public static readonly KalturaContainerFormat ISMA = new KalturaContainerFormat("isma");
		public static readonly KalturaContainerFormat ISMV = new KalturaContainerFormat("ismv");
		public static readonly KalturaContainerFormat JPG = new KalturaContainerFormat("jpg");
		public static readonly KalturaContainerFormat M2TS = new KalturaContainerFormat("m2ts");
		public static readonly KalturaContainerFormat M4V = new KalturaContainerFormat("m4v");
		public static readonly KalturaContainerFormat MKV = new KalturaContainerFormat("mkv");
		public static readonly KalturaContainerFormat MOV = new KalturaContainerFormat("mov");
		public static readonly KalturaContainerFormat MP3 = new KalturaContainerFormat("mp3");
		public static readonly KalturaContainerFormat MP4 = new KalturaContainerFormat("mp4");
		public static readonly KalturaContainerFormat MPEG = new KalturaContainerFormat("mpeg");
		public static readonly KalturaContainerFormat MPEGTS = new KalturaContainerFormat("mpegts");
		public static readonly KalturaContainerFormat MXF = new KalturaContainerFormat("mxf");
		public static readonly KalturaContainerFormat OGG = new KalturaContainerFormat("ogg");
		public static readonly KalturaContainerFormat OGV = new KalturaContainerFormat("ogv");
		public static readonly KalturaContainerFormat PDF = new KalturaContainerFormat("pdf");
		public static readonly KalturaContainerFormat PNG = new KalturaContainerFormat("png");
		public static readonly KalturaContainerFormat SWF = new KalturaContainerFormat("swf");
		public static readonly KalturaContainerFormat WAV = new KalturaContainerFormat("wav");
		public static readonly KalturaContainerFormat WEBM = new KalturaContainerFormat("webm");
		public static readonly KalturaContainerFormat WMA = new KalturaContainerFormat("wma");
		public static readonly KalturaContainerFormat WMV = new KalturaContainerFormat("wmv");
		public static readonly KalturaContainerFormat WVM = new KalturaContainerFormat("wvm");

		private KalturaContainerFormat(string name) : base(name) { }
	}
}
