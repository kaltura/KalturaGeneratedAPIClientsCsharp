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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class YouTubeDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_SPEC_VERSION = "feedSpecVersion";
		public const string USERNAME = "username";
		public const string NOTIFICATION_EMAIL = "notificationEmail";
		public const string SFTP_HOST = "sftpHost";
		public const string SFTP_PORT = "sftpPort";
		public const string SFTP_LOGIN = "sftpLogin";
		public const string SFTP_PUBLIC_KEY = "sftpPublicKey";
		public const string SFTP_PRIVATE_KEY = "sftpPrivateKey";
		public const string SFTP_BASE_DIR = "sftpBaseDir";
		public const string OWNER_NAME = "ownerName";
		public const string DEFAULT_CATEGORY = "defaultCategory";
		public const string ALLOW_COMMENTS = "allowComments";
		public const string ALLOW_EMBEDDING = "allowEmbedding";
		public const string ALLOW_RATINGS = "allowRatings";
		public const string ALLOW_RESPONSES = "allowResponses";
		public const string COMMERCIAL_POLICY = "commercialPolicy";
		public const string UGC_POLICY = "ugcPolicy";
		public const string TARGET = "target";
		public const string AD_SERVER_PARTNER_ID = "adServerPartnerId";
		public const string ENABLE_AD_SERVER = "enableAdServer";
		public const string ALLOW_PRE_ROLL_ADS = "allowPreRollAds";
		public const string ALLOW_POST_ROLL_ADS = "allowPostRollAds";
		public const string STRICT = "strict";
		public const string OVERRIDE_MANUAL_EDITS = "overrideManualEdits";
		public const string URGENT_REFERENCE = "urgentReference";
		public const string ALLOW_SYNDICATION = "allowSyndication";
		public const string HIDE_VIEW_COUNT = "hideViewCount";
		public const string ALLOW_ADSENSE_FOR_VIDEO = "allowAdsenseForVideo";
		public const string ALLOW_INVIDEO = "allowInvideo";
		public const string ALLOW_MID_ROLL_ADS = "allowMidRollAds";
		public const string INSTREAM_STANDARD = "instreamStandard";
		public const string INSTREAM_TRUEVIEW = "instreamTrueview";
		public const string CLAIM_TYPE = "claimType";
		public const string BLOCK_OUTSIDE_OWNERSHIP = "blockOutsideOwnership";
		public const string CAPTION_AUTOSYNC = "captionAutosync";
		public const string DELETE_REFERENCE = "deleteReference";
		public const string RELEASE_CLAIMS = "releaseClaims";
		public const string API_AUTHORIZE_URL = "apiAuthorizeUrl";
		public const string PRIVACY_STATUS = "privacyStatus";
		public const string ENABLE_CONTENT_ID = "enableContentId";
		public const string THIRD_PARTY_ADS = "thirdPartyAds";
		public const string PRODUCT_LISTING_ADS = "productListingAds";
		public const string DOMAIN_WHITELIST = "domainWhitelist";
		public const string NOTIFY_SUBSCRIBERS = "notifySubscribers";
		#endregion

		#region Private Fields
		private YouTubeDistributionFeedSpecVersion _FeedSpecVersion = null;
		private string _Username = null;
		private string _NotificationEmail = null;
		private string _SftpHost = null;
		private int _SftpPort = Int32.MinValue;
		private string _SftpLogin = null;
		private string _SftpPublicKey = null;
		private string _SftpPrivateKey = null;
		private string _SftpBaseDir = null;
		private string _OwnerName = null;
		private string _DefaultCategory = null;
		private string _AllowComments = null;
		private string _AllowEmbedding = null;
		private string _AllowRatings = null;
		private string _AllowResponses = null;
		private string _CommercialPolicy = null;
		private string _UgcPolicy = null;
		private string _Target = null;
		private string _AdServerPartnerId = null;
		private bool? _EnableAdServer = null;
		private bool? _AllowPreRollAds = null;
		private bool? _AllowPostRollAds = null;
		private string _Strict = null;
		private string _OverrideManualEdits = null;
		private string _UrgentReference = null;
		private string _AllowSyndication = null;
		private string _HideViewCount = null;
		private string _AllowAdsenseForVideo = null;
		private string _AllowInvideo = null;
		private bool? _AllowMidRollAds = null;
		private string _InstreamStandard = null;
		private string _InstreamTrueview = null;
		private string _ClaimType = null;
		private string _BlockOutsideOwnership = null;
		private string _CaptionAutosync = null;
		private bool? _DeleteReference = null;
		private bool? _ReleaseClaims = null;
		private string _ApiAuthorizeUrl = null;
		private string _PrivacyStatus = null;
		private string _EnableContentId = null;
		private string _ThirdPartyAds = null;
		private string _ProductListingAds = null;
		private string _DomainWhitelist = null;
		private string _NotifySubscribers = null;
		#endregion

		#region Properties
		public YouTubeDistributionFeedSpecVersion FeedSpecVersion
		{
			get { return _FeedSpecVersion; }
			set 
			{ 
				_FeedSpecVersion = value;
				OnPropertyChanged("FeedSpecVersion");
			}
		}
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string NotificationEmail
		{
			get { return _NotificationEmail; }
			set 
			{ 
				_NotificationEmail = value;
				OnPropertyChanged("NotificationEmail");
			}
		}
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
			}
		}
		public int SftpPort
		{
			get { return _SftpPort; }
			set 
			{ 
				_SftpPort = value;
				OnPropertyChanged("SftpPort");
			}
		}
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		public string SftpPublicKey
		{
			get { return _SftpPublicKey; }
			set 
			{ 
				_SftpPublicKey = value;
				OnPropertyChanged("SftpPublicKey");
			}
		}
		public string SftpPrivateKey
		{
			get { return _SftpPrivateKey; }
			set 
			{ 
				_SftpPrivateKey = value;
				OnPropertyChanged("SftpPrivateKey");
			}
		}
		public string SftpBaseDir
		{
			get { return _SftpBaseDir; }
			set 
			{ 
				_SftpBaseDir = value;
				OnPropertyChanged("SftpBaseDir");
			}
		}
		public string OwnerName
		{
			get { return _OwnerName; }
			set 
			{ 
				_OwnerName = value;
				OnPropertyChanged("OwnerName");
			}
		}
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		public string AllowComments
		{
			get { return _AllowComments; }
			set 
			{ 
				_AllowComments = value;
				OnPropertyChanged("AllowComments");
			}
		}
		public string AllowEmbedding
		{
			get { return _AllowEmbedding; }
			set 
			{ 
				_AllowEmbedding = value;
				OnPropertyChanged("AllowEmbedding");
			}
		}
		public string AllowRatings
		{
			get { return _AllowRatings; }
			set 
			{ 
				_AllowRatings = value;
				OnPropertyChanged("AllowRatings");
			}
		}
		public string AllowResponses
		{
			get { return _AllowResponses; }
			set 
			{ 
				_AllowResponses = value;
				OnPropertyChanged("AllowResponses");
			}
		}
		public string CommercialPolicy
		{
			get { return _CommercialPolicy; }
			set 
			{ 
				_CommercialPolicy = value;
				OnPropertyChanged("CommercialPolicy");
			}
		}
		public string UgcPolicy
		{
			get { return _UgcPolicy; }
			set 
			{ 
				_UgcPolicy = value;
				OnPropertyChanged("UgcPolicy");
			}
		}
		public string Target
		{
			get { return _Target; }
			set 
			{ 
				_Target = value;
				OnPropertyChanged("Target");
			}
		}
		public string AdServerPartnerId
		{
			get { return _AdServerPartnerId; }
			set 
			{ 
				_AdServerPartnerId = value;
				OnPropertyChanged("AdServerPartnerId");
			}
		}
		public bool? EnableAdServer
		{
			get { return _EnableAdServer; }
			set 
			{ 
				_EnableAdServer = value;
				OnPropertyChanged("EnableAdServer");
			}
		}
		public bool? AllowPreRollAds
		{
			get { return _AllowPreRollAds; }
			set 
			{ 
				_AllowPreRollAds = value;
				OnPropertyChanged("AllowPreRollAds");
			}
		}
		public bool? AllowPostRollAds
		{
			get { return _AllowPostRollAds; }
			set 
			{ 
				_AllowPostRollAds = value;
				OnPropertyChanged("AllowPostRollAds");
			}
		}
		public string Strict
		{
			get { return _Strict; }
			set 
			{ 
				_Strict = value;
				OnPropertyChanged("Strict");
			}
		}
		public string OverrideManualEdits
		{
			get { return _OverrideManualEdits; }
			set 
			{ 
				_OverrideManualEdits = value;
				OnPropertyChanged("OverrideManualEdits");
			}
		}
		public string UrgentReference
		{
			get { return _UrgentReference; }
			set 
			{ 
				_UrgentReference = value;
				OnPropertyChanged("UrgentReference");
			}
		}
		public string AllowSyndication
		{
			get { return _AllowSyndication; }
			set 
			{ 
				_AllowSyndication = value;
				OnPropertyChanged("AllowSyndication");
			}
		}
		public string HideViewCount
		{
			get { return _HideViewCount; }
			set 
			{ 
				_HideViewCount = value;
				OnPropertyChanged("HideViewCount");
			}
		}
		public string AllowAdsenseForVideo
		{
			get { return _AllowAdsenseForVideo; }
			set 
			{ 
				_AllowAdsenseForVideo = value;
				OnPropertyChanged("AllowAdsenseForVideo");
			}
		}
		public string AllowInvideo
		{
			get { return _AllowInvideo; }
			set 
			{ 
				_AllowInvideo = value;
				OnPropertyChanged("AllowInvideo");
			}
		}
		public bool? AllowMidRollAds
		{
			get { return _AllowMidRollAds; }
			set 
			{ 
				_AllowMidRollAds = value;
				OnPropertyChanged("AllowMidRollAds");
			}
		}
		public string InstreamStandard
		{
			get { return _InstreamStandard; }
			set 
			{ 
				_InstreamStandard = value;
				OnPropertyChanged("InstreamStandard");
			}
		}
		public string InstreamTrueview
		{
			get { return _InstreamTrueview; }
			set 
			{ 
				_InstreamTrueview = value;
				OnPropertyChanged("InstreamTrueview");
			}
		}
		public string ClaimType
		{
			get { return _ClaimType; }
			set 
			{ 
				_ClaimType = value;
				OnPropertyChanged("ClaimType");
			}
		}
		public string BlockOutsideOwnership
		{
			get { return _BlockOutsideOwnership; }
			set 
			{ 
				_BlockOutsideOwnership = value;
				OnPropertyChanged("BlockOutsideOwnership");
			}
		}
		public string CaptionAutosync
		{
			get { return _CaptionAutosync; }
			set 
			{ 
				_CaptionAutosync = value;
				OnPropertyChanged("CaptionAutosync");
			}
		}
		public bool? DeleteReference
		{
			get { return _DeleteReference; }
			set 
			{ 
				_DeleteReference = value;
				OnPropertyChanged("DeleteReference");
			}
		}
		public bool? ReleaseClaims
		{
			get { return _ReleaseClaims; }
			set 
			{ 
				_ReleaseClaims = value;
				OnPropertyChanged("ReleaseClaims");
			}
		}
		public string ApiAuthorizeUrl
		{
			get { return _ApiAuthorizeUrl; }
			set 
			{ 
				_ApiAuthorizeUrl = value;
				OnPropertyChanged("ApiAuthorizeUrl");
			}
		}
		public string PrivacyStatus
		{
			get { return _PrivacyStatus; }
			set 
			{ 
				_PrivacyStatus = value;
				OnPropertyChanged("PrivacyStatus");
			}
		}
		public string EnableContentId
		{
			get { return _EnableContentId; }
			set 
			{ 
				_EnableContentId = value;
				OnPropertyChanged("EnableContentId");
			}
		}
		public string ThirdPartyAds
		{
			get { return _ThirdPartyAds; }
			set 
			{ 
				_ThirdPartyAds = value;
				OnPropertyChanged("ThirdPartyAds");
			}
		}
		public string ProductListingAds
		{
			get { return _ProductListingAds; }
			set 
			{ 
				_ProductListingAds = value;
				OnPropertyChanged("ProductListingAds");
			}
		}
		public string DomainWhitelist
		{
			get { return _DomainWhitelist; }
			set 
			{ 
				_DomainWhitelist = value;
				OnPropertyChanged("DomainWhitelist");
			}
		}
		public string NotifySubscribers
		{
			get { return _NotifySubscribers; }
			set 
			{ 
				_NotifySubscribers = value;
				OnPropertyChanged("NotifySubscribers");
			}
		}
		#endregion

		#region CTor
		public YouTubeDistributionProfile()
		{
		}

		public YouTubeDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "feedSpecVersion":
						this._FeedSpecVersion = (YouTubeDistributionFeedSpecVersion)StringEnum.Parse(typeof(YouTubeDistributionFeedSpecVersion), propertyNode.InnerText);
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "notificationEmail":
						this._NotificationEmail = propertyNode.InnerText;
						continue;
					case "sftpHost":
						this._SftpHost = propertyNode.InnerText;
						continue;
					case "sftpPort":
						this._SftpPort = ParseInt(propertyNode.InnerText);
						continue;
					case "sftpLogin":
						this._SftpLogin = propertyNode.InnerText;
						continue;
					case "sftpPublicKey":
						this._SftpPublicKey = propertyNode.InnerText;
						continue;
					case "sftpPrivateKey":
						this._SftpPrivateKey = propertyNode.InnerText;
						continue;
					case "sftpBaseDir":
						this._SftpBaseDir = propertyNode.InnerText;
						continue;
					case "ownerName":
						this._OwnerName = propertyNode.InnerText;
						continue;
					case "defaultCategory":
						this._DefaultCategory = propertyNode.InnerText;
						continue;
					case "allowComments":
						this._AllowComments = propertyNode.InnerText;
						continue;
					case "allowEmbedding":
						this._AllowEmbedding = propertyNode.InnerText;
						continue;
					case "allowRatings":
						this._AllowRatings = propertyNode.InnerText;
						continue;
					case "allowResponses":
						this._AllowResponses = propertyNode.InnerText;
						continue;
					case "commercialPolicy":
						this._CommercialPolicy = propertyNode.InnerText;
						continue;
					case "ugcPolicy":
						this._UgcPolicy = propertyNode.InnerText;
						continue;
					case "target":
						this._Target = propertyNode.InnerText;
						continue;
					case "adServerPartnerId":
						this._AdServerPartnerId = propertyNode.InnerText;
						continue;
					case "enableAdServer":
						this._EnableAdServer = ParseBool(propertyNode.InnerText);
						continue;
					case "allowPreRollAds":
						this._AllowPreRollAds = ParseBool(propertyNode.InnerText);
						continue;
					case "allowPostRollAds":
						this._AllowPostRollAds = ParseBool(propertyNode.InnerText);
						continue;
					case "strict":
						this._Strict = propertyNode.InnerText;
						continue;
					case "overrideManualEdits":
						this._OverrideManualEdits = propertyNode.InnerText;
						continue;
					case "urgentReference":
						this._UrgentReference = propertyNode.InnerText;
						continue;
					case "allowSyndication":
						this._AllowSyndication = propertyNode.InnerText;
						continue;
					case "hideViewCount":
						this._HideViewCount = propertyNode.InnerText;
						continue;
					case "allowAdsenseForVideo":
						this._AllowAdsenseForVideo = propertyNode.InnerText;
						continue;
					case "allowInvideo":
						this._AllowInvideo = propertyNode.InnerText;
						continue;
					case "allowMidRollAds":
						this._AllowMidRollAds = ParseBool(propertyNode.InnerText);
						continue;
					case "instreamStandard":
						this._InstreamStandard = propertyNode.InnerText;
						continue;
					case "instreamTrueview":
						this._InstreamTrueview = propertyNode.InnerText;
						continue;
					case "claimType":
						this._ClaimType = propertyNode.InnerText;
						continue;
					case "blockOutsideOwnership":
						this._BlockOutsideOwnership = propertyNode.InnerText;
						continue;
					case "captionAutosync":
						this._CaptionAutosync = propertyNode.InnerText;
						continue;
					case "deleteReference":
						this._DeleteReference = ParseBool(propertyNode.InnerText);
						continue;
					case "releaseClaims":
						this._ReleaseClaims = ParseBool(propertyNode.InnerText);
						continue;
					case "apiAuthorizeUrl":
						this._ApiAuthorizeUrl = propertyNode.InnerText;
						continue;
					case "privacyStatus":
						this._PrivacyStatus = propertyNode.InnerText;
						continue;
					case "enableContentId":
						this._EnableContentId = propertyNode.InnerText;
						continue;
					case "thirdPartyAds":
						this._ThirdPartyAds = propertyNode.InnerText;
						continue;
					case "productListingAds":
						this._ProductListingAds = propertyNode.InnerText;
						continue;
					case "domainWhitelist":
						this._DomainWhitelist = propertyNode.InnerText;
						continue;
					case "notifySubscribers":
						this._NotifySubscribers = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaYouTubeDistributionProfile");
			kparams.AddIfNotNull("feedSpecVersion", this._FeedSpecVersion);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("notificationEmail", this._NotificationEmail);
			kparams.AddIfNotNull("sftpHost", this._SftpHost);
			kparams.AddIfNotNull("sftpPort", this._SftpPort);
			kparams.AddIfNotNull("sftpLogin", this._SftpLogin);
			kparams.AddIfNotNull("sftpPublicKey", this._SftpPublicKey);
			kparams.AddIfNotNull("sftpPrivateKey", this._SftpPrivateKey);
			kparams.AddIfNotNull("sftpBaseDir", this._SftpBaseDir);
			kparams.AddIfNotNull("ownerName", this._OwnerName);
			kparams.AddIfNotNull("defaultCategory", this._DefaultCategory);
			kparams.AddIfNotNull("allowComments", this._AllowComments);
			kparams.AddIfNotNull("allowEmbedding", this._AllowEmbedding);
			kparams.AddIfNotNull("allowRatings", this._AllowRatings);
			kparams.AddIfNotNull("allowResponses", this._AllowResponses);
			kparams.AddIfNotNull("commercialPolicy", this._CommercialPolicy);
			kparams.AddIfNotNull("ugcPolicy", this._UgcPolicy);
			kparams.AddIfNotNull("target", this._Target);
			kparams.AddIfNotNull("adServerPartnerId", this._AdServerPartnerId);
			kparams.AddIfNotNull("enableAdServer", this._EnableAdServer);
			kparams.AddIfNotNull("allowPreRollAds", this._AllowPreRollAds);
			kparams.AddIfNotNull("allowPostRollAds", this._AllowPostRollAds);
			kparams.AddIfNotNull("strict", this._Strict);
			kparams.AddIfNotNull("overrideManualEdits", this._OverrideManualEdits);
			kparams.AddIfNotNull("urgentReference", this._UrgentReference);
			kparams.AddIfNotNull("allowSyndication", this._AllowSyndication);
			kparams.AddIfNotNull("hideViewCount", this._HideViewCount);
			kparams.AddIfNotNull("allowAdsenseForVideo", this._AllowAdsenseForVideo);
			kparams.AddIfNotNull("allowInvideo", this._AllowInvideo);
			kparams.AddIfNotNull("allowMidRollAds", this._AllowMidRollAds);
			kparams.AddIfNotNull("instreamStandard", this._InstreamStandard);
			kparams.AddIfNotNull("instreamTrueview", this._InstreamTrueview);
			kparams.AddIfNotNull("claimType", this._ClaimType);
			kparams.AddIfNotNull("blockOutsideOwnership", this._BlockOutsideOwnership);
			kparams.AddIfNotNull("captionAutosync", this._CaptionAutosync);
			kparams.AddIfNotNull("deleteReference", this._DeleteReference);
			kparams.AddIfNotNull("releaseClaims", this._ReleaseClaims);
			kparams.AddIfNotNull("apiAuthorizeUrl", this._ApiAuthorizeUrl);
			kparams.AddIfNotNull("privacyStatus", this._PrivacyStatus);
			kparams.AddIfNotNull("enableContentId", this._EnableContentId);
			kparams.AddIfNotNull("thirdPartyAds", this._ThirdPartyAds);
			kparams.AddIfNotNull("productListingAds", this._ProductListingAds);
			kparams.AddIfNotNull("domainWhitelist", this._DomainWhitelist);
			kparams.AddIfNotNull("notifySubscribers", this._NotifySubscribers);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_SPEC_VERSION:
					return "FeedSpecVersion";
				case USERNAME:
					return "Username";
				case NOTIFICATION_EMAIL:
					return "NotificationEmail";
				case SFTP_HOST:
					return "SftpHost";
				case SFTP_PORT:
					return "SftpPort";
				case SFTP_LOGIN:
					return "SftpLogin";
				case SFTP_PUBLIC_KEY:
					return "SftpPublicKey";
				case SFTP_PRIVATE_KEY:
					return "SftpPrivateKey";
				case SFTP_BASE_DIR:
					return "SftpBaseDir";
				case OWNER_NAME:
					return "OwnerName";
				case DEFAULT_CATEGORY:
					return "DefaultCategory";
				case ALLOW_COMMENTS:
					return "AllowComments";
				case ALLOW_EMBEDDING:
					return "AllowEmbedding";
				case ALLOW_RATINGS:
					return "AllowRatings";
				case ALLOW_RESPONSES:
					return "AllowResponses";
				case COMMERCIAL_POLICY:
					return "CommercialPolicy";
				case UGC_POLICY:
					return "UgcPolicy";
				case TARGET:
					return "Target";
				case AD_SERVER_PARTNER_ID:
					return "AdServerPartnerId";
				case ENABLE_AD_SERVER:
					return "EnableAdServer";
				case ALLOW_PRE_ROLL_ADS:
					return "AllowPreRollAds";
				case ALLOW_POST_ROLL_ADS:
					return "AllowPostRollAds";
				case STRICT:
					return "Strict";
				case OVERRIDE_MANUAL_EDITS:
					return "OverrideManualEdits";
				case URGENT_REFERENCE:
					return "UrgentReference";
				case ALLOW_SYNDICATION:
					return "AllowSyndication";
				case HIDE_VIEW_COUNT:
					return "HideViewCount";
				case ALLOW_ADSENSE_FOR_VIDEO:
					return "AllowAdsenseForVideo";
				case ALLOW_INVIDEO:
					return "AllowInvideo";
				case ALLOW_MID_ROLL_ADS:
					return "AllowMidRollAds";
				case INSTREAM_STANDARD:
					return "InstreamStandard";
				case INSTREAM_TRUEVIEW:
					return "InstreamTrueview";
				case CLAIM_TYPE:
					return "ClaimType";
				case BLOCK_OUTSIDE_OWNERSHIP:
					return "BlockOutsideOwnership";
				case CAPTION_AUTOSYNC:
					return "CaptionAutosync";
				case DELETE_REFERENCE:
					return "DeleteReference";
				case RELEASE_CLAIMS:
					return "ReleaseClaims";
				case API_AUTHORIZE_URL:
					return "ApiAuthorizeUrl";
				case PRIVACY_STATUS:
					return "PrivacyStatus";
				case ENABLE_CONTENT_ID:
					return "EnableContentId";
				case THIRD_PARTY_ADS:
					return "ThirdPartyAds";
				case PRODUCT_LISTING_ADS:
					return "ProductListingAds";
				case DOMAIN_WHITELIST:
					return "DomainWhitelist";
				case NOTIFY_SUBSCRIBERS:
					return "NotifySubscribers";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

