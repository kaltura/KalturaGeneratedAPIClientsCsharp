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
	public class LiveToVodJobData : JobData
	{
		#region Constants
		public const string VOD_ENTRY_ID = "vodEntryId";
		public const string LIVE_ENTRY_ID = "liveEntryId";
		public const string TOTAL_VOD_DURATION = "totalVodDuration";
		public const string LAST_SEGMENT_DURATION = "lastSegmentDuration";
		public const string AMF_ARRAY = "amfArray";
		public const string LAST_CUE_POINT_SYNC_TIME = "lastCuePointSyncTime";
		public const string LAST_SEGMENT_DRIFT = "lastSegmentDrift";
		#endregion

		#region Private Fields
		private string _VodEntryId = null;
		private string _LiveEntryId = null;
		private double _TotalVodDuration = Double.MinValue;
		private double _LastSegmentDuration = Double.MinValue;
		private string _AmfArray = null;
		private int _LastCuePointSyncTime = Int32.MinValue;
		private int _LastSegmentDrift = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use VodEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VodEntryId
		{
			get { return _VodEntryId; }
			set 
			{ 
				_VodEntryId = value;
				OnPropertyChanged("VodEntryId");
			}
		}
		/// <summary>
		/// Use LiveEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LiveEntryId
		{
			get { return _LiveEntryId; }
			set 
			{ 
				_LiveEntryId = value;
				OnPropertyChanged("LiveEntryId");
			}
		}
		/// <summary>
		/// Use TotalVodDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double TotalVodDuration
		{
			get { return _TotalVodDuration; }
			set 
			{ 
				_TotalVodDuration = value;
				OnPropertyChanged("TotalVodDuration");
			}
		}
		/// <summary>
		/// Use LastSegmentDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double LastSegmentDuration
		{
			get { return _LastSegmentDuration; }
			set 
			{ 
				_LastSegmentDuration = value;
				OnPropertyChanged("LastSegmentDuration");
			}
		}
		/// <summary>
		/// Use AmfArrayAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AmfArray
		{
			get { return _AmfArray; }
			set 
			{ 
				_AmfArray = value;
				OnPropertyChanged("AmfArray");
			}
		}
		/// <summary>
		/// Use LastCuePointSyncTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastCuePointSyncTime
		{
			get { return _LastCuePointSyncTime; }
			set 
			{ 
				_LastCuePointSyncTime = value;
				OnPropertyChanged("LastCuePointSyncTime");
			}
		}
		/// <summary>
		/// Use LastSegmentDriftAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastSegmentDrift
		{
			get { return _LastSegmentDrift; }
			set 
			{ 
				_LastSegmentDrift = value;
				OnPropertyChanged("LastSegmentDrift");
			}
		}
		#endregion

		#region CTor
		public LiveToVodJobData()
		{
		}

		public LiveToVodJobData(JToken node) : base(node)
		{
			if(node["vodEntryId"] != null)
			{
				this._VodEntryId = node["vodEntryId"].Value<string>();
			}
			if(node["liveEntryId"] != null)
			{
				this._LiveEntryId = node["liveEntryId"].Value<string>();
			}
			if(node["totalVodDuration"] != null)
			{
				this._TotalVodDuration = ParseDouble(node["totalVodDuration"].Value<string>());
			}
			if(node["lastSegmentDuration"] != null)
			{
				this._LastSegmentDuration = ParseDouble(node["lastSegmentDuration"].Value<string>());
			}
			if(node["amfArray"] != null)
			{
				this._AmfArray = node["amfArray"].Value<string>();
			}
			if(node["lastCuePointSyncTime"] != null)
			{
				this._LastCuePointSyncTime = ParseInt(node["lastCuePointSyncTime"].Value<string>());
			}
			if(node["lastSegmentDrift"] != null)
			{
				this._LastSegmentDrift = ParseInt(node["lastSegmentDrift"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveToVodJobData");
			kparams.AddIfNotNull("vodEntryId", this._VodEntryId);
			kparams.AddIfNotNull("liveEntryId", this._LiveEntryId);
			kparams.AddIfNotNull("totalVodDuration", this._TotalVodDuration);
			kparams.AddIfNotNull("lastSegmentDuration", this._LastSegmentDuration);
			kparams.AddIfNotNull("amfArray", this._AmfArray);
			kparams.AddIfNotNull("lastCuePointSyncTime", this._LastCuePointSyncTime);
			kparams.AddIfNotNull("lastSegmentDrift", this._LastSegmentDrift);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VOD_ENTRY_ID:
					return "VodEntryId";
				case LIVE_ENTRY_ID:
					return "LiveEntryId";
				case TOTAL_VOD_DURATION:
					return "TotalVodDuration";
				case LAST_SEGMENT_DURATION:
					return "LastSegmentDuration";
				case AMF_ARRAY:
					return "AmfArray";
				case LAST_CUE_POINT_SYNC_TIME:
					return "LastCuePointSyncTime";
				case LAST_SEGMENT_DRIFT:
					return "LastSegmentDrift";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

