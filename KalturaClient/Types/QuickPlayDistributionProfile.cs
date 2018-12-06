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
		public string SftpHost
		{
			get { return _SftpHost; }
			set 
			{ 
				_SftpHost = value;
				OnPropertyChanged("SftpHost");
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
		public string SftpPass
		{
			get { return _SftpPass; }
			set 
			{ 
				_SftpPass = value;
				OnPropertyChanged("SftpPass");
			}
		}
		public string SftpBasePath
		{
			get { return _SftpBasePath; }
			set 
			{ 
				_SftpBasePath = value;
				OnPropertyChanged("SftpBasePath");
			}
		}
		public string ChannelTitle
		{
			get { return _ChannelTitle; }
			set 
			{ 
				_ChannelTitle = value;
				OnPropertyChanged("ChannelTitle");
			}
		}
		public string ChannelLink
		{
			get { return _ChannelLink; }
			set 
			{ 
				_ChannelLink = value;
				OnPropertyChanged("ChannelLink");
			}
		}
		public string ChannelDescription
		{
			get { return _ChannelDescription; }
			set 
			{ 
				_ChannelDescription = value;
				OnPropertyChanged("ChannelDescription");
			}
		}
		public string ChannelManagingEditor
		{
			get { return _ChannelManagingEditor; }
			set 
			{ 
				_ChannelManagingEditor = value;
				OnPropertyChanged("ChannelManagingEditor");
			}
		}
		public string ChannelLanguage
		{
			get { return _ChannelLanguage; }
			set 
			{ 
				_ChannelLanguage = value;
				OnPropertyChanged("ChannelLanguage");
			}
		}
		public string ChannelImageTitle
		{
			get { return _ChannelImageTitle; }
			set 
			{ 
				_ChannelImageTitle = value;
				OnPropertyChanged("ChannelImageTitle");
			}
		}
		public string ChannelImageWidth
		{
			get { return _ChannelImageWidth; }
			set 
			{ 
				_ChannelImageWidth = value;
				OnPropertyChanged("ChannelImageWidth");
			}
		}
		public string ChannelImageHeight
		{
			get { return _ChannelImageHeight; }
			set 
			{ 
				_ChannelImageHeight = value;
				OnPropertyChanged("ChannelImageHeight");
			}
		}
		public string ChannelImageLink
		{
			get { return _ChannelImageLink; }
			set 
			{ 
				_ChannelImageLink = value;
				OnPropertyChanged("ChannelImageLink");
			}
		}
		public string ChannelImageUrl
		{
			get { return _ChannelImageUrl; }
			set 
			{ 
				_ChannelImageUrl = value;
				OnPropertyChanged("ChannelImageUrl");
			}
		}
		public string ChannelCopyright
		{
			get { return _ChannelCopyright; }
			set 
			{ 
				_ChannelCopyright = value;
				OnPropertyChanged("ChannelCopyright");
			}
		}
		public string ChannelGenerator
		{
			get { return _ChannelGenerator; }
			set 
			{ 
				_ChannelGenerator = value;
				OnPropertyChanged("ChannelGenerator");
			}
		}
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

		public QuickPlayDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "sftpHost":
						this._SftpHost = propertyNode.InnerText;
						continue;
					case "sftpLogin":
						this._SftpLogin = propertyNode.InnerText;
						continue;
					case "sftpPass":
						this._SftpPass = propertyNode.InnerText;
						continue;
					case "sftpBasePath":
						this._SftpBasePath = propertyNode.InnerText;
						continue;
					case "channelTitle":
						this._ChannelTitle = propertyNode.InnerText;
						continue;
					case "channelLink":
						this._ChannelLink = propertyNode.InnerText;
						continue;
					case "channelDescription":
						this._ChannelDescription = propertyNode.InnerText;
						continue;
					case "channelManagingEditor":
						this._ChannelManagingEditor = propertyNode.InnerText;
						continue;
					case "channelLanguage":
						this._ChannelLanguage = propertyNode.InnerText;
						continue;
					case "channelImageTitle":
						this._ChannelImageTitle = propertyNode.InnerText;
						continue;
					case "channelImageWidth":
						this._ChannelImageWidth = propertyNode.InnerText;
						continue;
					case "channelImageHeight":
						this._ChannelImageHeight = propertyNode.InnerText;
						continue;
					case "channelImageLink":
						this._ChannelImageLink = propertyNode.InnerText;
						continue;
					case "channelImageUrl":
						this._ChannelImageUrl = propertyNode.InnerText;
						continue;
					case "channelCopyright":
						this._ChannelCopyright = propertyNode.InnerText;
						continue;
					case "channelGenerator":
						this._ChannelGenerator = propertyNode.InnerText;
						continue;
					case "channelRating":
						this._ChannelRating = propertyNode.InnerText;
						continue;
				}
			}
		}

		public QuickPlayDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._SftpHost = data.TryGetValueSafe<string>("sftpHost");
			    this._SftpLogin = data.TryGetValueSafe<string>("sftpLogin");
			    this._SftpPass = data.TryGetValueSafe<string>("sftpPass");
			    this._SftpBasePath = data.TryGetValueSafe<string>("sftpBasePath");
			    this._ChannelTitle = data.TryGetValueSafe<string>("channelTitle");
			    this._ChannelLink = data.TryGetValueSafe<string>("channelLink");
			    this._ChannelDescription = data.TryGetValueSafe<string>("channelDescription");
			    this._ChannelManagingEditor = data.TryGetValueSafe<string>("channelManagingEditor");
			    this._ChannelLanguage = data.TryGetValueSafe<string>("channelLanguage");
			    this._ChannelImageTitle = data.TryGetValueSafe<string>("channelImageTitle");
			    this._ChannelImageWidth = data.TryGetValueSafe<string>("channelImageWidth");
			    this._ChannelImageHeight = data.TryGetValueSafe<string>("channelImageHeight");
			    this._ChannelImageLink = data.TryGetValueSafe<string>("channelImageLink");
			    this._ChannelImageUrl = data.TryGetValueSafe<string>("channelImageUrl");
			    this._ChannelCopyright = data.TryGetValueSafe<string>("channelCopyright");
			    this._ChannelGenerator = data.TryGetValueSafe<string>("channelGenerator");
			    this._ChannelRating = data.TryGetValueSafe<string>("channelRating");
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

