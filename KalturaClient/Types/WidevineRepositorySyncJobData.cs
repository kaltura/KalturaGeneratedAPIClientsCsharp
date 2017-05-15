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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public WidevineRepositorySyncMode SyncMode
		{
			get { return _SyncMode; }
			set 
			{ 
				_SyncMode = value;
				OnPropertyChanged("SyncMode");
			}
		}
		public string WvAssetIds
		{
			get { return _WvAssetIds; }
			set 
			{ 
				_WvAssetIds = value;
				OnPropertyChanged("WvAssetIds");
			}
		}
		public string ModifiedAttributes
		{
			get { return _ModifiedAttributes; }
			set 
			{ 
				_ModifiedAttributes = value;
				OnPropertyChanged("ModifiedAttributes");
			}
		}
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

		public WidevineRepositorySyncJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "syncMode":
						this._SyncMode = (WidevineRepositorySyncMode)ParseEnum(typeof(WidevineRepositorySyncMode), propertyNode.InnerText);
						continue;
					case "wvAssetIds":
						this._WvAssetIds = propertyNode.InnerText;
						continue;
					case "modifiedAttributes":
						this._ModifiedAttributes = propertyNode.InnerText;
						continue;
					case "monitorSyncCompletion":
						this._MonitorSyncCompletion = ParseInt(propertyNode.InnerText);
						continue;
				}
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

