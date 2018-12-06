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
	public class GenericSyndicationFeed : BaseSyndicationFeed
	{
		#region Constants
		public const string FEED_DESCRIPTION = "feedDescription";
		public const string FEED_LANDING_PAGE = "feedLandingPage";
		public const string ENTRY_FILTER = "entryFilter";
		public const string PAGE_SIZE = "pageSize";
		#endregion

		#region Private Fields
		private string _FeedDescription = null;
		private string _FeedLandingPage = null;
		private BaseEntryFilter _EntryFilter;
		private int _PageSize = Int32.MinValue;
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
		public string FeedLandingPage
		{
			get { return _FeedLandingPage; }
			set 
			{ 
				_FeedLandingPage = value;
				OnPropertyChanged("FeedLandingPage");
			}
		}
		public BaseEntryFilter EntryFilter
		{
			get { return _EntryFilter; }
			set 
			{ 
				_EntryFilter = value;
				OnPropertyChanged("EntryFilter");
			}
		}
		public int PageSize
		{
			get { return _PageSize; }
			set 
			{ 
				_PageSize = value;
				OnPropertyChanged("PageSize");
			}
		}
		#endregion

		#region CTor
		public GenericSyndicationFeed()
		{
		}

		public GenericSyndicationFeed(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "feedDescription":
						this._FeedDescription = propertyNode.InnerText;
						continue;
					case "feedLandingPage":
						this._FeedLandingPage = propertyNode.InnerText;
						continue;
					case "entryFilter":
						this._EntryFilter = ObjectFactory.Create<BaseEntryFilter>(propertyNode);
						continue;
					case "pageSize":
						this._PageSize = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public GenericSyndicationFeed(IDictionary<string,object> data) : base(data)
		{
			    this._FeedDescription = data.TryGetValueSafe<string>("feedDescription");
			    this._FeedLandingPage = data.TryGetValueSafe<string>("feedLandingPage");
			    this._EntryFilter = ObjectFactory.Create<BaseEntryFilter>(data.TryGetValueSafe<IDictionary<string,object>>("entryFilter"));
			    this._PageSize = data.TryGetValueSafe<int>("pageSize");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericSyndicationFeed");
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("feedLandingPage", this._FeedLandingPage);
			kparams.AddIfNotNull("entryFilter", this._EntryFilter);
			kparams.AddIfNotNull("pageSize", this._PageSize);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_DESCRIPTION:
					return "FeedDescription";
				case FEED_LANDING_PAGE:
					return "FeedLandingPage";
				case ENTRY_FILTER:
					return "EntryFilter";
				case PAGE_SIZE:
					return "PageSize";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

