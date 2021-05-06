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
	public class ConvertJobData : ConvartableJobData
	{
		#region Constants
		public const string DEST_FILE_SYNC_LOCAL_PATH = "destFileSyncLocalPath";
		public const string DEST_FILE_SYNC_REMOTE_URL = "destFileSyncRemoteUrl";
		public const string LOG_FILE_SYNC_LOCAL_PATH = "logFileSyncLocalPath";
		public const string LOG_FILE_SYNC_REMOTE_URL = "logFileSyncRemoteUrl";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string REMOTE_MEDIA_ID = "remoteMediaId";
		public const string CUSTOM_DATA = "customData";
		public const string EXTRA_DEST_FILE_SYNCS = "extraDestFileSyncs";
		public const string ENGINE_MESSAGE = "engineMessage";
		public const string DEST_FILE_SYNC_SHARED_PATH = "destFileSyncSharedPath";
		public const string USER_CPU = "userCpu";
		#endregion

		#region Private Fields
		private string _DestFileSyncLocalPath = null;
		private string _DestFileSyncRemoteUrl = null;
		private string _LogFileSyncLocalPath = null;
		private string _LogFileSyncRemoteUrl = null;
		private string _FlavorAssetId = null;
		private string _RemoteMediaId = null;
		private string _CustomData = null;
		private IList<DestFileSyncDescriptor> _ExtraDestFileSyncs;
		private string _EngineMessage = null;
		private string _DestFileSyncSharedPath = null;
		private int _UserCpu = Int32.MinValue;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string LogFileSyncLocalPath
		{
			get { return _LogFileSyncLocalPath; }
			set 
			{ 
				_LogFileSyncLocalPath = value;
				OnPropertyChanged("LogFileSyncLocalPath");
			}
		}
		[JsonProperty]
		public string LogFileSyncRemoteUrl
		{
			get { return _LogFileSyncRemoteUrl; }
			set 
			{ 
				_LogFileSyncRemoteUrl = value;
				OnPropertyChanged("LogFileSyncRemoteUrl");
			}
		}
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
		[JsonProperty]
		public string RemoteMediaId
		{
			get { return _RemoteMediaId; }
			set 
			{ 
				_RemoteMediaId = value;
				OnPropertyChanged("RemoteMediaId");
			}
		}
		[JsonProperty]
		public string CustomData
		{
			get { return _CustomData; }
			set 
			{ 
				_CustomData = value;
				OnPropertyChanged("CustomData");
			}
		}
		[JsonProperty]
		public IList<DestFileSyncDescriptor> ExtraDestFileSyncs
		{
			get { return _ExtraDestFileSyncs; }
			set 
			{ 
				_ExtraDestFileSyncs = value;
				OnPropertyChanged("ExtraDestFileSyncs");
			}
		}
		[JsonProperty]
		public string EngineMessage
		{
			get { return _EngineMessage; }
			set 
			{ 
				_EngineMessage = value;
				OnPropertyChanged("EngineMessage");
			}
		}
		[JsonProperty]
		public string DestFileSyncSharedPath
		{
			get { return _DestFileSyncSharedPath; }
			set 
			{ 
				_DestFileSyncSharedPath = value;
				OnPropertyChanged("DestFileSyncSharedPath");
			}
		}
		[JsonProperty]
		public int UserCpu
		{
			get { return _UserCpu; }
			set 
			{ 
				_UserCpu = value;
				OnPropertyChanged("UserCpu");
			}
		}
		#endregion

		#region CTor
		public ConvertJobData()
		{
		}

		public ConvertJobData(JToken node) : base(node)
		{
			if(node["destFileSyncLocalPath"] != null)
			{
				this._DestFileSyncLocalPath = node["destFileSyncLocalPath"].Value<string>();
			}
			if(node["destFileSyncRemoteUrl"] != null)
			{
				this._DestFileSyncRemoteUrl = node["destFileSyncRemoteUrl"].Value<string>();
			}
			if(node["logFileSyncLocalPath"] != null)
			{
				this._LogFileSyncLocalPath = node["logFileSyncLocalPath"].Value<string>();
			}
			if(node["logFileSyncRemoteUrl"] != null)
			{
				this._LogFileSyncRemoteUrl = node["logFileSyncRemoteUrl"].Value<string>();
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["remoteMediaId"] != null)
			{
				this._RemoteMediaId = node["remoteMediaId"].Value<string>();
			}
			if(node["customData"] != null)
			{
				this._CustomData = node["customData"].Value<string>();
			}
			if(node["extraDestFileSyncs"] != null)
			{
				this._ExtraDestFileSyncs = new List<DestFileSyncDescriptor>();
				foreach(var arrayNode in node["extraDestFileSyncs"].Children())
				{
					this._ExtraDestFileSyncs.Add(ObjectFactory.Create<DestFileSyncDescriptor>(arrayNode));
				}
			}
			if(node["engineMessage"] != null)
			{
				this._EngineMessage = node["engineMessage"].Value<string>();
			}
			if(node["destFileSyncSharedPath"] != null)
			{
				this._DestFileSyncSharedPath = node["destFileSyncSharedPath"].Value<string>();
			}
			if(node["userCpu"] != null)
			{
				this._UserCpu = ParseInt(node["userCpu"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertJobData");
			kparams.AddIfNotNull("destFileSyncLocalPath", this._DestFileSyncLocalPath);
			kparams.AddIfNotNull("destFileSyncRemoteUrl", this._DestFileSyncRemoteUrl);
			kparams.AddIfNotNull("logFileSyncLocalPath", this._LogFileSyncLocalPath);
			kparams.AddIfNotNull("logFileSyncRemoteUrl", this._LogFileSyncRemoteUrl);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("remoteMediaId", this._RemoteMediaId);
			kparams.AddIfNotNull("customData", this._CustomData);
			kparams.AddIfNotNull("extraDestFileSyncs", this._ExtraDestFileSyncs);
			kparams.AddIfNotNull("engineMessage", this._EngineMessage);
			kparams.AddIfNotNull("destFileSyncSharedPath", this._DestFileSyncSharedPath);
			kparams.AddIfNotNull("userCpu", this._UserCpu);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DEST_FILE_SYNC_LOCAL_PATH:
					return "DestFileSyncLocalPath";
				case DEST_FILE_SYNC_REMOTE_URL:
					return "DestFileSyncRemoteUrl";
				case LOG_FILE_SYNC_LOCAL_PATH:
					return "LogFileSyncLocalPath";
				case LOG_FILE_SYNC_REMOTE_URL:
					return "LogFileSyncRemoteUrl";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case REMOTE_MEDIA_ID:
					return "RemoteMediaId";
				case CUSTOM_DATA:
					return "CustomData";
				case EXTRA_DEST_FILE_SYNCS:
					return "ExtraDestFileSyncs";
				case ENGINE_MESSAGE:
					return "EngineMessage";
				case DEST_FILE_SYNC_SHARED_PATH:
					return "DestFileSyncSharedPath";
				case USER_CPU:
					return "UserCpu";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

