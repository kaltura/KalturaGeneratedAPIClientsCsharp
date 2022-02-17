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
	public class ConvertCollectionFlavorData : ObjectBase
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FLAVOR_PARAMS_OUTPUT_ID = "flavorParamsOutputId";
		public const string READY_BEHAVIOR = "readyBehavior";
		public const string VIDEO_BITRATE = "videoBitrate";
		public const string AUDIO_BITRATE = "audioBitrate";
		public const string DEST_FILE_SYNC_LOCAL_PATH = "destFileSyncLocalPath";
		public const string DEST_FILE_SYNC_REMOTE_URL = "destFileSyncRemoteUrl";
		#endregion

		#region Private Fields
		private string _FlavorAssetId = null;
		private int _FlavorParamsOutputId = Int32.MinValue;
		private int _ReadyBehavior = Int32.MinValue;
		private int _VideoBitrate = Int32.MinValue;
		private int _AudioBitrate = Int32.MinValue;
		private string _DestFileSyncLocalPath = null;
		private string _DestFileSyncRemoteUrl = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FlavorAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		/// <summary>
		/// Use FlavorParamsOutputIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsOutputId
		{
			get { return _FlavorParamsOutputId; }
			set 
			{ 
				_FlavorParamsOutputId = value;
				OnPropertyChanged("FlavorParamsOutputId");
			}
		}
		/// <summary>
		/// Use ReadyBehaviorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		/// <summary>
		/// Use VideoBitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoBitrate
		{
			get { return _VideoBitrate; }
			set 
			{ 
				_VideoBitrate = value;
				OnPropertyChanged("VideoBitrate");
			}
		}
		/// <summary>
		/// Use AudioBitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioBitrate
		{
			get { return _AudioBitrate; }
			set 
			{ 
				_AudioBitrate = value;
				OnPropertyChanged("AudioBitrate");
			}
		}
		/// <summary>
		/// Use DestFileSyncLocalPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DestFileSyncLocalPath
		{
			get { return _DestFileSyncLocalPath; }
			set 
			{ 
				_DestFileSyncLocalPath = value;
				OnPropertyChanged("DestFileSyncLocalPath");
			}
		}
		/// <summary>
		/// Use DestFileSyncRemoteUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DestFileSyncRemoteUrl
		{
			get { return _DestFileSyncRemoteUrl; }
			set 
			{ 
				_DestFileSyncRemoteUrl = value;
				OnPropertyChanged("DestFileSyncRemoteUrl");
			}
		}
		#endregion

		#region CTor
		public ConvertCollectionFlavorData()
		{
		}

		public ConvertCollectionFlavorData(JToken node) : base(node)
		{
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["flavorParamsOutputId"] != null)
			{
				this._FlavorParamsOutputId = ParseInt(node["flavorParamsOutputId"].Value<string>());
			}
			if(node["readyBehavior"] != null)
			{
				this._ReadyBehavior = ParseInt(node["readyBehavior"].Value<string>());
			}
			if(node["videoBitrate"] != null)
			{
				this._VideoBitrate = ParseInt(node["videoBitrate"].Value<string>());
			}
			if(node["audioBitrate"] != null)
			{
				this._AudioBitrate = ParseInt(node["audioBitrate"].Value<string>());
			}
			if(node["destFileSyncLocalPath"] != null)
			{
				this._DestFileSyncLocalPath = node["destFileSyncLocalPath"].Value<string>();
			}
			if(node["destFileSyncRemoteUrl"] != null)
			{
				this._DestFileSyncRemoteUrl = node["destFileSyncRemoteUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertCollectionFlavorData");
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("flavorParamsOutputId", this._FlavorParamsOutputId);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			kparams.AddIfNotNull("videoBitrate", this._VideoBitrate);
			kparams.AddIfNotNull("audioBitrate", this._AudioBitrate);
			kparams.AddIfNotNull("destFileSyncLocalPath", this._DestFileSyncLocalPath);
			kparams.AddIfNotNull("destFileSyncRemoteUrl", this._DestFileSyncRemoteUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FLAVOR_PARAMS_OUTPUT_ID:
					return "FlavorParamsOutputId";
				case READY_BEHAVIOR:
					return "ReadyBehavior";
				case VIDEO_BITRATE:
					return "VideoBitrate";
				case AUDIO_BITRATE:
					return "AudioBitrate";
				case DEST_FILE_SYNC_LOCAL_PATH:
					return "DestFileSyncLocalPath";
				case DEST_FILE_SYNC_REMOTE_URL:
					return "DestFileSyncRemoteUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

