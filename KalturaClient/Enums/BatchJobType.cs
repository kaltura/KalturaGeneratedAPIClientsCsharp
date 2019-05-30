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
	public sealed class BatchJobType : StringEnum
	{
		public static readonly BatchJobType CONVERT = new BatchJobType("0");
		public static readonly BatchJobType PARSE_MULTI_LANGUAGE_CAPTION_ASSET = new BatchJobType("caption.parsemultilanguagecaptionasset");
		public static readonly BatchJobType PARSE_CAPTION_ASSET = new BatchJobType("captionSearch.parseCaptionAsset");
		public static readonly BatchJobType DISTRIBUTION_DELETE = new BatchJobType("contentDistribution.DistributionDelete");
		public static readonly BatchJobType DISTRIBUTION_DISABLE = new BatchJobType("contentDistribution.DistributionDisable");
		public static readonly BatchJobType DISTRIBUTION_ENABLE = new BatchJobType("contentDistribution.DistributionEnable");
		public static readonly BatchJobType DISTRIBUTION_FETCH_REPORT = new BatchJobType("contentDistribution.DistributionFetchReport");
		public static readonly BatchJobType DISTRIBUTION_SUBMIT = new BatchJobType("contentDistribution.DistributionSubmit");
		public static readonly BatchJobType DISTRIBUTION_SYNC = new BatchJobType("contentDistribution.DistributionSync");
		public static readonly BatchJobType DISTRIBUTION_UPDATE = new BatchJobType("contentDistribution.DistributionUpdate");
		public static readonly BatchJobType DROP_FOLDER_CONTENT_PROCESSOR = new BatchJobType("dropFolder.DropFolderContentProcessor");
		public static readonly BatchJobType DROP_FOLDER_WATCHER = new BatchJobType("dropFolder.DropFolderWatcher");
		public static readonly BatchJobType EVENT_NOTIFICATION_HANDLER = new BatchJobType("eventNotification.EventNotificationHandler");
		public static readonly BatchJobType INTEGRATION = new BatchJobType("integration.Integration");
		public static readonly BatchJobType ENTRY_VENDOR_TASK_CSV = new BatchJobType("reach.EntryVendorTasksCsv");
		public static readonly BatchJobType SYNC_REACH_CREDIT_TASK = new BatchJobType("reach.SyncReachCreditTask");
		public static readonly BatchJobType SCHEDULED_TASK = new BatchJobType("scheduledTask.ScheduledTask");
		public static readonly BatchJobType INDEX_TAGS = new BatchJobType("tagSearch.IndexTagsByPrivacyContext");
		public static readonly BatchJobType TAG_RESOLVE = new BatchJobType("tagSearch.TagResolve");
		public static readonly BatchJobType VIRUS_SCAN = new BatchJobType("virusScan.VirusScan");
		public static readonly BatchJobType WIDEVINE_REPOSITORY_SYNC = new BatchJobType("widevine.WidevineRepositorySync");
		public static readonly BatchJobType IMPORT = new BatchJobType("1");
		public static readonly BatchJobType DELETE = new BatchJobType("2");
		public static readonly BatchJobType FLATTEN = new BatchJobType("3");
		public static readonly BatchJobType BULKUPLOAD = new BatchJobType("4");
		public static readonly BatchJobType DVDCREATOR = new BatchJobType("5");
		public static readonly BatchJobType DOWNLOAD = new BatchJobType("6");
		public static readonly BatchJobType OOCONVERT = new BatchJobType("7");
		public static readonly BatchJobType CONVERT_PROFILE = new BatchJobType("10");
		public static readonly BatchJobType POSTCONVERT = new BatchJobType("11");
		public static readonly BatchJobType EXTRACT_MEDIA = new BatchJobType("14");
		public static readonly BatchJobType MAIL = new BatchJobType("15");
		public static readonly BatchJobType NOTIFICATION = new BatchJobType("16");
		public static readonly BatchJobType CLEANUP = new BatchJobType("17");
		public static readonly BatchJobType SCHEDULER_HELPER = new BatchJobType("18");
		public static readonly BatchJobType BULKDOWNLOAD = new BatchJobType("19");
		public static readonly BatchJobType DB_CLEANUP = new BatchJobType("20");
		public static readonly BatchJobType PROVISION_PROVIDE = new BatchJobType("21");
		public static readonly BatchJobType CONVERT_COLLECTION = new BatchJobType("22");
		public static readonly BatchJobType STORAGE_EXPORT = new BatchJobType("23");
		public static readonly BatchJobType PROVISION_DELETE = new BatchJobType("24");
		public static readonly BatchJobType STORAGE_DELETE = new BatchJobType("25");
		public static readonly BatchJobType EMAIL_INGESTION = new BatchJobType("26");
		public static readonly BatchJobType METADATA_IMPORT = new BatchJobType("27");
		public static readonly BatchJobType METADATA_TRANSFORM = new BatchJobType("28");
		public static readonly BatchJobType FILESYNC_IMPORT = new BatchJobType("29");
		public static readonly BatchJobType CAPTURE_THUMB = new BatchJobType("30");
		public static readonly BatchJobType DELETE_FILE = new BatchJobType("31");
		public static readonly BatchJobType INDEX = new BatchJobType("32");
		public static readonly BatchJobType MOVE_CATEGORY_ENTRIES = new BatchJobType("33");
		public static readonly BatchJobType COPY = new BatchJobType("34");
		public static readonly BatchJobType CONCAT = new BatchJobType("35");
		public static readonly BatchJobType CONVERT_LIVE_SEGMENT = new BatchJobType("36");
		public static readonly BatchJobType COPY_PARTNER = new BatchJobType("37");
		public static readonly BatchJobType VALIDATE_LIVE_MEDIA_SERVERS = new BatchJobType("38");
		public static readonly BatchJobType SYNC_CATEGORY_PRIVACY_CONTEXT = new BatchJobType("39");
		public static readonly BatchJobType LIVE_REPORT_EXPORT = new BatchJobType("40");
		public static readonly BatchJobType RECALCULATE_CACHE = new BatchJobType("41");
		public static readonly BatchJobType LIVE_TO_VOD = new BatchJobType("42");
		public static readonly BatchJobType COPY_CAPTIONS = new BatchJobType("43");
		public static readonly BatchJobType CHUNKED_ENCODE_JOB_SCHEDULER = new BatchJobType("44");
		public static readonly BatchJobType SERVER_NODE_MONITOR = new BatchJobType("45");
		public static readonly BatchJobType USERS_CSV = new BatchJobType("46");
		public static readonly BatchJobType CLIP_CONCAT = new BatchJobType("47");
		public static readonly BatchJobType COPY_CUE_POINTS = new BatchJobType("48");
		public static readonly BatchJobType EXPORT_CSV = new BatchJobType("49");
		public static readonly BatchJobType REPORT_EXPORT = new BatchJobType("50");

		private BatchJobType(string name) : base(name) { }
	}
}
