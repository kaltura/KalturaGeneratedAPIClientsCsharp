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
	public sealed class YahooSyndicationFeedCategories : StringEnum
	{
		public static readonly YahooSyndicationFeedCategories ACTION = new YahooSyndicationFeedCategories("Action");
		public static readonly YahooSyndicationFeedCategories ANIMALS = new YahooSyndicationFeedCategories("Animals");
		public static readonly YahooSyndicationFeedCategories ART_AND_ANIMATION = new YahooSyndicationFeedCategories("Art &amp; Animation");
		public static readonly YahooSyndicationFeedCategories COMMERCIALS = new YahooSyndicationFeedCategories("Commercials");
		public static readonly YahooSyndicationFeedCategories ENTERTAINMENT_AND_TV = new YahooSyndicationFeedCategories("Entertainment &amp; TV");
		public static readonly YahooSyndicationFeedCategories FAMILY = new YahooSyndicationFeedCategories("Family");
		public static readonly YahooSyndicationFeedCategories FOOD = new YahooSyndicationFeedCategories("Food");
		public static readonly YahooSyndicationFeedCategories FUNNY_VIDEOS = new YahooSyndicationFeedCategories("Funny Videos");
		public static readonly YahooSyndicationFeedCategories GAMES = new YahooSyndicationFeedCategories("Games");
		public static readonly YahooSyndicationFeedCategories HEALTH_AND_BEAUTY = new YahooSyndicationFeedCategories("Health &amp; Beauty");
		public static readonly YahooSyndicationFeedCategories HOW_TO = new YahooSyndicationFeedCategories("How-To");
		public static readonly YahooSyndicationFeedCategories MOVIES_AND_SHORTS = new YahooSyndicationFeedCategories("Movies &amp; Shorts");
		public static readonly YahooSyndicationFeedCategories MUSIC = new YahooSyndicationFeedCategories("Music");
		public static readonly YahooSyndicationFeedCategories NEWS_AND_POLITICS = new YahooSyndicationFeedCategories("News &amp; Politics");
		public static readonly YahooSyndicationFeedCategories PEOPLE_AND_VLOGS = new YahooSyndicationFeedCategories("People &amp; Vlogs");
		public static readonly YahooSyndicationFeedCategories PRODUCTS_AND_TECH = new YahooSyndicationFeedCategories("Products &amp; Tech.");
		public static readonly YahooSyndicationFeedCategories SCIENCE_AND_ENVIRONMENT = new YahooSyndicationFeedCategories("Science &amp; Environment");
		public static readonly YahooSyndicationFeedCategories SPORTS = new YahooSyndicationFeedCategories("Sports");
		public static readonly YahooSyndicationFeedCategories TRANSPORTATION = new YahooSyndicationFeedCategories("Transportation");
		public static readonly YahooSyndicationFeedCategories TRAVEL = new YahooSyndicationFeedCategories("Travel");

		private YahooSyndicationFeedCategories(string name) : base(name) { }
	}
}
