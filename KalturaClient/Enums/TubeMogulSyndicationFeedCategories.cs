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
	public sealed class TubeMogulSyndicationFeedCategories : StringEnum
	{
		public static readonly TubeMogulSyndicationFeedCategories ANIMALS_AND_PETS = new TubeMogulSyndicationFeedCategories("Animals &amp; Pets");
		public static readonly TubeMogulSyndicationFeedCategories ARTS_AND_ANIMATION = new TubeMogulSyndicationFeedCategories("Arts &amp; Animation");
		public static readonly TubeMogulSyndicationFeedCategories AUTOS = new TubeMogulSyndicationFeedCategories("Autos");
		public static readonly TubeMogulSyndicationFeedCategories COMEDY = new TubeMogulSyndicationFeedCategories("Comedy");
		public static readonly TubeMogulSyndicationFeedCategories COMMERCIALS_PROMOTIONAL = new TubeMogulSyndicationFeedCategories("Commercials/Promotional");
		public static readonly TubeMogulSyndicationFeedCategories ENTERTAINMENT = new TubeMogulSyndicationFeedCategories("Entertainment");
		public static readonly TubeMogulSyndicationFeedCategories FAMILY_AND_KIDS = new TubeMogulSyndicationFeedCategories("Family &amp; Kids");
		public static readonly TubeMogulSyndicationFeedCategories HOW_TO_INSTRUCTIONAL_DIY = new TubeMogulSyndicationFeedCategories("How To/Instructional/DIY");
		public static readonly TubeMogulSyndicationFeedCategories MUSIC = new TubeMogulSyndicationFeedCategories("Music");
		public static readonly TubeMogulSyndicationFeedCategories NEWS_AND_BLOGS = new TubeMogulSyndicationFeedCategories("News &amp; Blogs");
		public static readonly TubeMogulSyndicationFeedCategories SCIENCE_AND_TECHNOLOGY = new TubeMogulSyndicationFeedCategories("Science &amp; Technology");
		public static readonly TubeMogulSyndicationFeedCategories SPORTS = new TubeMogulSyndicationFeedCategories("Sports");
		public static readonly TubeMogulSyndicationFeedCategories TRAVEL_AND_PLACES = new TubeMogulSyndicationFeedCategories("Travel &amp; Places");
		public static readonly TubeMogulSyndicationFeedCategories VIDEO_GAMES = new TubeMogulSyndicationFeedCategories("Video Games");
		public static readonly TubeMogulSyndicationFeedCategories VLOGS_PEOPLE = new TubeMogulSyndicationFeedCategories("Vlogs &amp; People");

		private TubeMogulSyndicationFeedCategories(string name) : base(name) { }
	}
}
