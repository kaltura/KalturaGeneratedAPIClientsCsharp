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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public sealed class MailType : StringEnum
	{
		public static readonly MailType MAIL_TYPE_KALTURA_NEWSLETTER = new MailType("10");
		public static readonly MailType MAIL_TYPE_ADDED_TO_FAVORITES = new MailType("11");
		public static readonly MailType MAIL_TYPE_ADDED_TO_CLIP_FAVORITES = new MailType("12");
		public static readonly MailType MAIL_TYPE_NEW_COMMENT_IN_PROFILE = new MailType("13");
		public static readonly MailType MAIL_TYPE_CLIP_ADDED_YOUR_KALTURA = new MailType("20");
		public static readonly MailType MAIL_TYPE_VIDEO_ADDED = new MailType("21");
		public static readonly MailType MAIL_TYPE_ROUGHCUT_CREATED = new MailType("22");
		public static readonly MailType MAIL_TYPE_ADDED_KALTURA_TO_YOUR_FAVORITES = new MailType("23");
		public static readonly MailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA = new MailType("24");
		public static readonly MailType MAIL_TYPE_CLIP_ADDED = new MailType("30");
		public static readonly MailType MAIL_TYPE_VIDEO_CREATED = new MailType("31");
		public static readonly MailType MAIL_TYPE_ADDED_KALTURA_TO_HIS_FAVORITES = new MailType("32");
		public static readonly MailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA_YOU_CONTRIBUTED = new MailType("33");
		public static readonly MailType MAIL_TYPE_CLIP_CONTRIBUTED = new MailType("40");
		public static readonly MailType MAIL_TYPE_ROUGHCUT_CREATED_SUBSCRIBED = new MailType("41");
		public static readonly MailType MAIL_TYPE_ADDED_KALTURA_TO_HIS_FAVORITES_SUBSCRIBED = new MailType("42");
		public static readonly MailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA_YOU_SUBSCRIBED = new MailType("43");
		public static readonly MailType MAIL_TYPE_REGISTER_CONFIRM = new MailType("50");
		public static readonly MailType MAIL_TYPE_PASSWORD_RESET = new MailType("51");
		public static readonly MailType MAIL_TYPE_LOGIN_MAIL_RESET = new MailType("52");
		public static readonly MailType MAIL_TYPE_REGISTER_CONFIRM_VIDEO_SERVICE = new MailType("54");
		public static readonly MailType MAIL_TYPE_VIDEO_READY = new MailType("60");
		public static readonly MailType MAIL_TYPE_VIDEO_IS_READY = new MailType("62");
		public static readonly MailType MAIL_TYPE_BULK_DOWNLOAD_READY = new MailType("63");
		public static readonly MailType MAIL_TYPE_BULKUPLOAD_FINISHED = new MailType("64");
		public static readonly MailType MAIL_TYPE_BULKUPLOAD_FAILED = new MailType("65");
		public static readonly MailType MAIL_TYPE_BULKUPLOAD_ABORTED = new MailType("66");
		public static readonly MailType MAIL_TYPE_NOTIFY_ERR = new MailType("70");
		public static readonly MailType MAIL_TYPE_ACCOUNT_UPGRADE_CONFIRM = new MailType("80");
		public static readonly MailType MAIL_TYPE_VIDEO_SERVICE_NOTICE = new MailType("81");
		public static readonly MailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_LIMIT_REACHED = new MailType("82");
		public static readonly MailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_ACCOUNT_LOCKED = new MailType("83");
		public static readonly MailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_ACCOUNT_DELETED = new MailType("84");
		public static readonly MailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_UPGRADE_OFFER = new MailType("85");
		public static readonly MailType MAIL_TYPE_ACCOUNT_REACTIVE_CONFIRM = new MailType("86");
		public static readonly MailType MAIL_TYPE_SYSTEM_USER_RESET_PASSWORD = new MailType("110");
		public static readonly MailType MAIL_TYPE_SYSTEM_USER_RESET_PASSWORD_SUCCESS = new MailType("111");
		public static readonly MailType MAIL_TYPE_SYSTEM_USER_NEW_PASSWORD = new MailType("112");
		public static readonly MailType MAIL_TYPE_SYSTEM_USER_CREDENTIALS_SAVED = new MailType("113");
		public static readonly MailType MAIL_TYPE_LIVE_REPORT_EXPORT_SUCCESS = new MailType("130");
		public static readonly MailType MAIL_TYPE_LIVE_REPORT_EXPORT_FAILURE = new MailType("131");
		public static readonly MailType MAIL_TYPE_LIVE_REPORT_EXPORT_ABORT = new MailType("132");
		public static readonly MailType MAIL_TYPE_USERS_CSV = new MailType("133");
		public static readonly MailType MAIL_TYPE_OBJECTS_CSV = new MailType("135");
		public static readonly MailType MAIL_TYPE_REPORT_EXPORT_SUCCESS = new MailType("136");
		public static readonly MailType MAIL_TYPE_REPORT_EXPORT_FAILURE = new MailType("137");
		public static readonly MailType MAIL_TYPE_REPORT_EXPORT_ABORT = new MailType("138");

		private MailType(string name) : base(name) { }
	}
}
