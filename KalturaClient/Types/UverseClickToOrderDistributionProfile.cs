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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class UverseClickToOrderDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FEED_URL = "feedUrl";
		public const string BACKGROUND_IMAGE_WIDE = "backgroundImageWide";
		public const string BACKGROUND_IMAGE_STANDARD = "backgroundImageStandard";
		#endregion

		#region Private Fields
		private string _FeedUrl = null;
		private string _BackgroundImageWide = null;
		private string _BackgroundImageStandard = null;
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
		public string BackgroundImageWide
		{
			get { return _BackgroundImageWide; }
			set 
			{ 
				_BackgroundImageWide = value;
				OnPropertyChanged("BackgroundImageWide");
			}
		}
		[JsonProperty]
		public string BackgroundImageStandard
		{
			get { return _BackgroundImageStandard; }
			set 
			{ 
				_BackgroundImageStandard = value;
				OnPropertyChanged("BackgroundImageStandard");
			}
		}
		#endregion

		#region CTor
		public UverseClickToOrderDistributionProfile()
		{
		}

		public UverseClickToOrderDistributionProfile(JToken node) : base(node)
		{
			if(node["feedUrl"] != null)
			{
				this._FeedUrl = node["feedUrl"].Value<string>();
			}
			if(node["backgroundImageWide"] != null)
			{
				this._BackgroundImageWide = node["backgroundImageWide"].Value<string>();
			}
			if(node["backgroundImageStandard"] != null)
			{
				this._BackgroundImageStandard = node["backgroundImageStandard"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUverseClickToOrderDistributionProfile");
			kparams.AddIfNotNull("feedUrl", this._FeedUrl);
			kparams.AddIfNotNull("backgroundImageWide", this._BackgroundImageWide);
			kparams.AddIfNotNull("backgroundImageStandard", this._BackgroundImageStandard);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FEED_URL:
					return "FeedUrl";
				case BACKGROUND_IMAGE_WIDE:
					return "BackgroundImageWide";
				case BACKGROUND_IMAGE_STANDARD:
					return "BackgroundImageStandard";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

