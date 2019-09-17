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
	public sealed class DistributionProviderType : StringEnum
	{
		public static readonly DistributionProviderType ATT_UVERSE = new DistributionProviderType("attUverseDistribution.ATT_UVERSE");
		public static readonly DistributionProviderType AVN = new DistributionProviderType("avnDistribution.AVN");
		public static readonly DistributionProviderType COMCAST_MRSS = new DistributionProviderType("comcastMrssDistribution.COMCAST_MRSS");
		public static readonly DistributionProviderType CROSS_KALTURA = new DistributionProviderType("crossKalturaDistribution.CROSS_KALTURA");
		public static readonly DistributionProviderType DAILYMOTION = new DistributionProviderType("dailymotionDistribution.DAILYMOTION");
		public static readonly DistributionProviderType DOUBLECLICK = new DistributionProviderType("doubleClickDistribution.DOUBLECLICK");
		public static readonly DistributionProviderType FACEBOOK = new DistributionProviderType("facebookDistribution.FACEBOOK");
		public static readonly DistributionProviderType FREEWHEEL = new DistributionProviderType("freewheelDistribution.FREEWHEEL");
		public static readonly DistributionProviderType FREEWHEEL_GENERIC = new DistributionProviderType("freewheelGenericDistribution.FREEWHEEL_GENERIC");
		public static readonly DistributionProviderType FTP = new DistributionProviderType("ftpDistribution.FTP");
		public static readonly DistributionProviderType FTP_SCHEDULED = new DistributionProviderType("ftpDistribution.FTP_SCHEDULED");
		public static readonly DistributionProviderType HULU = new DistributionProviderType("huluDistribution.HULU");
		public static readonly DistributionProviderType IDETIC = new DistributionProviderType("ideticDistribution.IDETIC");
		public static readonly DistributionProviderType METRO_PCS = new DistributionProviderType("metroPcsDistribution.METRO_PCS");
		public static readonly DistributionProviderType MSN = new DistributionProviderType("msnDistribution.MSN");
		public static readonly DistributionProviderType NDN = new DistributionProviderType("ndnDistribution.NDN");
		public static readonly DistributionProviderType PODCAST = new DistributionProviderType("podcastDistribution.PODCAST");
		public static readonly DistributionProviderType PUSH_TO_NEWS = new DistributionProviderType("pushToNewsDistribution.PUSH_TO_NEWS");
		public static readonly DistributionProviderType QUICKPLAY = new DistributionProviderType("quickPlayDistribution.QUICKPLAY");
		public static readonly DistributionProviderType SYNACOR_HBO = new DistributionProviderType("synacorHboDistribution.SYNACOR_HBO");
		public static readonly DistributionProviderType TIME_WARNER = new DistributionProviderType("timeWarnerDistribution.TIME_WARNER");
		public static readonly DistributionProviderType TVCOM = new DistributionProviderType("tvComDistribution.TVCOM");
		public static readonly DistributionProviderType TVINCI = new DistributionProviderType("tvinciDistribution.TVINCI");
		public static readonly DistributionProviderType UNICORN = new DistributionProviderType("unicornDistribution.UNICORN");
		public static readonly DistributionProviderType UVERSE_CLICK_TO_ORDER = new DistributionProviderType("uverseClickToOrderDistribution.UVERSE_CLICK_TO_ORDER");
		public static readonly DistributionProviderType UVERSE = new DistributionProviderType("uverseDistribution.UVERSE");
		public static readonly DistributionProviderType VERIZON_VCAST = new DistributionProviderType("verizonVcastDistribution.VERIZON_VCAST");
		public static readonly DistributionProviderType YAHOO = new DistributionProviderType("yahooDistribution.YAHOO");
		public static readonly DistributionProviderType YOUTUBE = new DistributionProviderType("youTubeDistribution.YOUTUBE");
		public static readonly DistributionProviderType YOUTUBE_API = new DistributionProviderType("youtubeApiDistribution.YOUTUBE_API");
		public static readonly DistributionProviderType GENERIC = new DistributionProviderType("1");
		public static readonly DistributionProviderType SYNDICATION = new DistributionProviderType("2");

		private DistributionProviderType(string name) : base(name) { }
	}
}
