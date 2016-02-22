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
	public sealed class KalturaGenericXsltSyndicationFeedOrderBy : KalturaStringEnum
	{
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy CREATED_AT_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+createdAt");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy NAME_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+name");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy PLAYLIST_ID_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+playlistId");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy TYPE_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+type");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy UPDATED_AT_ASC = new KalturaGenericXsltSyndicationFeedOrderBy("+updatedAt");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy CREATED_AT_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-createdAt");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy NAME_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-name");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy PLAYLIST_ID_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-playlistId");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy TYPE_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-type");
		public static readonly KalturaGenericXsltSyndicationFeedOrderBy UPDATED_AT_DESC = new KalturaGenericXsltSyndicationFeedOrderBy("-updatedAt");

		private KalturaGenericXsltSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
