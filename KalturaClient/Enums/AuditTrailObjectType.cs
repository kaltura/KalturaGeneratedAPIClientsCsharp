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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public sealed class AuditTrailObjectType : StringEnum
	{
		public static readonly AuditTrailObjectType BATCH_JOB = new AuditTrailObjectType("BatchJob");
		public static readonly AuditTrailObjectType EMAIL_INGESTION_PROFILE = new AuditTrailObjectType("EmailIngestionProfile");
		public static readonly AuditTrailObjectType FILE_SYNC = new AuditTrailObjectType("FileSync");
		public static readonly AuditTrailObjectType KSHOW_KUSER = new AuditTrailObjectType("KshowKuser");
		public static readonly AuditTrailObjectType METADATA = new AuditTrailObjectType("Metadata");
		public static readonly AuditTrailObjectType METADATA_PROFILE = new AuditTrailObjectType("MetadataProfile");
		public static readonly AuditTrailObjectType PARTNER = new AuditTrailObjectType("Partner");
		public static readonly AuditTrailObjectType PERMISSION = new AuditTrailObjectType("Permission");
		public static readonly AuditTrailObjectType REACH_PROFILE = new AuditTrailObjectType("ReachProfile");
		public static readonly AuditTrailObjectType UPLOAD_TOKEN = new AuditTrailObjectType("UploadToken");
		public static readonly AuditTrailObjectType USER_LOGIN_DATA = new AuditTrailObjectType("UserLoginData");
		public static readonly AuditTrailObjectType USER_ROLE = new AuditTrailObjectType("UserRole");
		public static readonly AuditTrailObjectType ACCESS_CONTROL = new AuditTrailObjectType("accessControl");
		public static readonly AuditTrailObjectType CATEGORY = new AuditTrailObjectType("category");
		public static readonly AuditTrailObjectType CONVERSION_PROFILE_2 = new AuditTrailObjectType("conversionProfile2");
		public static readonly AuditTrailObjectType ENTRY = new AuditTrailObjectType("entry");
		public static readonly AuditTrailObjectType FLAVOR_ASSET = new AuditTrailObjectType("flavorAsset");
		public static readonly AuditTrailObjectType FLAVOR_PARAMS = new AuditTrailObjectType("flavorParams");
		public static readonly AuditTrailObjectType FLAVOR_PARAMS_CONVERSION_PROFILE = new AuditTrailObjectType("flavorParamsConversionProfile");
		public static readonly AuditTrailObjectType FLAVOR_PARAMS_OUTPUT = new AuditTrailObjectType("flavorParamsOutput");
		public static readonly AuditTrailObjectType KSHOW = new AuditTrailObjectType("kshow");
		public static readonly AuditTrailObjectType KUSER = new AuditTrailObjectType("kuser");
		public static readonly AuditTrailObjectType MEDIA_INFO = new AuditTrailObjectType("mediaInfo");
		public static readonly AuditTrailObjectType MODERATION = new AuditTrailObjectType("moderation");
		public static readonly AuditTrailObjectType ROUGHCUT = new AuditTrailObjectType("roughcutEntry");
		public static readonly AuditTrailObjectType SYNDICATION = new AuditTrailObjectType("syndicationFeed");
		public static readonly AuditTrailObjectType THUMBNAIL_ASSET = new AuditTrailObjectType("thumbAsset");
		public static readonly AuditTrailObjectType THUMBNAIL_PARAMS = new AuditTrailObjectType("thumbParams");
		public static readonly AuditTrailObjectType THUMBNAIL_PARAMS_OUTPUT = new AuditTrailObjectType("thumbParamsOutput");
		public static readonly AuditTrailObjectType UI_CONF = new AuditTrailObjectType("uiConf");
		public static readonly AuditTrailObjectType WIDGET = new AuditTrailObjectType("widget");

		private AuditTrailObjectType(string name) : base(name) { }
	}
}
