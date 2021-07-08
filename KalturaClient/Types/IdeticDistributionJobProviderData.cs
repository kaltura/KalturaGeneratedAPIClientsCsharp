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
	public class IdeticDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string THUMBNAIL_URL = "thumbnailUrl";
		public const string FLAVOR_ASSET_URL = "flavorAssetUrl";
		#endregion

		#region Private Fields
		private string _ThumbnailUrl = null;
		private string _FlavorAssetUrl = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ThumbnailUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		/// <summary>
		/// Use FlavorAssetUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetUrl
		{
			get { return _FlavorAssetUrl; }
			set 
			{ 
				_FlavorAssetUrl = value;
				OnPropertyChanged("FlavorAssetUrl");
			}
		}
		#endregion

		#region CTor
		public IdeticDistributionJobProviderData()
		{
		}

		public IdeticDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["thumbnailUrl"] != null)
			{
				this._ThumbnailUrl = node["thumbnailUrl"].Value<string>();
			}
			if(node["flavorAssetUrl"] != null)
			{
				this._FlavorAssetUrl = node["flavorAssetUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIdeticDistributionJobProviderData");
			kparams.AddIfNotNull("thumbnailUrl", this._ThumbnailUrl);
			kparams.AddIfNotNull("flavorAssetUrl", this._FlavorAssetUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case THUMBNAIL_URL:
					return "ThumbnailUrl";
				case FLAVOR_ASSET_URL:
					return "FlavorAssetUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

