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
		#endregion

		#region Properties
		public string DestFileSyncLocalPath
		{
			get { return _DestFileSyncLocalPath; }
			set 
			{ 
				_DestFileSyncLocalPath = value;
				OnPropertyChanged("DestFileSyncLocalPath");
			}
		}
		public string DestFileSyncRemoteUrl
		{
			get { return _DestFileSyncRemoteUrl; }
			set 
			{ 
				_DestFileSyncRemoteUrl = value;
				OnPropertyChanged("DestFileSyncRemoteUrl");
			}
		}
		public string LogFileSyncLocalPath
		{
			get { return _LogFileSyncLocalPath; }
			set 
			{ 
				_LogFileSyncLocalPath = value;
				OnPropertyChanged("LogFileSyncLocalPath");
			}
		}
		public string LogFileSyncRemoteUrl
		{
			get { return _LogFileSyncRemoteUrl; }
			set 
			{ 
				_LogFileSyncRemoteUrl = value;
				OnPropertyChanged("LogFileSyncRemoteUrl");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string RemoteMediaId
		{
			get { return _RemoteMediaId; }
			set 
			{ 
				_RemoteMediaId = value;
				OnPropertyChanged("RemoteMediaId");
			}
		}
		public string CustomData
		{
			get { return _CustomData; }
			set 
			{ 
				_CustomData = value;
				OnPropertyChanged("CustomData");
			}
		}
		public IList<DestFileSyncDescriptor> ExtraDestFileSyncs
		{
			get { return _ExtraDestFileSyncs; }
			set 
			{ 
				_ExtraDestFileSyncs = value;
				OnPropertyChanged("ExtraDestFileSyncs");
			}
		}
		public string EngineMessage
		{
			get { return _EngineMessage; }
			set 
			{ 
				_EngineMessage = value;
				OnPropertyChanged("EngineMessage");
			}
		}
		#endregion

		#region CTor
		public ConvertJobData()
		{
		}

		public ConvertJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "destFileSyncLocalPath":
						this._DestFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "destFileSyncRemoteUrl":
						this._DestFileSyncRemoteUrl = propertyNode.InnerText;
						continue;
					case "logFileSyncLocalPath":
						this._LogFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "logFileSyncRemoteUrl":
						this._LogFileSyncRemoteUrl = propertyNode.InnerText;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = propertyNode.InnerText;
						continue;
					case "remoteMediaId":
						this._RemoteMediaId = propertyNode.InnerText;
						continue;
					case "customData":
						this._CustomData = propertyNode.InnerText;
						continue;
					case "extraDestFileSyncs":
						this._ExtraDestFileSyncs = new List<DestFileSyncDescriptor>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ExtraDestFileSyncs.Add(ObjectFactory.Create<DestFileSyncDescriptor>(arrayNode));
						}
						continue;
					case "engineMessage":
						this._EngineMessage = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ConvertJobData(IDictionary<string,object> data) : base(data)
		{
			    this._DestFileSyncLocalPath = data.TryGetValueSafe<string>("destFileSyncLocalPath");
			    this._DestFileSyncRemoteUrl = data.TryGetValueSafe<string>("destFileSyncRemoteUrl");
			    this._LogFileSyncLocalPath = data.TryGetValueSafe<string>("logFileSyncLocalPath");
			    this._LogFileSyncRemoteUrl = data.TryGetValueSafe<string>("logFileSyncRemoteUrl");
			    this._FlavorAssetId = data.TryGetValueSafe<string>("flavorAssetId");
			    this._RemoteMediaId = data.TryGetValueSafe<string>("remoteMediaId");
			    this._CustomData = data.TryGetValueSafe<string>("customData");
			    this._ExtraDestFileSyncs = new List<DestFileSyncDescriptor>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("extraDestFileSyncs", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._ExtraDestFileSyncs.Add(ObjectFactory.Create<DestFileSyncDescriptor>((IDictionary<string,object>)dataDictionary));
			    }
			    this._EngineMessage = data.TryGetValueSafe<string>("engineMessage");
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

