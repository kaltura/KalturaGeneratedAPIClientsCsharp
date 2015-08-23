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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public sealed class KalturaBatchJobType : KalturaStringEnum
	{
		public static readonly KalturaBatchJobType CONVERT = new KalturaBatchJobType("0");
		public static readonly KalturaBatchJobType PARSE_MULTI_LANGUAGE_CAPTION_ASSET = new KalturaBatchJobType("caption.parsemultilanguagecaptionasset");
		public static readonly KalturaBatchJobType PARSE_CAPTION_ASSET = new KalturaBatchJobType("captionSearch.parseCaptionAsset");
		public static readonly KalturaBatchJobType DISTRIBUTION_DELETE = new KalturaBatchJobType("contentDistribution.DistributionDelete");
		public static readonly KalturaBatchJobType DISTRIBUTION_DISABLE = new KalturaBatchJobType("contentDistribution.DistributionDisable");
		public static readonly KalturaBatchJobType DISTRIBUTION_ENABLE = new KalturaBatchJobType("contentDistribution.DistributionEnable");
		public static readonly KalturaBatchJobType DISTRIBUTION_FETCH_REPORT = new KalturaBatchJobType("contentDistribution.DistributionFetchReport");
		public static readonly KalturaBatchJobType DISTRIBUTION_SUBMIT = new KalturaBatchJobType("contentDistribution.DistributionSubmit");
		public static readonly KalturaBatchJobType DISTRIBUTION_SYNC = new KalturaBatchJobType("contentDistribution.DistributionSync");
		public static readonly KalturaBatchJobType DISTRIBUTION_UPDATE = new KalturaBatchJobType("contentDistribution.DistributionUpdate");
		public static readonly KalturaBatchJobType DROP_FOLDER_CONTENT_PROCESSOR = new KalturaBatchJobType("dropFolder.DropFolderContentProcessor");
		public static readonly KalturaBatchJobType DROP_FOLDER_WATCHER = new KalturaBatchJobType("dropFolder.DropFolderWatcher");
		public static readonly KalturaBatchJobType EVENT_NOTIFICATION_HANDLER = new KalturaBatchJobType("eventNotification.EventNotificationHandler");
		public static readonly KalturaBatchJobType INTEGRATION = new KalturaBatchJobType("integration.Integration");
		public static readonly KalturaBatchJobType SCHEDULED_TASK = new KalturaBatchJobType("scheduledTask.ScheduledTask");
		public static readonly KalturaBatchJobType INDEX_TAGS = new KalturaBatchJobType("tagSearch.IndexTagsByPrivacyContext");
		public static readonly KalturaBatchJobType TAG_RESOLVE = new KalturaBatchJobType("tagSearch.TagResolve");
		public static readonly KalturaBatchJobType VIRUS_SCAN = new KalturaBatchJobType("virusScan.VirusScan");
		public static readonly KalturaBatchJobType IMPORT = new KalturaBatchJobType("1");
		public static readonly KalturaBatchJobType DELETE = new KalturaBatchJobType("2");
		public static readonly KalturaBatchJobType FLATTEN = new KalturaBatchJobType("3");
		public static readonly KalturaBatchJobType BULKUPLOAD = new KalturaBatchJobType("4");
		public static readonly KalturaBatchJobType DVDCREATOR = new KalturaBatchJobType("5");
		public static readonly KalturaBatchJobType DOWNLOAD = new KalturaBatchJobType("6");
		public static readonly KalturaBatchJobType OOCONVERT = new KalturaBatchJobType("7");
		public static readonly KalturaBatchJobType CONVERT_PROFILE = new KalturaBatchJobType("10");
		public static readonly KalturaBatchJobType POSTCONVERT = new KalturaBatchJobType("11");
		public static readonly KalturaBatchJobType EXTRACT_MEDIA = new KalturaBatchJobType("14");
		public static readonly KalturaBatchJobType MAIL = new KalturaBatchJobType("15");
		public static readonly KalturaBatchJobType NOTIFICATION = new KalturaBatchJobType("16");
		public static readonly KalturaBatchJobType CLEANUP = new KalturaBatchJobType("17");
		public static readonly KalturaBatchJobType SCHEDULER_HELPER = new KalturaBatchJobType("18");
		public static readonly KalturaBatchJobType BULKDOWNLOAD = new KalturaBatchJobType("19");
		public static readonly KalturaBatchJobType DB_CLEANUP = new KalturaBatchJobType("20");
		public static readonly KalturaBatchJobType PROVISION_PROVIDE = new KalturaBatchJobType("21");
		public static readonly KalturaBatchJobType CONVERT_COLLECTION = new KalturaBatchJobType("22");
		public static readonly KalturaBatchJobType STORAGE_EXPORT = new KalturaBatchJobType("23");
		public static readonly KalturaBatchJobType PROVISION_DELETE = new KalturaBatchJobType("24");
		public static readonly KalturaBatchJobType STORAGE_DELETE = new KalturaBatchJobType("25");
		public static readonly KalturaBatchJobType EMAIL_INGESTION = new KalturaBatchJobType("26");
		public static readonly KalturaBatchJobType METADATA_IMPORT = new KalturaBatchJobType("27");
		public static readonly KalturaBatchJobType METADATA_TRANSFORM = new KalturaBatchJobType("28");
		public static readonly KalturaBatchJobType FILESYNC_IMPORT = new KalturaBatchJobType("29");
		public static readonly KalturaBatchJobType CAPTURE_THUMB = new KalturaBatchJobType("30");
		public static readonly KalturaBatchJobType DELETE_FILE = new KalturaBatchJobType("31");
		public static readonly KalturaBatchJobType INDEX = new KalturaBatchJobType("32");
		public static readonly KalturaBatchJobType MOVE_CATEGORY_ENTRIES = new KalturaBatchJobType("33");
		public static readonly KalturaBatchJobType COPY = new KalturaBatchJobType("34");
		public static readonly KalturaBatchJobType CONCAT = new KalturaBatchJobType("35");
		public static readonly KalturaBatchJobType CONVERT_LIVE_SEGMENT = new KalturaBatchJobType("36");
		public static readonly KalturaBatchJobType COPY_PARTNER = new KalturaBatchJobType("37");
		public static readonly KalturaBatchJobType VALIDATE_LIVE_MEDIA_SERVERS = new KalturaBatchJobType("38");
		public static readonly KalturaBatchJobType SYNC_CATEGORY_PRIVACY_CONTEXT = new KalturaBatchJobType("39");
		public static readonly KalturaBatchJobType LIVE_REPORT_EXPORT = new KalturaBatchJobType("40");
		public static readonly KalturaBatchJobType RECALCULATE_CACHE = new KalturaBatchJobType("41");

		private KalturaBatchJobType(string name) : base(name) { }
	}
}
