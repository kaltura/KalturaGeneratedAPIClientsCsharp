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
	public sealed class KalturaMailType : KalturaStringEnum
	{
		public static readonly KalturaMailType MAIL_TYPE_KALTURA_NEWSLETTER = new KalturaMailType("10");
		public static readonly KalturaMailType MAIL_TYPE_ADDED_TO_FAVORITES = new KalturaMailType("11");
		public static readonly KalturaMailType MAIL_TYPE_ADDED_TO_CLIP_FAVORITES = new KalturaMailType("12");
		public static readonly KalturaMailType MAIL_TYPE_NEW_COMMENT_IN_PROFILE = new KalturaMailType("13");
		public static readonly KalturaMailType MAIL_TYPE_CLIP_ADDED_YOUR_KALTURA = new KalturaMailType("20");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_ADDED = new KalturaMailType("21");
		public static readonly KalturaMailType MAIL_TYPE_ROUGHCUT_CREATED = new KalturaMailType("22");
		public static readonly KalturaMailType MAIL_TYPE_ADDED_KALTURA_TO_YOUR_FAVORITES = new KalturaMailType("23");
		public static readonly KalturaMailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA = new KalturaMailType("24");
		public static readonly KalturaMailType MAIL_TYPE_CLIP_ADDED = new KalturaMailType("30");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_CREATED = new KalturaMailType("31");
		public static readonly KalturaMailType MAIL_TYPE_ADDED_KALTURA_TO_HIS_FAVORITES = new KalturaMailType("32");
		public static readonly KalturaMailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA_YOU_CONTRIBUTED = new KalturaMailType("33");
		public static readonly KalturaMailType MAIL_TYPE_CLIP_CONTRIBUTED = new KalturaMailType("40");
		public static readonly KalturaMailType MAIL_TYPE_ROUGHCUT_CREATED_SUBSCRIBED = new KalturaMailType("41");
		public static readonly KalturaMailType MAIL_TYPE_ADDED_KALTURA_TO_HIS_FAVORITES_SUBSCRIBED = new KalturaMailType("42");
		public static readonly KalturaMailType MAIL_TYPE_NEW_COMMENT_IN_KALTURA_YOU_SUBSCRIBED = new KalturaMailType("43");
		public static readonly KalturaMailType MAIL_TYPE_REGISTER_CONFIRM = new KalturaMailType("50");
		public static readonly KalturaMailType MAIL_TYPE_PASSWORD_RESET = new KalturaMailType("51");
		public static readonly KalturaMailType MAIL_TYPE_LOGIN_MAIL_RESET = new KalturaMailType("52");
		public static readonly KalturaMailType MAIL_TYPE_REGISTER_CONFIRM_VIDEO_SERVICE = new KalturaMailType("54");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_READY = new KalturaMailType("60");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_IS_READY = new KalturaMailType("62");
		public static readonly KalturaMailType MAIL_TYPE_BULK_DOWNLOAD_READY = new KalturaMailType("63");
		public static readonly KalturaMailType MAIL_TYPE_BULKUPLOAD_FINISHED = new KalturaMailType("64");
		public static readonly KalturaMailType MAIL_TYPE_BULKUPLOAD_FAILED = new KalturaMailType("65");
		public static readonly KalturaMailType MAIL_TYPE_BULKUPLOAD_ABORTED = new KalturaMailType("66");
		public static readonly KalturaMailType MAIL_TYPE_NOTIFY_ERR = new KalturaMailType("70");
		public static readonly KalturaMailType MAIL_TYPE_ACCOUNT_UPGRADE_CONFIRM = new KalturaMailType("80");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_SERVICE_NOTICE = new KalturaMailType("81");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_LIMIT_REACHED = new KalturaMailType("82");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_ACCOUNT_LOCKED = new KalturaMailType("83");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_ACCOUNT_DELETED = new KalturaMailType("84");
		public static readonly KalturaMailType MAIL_TYPE_VIDEO_SERVICE_NOTICE_UPGRADE_OFFER = new KalturaMailType("85");
		public static readonly KalturaMailType MAIL_TYPE_ACCOUNT_REACTIVE_CONFIRM = new KalturaMailType("86");
		public static readonly KalturaMailType MAIL_TYPE_SYSTEM_USER_RESET_PASSWORD = new KalturaMailType("110");
		public static readonly KalturaMailType MAIL_TYPE_SYSTEM_USER_RESET_PASSWORD_SUCCESS = new KalturaMailType("111");
		public static readonly KalturaMailType MAIL_TYPE_SYSTEM_USER_NEW_PASSWORD = new KalturaMailType("112");
		public static readonly KalturaMailType MAIL_TYPE_SYSTEM_USER_CREDENTIALS_SAVED = new KalturaMailType("113");
		public static readonly KalturaMailType MAIL_TYPE_LIVE_REPORT_EXPORT_SUCCESS = new KalturaMailType("130");
		public static readonly KalturaMailType MAIL_TYPE_LIVE_REPORT_EXPORT_FAILURE = new KalturaMailType("131");
		public static readonly KalturaMailType MAIL_TYPE_LIVE_REPORT_EXPORT_ABORT = new KalturaMailType("132");

		private KalturaMailType(string name) : base(name) { }
	}
}
