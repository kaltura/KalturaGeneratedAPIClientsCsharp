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
// Copyright (C) 2006-2016  Kaltura Inc.
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
using System;
using System.Xml;
using System.Collections.Generic;

namespace Kaltura
{
	public class KalturaSystemPartnerConfiguration : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _PartnerName = null;
		private string _Description = null;
		private string _AdminName = null;
		private string _AdminEmail = null;
		private string _Host = null;
		private string _CdnHost = null;
		private string _CdnHostWhiteList = null;
		private string _ThumbnailHost = null;
		private int _PartnerPackage = Int32.MinValue;
		private int _MonitorUsage = Int32.MinValue;
		private bool? _ModerateContent = null;
		private bool? _StorageDeleteFromKaltura = null;
		private KalturaStorageServePriority _StorageServePriority = (KalturaStorageServePriority)Int32.MinValue;
		private int _KmcVersion = Int32.MinValue;
		private int _RestrictThumbnailByKs = Int32.MinValue;
		private bool? _SupportAnimatedThumbnails = null;
		private int _DefThumbOffset = Int32.MinValue;
		private int _DefThumbDensity = Int32.MinValue;
		private int _UserSessionRoleId = Int32.MinValue;
		private int _AdminSessionRoleId = Int32.MinValue;
		private string _AlwaysAllowedPermissionNames = null;
		private bool? _ImportRemoteSourceForConvert = null;
		private IList<KalturaPermission> _Permissions;
		private string _NotificationsConfig = null;
		private bool? _AllowMultiNotification = null;
		private int _LoginBlockPeriod = Int32.MinValue;
		private int _NumPrevPassToKeep = Int32.MinValue;
		private int _PassReplaceFreq = Int32.MinValue;
		private bool? _IsFirstLogin = null;
		private KalturaPartnerGroupType _PartnerGroupType = (KalturaPartnerGroupType)Int32.MinValue;
		private int _PartnerParentId = Int32.MinValue;
		private IList<KalturaSystemPartnerLimit> _Limits;
		private string _StreamerType = null;
		private string _MediaProtocol = null;
		private string _ExtendedFreeTrailExpiryReason = null;
		private int _ExtendedFreeTrailExpiryDate = Int32.MinValue;
		private int _ExtendedFreeTrail = Int32.MinValue;
		private string _CrmId = null;
		private string _ReferenceId = null;
		private string _CrmLink = null;
		private string _VerticalClasiffication = null;
		private string _PartnerPackageClassOfService = null;
		private bool? _EnableBulkUploadNotificationsEmails = null;
		private string _DeliveryProfileIds = null;
		private bool? _EnforceDelivery = null;
		private string _BulkUploadNotificationsEmail = null;
		private bool? _InternalUse = null;
		private KalturaSourceType _DefaultLiveStreamEntrySourceType = null;
		private string _LiveStreamProvisionParams = null;
		private KalturaBaseEntryFilter _AutoModerateEntryFilter;
		private string _LogoutUrl = null;
		private bool? _DefaultEntitlementEnforcement = null;
		private int _CacheFlavorVersion = Int32.MinValue;
		private int _ApiAccessControlId = Int32.MinValue;
		private string _DefaultDeliveryType = null;
		private string _DefaultEmbedCodeType = null;
		private IList<KalturaKeyBooleanValue> _CustomDeliveryTypes;
		private bool? _RestrictEntryByMetadata = null;
		private KalturaLanguageCode _Language = null;
		private string _AudioThumbEntryId = null;
		private string _LiveThumbEntryId = null;
		private bool? _TimeAlignedRenditions = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string PartnerName
		{
			get { return _PartnerName; }
			set 
			{ 
				_PartnerName = value;
				OnPropertyChanged("PartnerName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string AdminName
		{
			get { return _AdminName; }
			set 
			{ 
				_AdminName = value;
				OnPropertyChanged("AdminName");
			}
		}
		public string AdminEmail
		{
			get { return _AdminEmail; }
			set 
			{ 
				_AdminEmail = value;
				OnPropertyChanged("AdminEmail");
			}
		}
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public string CdnHost
		{
			get { return _CdnHost; }
			set 
			{ 
				_CdnHost = value;
				OnPropertyChanged("CdnHost");
			}
		}
		public string CdnHostWhiteList
		{
			get { return _CdnHostWhiteList; }
			set 
			{ 
				_CdnHostWhiteList = value;
				OnPropertyChanged("CdnHostWhiteList");
			}
		}
		public string ThumbnailHost
		{
			get { return _ThumbnailHost; }
			set 
			{ 
				_ThumbnailHost = value;
				OnPropertyChanged("ThumbnailHost");
			}
		}
		public int PartnerPackage
		{
			get { return _PartnerPackage; }
			set 
			{ 
				_PartnerPackage = value;
				OnPropertyChanged("PartnerPackage");
			}
		}
		public int MonitorUsage
		{
			get { return _MonitorUsage; }
			set 
			{ 
				_MonitorUsage = value;
				OnPropertyChanged("MonitorUsage");
			}
		}
		public bool? ModerateContent
		{
			get { return _ModerateContent; }
			set 
			{ 
				_ModerateContent = value;
				OnPropertyChanged("ModerateContent");
			}
		}
		public bool? StorageDeleteFromKaltura
		{
			get { return _StorageDeleteFromKaltura; }
			set 
			{ 
				_StorageDeleteFromKaltura = value;
				OnPropertyChanged("StorageDeleteFromKaltura");
			}
		}
		public KalturaStorageServePriority StorageServePriority
		{
			get { return _StorageServePriority; }
			set 
			{ 
				_StorageServePriority = value;
				OnPropertyChanged("StorageServePriority");
			}
		}
		public int KmcVersion
		{
			get { return _KmcVersion; }
			set 
			{ 
				_KmcVersion = value;
				OnPropertyChanged("KmcVersion");
			}
		}
		public int RestrictThumbnailByKs
		{
			get { return _RestrictThumbnailByKs; }
			set 
			{ 
				_RestrictThumbnailByKs = value;
				OnPropertyChanged("RestrictThumbnailByKs");
			}
		}
		public bool? SupportAnimatedThumbnails
		{
			get { return _SupportAnimatedThumbnails; }
			set 
			{ 
				_SupportAnimatedThumbnails = value;
				OnPropertyChanged("SupportAnimatedThumbnails");
			}
		}
		public int DefThumbOffset
		{
			get { return _DefThumbOffset; }
			set 
			{ 
				_DefThumbOffset = value;
				OnPropertyChanged("DefThumbOffset");
			}
		}
		public int DefThumbDensity
		{
			get { return _DefThumbDensity; }
			set 
			{ 
				_DefThumbDensity = value;
				OnPropertyChanged("DefThumbDensity");
			}
		}
		public int UserSessionRoleId
		{
			get { return _UserSessionRoleId; }
			set 
			{ 
				_UserSessionRoleId = value;
				OnPropertyChanged("UserSessionRoleId");
			}
		}
		public int AdminSessionRoleId
		{
			get { return _AdminSessionRoleId; }
			set 
			{ 
				_AdminSessionRoleId = value;
				OnPropertyChanged("AdminSessionRoleId");
			}
		}
		public string AlwaysAllowedPermissionNames
		{
			get { return _AlwaysAllowedPermissionNames; }
			set 
			{ 
				_AlwaysAllowedPermissionNames = value;
				OnPropertyChanged("AlwaysAllowedPermissionNames");
			}
		}
		public bool? ImportRemoteSourceForConvert
		{
			get { return _ImportRemoteSourceForConvert; }
			set 
			{ 
				_ImportRemoteSourceForConvert = value;
				OnPropertyChanged("ImportRemoteSourceForConvert");
			}
		}
		public IList<KalturaPermission> Permissions
		{
			get { return _Permissions; }
			set 
			{ 
				_Permissions = value;
				OnPropertyChanged("Permissions");
			}
		}
		public string NotificationsConfig
		{
			get { return _NotificationsConfig; }
			set 
			{ 
				_NotificationsConfig = value;
				OnPropertyChanged("NotificationsConfig");
			}
		}
		public bool? AllowMultiNotification
		{
			get { return _AllowMultiNotification; }
			set 
			{ 
				_AllowMultiNotification = value;
				OnPropertyChanged("AllowMultiNotification");
			}
		}
		public int LoginBlockPeriod
		{
			get { return _LoginBlockPeriod; }
			set 
			{ 
				_LoginBlockPeriod = value;
				OnPropertyChanged("LoginBlockPeriod");
			}
		}
		public int NumPrevPassToKeep
		{
			get { return _NumPrevPassToKeep; }
			set 
			{ 
				_NumPrevPassToKeep = value;
				OnPropertyChanged("NumPrevPassToKeep");
			}
		}
		public int PassReplaceFreq
		{
			get { return _PassReplaceFreq; }
			set 
			{ 
				_PassReplaceFreq = value;
				OnPropertyChanged("PassReplaceFreq");
			}
		}
		public bool? IsFirstLogin
		{
			get { return _IsFirstLogin; }
			set 
			{ 
				_IsFirstLogin = value;
				OnPropertyChanged("IsFirstLogin");
			}
		}
		public KalturaPartnerGroupType PartnerGroupType
		{
			get { return _PartnerGroupType; }
			set 
			{ 
				_PartnerGroupType = value;
				OnPropertyChanged("PartnerGroupType");
			}
		}
		public int PartnerParentId
		{
			get { return _PartnerParentId; }
			set 
			{ 
				_PartnerParentId = value;
				OnPropertyChanged("PartnerParentId");
			}
		}
		public IList<KalturaSystemPartnerLimit> Limits
		{
			get { return _Limits; }
			set 
			{ 
				_Limits = value;
				OnPropertyChanged("Limits");
			}
		}
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		public string MediaProtocol
		{
			get { return _MediaProtocol; }
			set 
			{ 
				_MediaProtocol = value;
				OnPropertyChanged("MediaProtocol");
			}
		}
		public string ExtendedFreeTrailExpiryReason
		{
			get { return _ExtendedFreeTrailExpiryReason; }
			set 
			{ 
				_ExtendedFreeTrailExpiryReason = value;
				OnPropertyChanged("ExtendedFreeTrailExpiryReason");
			}
		}
		public int ExtendedFreeTrailExpiryDate
		{
			get { return _ExtendedFreeTrailExpiryDate; }
			set 
			{ 
				_ExtendedFreeTrailExpiryDate = value;
				OnPropertyChanged("ExtendedFreeTrailExpiryDate");
			}
		}
		public int ExtendedFreeTrail
		{
			get { return _ExtendedFreeTrail; }
			set 
			{ 
				_ExtendedFreeTrail = value;
				OnPropertyChanged("ExtendedFreeTrail");
			}
		}
		public string CrmId
		{
			get { return _CrmId; }
			set 
			{ 
				_CrmId = value;
				OnPropertyChanged("CrmId");
			}
		}
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
			}
		}
		public string CrmLink
		{
			get { return _CrmLink; }
			set 
			{ 
				_CrmLink = value;
				OnPropertyChanged("CrmLink");
			}
		}
		public string VerticalClasiffication
		{
			get { return _VerticalClasiffication; }
			set 
			{ 
				_VerticalClasiffication = value;
				OnPropertyChanged("VerticalClasiffication");
			}
		}
		public string PartnerPackageClassOfService
		{
			get { return _PartnerPackageClassOfService; }
			set 
			{ 
				_PartnerPackageClassOfService = value;
				OnPropertyChanged("PartnerPackageClassOfService");
			}
		}
		public bool? EnableBulkUploadNotificationsEmails
		{
			get { return _EnableBulkUploadNotificationsEmails; }
			set 
			{ 
				_EnableBulkUploadNotificationsEmails = value;
				OnPropertyChanged("EnableBulkUploadNotificationsEmails");
			}
		}
		public string DeliveryProfileIds
		{
			get { return _DeliveryProfileIds; }
			set 
			{ 
				_DeliveryProfileIds = value;
				OnPropertyChanged("DeliveryProfileIds");
			}
		}
		public bool? EnforceDelivery
		{
			get { return _EnforceDelivery; }
			set 
			{ 
				_EnforceDelivery = value;
				OnPropertyChanged("EnforceDelivery");
			}
		}
		public string BulkUploadNotificationsEmail
		{
			get { return _BulkUploadNotificationsEmail; }
			set 
			{ 
				_BulkUploadNotificationsEmail = value;
				OnPropertyChanged("BulkUploadNotificationsEmail");
			}
		}
		public bool? InternalUse
		{
			get { return _InternalUse; }
			set 
			{ 
				_InternalUse = value;
				OnPropertyChanged("InternalUse");
			}
		}
		public KalturaSourceType DefaultLiveStreamEntrySourceType
		{
			get { return _DefaultLiveStreamEntrySourceType; }
			set 
			{ 
				_DefaultLiveStreamEntrySourceType = value;
				OnPropertyChanged("DefaultLiveStreamEntrySourceType");
			}
		}
		public string LiveStreamProvisionParams
		{
			get { return _LiveStreamProvisionParams; }
			set 
			{ 
				_LiveStreamProvisionParams = value;
				OnPropertyChanged("LiveStreamProvisionParams");
			}
		}
		public KalturaBaseEntryFilter AutoModerateEntryFilter
		{
			get { return _AutoModerateEntryFilter; }
			set 
			{ 
				_AutoModerateEntryFilter = value;
				OnPropertyChanged("AutoModerateEntryFilter");
			}
		}
		public string LogoutUrl
		{
			get { return _LogoutUrl; }
			set 
			{ 
				_LogoutUrl = value;
				OnPropertyChanged("LogoutUrl");
			}
		}
		public bool? DefaultEntitlementEnforcement
		{
			get { return _DefaultEntitlementEnforcement; }
			set 
			{ 
				_DefaultEntitlementEnforcement = value;
				OnPropertyChanged("DefaultEntitlementEnforcement");
			}
		}
		public int CacheFlavorVersion
		{
			get { return _CacheFlavorVersion; }
			set 
			{ 
				_CacheFlavorVersion = value;
				OnPropertyChanged("CacheFlavorVersion");
			}
		}
		public int ApiAccessControlId
		{
			get { return _ApiAccessControlId; }
			set 
			{ 
				_ApiAccessControlId = value;
				OnPropertyChanged("ApiAccessControlId");
			}
		}
		public string DefaultDeliveryType
		{
			get { return _DefaultDeliveryType; }
			set 
			{ 
				_DefaultDeliveryType = value;
				OnPropertyChanged("DefaultDeliveryType");
			}
		}
		public string DefaultEmbedCodeType
		{
			get { return _DefaultEmbedCodeType; }
			set 
			{ 
				_DefaultEmbedCodeType = value;
				OnPropertyChanged("DefaultEmbedCodeType");
			}
		}
		public IList<KalturaKeyBooleanValue> CustomDeliveryTypes
		{
			get { return _CustomDeliveryTypes; }
			set 
			{ 
				_CustomDeliveryTypes = value;
				OnPropertyChanged("CustomDeliveryTypes");
			}
		}
		public bool? RestrictEntryByMetadata
		{
			get { return _RestrictEntryByMetadata; }
			set 
			{ 
				_RestrictEntryByMetadata = value;
				OnPropertyChanged("RestrictEntryByMetadata");
			}
		}
		public KalturaLanguageCode Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string AudioThumbEntryId
		{
			get { return _AudioThumbEntryId; }
			set 
			{ 
				_AudioThumbEntryId = value;
				OnPropertyChanged("AudioThumbEntryId");
			}
		}
		public string LiveThumbEntryId
		{
			get { return _LiveThumbEntryId; }
			set 
			{ 
				_LiveThumbEntryId = value;
				OnPropertyChanged("LiveThumbEntryId");
			}
		}
		public bool? TimeAlignedRenditions
		{
			get { return _TimeAlignedRenditions; }
			set 
			{ 
				_TimeAlignedRenditions = value;
				OnPropertyChanged("TimeAlignedRenditions");
			}
		}
		#endregion

		#region CTor
		public KalturaSystemPartnerConfiguration()
		{
		}

		public KalturaSystemPartnerConfiguration(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerName":
						this.PartnerName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "adminName":
						this.AdminName = txt;
						continue;
					case "adminEmail":
						this.AdminEmail = txt;
						continue;
					case "host":
						this.Host = txt;
						continue;
					case "cdnHost":
						this.CdnHost = txt;
						continue;
					case "cdnHostWhiteList":
						this.CdnHostWhiteList = txt;
						continue;
					case "thumbnailHost":
						this.ThumbnailHost = txt;
						continue;
					case "partnerPackage":
						this.PartnerPackage = ParseInt(txt);
						continue;
					case "monitorUsage":
						this.MonitorUsage = ParseInt(txt);
						continue;
					case "moderateContent":
						this.ModerateContent = ParseBool(txt);
						continue;
					case "storageDeleteFromKaltura":
						this.StorageDeleteFromKaltura = ParseBool(txt);
						continue;
					case "storageServePriority":
						this.StorageServePriority = (KalturaStorageServePriority)ParseEnum(typeof(KalturaStorageServePriority), txt);
						continue;
					case "kmcVersion":
						this.KmcVersion = ParseInt(txt);
						continue;
					case "restrictThumbnailByKs":
						this.RestrictThumbnailByKs = ParseInt(txt);
						continue;
					case "supportAnimatedThumbnails":
						this.SupportAnimatedThumbnails = ParseBool(txt);
						continue;
					case "defThumbOffset":
						this.DefThumbOffset = ParseInt(txt);
						continue;
					case "defThumbDensity":
						this.DefThumbDensity = ParseInt(txt);
						continue;
					case "userSessionRoleId":
						this.UserSessionRoleId = ParseInt(txt);
						continue;
					case "adminSessionRoleId":
						this.AdminSessionRoleId = ParseInt(txt);
						continue;
					case "alwaysAllowedPermissionNames":
						this.AlwaysAllowedPermissionNames = txt;
						continue;
					case "importRemoteSourceForConvert":
						this.ImportRemoteSourceForConvert = ParseBool(txt);
						continue;
					case "permissions":
						this.Permissions = new List<KalturaPermission>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Permissions.Add((KalturaPermission)KalturaObjectFactory.Create(arrayNode, "KalturaPermission"));
						}
						continue;
					case "notificationsConfig":
						this.NotificationsConfig = txt;
						continue;
					case "allowMultiNotification":
						this.AllowMultiNotification = ParseBool(txt);
						continue;
					case "loginBlockPeriod":
						this.LoginBlockPeriod = ParseInt(txt);
						continue;
					case "numPrevPassToKeep":
						this.NumPrevPassToKeep = ParseInt(txt);
						continue;
					case "passReplaceFreq":
						this.PassReplaceFreq = ParseInt(txt);
						continue;
					case "isFirstLogin":
						this.IsFirstLogin = ParseBool(txt);
						continue;
					case "partnerGroupType":
						this.PartnerGroupType = (KalturaPartnerGroupType)ParseEnum(typeof(KalturaPartnerGroupType), txt);
						continue;
					case "partnerParentId":
						this.PartnerParentId = ParseInt(txt);
						continue;
					case "limits":
						this.Limits = new List<KalturaSystemPartnerLimit>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Limits.Add((KalturaSystemPartnerLimit)KalturaObjectFactory.Create(arrayNode, "KalturaSystemPartnerLimit"));
						}
						continue;
					case "streamerType":
						this.StreamerType = txt;
						continue;
					case "mediaProtocol":
						this.MediaProtocol = txt;
						continue;
					case "extendedFreeTrailExpiryReason":
						this.ExtendedFreeTrailExpiryReason = txt;
						continue;
					case "extendedFreeTrailExpiryDate":
						this.ExtendedFreeTrailExpiryDate = ParseInt(txt);
						continue;
					case "extendedFreeTrail":
						this.ExtendedFreeTrail = ParseInt(txt);
						continue;
					case "crmId":
						this.CrmId = txt;
						continue;
					case "referenceId":
						this.ReferenceId = txt;
						continue;
					case "crmLink":
						this.CrmLink = txt;
						continue;
					case "verticalClasiffication":
						this.VerticalClasiffication = txt;
						continue;
					case "partnerPackageClassOfService":
						this.PartnerPackageClassOfService = txt;
						continue;
					case "enableBulkUploadNotificationsEmails":
						this.EnableBulkUploadNotificationsEmails = ParseBool(txt);
						continue;
					case "deliveryProfileIds":
						this.DeliveryProfileIds = txt;
						continue;
					case "enforceDelivery":
						this.EnforceDelivery = ParseBool(txt);
						continue;
					case "bulkUploadNotificationsEmail":
						this.BulkUploadNotificationsEmail = txt;
						continue;
					case "internalUse":
						this.InternalUse = ParseBool(txt);
						continue;
					case "defaultLiveStreamEntrySourceType":
						this.DefaultLiveStreamEntrySourceType = (KalturaSourceType)KalturaStringEnum.Parse(typeof(KalturaSourceType), txt);
						continue;
					case "liveStreamProvisionParams":
						this.LiveStreamProvisionParams = txt;
						continue;
					case "autoModerateEntryFilter":
						this.AutoModerateEntryFilter = (KalturaBaseEntryFilter)KalturaObjectFactory.Create(propertyNode, "KalturaBaseEntryFilter");
						continue;
					case "logoutUrl":
						this.LogoutUrl = txt;
						continue;
					case "defaultEntitlementEnforcement":
						this.DefaultEntitlementEnforcement = ParseBool(txt);
						continue;
					case "cacheFlavorVersion":
						this.CacheFlavorVersion = ParseInt(txt);
						continue;
					case "apiAccessControlId":
						this.ApiAccessControlId = ParseInt(txt);
						continue;
					case "defaultDeliveryType":
						this.DefaultDeliveryType = txt;
						continue;
					case "defaultEmbedCodeType":
						this.DefaultEmbedCodeType = txt;
						continue;
					case "customDeliveryTypes":
						this.CustomDeliveryTypes = new List<KalturaKeyBooleanValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.CustomDeliveryTypes.Add((KalturaKeyBooleanValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyBooleanValue"));
						}
						continue;
					case "restrictEntryByMetadata":
						this.RestrictEntryByMetadata = ParseBool(txt);
						continue;
					case "language":
						this.Language = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "audioThumbEntryId":
						this.AudioThumbEntryId = txt;
						continue;
					case "liveThumbEntryId":
						this.LiveThumbEntryId = txt;
						continue;
					case "timeAlignedRenditions":
						this.TimeAlignedRenditions = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSystemPartnerConfiguration");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerName", this.PartnerName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("adminName", this.AdminName);
			kparams.AddIfNotNull("adminEmail", this.AdminEmail);
			kparams.AddIfNotNull("host", this.Host);
			kparams.AddIfNotNull("cdnHost", this.CdnHost);
			kparams.AddIfNotNull("cdnHostWhiteList", this.CdnHostWhiteList);
			kparams.AddIfNotNull("thumbnailHost", this.ThumbnailHost);
			kparams.AddIfNotNull("partnerPackage", this.PartnerPackage);
			kparams.AddIfNotNull("monitorUsage", this.MonitorUsage);
			kparams.AddIfNotNull("moderateContent", this.ModerateContent);
			kparams.AddIfNotNull("storageDeleteFromKaltura", this.StorageDeleteFromKaltura);
			kparams.AddIfNotNull("storageServePriority", this.StorageServePriority);
			kparams.AddIfNotNull("kmcVersion", this.KmcVersion);
			kparams.AddIfNotNull("restrictThumbnailByKs", this.RestrictThumbnailByKs);
			kparams.AddIfNotNull("supportAnimatedThumbnails", this.SupportAnimatedThumbnails);
			kparams.AddIfNotNull("defThumbOffset", this.DefThumbOffset);
			kparams.AddIfNotNull("defThumbDensity", this.DefThumbDensity);
			kparams.AddIfNotNull("userSessionRoleId", this.UserSessionRoleId);
			kparams.AddIfNotNull("adminSessionRoleId", this.AdminSessionRoleId);
			kparams.AddIfNotNull("alwaysAllowedPermissionNames", this.AlwaysAllowedPermissionNames);
			kparams.AddIfNotNull("importRemoteSourceForConvert", this.ImportRemoteSourceForConvert);
			kparams.AddIfNotNull("permissions", this.Permissions);
			kparams.AddIfNotNull("notificationsConfig", this.NotificationsConfig);
			kparams.AddIfNotNull("allowMultiNotification", this.AllowMultiNotification);
			kparams.AddIfNotNull("loginBlockPeriod", this.LoginBlockPeriod);
			kparams.AddIfNotNull("numPrevPassToKeep", this.NumPrevPassToKeep);
			kparams.AddIfNotNull("passReplaceFreq", this.PassReplaceFreq);
			kparams.AddIfNotNull("isFirstLogin", this.IsFirstLogin);
			kparams.AddIfNotNull("partnerGroupType", this.PartnerGroupType);
			kparams.AddIfNotNull("partnerParentId", this.PartnerParentId);
			kparams.AddIfNotNull("limits", this.Limits);
			kparams.AddIfNotNull("streamerType", this.StreamerType);
			kparams.AddIfNotNull("mediaProtocol", this.MediaProtocol);
			kparams.AddIfNotNull("extendedFreeTrailExpiryReason", this.ExtendedFreeTrailExpiryReason);
			kparams.AddIfNotNull("extendedFreeTrailExpiryDate", this.ExtendedFreeTrailExpiryDate);
			kparams.AddIfNotNull("extendedFreeTrail", this.ExtendedFreeTrail);
			kparams.AddIfNotNull("crmId", this.CrmId);
			kparams.AddIfNotNull("referenceId", this.ReferenceId);
			kparams.AddIfNotNull("crmLink", this.CrmLink);
			kparams.AddIfNotNull("verticalClasiffication", this.VerticalClasiffication);
			kparams.AddIfNotNull("partnerPackageClassOfService", this.PartnerPackageClassOfService);
			kparams.AddIfNotNull("enableBulkUploadNotificationsEmails", this.EnableBulkUploadNotificationsEmails);
			kparams.AddIfNotNull("deliveryProfileIds", this.DeliveryProfileIds);
			kparams.AddIfNotNull("enforceDelivery", this.EnforceDelivery);
			kparams.AddIfNotNull("bulkUploadNotificationsEmail", this.BulkUploadNotificationsEmail);
			kparams.AddIfNotNull("internalUse", this.InternalUse);
			kparams.AddIfNotNull("defaultLiveStreamEntrySourceType", this.DefaultLiveStreamEntrySourceType);
			kparams.AddIfNotNull("liveStreamProvisionParams", this.LiveStreamProvisionParams);
			kparams.AddIfNotNull("autoModerateEntryFilter", this.AutoModerateEntryFilter);
			kparams.AddIfNotNull("logoutUrl", this.LogoutUrl);
			kparams.AddIfNotNull("defaultEntitlementEnforcement", this.DefaultEntitlementEnforcement);
			kparams.AddIfNotNull("cacheFlavorVersion", this.CacheFlavorVersion);
			kparams.AddIfNotNull("apiAccessControlId", this.ApiAccessControlId);
			kparams.AddIfNotNull("defaultDeliveryType", this.DefaultDeliveryType);
			kparams.AddIfNotNull("defaultEmbedCodeType", this.DefaultEmbedCodeType);
			kparams.AddIfNotNull("customDeliveryTypes", this.CustomDeliveryTypes);
			kparams.AddIfNotNull("restrictEntryByMetadata", this.RestrictEntryByMetadata);
			kparams.AddIfNotNull("language", this.Language);
			kparams.AddIfNotNull("audioThumbEntryId", this.AudioThumbEntryId);
			kparams.AddIfNotNull("liveThumbEntryId", this.LiveThumbEntryId);
			kparams.AddIfNotNull("timeAlignedRenditions", this.TimeAlignedRenditions);
			return kparams;
		}
		#endregion
	}
}

