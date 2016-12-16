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
	public class YahooSyndicationFeed : BaseSyndicationFeed
	{
		#region Constants
		public const string CATEGORY = "category";
		public const string ADULT_CONTENT = "adultContent";
		public const string FEED_DESCRIPTION = "feedDescription";
		public const string FEED_LANDING_PAGE = "feedLandingPage";
		#endregion

		#region Private Fields
		private YahooSyndicationFeedCategories _Category = null;
		private YahooSyndicationFeedAdultValues _AdultContent = null;
		private string _FeedDescription = null;
		private string _FeedLandingPage = null;
		#endregion

		#region Properties
		public YahooSyndicationFeedCategories Category
		{
			get { return _Category; }
		}
		public YahooSyndicationFeedAdultValues AdultContent
		{
			get { return _AdultContent; }
			set 
			{ 
				_AdultContent = value;
				OnPropertyChanged("AdultContent");
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
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		#endregion

		#region CTor
		public YahooSyndicationFeed()
		{
		}

		public YahooSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "category":
						this._Category = (YahooSyndicationFeedCategories)StringEnum.Parse(typeof(YahooSyndicationFeedCategories), txt);
						continue;
					case "adultContent":
						this._AdultContent = (YahooSyndicationFeedAdultValues)StringEnum.Parse(typeof(YahooSyndicationFeedAdultValues), txt);
						continue;
					case "feedDescription":
						this._FeedDescription = txt;
						continue;
					case "feedLandingPage":
						this._FeedLandingPage = txt;
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
				kparams.AddReplace("objectType", "KalturaYahooSyndicationFeed");
			kparams.AddIfNotNull("category", this._Category);
			kparams.AddIfNotNull("adultContent", this._AdultContent);
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("feedLandingPage", this._FeedLandingPage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY:
					return "Category";
				case ADULT_CONTENT:
					return "AdultContent";
				case FEED_DESCRIPTION:
					return "FeedDescription";
				case FEED_LANDING_PAGE:
					return "FeedLandingPage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

