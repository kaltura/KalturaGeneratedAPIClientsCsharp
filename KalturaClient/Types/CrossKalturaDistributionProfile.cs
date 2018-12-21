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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class CrossKalturaDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string TARGET_SERVICE_URL = "targetServiceUrl";
		public const string TARGET_ACCOUNT_ID = "targetAccountId";
		public const string TARGET_LOGIN_ID = "targetLoginId";
		public const string TARGET_LOGIN_PASSWORD = "targetLoginPassword";
		public const string METADATA_XSLT = "metadataXslt";
		public const string METADATA_XPATHS_TRIGGER_UPDATE = "metadataXpathsTriggerUpdate";
		public const string DISTRIBUTE_CAPTIONS = "distributeCaptions";
		public const string DISTRIBUTE_CUE_POINTS = "distributeCuePoints";
		public const string DISTRIBUTE_REMOTE_FLAVOR_ASSET_CONTENT = "distributeRemoteFlavorAssetContent";
		public const string DISTRIBUTE_REMOTE_THUMB_ASSET_CONTENT = "distributeRemoteThumbAssetContent";
		public const string DISTRIBUTE_REMOTE_CAPTION_ASSET_CONTENT = "distributeRemoteCaptionAssetContent";
		public const string MAP_ACCESS_CONTROL_PROFILE_IDS = "mapAccessControlProfileIds";
		public const string MAP_CONVERSION_PROFILE_IDS = "mapConversionProfileIds";
		public const string MAP_METADATA_PROFILE_IDS = "mapMetadataProfileIds";
		public const string MAP_STORAGE_PROFILE_IDS = "mapStorageProfileIds";
		public const string MAP_FLAVOR_PARAMS_IDS = "mapFlavorParamsIds";
		public const string MAP_THUMB_PARAMS_IDS = "mapThumbParamsIds";
		public const string MAP_CAPTION_PARAMS_IDS = "mapCaptionParamsIds";
		#endregion

		#region Private Fields
		private string _TargetServiceUrl = null;
		private int _TargetAccountId = Int32.MinValue;
		private string _TargetLoginId = null;
		private string _TargetLoginPassword = null;
		private string _MetadataXslt = null;
		private IList<StringValue> _MetadataXpathsTriggerUpdate;
		private bool? _DistributeCaptions = null;
		private bool? _DistributeCuePoints = null;
		private bool? _DistributeRemoteFlavorAssetContent = null;
		private bool? _DistributeRemoteThumbAssetContent = null;
		private bool? _DistributeRemoteCaptionAssetContent = null;
		private IList<KeyValue> _MapAccessControlProfileIds;
		private IList<KeyValue> _MapConversionProfileIds;
		private IList<KeyValue> _MapMetadataProfileIds;
		private IList<KeyValue> _MapStorageProfileIds;
		private IList<KeyValue> _MapFlavorParamsIds;
		private IList<KeyValue> _MapThumbParamsIds;
		private IList<KeyValue> _MapCaptionParamsIds;
		#endregion

		#region Properties
		[JsonProperty]
		public string TargetServiceUrl
		{
			get { return _TargetServiceUrl; }
			set 
			{ 
				_TargetServiceUrl = value;
				OnPropertyChanged("TargetServiceUrl");
			}
		}
		[JsonProperty]
		public int TargetAccountId
		{
			get { return _TargetAccountId; }
			set 
			{ 
				_TargetAccountId = value;
				OnPropertyChanged("TargetAccountId");
			}
		}
		[JsonProperty]
		public string TargetLoginId
		{
			get { return _TargetLoginId; }
			set 
			{ 
				_TargetLoginId = value;
				OnPropertyChanged("TargetLoginId");
			}
		}
		[JsonProperty]
		public string TargetLoginPassword
		{
			get { return _TargetLoginPassword; }
			set 
			{ 
				_TargetLoginPassword = value;
				OnPropertyChanged("TargetLoginPassword");
			}
		}
		[JsonProperty]
		public string MetadataXslt
		{
			get { return _MetadataXslt; }
			set 
			{ 
				_MetadataXslt = value;
				OnPropertyChanged("MetadataXslt");
			}
		}
		[JsonProperty]
		public IList<StringValue> MetadataXpathsTriggerUpdate
		{
			get { return _MetadataXpathsTriggerUpdate; }
			set 
			{ 
				_MetadataXpathsTriggerUpdate = value;
				OnPropertyChanged("MetadataXpathsTriggerUpdate");
			}
		}
		[JsonProperty]
		public bool? DistributeCaptions
		{
			get { return _DistributeCaptions; }
			set 
			{ 
				_DistributeCaptions = value;
				OnPropertyChanged("DistributeCaptions");
			}
		}
		[JsonProperty]
		public bool? DistributeCuePoints
		{
			get { return _DistributeCuePoints; }
			set 
			{ 
				_DistributeCuePoints = value;
				OnPropertyChanged("DistributeCuePoints");
			}
		}
		[JsonProperty]
		public bool? DistributeRemoteFlavorAssetContent
		{
			get { return _DistributeRemoteFlavorAssetContent; }
			set 
			{ 
				_DistributeRemoteFlavorAssetContent = value;
				OnPropertyChanged("DistributeRemoteFlavorAssetContent");
			}
		}
		[JsonProperty]
		public bool? DistributeRemoteThumbAssetContent
		{
			get { return _DistributeRemoteThumbAssetContent; }
			set 
			{ 
				_DistributeRemoteThumbAssetContent = value;
				OnPropertyChanged("DistributeRemoteThumbAssetContent");
			}
		}
		[JsonProperty]
		public bool? DistributeRemoteCaptionAssetContent
		{
			get { return _DistributeRemoteCaptionAssetContent; }
			set 
			{ 
				_DistributeRemoteCaptionAssetContent = value;
				OnPropertyChanged("DistributeRemoteCaptionAssetContent");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapAccessControlProfileIds
		{
			get { return _MapAccessControlProfileIds; }
			set 
			{ 
				_MapAccessControlProfileIds = value;
				OnPropertyChanged("MapAccessControlProfileIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapConversionProfileIds
		{
			get { return _MapConversionProfileIds; }
			set 
			{ 
				_MapConversionProfileIds = value;
				OnPropertyChanged("MapConversionProfileIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapMetadataProfileIds
		{
			get { return _MapMetadataProfileIds; }
			set 
			{ 
				_MapMetadataProfileIds = value;
				OnPropertyChanged("MapMetadataProfileIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapStorageProfileIds
		{
			get { return _MapStorageProfileIds; }
			set 
			{ 
				_MapStorageProfileIds = value;
				OnPropertyChanged("MapStorageProfileIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapFlavorParamsIds
		{
			get { return _MapFlavorParamsIds; }
			set 
			{ 
				_MapFlavorParamsIds = value;
				OnPropertyChanged("MapFlavorParamsIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapThumbParamsIds
		{
			get { return _MapThumbParamsIds; }
			set 
			{ 
				_MapThumbParamsIds = value;
				OnPropertyChanged("MapThumbParamsIds");
			}
		}
		[JsonProperty]
		public IList<KeyValue> MapCaptionParamsIds
		{
			get { return _MapCaptionParamsIds; }
			set 
			{ 
				_MapCaptionParamsIds = value;
				OnPropertyChanged("MapCaptionParamsIds");
			}
		}
		#endregion

		#region CTor
		public CrossKalturaDistributionProfile()
		{
		}

		public CrossKalturaDistributionProfile(JToken node) : base(node)
		{
			if(node["targetServiceUrl"] != null)
			{
				this._TargetServiceUrl = node["targetServiceUrl"].Value<string>();
			}
			if(node["targetAccountId"] != null)
			{
				this._TargetAccountId = ParseInt(node["targetAccountId"].Value<string>());
			}
			if(node["targetLoginId"] != null)
			{
				this._TargetLoginId = node["targetLoginId"].Value<string>();
			}
			if(node["targetLoginPassword"] != null)
			{
				this._TargetLoginPassword = node["targetLoginPassword"].Value<string>();
			}
			if(node["metadataXslt"] != null)
			{
				this._MetadataXslt = node["metadataXslt"].Value<string>();
			}
			if(node["metadataXpathsTriggerUpdate"] != null)
			{
				this._MetadataXpathsTriggerUpdate = new List<StringValue>();
				foreach(var arrayNode in node["metadataXpathsTriggerUpdate"].Children())
				{
					this._MetadataXpathsTriggerUpdate.Add(ObjectFactory.Create<StringValue>(arrayNode));
				}
			}
			if(node["distributeCaptions"] != null)
			{
				this._DistributeCaptions = ParseBool(node["distributeCaptions"].Value<string>());
			}
			if(node["distributeCuePoints"] != null)
			{
				this._DistributeCuePoints = ParseBool(node["distributeCuePoints"].Value<string>());
			}
			if(node["distributeRemoteFlavorAssetContent"] != null)
			{
				this._DistributeRemoteFlavorAssetContent = ParseBool(node["distributeRemoteFlavorAssetContent"].Value<string>());
			}
			if(node["distributeRemoteThumbAssetContent"] != null)
			{
				this._DistributeRemoteThumbAssetContent = ParseBool(node["distributeRemoteThumbAssetContent"].Value<string>());
			}
			if(node["distributeRemoteCaptionAssetContent"] != null)
			{
				this._DistributeRemoteCaptionAssetContent = ParseBool(node["distributeRemoteCaptionAssetContent"].Value<string>());
			}
			if(node["mapAccessControlProfileIds"] != null)
			{
				this._MapAccessControlProfileIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapAccessControlProfileIds"].Children())
				{
					this._MapAccessControlProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapConversionProfileIds"] != null)
			{
				this._MapConversionProfileIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapConversionProfileIds"].Children())
				{
					this._MapConversionProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapMetadataProfileIds"] != null)
			{
				this._MapMetadataProfileIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapMetadataProfileIds"].Children())
				{
					this._MapMetadataProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapStorageProfileIds"] != null)
			{
				this._MapStorageProfileIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapStorageProfileIds"].Children())
				{
					this._MapStorageProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapFlavorParamsIds"] != null)
			{
				this._MapFlavorParamsIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapFlavorParamsIds"].Children())
				{
					this._MapFlavorParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapThumbParamsIds"] != null)
			{
				this._MapThumbParamsIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapThumbParamsIds"].Children())
				{
					this._MapThumbParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["mapCaptionParamsIds"] != null)
			{
				this._MapCaptionParamsIds = new List<KeyValue>();
				foreach(var arrayNode in node["mapCaptionParamsIds"].Children())
				{
					this._MapCaptionParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCrossKalturaDistributionProfile");
			kparams.AddIfNotNull("targetServiceUrl", this._TargetServiceUrl);
			kparams.AddIfNotNull("targetAccountId", this._TargetAccountId);
			kparams.AddIfNotNull("targetLoginId", this._TargetLoginId);
			kparams.AddIfNotNull("targetLoginPassword", this._TargetLoginPassword);
			kparams.AddIfNotNull("metadataXslt", this._MetadataXslt);
			kparams.AddIfNotNull("metadataXpathsTriggerUpdate", this._MetadataXpathsTriggerUpdate);
			kparams.AddIfNotNull("distributeCaptions", this._DistributeCaptions);
			kparams.AddIfNotNull("distributeCuePoints", this._DistributeCuePoints);
			kparams.AddIfNotNull("distributeRemoteFlavorAssetContent", this._DistributeRemoteFlavorAssetContent);
			kparams.AddIfNotNull("distributeRemoteThumbAssetContent", this._DistributeRemoteThumbAssetContent);
			kparams.AddIfNotNull("distributeRemoteCaptionAssetContent", this._DistributeRemoteCaptionAssetContent);
			kparams.AddIfNotNull("mapAccessControlProfileIds", this._MapAccessControlProfileIds);
			kparams.AddIfNotNull("mapConversionProfileIds", this._MapConversionProfileIds);
			kparams.AddIfNotNull("mapMetadataProfileIds", this._MapMetadataProfileIds);
			kparams.AddIfNotNull("mapStorageProfileIds", this._MapStorageProfileIds);
			kparams.AddIfNotNull("mapFlavorParamsIds", this._MapFlavorParamsIds);
			kparams.AddIfNotNull("mapThumbParamsIds", this._MapThumbParamsIds);
			kparams.AddIfNotNull("mapCaptionParamsIds", this._MapCaptionParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TARGET_SERVICE_URL:
					return "TargetServiceUrl";
				case TARGET_ACCOUNT_ID:
					return "TargetAccountId";
				case TARGET_LOGIN_ID:
					return "TargetLoginId";
				case TARGET_LOGIN_PASSWORD:
					return "TargetLoginPassword";
				case METADATA_XSLT:
					return "MetadataXslt";
				case METADATA_XPATHS_TRIGGER_UPDATE:
					return "MetadataXpathsTriggerUpdate";
				case DISTRIBUTE_CAPTIONS:
					return "DistributeCaptions";
				case DISTRIBUTE_CUE_POINTS:
					return "DistributeCuePoints";
				case DISTRIBUTE_REMOTE_FLAVOR_ASSET_CONTENT:
					return "DistributeRemoteFlavorAssetContent";
				case DISTRIBUTE_REMOTE_THUMB_ASSET_CONTENT:
					return "DistributeRemoteThumbAssetContent";
				case DISTRIBUTE_REMOTE_CAPTION_ASSET_CONTENT:
					return "DistributeRemoteCaptionAssetContent";
				case MAP_ACCESS_CONTROL_PROFILE_IDS:
					return "MapAccessControlProfileIds";
				case MAP_CONVERSION_PROFILE_IDS:
					return "MapConversionProfileIds";
				case MAP_METADATA_PROFILE_IDS:
					return "MapMetadataProfileIds";
				case MAP_STORAGE_PROFILE_IDS:
					return "MapStorageProfileIds";
				case MAP_FLAVOR_PARAMS_IDS:
					return "MapFlavorParamsIds";
				case MAP_THUMB_PARAMS_IDS:
					return "MapThumbParamsIds";
				case MAP_CAPTION_PARAMS_IDS:
					return "MapCaptionParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

