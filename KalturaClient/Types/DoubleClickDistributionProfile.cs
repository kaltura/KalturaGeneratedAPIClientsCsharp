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
	public class DoubleClickDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string CHANNEL_TITLE = "channelTitle";
		public const string CHANNEL_LINK = "channelLink";
		public const string CHANNEL_DESCRIPTION = "channelDescription";
		public const string FEED_URL = "feedUrl";
		public const string CUE_POINTS_PROVIDER = "cuePointsProvider";
		public const string ITEMS_PER_PAGE = "itemsPerPage";
		public const string IGNORE_SCHEDULING_IN_FEED = "ignoreSchedulingInFeed";
		#endregion

		#region Private Fields
		private string _ChannelTitle = null;
		private string _ChannelLink = null;
		private string _ChannelDescription = null;
		private string _FeedUrl = null;
		private string _CuePointsProvider = null;
		private string _ItemsPerPage = null;
		private bool? _IgnoreSchedulingInFeed = null;
		#endregion

		#region Properties
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
		public string FeedUrl
		{
			get { return _FeedUrl; }
		}
		public string CuePointsProvider
		{
			get { return _CuePointsProvider; }
			set 
			{ 
				_CuePointsProvider = value;
				OnPropertyChanged("CuePointsProvider");
			}
		}
		public string ItemsPerPage
		{
			get { return _ItemsPerPage; }
			set 
			{ 
				_ItemsPerPage = value;
				OnPropertyChanged("ItemsPerPage");
			}
		}
		public bool? IgnoreSchedulingInFeed
		{
			get { return _IgnoreSchedulingInFeed; }
			set 
			{ 
				_IgnoreSchedulingInFeed = value;
				OnPropertyChanged("IgnoreSchedulingInFeed");
			}
		}
		#endregion

		#region CTor
		public DoubleClickDistributionProfile()
		{
		}

		public DoubleClickDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "channelTitle":
						this._ChannelTitle = propertyNode.InnerText;
						continue;
					case "channelLink":
						this._ChannelLink = propertyNode.InnerText;
						continue;
					case "channelDescription":
						this._ChannelDescription = propertyNode.InnerText;
						continue;
					case "feedUrl":
						this._FeedUrl = propertyNode.InnerText;
						continue;
					case "cuePointsProvider":
						this._CuePointsProvider = propertyNode.InnerText;
						continue;
					case "itemsPerPage":
						this._ItemsPerPage = propertyNode.InnerText;
						continue;
					case "ignoreSchedulingInFeed":
						this._IgnoreSchedulingInFeed = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaDoubleClickDistributionProfile");
			kparams.AddIfNotNull("channelTitle", this._ChannelTitle);
			kparams.AddIfNotNull("channelLink", this._ChannelLink);
			kparams.AddIfNotNull("channelDescription", this._ChannelDescription);
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("cuePointsProvider", this._CuePointsProvider);
			kparams.AddIfNotNull("itemsPerPage", this._ItemsPerPage);
			kparams.AddIfNotNull("ignoreSchedulingInFeed", this._IgnoreSchedulingInFeed);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CHANNEL_TITLE:
					return "ChannelTitle";
				case CHANNEL_LINK:
					return "ChannelLink";
				case CHANNEL_DESCRIPTION:
					return "ChannelDescription";
				case FEED_URL:
					return "FeedUrl";
				case CUE_POINTS_PROVIDER:
					return "CuePointsProvider";
				case ITEMS_PER_PAGE:
					return "ItemsPerPage";
				case IGNORE_SCHEDULING_IN_FEED:
					return "IgnoreSchedulingInFeed";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

