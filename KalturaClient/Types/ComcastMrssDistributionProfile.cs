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
	public class ComcastMrssDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string FEED_URL = "feedUrl";
		public const string FEED_TITLE = "feedTitle";
		public const string FEED_LINK = "feedLink";
		public const string FEED_DESCRIPTION = "feedDescription";
		public const string FEED_LAST_BUILD_DATE = "feedLastBuildDate";
		public const string ITEM_LINK = "itemLink";
		public const string CPLATFORM_TV_SERIES = "cPlatformTvSeries";
		public const string CPLATFORM_TV_SERIES_FIELD = "cPlatformTvSeriesField";
		public const string SHOULD_INCLUDE_CUE_POINTS = "shouldIncludeCuePoints";
		public const string SHOULD_INCLUDE_CAPTIONS = "shouldIncludeCaptions";
		public const string SHOULD_ADD_THUMB_EXTENSION = "shouldAddThumbExtension";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _FeedUrl = null;
		private string _FeedTitle = null;
		private string _FeedLink = null;
		private string _FeedDescription = null;
		private string _FeedLastBuildDate = null;
		private string _ItemLink = null;
		private IList<KeyValue> _CPlatformTvSeries;
		private string _CPlatformTvSeriesField = null;
		private bool? _ShouldIncludeCuePoints = null;
		private bool? _ShouldIncludeCaptions = null;
		private bool? _ShouldAddThumbExtension = null;
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
		public string FeedLastBuildDate
		{
			get { return _FeedLastBuildDate; }
			set 
			{ 
				_FeedLastBuildDate = value;
				OnPropertyChanged("FeedLastBuildDate");
			}
		}
		public string ItemLink
		{
			get { return _ItemLink; }
			set 
			{ 
				_ItemLink = value;
				OnPropertyChanged("ItemLink");
			}
		}
		public IList<KeyValue> CPlatformTvSeries
		{
			get { return _CPlatformTvSeries; }
			set 
			{ 
				_CPlatformTvSeries = value;
				OnPropertyChanged("CPlatformTvSeries");
			}
		}
		public string CPlatformTvSeriesField
		{
			get { return _CPlatformTvSeriesField; }
			set 
			{ 
				_CPlatformTvSeriesField = value;
				OnPropertyChanged("CPlatformTvSeriesField");
			}
		}
		public bool? ShouldIncludeCuePoints
		{
			get { return _ShouldIncludeCuePoints; }
			set 
			{ 
				_ShouldIncludeCuePoints = value;
				OnPropertyChanged("ShouldIncludeCuePoints");
			}
		}
		public bool? ShouldIncludeCaptions
		{
			get { return _ShouldIncludeCaptions; }
			set 
			{ 
				_ShouldIncludeCaptions = value;
				OnPropertyChanged("ShouldIncludeCaptions");
			}
		}
		public bool? ShouldAddThumbExtension
		{
			get { return _ShouldAddThumbExtension; }
			set 
			{ 
				_ShouldAddThumbExtension = value;
				OnPropertyChanged("ShouldAddThumbExtension");
			}
		}
		#endregion

		#region CTor
		public ComcastMrssDistributionProfile()
		{
		}

		public ComcastMrssDistributionProfile(XmlElement node) : base(node)
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
					case "feedLastBuildDate":
						this._FeedLastBuildDate = propertyNode.InnerText;
						continue;
					case "itemLink":
						this._ItemLink = propertyNode.InnerText;
						continue;
					case "cPlatformTvSeries":
						this._CPlatformTvSeries = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CPlatformTvSeries.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "cPlatformTvSeriesField":
						this._CPlatformTvSeriesField = propertyNode.InnerText;
						continue;
					case "shouldIncludeCuePoints":
						this._ShouldIncludeCuePoints = ParseBool(propertyNode.InnerText);
						continue;
					case "shouldIncludeCaptions":
						this._ShouldIncludeCaptions = ParseBool(propertyNode.InnerText);
						continue;
					case "shouldAddThumbExtension":
						this._ShouldAddThumbExtension = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaComcastMrssDistributionProfile");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("feedTitle", this._FeedTitle);
			kparams.AddIfNotNull("feedLink", this._FeedLink);
			kparams.AddIfNotNull("feedDescription", this._FeedDescription);
			kparams.AddIfNotNull("feedLastBuildDate", this._FeedLastBuildDate);
			kparams.AddIfNotNull("itemLink", this._ItemLink);
			kparams.AddIfNotNull("cPlatformTvSeries", this._CPlatformTvSeries);
			kparams.AddIfNotNull("cPlatformTvSeriesField", this._CPlatformTvSeriesField);
			kparams.AddIfNotNull("shouldIncludeCuePoints", this._ShouldIncludeCuePoints);
			kparams.AddIfNotNull("shouldIncludeCaptions", this._ShouldIncludeCaptions);
			kparams.AddIfNotNull("shouldAddThumbExtension", this._ShouldAddThumbExtension);
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
				case FEED_LAST_BUILD_DATE:
					return "FeedLastBuildDate";
				case ITEM_LINK:
					return "ItemLink";
				case CPLATFORM_TV_SERIES:
					return "CPlatformTvSeries";
				case CPLATFORM_TV_SERIES_FIELD:
					return "CPlatformTvSeriesField";
				case SHOULD_INCLUDE_CUE_POINTS:
					return "ShouldIncludeCuePoints";
				case SHOULD_INCLUDE_CAPTIONS:
					return "ShouldIncludeCaptions";
				case SHOULD_ADD_THUMB_EXTENSION:
					return "ShouldAddThumbExtension";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

