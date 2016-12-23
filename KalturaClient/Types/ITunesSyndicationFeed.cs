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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ITunesSyndicationFeed : BaseSyndicationFeed
	{
		#region Constants
		public const string FEED_DESCRIPTION = "feedDescription";
		public const string LANGUAGE = "language";
		public const string FEED_LANDING_PAGE = "feedLandingPage";
		public const string OWNER_NAME = "ownerName";
		public const string OWNER_EMAIL = "ownerEmail";
		public const string FEED_IMAGE_URL = "feedImageUrl";
		public const string CATEGORY = "category";
		public const string ADULT_CONTENT = "adultContent";
		public const string FEED_AUTHOR = "feedAuthor";
		public const string ENFORCE_ORDER = "enforceOrder";
		#endregion

		#region Private Fields
		private string _FeedDescription = null;
		private string _Language = null;
		private string _FeedLandingPage = null;
		private string _OwnerName = null;
		private string _OwnerEmail = null;
		private string _FeedImageUrl = null;
		private ITunesSyndicationFeedCategories _Category = null;
		private ITunesSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedAuthor = null;
		private NullableBoolean _EnforceOrder = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
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
		public string OwnerEmail
		{
			get { return _OwnerEmail; }
			set 
			{ 
				_OwnerEmail = value;
				OnPropertyChanged("OwnerEmail");
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
		public ITunesSyndicationFeedCategories Category
		{
			get { return _Category; }
		}
		public ITunesSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		public string FeedAuthor
		{
			get { return _FeedAuthor; }
			set 
			{ 
				_FeedAuthor = value;
				OnPropertyChanged("FeedAuthor");
			}
		}
		public NullableBoolean EnforceOrder
		{
			get { return _EnforceOrder; }
			set 
			{ 
				_EnforceOrder = value;
				OnPropertyChanged("EnforceOrder");
			}
		}
		#endregion

		#region CTor
		public ITunesSyndicationFeed()
		{
		}

		public ITunesSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "feedDescription":
						this._FeedDescription = propertyNode.InnerText;
						continue;
					case "language":
						this._Language = propertyNode.InnerText;
						continue;
					case "feedLandingPage":
						this._FeedLandingPage = propertyNode.InnerText;
						continue;
					case "ownerName":
						this._OwnerName = propertyNode.InnerText;
						continue;
					case "ownerEmail":
						this._OwnerEmail = propertyNode.InnerText;
						continue;
					case "feedImageUrl":
						this._FeedImageUrl = propertyNode.InnerText;
						continue;
					case "category":
						this._Category = (ITunesSyndicationFeedCategories)StringEnum.Parse(typeof(ITunesSyndicationFeedCategories), propertyNode.InnerText);
						continue;
					case "adultContent":
						this._AdultContent = (ITunesSyndicationFeedAdultValues)StringEnum.Parse(typeof(ITunesSyndicationFeedAdultValues), propertyNode.InnerText);
						continue;
					case "feedAuthor":
						this._FeedAuthor = propertyNode.InnerText;
						continue;
					case "enforceOrder":
						this._EnforceOrder = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaITunesSyndicationFeed");
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("feedLandingPage", this._FeedLandingPage);
			kparams.AddIfNotNull("ownerName", this._OwnerName);
			kparams.AddIfNotNull("ownerEmail", this._OwnerEmail);
			kparams.AddIfNotNull("feedImageUrl", this._FeedImageUrl);
			kparams.AddIfNotNull("category", this._Category);
			kparams.AddIfNotNull("adultContent", this._AdultContent);
			kparams.AddIfNotNull("feedAuthor", this._FeedAuthor);
			kparams.AddIfNotNull("enforceOrder", this._EnforceOrder);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_DESCRIPTION:
					return "FeedDescription";
				case LANGUAGE:
					return "Language";
				case FEED_LANDING_PAGE:
					return "FeedLandingPage";
				case OWNER_NAME:
					return "OwnerName";
				case OWNER_EMAIL:
					return "OwnerEmail";
				case FEED_IMAGE_URL:
					return "FeedImageUrl";
				case CATEGORY:
					return "Category";
				case ADULT_CONTENT:
					return "AdultContent";
				case FEED_AUTHOR:
					return "FeedAuthor";
				case ENFORCE_ORDER:
					return "EnforceOrder";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

