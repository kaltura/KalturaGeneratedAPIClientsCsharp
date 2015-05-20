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
	public sealed class KalturaTubeMogulSyndicationFeedCategories : KalturaStringEnum
	{
		public static readonly KalturaTubeMogulSyndicationFeedCategories ANIMALS_AND_PETS = new KalturaTubeMogulSyndicationFeedCategories("Animals &amp; Pets");
		public static readonly KalturaTubeMogulSyndicationFeedCategories ARTS_AND_ANIMATION = new KalturaTubeMogulSyndicationFeedCategories("Arts &amp; Animation");
		public static readonly KalturaTubeMogulSyndicationFeedCategories AUTOS = new KalturaTubeMogulSyndicationFeedCategories("Autos");
		public static readonly KalturaTubeMogulSyndicationFeedCategories COMEDY = new KalturaTubeMogulSyndicationFeedCategories("Comedy");
		public static readonly KalturaTubeMogulSyndicationFeedCategories COMMERCIALS_PROMOTIONAL = new KalturaTubeMogulSyndicationFeedCategories("Commercials/Promotional");
		public static readonly KalturaTubeMogulSyndicationFeedCategories ENTERTAINMENT = new KalturaTubeMogulSyndicationFeedCategories("Entertainment");
		public static readonly KalturaTubeMogulSyndicationFeedCategories FAMILY_AND_KIDS = new KalturaTubeMogulSyndicationFeedCategories("Family &amp; Kids");
		public static readonly KalturaTubeMogulSyndicationFeedCategories HOW_TO_INSTRUCTIONAL_DIY = new KalturaTubeMogulSyndicationFeedCategories("How To/Instructional/DIY");
		public static readonly KalturaTubeMogulSyndicationFeedCategories MUSIC = new KalturaTubeMogulSyndicationFeedCategories("Music");
		public static readonly KalturaTubeMogulSyndicationFeedCategories NEWS_AND_BLOGS = new KalturaTubeMogulSyndicationFeedCategories("News &amp; Blogs");
		public static readonly KalturaTubeMogulSyndicationFeedCategories SCIENCE_AND_TECHNOLOGY = new KalturaTubeMogulSyndicationFeedCategories("Science &amp; Technology");
		public static readonly KalturaTubeMogulSyndicationFeedCategories SPORTS = new KalturaTubeMogulSyndicationFeedCategories("Sports");
		public static readonly KalturaTubeMogulSyndicationFeedCategories TRAVEL_AND_PLACES = new KalturaTubeMogulSyndicationFeedCategories("Travel &amp; Places");
		public static readonly KalturaTubeMogulSyndicationFeedCategories VIDEO_GAMES = new KalturaTubeMogulSyndicationFeedCategories("Video Games");
		public static readonly KalturaTubeMogulSyndicationFeedCategories VLOGS_PEOPLE = new KalturaTubeMogulSyndicationFeedCategories("Vlogs &amp; People");

		private KalturaTubeMogulSyndicationFeedCategories(string name) : base(name) { }
	}
}
