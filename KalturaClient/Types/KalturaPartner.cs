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
	public class KalturaPartner : KalturaObjectBase
	{
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
		private KalturaCommercialUseType _CommercialUse = (KalturaCommercialUseType)Int32.MinValue;
		private string _LandingPage = null;
		private string _UserLandingPage = null;
		private string _ContentCategories = null;
		private KalturaPartnerType _Type = (KalturaPartnerType)Int32.MinValue;
		private string _Phone = null;
		private string _DescribeYourself = null;
		private bool? _AdultContent = null;
		private string _DefConversionProfileType = null;
		private int _Notify = Int32.MinValue;
		private KalturaPartnerStatus _Status = (KalturaPartnerStatus)Int32.MinValue;
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
		private IList<KalturaKeyValue> _AdditionalParams;
		private int _PublishersQuota = Int32.MinValue;
		private KalturaPartnerGroupType _PartnerGroupType = (KalturaPartnerGroupType)Int32.MinValue;
		private bool? _DefaultEntitlementEnforcement = null;
		private string _DefaultDeliveryType = null;
		private string _DefaultEmbedCodeType = null;
		private IList<KalturaPlayerDeliveryType> _DeliveryTypes;
		private IList<KalturaPlayerEmbedCodeType> _EmbedCodeTypes;
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
		public KalturaCommercialUseType CommercialUse
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
		public KalturaPartnerType Type
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
		public KalturaPartnerStatus Status
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
		public new IList<KalturaKeyValue> AdditionalParams
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
		public KalturaPartnerGroupType PartnerGroupType
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
		public new IList<KalturaPlayerDeliveryType> DeliveryTypes
		{
			get { return _DeliveryTypes; }
		}
		public new IList<KalturaPlayerEmbedCodeType> EmbedCodeTypes
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
		public KalturaPartner()
		{
		}

		public KalturaPartner(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "website":
						this._Website = txt;
						continue;
					case "notificationUrl":
						this._NotificationUrl = txt;
						continue;
					case "appearInSearch":
						this._AppearInSearch = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "adminName":
						this._AdminName = txt;
						continue;
					case "adminEmail":
						this._AdminEmail = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "commercialUse":
						this._CommercialUse = (KalturaCommercialUseType)ParseEnum(typeof(KalturaCommercialUseType), txt);
						continue;
					case "landingPage":
						this._LandingPage = txt;
						continue;
					case "userLandingPage":
						this._UserLandingPage = txt;
						continue;
					case "contentCategories":
						this._ContentCategories = txt;
						continue;
					case "type":
						this._Type = (KalturaPartnerType)ParseEnum(typeof(KalturaPartnerType), txt);
						continue;
					case "phone":
						this._Phone = txt;
						continue;
					case "describeYourself":
						this._DescribeYourself = txt;
						continue;
					case "adultContent":
						this._AdultContent = ParseBool(txt);
						continue;
					case "defConversionProfileType":
						this._DefConversionProfileType = txt;
						continue;
					case "notify":
						this._Notify = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaPartnerStatus)ParseEnum(typeof(KalturaPartnerStatus), txt);
						continue;
					case "allowQuickEdit":
						this._AllowQuickEdit = ParseInt(txt);
						continue;
					case "mergeEntryLists":
						this._MergeEntryLists = ParseInt(txt);
						continue;
					case "notificationsConfig":
						this._NotificationsConfig = txt;
						continue;
					case "maxUploadSize":
						this._MaxUploadSize = ParseInt(txt);
						continue;
					case "partnerPackage":
						this._PartnerPackage = ParseInt(txt);
						continue;
					case "secret":
						this._Secret = txt;
						continue;
					case "adminSecret":
						this._AdminSecret = txt;
						continue;
					case "cmsPassword":
						this._CmsPassword = txt;
						continue;
					case "allowMultiNotification":
						this._AllowMultiNotification = ParseInt(txt);
						continue;
					case "adminLoginUsersQuota":
						this._AdminLoginUsersQuota = ParseInt(txt);
						continue;
					case "adminUserId":
						this._AdminUserId = txt;
						continue;
					case "firstName":
						this._FirstName = txt;
						continue;
					case "lastName":
						this._LastName = txt;
						continue;
					case "country":
						this._Country = txt;
						continue;
					case "state":
						this._State = txt;
						continue;
					case "additionalParams":
						this._AdditionalParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AdditionalParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "publishersQuota":
						this._PublishersQuota = ParseInt(txt);
						continue;
					case "partnerGroupType":
						this._PartnerGroupType = (KalturaPartnerGroupType)ParseEnum(typeof(KalturaPartnerGroupType), txt);
						continue;
					case "defaultEntitlementEnforcement":
						this._DefaultEntitlementEnforcement = ParseBool(txt);
						continue;
					case "defaultDeliveryType":
						this._DefaultDeliveryType = txt;
						continue;
					case "defaultEmbedCodeType":
						this._DefaultEmbedCodeType = txt;
						continue;
					case "deliveryTypes":
						this._DeliveryTypes = new List<KalturaPlayerDeliveryType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._DeliveryTypes.Add((KalturaPlayerDeliveryType)KalturaObjectFactory.Create(arrayNode, "KalturaPlayerDeliveryType"));
						}
						continue;
					case "embedCodeTypes":
						this._EmbedCodeTypes = new List<KalturaPlayerEmbedCodeType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._EmbedCodeTypes.Add((KalturaPlayerEmbedCodeType)KalturaObjectFactory.Create(arrayNode, "KalturaPlayerEmbedCodeType"));
						}
						continue;
					case "templatePartnerId":
						this._TemplatePartnerId = ParseInt(txt);
						continue;
					case "ignoreSeoLinks":
						this._IgnoreSeoLinks = ParseBool(txt);
						continue;
					case "host":
						this._Host = txt;
						continue;
					case "cdnHost":
						this._CdnHost = txt;
						continue;
					case "isFirstLogin":
						this._IsFirstLogin = ParseBool(txt);
						continue;
					case "logoutUrl":
						this._LogoutUrl = txt;
						continue;
					case "partnerParentId":
						this._PartnerParentId = ParseInt(txt);
						continue;
					case "crmId":
						this._CrmId = txt;
						continue;
					case "referenceId":
						this._ReferenceId = txt;
						continue;
					case "timeAlignedRenditions":
						this._TimeAlignedRenditions = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

