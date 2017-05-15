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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class NdnDistributionProfile : ConfigurableDistributionProfile
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
		public const string ITEM_MEDIA_RATING = "itemMediaRating";
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
		private string _ItemMediaRating = null;
		#endregion

		#region Properties
		public string FeedUrl
		{
			get { return _FeedUrl; }
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
		public string ChannelLanguage
		{
			get { return _ChannelLanguage; }
			set 
			{ 
				_ChannelLanguage = value;
				OnPropertyChanged("ChannelLanguage");
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
		public string ChannelImageTitle
		{
			get { return _ChannelImageTitle; }
			set 
			{ 
				_ChannelImageTitle = value;
				OnPropertyChanged("ChannelImageTitle");
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
		public string ChannelImageLink
		{
			get { return _ChannelImageLink; }
			set 
			{ 
				_ChannelImageLink = value;
				OnPropertyChanged("ChannelImageLink");
			}
		}
		public string ItemMediaRating
		{
			get { return _ItemMediaRating; }
			set 
			{ 
				_ItemMediaRating = value;
				OnPropertyChanged("ItemMediaRating");
			}
		}
		#endregion

		#region CTor
		public NdnDistributionProfile()
		{
		}

		public NdnDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "feedUrl":
						this._FeedUrl = propertyNode.InnerText;
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
					case "channelLanguage":
						this._ChannelLanguage = propertyNode.InnerText;
						continue;
					case "channelCopyright":
						this._ChannelCopyright = propertyNode.InnerText;
						continue;
					case "channelImageTitle":
						this._ChannelImageTitle = propertyNode.InnerText;
						continue;
					case "channelImageUrl":
						this._ChannelImageUrl = propertyNode.InnerText;
						continue;
					case "channelImageLink":
						this._ChannelImageLink = propertyNode.InnerText;
						continue;
					case "itemMediaRating":
						this._ItemMediaRating = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaNdnDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("channelTitle", this._ChannelTitle);
			kparams.AddIfNotNull("channelLink", this._ChannelLink);
			kparams.AddIfNotNull("channelDescription", this._ChannelDescription);
			kparams.AddIfNotNull("channelLanguage", this._ChannelLanguage);
			kparams.AddIfNotNull("channelCopyright", this._ChannelCopyright);
			kparams.AddIfNotNull("channelImageTitle", this._ChannelImageTitle);
			kparams.AddIfNotNull("channelImageUrl", this._ChannelImageUrl);
			kparams.AddIfNotNull("channelImageLink", this._ChannelImageLink);
			kparams.AddIfNotNull("itemMediaRating", this._ItemMediaRating);
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
				case ITEM_MEDIA_RATING:
					return "ItemMediaRating";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

