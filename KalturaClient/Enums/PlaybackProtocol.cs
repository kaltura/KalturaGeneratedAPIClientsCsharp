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
	public sealed class PlaybackProtocol : StringEnum
	{
		public static readonly PlaybackProtocol APPLE_HTTP = new PlaybackProtocol("applehttp");
		public static readonly PlaybackProtocol APPLE_HTTP_TO_MC = new PlaybackProtocol("applehttp_to_mc");
		public static readonly PlaybackProtocol AUTO = new PlaybackProtocol("auto");
		public static readonly PlaybackProtocol DOWNLOAD = new PlaybackProtocol("download");
		public static readonly PlaybackProtocol AKAMAI_HD = new PlaybackProtocol("hdnetwork");
		public static readonly PlaybackProtocol AKAMAI_HDS = new PlaybackProtocol("hdnetworkmanifest");
		public static readonly PlaybackProtocol HDS = new PlaybackProtocol("hds");
		public static readonly PlaybackProtocol HLS = new PlaybackProtocol("hls");
		public static readonly PlaybackProtocol HTTP = new PlaybackProtocol("http");
		public static readonly PlaybackProtocol MPEG_DASH = new PlaybackProtocol("mpegdash");
		public static readonly PlaybackProtocol MULTICAST_SL = new PlaybackProtocol("multicast_silverlight");
		public static readonly PlaybackProtocol RTMP = new PlaybackProtocol("rtmp");
		public static readonly PlaybackProtocol RTSP = new PlaybackProtocol("rtsp");
		public static readonly PlaybackProtocol SILVER_LIGHT = new PlaybackProtocol("sl");
		public static readonly PlaybackProtocol URL = new PlaybackProtocol("url");

		private PlaybackProtocol(string name) : base(name) { }
	}
}
