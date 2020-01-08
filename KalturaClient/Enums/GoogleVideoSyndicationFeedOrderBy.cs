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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class GoogleVideoSyndicationFeedOrderBy : StringEnum
	{
		public static readonly GoogleVideoSyndicationFeedOrderBy CREATED_AT_ASC = new GoogleVideoSyndicationFeedOrderBy("+createdAt");
		public static readonly GoogleVideoSyndicationFeedOrderBy NAME_ASC = new GoogleVideoSyndicationFeedOrderBy("+name");
		public static readonly GoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_ASC = new GoogleVideoSyndicationFeedOrderBy("+playlistId");
		public static readonly GoogleVideoSyndicationFeedOrderBy TYPE_ASC = new GoogleVideoSyndicationFeedOrderBy("+type");
		public static readonly GoogleVideoSyndicationFeedOrderBy UPDATED_AT_ASC = new GoogleVideoSyndicationFeedOrderBy("+updatedAt");
		public static readonly GoogleVideoSyndicationFeedOrderBy CREATED_AT_DESC = new GoogleVideoSyndicationFeedOrderBy("-createdAt");
		public static readonly GoogleVideoSyndicationFeedOrderBy NAME_DESC = new GoogleVideoSyndicationFeedOrderBy("-name");
		public static readonly GoogleVideoSyndicationFeedOrderBy PLAYLIST_ID_DESC = new GoogleVideoSyndicationFeedOrderBy("-playlistId");
		public static readonly GoogleVideoSyndicationFeedOrderBy TYPE_DESC = new GoogleVideoSyndicationFeedOrderBy("-type");
		public static readonly GoogleVideoSyndicationFeedOrderBy UPDATED_AT_DESC = new GoogleVideoSyndicationFeedOrderBy("-updatedAt");

		private GoogleVideoSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
