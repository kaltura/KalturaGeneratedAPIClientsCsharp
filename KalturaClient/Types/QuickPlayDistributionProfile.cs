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
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class QuickPlayDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string SFTP_HOST = "sftpHost";
		public const string SFTP_LOGIN = "sftpLogin";
		public const string SFTP_PASS = "sftpPass";
		public const string SFTP_BASE_PATH = "sftpBasePath";
		public const string CHANNEL_TITLE = "channelTitle";
		public const string CHANNEL_LINK = "channelLink";
		public const string CHANNEL_DESCRIPTION = "channelDescription";
		public const string CHANNEL_MANAGING_EDITOR = "channelManagingEditor";
		public const string CHANNEL_LANGUAGE = "channelLanguage";
		public const string CHANNEL_IMAGE_TITLE = "channelImageTitle";
		public const string CHANNEL_IMAGE_WIDTH = "channelImageWidth";
		public const string CHANNEL_IMAGE_HEIGHT = "channelImageHeight";
		public const string CHANNEL_IMAGE_LINK = "channelImageLink";
		public const string CHANNEL_IMAGE_URL = "channelImageUrl";
		public const string CHANNEL_COPYRIGHT = "channelCopyright";
		public const string CHANNEL_GENERATOR = "channelGenerator";
		public const string CHANNEL_RATING = "channelRating";
		#endregion

		#region Private Fields
		private string _SftpHost = null;
		private string _SftpLogin = null;
		private string _SftpPass = null;
		private string _SftpBasePath = null;
		private string _ChannelTitle = null;
		private string _ChannelLink = null;
		private string _ChannelDescription = null;
		private string _ChannelManagingEditor = null;
		private string _ChannelLanguage = null;
		private string _ChannelImageTitle = null;
		private string _ChannelImageWidth = null;
		private string _ChannelImageHeight = null;
		private string _ChannelImageLink = null;
		private string _ChannelImageUrl = null;
		private string _ChannelCopyright = null;
		private string _ChannelGenerator = null;
		private string _ChannelRating = null;
		#endregion

		#region Properties
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
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		[JsonProperty]
		public string SftpBasePath
		{
			get { return _SftpBasePath; }
			set 
			{ 
				_SftpBasePath = value;
				OnPropertyChanged("SftpBasePath");
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
		public string ChannelManagingEditor
		{
			get { return _ChannelManagingEditor; }
			set 
			{ 
				_ChannelManagingEditor = value;
				OnPropertyChanged("ChannelManagingEditor");
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
		public string ChannelImageWidth
		{
			get { return _ChannelImageWidth; }
			set 
			{ 
				_ChannelImageWidth = value;
				OnPropertyChanged("ChannelImageWidth");
			}
		}
		[JsonProperty]
		public string ChannelImageHeight
		{
			get { return _ChannelImageHeight; }
			set 
			{ 
				_ChannelImageHeight = value;
				OnPropertyChanged("ChannelImageHeight");
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
		public string ChannelGenerator
		{
			get { return _ChannelGenerator; }
			set 
			{ 
				_ChannelGenerator = value;
				OnPropertyChanged("ChannelGenerator");
			}
		}
		[JsonProperty]
		public string ChannelRating
		{
			get { return _ChannelRating; }
			set 
			{ 
				_ChannelRating = value;
				OnPropertyChanged("ChannelRating");
			}
		}
		#endregion

		#region CTor
		public QuickPlayDistributionProfile()
		{
		}

		public QuickPlayDistributionProfile(JToken node) : base(node)
		{
			if(node["sftpHost"] != null)
			{
				this._SftpHost = node["sftpHost"].Value<string>();
			}
			if(node["sftpLogin"] != null)
			{
				this._SftpLogin = node["sftpLogin"].Value<string>();
			}
			if(node["sftpPass"] != null)
			{
				this._SftpPass = node["sftpPass"].Value<string>();
			}
			if(node["sftpBasePath"] != null)
			{
				this._SftpBasePath = node["sftpBasePath"].Value<string>();
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
			if(node["channelManagingEditor"] != null)
			{
				this._ChannelManagingEditor = node["channelManagingEditor"].Value<string>();
			}
			if(node["channelLanguage"] != null)
			{
				this._ChannelLanguage = node["channelLanguage"].Value<string>();
			}
			if(node["channelImageTitle"] != null)
			{
				this._ChannelImageTitle = node["channelImageTitle"].Value<string>();
			}
			if(node["channelImageWidth"] != null)
			{
				this._ChannelImageWidth = node["channelImageWidth"].Value<string>();
			}
			if(node["channelImageHeight"] != null)
			{
				this._ChannelImageHeight = node["channelImageHeight"].Value<string>();
			}
			if(node["channelImageLink"] != null)
			{
				this._ChannelImageLink = node["channelImageLink"].Value<string>();
			}
			if(node["channelImageUrl"] != null)
			{
				this._ChannelImageUrl = node["channelImageUrl"].Value<string>();
			}
			if(node["channelCopyright"] != null)
			{
				this._ChannelCopyright = node["channelCopyright"].Value<string>();
			}
			if(node["channelGenerator"] != null)
			{
				this._ChannelGenerator = node["channelGenerator"].Value<string>();
			}
			if(node["channelRating"] != null)
			{
				this._ChannelRating = node["channelRating"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaQuickPlayDistributionProfile");
			kparams.AddIfNotNull("sftpHost", this._SftpHost);
			kparams.AddIfNotNull("sftpLogin", this._SftpLogin);
			kparams.AddIfNotNull("sftpPass", this._SftpPass);
			kparams.AddIfNotNull("sftpBasePath", this._SftpBasePath);
			kparams.AddIfNotNull("channelTitle", this._ChannelTitle);
			kparams.AddIfNotNull("channelLink", this._ChannelLink);
			kparams.AddIfNotNull("channelDescription", this._ChannelDescription);
			kparams.AddIfNotNull("channelManagingEditor", this._ChannelManagingEditor);
			kparams.AddIfNotNull("channelLanguage", this._ChannelLanguage);
			kparams.AddIfNotNull("channelImageTitle", this._ChannelImageTitle);
			kparams.AddIfNotNull("channelImageWidth", this._ChannelImageWidth);
			kparams.AddIfNotNull("channelImageHeight", this._ChannelImageHeight);
			kparams.AddIfNotNull("channelImageLink", this._ChannelImageLink);
			kparams.AddIfNotNull("channelImageUrl", this._ChannelImageUrl);
			kparams.AddIfNotNull("channelCopyright", this._ChannelCopyright);
			kparams.AddIfNotNull("channelGenerator", this._ChannelGenerator);
			kparams.AddIfNotNull("channelRating", this._ChannelRating);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SFTP_HOST:
					return "SftpHost";
				case SFTP_LOGIN:
					return "SftpLogin";
				case SFTP_PASS:
					return "SftpPass";
				case SFTP_BASE_PATH:
					return "SftpBasePath";
				case CHANNEL_TITLE:
					return "ChannelTitle";
				case CHANNEL_LINK:
					return "ChannelLink";
				case CHANNEL_DESCRIPTION:
					return "ChannelDescription";
				case CHANNEL_MANAGING_EDITOR:
					return "ChannelManagingEditor";
				case CHANNEL_LANGUAGE:
					return "ChannelLanguage";
				case CHANNEL_IMAGE_TITLE:
					return "ChannelImageTitle";
				case CHANNEL_IMAGE_WIDTH:
					return "ChannelImageWidth";
				case CHANNEL_IMAGE_HEIGHT:
					return "ChannelImageHeight";
				case CHANNEL_IMAGE_LINK:
					return "ChannelImageLink";
				case CHANNEL_IMAGE_URL:
					return "ChannelImageUrl";
				case CHANNEL_COPYRIGHT:
					return "ChannelCopyright";
				case CHANNEL_GENERATOR:
					return "ChannelGenerator";
				case CHANNEL_RATING:
					return "ChannelRating";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

