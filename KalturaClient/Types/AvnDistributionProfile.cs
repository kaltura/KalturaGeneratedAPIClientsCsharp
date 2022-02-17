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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class AvnDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_URL = "feedUrl";
		public const string FEED_TITLE = "feedTitle";
		#endregion

		#region Private Fields
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FeedUrlAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use FeedTitleAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public AvnDistributionProfile()
		{
		}

		public AvnDistributionProfile(JToken node) : base(node)
		{
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["feedTitle"] != null)
			{
				this._FeedTitle = node["feedTitle"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAvnDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("feedTitle", this._FeedTitle);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

