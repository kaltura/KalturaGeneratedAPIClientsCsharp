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
		/// <summary>
		/// Use SrcFileSyncLocalPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		/// <summary>
		/// Use ActualSrcFileSyncLocalPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		/// <summary>
		/// Use SrcFileSyncRemoteUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		/// <summary>
		/// Use SrcFileSyncsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SourceFileSyncDescriptor> SrcFileSyncs
		{
			get { return _SrcFileSyncs; }
			set 
			{ 
				_SrcFileSyncs = value;
				OnPropertyChanged("SrcFileSyncs");
			}
		}
		/// <summary>
		/// Use EngineVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
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
		/// Use FlavorParamsOutputAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FlavorParamsOutput FlavorParamsOutput
		{
			get { return _FlavorParamsOutput; }
			set 
			{ 
				_FlavorParamsOutput = value;
				OnPropertyChanged("FlavorParamsOutput");
			}
		}
		/// <summary>
		/// Use MediaInfoIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MediaInfoId
		{
			get { return _MediaInfoId; }
			set 
			{ 
				_MediaInfoId = value;
				OnPropertyChanged("MediaInfoId");
			}
		}
		/// <summary>
		/// Use CurrentOperationSetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CurrentOperationSet
		{
			get { return _CurrentOperationSet; }
			set 
			{ 
				_CurrentOperationSet = value;
				OnPropertyChanged("CurrentOperationSet");
			}
		}
		/// <summary>
		/// Use CurrentOperationIndexAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CurrentOperationIndex
		{
			get { return _CurrentOperationIndex; }
			set 
			{ 
				_CurrentOperationIndex = value;
				OnPropertyChanged("CurrentOperationIndex");
			}
		}
		/// <summary>
		/// Use PluginDataAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public ConvartableJobData(JToken node) : base(node)
		{
			if(node["srcFileSyncLocalPath"] != null)
			{
				this._SrcFileSyncLocalPath = node["srcFileSyncLocalPath"].Value<string>();
			}
			if(node["actualSrcFileSyncLocalPath"] != null)
			{
				this._ActualSrcFileSyncLocalPath = node["actualSrcFileSyncLocalPath"].Value<string>();
			}
			if(node["srcFileSyncRemoteUrl"] != null)
			{
				this._SrcFileSyncRemoteUrl = node["srcFileSyncRemoteUrl"].Value<string>();
			}
			if(node["srcFileSyncs"] != null)
			{
				this._SrcFileSyncs = new List<SourceFileSyncDescriptor>();
				foreach(var arrayNode in node["srcFileSyncs"].Children())
				{
					this._SrcFileSyncs.Add(ObjectFactory.Create<SourceFileSyncDescriptor>(arrayNode));
				}
			}
			if(node["engineVersion"] != null)
			{
				this._EngineVersion = ParseInt(node["engineVersion"].Value<string>());
			}
			if(node["flavorParamsOutputId"] != null)
			{
				this._FlavorParamsOutputId = ParseInt(node["flavorParamsOutputId"].Value<string>());
			}
			if(node["flavorParamsOutput"] != null)
			{
				this._FlavorParamsOutput = ObjectFactory.Create<FlavorParamsOutput>(node["flavorParamsOutput"]);
			}
			if(node["mediaInfoId"] != null)
			{
				this._MediaInfoId = ParseInt(node["mediaInfoId"].Value<string>());
			}
			if(node["currentOperationSet"] != null)
			{
				this._CurrentOperationSet = ParseInt(node["currentOperationSet"].Value<string>());
			}
			if(node["currentOperationIndex"] != null)
			{
				this._CurrentOperationIndex = ParseInt(node["currentOperationIndex"].Value<string>());
			}
			if(node["pluginData"] != null)
			{
				this._PluginData = new List<KeyValue>();
				foreach(var arrayNode in node["pluginData"].Children())
				{
					this._PluginData.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
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

