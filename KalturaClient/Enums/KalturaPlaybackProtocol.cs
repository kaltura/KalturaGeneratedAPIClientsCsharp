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
	public sealed class KalturaPlaybackProtocol : KalturaStringEnum
	{
		public static readonly KalturaPlaybackProtocol APPLE_HTTP = new KalturaPlaybackProtocol("applehttp");
		public static readonly KalturaPlaybackProtocol AUTO = new KalturaPlaybackProtocol("auto");
		public static readonly KalturaPlaybackProtocol AKAMAI_HD = new KalturaPlaybackProtocol("hdnetwork");
		public static readonly KalturaPlaybackProtocol AKAMAI_HDS = new KalturaPlaybackProtocol("hdnetworkmanifest");
		public static readonly KalturaPlaybackProtocol HDS = new KalturaPlaybackProtocol("hds");
		public static readonly KalturaPlaybackProtocol HLS = new KalturaPlaybackProtocol("hls");
		public static readonly KalturaPlaybackProtocol HTTP = new KalturaPlaybackProtocol("http");
		public static readonly KalturaPlaybackProtocol MPEG_DASH = new KalturaPlaybackProtocol("mpegdash");
		public static readonly KalturaPlaybackProtocol MULTICAST_SL = new KalturaPlaybackProtocol("multicast_silverlight");
		public static readonly KalturaPlaybackProtocol RTMP = new KalturaPlaybackProtocol("rtmp");
		public static readonly KalturaPlaybackProtocol RTSP = new KalturaPlaybackProtocol("rtsp");
		public static readonly KalturaPlaybackProtocol SILVER_LIGHT = new KalturaPlaybackProtocol("sl");

		private KalturaPlaybackProtocol(string name) : base(name) { }
	}
}
