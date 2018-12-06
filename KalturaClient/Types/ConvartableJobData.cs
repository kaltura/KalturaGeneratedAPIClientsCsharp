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
	public class ConvartableJobData : JobData
	{
		#region Constants
		public const string SRC_FILE_SYNC_LOCAL_PATH = "srcFileSyncLocalPath";
		public const string ACTUAL_SRC_FILE_SYNC_LOCAL_PATH = "actualSrcFileSyncLocalPath";
		public const string SRC_FILE_SYNC_REMOTE_URL = "srcFileSyncRemoteUrl";
		public const string SRC_FILE_SYNCS = "srcFileSyncs";
		public const string ENGINE_VERSION = "engineVersion";
		public const string FLAVOR_PARAMS_OUTPUT_ID = "flavorParamsOutputId";
		public const string FLAVOR_PARAMS_OUTPUT = "flavorParamsOutput";
		public const string MEDIA_INFO_ID = "mediaInfoId";
		public const string CURRENT_OPERATION_SET = "currentOperationSet";
		public const string CURRENT_OPERATION_INDEX = "currentOperationIndex";
		public const string PLUGIN_DATA = "pluginData";
		#endregion

		#region Private Fields
		private string _SrcFileSyncLocalPath = null;
		private string _ActualSrcFileSyncLocalPath = null;
		private string _SrcFileSyncRemoteUrl = null;
		private IList<SourceFileSyncDescriptor> _SrcFileSyncs;
		private int _EngineVersion = Int32.MinValue;
		private int _FlavorParamsOutputId = Int32.MinValue;
		private FlavorParamsOutput _FlavorParamsOutput;
		private int _MediaInfoId = Int32.MinValue;
		private int _CurrentOperationSet = Int32.MinValue;
		private int _CurrentOperationIndex = Int32.MinValue;
		private IList<KeyValue> _PluginData;
		#endregion

		#region Properties
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		public IList<SourceFileSyncDescriptor> SrcFileSyncs
		{
			get { return _SrcFileSyncs; }
			set 
			{ 
				_SrcFileSyncs = value;
				OnPropertyChanged("SrcFileSyncs");
			}
		}
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
			}
		}
		public int FlavorParamsOutputId
		{
			get { return _FlavorParamsOutputId; }
			set 
			{ 
				_FlavorParamsOutputId = value;
				OnPropertyChanged("FlavorParamsOutputId");
			}
		}
		public FlavorParamsOutput FlavorParamsOutput
		{
			get { return _FlavorParamsOutput; }
			set 
			{ 
				_FlavorParamsOutput = value;
				OnPropertyChanged("FlavorParamsOutput");
			}
		}
		public int MediaInfoId
		{
			get { return _MediaInfoId; }
			set 
			{ 
				_MediaInfoId = value;
				OnPropertyChanged("MediaInfoId");
			}
		}
		public int CurrentOperationSet
		{
			get { return _CurrentOperationSet; }
			set 
			{ 
				_CurrentOperationSet = value;
				OnPropertyChanged("CurrentOperationSet");
			}
		}
		public int CurrentOperationIndex
		{
			get { return _CurrentOperationIndex; }
			set 
			{ 
				_CurrentOperationIndex = value;
				OnPropertyChanged("CurrentOperationIndex");
			}
		}
		public IList<KeyValue> PluginData
		{
			get { return _PluginData; }
			set 
			{ 
				_PluginData = value;
				OnPropertyChanged("PluginData");
			}
		}
		#endregion

		#region CTor
		public ConvartableJobData()
		{
		}

		public ConvartableJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcFileSyncLocalPath":
						this._SrcFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "actualSrcFileSyncLocalPath":
						this._ActualSrcFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "srcFileSyncRemoteUrl":
						this._SrcFileSyncRemoteUrl = propertyNode.InnerText;
						continue;
					case "srcFileSyncs":
						this._SrcFileSyncs = new List<SourceFileSyncDescriptor>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._SrcFileSyncs.Add(ObjectFactory.Create<SourceFileSyncDescriptor>(arrayNode));
						}
						continue;
					case "engineVersion":
						this._EngineVersion = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamsOutputId":
						this._FlavorParamsOutputId = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamsOutput":
						this._FlavorParamsOutput = ObjectFactory.Create<FlavorParamsOutput>(propertyNode);
						continue;
					case "mediaInfoId":
						this._MediaInfoId = ParseInt(propertyNode.InnerText);
						continue;
					case "currentOperationSet":
						this._CurrentOperationSet = ParseInt(propertyNode.InnerText);
						continue;
					case "currentOperationIndex":
						this._CurrentOperationIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "pluginData":
						this._PluginData = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._PluginData.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
				}
			}
		}

		public ConvartableJobData(IDictionary<string,object> data) : base(data)
		{
			    this._SrcFileSyncLocalPath = data.TryGetValueSafe<string>("srcFileSyncLocalPath");
			    this._ActualSrcFileSyncLocalPath = data.TryGetValueSafe<string>("actualSrcFileSyncLocalPath");
			    this._SrcFileSyncRemoteUrl = data.TryGetValueSafe<string>("srcFileSyncRemoteUrl");
			    this._SrcFileSyncs = new List<SourceFileSyncDescriptor>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("srcFileSyncs", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._SrcFileSyncs.Add(ObjectFactory.Create<SourceFileSyncDescriptor>((IDictionary<string,object>)dataDictionary));
			    }
			    this._EngineVersion = data.TryGetValueSafe<int>("engineVersion");
			    this._FlavorParamsOutputId = data.TryGetValueSafe<int>("flavorParamsOutputId");
			    this._FlavorParamsOutput = ObjectFactory.Create<FlavorParamsOutput>(data.TryGetValueSafe<IDictionary<string,object>>("flavorParamsOutput"));
			    this._MediaInfoId = data.TryGetValueSafe<int>("mediaInfoId");
			    this._CurrentOperationSet = data.TryGetValueSafe<int>("currentOperationSet");
			    this._CurrentOperationIndex = data.TryGetValueSafe<int>("currentOperationIndex");
			    this._PluginData = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("pluginData", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._PluginData.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
			    }
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvartableJobData");
			kparams.AddIfNotNull("srcFileSyncLocalPath", this._SrcFileSyncLocalPath);
			kparams.AddIfNotNull("actualSrcFileSyncLocalPath", this._ActualSrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileSyncRemoteUrl", this._SrcFileSyncRemoteUrl);
			kparams.AddIfNotNull("srcFileSyncs", this._SrcFileSyncs);
			kparams.AddIfNotNull("engineVersion", this._EngineVersion);
			kparams.AddIfNotNull("flavorParamsOutputId", this._FlavorParamsOutputId);
			kparams.AddIfNotNull("flavorParamsOutput", this._FlavorParamsOutput);
			kparams.AddIfNotNull("mediaInfoId", this._MediaInfoId);
			kparams.AddIfNotNull("currentOperationSet", this._CurrentOperationSet);
			kparams.AddIfNotNull("currentOperationIndex", this._CurrentOperationIndex);
			kparams.AddIfNotNull("pluginData", this._PluginData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILE_SYNC_LOCAL_PATH:
					return "SrcFileSyncLocalPath";
				case ACTUAL_SRC_FILE_SYNC_LOCAL_PATH:
					return "ActualSrcFileSyncLocalPath";
				case SRC_FILE_SYNC_REMOTE_URL:
					return "SrcFileSyncRemoteUrl";
				case SRC_FILE_SYNCS:
					return "SrcFileSyncs";
				case ENGINE_VERSION:
					return "EngineVersion";
				case FLAVOR_PARAMS_OUTPUT_ID:
					return "FlavorParamsOutputId";
				case FLAVOR_PARAMS_OUTPUT:
					return "FlavorParamsOutput";
				case MEDIA_INFO_ID:
					return "MediaInfoId";
				case CURRENT_OPERATION_SET:
					return "CurrentOperationSet";
				case CURRENT_OPERATION_INDEX:
					return "CurrentOperationIndex";
				case PLUGIN_DATA:
					return "PluginData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

