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
	public sealed class KalturaBaseSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaBaseSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaBaseSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaBaseSyndicationFeedOrderBy NAME_ASC = new KalturaBaseSyndicationFeedOrderBy("+name");
		public static readonly KalturaBaseSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaBaseSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaBaseSyndicationFeedOrderBy TYPE_ASC = new KalturaBaseSyndicationFeedOrderBy("+type");
		public static readonly KalturaBaseSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaBaseSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaBaseSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaBaseSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaBaseSyndicationFeedOrderBy NAME_DESC = new KalturaBaseSyndicationFeedOrderBy("-name");
		public static readonly KalturaBaseSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaBaseSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaBaseSyndicationFeedOrderBy TYPE_DESC = new KalturaBaseSyndicationFeedOrderBy("-type");
		public static readonly KalturaBaseSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaBaseSyndicationFeedOrderBy("-updatedAt");

		private KalturaBaseSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
