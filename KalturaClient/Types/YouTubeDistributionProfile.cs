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
// Copyright (C) 2006-2019  Kaltura Inc.
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
		[JsonProperty]
		public YouTubeDistributionFeedSpecVersion FeedSpecVersion
		{
			get { return _FeedSpecVersion; }
			set 
			{ 
				_FeedSpecVersion = value;
				OnPropertyChanged("FeedSpecVersion");
			}
		}
		[JsonProperty]
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		[JsonProperty]
		public string NotificationEmail
		{
			get { return _NotificationEmail; }
			set 
			{ 
				_NotificationEmail = value;
				OnPropertyChanged("NotificationEmail");
			}
		}
		[JsonProperty]
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
			}
		}
		[JsonProperty]
		public int SftpPort
		{
			get { return _SftpPort; }
			set 
			{ 
				_SftpPort = value;
				OnPropertyChanged("SftpPort");
			}
		}
		[JsonProperty]
		public string SftpLogin
		{
			get { return _SftpLogin; }
			set 
			{ 
				_SftpLogin = value;
				OnPropertyChanged("SftpLogin");
			}
		}
		[JsonProperty]
		public string SftpPublicKey
		{
			get { return _SftpPublicKey; }
			set 
			{ 
				_SftpPublicKey = value;
				OnPropertyChanged("SftpPublicKey");
			}
		}
		[JsonProperty]
		public string SftpPrivateKey
		{
			get { return _SftpPrivateKey; }
			set 
			{ 
				_SftpPrivateKey = value;
				OnPropertyChanged("SftpPrivateKey");
			}
		}
		[JsonProperty]
		public string SftpBaseDir
		{
			get { return _SftpBaseDir; }
			set 
			{ 
				_SftpBaseDir = value;
				OnPropertyChanged("SftpBaseDir");
			}
		}
		[JsonProperty]
		public string OwnerName
		{
			get { return _OwnerName; }
			set 
			{ 
				_OwnerName = value;
				OnPropertyChanged("OwnerName");
			}
		}
		[JsonProperty]
		public string DefaultCategory
		{
			get { return _DefaultCategory; }
			set 
			{ 
				_DefaultCategory = value;
				OnPropertyChanged("DefaultCategory");
			}
		}
		[JsonProperty]
		public string AllowComments
		{
			get { return _AllowComments; }
			set 
			{ 
				_AllowComments = value;
				OnPropertyChanged("AllowComments");
			}
		}
		[JsonProperty]
		public string AllowEmbedding
		{
			get { return _AllowEmbedding; }
			set 
			{ 
				_AllowEmbedding = value;
				OnPropertyChanged("AllowEmbedding");
			}
		}
		[JsonProperty]
		public string AllowRatings
		{
			get { return _AllowRatings; }
			set 
			{ 
				_AllowRatings = value;
				OnPropertyChanged("AllowRatings");
			}
		}
		[JsonProperty]
		public string AllowResponses
		{
			get { return _AllowResponses; }
			set 
			{ 
				_AllowResponses = value;
				OnPropertyChanged("AllowResponses");
			}
		}
		[JsonProperty]
		public string CommercialPolicy
		{
			get { return _CommercialPolicy; }
			set 
			{ 
				_CommercialPolicy = value;
				OnPropertyChanged("CommercialPolicy");
			}
		}
		[JsonProperty]
		public string UgcPolicy
		{
			get { return _UgcPolicy; }
			set 
			{ 
				_UgcPolicy = value;
				OnPropertyChanged("UgcPolicy");
			}
		}
		[JsonProperty]
		public string Target
		{
			get { return _Target; }
			set 
			{ 
				_Target = value;
				OnPropertyChanged("Target");
			}
		}
		[JsonProperty]
		public string AdServerPartnerId
		{
			get { return _AdServerPartnerId; }
			set 
			{ 
				_AdServerPartnerId = value;
				OnPropertyChanged("AdServerPartnerId");
			}
		}
		[JsonProperty]
		public bool? EnableAdServer
		{
			get { return _EnableAdServer; }
			set 
			{ 
				_EnableAdServer = value;
				OnPropertyChanged("EnableAdServer");
			}
		}
		[JsonProperty]
		public bool? AllowPreRollAds
		{
			get { return _AllowPreRollAds; }
			set 
			{ 
				_AllowPreRollAds = value;
				OnPropertyChanged("AllowPreRollAds");
			}
		}
		[JsonProperty]
		public bool? AllowPostRollAds
		{
			get { return _AllowPostRollAds; }
			set 
			{ 
				_AllowPostRollAds = value;
				OnPropertyChanged("AllowPostRollAds");
			}
		}
		[JsonProperty]
		public string Strict
		{
			get { return _Strict; }
			set 
			{ 
				_Strict = value;
				OnPropertyChanged("Strict");
			}
		}
		[JsonProperty]
		public string OverrideManualEdits
		{
			get { return _OverrideManualEdits; }
			set 
			{ 
				_OverrideManualEdits = value;
				OnPropertyChanged("OverrideManualEdits");
			}
		}
		[JsonProperty]
		public string UrgentReference
		{
			get { return _UrgentReference; }
			set 
			{ 
				_UrgentReference = value;
				OnPropertyChanged("UrgentReference");
			}
		}
		[JsonProperty]
		public string AllowSyndication
		{
			get { return _AllowSyndication; }
			set 
			{ 
				_AllowSyndication = value;
				OnPropertyChanged("AllowSyndication");
			}
		}
		[JsonProperty]
		public string HideViewCount
		{
			get { return _HideViewCount; }
			set 
			{ 
				_HideViewCount = value;
				OnPropertyChanged("HideViewCount");
			}
		}
		[JsonProperty]
		public string AllowAdsenseForVideo
		{
			get { return _AllowAdsenseForVideo; }
			set 
			{ 
				_AllowAdsenseForVideo = value;
				OnPropertyChanged("AllowAdsenseForVideo");
			}
		}
		[JsonProperty]
		public string AllowInvideo
		{
			get { return _AllowInvideo; }
			set 
			{ 
				_AllowInvideo = value;
				OnPropertyChanged("AllowInvideo");
			}
		}
		[JsonProperty]
		public bool? AllowMidRollAds
		{
			get { return _AllowMidRollAds; }
			set 
			{ 
				_AllowMidRollAds = value;
				OnPropertyChanged("AllowMidRollAds");
			}
		}
		[JsonProperty]
		public string InstreamStandard
		{
			get { return _InstreamStandard; }
			set 
			{ 
				_InstreamStandard = value;
				OnPropertyChanged("InstreamStandard");
			}
		}
		[JsonProperty]
		public string InstreamTrueview
		{
			get { return _InstreamTrueview; }
			set 
			{ 
				_InstreamTrueview = value;
				OnPropertyChanged("InstreamTrueview");
			}
		}
		[JsonProperty]
		public string ClaimType
		{
			get { return _ClaimType; }
			set 
			{ 
				_ClaimType = value;
				OnPropertyChanged("ClaimType");
			}
		}
		[JsonProperty]
		public string BlockOutsideOwnership
		{
			get { return _BlockOutsideOwnership; }
			set 
			{ 
				_BlockOutsideOwnership = value;
				OnPropertyChanged("BlockOutsideOwnership");
			}
		}
		[JsonProperty]
		public string CaptionAutosync
		{
			get { return _CaptionAutosync; }
			set 
			{ 
				_CaptionAutosync = value;
				OnPropertyChanged("CaptionAutosync");
			}
		}
		[JsonProperty]
		public bool? DeleteReference
		{
			get { return _DeleteReference; }
			set 
			{ 
				_DeleteReference = value;
				OnPropertyChanged("DeleteReference");
			}
		}
		[JsonProperty]
		public bool? ReleaseClaims
		{
			get { return _ReleaseClaims; }
			set 
			{ 
				_ReleaseClaims = value;
				OnPropertyChanged("ReleaseClaims");
			}
		}
		[JsonProperty]
		public string ApiAuthorizeUrl
		{
			get { return _ApiAuthorizeUrl; }
			set 
			{ 
				_ApiAuthorizeUrl = value;
				OnPropertyChanged("ApiAuthorizeUrl");
			}
		}
		[JsonProperty]
		public string PrivacyStatus
		{
			get { return _PrivacyStatus; }
			set 
			{ 
				_PrivacyStatus = value;
				OnPropertyChanged("PrivacyStatus");
			}
		}
		[JsonProperty]
		public string EnableContentId
		{
			get { return _EnableContentId; }
			set 
			{ 
				_EnableContentId = value;
				OnPropertyChanged("EnableContentId");
			}
		}
		[JsonProperty]
		public string ThirdPartyAds
		{
			get { return _ThirdPartyAds; }
			set 
			{ 
				_ThirdPartyAds = value;
				OnPropertyChanged("ThirdPartyAds");
			}
		}
		[JsonProperty]
		public string ProductListingAds
		{
			get { return _ProductListingAds; }
			set 
			{ 
				_ProductListingAds = value;
				OnPropertyChanged("ProductListingAds");
			}
		}
		[JsonProperty]
		public string DomainWhitelist
		{
			get { return _DomainWhitelist; }
			set 
			{ 
				_DomainWhitelist = value;
				OnPropertyChanged("DomainWhitelist");
			}
		}
		[JsonProperty]
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

		public YouTubeDistributionProfile(JToken node) : base(node)
		{
			if(node["feedSpecVersion"] != null)
			{
				this._FeedSpecVersion = (YouTubeDistributionFeedSpecVersion)StringEnum.Parse(typeof(YouTubeDistributionFeedSpecVersion), node["feedSpecVersion"].Value<string>());
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["notificationEmail"] != null)
			{
				this._NotificationEmail = node["notificationEmail"].Value<string>();
			}
			if(node["sftpHost"] != null)
			{
				this._SftpHost = node["sftpHost"].Value<string>();
			}
			if(node["sftpPort"] != null)
			{
				this._SftpPort = ParseInt(node["sftpPort"].Value<string>());
			}
			if(node["sftpLogin"] != null)
			{
				this._SftpLogin = node["sftpLogin"].Value<string>();
			}
			if(node["sftpPublicKey"] != null)
			{
				this._SftpPublicKey = node["sftpPublicKey"].Value<string>();
			}
			if(node["sftpPrivateKey"] != null)
			{
				this._SftpPrivateKey = node["sftpPrivateKey"].Value<string>();
			}
			if(node["sftpBaseDir"] != null)
			{
				this._SftpBaseDir = node["sftpBaseDir"].Value<string>();
			}
			if(node["ownerName"] != null)
			{
				this._OwnerName = node["ownerName"].Value<string>();
			}
			if(node["defaultCategory"] != null)
			{
				this._DefaultCategory = node["defaultCategory"].Value<string>();
			}
			if(node["allowComments"] != null)
			{
				this._AllowComments = node["allowComments"].Value<string>();
			}
			if(node["allowEmbedding"] != null)
			{
				this._AllowEmbedding = node["allowEmbedding"].Value<string>();
			}
			if(node["allowRatings"] != null)
			{
				this._AllowRatings = node["allowRatings"].Value<string>();
			}
			if(node["allowResponses"] != null)
			{
				this._AllowResponses = node["allowResponses"].Value<string>();
			}
			if(node["commercialPolicy"] != null)
			{
				this._CommercialPolicy = node["commercialPolicy"].Value<string>();
			}
			if(node["ugcPolicy"] != null)
			{
				this._UgcPolicy = node["ugcPolicy"].Value<string>();
			}
			if(node["target"] != null)
			{
				this._Target = node["target"].Value<string>();
			}
			if(node["adServerPartnerId"] != null)
			{
				this._AdServerPartnerId = node["adServerPartnerId"].Value<string>();
			}
			if(node["enableAdServer"] != null)
			{
				this._EnableAdServer = ParseBool(node["enableAdServer"].Value<string>());
			}
			if(node["allowPreRollAds"] != null)
			{
				this._AllowPreRollAds = ParseBool(node["allowPreRollAds"].Value<string>());
			}
			if(node["allowPostRollAds"] != null)
			{
				this._AllowPostRollAds = ParseBool(node["allowPostRollAds"].Value<string>());
			}
			if(node["strict"] != null)
			{
				this._Strict = node["strict"].Value<string>();
			}
			if(node["overrideManualEdits"] != null)
			{
				this._OverrideManualEdits = node["overrideManualEdits"].Value<string>();
			}
			if(node["urgentReference"] != null)
			{
				this._UrgentReference = node["urgentReference"].Value<string>();
			}
			if(node["allowSyndication"] != null)
			{
				this._AllowSyndication = node["allowSyndication"].Value<string>();
			}
			if(node["hideViewCount"] != null)
			{
				this._HideViewCount = node["hideViewCount"].Value<string>();
			}
			if(node["allowAdsenseForVideo"] != null)
			{
				this._AllowAdsenseForVideo = node["allowAdsenseForVideo"].Value<string>();
			}
			if(node["allowInvideo"] != null)
			{
				this._AllowInvideo = node["allowInvideo"].Value<string>();
			}
			if(node["allowMidRollAds"] != null)
			{
				this._AllowMidRollAds = ParseBool(node["allowMidRollAds"].Value<string>());
			}
			if(node["instreamStandard"] != null)
			{
				this._InstreamStandard = node["instreamStandard"].Value<string>();
			}
			if(node["instreamTrueview"] != null)
			{
				this._InstreamTrueview = node["instreamTrueview"].Value<string>();
			}
			if(node["claimType"] != null)
			{
				this._ClaimType = node["claimType"].Value<string>();
			}
			if(node["blockOutsideOwnership"] != null)
			{
				this._BlockOutsideOwnership = node["blockOutsideOwnership"].Value<string>();
			}
			if(node["captionAutosync"] != null)
			{
				this._CaptionAutosync = node["captionAutosync"].Value<string>();
			}
			if(node["deleteReference"] != null)
			{
				this._DeleteReference = ParseBool(node["deleteReference"].Value<string>());
			}
			if(node["releaseClaims"] != null)
			{
				this._ReleaseClaims = ParseBool(node["releaseClaims"].Value<string>());
			}
			if(node["apiAuthorizeUrl"] != null)
			{
				this._ApiAuthorizeUrl = node["apiAuthorizeUrl"].Value<string>();
			}
			if(node["privacyStatus"] != null)
			{
				this._PrivacyStatus = node["privacyStatus"].Value<string>();
			}
			if(node["enableContentId"] != null)
			{
				this._EnableContentId = node["enableContentId"].Value<string>();
			}
			if(node["thirdPartyAds"] != null)
			{
				this._ThirdPartyAds = node["thirdPartyAds"].Value<string>();
			}
			if(node["productListingAds"] != null)
			{
				this._ProductListingAds = node["productListingAds"].Value<string>();
			}
			if(node["domainWhitelist"] != null)
			{
				this._DomainWhitelist = node["domainWhitelist"].Value<string>();
			}
			if(node["notifySubscribers"] != null)
			{
				this._NotifySubscribers = node["notifySubscribers"].Value<string>();
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

