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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaDeliveryProfileType : KalturaStringEnum
	{
		public static readonly KalturaDeliveryProfileType EDGE_CAST_HTTP = new KalturaDeliveryProfileType("edgeCast.EDGE_CAST_HTTP");
		public static readonly KalturaDeliveryProfileType EDGE_CAST_RTMP = new KalturaDeliveryProfileType("edgeCast.EDGE_CAST_RTMP");
		public static readonly KalturaDeliveryProfileType KONTIKI_HTTP = new KalturaDeliveryProfileType("kontiki.KONTIKI_HTTP");
		public static readonly KalturaDeliveryProfileType VELOCIX_HDS = new KalturaDeliveryProfileType("velocix.VELOCIX_HDS");
		public static readonly KalturaDeliveryProfileType VELOCIX_HLS = new KalturaDeliveryProfileType("velocix.VELOCIX_HLS");
		public static readonly KalturaDeliveryProfileType APPLE_HTTP = new KalturaDeliveryProfileType("1");
		public static readonly KalturaDeliveryProfileType HDS = new KalturaDeliveryProfileType("3");
		public static readonly KalturaDeliveryProfileType HTTP = new KalturaDeliveryProfileType("4");
		public static readonly KalturaDeliveryProfileType RTMP = new KalturaDeliveryProfileType("5");
		public static readonly KalturaDeliveryProfileType RTSP = new KalturaDeliveryProfileType("6");
		public static readonly KalturaDeliveryProfileType SILVER_LIGHT = new KalturaDeliveryProfileType("7");
		public static readonly KalturaDeliveryProfileType AKAMAI_HLS_DIRECT = new KalturaDeliveryProfileType("10");
		public static readonly KalturaDeliveryProfileType AKAMAI_HLS_MANIFEST = new KalturaDeliveryProfileType("11");
		public static readonly KalturaDeliveryProfileType AKAMAI_HD = new KalturaDeliveryProfileType("12");
		public static readonly KalturaDeliveryProfileType AKAMAI_HDS = new KalturaDeliveryProfileType("13");
		public static readonly KalturaDeliveryProfileType AKAMAI_HTTP = new KalturaDeliveryProfileType("14");
		public static readonly KalturaDeliveryProfileType AKAMAI_RTMP = new KalturaDeliveryProfileType("15");
		public static readonly KalturaDeliveryProfileType AKAMAI_RTSP = new KalturaDeliveryProfileType("16");
		public static readonly KalturaDeliveryProfileType AKAMAI_SS = new KalturaDeliveryProfileType("17");
		public static readonly KalturaDeliveryProfileType GENERIC_HLS = new KalturaDeliveryProfileType("21");
		public static readonly KalturaDeliveryProfileType GENERIC_HDS = new KalturaDeliveryProfileType("23");
		public static readonly KalturaDeliveryProfileType GENERIC_HTTP = new KalturaDeliveryProfileType("24");
		public static readonly KalturaDeliveryProfileType GENERIC_HLS_MANIFEST = new KalturaDeliveryProfileType("25");
		public static readonly KalturaDeliveryProfileType GENERIC_HDS_MANIFEST = new KalturaDeliveryProfileType("26");
		public static readonly KalturaDeliveryProfileType GENERIC_SS = new KalturaDeliveryProfileType("27");
		public static readonly KalturaDeliveryProfileType GENERIC_RTMP = new KalturaDeliveryProfileType("28");
		public static readonly KalturaDeliveryProfileType LEVEL3_HLS = new KalturaDeliveryProfileType("31");
		public static readonly KalturaDeliveryProfileType LEVEL3_HTTP = new KalturaDeliveryProfileType("34");
		public static readonly KalturaDeliveryProfileType LEVEL3_RTMP = new KalturaDeliveryProfileType("35");
		public static readonly KalturaDeliveryProfileType LIMELIGHT_HTTP = new KalturaDeliveryProfileType("44");
		public static readonly KalturaDeliveryProfileType LIMELIGHT_RTMP = new KalturaDeliveryProfileType("45");
		public static readonly KalturaDeliveryProfileType LOCAL_PATH_APPLE_HTTP = new KalturaDeliveryProfileType("51");
		public static readonly KalturaDeliveryProfileType LOCAL_PATH_HDS = new KalturaDeliveryProfileType("53");
		public static readonly KalturaDeliveryProfileType LOCAL_PATH_HTTP = new KalturaDeliveryProfileType("54");
		public static readonly KalturaDeliveryProfileType LOCAL_PATH_RTMP = new KalturaDeliveryProfileType("55");
		public static readonly KalturaDeliveryProfileType VOD_PACKAGER_HLS = new KalturaDeliveryProfileType("61");
		public static readonly KalturaDeliveryProfileType VOD_PACKAGER_HDS = new KalturaDeliveryProfileType("63");
		public static readonly KalturaDeliveryProfileType VOD_PACKAGER_MSS = new KalturaDeliveryProfileType("67");
		public static readonly KalturaDeliveryProfileType VOD_PACKAGER_DASH = new KalturaDeliveryProfileType("68");
		public static readonly KalturaDeliveryProfileType LIVE_HLS = new KalturaDeliveryProfileType("1001");
		public static readonly KalturaDeliveryProfileType LIVE_HDS = new KalturaDeliveryProfileType("1002");
		public static readonly KalturaDeliveryProfileType LIVE_DASH = new KalturaDeliveryProfileType("1003");
		public static readonly KalturaDeliveryProfileType LIVE_RTMP = new KalturaDeliveryProfileType("1005");
		public static readonly KalturaDeliveryProfileType LIVE_HLS_TO_MULTICAST = new KalturaDeliveryProfileType("1006");
		public static readonly KalturaDeliveryProfileType LIVE_AKAMAI_HDS = new KalturaDeliveryProfileType("1013");

		private KalturaDeliveryProfileType(string name) : base(name) { }
	}
}
