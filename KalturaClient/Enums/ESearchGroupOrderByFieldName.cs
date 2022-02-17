// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public sealed class ESearchGroupOrderByFieldName : StringEnum
	{
		public static readonly ESearchGroupOrderByFieldName CREATED_AT = new ESearchGroupOrderByFieldName("created_at");
		public static readonly ESearchGroupOrderByFieldName MEMBERS_COUNT = new ESearchGroupOrderByFieldName("members_count");
		public static readonly ESearchGroupOrderByFieldName USER_ID = new ESearchGroupOrderByFieldName("puser_id");
		public static readonly ESearchGroupOrderByFieldName SCREEN_NAME = new ESearchGroupOrderByFieldName("screen_name");
		public static readonly ESearchGroupOrderByFieldName UPDATED_AT = new ESearchGroupOrderByFieldName("updated_at");

		private ESearchGroupOrderByFieldName(string name) : base(name) { }
	}
}
