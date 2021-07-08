// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class Partner : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string NAME = "name";
		public const string WEBSITE = "website";
		public const string NOTIFICATION_URL = "notificationUrl";
		public const string APPEAR_IN_SEARCH = "appearInSearch";
		public const string CREATED_AT = "createdAt";
		public const string ADMIN_NAME = "adminName";
		public const string ADMIN_EMAIL = "adminEmail";
		public const string DESCRIPTION = "description";
		public const string COMMERCIAL_USE = "commercialUse";
		public const string LANDING_PAGE = "landingPage";
		public const string USER_LANDING_PAGE = "userLandingPage";
		public const string CONTENT_CATEGORIES = "contentCategories";
		public const string TYPE = "type";
		public const string PHONE = "phone";
		public const string DESCRIBE_YOURSELF = "describeYourself";
		public const string ADULT_CONTENT = "adultContent";
		public const string DEF_CONVERSION_PROFILE_TYPE = "defConversionProfileType";
		public const string NOTIFY = "notify";
		public const string STATUS = "status";
		public const string ALLOW_QUICK_EDIT = "allowQuickEdit";
		public const string MERGE_ENTRY_LISTS = "mergeEntryLists";
		public const string NOTIFICATIONS_CONFIG = "notificationsConfig";
		public const string ALLOWED_FROM_EMAIL_WHITE_LIST = "allowedFromEmailWhiteList";
		public const string MAX_UPLOAD_SIZE = "maxUploadSize";
		public const string PARTNER_PACKAGE = "partnerPackage";
		public const string SECRET = "secret";
		public const string ADMIN_SECRET = "adminSecret";
		public const string CMS_PASSWORD = "cmsPassword";
		public const string ALLOW_MULTI_NOTIFICATION = "allowMultiNotification";
		public const string ADMIN_LOGIN_USERS_QUOTA = "adminLoginUsersQuota";
		public const string ADMIN_USER_ID = "adminUserId";
		public const string FIRST_NAME = "firstName";
		public const string LAST_NAME = "lastName";
		public const string COUNTRY = "country";
		public const string STATE = "state";
		public const string ADDITIONAL_PARAMS = "additionalParams";
		public const string PUBLISHERS_QUOTA = "publishersQuota";
		public const string PARTNER_GROUP_TYPE = "partnerGroupType";
		public const string DEFAULT_ENTITLEMENT_ENFORCEMENT = "defaultEntitlementEnforcement";
		public const string DEFAULT_DELIVERY_TYPE = "defaultDeliveryType";
		public const string DEFAULT_EMBED_CODE_TYPE = "defaultEmbedCodeType";
		public const string DELIVERY_TYPES = "deliveryTypes";
		public const string EMBED_CODE_TYPES = "embedCodeTypes";
		public const string TEMPLATE_PARTNER_ID = "templatePartnerId";
		public const string IGNORE_SEO_LINKS = "ignoreSeoLinks";
		public const string BLOCK_DIRECT_LOGIN = "blockDirectLogin";
		public const string HOST = "host";
		public const string CDN_HOST = "cdnHost";
		public const string IS_FIRST_LOGIN = "isFirstLogin";
		public const string LOGOUT_URL = "logoutUrl";
		public const string PARTNER_PARENT_ID = "partnerParentId";
		public const string CRM_ID = "crmId";
		public const string REFERENCE_ID = "referenceId";
		public const string TIME_ALIGNED_RENDITIONS = "timeAlignedRenditions";
		public const string PUBLISHER_ENVIRONMENT_TYPE = "publisherEnvironmentType";
		public const string OVP_ENVIRONMENT_URL = "ovpEnvironmentUrl";
		public const string OTT_ENVIRONMENT_URL = "ottEnvironmentUrl";
		public const string ESEARCH_LANGUAGES = "eSearchLanguages";
		public const string AUTHENTICATION_TYPE = "authenticationType";
		public const string EXTENDED_FREE_TRAIL_EXPIRY_REASON = "extendedFreeTrailExpiryReason";
		public const string EXTENDED_FREE_TRAIL_EXPIRY_DATE = "extendedFreeTrailExpiryDate";
		public const string EXTENDED_FREE_TRAIL = "extendedFreeTrail";
		public const string EXTENDED_FREE_TRAIL_ENDS_WARNING = "extendedFreeTrailEndsWarning";
		public const string EIGHTY_PERCENT_WARNING = "eightyPercentWarning";
		public const string USAGE_LIMIT_WARNING = "usageLimitWarning";
		public const string LAST_FREE_TRIAL_NOTIFICATION_DAY = "lastFreeTrialNotificationDay";
		public const string MONITOR_USAGE = "monitorUsage";
		public const string PASSWORD_STRUCTURE_VALIDATIONS = "passwordStructureValidations";
		public const string PASSWORD_STRUCTURE_VALIDATIONS_DESCRIPTION = "passwordStructureValidationsDescription";
		public const string PASS_REPLACE_FREQ = "passReplaceFreq";
		public const string MAX_LOGIN_ATTEMPTS = "maxLoginAttempts";
		public const string LOGIN_BLOCK_PERIOD = "loginBlockPeriod";
		public const string NUM_PREV_PASS_TO_KEEP = "numPrevPassToKeep";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _Name = null;
		private string _Website = null;
		private string _NotificationUrl = null;
		private int _AppearInSearch = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private string _AdminName = null;
		private string _AdminEmail = null;
		private string _Description = null;
		private CommercialUseType _CommercialUse = (CommercialUseType)Int32.MinValue;
		private string _LandingPage = null;
		private string _UserLandingPage = null;
		private string _ContentCategories = null;
		private PartnerType _Type = (PartnerType)Int32.MinValue;
		private string _Phone = null;
		private string _DescribeYourself = null;
		private bool? _AdultContent = null;
		private string _DefConversionProfileType = null;
		private int _Notify = Int32.MinValue;
		private PartnerStatus _Status = (PartnerStatus)Int32.MinValue;
		private int _AllowQuickEdit = Int32.MinValue;
		private int _MergeEntryLists = Int32.MinValue;
		private string _NotificationsConfig = null;
		private string _AllowedFromEmailWhiteList = null;
		private int _MaxUploadSize = Int32.MinValue;
		private int _PartnerPackage = Int32.MinValue;
		private string _Secret = null;
		private string _AdminSecret = null;
		private string _CmsPassword = null;
		private int _AllowMultiNotification = Int32.MinValue;
		private int _AdminLoginUsersQuota = Int32.MinValue;
		private string _AdminUserId = null;
		private string _FirstName = null;
		private string _LastName = null;
		private string _Country = null;
		private string _State = null;
		private IList<KeyValue> _AdditionalParams;
		private int _PublishersQuota = Int32.MinValue;
		private PartnerGroupType _PartnerGroupType = (PartnerGroupType)Int32.MinValue;
		private bool? _DefaultEntitlementEnforcement = null;
		private string _DefaultDeliveryType = null;
		private string _DefaultEmbedCodeType = null;
		private IList<PlayerDeliveryType> _DeliveryTypes;
		private IList<PlayerEmbedCodeType> _EmbedCodeTypes;
		private int _TemplatePartnerId = Int32.MinValue;
		private bool? _IgnoreSeoLinks = null;
		private bool? _BlockDirectLogin = null;
		private string _Host = null;
		private string _CdnHost = null;
		private bool? _IsFirstLogin = null;
		private string _LogoutUrl = null;
		private int _PartnerParentId = Int32.MinValue;
		private string _CrmId = null;
		private string _ReferenceId = null;
		private bool? _TimeAlignedRenditions = null;
		private int _PublisherEnvironmentType = Int32.MinValue;
		private string _OvpEnvironmentUrl = null;
		private string _OttEnvironmentUrl = null;
		private IList<ESearchLanguageItem> _ESearchLanguages;
		private PartnerAuthenticationType _AuthenticationType = (PartnerAuthenticationType)Int32.MinValue;
		private string _ExtendedFreeTrailExpiryReason = null;
		private int _ExtendedFreeTrailExpiryDate = Int32.MinValue;
		private int _ExtendedFreeTrail = Int32.MinValue;
		private bool? _ExtendedFreeTrailEndsWarning = null;
		private int _EightyPercentWarning = Int32.MinValue;
		private int _UsageLimitWarning = Int32.MinValue;
		private int _LastFreeTrialNotificationDay = Int32.MinValue;
		private int _MonitorUsage = Int32.MinValue;
		private string _PasswordStructureValidations = null;
		private string _PasswordStructureValidationsDescription = null;
		private int _PassReplaceFreq = Int32.MinValue;
		private int _MaxLoginAttempts = Int32.MinValue;
		private int _LoginBlockPeriod = Int32.MinValue;
		private int _NumPrevPassToKeep = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use WebsiteAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Website
		{
			get { return _Website; }
			set 
			{ 
				_Website = value;
				OnPropertyChanged("Website");
			}
		}
		/// <summary>
		/// Use NotificationUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NotificationUrl
		{
			get { return _NotificationUrl; }
			set 
			{ 
				_NotificationUrl = value;
				OnPropertyChanged("NotificationUrl");
			}
		}
		/// <summary>
		/// Use AppearInSearchAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AppearInSearch
		{
			get { return _AppearInSearch; }
			set 
			{ 
				_AppearInSearch = value;
				OnPropertyChanged("AppearInSearch");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use AdminNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminName
		{
			get { return _AdminName; }
			set 
			{ 
				_AdminName = value;
				OnPropertyChanged("AdminName");
			}
		}
		/// <summary>
		/// Use AdminEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminEmail
		{
			get { return _AdminEmail; }
			set 
			{ 
				_AdminEmail = value;
				OnPropertyChanged("AdminEmail");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use CommercialUseAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CommercialUseType CommercialUse
		{
			get { return _CommercialUse; }
			set 
			{ 
				_CommercialUse = value;
				OnPropertyChanged("CommercialUse");
			}
		}
		/// <summary>
		/// Use LandingPageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		/// <summary>
		/// Use UserLandingPageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserLandingPage
		{
			get { return _UserLandingPage; }
			set 
			{ 
				_UserLandingPage = value;
				OnPropertyChanged("UserLandingPage");
			}
		}
		/// <summary>
		/// Use ContentCategoriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContentCategories
		{
			get { return _ContentCategories; }
			set 
			{ 
				_ContentCategories = value;
				OnPropertyChanged("ContentCategories");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PartnerType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use PhoneAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Phone
		{
			get { return _Phone; }
			set 
			{ 
				_Phone = value;
				OnPropertyChanged("Phone");
			}
		}
		/// <summary>
		/// Use DescribeYourselfAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DescribeYourself
		{
			get { return _DescribeYourself; }
			set 
			{ 
				_DescribeYourself = value;
				OnPropertyChanged("DescribeYourself");
			}
		}
		/// <summary>
		/// Use AdultContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		/// <summary>
		/// Use DefConversionProfileTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefConversionProfileType
		{
			get { return _DefConversionProfileType; }
			set 
			{ 
				_DefConversionProfileType = value;
				OnPropertyChanged("DefConversionProfileType");
			}
		}
		/// <summary>
		/// Use NotifyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Notify
		{
			get { return _Notify; }
			set 
			{ 
				_Notify = value;
				OnPropertyChanged("Notify");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PartnerStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use AllowQuickEditAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AllowQuickEdit
		{
			get { return _AllowQuickEdit; }
			set 
			{ 
				_AllowQuickEdit = value;
				OnPropertyChanged("AllowQuickEdit");
			}
		}
		/// <summary>
		/// Use MergeEntryListsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MergeEntryLists
		{
			get { return _MergeEntryLists; }
			set 
			{ 
				_MergeEntryLists = value;
				OnPropertyChanged("MergeEntryLists");
			}
		}
		/// <summary>
		/// Use NotificationsConfigAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NotificationsConfig
		{
			get { return _NotificationsConfig; }
			set 
			{ 
				_NotificationsConfig = value;
				OnPropertyChanged("NotificationsConfig");
			}
		}
		/// <summary>
		/// Use AllowedFromEmailWhiteListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AllowedFromEmailWhiteList
		{
			get { return _AllowedFromEmailWhiteList; }
			set 
			{ 
				_AllowedFromEmailWhiteList = value;
				OnPropertyChanged("AllowedFromEmailWhiteList");
			}
		}
		/// <summary>
		/// Use MaxUploadSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxUploadSize
		{
			get { return _MaxUploadSize; }
			set 
			{ 
				_MaxUploadSize = value;
				OnPropertyChanged("MaxUploadSize");
			}
		}
		/// <summary>
		/// Use PartnerPackageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerPackage
		{
			get { return _PartnerPackage; }
			set 
			{ 
				_PartnerPackage = value;
				OnPropertyChanged("PartnerPackage");
			}
		}
		/// <summary>
		/// Use SecretAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Secret
		{
			get { return _Secret; }
			private set 
			{ 
				_Secret = value;
				OnPropertyChanged("Secret");
			}
		}
		/// <summary>
		/// Use AdminSecretAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminSecret
		{
			get { return _AdminSecret; }
			private set 
			{ 
				_AdminSecret = value;
				OnPropertyChanged("AdminSecret");
			}
		}
		/// <summary>
		/// Use CmsPasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CmsPassword
		{
			get { return _CmsPassword; }
			private set 
			{ 
				_CmsPassword = value;
				OnPropertyChanged("CmsPassword");
			}
		}
		/// <summary>
		/// Use AllowMultiNotificationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AllowMultiNotification
		{
			get { return _AllowMultiNotification; }
			set 
			{ 
				_AllowMultiNotification = value;
				OnPropertyChanged("AllowMultiNotification");
			}
		}
		/// <summary>
		/// Use AdminLoginUsersQuotaAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AdminLoginUsersQuota
		{
			get { return _AdminLoginUsersQuota; }
			private set 
			{ 
				_AdminLoginUsersQuota = value;
				OnPropertyChanged("AdminLoginUsersQuota");
			}
		}
		/// <summary>
		/// Use AdminUserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminUserId
		{
			get { return _AdminUserId; }
			set 
			{ 
				_AdminUserId = value;
				OnPropertyChanged("AdminUserId");
			}
		}
		/// <summary>
		/// Use FirstNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FirstName
		{
			get { return _FirstName; }
			set 
			{ 
				_FirstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		/// <summary>
		/// Use LastNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LastName
		{
			get { return _LastName; }
			set 
			{ 
				_LastName = value;
				OnPropertyChanged("LastName");
			}
		}
		/// <summary>
		/// Use CountryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		/// <summary>
		/// Use StateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		/// <summary>
		/// Use AdditionalParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> AdditionalParams
		{
			get { return _AdditionalParams; }
			set 
			{ 
				_AdditionalParams = value;
				OnPropertyChanged("AdditionalParams");
			}
		}
		/// <summary>
		/// Use PublishersQuotaAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PublishersQuota
		{
			get { return _PublishersQuota; }
			private set 
			{ 
				_PublishersQuota = value;
				OnPropertyChanged("PublishersQuota");
			}
		}
		/// <summary>
		/// Use PartnerGroupTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PartnerGroupType PartnerGroupType
		{
			get { return _PartnerGroupType; }
			private set 
			{ 
				_PartnerGroupType = value;
				OnPropertyChanged("PartnerGroupType");
			}
		}
		/// <summary>
		/// Use DefaultEntitlementEnforcementAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? DefaultEntitlementEnforcement
		{
			get { return _DefaultEntitlementEnforcement; }
			private set 
			{ 
				_DefaultEntitlementEnforcement = value;
				OnPropertyChanged("DefaultEntitlementEnforcement");
			}
		}
		/// <summary>
		/// Use DefaultDeliveryTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultDeliveryType
		{
			get { return _DefaultDeliveryType; }
			private set 
			{ 
				_DefaultDeliveryType = value;
				OnPropertyChanged("DefaultDeliveryType");
			}
		}
		/// <summary>
		/// Use DefaultEmbedCodeTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultEmbedCodeType
		{
			get { return _DefaultEmbedCodeType; }
			private set 
			{ 
				_DefaultEmbedCodeType = value;
				OnPropertyChanged("DefaultEmbedCodeType");
			}
		}
		/// <summary>
		/// Use DeliveryTypesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayerDeliveryType> DeliveryTypes
		{
			get { return _DeliveryTypes; }
			private set 
			{ 
				_DeliveryTypes = value;
				OnPropertyChanged("DeliveryTypes");
			}
		}
		/// <summary>
		/// Use EmbedCodeTypesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<PlayerEmbedCodeType> EmbedCodeTypes
		{
			get { return _EmbedCodeTypes; }
			private set 
			{ 
				_EmbedCodeTypes = value;
				OnPropertyChanged("EmbedCodeTypes");
			}
		}
		/// <summary>
		/// Use TemplatePartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int TemplatePartnerId
		{
			get { return _TemplatePartnerId; }
			private set 
			{ 
				_TemplatePartnerId = value;
				OnPropertyChanged("TemplatePartnerId");
			}
		}
		/// <summary>
		/// Use IgnoreSeoLinksAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IgnoreSeoLinks
		{
			get { return _IgnoreSeoLinks; }
			private set 
			{ 
				_IgnoreSeoLinks = value;
				OnPropertyChanged("IgnoreSeoLinks");
			}
		}
		/// <summary>
		/// Use BlockDirectLoginAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? BlockDirectLogin
		{
			get { return _BlockDirectLogin; }
			private set 
			{ 
				_BlockDirectLogin = value;
				OnPropertyChanged("BlockDirectLogin");
			}
		}
		/// <summary>
		/// Use HostAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Host
		{
			get { return _Host; }
			private set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		/// <summary>
		/// Use CdnHostAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CdnHost
		{
			get { return _CdnHost; }
			private set 
			{ 
				_CdnHost = value;
				OnPropertyChanged("CdnHost");
			}
		}
		/// <summary>
		/// Use IsFirstLoginAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsFirstLogin
		{
			get { return _IsFirstLogin; }
			private set 
			{ 
				_IsFirstLogin = value;
				OnPropertyChanged("IsFirstLogin");
			}
		}
		/// <summary>
		/// Use LogoutUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LogoutUrl
		{
			get { return _LogoutUrl; }
			private set 
			{ 
				_LogoutUrl = value;
				OnPropertyChanged("LogoutUrl");
			}
		}
		/// <summary>
		/// Use PartnerParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerParentId
		{
			get { return _PartnerParentId; }
			set 
			{ 
				_PartnerParentId = value;
				OnPropertyChanged("PartnerParentId");
			}
		}
		/// <summary>
		/// Use CrmIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CrmId
		{
			get { return _CrmId; }
			private set 
			{ 
				_CrmId = value;
				OnPropertyChanged("CrmId");
			}
		}
		/// <summary>
		/// Use ReferenceIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReferenceId
		{
			get { return _ReferenceId; }
			set 
			{ 
				_ReferenceId = value;
				OnPropertyChanged("ReferenceId");
			}
		}
		/// <summary>
		/// Use TimeAlignedRenditionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? TimeAlignedRenditions
		{
			get { return _TimeAlignedRenditions; }
			private set 
			{ 
				_TimeAlignedRenditions = value;
				OnPropertyChanged("TimeAlignedRenditions");
			}
		}
		/// <summary>
		/// Use PublisherEnvironmentTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PublisherEnvironmentType
		{
			get { return _PublisherEnvironmentType; }
			private set 
			{ 
				_PublisherEnvironmentType = value;
				OnPropertyChanged("PublisherEnvironmentType");
			}
		}
		/// <summary>
		/// Use OvpEnvironmentUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OvpEnvironmentUrl
		{
			get { return _OvpEnvironmentUrl; }
			private set 
			{ 
				_OvpEnvironmentUrl = value;
				OnPropertyChanged("OvpEnvironmentUrl");
			}
		}
		/// <summary>
		/// Use OttEnvironmentUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OttEnvironmentUrl
		{
			get { return _OttEnvironmentUrl; }
			private set 
			{ 
				_OttEnvironmentUrl = value;
				OnPropertyChanged("OttEnvironmentUrl");
			}
		}
		/// <summary>
		/// Use ESearchLanguagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ESearchLanguageItem> ESearchLanguages
		{
			get { return _ESearchLanguages; }
			set 
			{ 
				_ESearchLanguages = value;
				OnPropertyChanged("ESearchLanguages");
			}
		}
		/// <summary>
		/// Use AuthenticationTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public PartnerAuthenticationType AuthenticationType
		{
			get { return _AuthenticationType; }
			private set 
			{ 
				_AuthenticationType = value;
				OnPropertyChanged("AuthenticationType");
			}
		}
		/// <summary>
		/// Use ExtendedFreeTrailExpiryReasonAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExtendedFreeTrailExpiryReason
		{
			get { return _ExtendedFreeTrailExpiryReason; }
			private set 
			{ 
				_ExtendedFreeTrailExpiryReason = value;
				OnPropertyChanged("ExtendedFreeTrailExpiryReason");
			}
		}
		/// <summary>
		/// Use ExtendedFreeTrailExpiryDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExtendedFreeTrailExpiryDate
		{
			get { return _ExtendedFreeTrailExpiryDate; }
			private set 
			{ 
				_ExtendedFreeTrailExpiryDate = value;
				OnPropertyChanged("ExtendedFreeTrailExpiryDate");
			}
		}
		/// <summary>
		/// Use ExtendedFreeTrailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExtendedFreeTrail
		{
			get { return _ExtendedFreeTrail; }
			private set 
			{ 
				_ExtendedFreeTrail = value;
				OnPropertyChanged("ExtendedFreeTrail");
			}
		}
		/// <summary>
		/// Use ExtendedFreeTrailEndsWarningAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ExtendedFreeTrailEndsWarning
		{
			get { return _ExtendedFreeTrailEndsWarning; }
			private set 
			{ 
				_ExtendedFreeTrailEndsWarning = value;
				OnPropertyChanged("ExtendedFreeTrailEndsWarning");
			}
		}
		/// <summary>
		/// Use EightyPercentWarningAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EightyPercentWarning
		{
			get { return _EightyPercentWarning; }
			private set 
			{ 
				_EightyPercentWarning = value;
				OnPropertyChanged("EightyPercentWarning");
			}
		}
		/// <summary>
		/// Use UsageLimitWarningAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UsageLimitWarning
		{
			get { return _UsageLimitWarning; }
			private set 
			{ 
				_UsageLimitWarning = value;
				OnPropertyChanged("UsageLimitWarning");
			}
		}
		/// <summary>
		/// Use LastFreeTrialNotificationDayAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastFreeTrialNotificationDay
		{
			get { return _LastFreeTrialNotificationDay; }
			private set 
			{ 
				_LastFreeTrialNotificationDay = value;
				OnPropertyChanged("LastFreeTrialNotificationDay");
			}
		}
		/// <summary>
		/// Use MonitorUsageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MonitorUsage
		{
			get { return _MonitorUsage; }
			private set 
			{ 
				_MonitorUsage = value;
				OnPropertyChanged("MonitorUsage");
			}
		}
		/// <summary>
		/// Use PasswordStructureValidationsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PasswordStructureValidations
		{
			get { return _PasswordStructureValidations; }
			set 
			{ 
				_PasswordStructureValidations = value;
				OnPropertyChanged("PasswordStructureValidations");
			}
		}
		/// <summary>
		/// Use PasswordStructureValidationsDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PasswordStructureValidationsDescription
		{
			get { return _PasswordStructureValidationsDescription; }
			set 
			{ 
				_PasswordStructureValidationsDescription = value;
				OnPropertyChanged("PasswordStructureValidationsDescription");
			}
		}
		/// <summary>
		/// Use PassReplaceFreqAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PassReplaceFreq
		{
			get { return _PassReplaceFreq; }
			set 
			{ 
				_PassReplaceFreq = value;
				OnPropertyChanged("PassReplaceFreq");
			}
		}
		/// <summary>
		/// Use MaxLoginAttemptsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxLoginAttempts
		{
			get { return _MaxLoginAttempts; }
			set 
			{ 
				_MaxLoginAttempts = value;
				OnPropertyChanged("MaxLoginAttempts");
			}
		}
		/// <summary>
		/// Use LoginBlockPeriodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LoginBlockPeriod
		{
			get { return _LoginBlockPeriod; }
			set 
			{ 
				_LoginBlockPeriod = value;
				OnPropertyChanged("LoginBlockPeriod");
			}
		}
		/// <summary>
		/// Use NumPrevPassToKeepAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int NumPrevPassToKeep
		{
			get { return _NumPrevPassToKeep; }
			set 
			{ 
				_NumPrevPassToKeep = value;
				OnPropertyChanged("NumPrevPassToKeep");
			}
		}
		#endregion

		#region CTor
		public Partner()
		{
		}

		public Partner(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["website"] != null)
			{
				this._Website = node["website"].Value<string>();
			}
			if(node["notificationUrl"] != null)
			{
				this._NotificationUrl = node["notificationUrl"].Value<string>();
			}
			if(node["appearInSearch"] != null)
			{
				this._AppearInSearch = ParseInt(node["appearInSearch"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["adminName"] != null)
			{
				this._AdminName = node["adminName"].Value<string>();
			}
			if(node["adminEmail"] != null)
			{
				this._AdminEmail = node["adminEmail"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["commercialUse"] != null)
			{
				this._CommercialUse = (CommercialUseType)ParseEnum(typeof(CommercialUseType), node["commercialUse"].Value<string>());
			}
			if(node["landingPage"] != null)
			{
				this._LandingPage = node["landingPage"].Value<string>();
			}
			if(node["userLandingPage"] != null)
			{
				this._UserLandingPage = node["userLandingPage"].Value<string>();
			}
			if(node["contentCategories"] != null)
			{
				this._ContentCategories = node["contentCategories"].Value<string>();
			}
			if(node["type"] != null)
			{
				this._Type = (PartnerType)ParseEnum(typeof(PartnerType), node["type"].Value<string>());
			}
			if(node["phone"] != null)
			{
				this._Phone = node["phone"].Value<string>();
			}
			if(node["describeYourself"] != null)
			{
				this._DescribeYourself = node["describeYourself"].Value<string>();
			}
			if(node["adultContent"] != null)
			{
				this._AdultContent = ParseBool(node["adultContent"].Value<string>());
			}
			if(node["defConversionProfileType"] != null)
			{
				this._DefConversionProfileType = node["defConversionProfileType"].Value<string>();
			}
			if(node["notify"] != null)
			{
				this._Notify = ParseInt(node["notify"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (PartnerStatus)ParseEnum(typeof(PartnerStatus), node["status"].Value<string>());
			}
			if(node["allowQuickEdit"] != null)
			{
				this._AllowQuickEdit = ParseInt(node["allowQuickEdit"].Value<string>());
			}
			if(node["mergeEntryLists"] != null)
			{
				this._MergeEntryLists = ParseInt(node["mergeEntryLists"].Value<string>());
			}
			if(node["notificationsConfig"] != null)
			{
				this._NotificationsConfig = node["notificationsConfig"].Value<string>();
			}
			if(node["allowedFromEmailWhiteList"] != null)
			{
				this._AllowedFromEmailWhiteList = node["allowedFromEmailWhiteList"].Value<string>();
			}
			if(node["maxUploadSize"] != null)
			{
				this._MaxUploadSize = ParseInt(node["maxUploadSize"].Value<string>());
			}
			if(node["partnerPackage"] != null)
			{
				this._PartnerPackage = ParseInt(node["partnerPackage"].Value<string>());
			}
			if(node["secret"] != null)
			{
				this._Secret = node["secret"].Value<string>();
			}
			if(node["adminSecret"] != null)
			{
				this._AdminSecret = node["adminSecret"].Value<string>();
			}
			if(node["cmsPassword"] != null)
			{
				this._CmsPassword = node["cmsPassword"].Value<string>();
			}
			if(node["allowMultiNotification"] != null)
			{
				this._AllowMultiNotification = ParseInt(node["allowMultiNotification"].Value<string>());
			}
			if(node["adminLoginUsersQuota"] != null)
			{
				this._AdminLoginUsersQuota = ParseInt(node["adminLoginUsersQuota"].Value<string>());
			}
			if(node["adminUserId"] != null)
			{
				this._AdminUserId = node["adminUserId"].Value<string>();
			}
			if(node["firstName"] != null)
			{
				this._FirstName = node["firstName"].Value<string>();
			}
			if(node["lastName"] != null)
			{
				this._LastName = node["lastName"].Value<string>();
			}
			if(node["country"] != null)
			{
				this._Country = node["country"].Value<string>();
			}
			if(node["state"] != null)
			{
				this._State = node["state"].Value<string>();
			}
			if(node["additionalParams"] != null)
			{
				this._AdditionalParams = new List<KeyValue>();
				foreach(var arrayNode in node["additionalParams"].Children())
				{
					this._AdditionalParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["publishersQuota"] != null)
			{
				this._PublishersQuota = ParseInt(node["publishersQuota"].Value<string>());
			}
			if(node["partnerGroupType"] != null)
			{
				this._PartnerGroupType = (PartnerGroupType)ParseEnum(typeof(PartnerGroupType), node["partnerGroupType"].Value<string>());
			}
			if(node["defaultEntitlementEnforcement"] != null)
			{
				this._DefaultEntitlementEnforcement = ParseBool(node["defaultEntitlementEnforcement"].Value<string>());
			}
			if(node["defaultDeliveryType"] != null)
			{
				this._DefaultDeliveryType = node["defaultDeliveryType"].Value<string>();
			}
			if(node["defaultEmbedCodeType"] != null)
			{
				this._DefaultEmbedCodeType = node["defaultEmbedCodeType"].Value<string>();
			}
			if(node["deliveryTypes"] != null)
			{
				this._DeliveryTypes = new List<PlayerDeliveryType>();
				foreach(var arrayNode in node["deliveryTypes"].Children())
				{
					this._DeliveryTypes.Add(ObjectFactory.Create<PlayerDeliveryType>(arrayNode));
				}
			}
			if(node["embedCodeTypes"] != null)
			{
				this._EmbedCodeTypes = new List<PlayerEmbedCodeType>();
				foreach(var arrayNode in node["embedCodeTypes"].Children())
				{
					this._EmbedCodeTypes.Add(ObjectFactory.Create<PlayerEmbedCodeType>(arrayNode));
				}
			}
			if(node["templatePartnerId"] != null)
			{
				this._TemplatePartnerId = ParseInt(node["templatePartnerId"].Value<string>());
			}
			if(node["ignoreSeoLinks"] != null)
			{
				this._IgnoreSeoLinks = ParseBool(node["ignoreSeoLinks"].Value<string>());
			}
			if(node["blockDirectLogin"] != null)
			{
				this._BlockDirectLogin = ParseBool(node["blockDirectLogin"].Value<string>());
			}
			if(node["host"] != null)
			{
				this._Host = node["host"].Value<string>();
			}
			if(node["cdnHost"] != null)
			{
				this._CdnHost = node["cdnHost"].Value<string>();
			}
			if(node["isFirstLogin"] != null)
			{
				this._IsFirstLogin = ParseBool(node["isFirstLogin"].Value<string>());
			}
			if(node["logoutUrl"] != null)
			{
				this._LogoutUrl = node["logoutUrl"].Value<string>();
			}
			if(node["partnerParentId"] != null)
			{
				this._PartnerParentId = ParseInt(node["partnerParentId"].Value<string>());
			}
			if(node["crmId"] != null)
			{
				this._CrmId = node["crmId"].Value<string>();
			}
			if(node["referenceId"] != null)
			{
				this._ReferenceId = node["referenceId"].Value<string>();
			}
			if(node["timeAlignedRenditions"] != null)
			{
				this._TimeAlignedRenditions = ParseBool(node["timeAlignedRenditions"].Value<string>());
			}
			if(node["publisherEnvironmentType"] != null)
			{
				this._PublisherEnvironmentType = ParseInt(node["publisherEnvironmentType"].Value<string>());
			}
			if(node["ovpEnvironmentUrl"] != null)
			{
				this._OvpEnvironmentUrl = node["ovpEnvironmentUrl"].Value<string>();
			}
			if(node["ottEnvironmentUrl"] != null)
			{
				this._OttEnvironmentUrl = node["ottEnvironmentUrl"].Value<string>();
			}
			if(node["eSearchLanguages"] != null)
			{
				this._ESearchLanguages = new List<ESearchLanguageItem>();
				foreach(var arrayNode in node["eSearchLanguages"].Children())
				{
					this._ESearchLanguages.Add(ObjectFactory.Create<ESearchLanguageItem>(arrayNode));
				}
			}
			if(node["authenticationType"] != null)
			{
				this._AuthenticationType = (PartnerAuthenticationType)ParseEnum(typeof(PartnerAuthenticationType), node["authenticationType"].Value<string>());
			}
			if(node["extendedFreeTrailExpiryReason"] != null)
			{
				this._ExtendedFreeTrailExpiryReason = node["extendedFreeTrailExpiryReason"].Value<string>();
			}
			if(node["extendedFreeTrailExpiryDate"] != null)
			{
				this._ExtendedFreeTrailExpiryDate = ParseInt(node["extendedFreeTrailExpiryDate"].Value<string>());
			}
			if(node["extendedFreeTrail"] != null)
			{
				this._ExtendedFreeTrail = ParseInt(node["extendedFreeTrail"].Value<string>());
			}
			if(node["extendedFreeTrailEndsWarning"] != null)
			{
				this._ExtendedFreeTrailEndsWarning = ParseBool(node["extendedFreeTrailEndsWarning"].Value<string>());
			}
			if(node["eightyPercentWarning"] != null)
			{
				this._EightyPercentWarning = ParseInt(node["eightyPercentWarning"].Value<string>());
			}
			if(node["usageLimitWarning"] != null)
			{
				this._UsageLimitWarning = ParseInt(node["usageLimitWarning"].Value<string>());
			}
			if(node["lastFreeTrialNotificationDay"] != null)
			{
				this._LastFreeTrialNotificationDay = ParseInt(node["lastFreeTrialNotificationDay"].Value<string>());
			}
			if(node["monitorUsage"] != null)
			{
				this._MonitorUsage = ParseInt(node["monitorUsage"].Value<string>());
			}
			if(node["passwordStructureValidations"] != null)
			{
				this._PasswordStructureValidations = node["passwordStructureValidations"].Value<string>();
			}
			if(node["passwordStructureValidationsDescription"] != null)
			{
				this._PasswordStructureValidationsDescription = node["passwordStructureValidationsDescription"].Value<string>();
			}
			if(node["passReplaceFreq"] != null)
			{
				this._PassReplaceFreq = ParseInt(node["passReplaceFreq"].Value<string>());
			}
			if(node["maxLoginAttempts"] != null)
			{
				this._MaxLoginAttempts = ParseInt(node["maxLoginAttempts"].Value<string>());
			}
			if(node["loginBlockPeriod"] != null)
			{
				this._LoginBlockPeriod = ParseInt(node["loginBlockPeriod"].Value<string>());
			}
			if(node["numPrevPassToKeep"] != null)
			{
				this._NumPrevPassToKeep = ParseInt(node["numPrevPassToKeep"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPartner");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("website", this._Website);
			kparams.AddIfNotNull("notificationUrl", this._NotificationUrl);
			kparams.AddIfNotNull("appearInSearch", this._AppearInSearch);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("adminName", this._AdminName);
			kparams.AddIfNotNull("adminEmail", this._AdminEmail);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("commercialUse", this._CommercialUse);
			kparams.AddIfNotNull("landingPage", this._LandingPage);
			kparams.AddIfNotNull("userLandingPage", this._UserLandingPage);
			kparams.AddIfNotNull("contentCategories", this._ContentCategories);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("phone", this._Phone);
			kparams.AddIfNotNull("describeYourself", this._DescribeYourself);
			kparams.AddIfNotNull("adultContent", this._AdultContent);
			kparams.AddIfNotNull("defConversionProfileType", this._DefConversionProfileType);
			kparams.AddIfNotNull("notify", this._Notify);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("allowQuickEdit", this._AllowQuickEdit);
			kparams.AddIfNotNull("mergeEntryLists", this._MergeEntryLists);
			kparams.AddIfNotNull("notificationsConfig", this._NotificationsConfig);
			kparams.AddIfNotNull("allowedFromEmailWhiteList", this._AllowedFromEmailWhiteList);
			kparams.AddIfNotNull("maxUploadSize", this._MaxUploadSize);
			kparams.AddIfNotNull("partnerPackage", this._PartnerPackage);
			kparams.AddIfNotNull("secret", this._Secret);
			kparams.AddIfNotNull("adminSecret", this._AdminSecret);
			kparams.AddIfNotNull("cmsPassword", this._CmsPassword);
			kparams.AddIfNotNull("allowMultiNotification", this._AllowMultiNotification);
			kparams.AddIfNotNull("adminLoginUsersQuota", this._AdminLoginUsersQuota);
			kparams.AddIfNotNull("adminUserId", this._AdminUserId);
			kparams.AddIfNotNull("firstName", this._FirstName);
			kparams.AddIfNotNull("lastName", this._LastName);
			kparams.AddIfNotNull("country", this._Country);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("additionalParams", this._AdditionalParams);
			kparams.AddIfNotNull("publishersQuota", this._PublishersQuota);
			kparams.AddIfNotNull("partnerGroupType", this._PartnerGroupType);
			kparams.AddIfNotNull("defaultEntitlementEnforcement", this._DefaultEntitlementEnforcement);
			kparams.AddIfNotNull("defaultDeliveryType", this._DefaultDeliveryType);
			kparams.AddIfNotNull("defaultEmbedCodeType", this._DefaultEmbedCodeType);
			kparams.AddIfNotNull("deliveryTypes", this._DeliveryTypes);
			kparams.AddIfNotNull("embedCodeTypes", this._EmbedCodeTypes);
			kparams.AddIfNotNull("templatePartnerId", this._TemplatePartnerId);
			kparams.AddIfNotNull("ignoreSeoLinks", this._IgnoreSeoLinks);
			kparams.AddIfNotNull("blockDirectLogin", this._BlockDirectLogin);
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("cdnHost", this._CdnHost);
			kparams.AddIfNotNull("isFirstLogin", this._IsFirstLogin);
			kparams.AddIfNotNull("logoutUrl", this._LogoutUrl);
			kparams.AddIfNotNull("partnerParentId", this._PartnerParentId);
			kparams.AddIfNotNull("crmId", this._CrmId);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("timeAlignedRenditions", this._TimeAlignedRenditions);
			kparams.AddIfNotNull("publisherEnvironmentType", this._PublisherEnvironmentType);
			kparams.AddIfNotNull("ovpEnvironmentUrl", this._OvpEnvironmentUrl);
			kparams.AddIfNotNull("ottEnvironmentUrl", this._OttEnvironmentUrl);
			kparams.AddIfNotNull("eSearchLanguages", this._ESearchLanguages);
			kparams.AddIfNotNull("authenticationType", this._AuthenticationType);
			kparams.AddIfNotNull("extendedFreeTrailExpiryReason", this._ExtendedFreeTrailExpiryReason);
			kparams.AddIfNotNull("extendedFreeTrailExpiryDate", this._ExtendedFreeTrailExpiryDate);
			kparams.AddIfNotNull("extendedFreeTrail", this._ExtendedFreeTrail);
			kparams.AddIfNotNull("extendedFreeTrailEndsWarning", this._ExtendedFreeTrailEndsWarning);
			kparams.AddIfNotNull("eightyPercentWarning", this._EightyPercentWarning);
			kparams.AddIfNotNull("usageLimitWarning", this._UsageLimitWarning);
			kparams.AddIfNotNull("lastFreeTrialNotificationDay", this._LastFreeTrialNotificationDay);
			kparams.AddIfNotNull("monitorUsage", this._MonitorUsage);
			kparams.AddIfNotNull("passwordStructureValidations", this._PasswordStructureValidations);
			kparams.AddIfNotNull("passwordStructureValidationsDescription", this._PasswordStructureValidationsDescription);
			kparams.AddIfNotNull("passReplaceFreq", this._PassReplaceFreq);
			kparams.AddIfNotNull("maxLoginAttempts", this._MaxLoginAttempts);
			kparams.AddIfNotNull("loginBlockPeriod", this._LoginBlockPeriod);
			kparams.AddIfNotNull("numPrevPassToKeep", this._NumPrevPassToKeep);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case NAME:
					return "Name";
				case WEBSITE:
					return "Website";
				case NOTIFICATION_URL:
					return "NotificationUrl";
				case APPEAR_IN_SEARCH:
					return "AppearInSearch";
				case CREATED_AT:
					return "CreatedAt";
				case ADMIN_NAME:
					return "AdminName";
				case ADMIN_EMAIL:
					return "AdminEmail";
				case DESCRIPTION:
					return "Description";
				case COMMERCIAL_USE:
					return "CommercialUse";
				case LANDING_PAGE:
					return "LandingPage";
				case USER_LANDING_PAGE:
					return "UserLandingPage";
				case CONTENT_CATEGORIES:
					return "ContentCategories";
				case TYPE:
					return "Type";
				case PHONE:
					return "Phone";
				case DESCRIBE_YOURSELF:
					return "DescribeYourself";
				case ADULT_CONTENT:
					return "AdultContent";
				case DEF_CONVERSION_PROFILE_TYPE:
					return "DefConversionProfileType";
				case NOTIFY:
					return "Notify";
				case STATUS:
					return "Status";
				case ALLOW_QUICK_EDIT:
					return "AllowQuickEdit";
				case MERGE_ENTRY_LISTS:
					return "MergeEntryLists";
				case NOTIFICATIONS_CONFIG:
					return "NotificationsConfig";
				case ALLOWED_FROM_EMAIL_WHITE_LIST:
					return "AllowedFromEmailWhiteList";
				case MAX_UPLOAD_SIZE:
					return "MaxUploadSize";
				case PARTNER_PACKAGE:
					return "PartnerPackage";
				case SECRET:
					return "Secret";
				case ADMIN_SECRET:
					return "AdminSecret";
				case CMS_PASSWORD:
					return "CmsPassword";
				case ALLOW_MULTI_NOTIFICATION:
					return "AllowMultiNotification";
				case ADMIN_LOGIN_USERS_QUOTA:
					return "AdminLoginUsersQuota";
				case ADMIN_USER_ID:
					return "AdminUserId";
				case FIRST_NAME:
					return "FirstName";
				case LAST_NAME:
					return "LastName";
				case COUNTRY:
					return "Country";
				case STATE:
					return "State";
				case ADDITIONAL_PARAMS:
					return "AdditionalParams";
				case PUBLISHERS_QUOTA:
					return "PublishersQuota";
				case PARTNER_GROUP_TYPE:
					return "PartnerGroupType";
				case DEFAULT_ENTITLEMENT_ENFORCEMENT:
					return "DefaultEntitlementEnforcement";
				case DEFAULT_DELIVERY_TYPE:
					return "DefaultDeliveryType";
				case DEFAULT_EMBED_CODE_TYPE:
					return "DefaultEmbedCodeType";
				case DELIVERY_TYPES:
					return "DeliveryTypes";
				case EMBED_CODE_TYPES:
					return "EmbedCodeTypes";
				case TEMPLATE_PARTNER_ID:
					return "TemplatePartnerId";
				case IGNORE_SEO_LINKS:
					return "IgnoreSeoLinks";
				case BLOCK_DIRECT_LOGIN:
					return "BlockDirectLogin";
				case HOST:
					return "Host";
				case CDN_HOST:
					return "CdnHost";
				case IS_FIRST_LOGIN:
					return "IsFirstLogin";
				case LOGOUT_URL:
					return "LogoutUrl";
				case PARTNER_PARENT_ID:
					return "PartnerParentId";
				case CRM_ID:
					return "CrmId";
				case REFERENCE_ID:
					return "ReferenceId";
				case TIME_ALIGNED_RENDITIONS:
					return "TimeAlignedRenditions";
				case PUBLISHER_ENVIRONMENT_TYPE:
					return "PublisherEnvironmentType";
				case OVP_ENVIRONMENT_URL:
					return "OvpEnvironmentUrl";
				case OTT_ENVIRONMENT_URL:
					return "OttEnvironmentUrl";
				case ESEARCH_LANGUAGES:
					return "ESearchLanguages";
				case AUTHENTICATION_TYPE:
					return "AuthenticationType";
				case EXTENDED_FREE_TRAIL_EXPIRY_REASON:
					return "ExtendedFreeTrailExpiryReason";
				case EXTENDED_FREE_TRAIL_EXPIRY_DATE:
					return "ExtendedFreeTrailExpiryDate";
				case EXTENDED_FREE_TRAIL:
					return "ExtendedFreeTrail";
				case EXTENDED_FREE_TRAIL_ENDS_WARNING:
					return "ExtendedFreeTrailEndsWarning";
				case EIGHTY_PERCENT_WARNING:
					return "EightyPercentWarning";
				case USAGE_LIMIT_WARNING:
					return "UsageLimitWarning";
				case LAST_FREE_TRIAL_NOTIFICATION_DAY:
					return "LastFreeTrialNotificationDay";
				case MONITOR_USAGE:
					return "MonitorUsage";
				case PASSWORD_STRUCTURE_VALIDATIONS:
					return "PasswordStructureValidations";
				case PASSWORD_STRUCTURE_VALIDATIONS_DESCRIPTION:
					return "PasswordStructureValidationsDescription";
				case PASS_REPLACE_FREQ:
					return "PassReplaceFreq";
				case MAX_LOGIN_ATTEMPTS:
					return "MaxLoginAttempts";
				case LOGIN_BLOCK_PERIOD:
					return "LoginBlockPeriod";
				case NUM_PREV_PASS_TO_KEEP:
					return "NumPrevPassToKeep";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

