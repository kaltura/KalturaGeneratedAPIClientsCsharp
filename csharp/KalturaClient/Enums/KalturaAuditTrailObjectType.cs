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
	public sealed class KalturaAuditTrailObjectType : KalturaStringEnum
	{
		public static readonly KalturaAuditTrailObjectType BATCH_JOB = new KalturaAuditTrailObjectType("BatchJob");
		public static readonly KalturaAuditTrailObjectType EMAIL_INGESTION_PROFILE = new KalturaAuditTrailObjectType("EmailIngestionProfile");
		public static readonly KalturaAuditTrailObjectType FILE_SYNC = new KalturaAuditTrailObjectType("FileSync");
		public static readonly KalturaAuditTrailObjectType KSHOW_KUSER = new KalturaAuditTrailObjectType("KshowKuser");
		public static readonly KalturaAuditTrailObjectType METADATA = new KalturaAuditTrailObjectType("Metadata");
		public static readonly KalturaAuditTrailObjectType METADATA_PROFILE = new KalturaAuditTrailObjectType("MetadataProfile");
		public static readonly KalturaAuditTrailObjectType PARTNER = new KalturaAuditTrailObjectType("Partner");
		public static readonly KalturaAuditTrailObjectType PERMISSION = new KalturaAuditTrailObjectType("Permission");
		public static readonly KalturaAuditTrailObjectType UPLOAD_TOKEN = new KalturaAuditTrailObjectType("UploadToken");
		public static readonly KalturaAuditTrailObjectType USER_LOGIN_DATA = new KalturaAuditTrailObjectType("UserLoginData");
		public static readonly KalturaAuditTrailObjectType USER_ROLE = new KalturaAuditTrailObjectType("UserRole");
		public static readonly KalturaAuditTrailObjectType ACCESS_CONTROL = new KalturaAuditTrailObjectType("accessControl");
		public static readonly KalturaAuditTrailObjectType CATEGORY = new KalturaAuditTrailObjectType("category");
		public static readonly KalturaAuditTrailObjectType CONVERSION_PROFILE_2 = new KalturaAuditTrailObjectType("conversionProfile2");
		public static readonly KalturaAuditTrailObjectType ENTRY = new KalturaAuditTrailObjectType("entry");
		public static readonly KalturaAuditTrailObjectType FLAVOR_ASSET = new KalturaAuditTrailObjectType("flavorAsset");
		public static readonly KalturaAuditTrailObjectType FLAVOR_PARAMS = new KalturaAuditTrailObjectType("flavorParams");
		public static readonly KalturaAuditTrailObjectType FLAVOR_PARAMS_CONVERSION_PROFILE = new KalturaAuditTrailObjectType("flavorParamsConversionProfile");
		public static readonly KalturaAuditTrailObjectType FLAVOR_PARAMS_OUTPUT = new KalturaAuditTrailObjectType("flavorParamsOutput");
		public static readonly KalturaAuditTrailObjectType KSHOW = new KalturaAuditTrailObjectType("kshow");
		public static readonly KalturaAuditTrailObjectType KUSER = new KalturaAuditTrailObjectType("kuser");
		public static readonly KalturaAuditTrailObjectType MEDIA_INFO = new KalturaAuditTrailObjectType("mediaInfo");
		public static readonly KalturaAuditTrailObjectType MODERATION = new KalturaAuditTrailObjectType("moderation");
		public static readonly KalturaAuditTrailObjectType ROUGHCUT = new KalturaAuditTrailObjectType("roughcutEntry");
		public static readonly KalturaAuditTrailObjectType SYNDICATION = new KalturaAuditTrailObjectType("syndicationFeed");
		public static readonly KalturaAuditTrailObjectType THUMBNAIL_ASSET = new KalturaAuditTrailObjectType("thumbAsset");
		public static readonly KalturaAuditTrailObjectType THUMBNAIL_PARAMS = new KalturaAuditTrailObjectType("thumbParams");
		public static readonly KalturaAuditTrailObjectType THUMBNAIL_PARAMS_OUTPUT = new KalturaAuditTrailObjectType("thumbParamsOutput");
		public static readonly KalturaAuditTrailObjectType UI_CONF = new KalturaAuditTrailObjectType("uiConf");
		public static readonly KalturaAuditTrailObjectType WIDGET = new KalturaAuditTrailObjectType("widget");

		private KalturaAuditTrailObjectType(string name) : base(name) { }
	}
}
