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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public sealed class ESearchUserFieldName : StringEnum
	{
		public static readonly ESearchUserFieldName COMPANY = new ESearchUserFieldName("company");
		public static readonly ESearchUserFieldName COUNTRY = new ESearchUserFieldName("country");
		public static readonly ESearchUserFieldName CREATED_AT = new ESearchUserFieldName("created_at");
		public static readonly ESearchUserFieldName EMAIL = new ESearchUserFieldName("email");
		public static readonly ESearchUserFieldName EXTERNAL_ID = new ESearchUserFieldName("external_id");
		public static readonly ESearchUserFieldName FIRST_NAME = new ESearchUserFieldName("first_name");
		public static readonly ESearchUserFieldName GROUP_IDS = new ESearchUserFieldName("group_ids");
		public static readonly ESearchUserFieldName IS_ADMIN = new ESearchUserFieldName("is_admin");
		public static readonly ESearchUserFieldName IS_HASHED = new ESearchUserFieldName("is_hashed");
		public static readonly ESearchUserFieldName LAST_NAME = new ESearchUserFieldName("last_name");
		public static readonly ESearchUserFieldName LOGIN_ENABLED = new ESearchUserFieldName("login_enabled");
		public static readonly ESearchUserFieldName PERMISSION_NAMES = new ESearchUserFieldName("permission_names");
		public static readonly ESearchUserFieldName ROLE_IDS = new ESearchUserFieldName("role_ids");
		public static readonly ESearchUserFieldName SCREEN_NAME = new ESearchUserFieldName("screen_name");
		public static readonly ESearchUserFieldName TAGS = new ESearchUserFieldName("tags");
		public static readonly ESearchUserFieldName TITLE = new ESearchUserFieldName("title");
		public static readonly ESearchUserFieldName UPDATED_AT = new ESearchUserFieldName("updated_at");
		public static readonly ESearchUserFieldName USER_ID = new ESearchUserFieldName("user_id");
		public static readonly ESearchUserFieldName TYPE = new ESearchUserFieldName("user_type");

		private ESearchUserFieldName(string name) : base(name) { }
	}
}
