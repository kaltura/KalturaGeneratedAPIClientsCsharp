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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class LiveStats : ObjectBase
	{
		#region Constants
		public const string AUDIENCE = "audience";
		public const string DVR_AUDIENCE = "dvrAudience";
		public const string AVG_BITRATE = "avgBitrate";
		public const string BUFFER_TIME = "bufferTime";
		public const string PLAYS = "plays";
		public const string SECONDS_VIEWED = "secondsViewed";
		public const string START_EVENT = "startEvent";
		public const string TIMESTAMP = "timestamp";
		#endregion

		#region Private Fields
		private int _Audience = Int32.MinValue;
		private int _DvrAudience = Int32.MinValue;
		private float _AvgBitrate = Single.MinValue;
		private int _BufferTime = Int32.MinValue;
		private int _Plays = Int32.MinValue;
		private int _SecondsViewed = Int32.MinValue;
		private long _StartEvent = long.MinValue;
		private int _Timestamp = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int Audience
		{
			get { return _Audience; }
			set 
			{ 
				_Audience = value;
				OnPropertyChanged("Audience");
			}
		}
		[JsonProperty]
		public int DvrAudience
		{
			get { return _DvrAudience; }
			set 
			{ 
				_DvrAudience = value;
				OnPropertyChanged("DvrAudience");
			}
		}
		[JsonProperty]
		public float AvgBitrate
		{
			get { return _AvgBitrate; }
			set 
			{ 
				_AvgBitrate = value;
				OnPropertyChanged("AvgBitrate");
			}
		}
		[JsonProperty]
		public int BufferTime
		{
			get { return _BufferTime; }
			set 
			{ 
				_BufferTime = value;
				OnPropertyChanged("BufferTime");
			}
		}
		[JsonProperty]
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		[JsonProperty]
		public int SecondsViewed
		{
			get { return _SecondsViewed; }
			set 
			{ 
				_SecondsViewed = value;
				OnPropertyChanged("SecondsViewed");
			}
		}
		[JsonProperty]
		public long StartEvent
		{
			get { return _StartEvent; }
			set 
			{ 
				_StartEvent = value;
				OnPropertyChanged("StartEvent");
			}
		}
		[JsonProperty]
		public int Timestamp
		{
			get { return _Timestamp; }
			set 
			{ 
				_Timestamp = value;
				OnPropertyChanged("Timestamp");
			}
		}
		#endregion

		#region CTor
		public LiveStats()
		{
		}

		public LiveStats(JToken node) : base(node)
		{
			if(node["audience"] != null)
			{
				this._Audience = ParseInt(node["audience"].Value<string>());
			}
			if(node["dvrAudience"] != null)
			{
				this._DvrAudience = ParseInt(node["dvrAudience"].Value<string>());
			}
			if(node["avgBitrate"] != null)
			{
				this._AvgBitrate = ParseFloat(node["avgBitrate"].Value<string>());
			}
			if(node["bufferTime"] != null)
			{
				this._BufferTime = ParseInt(node["bufferTime"].Value<string>());
			}
			if(node["plays"] != null)
			{
				this._Plays = ParseInt(node["plays"].Value<string>());
			}
			if(node["secondsViewed"] != null)
			{
				this._SecondsViewed = ParseInt(node["secondsViewed"].Value<string>());
			}
			if(node["startEvent"] != null)
			{
				this._StartEvent = ParseLong(node["startEvent"].Value<string>());
			}
			if(node["timestamp"] != null)
			{
				this._Timestamp = ParseInt(node["timestamp"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStats");
			kparams.AddIfNotNull("audience", this._Audience);
			kparams.AddIfNotNull("dvrAudience", this._DvrAudience);
			kparams.AddIfNotNull("avgBitrate", this._AvgBitrate);
			kparams.AddIfNotNull("bufferTime", this._BufferTime);
			kparams.AddIfNotNull("plays", this._Plays);
			kparams.AddIfNotNull("secondsViewed", this._SecondsViewed);
			kparams.AddIfNotNull("startEvent", this._StartEvent);
			kparams.AddIfNotNull("timestamp", this._Timestamp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case AUDIENCE:
					return "Audience";
				case DVR_AUDIENCE:
					return "DvrAudience";
				case AVG_BITRATE:
					return "AvgBitrate";
				case BUFFER_TIME:
					return "BufferTime";
				case PLAYS:
					return "Plays";
				case SECONDS_VIEWED:
					return "SecondsViewed";
				case START_EVENT:
					return "StartEvent";
				case TIMESTAMP:
					return "Timestamp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

