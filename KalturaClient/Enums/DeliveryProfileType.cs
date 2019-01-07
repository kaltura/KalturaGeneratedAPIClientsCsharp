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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class DeliveryProfileType : StringEnum
	{
		public static readonly DeliveryProfileType EDGE_CAST_HTTP = new DeliveryProfileType("edgeCast.EDGE_CAST_HTTP");
		public static readonly DeliveryProfileType EDGE_CAST_RTMP = new DeliveryProfileType("edgeCast.EDGE_CAST_RTMP");
		public static readonly DeliveryProfileType KONTIKI_HTTP = new DeliveryProfileType("kontiki.KONTIKI_HTTP");
		public static readonly DeliveryProfileType VELOCIX_HDS = new DeliveryProfileType("velocix.VELOCIX_HDS");
		public static readonly DeliveryProfileType VELOCIX_HLS = new DeliveryProfileType("velocix.VELOCIX_HLS");
		public static readonly DeliveryProfileType APPLE_HTTP = new DeliveryProfileType("1");
		public static readonly DeliveryProfileType HDS = new DeliveryProfileType("3");
		public static readonly DeliveryProfileType HTTP = new DeliveryProfileType("4");
		public static readonly DeliveryProfileType RTMP = new DeliveryProfileType("5");
		public static readonly DeliveryProfileType RTSP = new DeliveryProfileType("6");
		public static readonly DeliveryProfileType SILVER_LIGHT = new DeliveryProfileType("7");
		public static readonly DeliveryProfileType AKAMAI_HLS_DIRECT = new DeliveryProfileType("10");
		public static readonly DeliveryProfileType AKAMAI_HLS_MANIFEST = new DeliveryProfileType("11");
		public static readonly DeliveryProfileType AKAMAI_HD = new DeliveryProfileType("12");
		public static readonly DeliveryProfileType AKAMAI_HDS = new DeliveryProfileType("13");
		public static readonly DeliveryProfileType AKAMAI_HTTP = new DeliveryProfileType("14");
		public static readonly DeliveryProfileType AKAMAI_RTMP = new DeliveryProfileType("15");
		public static readonly DeliveryProfileType AKAMAI_RTSP = new DeliveryProfileType("16");
		public static readonly DeliveryProfileType AKAMAI_SS = new DeliveryProfileType("17");
		public static readonly DeliveryProfileType GENERIC_HLS = new DeliveryProfileType("21");
		public static readonly DeliveryProfileType GENERIC_HDS = new DeliveryProfileType("23");
		public static readonly DeliveryProfileType GENERIC_HTTP = new DeliveryProfileType("24");
		public static readonly DeliveryProfileType GENERIC_HLS_MANIFEST = new DeliveryProfileType("25");
		public static readonly DeliveryProfileType GENERIC_HDS_MANIFEST = new DeliveryProfileType("26");
		public static readonly DeliveryProfileType GENERIC_SS = new DeliveryProfileType("27");
		public static readonly DeliveryProfileType GENERIC_RTMP = new DeliveryProfileType("28");
		public static readonly DeliveryProfileType LEVEL3_HLS = new DeliveryProfileType("31");
		public static readonly DeliveryProfileType LEVEL3_HTTP = new DeliveryProfileType("34");
		public static readonly DeliveryProfileType LEVEL3_RTMP = new DeliveryProfileType("35");
		public static readonly DeliveryProfileType LIMELIGHT_HTTP = new DeliveryProfileType("44");
		public static readonly DeliveryProfileType LIMELIGHT_RTMP = new DeliveryProfileType("45");
		public static readonly DeliveryProfileType LOCAL_PATH_APPLE_HTTP = new DeliveryProfileType("51");
		public static readonly DeliveryProfileType LOCAL_PATH_HDS = new DeliveryProfileType("53");
		public static readonly DeliveryProfileType LOCAL_PATH_HTTP = new DeliveryProfileType("54");
		public static readonly DeliveryProfileType LOCAL_PATH_RTMP = new DeliveryProfileType("55");
		public static readonly DeliveryProfileType VOD_PACKAGER_HLS = new DeliveryProfileType("61");
		public static readonly DeliveryProfileType VOD_PACKAGER_HDS = new DeliveryProfileType("63");
		public static readonly DeliveryProfileType VOD_PACKAGER_MSS = new DeliveryProfileType("67");
		public static readonly DeliveryProfileType VOD_PACKAGER_DASH = new DeliveryProfileType("68");
		public static readonly DeliveryProfileType VOD_PACKAGER_HLS_MANIFEST = new DeliveryProfileType("69");
		public static readonly DeliveryProfileType LIVE_HLS = new DeliveryProfileType("1001");
		public static readonly DeliveryProfileType LIVE_HDS = new DeliveryProfileType("1002");
		public static readonly DeliveryProfileType LIVE_DASH = new DeliveryProfileType("1003");
		public static readonly DeliveryProfileType LIVE_RTMP = new DeliveryProfileType("1005");
		public static readonly DeliveryProfileType LIVE_HLS_TO_MULTICAST = new DeliveryProfileType("1006");
		public static readonly DeliveryProfileType LIVE_PACKAGER_HLS = new DeliveryProfileType("1007");
		public static readonly DeliveryProfileType LIVE_PACKAGER_HDS = new DeliveryProfileType("1008");
		public static readonly DeliveryProfileType LIVE_PACKAGER_DASH = new DeliveryProfileType("1009");
		public static readonly DeliveryProfileType LIVE_PACKAGER_MSS = new DeliveryProfileType("1010");
		public static readonly DeliveryProfileType LIVE_AKAMAI_HDS = new DeliveryProfileType("1013");

		private DeliveryProfileType(string name) : base(name) { }
	}
}
