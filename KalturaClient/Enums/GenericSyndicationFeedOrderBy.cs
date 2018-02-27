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
	public sealed class GenericSyndicationFeedOrderBy : StringEnum
	{
		public static readonly GenericSyndicationFeedOrderBy CREATED_AT_ASC = new GenericSyndicationFeedOrderBy("+createdAt");
		public static readonly GenericSyndicationFeedOrderBy NAME_ASC = new GenericSyndicationFeedOrderBy("+name");
		public static readonly GenericSyndicationFeedOrderBy PLAYLIST_ID_ASC = new GenericSyndicationFeedOrderBy("+playlistId");
		public static readonly GenericSyndicationFeedOrderBy TYPE_ASC = new GenericSyndicationFeedOrderBy("+type");
		public static readonly GenericSyndicationFeedOrderBy UPDATED_AT_ASC = new GenericSyndicationFeedOrderBy("+updatedAt");
		public static readonly GenericSyndicationFeedOrderBy CREATED_AT_DESC = new GenericSyndicationFeedOrderBy("-createdAt");
		public static readonly GenericSyndicationFeedOrderBy NAME_DESC = new GenericSyndicationFeedOrderBy("-name");
		public static readonly GenericSyndicationFeedOrderBy PLAYLIST_ID_DESC = new GenericSyndicationFeedOrderBy("-playlistId");
		public static readonly GenericSyndicationFeedOrderBy TYPE_DESC = new GenericSyndicationFeedOrderBy("-type");
		public static readonly GenericSyndicationFeedOrderBy UPDATED_AT_DESC = new GenericSyndicationFeedOrderBy("-updatedAt");

		private GenericSyndicationFeedOrderBy(string name) : base(name) { }
	}
}
