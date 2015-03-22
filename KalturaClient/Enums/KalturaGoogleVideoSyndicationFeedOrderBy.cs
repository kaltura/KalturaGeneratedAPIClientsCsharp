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
	public sealed class KalturaGoogleVideoSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy NAME_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+name");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy TYPE_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+type");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaGoogleVideoSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy NAME_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-name");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy TYPE_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-type");
		public static readonly KalturaGoogleVideoSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaGoogleVideoSyndicationFeedOrderBy("-updatedAt");

		private KalturaGoogleVideoSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
