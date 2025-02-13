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
	public class UverseDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_URL = "feedUrl";
		public const string CHANNEL_TITLE = "channelTitle";
		public const string CHANNEL_LINK = "channelLink";
		public const string CHANNEL_DESCRIPTION = "channelDescription";
		public const string CHANNEL_LANGUAGE = "channelLanguage";
		public const string CHANNEL_COPYRIGHT = "channelCopyright";
		public const string CHANNEL_IMAGE_TITLE = "channelImageTitle";
		public const string CHANNEL_IMAGE_URL = "channelImageUrl";
		public const string CHANNEL_IMAGE_LINK = "channelImageLink";
		public const string FTP_HOST = "ftpHost";
		public const string FTP_LOGIN = "ftpLogin";
		public const string FTP_PASSWORD = "ftpPassword";
		#endregion

		#region Private Fields
		private string _FeedUrl = null;
		private string _ChannelTitle = null;
		private string _ChannelLink = null;
		private string _ChannelDescription = null;
		private string _ChannelLanguage = null;
		private string _ChannelCopyright = null;
		private string _ChannelImageTitle = null;
		private string _ChannelImageUrl = null;
		private string _ChannelImageLink = null;
		private string _FtpHost = null;
		private string _FtpLogin = null;
		private string _FtpPassword = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string FeedUrl
		{
			get { return _FeedUrl; }
			private set 
			{ 
				_FeedUrl = value;
				OnPropertyChanged("FeedUrl");
			}
		}
		[JsonProperty]
		public string ChannelTitle
		{
			get { return _ChannelTitle; }
			set 
			{ 
				_ChannelTitle = value;
				OnPropertyChanged("ChannelTitle");
			}
		}
		[JsonProperty]
		public string ChannelLink
		{
			get { return _ChannelLink; }
			set 
			{ 
				_ChannelLink = value;
				OnPropertyChanged("ChannelLink");
			}
		}
		[JsonProperty]
		public string ChannelDescription
		{
			get { return _ChannelDescription; }
			set 
			{ 
				_ChannelDescription = value;
				OnPropertyChanged("ChannelDescription");
			}
		}
		[JsonProperty]
		public string ChannelLanguage
		{
			get { return _ChannelLanguage; }
			set 
			{ 
				_ChannelLanguage = value;
				OnPropertyChanged("ChannelLanguage");
			}
		}
		[JsonProperty]
		public string ChannelCopyright
		{
			get { return _ChannelCopyright; }
			set 
			{ 
				_ChannelCopyright = value;
				OnPropertyChanged("ChannelCopyright");
			}
		}
		[JsonProperty]
		public string ChannelImageTitle
		{
			get { return _ChannelImageTitle; }
			set 
			{ 
				_ChannelImageTitle = value;
				OnPropertyChanged("ChannelImageTitle");
			}
		}
		[JsonProperty]
		public string ChannelImageUrl
		{
			get { return _ChannelImageUrl; }
			set 
			{ 
				_ChannelImageUrl = value;
				OnPropertyChanged("ChannelImageUrl");
			}
		}
		[JsonProperty]
		public string ChannelImageLink
		{
			get { return _ChannelImageLink; }
			set 
			{ 
				_ChannelImageLink = value;
				OnPropertyChanged("ChannelImageLink");
			}
		}
		[JsonProperty]
		public string FtpHost
		{
			get { return _FtpHost; }
			set 
			{ 
				_FtpHost = value;
				OnPropertyChanged("FtpHost");
			}
		}
		[JsonProperty]
		public string FtpLogin
		{
			get { return _FtpLogin; }
			set 
			{ 
				_FtpLogin = value;
				OnPropertyChanged("FtpLogin");
			}
		}
		[JsonProperty]
		public string FtpPassword
		{
			get { return _FtpPassword; }
			set 
			{ 
				_FtpPassword = value;
				OnPropertyChanged("FtpPassword");
			}
		}
		#endregion

		#region CTor
		public UverseDistributionProfile()
		{
		}

		public UverseDistributionProfile(JToken node) : base(node)
		{
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["channelTitle"] != null)
			{
				this._ChannelTitle = node["channelTitle"].Value<string>();
			}
			if(node["channelLink"] != null)
			{
				this._ChannelLink = node["channelLink"].Value<string>();
			}
			if(node["channelDescription"] != null)
			{
				this._ChannelDescription = node["channelDescription"].Value<string>();
			}
			if(node["channelLanguage"] != null)
			{
				this._ChannelLanguage = node["channelLanguage"].Value<string>();
			}
			if(node["channelCopyright"] != null)
			{
				this._ChannelCopyright = node["channelCopyright"].Value<string>();
			}
			if(node["channelImageTitle"] != null)
			{
				this._ChannelImageTitle = node["channelImageTitle"].Value<string>();
			}
			if(node["channelImageUrl"] != null)
			{
				this._ChannelImageUrl = node["channelImageUrl"].Value<string>();
			}
			if(node["channelImageLink"] != null)
			{
				this._ChannelImageLink = node["channelImageLink"].Value<string>();
			}
			if(node["ftpHost"] != null)
			{
				this._FtpHost = node["ftpHost"].Value<string>();
			}
			if(node["ftpLogin"] != null)
			{
				this._FtpLogin = node["ftpLogin"].Value<string>();
			}
			if(node["ftpPassword"] != null)
			{
				this._FtpPassword = node["ftpPassword"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUverseDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("channelTitle", this._ChannelTitle);
			kparams.AddIfNotNull("channelLink", this._ChannelLink);
			kparams.AddIfNotNull("channelDescription", this._ChannelDescription);
			kparams.AddIfNotNull("channelLanguage", this._ChannelLanguage);
			kparams.AddIfNotNull("channelCopyright", this._ChannelCopyright);
			kparams.AddIfNotNull("channelImageTitle", this._ChannelImageTitle);
			kparams.AddIfNotNull("channelImageUrl", this._ChannelImageUrl);
			kparams.AddIfNotNull("channelImageLink", this._ChannelImageLink);
			kparams.AddIfNotNull("ftpHost", this._FtpHost);
			kparams.AddIfNotNull("ftpLogin", this._FtpLogin);
			kparams.AddIfNotNull("ftpPassword", this._FtpPassword);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_URL:
					return "FeedUrl";
				case CHANNEL_TITLE:
					return "ChannelTitle";
				case CHANNEL_LINK:
					return "ChannelLink";
				case CHANNEL_DESCRIPTION:
					return "ChannelDescription";
				case CHANNEL_LANGUAGE:
					return "ChannelLanguage";
				case CHANNEL_COPYRIGHT:
					return "ChannelCopyright";
				case CHANNEL_IMAGE_TITLE:
					return "ChannelImageTitle";
				case CHANNEL_IMAGE_URL:
					return "ChannelImageUrl";
				case CHANNEL_IMAGE_LINK:
					return "ChannelImageLink";
				case FTP_HOST:
					return "FtpHost";
				case FTP_LOGIN:
					return "FtpLogin";
				case FTP_PASSWORD:
					return "FtpPassword";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

