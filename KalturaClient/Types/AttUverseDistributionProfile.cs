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
	public class AttUverseDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_URL = "feedUrl";
		public const string FTP_HOST = "ftpHost";
		public const string FTP_USERNAME = "ftpUsername";
		public const string FTP_PASSWORD = "ftpPassword";
		public const string FTP_PATH = "ftpPath";
		public const string CHANNEL_TITLE = "channelTitle";
		public const string FLAVOR_ASSET_FILENAME_XSLT = "flavorAssetFilenameXslt";
		public const string THUMBNAIL_ASSET_FILENAME_XSLT = "thumbnailAssetFilenameXslt";
		public const string ASSET_FILENAME_XSLT = "assetFilenameXslt";
		#endregion

		#region Private Fields
		private string _FeedUrl = null;
		private string _FtpHost = null;
		private string _FtpUsername = null;
		private string _FtpPassword = null;
		private string _FtpPath = null;
		private string _ChannelTitle = null;
		private string _FlavorAssetFilenameXslt = null;
		private string _ThumbnailAssetFilenameXslt = null;
		private string _AssetFilenameXslt = null;
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
		public string FtpUsername
		{
			get { return _FtpUsername; }
			set 
			{ 
				_FtpUsername = value;
				OnPropertyChanged("FtpUsername");
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
		[JsonProperty]
		public string FtpPath
		{
			get { return _FtpPath; }
			set 
			{ 
				_FtpPath = value;
				OnPropertyChanged("FtpPath");
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
		public string FlavorAssetFilenameXslt
		{
			get { return _FlavorAssetFilenameXslt; }
			set 
			{ 
				_FlavorAssetFilenameXslt = value;
				OnPropertyChanged("FlavorAssetFilenameXslt");
			}
		}
		[JsonProperty]
		public string ThumbnailAssetFilenameXslt
		{
			get { return _ThumbnailAssetFilenameXslt; }
			set 
			{ 
				_ThumbnailAssetFilenameXslt = value;
				OnPropertyChanged("ThumbnailAssetFilenameXslt");
			}
		}
		[JsonProperty]
		public string AssetFilenameXslt
		{
			get { return _AssetFilenameXslt; }
			set 
			{ 
				_AssetFilenameXslt = value;
				OnPropertyChanged("AssetFilenameXslt");
			}
		}
		#endregion

		#region CTor
		public AttUverseDistributionProfile()
		{
		}

		public AttUverseDistributionProfile(JToken node) : base(node)
		{
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["ftpHost"] != null)
			{
				this._FtpHost = node["ftpHost"].Value<string>();
			}
			if(node["ftpUsername"] != null)
			{
				this._FtpUsername = node["ftpUsername"].Value<string>();
			}
			if(node["ftpPassword"] != null)
			{
				this._FtpPassword = node["ftpPassword"].Value<string>();
			}
			if(node["ftpPath"] != null)
			{
				this._FtpPath = node["ftpPath"].Value<string>();
			}
			if(node["channelTitle"] != null)
			{
				this._ChannelTitle = node["channelTitle"].Value<string>();
			}
			if(node["flavorAssetFilenameXslt"] != null)
			{
				this._FlavorAssetFilenameXslt = node["flavorAssetFilenameXslt"].Value<string>();
			}
			if(node["thumbnailAssetFilenameXslt"] != null)
			{
				this._ThumbnailAssetFilenameXslt = node["thumbnailAssetFilenameXslt"].Value<string>();
			}
			if(node["assetFilenameXslt"] != null)
			{
				this._AssetFilenameXslt = node["assetFilenameXslt"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAttUverseDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("ftpHost", this._FtpHost);
			kparams.AddIfNotNull("ftpUsername", this._FtpUsername);
			kparams.AddIfNotNull("ftpPassword", this._FtpPassword);
			kparams.AddIfNotNull("ftpPath", this._FtpPath);
			kparams.AddIfNotNull("channelTitle", this._ChannelTitle);
			kparams.AddIfNotNull("flavorAssetFilenameXslt", this._FlavorAssetFilenameXslt);
			kparams.AddIfNotNull("thumbnailAssetFilenameXslt", this._ThumbnailAssetFilenameXslt);
			kparams.AddIfNotNull("assetFilenameXslt", this._AssetFilenameXslt);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_URL:
					return "FeedUrl";
				case FTP_HOST:
					return "FtpHost";
				case FTP_USERNAME:
					return "FtpUsername";
				case FTP_PASSWORD:
					return "FtpPassword";
				case FTP_PATH:
					return "FtpPath";
				case CHANNEL_TITLE:
					return "ChannelTitle";
				case FLAVOR_ASSET_FILENAME_XSLT:
					return "FlavorAssetFilenameXslt";
				case THUMBNAIL_ASSET_FILENAME_XSLT:
					return "ThumbnailAssetFilenameXslt";
				case ASSET_FILENAME_XSLT:
					return "AssetFilenameXslt";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

