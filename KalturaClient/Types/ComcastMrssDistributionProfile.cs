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
		/// <summary>
		/// Use MetadataProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
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
		/// <summary>
		/// Use FeedLinkAsDouble property instead
		/// </summary>
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
		/// Use FeedLastBuildDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FeedLastBuildDate
		{
			get { return _FeedLastBuildDate; }
			set 
			{ 
				_FeedLastBuildDate = value;
				OnPropertyChanged("FeedLastBuildDate");
			}
		}
		/// <summary>
		/// Use ItemLinkAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ItemLink
		{
			get { return _ItemLink; }
			set 
			{ 
				_ItemLink = value;
				OnPropertyChanged("ItemLink");
			}
		}
		/// <summary>
		/// Use CPlatformTvSeriesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> CPlatformTvSeries
		{
			get { return _CPlatformTvSeries; }
			set 
			{ 
				_CPlatformTvSeries = value;
				OnPropertyChanged("CPlatformTvSeries");
			}
		}
		/// <summary>
		/// Use CPlatformTvSeriesFieldAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CPlatformTvSeriesField
		{
			get { return _CPlatformTvSeriesField; }
			set 
			{ 
				_CPlatformTvSeriesField = value;
				OnPropertyChanged("CPlatformTvSeriesField");
			}
		}
		/// <summary>
		/// Use ShouldIncludeCuePointsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ShouldIncludeCuePoints
		{
			get { return _ShouldIncludeCuePoints; }
			set 
			{ 
				_ShouldIncludeCuePoints = value;
				OnPropertyChanged("ShouldIncludeCuePoints");
			}
		}
		/// <summary>
		/// Use ShouldIncludeCaptionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ShouldIncludeCaptions
		{
			get { return _ShouldIncludeCaptions; }
			set 
			{ 
				_ShouldIncludeCaptions = value;
				OnPropertyChanged("ShouldIncludeCaptions");
			}
		}
		/// <summary>
		/// Use ShouldAddThumbExtensionAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public ComcastMrssDistributionProfile(JToken node) : base(node)
		{
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["feedTitle"] != null)
			{
				this._FeedTitle = node["feedTitle"].Value<string>();
			}
			if(node["feedLink"] != null)
			{
				this._FeedLink = node["feedLink"].Value<string>();
			}
			if(node["feedDescription"] != null)
			{
				this._FeedDescription = node["feedDescription"].Value<string>();
			}
			if(node["feedLastBuildDate"] != null)
			{
				this._FeedLastBuildDate = node["feedLastBuildDate"].Value<string>();
			}
			if(node["itemLink"] != null)
			{
				this._ItemLink = node["itemLink"].Value<string>();
			}
			if(node["cPlatformTvSeries"] != null)
			{
				this._CPlatformTvSeries = new List<KeyValue>();
				foreach(var arrayNode in node["cPlatformTvSeries"].Children())
				{
					this._CPlatformTvSeries.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["cPlatformTvSeriesField"] != null)
			{
				this._CPlatformTvSeriesField = node["cPlatformTvSeriesField"].Value<string>();
			}
			if(node["shouldIncludeCuePoints"] != null)
			{
				this._ShouldIncludeCuePoints = ParseBool(node["shouldIncludeCuePoints"].Value<string>());
			}
			if(node["shouldIncludeCaptions"] != null)
			{
				this._ShouldIncludeCaptions = ParseBool(node["shouldIncludeCaptions"].Value<string>());
			}
			if(node["shouldAddThumbExtension"] != null)
			{
				this._ShouldAddThumbExtension = ParseBool(node["shouldAddThumbExtension"].Value<string>());
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

