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
	public sealed class KalturaYahooSyndicationFeedCategories : KalturaStringEnum
	{
		public static readonly KalturaYahooSyndicationFeedCategories ACTION = new KalturaYahooSyndicationFeedCategories("Action");
		public static readonly KalturaYahooSyndicationFeedCategories ANIMALS = new KalturaYahooSyndicationFeedCategories("Animals");
		public static readonly KalturaYahooSyndicationFeedCategories ART_AND_ANIMATION = new KalturaYahooSyndicationFeedCategories("Art &amp; Animation");
		public static readonly KalturaYahooSyndicationFeedCategories COMMERCIALS = new KalturaYahooSyndicationFeedCategories("Commercials");
		public static readonly KalturaYahooSyndicationFeedCategories ENTERTAINMENT_AND_TV = new KalturaYahooSyndicationFeedCategories("Entertainment &amp; TV");
		public static readonly KalturaYahooSyndicationFeedCategories FAMILY = new KalturaYahooSyndicationFeedCategories("Family");
		public static readonly KalturaYahooSyndicationFeedCategories FOOD = new KalturaYahooSyndicationFeedCategories("Food");
		public static readonly KalturaYahooSyndicationFeedCategories FUNNY_VIDEOS = new KalturaYahooSyndicationFeedCategories("Funny Videos");
		public static readonly KalturaYahooSyndicationFeedCategories GAMES = new KalturaYahooSyndicationFeedCategories("Games");
		public static readonly KalturaYahooSyndicationFeedCategories HEALTH_AND_BEAUTY = new KalturaYahooSyndicationFeedCategories("Health &amp; Beauty");
		public static readonly KalturaYahooSyndicationFeedCategories HOW_TO = new KalturaYahooSyndicationFeedCategories("How-To");
		public static readonly KalturaYahooSyndicationFeedCategories MOVIES_AND_SHORTS = new KalturaYahooSyndicationFeedCategories("Movies &amp; Shorts");
		public static readonly KalturaYahooSyndicationFeedCategories MUSIC = new KalturaYahooSyndicationFeedCategories("Music");
		public static readonly KalturaYahooSyndicationFeedCategories NEWS_AND_POLITICS = new KalturaYahooSyndicationFeedCategories("News &amp; Politics");
		public static readonly KalturaYahooSyndicationFeedCategories PEOPLE_AND_VLOGS = new KalturaYahooSyndicationFeedCategories("People &amp; Vlogs");
		public static readonly KalturaYahooSyndicationFeedCategories PRODUCTS_AND_TECH = new KalturaYahooSyndicationFeedCategories("Products &amp; Tech.");
		public static readonly KalturaYahooSyndicationFeedCategories SCIENCE_AND_ENVIRONMENT = new KalturaYahooSyndicationFeedCategories("Science &amp; Environment");
		public static readonly KalturaYahooSyndicationFeedCategories SPORTS = new KalturaYahooSyndicationFeedCategories("Sports");
		public static readonly KalturaYahooSyndicationFeedCategories TRANSPORTATION = new KalturaYahooSyndicationFeedCategories("Transportation");
		public static readonly KalturaYahooSyndicationFeedCategories TRAVEL = new KalturaYahooSyndicationFeedCategories("Travel");

		private KalturaYahooSyndicationFeedCategories(string name) : base(name) { }
	}
}
