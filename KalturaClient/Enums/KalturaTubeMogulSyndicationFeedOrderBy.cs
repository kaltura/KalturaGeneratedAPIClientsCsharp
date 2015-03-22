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
	public sealed class KalturaTubeMogulSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy NAME_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+name");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy TYPE_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+type");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaTubeMogulSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy NAME_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-name");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy TYPE_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-type");
		public static readonly KalturaTubeMogulSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaTubeMogulSyndicationFeedOrderBy("-updatedAt");

		private KalturaTubeMogulSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
