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
	public sealed class KalturaGenericSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGenericSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGenericSyndicationFeedOrderBy NAME_ASC = new KalturaGenericSyndicationFeedOrderBy("+name");
		public static readonly KalturaGenericSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGenericSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGenericSyndicationFeedOrderBy TYPE_ASC = new KalturaGenericSyndicationFeedOrderBy("+type");
		public static readonly KalturaGenericSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaGenericSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaGenericSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGenericSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaGenericSyndicationFeedOrderBy NAME_DESC = new KalturaGenericSyndicationFeedOrderBy("-name");
		public static readonly KalturaGenericSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGenericSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGenericSyndicationFeedOrderBy TYPE_DESC = new KalturaGenericSyndicationFeedOrderBy("-type");
		public static readonly KalturaGenericSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaGenericSyndicationFeedOrderBy("-updatedAt");

		private KalturaGenericSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
