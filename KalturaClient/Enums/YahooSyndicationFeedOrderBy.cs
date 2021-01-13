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
	public sealed class YahooSyndicationFeedOrderBy : StringEnum
	{
		public static readonly YahooSyndicationFeedOrderBy CREATED_AT_ASC = new YahooSyndicationFeedOrderBy("+createdAt");
		public static readonly YahooSyndicationFeedOrderBy NAME_ASC = new YahooSyndicationFeedOrderBy("+name");
		public static readonly YahooSyndicationFeedOrderBy PLAYLIST_ID_ASC = new YahooSyndicationFeedOrderBy("+playlistId");
		public static readonly YahooSyndicationFeedOrderBy TYPE_ASC = new YahooSyndicationFeedOrderBy("+type");
		public static readonly YahooSyndicationFeedOrderBy UPDATED_AT_ASC = new YahooSyndicationFeedOrderBy("+updatedAt");
		public static readonly YahooSyndicationFeedOrderBy CREATED_AT_DESC = new YahooSyndicationFeedOrderBy("-createdAt");
		public static readonly YahooSyndicationFeedOrderBy NAME_DESC = new YahooSyndicationFeedOrderBy("-name");
		public static readonly YahooSyndicationFeedOrderBy PLAYLIST_ID_DESC = new YahooSyndicationFeedOrderBy("-playlistId");
		public static readonly YahooSyndicationFeedOrderBy TYPE_DESC = new YahooSyndicationFeedOrderBy("-type");
		public static readonly YahooSyndicationFeedOrderBy UPDATED_AT_DESC = new YahooSyndicationFeedOrderBy("-updatedAt");

		private YahooSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
