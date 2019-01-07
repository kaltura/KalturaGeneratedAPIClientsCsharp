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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class LiveStatsEvent : ObjectBase
	{
		#region Constants
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string EVENT_TYPE = "eventType";
		public const string SESSION_ID = "sessionId";
		public const string EVENT_INDEX = "eventIndex";
		public const string BUFFER_TIME = "bufferTime";
		public const string BITRATE = "bitrate";
		public const string REFERRER = "referrer";
		public const string IS_LIVE = "isLive";
		public const string START_TIME = "startTime";
		public const string DELIVERY_TYPE = "deliveryType";
		#endregion

		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private LiveStatsEventType _EventType = (LiveStatsEventType)Int32.MinValue;
		private string _SessionId = null;
		private int _EventIndex = Int32.MinValue;
		private int _BufferTime = Int32.MinValue;
		private int _Bitrate = Int32.MinValue;
		private string _Referrer = null;
		private bool? _IsLive = null;
		private string _StartTime = null;
		private PlaybackProtocol _DeliveryType = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public LiveStatsEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		[JsonProperty]
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
			}
		}
		[JsonProperty]
		public int EventIndex
		{
			get { return _EventIndex; }
			set 
			{ 
				_EventIndex = value;
				OnPropertyChanged("EventIndex");
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
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		[JsonProperty]
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		[JsonProperty]
		public bool? IsLive
		{
			get { return _IsLive; }
			set 
			{ 
				_IsLive = value;
				OnPropertyChanged("IsLive");
			}
		}
		[JsonProperty]
		public string StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		[JsonProperty]
		public PlaybackProtocol DeliveryType
		{
			get { return _DeliveryType; }
			set 
			{ 
				_DeliveryType = value;
				OnPropertyChanged("DeliveryType");
			}
		}
		#endregion

		#region CTor
		public LiveStatsEvent()
		{
		}

		public LiveStatsEvent(JToken node) : base(node)
		{
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["eventType"] != null)
			{
				this._EventType = (LiveStatsEventType)ParseEnum(typeof(LiveStatsEventType), node["eventType"].Value<string>());
			}
			if(node["sessionId"] != null)
			{
				this._SessionId = node["sessionId"].Value<string>();
			}
			if(node["eventIndex"] != null)
			{
				this._EventIndex = ParseInt(node["eventIndex"].Value<string>());
			}
			if(node["bufferTime"] != null)
			{
				this._BufferTime = ParseInt(node["bufferTime"].Value<string>());
			}
			if(node["bitrate"] != null)
			{
				this._Bitrate = ParseInt(node["bitrate"].Value<string>());
			}
			if(node["referrer"] != null)
			{
				this._Referrer = node["referrer"].Value<string>();
			}
			if(node["isLive"] != null)
			{
				this._IsLive = ParseBool(node["isLive"].Value<string>());
			}
			if(node["startTime"] != null)
			{
				this._StartTime = node["startTime"].Value<string>();
			}
			if(node["deliveryType"] != null)
			{
				this._DeliveryType = (PlaybackProtocol)StringEnum.Parse(typeof(PlaybackProtocol), node["deliveryType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStatsEvent");
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("eventType", this._EventType);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			kparams.AddIfNotNull("eventIndex", this._EventIndex);
			kparams.AddIfNotNull("bufferTime", this._BufferTime);
			kparams.AddIfNotNull("bitrate", this._Bitrate);
			kparams.AddIfNotNull("referrer", this._Referrer);
			kparams.AddIfNotNull("isLive", this._IsLive);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("deliveryType", this._DeliveryType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case EVENT_TYPE:
					return "EventType";
				case SESSION_ID:
					return "SessionId";
				case EVENT_INDEX:
					return "EventIndex";
				case BUFFER_TIME:
					return "BufferTime";
				case BITRATE:
					return "Bitrate";
				case REFERRER:
					return "Referrer";
				case IS_LIVE:
					return "IsLive";
				case START_TIME:
					return "StartTime";
				case DELIVERY_TYPE:
					return "DeliveryType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

