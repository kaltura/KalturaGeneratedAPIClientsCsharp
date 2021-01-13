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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public sealed class EventNotificationEventObjectType : StringEnum
	{
		public static readonly EventNotificationEventObjectType AD_CUE_POINT = new EventNotificationEventObjectType("adCuePointEventNotifications.AdCuePoint");
		public static readonly EventNotificationEventObjectType ANNOTATION = new EventNotificationEventObjectType("annotationEventNotifications.Annotation");
		public static readonly EventNotificationEventObjectType ATTACHMENT_ASSET = new EventNotificationEventObjectType("attachmentAssetEventNotifications.AttachmentAsset");
		public static readonly EventNotificationEventObjectType CAPTION_ASSET = new EventNotificationEventObjectType("captionAssetEventNotifications.CaptionAsset");
		public static readonly EventNotificationEventObjectType CODE_CUE_POINT = new EventNotificationEventObjectType("codeCuePointEventNotifications.CodeCuePoint");
		public static readonly EventNotificationEventObjectType DISTRIBUTION_PROFILE = new EventNotificationEventObjectType("contentDistributionEventNotifications.DistributionProfile");
		public static readonly EventNotificationEventObjectType ENTRY_DISTRIBUTION = new EventNotificationEventObjectType("contentDistributionEventNotifications.EntryDistribution");
		public static readonly EventNotificationEventObjectType CUE_POINT = new EventNotificationEventObjectType("cuePointEventNotifications.CuePoint");
		public static readonly EventNotificationEventObjectType DROP_FOLDER = new EventNotificationEventObjectType("dropFolderEventNotifications.DropFolder");
		public static readonly EventNotificationEventObjectType DROP_FOLDER_FILE = new EventNotificationEventObjectType("dropFolderEventNotifications.DropFolderFile");
		public static readonly EventNotificationEventObjectType METADATA = new EventNotificationEventObjectType("metadataEventNotifications.Metadata");
		public static readonly EventNotificationEventObjectType TRANSCRIPT_ASSET = new EventNotificationEventObjectType("transcriptAssetEventNotifications.TranscriptAsset");
		public static readonly EventNotificationEventObjectType ENTRY = new EventNotificationEventObjectType("1");
		public static readonly EventNotificationEventObjectType CATEGORY = new EventNotificationEventObjectType("2");
		public static readonly EventNotificationEventObjectType ASSET = new EventNotificationEventObjectType("3");
		public static readonly EventNotificationEventObjectType FLAVORASSET = new EventNotificationEventObjectType("4");
		public static readonly EventNotificationEventObjectType THUMBASSET = new EventNotificationEventObjectType("5");
		public static readonly EventNotificationEventObjectType KUSER = new EventNotificationEventObjectType("8");
		public static readonly EventNotificationEventObjectType ACCESSCONTROL = new EventNotificationEventObjectType("9");
		public static readonly EventNotificationEventObjectType BATCHJOB = new EventNotificationEventObjectType("10");
		public static readonly EventNotificationEventObjectType BULKUPLOADRESULT = new EventNotificationEventObjectType("11");
		public static readonly EventNotificationEventObjectType CATEGORYKUSER = new EventNotificationEventObjectType("12");
		public static readonly EventNotificationEventObjectType CONVERSIONPROFILE2 = new EventNotificationEventObjectType("14");
		public static readonly EventNotificationEventObjectType FLAVORPARAMS = new EventNotificationEventObjectType("15");
		public static readonly EventNotificationEventObjectType FLAVORPARAMSCONVERSIONPROFILE = new EventNotificationEventObjectType("16");
		public static readonly EventNotificationEventObjectType FLAVORPARAMSOUTPUT = new EventNotificationEventObjectType("17");
		public static readonly EventNotificationEventObjectType GENERICSYNDICATIONFEED = new EventNotificationEventObjectType("18");
		public static readonly EventNotificationEventObjectType KUSERTOUSERROLE = new EventNotificationEventObjectType("19");
		public static readonly EventNotificationEventObjectType PARTNER = new EventNotificationEventObjectType("20");
		public static readonly EventNotificationEventObjectType PERMISSION = new EventNotificationEventObjectType("21");
		public static readonly EventNotificationEventObjectType PERMISSIONITEM = new EventNotificationEventObjectType("22");
		public static readonly EventNotificationEventObjectType PERMISSIONTOPERMISSIONITEM = new EventNotificationEventObjectType("23");
		public static readonly EventNotificationEventObjectType SCHEDULER = new EventNotificationEventObjectType("24");
		public static readonly EventNotificationEventObjectType SCHEDULERCONFIG = new EventNotificationEventObjectType("25");
		public static readonly EventNotificationEventObjectType SCHEDULERSTATUS = new EventNotificationEventObjectType("26");
		public static readonly EventNotificationEventObjectType SCHEDULERWORKER = new EventNotificationEventObjectType("27");
		public static readonly EventNotificationEventObjectType STORAGEPROFILE = new EventNotificationEventObjectType("28");
		public static readonly EventNotificationEventObjectType SYNDICATIONFEED = new EventNotificationEventObjectType("29");
		public static readonly EventNotificationEventObjectType THUMBPARAMS = new EventNotificationEventObjectType("31");
		public static readonly EventNotificationEventObjectType THUMBPARAMSOUTPUT = new EventNotificationEventObjectType("32");
		public static readonly EventNotificationEventObjectType UPLOADTOKEN = new EventNotificationEventObjectType("33");
		public static readonly EventNotificationEventObjectType USERLOGINDATA = new EventNotificationEventObjectType("34");
		public static readonly EventNotificationEventObjectType USERROLE = new EventNotificationEventObjectType("35");
		public static readonly EventNotificationEventObjectType WIDGET = new EventNotificationEventObjectType("36");
		public static readonly EventNotificationEventObjectType CATEGORYENTRY = new EventNotificationEventObjectType("37");
		public static readonly EventNotificationEventObjectType LIVE_STREAM = new EventNotificationEventObjectType("38");
		public static readonly EventNotificationEventObjectType SERVER_NODE = new EventNotificationEventObjectType("39");
		public static readonly EventNotificationEventObjectType ENTRY_SERVER_NODE = new EventNotificationEventObjectType("40");
		public static readonly EventNotificationEventObjectType REACH_PROFILE = new EventNotificationEventObjectType("41");
		public static readonly EventNotificationEventObjectType ENTRY_VENDOR_TASK = new EventNotificationEventObjectType("42");

		private EventNotificationEventObjectType(string name) : base(name) { }
	}
}
