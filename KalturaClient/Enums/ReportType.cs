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
	public sealed class ReportType : StringEnum
	{
		public static readonly ReportType QUIZ = new ReportType("quiz.QUIZ");
		public static readonly ReportType QUIZ_AGGREGATE_BY_QUESTION = new ReportType("quiz.QUIZ_AGGREGATE_BY_QUESTION");
		public static readonly ReportType QUIZ_USER_AGGREGATE_BY_QUESTION = new ReportType("quiz.QUIZ_USER_AGGREGATE_BY_QUESTION");
		public static readonly ReportType QUIZ_USER_PERCENTAGE = new ReportType("quiz.QUIZ_USER_PERCENTAGE");
		public static readonly ReportType TOP_CONTENT = new ReportType("1");
		public static readonly ReportType CONTENT_DROPOFF = new ReportType("2");
		public static readonly ReportType CONTENT_INTERACTIONS = new ReportType("3");
		public static readonly ReportType MAP_OVERLAY = new ReportType("4");
		public static readonly ReportType TOP_CONTRIBUTORS = new ReportType("5");
		public static readonly ReportType TOP_SYNDICATION = new ReportType("6");
		public static readonly ReportType CONTENT_CONTRIBUTIONS = new ReportType("7");
		public static readonly ReportType USER_ENGAGEMENT = new ReportType("11");
		public static readonly ReportType SPECIFIC_USER_ENGAGEMENT = new ReportType("12");
		public static readonly ReportType USER_TOP_CONTENT = new ReportType("13");
		public static readonly ReportType USER_CONTENT_DROPOFF = new ReportType("14");
		public static readonly ReportType USER_CONTENT_INTERACTIONS = new ReportType("15");
		public static readonly ReportType APPLICATIONS = new ReportType("16");
		public static readonly ReportType USER_USAGE = new ReportType("17");
		public static readonly ReportType SPECIFIC_USER_USAGE = new ReportType("18");
		public static readonly ReportType VAR_USAGE = new ReportType("19");
		public static readonly ReportType TOP_CREATORS = new ReportType("20");
		public static readonly ReportType PLATFORMS = new ReportType("21");
		public static readonly ReportType OPERATING_SYSTEM = new ReportType("22");
		public static readonly ReportType BROWSERS = new ReportType("23");
		public static readonly ReportType LIVE = new ReportType("24");
		public static readonly ReportType TOP_PLAYBACK_CONTEXT = new ReportType("25");
		public static readonly ReportType VPAAS_USAGE = new ReportType("26");
		public static readonly ReportType ENTRY_USAGE = new ReportType("27");
		public static readonly ReportType REACH_USAGE = new ReportType("28");
		public static readonly ReportType TOP_CUSTOM_VAR1 = new ReportType("29");
		public static readonly ReportType MAP_OVERLAY_CITY = new ReportType("30");
		public static readonly ReportType OPERATING_SYSTEM_FAMILIES = new ReportType("32");
		public static readonly ReportType BROWSERS_FAMILIES = new ReportType("33");
		public static readonly ReportType USER_ENGAGEMENT_TIMELINE = new ReportType("34");
		public static readonly ReportType UNIQUE_USERS_PLAY = new ReportType("35");
		public static readonly ReportType MAP_OVERLAY_COUNTRY = new ReportType("36");
		public static readonly ReportType MAP_OVERLAY_REGION = new ReportType("37");
		public static readonly ReportType TOP_CONTENT_CREATOR = new ReportType("38");
		public static readonly ReportType TOP_CONTENT_CONTRIBUTORS = new ReportType("39");
		public static readonly ReportType APP_DOMAIN_UNIQUE_ACTIVE_USERS = new ReportType("40");
		public static readonly ReportType TOP_SOURCES = new ReportType("41");
		public static readonly ReportType VPAAS_USAGE_MULTI = new ReportType("42");
		public static readonly ReportType PERCENTILES = new ReportType("43");
		public static readonly ReportType CONTENT_REPORT_REASONS = new ReportType("44");
		public static readonly ReportType PLAYER_RELATED_INTERACTIONS = new ReportType("45");
		public static readonly ReportType PLAYBACK_RATE = new ReportType("46");
		public static readonly ReportType TOP_USER_CONTENT = new ReportType("47");
		public static readonly ReportType USER_HIGHLIGHTS = new ReportType("48");
		public static readonly ReportType USER_INTERACTIVE_VIDEO = new ReportType("49");
		public static readonly ReportType INTERACTIVE_VIDEO_TOP_NODES = new ReportType("50");
		public static readonly ReportType LATEST_PLAYED_ENTRIES = new ReportType("51");
		public static readonly ReportType CATEGORY_HIGHLIGHTS = new ReportType("52");
		public static readonly ReportType SUB_CATEGORIES = new ReportType("53");
		public static readonly ReportType INTERACTIVE_VIDEO_NODE_TOP_HOTSPOTS = new ReportType("54");
		public static readonly ReportType INTERCATIVE_VIDEO_NODE_SWITCH_TOP_HOTSPOTS = new ReportType("55");
		public static readonly ReportType INTERACTIVE_VIDEO_HOTSPOT_CLICKED_PERCENTILES = new ReportType("56");
		public static readonly ReportType INTERACTIVE_VIDEO_NODE_SWITCH_HOTSPOT_CLICKED_PERCENTILES = new ReportType("57");
		public static readonly ReportType TOP_CUSTOM_VAR2 = new ReportType("58");
		public static readonly ReportType TOP_CUSTOM_VAR3 = new ReportType("59");
		public static readonly ReportType SELF_SERVE_USAGE = new ReportType("60");
		public static readonly ReportType PARTNER_USAGE = new ReportType("201");
		public static readonly ReportType MAP_OVERLAY_COUNTRY_REALTIME = new ReportType("10001");
		public static readonly ReportType MAP_OVERLAY_REGION_REALTIME = new ReportType("10002");
		public static readonly ReportType MAP_OVERLAY_CITY_REALTIME = new ReportType("10003");
		public static readonly ReportType PLATFORMS_REALTIME = new ReportType("10004");
		public static readonly ReportType USERS_OVERVIEW_REALTIME = new ReportType("10005");
		public static readonly ReportType QOS_OVERVIEW_REALTIME = new ReportType("10006");
		public static readonly ReportType DISCOVERY_REALTIME = new ReportType("10007");
		public static readonly ReportType ENTRY_LEVEL_USERS_DISCOVERY_REALTIME = new ReportType("10008");
		public static readonly ReportType ENTRY_LEVEL_USERS_STATUS_REALTIME = new ReportType("10009");
		public static readonly ReportType PLATFORMS_DISCOVERY_REALTIME = new ReportType("10010");
		public static readonly ReportType PLAYBACK_TYPE_REALTIME = new ReportType("10011");
		public static readonly ReportType CONTENT_REALTIME = new ReportType("10012");
		public static readonly ReportType DISCOVERY_VIEW_REALTIME = new ReportType("10013");
		public static readonly ReportType TOP_ENDED_BROADCAST_ENTRIES = new ReportType("10014");
		public static readonly ReportType TOP_LIVE_NOW_ENTRIES = new ReportType("10015");
		public static readonly ReportType CONTENT_DROPOFF_VPAAS = new ReportType("20001");
		public static readonly ReportType TOP_SYNDICATION_VPAAS = new ReportType("20002");
		public static readonly ReportType USER_TOP_CONTENT_VPAAS = new ReportType("20003");
		public static readonly ReportType USER_USAGE_VPAAS = new ReportType("20004");
		public static readonly ReportType PLATFORMS_VPAAS = new ReportType("20005");
		public static readonly ReportType OPERATING_SYSTEM_VPAAS = new ReportType("20006");
		public static readonly ReportType BROWSERS_VPAAS = new ReportType("20007");
		public static readonly ReportType OPERATING_SYSTEM_FAMILIES_VPAAS = new ReportType("20008");
		public static readonly ReportType BROWSERS_FAMILIES_VPAAS = new ReportType("20009");
		public static readonly ReportType USER_ENGAGEMENT_TIMELINE_VPAAS = new ReportType("20010");
		public static readonly ReportType UNIQUE_USERS_PLAY_VPAAS = new ReportType("20011");
		public static readonly ReportType MAP_OVERLAY_COUNTRY_VPAAS = new ReportType("20012");
		public static readonly ReportType MAP_OVERLAY_REGION_VPAAS = new ReportType("20013");
		public static readonly ReportType MAP_OVERLAY_CITY_VPAAS = new ReportType("20014");
		public static readonly ReportType TOP_CONTENT_CREATOR_VPAAS = new ReportType("20015");
		public static readonly ReportType TOP_CONTENT_CONTRIBUTORS_VPAAS = new ReportType("20016");
		public static readonly ReportType TOP_SOURCES_VPAAS = new ReportType("20017");
		public static readonly ReportType CONTENT_REPORT_REASONS_VPAAS = new ReportType("20018");
		public static readonly ReportType PLAYER_RELATED_INTERACTIONS_VPAAS = new ReportType("20019");
		public static readonly ReportType PLAYBACK_RATE_VPAAS = new ReportType("20020");
		public static readonly ReportType PARTNER_USAGE_VPAAS = new ReportType("20021");
		public static readonly ReportType TOP_PLAYBACK_CONTEXT_VPAAS = new ReportType("20022");
		public static readonly ReportType SELF_SERVE_USAGE_VPAAS = new ReportType("20023");
		public static readonly ReportType QOE_OVERVIEW = new ReportType("30001");
		public static readonly ReportType QOE_EXPERIENCE = new ReportType("30002");
		public static readonly ReportType QOE_EXPERIENCE_PLATFORMS = new ReportType("30003");
		public static readonly ReportType QOE_EXPERIENCE_COUNTRY = new ReportType("30004");
		public static readonly ReportType QOE_EXPERIENCE_REGION = new ReportType("30005");
		public static readonly ReportType QOE_EXPERIENCE_CITY = new ReportType("30006");
		public static readonly ReportType QOE_EXPERIENCE_BROWSERS_FAMILIES = new ReportType("30007");
		public static readonly ReportType QOE_EXPERIENCE_BROWSERS = new ReportType("30008");
		public static readonly ReportType QOE_EXPERIENCE_OPERATING_SYSTEM_FAMILIES = new ReportType("30009");
		public static readonly ReportType QOE_EXPERIENCE_OPERATING_SYSTEM = new ReportType("30010");
		public static readonly ReportType QOE_EXPERIENCE_PLAYER_VERSION = new ReportType("30011");
		public static readonly ReportType QOE_EXPERIENCE_ENTRY = new ReportType("30012");
		public static readonly ReportType QOE_EXPERIENCE_ISP = new ReportType("30013");
		public static readonly ReportType QOE_ENGAGEMENT = new ReportType("30014");
		public static readonly ReportType QOE_ENGAGEMENT_PLATFORMS = new ReportType("30015");
		public static readonly ReportType QOE_ENGAGEMENT_COUNTRY = new ReportType("30016");
		public static readonly ReportType QOE_ENGAGEMENT_REGION = new ReportType("30017");
		public static readonly ReportType QOE_ENGAGEMENT_CITY = new ReportType("30018");
		public static readonly ReportType QOE_ENGAGEMENT_BROWSERS_FAMILIES = new ReportType("30019");
		public static readonly ReportType QOE_ENGAGEMENT_BROWSERS = new ReportType("30020");
		public static readonly ReportType QOE_ENGAGEMENT_OPERATING_SYSTEM_FAMILIES = new ReportType("30021");
		public static readonly ReportType QOE_ENGAGEMENT_OPERATING_SYSTEM = new ReportType("30022");
		public static readonly ReportType QOE_ENGAGEMENT_PLAYER_VERSION = new ReportType("30023");
		public static readonly ReportType QOE_ENGAGEMENT_ENTRY = new ReportType("30024");
		public static readonly ReportType QOE_ENGAGEMENT_ISP = new ReportType("30025");
		public static readonly ReportType QOE_STREAM_QUALITY = new ReportType("30026");
		public static readonly ReportType QOE_STREAM_QUALITY_PLATFORMS = new ReportType("30027");
		public static readonly ReportType QOE_STREAM_QUALITY_COUNTRY = new ReportType("30028");
		public static readonly ReportType QOE_STREAM_QUALITY_REGION = new ReportType("30029");
		public static readonly ReportType QOE_STREAM_QUALITY_CITY = new ReportType("30030");
		public static readonly ReportType QOE_STREAM_QUALITY_BROWSERS_FAMILIES = new ReportType("30031");
		public static readonly ReportType QOE_STREAM_QUALITY_BROWSERS = new ReportType("30032");
		public static readonly ReportType QOE_STREAM_QUALITY_OPERATING_SYSTEM_FAMILIES = new ReportType("30033");
		public static readonly ReportType QOE_STREAM_QUALITY_OPERATING_SYSTEM = new ReportType("30034");
		public static readonly ReportType QOE_STREAM_QUALITY_PLAYER_VERSION = new ReportType("30035");
		public static readonly ReportType QOE_STREAM_QUALITY_ENTRY = new ReportType("30036");
		public static readonly ReportType QOE_STREAM_QUALITY_ISP = new ReportType("30037");
		public static readonly ReportType QOE_ERROR_TRACKING = new ReportType("30038");
		public static readonly ReportType QOE_ERROR_TRACKING_CODES = new ReportType("30039");
		public static readonly ReportType QOE_ERROR_TRACKING_PLATFORMS = new ReportType("30040");
		public static readonly ReportType QOE_ERROR_TRACKING_BROWSERS_FAMILIES = new ReportType("30041");
		public static readonly ReportType QOE_ERROR_TRACKING_BROWSERS = new ReportType("30042");
		public static readonly ReportType QOE_ERROR_TRACKING_OPERATING_SYSTEM_FAMILIES = new ReportType("30043");
		public static readonly ReportType QOE_ERROR_TRACKING_OPERATING_SYSTEM = new ReportType("30044");
		public static readonly ReportType QOE_ERROR_TRACKING_PLAYER_VERSION = new ReportType("30045");
		public static readonly ReportType QOE_ERROR_TRACKING_ENTRY = new ReportType("30046");
		public static readonly ReportType QOE_VOD_SESSION_FLOW = new ReportType("30047");
		public static readonly ReportType QOE_LIVE_SESSION_FLOW = new ReportType("30048");
		public static readonly ReportType QOE_EXPERIENCE_CUSTOM_VAR1 = new ReportType("30049");
		public static readonly ReportType QOE_EXPERIENCE_CUSTOM_VAR2 = new ReportType("30050");
		public static readonly ReportType QOE_EXPERIENCE_CUSTOM_VAR3 = new ReportType("30051");
		public static readonly ReportType QOE_ENGAGEMENT_CUSTOM_VAR1 = new ReportType("30052");
		public static readonly ReportType QOE_ENGAGEMENT_CUSTOM_VAR2 = new ReportType("30053");
		public static readonly ReportType QOE_ENGAGEMENT_CUSTOM_VAR3 = new ReportType("30054");
		public static readonly ReportType QOE_STREAM_QUALITY_CUSTOM_VAR1 = new ReportType("30055");
		public static readonly ReportType QOE_STREAM_QUALITY_CUSTOM_VAR2 = new ReportType("30056");
		public static readonly ReportType QOE_STREAM_QUALITY_CUSTOM_VAR3 = new ReportType("30057");
		public static readonly ReportType QOE_ERROR_TRACKING_CUSTOM_VAR1 = new ReportType("30058");
		public static readonly ReportType QOE_ERROR_TRACKING_CUSTOM_VAR2 = new ReportType("30059");
		public static readonly ReportType QOE_ERROR_TRACKING_CUSTOM_VAR3 = new ReportType("30060");
		public static readonly ReportType QOE_EXPERIENCE_APPLICATION_VERSION = new ReportType("30061");
		public static readonly ReportType QOE_ENGAGEMENT_APPLICATION_VERSION = new ReportType("30062");
		public static readonly ReportType QOE_STREAM_QUALITY_APPLICATION_VERSION = new ReportType("30063");
		public static readonly ReportType QOE_ERROR_TRACKING_APPLICATION_VERSION = new ReportType("30064");
		public static readonly ReportType HIGHLIGHTS_WEBCAST = new ReportType("40001");
		public static readonly ReportType ENGAGEMENT_WEBCAST = new ReportType("40002");
		public static readonly ReportType QUALITY_WEBCAST = new ReportType("40003");
		public static readonly ReportType MAP_OVERLAY_COUNTRY_WEBCAST = new ReportType("40004");
		public static readonly ReportType MAP_OVERLAY_REGION_WEBCAST = new ReportType("40005");
		public static readonly ReportType MAP_OVERLAY_CITY_WEBCAST = new ReportType("40006");
		public static readonly ReportType PLATFORMS_WEBCAST = new ReportType("40007");
		public static readonly ReportType TOP_DOMAINS_WEBCAST = new ReportType("40008");
		public static readonly ReportType TOP_USERS_WEBCAST = new ReportType("40009");
		public static readonly ReportType ENGAGEMENT_BREAKDOWN_WEBCAST = new ReportType("40010");
		public static readonly ReportType ENGAGMENT_TIMELINE_WEBCAST = new ReportType("40011");
		public static readonly ReportType ENGAGEMENT_TOOLS_WEBCAST = new ReportType("40012");
		public static readonly ReportType REACTIONS_BREAKDOWN_WEBCAST = new ReportType("40013");

		private ReportType(string name) : base(name) { }
	}
}
