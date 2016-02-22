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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public sealed class KalturaITunesSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaITunesSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaITunesSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaITunesSyndicationFeedOrderBy NAME_ASC = new KalturaITunesSyndicationFeedOrderBy("+name");
		public static readonly KalturaITunesSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaITunesSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaITunesSyndicationFeedOrderBy TYPE_ASC = new KalturaITunesSyndicationFeedOrderBy("+type");
		public static readonly KalturaITunesSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaITunesSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaITunesSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaITunesSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaITunesSyndicationFeedOrderBy NAME_DESC = new KalturaITunesSyndicationFeedOrderBy("-name");
		public static readonly KalturaITunesSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaITunesSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaITunesSyndicationFeedOrderBy TYPE_DESC = new KalturaITunesSyndicationFeedOrderBy("-type");
		public static readonly KalturaITunesSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaITunesSyndicationFeedOrderBy("-updatedAt");

		private KalturaITunesSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
