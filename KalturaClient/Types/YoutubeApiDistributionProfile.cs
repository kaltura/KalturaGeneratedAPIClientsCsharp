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
	public class YoutubeApiDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string USERNAME = "username";
		public const string DEFAULT_CATEGORY = "defaultCategory";
		public const string ALLOW_COMMENTS = "allowComments";
		public const string ALLOW_EMBEDDING = "allowEmbedding";
		public const string ALLOW_RATINGS = "allowRatings";
		public const string ALLOW_RESPONSES = "allowResponses";
		public const string API_AUTHORIZE_URL = "apiAuthorizeUrl";
		public const string GOOGLE_CLIENT_ID = "googleClientId";
		public const string GOOGLE_CLIENT_SECRET = "googleClientSecret";
		public const string GOOGLE_TOKEN_DATA = "googleTokenData";
		public const string ASSUME_SUCCESS = "assumeSuccess";
		public const string PRIVACY_STATUS = "privacyStatus";
		#endregion

		#region Private Fields
		private string _Username = null;
		private int _DefaultCategory = Int32.MinValue;
		private string _AllowComments = null;
		private string _AllowEmbedding = null;
		private string _AllowRatings = null;
		private string _AllowResponses = null;
		private string _ApiAuthorizeUrl = null;
		private string _GoogleClientId = null;
		private string _GoogleClientSecret = null;
		private string _GoogleTokenData = null;
		private bool? _AssumeSuccess = null;
		private string _PrivacyStatus = null;
		#endregion

		#region Properties
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
		public int DefaultCategory
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
		public string GoogleClientId
		{
			get { return _GoogleClientId; }
			set 
			{ 
				_GoogleClientId = value;
				OnPropertyChanged("GoogleClientId");
			}
		}
		[JsonProperty]
		public string GoogleClientSecret
		{
			get { return _GoogleClientSecret; }
			set 
			{ 
				_GoogleClientSecret = value;
				OnPropertyChanged("GoogleClientSecret");
			}
		}
		[JsonProperty]
		public string GoogleTokenData
		{
			get { return _GoogleTokenData; }
			set 
			{ 
				_GoogleTokenData = value;
				OnPropertyChanged("GoogleTokenData");
			}
		}
		[JsonProperty]
		public bool? AssumeSuccess
		{
			get { return _AssumeSuccess; }
			set 
			{ 
				_AssumeSuccess = value;
				OnPropertyChanged("AssumeSuccess");
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
		#endregion

		#region CTor
		public YoutubeApiDistributionProfile()
		{
		}

		public YoutubeApiDistributionProfile(JToken node) : base(node)
		{
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["defaultCategory"] != null)
			{
				this._DefaultCategory = ParseInt(node["defaultCategory"].Value<string>());
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
			if(node["apiAuthorizeUrl"] != null)
			{
				this._ApiAuthorizeUrl = node["apiAuthorizeUrl"].Value<string>();
			}
			if(node["googleClientId"] != null)
			{
				this._GoogleClientId = node["googleClientId"].Value<string>();
			}
			if(node["googleClientSecret"] != null)
			{
				this._GoogleClientSecret = node["googleClientSecret"].Value<string>();
			}
			if(node["googleTokenData"] != null)
			{
				this._GoogleTokenData = node["googleTokenData"].Value<string>();
			}
			if(node["assumeSuccess"] != null)
			{
				this._AssumeSuccess = ParseBool(node["assumeSuccess"].Value<string>());
			}
			if(node["privacyStatus"] != null)
			{
				this._PrivacyStatus = node["privacyStatus"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaYoutubeApiDistributionProfile");
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("defaultCategory", this._DefaultCategory);
			kparams.AddIfNotNull("allowComments", this._AllowComments);
			kparams.AddIfNotNull("allowEmbedding", this._AllowEmbedding);
			kparams.AddIfNotNull("allowRatings", this._AllowRatings);
			kparams.AddIfNotNull("allowResponses", this._AllowResponses);
			kparams.AddIfNotNull("apiAuthorizeUrl", this._ApiAuthorizeUrl);
			kparams.AddIfNotNull("googleClientId", this._GoogleClientId);
			kparams.AddIfNotNull("googleClientSecret", this._GoogleClientSecret);
			kparams.AddIfNotNull("googleTokenData", this._GoogleTokenData);
			kparams.AddIfNotNull("assumeSuccess", this._AssumeSuccess);
			kparams.AddIfNotNull("privacyStatus", this._PrivacyStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USERNAME:
					return "Username";
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
				case API_AUTHORIZE_URL:
					return "ApiAuthorizeUrl";
				case GOOGLE_CLIENT_ID:
					return "GoogleClientId";
				case GOOGLE_CLIENT_SECRET:
					return "GoogleClientSecret";
				case GOOGLE_TOKEN_DATA:
					return "GoogleTokenData";
				case ASSUME_SUCCESS:
					return "AssumeSuccess";
				case PRIVACY_STATUS:
					return "PrivacyStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

