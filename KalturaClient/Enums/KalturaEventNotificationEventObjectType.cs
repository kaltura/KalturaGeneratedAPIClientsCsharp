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
	public sealed class KalturaEventNotificationEventObjectType : KalturaStringEnum
	{
		public static readonly KalturaEventNotificationEventObjectType AD_CUE_POINT = new KalturaEventNotificationEventObjectType("adCuePointEventNotifications.AdCuePoint");
		public static readonly KalturaEventNotificationEventObjectType ANNOTATION = new KalturaEventNotificationEventObjectType("annotationEventNotifications.Annotation");
		public static readonly KalturaEventNotificationEventObjectType ATTACHMENT_ASSET = new KalturaEventNotificationEventObjectType("attachmentAssetEventNotifications.AttachmentAsset");
		public static readonly KalturaEventNotificationEventObjectType CAPTION_ASSET = new KalturaEventNotificationEventObjectType("captionAssetEventNotifications.CaptionAsset");
		public static readonly KalturaEventNotificationEventObjectType CODE_CUE_POINT = new KalturaEventNotificationEventObjectType("codeCuePointEventNotifications.CodeCuePoint");
		public static readonly KalturaEventNotificationEventObjectType DISTRIBUTION_PROFILE = new KalturaEventNotificationEventObjectType("contentDistributionEventNotifications.DistributionProfile");
		public static readonly KalturaEventNotificationEventObjectType ENTRY_DISTRIBUTION = new KalturaEventNotificationEventObjectType("contentDistributionEventNotifications.EntryDistribution");
		public static readonly KalturaEventNotificationEventObjectType CUE_POINT = new KalturaEventNotificationEventObjectType("cuePointEventNotifications.CuePoint");
		public static readonly KalturaEventNotificationEventObjectType DROP_FOLDER = new KalturaEventNotificationEventObjectType("dropFolderEventNotifications.DropFolder");
		public static readonly KalturaEventNotificationEventObjectType DROP_FOLDER_FILE = new KalturaEventNotificationEventObjectType("dropFolderEventNotifications.DropFolderFile");
		public static readonly KalturaEventNotificationEventObjectType METADATA = new KalturaEventNotificationEventObjectType("metadataEventNotifications.Metadata");
		public static readonly KalturaEventNotificationEventObjectType TRANSCRIPT_ASSET = new KalturaEventNotificationEventObjectType("transcriptAssetEventNotifications.TranscriptAsset");
		public static readonly KalturaEventNotificationEventObjectType ENTRY = new KalturaEventNotificationEventObjectType("1");
		public static readonly KalturaEventNotificationEventObjectType CATEGORY = new KalturaEventNotificationEventObjectType("2");
		public static readonly KalturaEventNotificationEventObjectType ASSET = new KalturaEventNotificationEventObjectType("3");
		public static readonly KalturaEventNotificationEventObjectType FLAVORASSET = new KalturaEventNotificationEventObjectType("4");
		public static readonly KalturaEventNotificationEventObjectType THUMBASSET = new KalturaEventNotificationEventObjectType("5");
		public static readonly KalturaEventNotificationEventObjectType KUSER = new KalturaEventNotificationEventObjectType("8");
		public static readonly KalturaEventNotificationEventObjectType ACCESSCONTROL = new KalturaEventNotificationEventObjectType("9");
		public static readonly KalturaEventNotificationEventObjectType BATCHJOB = new KalturaEventNotificationEventObjectType("10");
		public static readonly KalturaEventNotificationEventObjectType BULKUPLOADRESULT = new KalturaEventNotificationEventObjectType("11");
		public static readonly KalturaEventNotificationEventObjectType CATEGORYKUSER = new KalturaEventNotificationEventObjectType("12");
		public static readonly KalturaEventNotificationEventObjectType CONVERSIONPROFILE2 = new KalturaEventNotificationEventObjectType("14");
		public static readonly KalturaEventNotificationEventObjectType FLAVORPARAMS = new KalturaEventNotificationEventObjectType("15");
		public static readonly KalturaEventNotificationEventObjectType FLAVORPARAMSCONVERSIONPROFILE = new KalturaEventNotificationEventObjectType("16");
		public static readonly KalturaEventNotificationEventObjectType FLAVORPARAMSOUTPUT = new KalturaEventNotificationEventObjectType("17");
		public static readonly KalturaEventNotificationEventObjectType GENERICSYNDICATIONFEED = new KalturaEventNotificationEventObjectType("18");
		public static readonly KalturaEventNotificationEventObjectType KUSERTOUSERROLE = new KalturaEventNotificationEventObjectType("19");
		public static readonly KalturaEventNotificationEventObjectType PARTNER = new KalturaEventNotificationEventObjectType("20");
		public static readonly KalturaEventNotificationEventObjectType PERMISSION = new KalturaEventNotificationEventObjectType("21");
		public static readonly KalturaEventNotificationEventObjectType PERMISSIONITEM = new KalturaEventNotificationEventObjectType("22");
		public static readonly KalturaEventNotificationEventObjectType PERMISSIONTOPERMISSIONITEM = new KalturaEventNotificationEventObjectType("23");
		public static readonly KalturaEventNotificationEventObjectType SCHEDULER = new KalturaEventNotificationEventObjectType("24");
		public static readonly KalturaEventNotificationEventObjectType SCHEDULERCONFIG = new KalturaEventNotificationEventObjectType("25");
		public static readonly KalturaEventNotificationEventObjectType SCHEDULERSTATUS = new KalturaEventNotificationEventObjectType("26");
		public static readonly KalturaEventNotificationEventObjectType SCHEDULERWORKER = new KalturaEventNotificationEventObjectType("27");
		public static readonly KalturaEventNotificationEventObjectType STORAGEPROFILE = new KalturaEventNotificationEventObjectType("28");
		public static readonly KalturaEventNotificationEventObjectType SYNDICATIONFEED = new KalturaEventNotificationEventObjectType("29");
		public static readonly KalturaEventNotificationEventObjectType THUMBPARAMS = new KalturaEventNotificationEventObjectType("31");
		public static readonly KalturaEventNotificationEventObjectType THUMBPARAMSOUTPUT = new KalturaEventNotificationEventObjectType("32");
		public static readonly KalturaEventNotificationEventObjectType UPLOADTOKEN = new KalturaEventNotificationEventObjectType("33");
		public static readonly KalturaEventNotificationEventObjectType USERLOGINDATA = new KalturaEventNotificationEventObjectType("34");
		public static readonly KalturaEventNotificationEventObjectType USERROLE = new KalturaEventNotificationEventObjectType("35");
		public static readonly KalturaEventNotificationEventObjectType WIDGET = new KalturaEventNotificationEventObjectType("36");
		public static readonly KalturaEventNotificationEventObjectType CATEGORYENTRY = new KalturaEventNotificationEventObjectType("37");

		private KalturaEventNotificationEventObjectType(string name) : base(name) { }
	}
}
