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
		public string TargetServiceUrl
		{
			get { return _TargetServiceUrl; }
			set 
			{ 
				_TargetServiceUrl = value;
				OnPropertyChanged("TargetServiceUrl");
			}
		}
		public int TargetAccountId
		{
			get { return _TargetAccountId; }
			set 
			{ 
				_TargetAccountId = value;
				OnPropertyChanged("TargetAccountId");
			}
		}
		public string TargetLoginId
		{
			get { return _TargetLoginId; }
			set 
			{ 
				_TargetLoginId = value;
				OnPropertyChanged("TargetLoginId");
			}
		}
		public string TargetLoginPassword
		{
			get { return _TargetLoginPassword; }
			set 
			{ 
				_TargetLoginPassword = value;
				OnPropertyChanged("TargetLoginPassword");
			}
		}
		public string MetadataXslt
		{
			get { return _MetadataXslt; }
			set 
			{ 
				_MetadataXslt = value;
				OnPropertyChanged("MetadataXslt");
			}
		}
		public IList<StringValue> MetadataXpathsTriggerUpdate
		{
			get { return _MetadataXpathsTriggerUpdate; }
			set 
			{ 
				_MetadataXpathsTriggerUpdate = value;
				OnPropertyChanged("MetadataXpathsTriggerUpdate");
			}
		}
		public bool? DistributeCaptions
		{
			get { return _DistributeCaptions; }
			set 
			{ 
				_DistributeCaptions = value;
				OnPropertyChanged("DistributeCaptions");
			}
		}
		public bool? DistributeCuePoints
		{
			get { return _DistributeCuePoints; }
			set 
			{ 
				_DistributeCuePoints = value;
				OnPropertyChanged("DistributeCuePoints");
			}
		}
		public bool? DistributeRemoteFlavorAssetContent
		{
			get { return _DistributeRemoteFlavorAssetContent; }
			set 
			{ 
				_DistributeRemoteFlavorAssetContent = value;
				OnPropertyChanged("DistributeRemoteFlavorAssetContent");
			}
		}
		public bool? DistributeRemoteThumbAssetContent
		{
			get { return _DistributeRemoteThumbAssetContent; }
			set 
			{ 
				_DistributeRemoteThumbAssetContent = value;
				OnPropertyChanged("DistributeRemoteThumbAssetContent");
			}
		}
		public bool? DistributeRemoteCaptionAssetContent
		{
			get { return _DistributeRemoteCaptionAssetContent; }
			set 
			{ 
				_DistributeRemoteCaptionAssetContent = value;
				OnPropertyChanged("DistributeRemoteCaptionAssetContent");
			}
		}
		public IList<KeyValue> MapAccessControlProfileIds
		{
			get { return _MapAccessControlProfileIds; }
			set 
			{ 
				_MapAccessControlProfileIds = value;
				OnPropertyChanged("MapAccessControlProfileIds");
			}
		}
		public IList<KeyValue> MapConversionProfileIds
		{
			get { return _MapConversionProfileIds; }
			set 
			{ 
				_MapConversionProfileIds = value;
				OnPropertyChanged("MapConversionProfileIds");
			}
		}
		public IList<KeyValue> MapMetadataProfileIds
		{
			get { return _MapMetadataProfileIds; }
			set 
			{ 
				_MapMetadataProfileIds = value;
				OnPropertyChanged("MapMetadataProfileIds");
			}
		}
		public IList<KeyValue> MapStorageProfileIds
		{
			get { return _MapStorageProfileIds; }
			set 
			{ 
				_MapStorageProfileIds = value;
				OnPropertyChanged("MapStorageProfileIds");
			}
		}
		public IList<KeyValue> MapFlavorParamsIds
		{
			get { return _MapFlavorParamsIds; }
			set 
			{ 
				_MapFlavorParamsIds = value;
				OnPropertyChanged("MapFlavorParamsIds");
			}
		}
		public IList<KeyValue> MapThumbParamsIds
		{
			get { return _MapThumbParamsIds; }
			set 
			{ 
				_MapThumbParamsIds = value;
				OnPropertyChanged("MapThumbParamsIds");
			}
		}
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

		public CrossKalturaDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "targetServiceUrl":
						this._TargetServiceUrl = propertyNode.InnerText;
						continue;
					case "targetAccountId":
						this._TargetAccountId = ParseInt(propertyNode.InnerText);
						continue;
					case "targetLoginId":
						this._TargetLoginId = propertyNode.InnerText;
						continue;
					case "targetLoginPassword":
						this._TargetLoginPassword = propertyNode.InnerText;
						continue;
					case "metadataXslt":
						this._MetadataXslt = propertyNode.InnerText;
						continue;
					case "metadataXpathsTriggerUpdate":
						this._MetadataXpathsTriggerUpdate = new List<StringValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MetadataXpathsTriggerUpdate.Add(ObjectFactory.Create<StringValue>(arrayNode));
						}
						continue;
					case "distributeCaptions":
						this._DistributeCaptions = ParseBool(propertyNode.InnerText);
						continue;
					case "distributeCuePoints":
						this._DistributeCuePoints = ParseBool(propertyNode.InnerText);
						continue;
					case "distributeRemoteFlavorAssetContent":
						this._DistributeRemoteFlavorAssetContent = ParseBool(propertyNode.InnerText);
						continue;
					case "distributeRemoteThumbAssetContent":
						this._DistributeRemoteThumbAssetContent = ParseBool(propertyNode.InnerText);
						continue;
					case "distributeRemoteCaptionAssetContent":
						this._DistributeRemoteCaptionAssetContent = ParseBool(propertyNode.InnerText);
						continue;
					case "mapAccessControlProfileIds":
						this._MapAccessControlProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapAccessControlProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapConversionProfileIds":
						this._MapConversionProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapConversionProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapMetadataProfileIds":
						this._MapMetadataProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapMetadataProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapStorageProfileIds":
						this._MapStorageProfileIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapStorageProfileIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapFlavorParamsIds":
						this._MapFlavorParamsIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapFlavorParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapThumbParamsIds":
						this._MapThumbParamsIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapThumbParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
					case "mapCaptionParamsIds":
						this._MapCaptionParamsIds = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._MapCaptionParamsIds.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
				}
			}
		}

		public CrossKalturaDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._TargetServiceUrl = data.TryGetValueSafe<string>("targetServiceUrl");
			    this._TargetAccountId = data.TryGetValueSafe<int>("targetAccountId");
			    this._TargetLoginId = data.TryGetValueSafe<string>("targetLoginId");
			    this._TargetLoginPassword = data.TryGetValueSafe<string>("targetLoginPassword");
			    this._MetadataXslt = data.TryGetValueSafe<string>("metadataXslt");
			    this._MetadataXpathsTriggerUpdate = new List<StringValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("metadataXpathsTriggerUpdate", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MetadataXpathsTriggerUpdate.Add(ObjectFactory.Create<StringValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._DistributeCaptions = data.TryGetValueSafe<bool>("distributeCaptions");
			    this._DistributeCuePoints = data.TryGetValueSafe<bool>("distributeCuePoints");
			    this._DistributeRemoteFlavorAssetContent = data.TryGetValueSafe<bool>("distributeRemoteFlavorAssetContent");
			    this._DistributeRemoteThumbAssetContent = data.TryGetValueSafe<bool>("distributeRemoteThumbAssetContent");
			    this._DistributeRemoteCaptionAssetContent = data.TryGetValueSafe<bool>("distributeRemoteCaptionAssetContent");
			    this._MapAccessControlProfileIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapAccessControlProfileIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapAccessControlProfileIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapConversionProfileIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapConversionProfileIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapConversionProfileIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapMetadataProfileIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapMetadataProfileIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapMetadataProfileIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapStorageProfileIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapStorageProfileIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapStorageProfileIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapFlavorParamsIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapFlavorParamsIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapFlavorParamsIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapThumbParamsIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapThumbParamsIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapThumbParamsIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MapCaptionParamsIds = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("mapCaptionParamsIds", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._MapCaptionParamsIds.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
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

