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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class ContainerFormat : StringEnum
	{
		public static readonly ContainerFormat _3GP = new ContainerFormat("3gp");
		public static readonly ContainerFormat APPLEHTTP = new ContainerFormat("applehttp");
		public static readonly ContainerFormat AVI = new ContainerFormat("avi");
		public static readonly ContainerFormat BIF = new ContainerFormat("bif");
		public static readonly ContainerFormat BMP = new ContainerFormat("bmp");
		public static readonly ContainerFormat COPY = new ContainerFormat("copy");
		public static readonly ContainerFormat FLV = new ContainerFormat("flv");
		public static readonly ContainerFormat HLS = new ContainerFormat("hls");
		public static readonly ContainerFormat ISMA = new ContainerFormat("isma");
		public static readonly ContainerFormat ISMV = new ContainerFormat("ismv");
		public static readonly ContainerFormat JPG = new ContainerFormat("jpg");
		public static readonly ContainerFormat M2TS = new ContainerFormat("m2ts");
		public static readonly ContainerFormat M4V = new ContainerFormat("m4v");
		public static readonly ContainerFormat MKV = new ContainerFormat("mkv");
		public static readonly ContainerFormat MOV = new ContainerFormat("mov");
		public static readonly ContainerFormat MP3 = new ContainerFormat("mp3");
		public static readonly ContainerFormat MP4 = new ContainerFormat("mp4");
		public static readonly ContainerFormat MPEG = new ContainerFormat("mpeg");
		public static readonly ContainerFormat MPEGTS = new ContainerFormat("mpegts");
		public static readonly ContainerFormat MXF = new ContainerFormat("mxf");
		public static readonly ContainerFormat OGG = new ContainerFormat("ogg");
		public static readonly ContainerFormat OGV = new ContainerFormat("ogv");
		public static readonly ContainerFormat PDF = new ContainerFormat("pdf");
		public static readonly ContainerFormat PNG = new ContainerFormat("png");
		public static readonly ContainerFormat SWF = new ContainerFormat("swf");
		public static readonly ContainerFormat WAV = new ContainerFormat("wav");
		public static readonly ContainerFormat WEBM = new ContainerFormat("webm");
		public static readonly ContainerFormat WMA = new ContainerFormat("wma");
		public static readonly ContainerFormat WMV = new ContainerFormat("wmv");
		public static readonly ContainerFormat WVM = new ContainerFormat("wvm");

		private ContainerFormat(string name) : base(name) { }
	}
}
