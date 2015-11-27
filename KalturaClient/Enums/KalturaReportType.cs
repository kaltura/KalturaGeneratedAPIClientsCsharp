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
	public sealed class KalturaReportType : KalturaStringEnum
	{
		public static readonly KalturaReportType QUIZ = new KalturaReportType("quiz.QUIZ");
		public static readonly KalturaReportType QUIZ_AGGREGATE_BY_QUESTION = new KalturaReportType("quiz.QUIZ_AGGREGATE_BY_QUESTION");
		public static readonly KalturaReportType QUIZ_USER_AGGREGATE_BY_QUESTION = new KalturaReportType("quiz.QUIZ_USER_AGGREGATE_BY_QUESTION");
		public static readonly KalturaReportType QUIZ_USER_PERCENTAGE = new KalturaReportType("quiz.QUIZ_USER_PERCENTAGE");
		public static readonly KalturaReportType TOP_CONTENT = new KalturaReportType("1");
		public static readonly KalturaReportType CONTENT_DROPOFF = new KalturaReportType("2");
		public static readonly KalturaReportType CONTENT_INTERACTIONS = new KalturaReportType("3");
		public static readonly KalturaReportType MAP_OVERLAY = new KalturaReportType("4");
		public static readonly KalturaReportType TOP_CONTRIBUTORS = new KalturaReportType("5");
		public static readonly KalturaReportType TOP_SYNDICATION = new KalturaReportType("6");
		public static readonly KalturaReportType CONTENT_CONTRIBUTIONS = new KalturaReportType("7");
		public static readonly KalturaReportType USER_ENGAGEMENT = new KalturaReportType("11");
		public static readonly KalturaReportType SPEFICIC_USER_ENGAGEMENT = new KalturaReportType("12");
		public static readonly KalturaReportType USER_TOP_CONTENT = new KalturaReportType("13");
		public static readonly KalturaReportType USER_CONTENT_DROPOFF = new KalturaReportType("14");
		public static readonly KalturaReportType USER_CONTENT_INTERACTIONS = new KalturaReportType("15");
		public static readonly KalturaReportType APPLICATIONS = new KalturaReportType("16");
		public static readonly KalturaReportType USER_USAGE = new KalturaReportType("17");
		public static readonly KalturaReportType SPECIFIC_USER_USAGE = new KalturaReportType("18");
		public static readonly KalturaReportType VAR_USAGE = new KalturaReportType("19");
		public static readonly KalturaReportType TOP_CREATORS = new KalturaReportType("20");
		public static readonly KalturaReportType PLATFORMS = new KalturaReportType("21");
		public static readonly KalturaReportType OPERATION_SYSTEM = new KalturaReportType("22");
		public static readonly KalturaReportType BROWSERS = new KalturaReportType("23");
		public static readonly KalturaReportType LIVE = new KalturaReportType("24");
		public static readonly KalturaReportType TOP_PLAYBACK_CONTEXT = new KalturaReportType("25");
		public static readonly KalturaReportType VPAAS_USAGE = new KalturaReportType("26");
		public static readonly KalturaReportType PARTNER_USAGE = new KalturaReportType("201");

		private KalturaReportType(string name) : base(name) { }
	}
}
