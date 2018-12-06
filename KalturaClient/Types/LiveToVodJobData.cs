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
		private float _TotalVodDuration = Single.MinValue;
		private float _LastSegmentDuration = Single.MinValue;
		private string _AmfArray = null;
		private int _LastCuePointSyncTime = Int32.MinValue;
		private int _LastSegmentDrift = Int32.MinValue;
		#endregion

		#region Properties
		public string VodEntryId
		{
			get { return _VodEntryId; }
			set 
			{ 
				_VodEntryId = value;
				OnPropertyChanged("VodEntryId");
			}
		}
		public string LiveEntryId
		{
			get { return _LiveEntryId; }
			set 
			{ 
				_LiveEntryId = value;
				OnPropertyChanged("LiveEntryId");
			}
		}
		public float TotalVodDuration
		{
			get { return _TotalVodDuration; }
			set 
			{ 
				_TotalVodDuration = value;
				OnPropertyChanged("TotalVodDuration");
			}
		}
		public float LastSegmentDuration
		{
			get { return _LastSegmentDuration; }
			set 
			{ 
				_LastSegmentDuration = value;
				OnPropertyChanged("LastSegmentDuration");
			}
		}
		public string AmfArray
		{
			get { return _AmfArray; }
			set 
			{ 
				_AmfArray = value;
				OnPropertyChanged("AmfArray");
			}
		}
		public int LastCuePointSyncTime
		{
			get { return _LastCuePointSyncTime; }
			set 
			{ 
				_LastCuePointSyncTime = value;
				OnPropertyChanged("LastCuePointSyncTime");
			}
		}
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

		public LiveToVodJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "vodEntryId":
						this._VodEntryId = propertyNode.InnerText;
						continue;
					case "liveEntryId":
						this._LiveEntryId = propertyNode.InnerText;
						continue;
					case "totalVodDuration":
						this._TotalVodDuration = ParseFloat(propertyNode.InnerText);
						continue;
					case "lastSegmentDuration":
						this._LastSegmentDuration = ParseFloat(propertyNode.InnerText);
						continue;
					case "amfArray":
						this._AmfArray = propertyNode.InnerText;
						continue;
					case "lastCuePointSyncTime":
						this._LastCuePointSyncTime = ParseInt(propertyNode.InnerText);
						continue;
					case "lastSegmentDrift":
						this._LastSegmentDrift = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public LiveToVodJobData(IDictionary<string,object> data) : base(data)
		{
			    this._VodEntryId = data.TryGetValueSafe<string>("vodEntryId");
			    this._LiveEntryId = data.TryGetValueSafe<string>("liveEntryId");
			    this._TotalVodDuration = data.TryGetValueSafe<float>("totalVodDuration");
			    this._LastSegmentDuration = data.TryGetValueSafe<float>("lastSegmentDuration");
			    this._AmfArray = data.TryGetValueSafe<string>("amfArray");
			    this._LastCuePointSyncTime = data.TryGetValueSafe<int>("lastCuePointSyncTime");
			    this._LastSegmentDrift = data.TryGetValueSafe<int>("lastSegmentDrift");
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

