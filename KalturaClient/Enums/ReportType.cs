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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		public static readonly ReportType APP_DOMAIN_UNIQUE_ACTIVE_USERS = new ReportType("40");
		public static readonly ReportType PARTNER_USAGE = new ReportType("201");

		private ReportType(string name) : base(name) { }
	}
}
