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
	public sealed class ITunesSyndicationFeedOrderBy : StringEnum
	{
		public static readonly ITunesSyndicationFeedOrderBy CREATED_AT_ASC = new ITunesSyndicationFeedOrderBy("+createdAt");
		public static readonly ITunesSyndicationFeedOrderBy NAME_ASC = new ITunesSyndicationFeedOrderBy("+name");
		public static readonly ITunesSyndicationFeedOrderBy PLAYLIST_ID_ASC = new ITunesSyndicationFeedOrderBy("+playlistId");
		public static readonly ITunesSyndicationFeedOrderBy TYPE_ASC = new ITunesSyndicationFeedOrderBy("+type");
		public static readonly ITunesSyndicationFeedOrderBy UPDATED_AT_ASC = new ITunesSyndicationFeedOrderBy("+updatedAt");
		public static readonly ITunesSyndicationFeedOrderBy CREATED_AT_DESC = new ITunesSyndicationFeedOrderBy("-createdAt");
		public static readonly ITunesSyndicationFeedOrderBy NAME_DESC = new ITunesSyndicationFeedOrderBy("-name");
		public static readonly ITunesSyndicationFeedOrderBy PLAYLIST_ID_DESC = new ITunesSyndicationFeedOrderBy("-playlistId");
		public static readonly ITunesSyndicationFeedOrderBy TYPE_DESC = new ITunesSyndicationFeedOrderBy("-type");
		public static readonly ITunesSyndicationFeedOrderBy UPDATED_AT_DESC = new ITunesSyndicationFeedOrderBy("-updatedAt");

		private ITunesSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
