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
	public class WidevineRepositorySyncJobData : JobData
	{
		#region Constants
		public const string SYNC_MODE = "syncMode";
		public const string WV_ASSET_IDS = "wvAssetIds";
		public const string MODIFIED_ATTRIBUTES = "modifiedAttributes";
		public const string MONITOR_SYNC_COMPLETION = "monitorSyncCompletion";
		#endregion

		#region Private Fields
		private WidevineRepositorySyncMode _SyncMode = (WidevineRepositorySyncMode)Int32.MinValue;
		private string _WvAssetIds = null;
		private string _ModifiedAttributes = null;
		private int _MonitorSyncCompletion = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use SyncModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public WidevineRepositorySyncMode SyncMode
		{
			get { return _SyncMode; }
			set 
			{ 
				_SyncMode = value;
				OnPropertyChanged("SyncMode");
			}
		}
		/// <summary>
		/// Use WvAssetIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string WvAssetIds
		{
			get { return _WvAssetIds; }
			set 
			{ 
				_WvAssetIds = value;
				OnPropertyChanged("WvAssetIds");
			}
		}
		/// <summary>
		/// Use ModifiedAttributesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ModifiedAttributes
		{
			get { return _ModifiedAttributes; }
			set 
			{ 
				_ModifiedAttributes = value;
				OnPropertyChanged("ModifiedAttributes");
			}
		}
		/// <summary>
		/// Use MonitorSyncCompletionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MonitorSyncCompletion
		{
			get { return _MonitorSyncCompletion; }
			set 
			{ 
				_MonitorSyncCompletion = value;
				OnPropertyChanged("MonitorSyncCompletion");
			}
		}
		#endregion

		#region CTor
		public WidevineRepositorySyncJobData()
		{
		}

		public WidevineRepositorySyncJobData(JToken node) : base(node)
		{
			if(node["syncMode"] != null)
			{
				this._SyncMode = (WidevineRepositorySyncMode)ParseEnum(typeof(WidevineRepositorySyncMode), node["syncMode"].Value<string>());
			}
			if(node["wvAssetIds"] != null)
			{
				this._WvAssetIds = node["wvAssetIds"].Value<string>();
			}
			if(node["modifiedAttributes"] != null)
			{
				this._ModifiedAttributes = node["modifiedAttributes"].Value<string>();
			}
			if(node["monitorSyncCompletion"] != null)
			{
				this._MonitorSyncCompletion = ParseInt(node["monitorSyncCompletion"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWidevineRepositorySyncJobData");
			kparams.AddIfNotNull("syncMode", this._SyncMode);
			kparams.AddIfNotNull("wvAssetIds", this._WvAssetIds);
			kparams.AddIfNotNull("modifiedAttributes", this._ModifiedAttributes);
			kparams.AddIfNotNull("monitorSyncCompletion", this._MonitorSyncCompletion);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SYNC_MODE:
					return "SyncMode";
				case WV_ASSET_IDS:
					return "WvAssetIds";
				case MODIFIED_ATTRIBUTES:
					return "ModifiedAttributes";
				case MONITOR_SYNC_COMPLETION:
					return "MonitorSyncCompletion";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

