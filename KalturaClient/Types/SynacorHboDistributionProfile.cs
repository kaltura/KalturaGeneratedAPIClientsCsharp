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
	public class SynacorHboDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_URL = "feedUrl";
		public const string FEED_TITLE = "feedTitle";
		public const string FEED_SUBTITLE = "feedSubtitle";
		public const string FEED_LINK = "feedLink";
		public const string FEED_AUTHOR_NAME = "feedAuthorName";
		#endregion

		#region Private Fields
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedSubtitle = null;
		private string _FeedLink = null;
		private string _FeedAuthorName = null;
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
		public string FeedTitle
		{
			get { return _FeedTitle; }
			set 
			{ 
				_FeedTitle = value;
				OnPropertyChanged("FeedTitle");
			}
		}
		[JsonProperty]
		public string FeedSubtitle
		{
			get { return _FeedSubtitle; }
			set 
			{ 
				_FeedSubtitle = value;
				OnPropertyChanged("FeedSubtitle");
			}
		}
		[JsonProperty]
		public string FeedLink
		{
			get { return _FeedLink; }
			set 
			{ 
				_FeedLink = value;
				OnPropertyChanged("FeedLink");
			}
		}
		[JsonProperty]
		public string FeedAuthorName
		{
			get { return _FeedAuthorName; }
			set 
			{ 
				_FeedAuthorName = value;
				OnPropertyChanged("FeedAuthorName");
			}
		}
		#endregion

		#region CTor
		public SynacorHboDistributionProfile()
		{
		}

		public SynacorHboDistributionProfile(JToken node) : base(node)
		{
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["feedTitle"] != null)
			{
				this._FeedTitle = node["feedTitle"].Value<string>();
			}
			if(node["feedSubtitle"] != null)
			{
				this._FeedSubtitle = node["feedSubtitle"].Value<string>();
			}
			if(node["feedLink"] != null)
			{
				this._FeedLink = node["feedLink"].Value<string>();
			}
			if(node["feedAuthorName"] != null)
			{
				this._FeedAuthorName = node["feedAuthorName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSynacorHboDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("feedTitle", this._FeedTitle);
			kparams.AddIfNotNull("feedSubtitle", this._FeedSubtitle);
			kparams.AddIfNotNull("feedLink", this._FeedLink);
			kparams.AddIfNotNull("feedAuthorName", this._FeedAuthorName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_URL:
					return "FeedUrl";
				case FEED_TITLE:
					return "FeedTitle";
				case FEED_SUBTITLE:
					return "FeedSubtitle";
				case FEED_LINK:
					return "FeedLink";
				case FEED_AUTHOR_NAME:
					return "FeedAuthorName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

