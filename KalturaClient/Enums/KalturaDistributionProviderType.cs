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
	public sealed class KalturaDistributionProviderType : KalturaStringEnum
	{
		public static readonly KalturaDistributionProviderType ATT_UVERSE = new KalturaDistributionProviderType("attUverseDistribution.ATT_UVERSE");
		public static readonly KalturaDistributionProviderType AVN = new KalturaDistributionProviderType("avnDistribution.AVN");
		public static readonly KalturaDistributionProviderType COMCAST_MRSS = new KalturaDistributionProviderType("comcastMrssDistribution.COMCAST_MRSS");
		public static readonly KalturaDistributionProviderType CROSS_KALTURA = new KalturaDistributionProviderType("crossKalturaDistribution.CROSS_KALTURA");
		public static readonly KalturaDistributionProviderType DAILYMOTION = new KalturaDistributionProviderType("dailymotionDistribution.DAILYMOTION");
		public static readonly KalturaDistributionProviderType DOUBLECLICK = new KalturaDistributionProviderType("doubleClickDistribution.DOUBLECLICK");
		public static readonly KalturaDistributionProviderType FREEWHEEL = new KalturaDistributionProviderType("freewheelDistribution.FREEWHEEL");
		public static readonly KalturaDistributionProviderType FREEWHEEL_GENERIC = new KalturaDistributionProviderType("freewheelGenericDistribution.FREEWHEEL_GENERIC");
		public static readonly KalturaDistributionProviderType FTP = new KalturaDistributionProviderType("ftpDistribution.FTP");
		public static readonly KalturaDistributionProviderType FTP_SCHEDULED = new KalturaDistributionProviderType("ftpDistribution.FTP_SCHEDULED");
		public static readonly KalturaDistributionProviderType HULU = new KalturaDistributionProviderType("huluDistribution.HULU");
		public static readonly KalturaDistributionProviderType IDETIC = new KalturaDistributionProviderType("ideticDistribution.IDETIC");
		public static readonly KalturaDistributionProviderType METRO_PCS = new KalturaDistributionProviderType("metroPcsDistribution.METRO_PCS");
		public static readonly KalturaDistributionProviderType MSN = new KalturaDistributionProviderType("msnDistribution.MSN");
		public static readonly KalturaDistributionProviderType NDN = new KalturaDistributionProviderType("ndnDistribution.NDN");
		public static readonly KalturaDistributionProviderType PODCAST = new KalturaDistributionProviderType("podcastDistribution.PODCAST");
		public static readonly KalturaDistributionProviderType QUICKPLAY = new KalturaDistributionProviderType("quickPlayDistribution.QUICKPLAY");
		public static readonly KalturaDistributionProviderType SYNACOR_HBO = new KalturaDistributionProviderType("synacorHboDistribution.SYNACOR_HBO");
		public static readonly KalturaDistributionProviderType TIME_WARNER = new KalturaDistributionProviderType("timeWarnerDistribution.TIME_WARNER");
		public static readonly KalturaDistributionProviderType TVCOM = new KalturaDistributionProviderType("tvComDistribution.TVCOM");
		public static readonly KalturaDistributionProviderType TVINCI = new KalturaDistributionProviderType("tvinciDistribution.TVINCI");
		public static readonly KalturaDistributionProviderType UVERSE_CLICK_TO_ORDER = new KalturaDistributionProviderType("uverseClickToOrderDistribution.UVERSE_CLICK_TO_ORDER");
		public static readonly KalturaDistributionProviderType UVERSE = new KalturaDistributionProviderType("uverseDistribution.UVERSE");
		public static readonly KalturaDistributionProviderType VERIZON_VCAST = new KalturaDistributionProviderType("verizonVcastDistribution.VERIZON_VCAST");
		public static readonly KalturaDistributionProviderType YAHOO = new KalturaDistributionProviderType("yahooDistribution.YAHOO");
		public static readonly KalturaDistributionProviderType YOUTUBE = new KalturaDistributionProviderType("youTubeDistribution.YOUTUBE");
		public static readonly KalturaDistributionProviderType YOUTUBE_API = new KalturaDistributionProviderType("youtubeApiDistribution.YOUTUBE_API");
		public static readonly KalturaDistributionProviderType GENERIC = new KalturaDistributionProviderType("1");
		public static readonly KalturaDistributionProviderType SYNDICATION = new KalturaDistributionProviderType("2");

		private KalturaDistributionProviderType(string name) : base(name) { }
	}
}
