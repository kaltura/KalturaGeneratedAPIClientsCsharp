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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public sealed class ESearchEntryFieldName : StringEnum
	{
		public static readonly ESearchEntryFieldName ACCESS_CONTROL_ID = new ESearchEntryFieldName("access_control_id");
		public static readonly ESearchEntryFieldName ADMIN_TAGS = new ESearchEntryFieldName("admin_tags");
		public static readonly ESearchEntryFieldName CONVERSION_PROFILE_ID = new ESearchEntryFieldName("conversion_profile_id");
		public static readonly ESearchEntryFieldName CREATED_AT = new ESearchEntryFieldName("created_at");
		public static readonly ESearchEntryFieldName CREATOR_ID = new ESearchEntryFieldName("creator_kuser_id");
		public static readonly ESearchEntryFieldName CREDIT = new ESearchEntryFieldName("credit");
		public static readonly ESearchEntryFieldName DESCRIPTION = new ESearchEntryFieldName("description");
		public static readonly ESearchEntryFieldName END_DATE = new ESearchEntryFieldName("end_date");
		public static readonly ESearchEntryFieldName ENTITLED_USER_EDIT = new ESearchEntryFieldName("entitled_kusers_edit");
		public static readonly ESearchEntryFieldName ENTITLED_USER_PUBLISH = new ESearchEntryFieldName("entitled_kusers_publish");
		public static readonly ESearchEntryFieldName ENTRY_TYPE = new ESearchEntryFieldName("entry_type");
		public static readonly ESearchEntryFieldName EXTERNAL_SOURCE_TYPE = new ESearchEntryFieldName("external_source_type");
		public static readonly ESearchEntryFieldName ID = new ESearchEntryFieldName("id");
		public static readonly ESearchEntryFieldName IS_LIVE = new ESearchEntryFieldName("is_live");
		public static readonly ESearchEntryFieldName IS_QUIZ = new ESearchEntryFieldName("is_quiz");
		public static readonly ESearchEntryFieldName USER_ID = new ESearchEntryFieldName("kuser_id");
		public static readonly ESearchEntryFieldName LENGTH_IN_MSECS = new ESearchEntryFieldName("length_in_msecs");
		public static readonly ESearchEntryFieldName MEDIA_TYPE = new ESearchEntryFieldName("media_type");
		public static readonly ESearchEntryFieldName MODERATION_STATUS = new ESearchEntryFieldName("moderation_status");
		public static readonly ESearchEntryFieldName NAME = new ESearchEntryFieldName("name");
		public static readonly ESearchEntryFieldName PARENT_ENTRY_ID = new ESearchEntryFieldName("parent_id");
		public static readonly ESearchEntryFieldName PUSH_PUBLISH = new ESearchEntryFieldName("push_publish");
		public static readonly ESearchEntryFieldName RECORDED_ENTRY_ID = new ESearchEntryFieldName("recorded_entry_id");
		public static readonly ESearchEntryFieldName REDIRECT_ENTRY_ID = new ESearchEntryFieldName("redirect_entry_id");
		public static readonly ESearchEntryFieldName REFERENCE_ID = new ESearchEntryFieldName("reference_id");
		public static readonly ESearchEntryFieldName ROOT_ID = new ESearchEntryFieldName("root_id");
		public static readonly ESearchEntryFieldName SITE_URL = new ESearchEntryFieldName("site_url");
		public static readonly ESearchEntryFieldName SOURCE_TYPE = new ESearchEntryFieldName("source_type");
		public static readonly ESearchEntryFieldName START_DATE = new ESearchEntryFieldName("start_date");
		public static readonly ESearchEntryFieldName TAGS = new ESearchEntryFieldName("tags");
		public static readonly ESearchEntryFieldName TEMPLATE_ENTRY_ID = new ESearchEntryFieldName("template_entry_id");
		public static readonly ESearchEntryFieldName UPDATED_AT = new ESearchEntryFieldName("updated_at");
		public static readonly ESearchEntryFieldName USER_NAMES = new ESearchEntryFieldName("user_names");

		private ESearchEntryFieldName(string name) : base(name) { }
	}
}
