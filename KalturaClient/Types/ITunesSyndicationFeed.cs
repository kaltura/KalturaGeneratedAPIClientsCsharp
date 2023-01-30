// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
		public const string ENFORCE_FEED_AUTHOR = "enforceFeedAuthor";
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
		private bool? _EnforceFeedAuthor = null;
		private NullableBoolean _EnforceOrder = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use FeedDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FeedDescription
		{
			get { return _FeedDescription; }
			set 
			{ 
				_FeedDescription = value;
				OnPropertyChanged("FeedDescription");
			}
		}
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use FeedLandingPageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		/// <summary>
		/// Use OwnerNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use OwnerEmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OwnerEmail
		{
			get { return _OwnerEmail; }
			set 
			{ 
				_OwnerEmail = value;
				OnPropertyChanged("OwnerEmail");
			}
		}
		/// <summary>
		/// Use FeedImageUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FeedImageUrl
		{
			get { return _FeedImageUrl; }
			set 
			{ 
				_FeedImageUrl = value;
				OnPropertyChanged("FeedImageUrl");
			}
		}
		/// <summary>
		/// Use CategoryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ITunesSyndicationFeedCategories Category
		{
			get { return _Category; }
			private set 
			{ 
				_Category = value;
				OnPropertyChanged("Category");
			}
		}
		/// <summary>
		/// Use AdultContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ITunesSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
			}
		}
		/// <summary>
		/// Use FeedAuthorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FeedAuthor
		{
			get { return _FeedAuthor; }
			set 
			{ 
				_FeedAuthor = value;
				OnPropertyChanged("FeedAuthor");
			}
		}
		/// <summary>
		/// Use EnforceFeedAuthorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? EnforceFeedAuthor
		{
			get { return _EnforceFeedAuthor; }
			set 
			{ 
				_EnforceFeedAuthor = value;
				OnPropertyChanged("EnforceFeedAuthor");
			}
		}
		/// <summary>
		/// Use EnforceOrderAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public ITunesSyndicationFeed(JToken node) : base(node)
		{
			if(node["feedDescription"] != null)
			{
				this._FeedDescription = node["feedDescription"].Value<string>();
			}
			if(node["language"] != null)
			{
				this._Language = node["language"].Value<string>();
			}
			if(node["feedLandingPage"] != null)
			{
				this._FeedLandingPage = node["feedLandingPage"].Value<string>();
			}
			if(node["ownerName"] != null)
			{
				this._OwnerName = node["ownerName"].Value<string>();
			}
			if(node["ownerEmail"] != null)
			{
				this._OwnerEmail = node["ownerEmail"].Value<string>();
			}
			if(node["feedImageUrl"] != null)
			{
				this._FeedImageUrl = node["feedImageUrl"].Value<string>();
			}
			if(node["category"] != null)
			{
				this._Category = (ITunesSyndicationFeedCategories)StringEnum.Parse(typeof(ITunesSyndicationFeedCategories), node["category"].Value<string>());
			}
			if(node["adultContent"] != null)
			{
				this._AdultContent = (ITunesSyndicationFeedAdultValues)StringEnum.Parse(typeof(ITunesSyndicationFeedAdultValues), node["adultContent"].Value<string>());
			}
			if(node["feedAuthor"] != null)
			{
				this._FeedAuthor = node["feedAuthor"].Value<string>();
			}
			if(node["enforceFeedAuthor"] != null)
			{
				this._EnforceFeedAuthor = ParseBool(node["enforceFeedAuthor"].Value<string>());
			}
			if(node["enforceOrder"] != null)
			{
				this._EnforceOrder = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["enforceOrder"].Value<string>());
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
			kparams.AddIfNotNull("enforceFeedAuthor", this._EnforceFeedAuthor);
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
				case ENFORCE_FEED_AUTHOR:
					return "EnforceFeedAuthor";
				case ENFORCE_ORDER:
					return "EnforceOrder";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

