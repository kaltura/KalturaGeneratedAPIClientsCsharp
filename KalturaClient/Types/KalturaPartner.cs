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
		private bool? _AdultContent = false;
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
		private bool? _DefaultEntitlementEnforcement = false;
		private string _DefaultDeliveryType = null;
		private string _DefaultEmbedCodeType = null;
		private IList<KalturaPlayerDeliveryType> _DeliveryTypes;
		private IList<KalturaPlayerEmbedCodeType> _EmbedCodeTypes;
		private int _TemplatePartnerId = Int32.MinValue;
		private bool? _IgnoreSeoLinks = false;
		private string _Host = null;
		private string _CdnHost = null;
		private bool? _IsFirstLogin = false;
		private string _LogoutUrl = null;
		private int _PartnerParentId = Int32.MinValue;
		private string _CrmId = null;
		private string _ReferenceId = null;
		private bool? _TimeAlignedRenditions = false;
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
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
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
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
			set 
			{ 
				_PartnerPackage = value;
				OnPropertyChanged("PartnerPackage");
			}
		}
		public string Secret
		{
			get { return _Secret; }
			set 
			{ 
				_Secret = value;
				OnPropertyChanged("Secret");
			}
		}
		public string AdminSecret
		{
			get { return _AdminSecret; }
			set 
			{ 
				_AdminSecret = value;
				OnPropertyChanged("AdminSecret");
			}
		}
		public string CmsPassword
		{
			get { return _CmsPassword; }
			set 
			{ 
				_CmsPassword = value;
				OnPropertyChanged("CmsPassword");
			}
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
			set 
			{ 
				_AdminLoginUsersQuota = value;
				OnPropertyChanged("AdminLoginUsersQuota");
			}
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
		public IList<KalturaKeyValue> AdditionalParams
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
			set 
			{ 
				_PublishersQuota = value;
				OnPropertyChanged("PublishersQuota");
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
		public bool? DefaultEntitlementEnforcement
		{
			get { return _DefaultEntitlementEnforcement; }
			set 
			{ 
				_DefaultEntitlementEnforcement = value;
				OnPropertyChanged("DefaultEntitlementEnforcement");
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
		public IList<KalturaPlayerDeliveryType> DeliveryTypes
		{
			get { return _DeliveryTypes; }
			set 
			{ 
				_DeliveryTypes = value;
				OnPropertyChanged("DeliveryTypes");
			}
		}
		public IList<KalturaPlayerEmbedCodeType> EmbedCodeTypes
		{
			get { return _EmbedCodeTypes; }
			set 
			{ 
				_EmbedCodeTypes = value;
				OnPropertyChanged("EmbedCodeTypes");
			}
		}
		public int TemplatePartnerId
		{
			get { return _TemplatePartnerId; }
			set 
			{ 
				_TemplatePartnerId = value;
				OnPropertyChanged("TemplatePartnerId");
			}
		}
		public bool? IgnoreSeoLinks
		{
			get { return _IgnoreSeoLinks; }
			set 
			{ 
				_IgnoreSeoLinks = value;
				OnPropertyChanged("IgnoreSeoLinks");
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
		public bool? IsFirstLogin
		{
			get { return _IsFirstLogin; }
			set 
			{ 
				_IsFirstLogin = value;
				OnPropertyChanged("IsFirstLogin");
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
		public int PartnerParentId
		{
			get { return _PartnerParentId; }
			set 
			{ 
				_PartnerParentId = value;
				OnPropertyChanged("PartnerParentId");
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
						this.Id = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "website":
						this.Website = txt;
						continue;
					case "notificationUrl":
						this.NotificationUrl = txt;
						continue;
					case "appearInSearch":
						this.AppearInSearch = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "adminName":
						this.AdminName = txt;
						continue;
					case "adminEmail":
						this.AdminEmail = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "commercialUse":
						this.CommercialUse = (KalturaCommercialUseType)ParseEnum(typeof(KalturaCommercialUseType), txt);
						continue;
					case "landingPage":
						this.LandingPage = txt;
						continue;
					case "userLandingPage":
						this.UserLandingPage = txt;
						continue;
					case "contentCategories":
						this.ContentCategories = txt;
						continue;
					case "type":
						this.Type = (KalturaPartnerType)ParseEnum(typeof(KalturaPartnerType), txt);
						continue;
					case "phone":
						this.Phone = txt;
						continue;
					case "describeYourself":
						this.DescribeYourself = txt;
						continue;
					case "adultContent":
						this.AdultContent = ParseBool(txt);
						continue;
					case "defConversionProfileType":
						this.DefConversionProfileType = txt;
						continue;
					case "notify":
						this.Notify = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaPartnerStatus)ParseEnum(typeof(KalturaPartnerStatus), txt);
						continue;
					case "allowQuickEdit":
						this.AllowQuickEdit = ParseInt(txt);
						continue;
					case "mergeEntryLists":
						this.MergeEntryLists = ParseInt(txt);
						continue;
					case "notificationsConfig":
						this.NotificationsConfig = txt;
						continue;
					case "maxUploadSize":
						this.MaxUploadSize = ParseInt(txt);
						continue;
					case "partnerPackage":
						this.PartnerPackage = ParseInt(txt);
						continue;
					case "secret":
						this.Secret = txt;
						continue;
					case "adminSecret":
						this.AdminSecret = txt;
						continue;
					case "cmsPassword":
						this.CmsPassword = txt;
						continue;
					case "allowMultiNotification":
						this.AllowMultiNotification = ParseInt(txt);
						continue;
					case "adminLoginUsersQuota":
						this.AdminLoginUsersQuota = ParseInt(txt);
						continue;
					case "adminUserId":
						this.AdminUserId = txt;
						continue;
					case "firstName":
						this.FirstName = txt;
						continue;
					case "lastName":
						this.LastName = txt;
						continue;
					case "country":
						this.Country = txt;
						continue;
					case "state":
						this.State = txt;
						continue;
					case "additionalParams":
						this.AdditionalParams = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AdditionalParams.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "publishersQuota":
						this.PublishersQuota = ParseInt(txt);
						continue;
					case "partnerGroupType":
						this.PartnerGroupType = (KalturaPartnerGroupType)ParseEnum(typeof(KalturaPartnerGroupType), txt);
						continue;
					case "defaultEntitlementEnforcement":
						this.DefaultEntitlementEnforcement = ParseBool(txt);
						continue;
					case "defaultDeliveryType":
						this.DefaultDeliveryType = txt;
						continue;
					case "defaultEmbedCodeType":
						this.DefaultEmbedCodeType = txt;
						continue;
					case "deliveryTypes":
						this.DeliveryTypes = new List<KalturaPlayerDeliveryType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.DeliveryTypes.Add((KalturaPlayerDeliveryType)KalturaObjectFactory.Create(arrayNode, "KalturaPlayerDeliveryType"));
						}
						continue;
					case "embedCodeTypes":
						this.EmbedCodeTypes = new List<KalturaPlayerEmbedCodeType>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.EmbedCodeTypes.Add((KalturaPlayerEmbedCodeType)KalturaObjectFactory.Create(arrayNode, "KalturaPlayerEmbedCodeType"));
						}
						continue;
					case "templatePartnerId":
						this.TemplatePartnerId = ParseInt(txt);
						continue;
					case "ignoreSeoLinks":
						this.IgnoreSeoLinks = ParseBool(txt);
						continue;
					case "host":
						this.Host = txt;
						continue;
					case "cdnHost":
						this.CdnHost = txt;
						continue;
					case "isFirstLogin":
						this.IsFirstLogin = ParseBool(txt);
						continue;
					case "logoutUrl":
						this.LogoutUrl = txt;
						continue;
					case "partnerParentId":
						this.PartnerParentId = ParseInt(txt);
						continue;
					case "crmId":
						this.CrmId = txt;
						continue;
					case "referenceId":
						this.ReferenceId = txt;
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
			kparams.AddReplace("objectType", "KalturaPartner");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("website", this.Website);
			kparams.AddIfNotNull("notificationUrl", this.NotificationUrl);
			kparams.AddIfNotNull("appearInSearch", this.AppearInSearch);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("adminName", this.AdminName);
			kparams.AddIfNotNull("adminEmail", this.AdminEmail);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("commercialUse", this.CommercialUse);
			kparams.AddIfNotNull("landingPage", this.LandingPage);
			kparams.AddIfNotNull("userLandingPage", this.UserLandingPage);
			kparams.AddIfNotNull("contentCategories", this.ContentCategories);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("phone", this.Phone);
			kparams.AddIfNotNull("describeYourself", this.DescribeYourself);
			kparams.AddIfNotNull("adultContent", this.AdultContent);
			kparams.AddIfNotNull("defConversionProfileType", this.DefConversionProfileType);
			kparams.AddIfNotNull("notify", this.Notify);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("allowQuickEdit", this.AllowQuickEdit);
			kparams.AddIfNotNull("mergeEntryLists", this.MergeEntryLists);
			kparams.AddIfNotNull("notificationsConfig", this.NotificationsConfig);
			kparams.AddIfNotNull("maxUploadSize", this.MaxUploadSize);
			kparams.AddIfNotNull("partnerPackage", this.PartnerPackage);
			kparams.AddIfNotNull("secret", this.Secret);
			kparams.AddIfNotNull("adminSecret", this.AdminSecret);
			kparams.AddIfNotNull("cmsPassword", this.CmsPassword);
			kparams.AddIfNotNull("allowMultiNotification", this.AllowMultiNotification);
			kparams.AddIfNotNull("adminLoginUsersQuota", this.AdminLoginUsersQuota);
			kparams.AddIfNotNull("adminUserId", this.AdminUserId);
			kparams.AddIfNotNull("firstName", this.FirstName);
			kparams.AddIfNotNull("lastName", this.LastName);
			kparams.AddIfNotNull("country", this.Country);
			kparams.AddIfNotNull("state", this.State);
			kparams.AddIfNotNull("additionalParams", this.AdditionalParams);
			kparams.AddIfNotNull("publishersQuota", this.PublishersQuota);
			kparams.AddIfNotNull("partnerGroupType", this.PartnerGroupType);
			kparams.AddIfNotNull("defaultEntitlementEnforcement", this.DefaultEntitlementEnforcement);
			kparams.AddIfNotNull("defaultDeliveryType", this.DefaultDeliveryType);
			kparams.AddIfNotNull("defaultEmbedCodeType", this.DefaultEmbedCodeType);
			kparams.AddIfNotNull("deliveryTypes", this.DeliveryTypes);
			kparams.AddIfNotNull("embedCodeTypes", this.EmbedCodeTypes);
			kparams.AddIfNotNull("templatePartnerId", this.TemplatePartnerId);
			kparams.AddIfNotNull("ignoreSeoLinks", this.IgnoreSeoLinks);
			kparams.AddIfNotNull("host", this.Host);
			kparams.AddIfNotNull("cdnHost", this.CdnHost);
			kparams.AddIfNotNull("isFirstLogin", this.IsFirstLogin);
			kparams.AddIfNotNull("logoutUrl", this.LogoutUrl);
			kparams.AddIfNotNull("partnerParentId", this.PartnerParentId);
			kparams.AddIfNotNull("crmId", this.CrmId);
			kparams.AddIfNotNull("referenceId", this.ReferenceId);
			kparams.AddIfNotNull("timeAlignedRenditions", this.TimeAlignedRenditions);
			return kparams;
		}
		#endregion
	}
}

