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

		private ReportType(string name) : base(name) { }
	}
}
