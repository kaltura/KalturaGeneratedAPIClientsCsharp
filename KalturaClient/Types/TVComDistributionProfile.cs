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
	public class TVComDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string FEED_URL = "feedUrl";
		public const string FEED_TITLE = "feedTitle";
		public const string FEED_LINK = "feedLink";
		public const string FEED_DESCRIPTION = "feedDescription";
		public const string FEED_LANGUAGE = "feedLanguage";
		public const string FEED_COPYRIGHT = "feedCopyright";
		public const string FEED_IMAGE_TITLE = "feedImageTitle";
		public const string FEED_IMAGE_URL = "feedImageUrl";
		public const string FEED_IMAGE_LINK = "feedImageLink";
		public const string FEED_IMAGE_WIDTH = "feedImageWidth";
		public const string FEED_IMAGE_HEIGHT = "feedImageHeight";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedLink = null;
		private string _FeedDescription = null;
		private string _FeedLanguage = null;
		private string _FeedCopyright = null;
		private string _FeedImageTitle = null;
		private string _FeedImageUrl = null;
		private string _FeedImageLink = null;
		private int _FeedImageWidth = Int32.MinValue;
		private int _FeedImageHeight = Int32.MinValue;
		#endregion

		#region Properties
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public string FeedUrl
		{
			get { return _FeedUrl; }
		}
		public string FeedTitle
		{
			get { return _FeedTitle; }
			set 
			{ 
				_FeedTitle = value;
				OnPropertyChanged("FeedTitle");
			}
		}
		public string FeedLink
		{
			get { return _FeedLink; }
			set 
			{ 
				_FeedLink = value;
				OnPropertyChanged("FeedLink");
			}
		}
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string FeedLanguage
		{
			get { return _FeedLanguage; }
			set 
			{ 
				_FeedLanguage = value;
				OnPropertyChanged("FeedLanguage");
			}
		}
		public string FeedCopyright
		{
			get { return _FeedCopyright; }
			set 
			{ 
				_FeedCopyright = value;
				OnPropertyChanged("FeedCopyright");
			}
		}
		public string FeedImageTitle
		{
			get { return _FeedImageTitle; }
			set 
			{ 
				_FeedImageTitle = value;
				OnPropertyChanged("FeedImageTitle");
			}
		}
		public string FeedImageUrl
		{
			get { return _FeedImageUrl; }
			set 
			{ 
				_FeedImageUrl = value;
				OnPropertyChanged("FeedImageUrl");
			}
		}
		public string FeedImageLink
		{
			get { return _FeedImageLink; }
			set 
			{ 
				_FeedImageLink = value;
				OnPropertyChanged("FeedImageLink");
			}
		}
		public int FeedImageWidth
		{
			get { return _FeedImageWidth; }
			set 
			{ 
				_FeedImageWidth = value;
				OnPropertyChanged("FeedImageWidth");
			}
		}
		public int FeedImageHeight
		{
			get { return _FeedImageHeight; }
			set 
			{ 
				_FeedImageHeight = value;
				OnPropertyChanged("FeedImageHeight");
			}
		}
		#endregion

		#region CTor
		public TVComDistributionProfile()
		{
		}

		public TVComDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "feedUrl":
						this._FeedUrl = propertyNode.InnerText;
						continue;
					case "feedTitle":
						this._FeedTitle = propertyNode.InnerText;
						continue;
					case "feedLink":
						this._FeedLink = propertyNode.InnerText;
						continue;
					case "feedDescription":
						this._FeedDescription = propertyNode.InnerText;
						continue;
					case "feedLanguage":
						this._FeedLanguage = propertyNode.InnerText;
						continue;
					case "feedCopyright":
						this._FeedCopyright = propertyNode.InnerText;
						continue;
					case "feedImageTitle":
						this._FeedImageTitle = propertyNode.InnerText;
						continue;
					case "feedImageUrl":
						this._FeedImageUrl = propertyNode.InnerText;
						continue;
					case "feedImageLink":
						this._FeedImageLink = propertyNode.InnerText;
						continue;
					case "feedImageWidth":
						this._FeedImageWidth = ParseInt(propertyNode.InnerText);
						continue;
					case "feedImageHeight":
						this._FeedImageHeight = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaTVComDistributionProfile");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("feedTitle", this._FeedTitle);
			kparams.AddIfNotNull("feedLink", this._FeedLink);
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("feedLanguage", this._FeedLanguage);
			kparams.AddIfNotNull("feedCopyright", this._FeedCopyright);
			kparams.AddIfNotNull("feedImageTitle", this._FeedImageTitle);
			kparams.AddIfNotNull("feedImageUrl", this._FeedImageUrl);
			kparams.AddIfNotNull("feedImageLink", this._FeedImageLink);
			kparams.AddIfNotNull("feedImageWidth", this._FeedImageWidth);
			kparams.AddIfNotNull("feedImageHeight", this._FeedImageHeight);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case FEED_URL:
					return "FeedUrl";
				case FEED_TITLE:
					return "FeedTitle";
				case FEED_LINK:
					return "FeedLink";
				case FEED_DESCRIPTION:
					return "FeedDescription";
				case FEED_LANGUAGE:
					return "FeedLanguage";
				case FEED_COPYRIGHT:
					return "FeedCopyright";
				case FEED_IMAGE_TITLE:
					return "FeedImageTitle";
				case FEED_IMAGE_URL:
					return "FeedImageUrl";
				case FEED_IMAGE_LINK:
					return "FeedImageLink";
				case FEED_IMAGE_WIDTH:
					return "FeedImageWidth";
				case FEED_IMAGE_HEIGHT:
					return "FeedImageHeight";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

