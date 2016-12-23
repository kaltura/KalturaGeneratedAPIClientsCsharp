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
using Kaltura.Enums;
using Kaltura.Request;

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
		public const string HOST = "host";
		public const string CDN_HOST = "cdnHost";
		public const string IS_FIRST_LOGIN = "isFirstLogin";
		public const string LOGOUT_URL = "logoutUrl";
		public const string PARTNER_PARENT_ID = "partnerParentId";
		public const string CRM_ID = "crmId";
		public const string REFERENCE_ID = "referenceId";
		public const string TIME_ALIGNED_RENDITIONS = "timeAlignedRenditions";
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
		private string _Host = null;
		private string _CdnHost = null;
		private bool? _IsFirstLogin = null;
		private string _LogoutUrl = null;
		private int _PartnerParentId = Int32.MinValue;
		private string _CrmId = null;
		private string _ReferenceId = null;
		private bool? _TimeAlignedRenditions = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Website
		{
			get { return _Website; }
			set 
			{ 
				_Website = value;
				OnPropertyChanged("Website");
			}
		}
		public string NotificationUrl
		{
			get { return _NotificationUrl; }
			set 
			{ 
				_NotificationUrl = value;
				OnPropertyChanged("NotificationUrl");
			}
		}
		public int AppearInSearch
		{
			get { return _AppearInSearch; }
			set 
			{ 
				_AppearInSearch = value;
				OnPropertyChanged("AppearInSearch");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public CommercialUseType CommercialUse
		{
			get { return _CommercialUse; }
			set 
			{ 
				_CommercialUse = value;
				OnPropertyChanged("CommercialUse");
			}
		}
		public string LandingPage
		{
			get { return _LandingPage; }
			set 
			{ 
				_LandingPage = value;
				OnPropertyChanged("LandingPage");
			}
		}
		public string UserLandingPage
		{
			get { return _UserLandingPage; }
			set 
			{ 
				_UserLandingPage = value;
				OnPropertyChanged("UserLandingPage");
			}
		}
		public string ContentCategories
		{
			get { return _ContentCategories; }
			set 
			{ 
				_ContentCategories = value;
				OnPropertyChanged("ContentCategories");
			}
		}
		public PartnerType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Phone
		{
			get { return _Phone; }
			set 
			{ 
				_Phone = value;
				OnPropertyChanged("Phone");
			}
		}
		public string DescribeYourself
		{
			get { return _DescribeYourself; }
			set 
			{ 
				_DescribeYourself = value;
				OnPropertyChanged("DescribeYourself");
			}
		}
		public bool? AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string DefConversionProfileType
		{
			get { return _DefConversionProfileType; }
			set 
			{ 
				_DefConversionProfileType = value;
				OnPropertyChanged("DefConversionProfileType");
			}
		}
		public int Notify
		{
			get { return _Notify; }
			set 
			{ 
				_Notify = value;
				OnPropertyChanged("Notify");
			}
		}
		public PartnerStatus Status
		{
			get { return _Status; }
		}
		public int AllowQuickEdit
		{
			get { return _AllowQuickEdit; }
			set 
			{ 
				_AllowQuickEdit = value;
				OnPropertyChanged("AllowQuickEdit");
			}
		}
		public int MergeEntryLists
		{
			get { return _MergeEntryLists; }
			set 
			{ 
				_MergeEntryLists = value;
				OnPropertyChanged("MergeEntryLists");
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
		public int MaxUploadSize
		{
			get { return _MaxUploadSize; }
			set 
			{ 
				_MaxUploadSize = value;
				OnPropertyChanged("MaxUploadSize");
			}
		}
		public int PartnerPackage
		{
			get { return _PartnerPackage; }
		}
		public string Secret
		{
			get { return _Secret; }
		}
		public string AdminSecret
		{
			get { return _AdminSecret; }
		}
		public string CmsPassword
		{
			get { return _CmsPassword; }
		}
		public int AllowMultiNotification
		{
			get { return _AllowMultiNotification; }
			set 
			{ 
				_AllowMultiNotification = value;
				OnPropertyChanged("AllowMultiNotification");
			}
		}
		public int AdminLoginUsersQuota
		{
			get { return _AdminLoginUsersQuota; }
		}
		public string AdminUserId
		{
			get { return _AdminUserId; }
			set 
			{ 
				_AdminUserId = value;
				OnPropertyChanged("AdminUserId");
			}
		}
		public string FirstName
		{
			get { return _FirstName; }
			set 
			{ 
				_FirstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		public string LastName
		{
			get { return _LastName; }
			set 
			{ 
				_LastName = value;
				OnPropertyChanged("LastName");
			}
		}
		public string Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		public IList<KeyValue> AdditionalParams
		{
			get { return _AdditionalParams; }
			set 
			{ 
				_AdditionalParams = value;
				OnPropertyChanged("AdditionalParams");
			}
		}
		public int PublishersQuota
		{
			get { return _PublishersQuota; }
		}
		public PartnerGroupType PartnerGroupType
		{
			get { return _PartnerGroupType; }
		}
		public bool? DefaultEntitlementEnforcement
		{
			get { return _DefaultEntitlementEnforcement; }
		}
		public string DefaultDeliveryType
		{
			get { return _DefaultDeliveryType; }
		}
		public string DefaultEmbedCodeType
		{
			get { return _DefaultEmbedCodeType; }
		}
		public IList<PlayerDeliveryType> DeliveryTypes
		{
			get { return _DeliveryTypes; }
		}
		public IList<PlayerEmbedCodeType> EmbedCodeTypes
		{
			get { return _EmbedCodeTypes; }
		}
		public int TemplatePartnerId
		{
			get { return _TemplatePartnerId; }
		}
		public bool? IgnoreSeoLinks
		{
			get { return _IgnoreSeoLinks; }
		}
		public string Host
		{
			get { return _Host; }
		}
		public string CdnHost
		{
			get { return _CdnHost; }
		}
		public bool? IsFirstLogin
		{
			get { return _IsFirstLogin; }
		}
		public string LogoutUrl
		{
			get { return _LogoutUrl; }
		}
		public int PartnerParentId
		{
			get { return _PartnerParentId; }
		}
		public string CrmId
		{
			get { return _CrmId; }
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
		public bool? TimeAlignedRenditions
		{
			get { return _TimeAlignedRenditions; }
		}
		#endregion

		#region CTor
		public Partner()
		{
		}

		public Partner(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "website":
						this._Website = propertyNode.InnerText;
						continue;
					case "notificationUrl":
						this._NotificationUrl = propertyNode.InnerText;
						continue;
					case "appearInSearch":
						this._AppearInSearch = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "adminName":
						this._AdminName = propertyNode.InnerText;
						continue;
					case "adminEmail":
						this._AdminEmail = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "commercialUse":
						this._CommercialUse = (CommercialUseType)ParseEnum(typeof(CommercialUseType), propertyNode.InnerText);
						continue;
					case "landingPage":
						this._LandingPage = propertyNode.InnerText;
						continue;
					case "userLandingPage":
						this._UserLandingPage = propertyNode.InnerText;
						continue;
					case "contentCategories":
						this._ContentCategories = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = (PartnerType)ParseEnum(typeof(PartnerType), propertyNode.InnerText);
						continue;
					case "phone":
						this._Phone = propertyNode.InnerText;
						continue;
					case "describeYourself":
						this._DescribeYourself = propertyNode.InnerText;
						continue;
					case "adultContent":
						this._AdultContent = ParseBool(propertyNode.InnerText);
						continue;
					case "defConversionProfileType":
						this._DefConversionProfileType = propertyNode.InnerText;
						continue;
					case "notify":
						this._Notify = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (PartnerStatus)ParseEnum(typeof(PartnerStatus), propertyNode.InnerText);
						continue;
					case "allowQuickEdit":
						this._AllowQuickEdit = ParseInt(propertyNode.InnerText);
						continue;
					case "mergeEntryLists":
						this._MergeEntryLists = ParseInt(propertyNode.InnerText);
						continue;
					case "notificationsConfig":
						this._NotificationsConfig = propertyNode.InnerText;
						continue;
					case "maxUploadSize":
						this._MaxUploadSize = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerPackage":
						this._PartnerPackage = ParseInt(propertyNode.InnerText);
						continue;
					case "secret":
						this._Secret = propertyNode.InnerText;
						continue;
					case "adminSecret":
						this._AdminSecret = propertyNode.InnerText;
						continue;
					case "cmsPassword":
						this._CmsPassword = propertyNode.InnerText;
						continue;
					case "allowMultiNotification":
						this._AllowMultiNotification = ParseInt(propertyNode.InnerText);
						continue;
					case "adminLoginUsersQuota":
						this._AdminLoginUsersQuota = ParseInt(propertyNode.InnerText);
						continue;
					case "adminUserId":
						this._AdminUserId = propertyNode.InnerText;
						continue;
					case "firstName":
						this._FirstName = propertyNode.InnerText;
						continue;
					case "lastName":
						this._LastName = propertyNode.InnerText;
						continue;
					case "country":
						this._Country = propertyNode.InnerText;
						continue;
					case "state":
						this._State = propertyNode.InnerText;
						continue;
					case "additionalParams":
						this._AdditionalParams = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AdditionalParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "publishersQuota":
						this._PublishersQuota = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerGroupType":
						this._PartnerGroupType = (PartnerGroupType)ParseEnum(typeof(PartnerGroupType), propertyNode.InnerText);
						continue;
					case "defaultEntitlementEnforcement":
						this._DefaultEntitlementEnforcement = ParseBool(propertyNode.InnerText);
						continue;
					case "defaultDeliveryType":
						this._DefaultDeliveryType = propertyNode.InnerText;
						continue;
					case "defaultEmbedCodeType":
						this._DefaultEmbedCodeType = propertyNode.InnerText;
						continue;
					case "deliveryTypes":
						this._DeliveryTypes = new List<PlayerDeliveryType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DeliveryTypes.Add(ObjectFactory.Create<PlayerDeliveryType>(arrayNode));
						}
						continue;
					case "embedCodeTypes":
						this._EmbedCodeTypes = new List<PlayerEmbedCodeType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._EmbedCodeTypes.Add(ObjectFactory.Create<PlayerEmbedCodeType>(arrayNode));
						}
						continue;
					case "templatePartnerId":
						this._TemplatePartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "ignoreSeoLinks":
						this._IgnoreSeoLinks = ParseBool(propertyNode.InnerText);
						continue;
					case "host":
						this._Host = propertyNode.InnerText;
						continue;
					case "cdnHost":
						this._CdnHost = propertyNode.InnerText;
						continue;
					case "isFirstLogin":
						this._IsFirstLogin = ParseBool(propertyNode.InnerText);
						continue;
					case "logoutUrl":
						this._LogoutUrl = propertyNode.InnerText;
						continue;
					case "partnerParentId":
						this._PartnerParentId = ParseInt(propertyNode.InnerText);
						continue;
					case "crmId":
						this._CrmId = propertyNode.InnerText;
						continue;
					case "referenceId":
						this._ReferenceId = propertyNode.InnerText;
						continue;
					case "timeAlignedRenditions":
						this._TimeAlignedRenditions = ParseBool(propertyNode.InnerText);
						continue;
				}
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
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("cdnHost", this._CdnHost);
			kparams.AddIfNotNull("isFirstLogin", this._IsFirstLogin);
			kparams.AddIfNotNull("logoutUrl", this._LogoutUrl);
			kparams.AddIfNotNull("partnerParentId", this._PartnerParentId);
			kparams.AddIfNotNull("crmId", this._CrmId);
			kparams.AddIfNotNull("referenceId", this._ReferenceId);
			kparams.AddIfNotNull("timeAlignedRenditions", this._TimeAlignedRenditions);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

