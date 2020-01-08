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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class UnicornDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string CATALOG_GUID = "catalogGuid";
		public const string TITLE = "title";
		public const string MEDIA_CHANGED = "mediaChanged";
		public const string FLAVOR_ASSET_VERSION = "flavorAssetVersion";
		public const string NOTIFICATION_BASE_URL = "notificationBaseUrl";
		#endregion

		#region Private Fields
		private string _CatalogGuid = null;
		private string _Title = null;
		private bool? _MediaChanged = null;
		private string _FlavorAssetVersion = null;
		private string _NotificationBaseUrl = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string CatalogGuid
		{
			get { return _CatalogGuid; }
			set 
			{ 
				_CatalogGuid = value;
				OnPropertyChanged("CatalogGuid");
			}
		}
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		[JsonProperty]
		public bool? MediaChanged
		{
			get { return _MediaChanged; }
			set 
			{ 
				_MediaChanged = value;
				OnPropertyChanged("MediaChanged");
			}
		}
		[JsonProperty]
		public string FlavorAssetVersion
		{
			get { return _FlavorAssetVersion; }
			set 
			{ 
				_FlavorAssetVersion = value;
				OnPropertyChanged("FlavorAssetVersion");
			}
		}
		[JsonProperty]
		public string NotificationBaseUrl
		{
			get { return _NotificationBaseUrl; }
			set 
			{ 
				_NotificationBaseUrl = value;
				OnPropertyChanged("NotificationBaseUrl");
			}
		}
		#endregion

		#region CTor
		public UnicornDistributionJobProviderData()
		{
		}

		public UnicornDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["catalogGuid"] != null)
			{
				this._CatalogGuid = node["catalogGuid"].Value<string>();
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["mediaChanged"] != null)
			{
				this._MediaChanged = ParseBool(node["mediaChanged"].Value<string>());
			}
			if(node["flavorAssetVersion"] != null)
			{
				this._FlavorAssetVersion = node["flavorAssetVersion"].Value<string>();
			}
			if(node["notificationBaseUrl"] != null)
			{
				this._NotificationBaseUrl = node["notificationBaseUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUnicornDistributionJobProviderData");
			kparams.AddIfNotNull("catalogGuid", this._CatalogGuid);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("mediaChanged", this._MediaChanged);
			kparams.AddIfNotNull("flavorAssetVersion", this._FlavorAssetVersion);
			kparams.AddIfNotNull("notificationBaseUrl", this._NotificationBaseUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATALOG_GUID:
					return "CatalogGuid";
				case TITLE:
					return "Title";
				case MEDIA_CHANGED:
					return "MediaChanged";
				case FLAVOR_ASSET_VERSION:
					return "FlavorAssetVersion";
				case NOTIFICATION_BASE_URL:
					return "NotificationBaseUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

