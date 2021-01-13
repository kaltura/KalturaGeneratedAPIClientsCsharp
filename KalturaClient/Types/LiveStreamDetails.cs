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
	public class LiveStreamDetails : ObjectBase
	{
		#region Constants
		public const string PRIMARY_STREAM_STATUS = "primaryStreamStatus";
		public const string SECONDARY_STREAM_STATUS = "secondaryStreamStatus";
		public const string VIEW_MODE = "viewMode";
		public const string WAS_BROADCAST = "wasBroadcast";
		public const string BROADCAST_STATUS = "broadcastStatus";
		#endregion

		#region Private Fields
		private EntryServerNodeStatus _PrimaryStreamStatus = (EntryServerNodeStatus)Int32.MinValue;
		private EntryServerNodeStatus _SecondaryStreamStatus = (EntryServerNodeStatus)Int32.MinValue;
		private ViewMode _ViewMode = (ViewMode)Int32.MinValue;
		private bool? _WasBroadcast = null;
		private LiveStreamBroadcastStatus _BroadcastStatus = (LiveStreamBroadcastStatus)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public EntryServerNodeStatus PrimaryStreamStatus
		{
			get { return _PrimaryStreamStatus; }
			set 
			{ 
				_PrimaryStreamStatus = value;
				OnPropertyChanged("PrimaryStreamStatus");
			}
		}
		[JsonProperty]
		public EntryServerNodeStatus SecondaryStreamStatus
		{
			get { return _SecondaryStreamStatus; }
			set 
			{ 
				_SecondaryStreamStatus = value;
				OnPropertyChanged("SecondaryStreamStatus");
			}
		}
		[JsonProperty]
		public ViewMode ViewMode
		{
			get { return _ViewMode; }
			set 
			{ 
				_ViewMode = value;
				OnPropertyChanged("ViewMode");
			}
		}
		[JsonProperty]
		public bool? WasBroadcast
		{
			get { return _WasBroadcast; }
			set 
			{ 
				_WasBroadcast = value;
				OnPropertyChanged("WasBroadcast");
			}
		}
		[JsonProperty]
		public LiveStreamBroadcastStatus BroadcastStatus
		{
			get { return _BroadcastStatus; }
			set 
			{ 
				_BroadcastStatus = value;
				OnPropertyChanged("BroadcastStatus");
			}
		}
		#endregion

		#region CTor
		public LiveStreamDetails()
		{
		}

		public LiveStreamDetails(JToken node) : base(node)
		{
			if(node["primaryStreamStatus"] != null)
			{
				this._PrimaryStreamStatus = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), node["primaryStreamStatus"].Value<string>());
			}
			if(node["secondaryStreamStatus"] != null)
			{
				this._SecondaryStreamStatus = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), node["secondaryStreamStatus"].Value<string>());
			}
			if(node["viewMode"] != null)
			{
				this._ViewMode = (ViewMode)ParseEnum(typeof(ViewMode), node["viewMode"].Value<string>());
			}
			if(node["wasBroadcast"] != null)
			{
				this._WasBroadcast = ParseBool(node["wasBroadcast"].Value<string>());
			}
			if(node["broadcastStatus"] != null)
			{
				this._BroadcastStatus = (LiveStreamBroadcastStatus)ParseEnum(typeof(LiveStreamBroadcastStatus), node["broadcastStatus"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamDetails");
			kparams.AddIfNotNull("primaryStreamStatus", this._PrimaryStreamStatus);
			kparams.AddIfNotNull("secondaryStreamStatus", this._SecondaryStreamStatus);
			kparams.AddIfNotNull("viewMode", this._ViewMode);
			kparams.AddIfNotNull("wasBroadcast", this._WasBroadcast);
			kparams.AddIfNotNull("broadcastStatus", this._BroadcastStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRIMARY_STREAM_STATUS:
					return "PrimaryStreamStatus";
				case SECONDARY_STREAM_STATUS:
					return "SecondaryStreamStatus";
				case VIEW_MODE:
					return "ViewMode";
				case WAS_BROADCAST:
					return "WasBroadcast";
				case BROADCAST_STATUS:
					return "BroadcastStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

