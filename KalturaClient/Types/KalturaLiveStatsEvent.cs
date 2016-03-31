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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaLiveStatsEvent : KalturaObjectBase
	{
		#region Private Fields
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private KalturaLiveStatsEventType _EventType = (KalturaLiveStatsEventType)Int32.MinValue;
		private string _SessionId = null;
		private int _EventIndex = Int32.MinValue;
		private int _BufferTime = Int32.MinValue;
		private int _Bitrate = Int32.MinValue;
		private string _Referrer = null;
		private bool? _IsLive = null;
		private string _StartTime = null;
		private KalturaPlaybackProtocol _DeliveryType = null;
		#endregion

		#region Properties
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public KalturaLiveStatsEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
			}
		}
		public int EventIndex
		{
			get { return _EventIndex; }
			set 
			{ 
				_EventIndex = value;
				OnPropertyChanged("EventIndex");
			}
		}
		public int BufferTime
		{
			get { return _BufferTime; }
			set 
			{ 
				_BufferTime = value;
				OnPropertyChanged("BufferTime");
			}
		}
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		public bool? IsLive
		{
			get { return _IsLive; }
			set 
			{ 
				_IsLive = value;
				OnPropertyChanged("IsLive");
			}
		}
		public string StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public KalturaPlaybackProtocol DeliveryType
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
		public KalturaLiveStatsEvent()
		{
		}

		public KalturaLiveStatsEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "eventType":
						this.EventType = (KalturaLiveStatsEventType)ParseEnum(typeof(KalturaLiveStatsEventType), txt);
						continue;
					case "sessionId":
						this.SessionId = txt;
						continue;
					case "eventIndex":
						this.EventIndex = ParseInt(txt);
						continue;
					case "bufferTime":
						this.BufferTime = ParseInt(txt);
						continue;
					case "bitrate":
						this.Bitrate = ParseInt(txt);
						continue;
					case "referrer":
						this.Referrer = txt;
						continue;
					case "isLive":
						this.IsLive = ParseBool(txt);
						continue;
					case "startTime":
						this.StartTime = txt;
						continue;
					case "deliveryType":
						this.DeliveryType = (KalturaPlaybackProtocol)KalturaStringEnum.Parse(typeof(KalturaPlaybackProtocol), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStatsEvent");
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("eventType", this.EventType);
			kparams.AddIfNotNull("sessionId", this.SessionId);
			kparams.AddIfNotNull("eventIndex", this.EventIndex);
			kparams.AddIfNotNull("bufferTime", this.BufferTime);
			kparams.AddIfNotNull("bitrate", this.Bitrate);
			kparams.AddIfNotNull("referrer", this.Referrer);
			kparams.AddIfNotNull("isLive", this.IsLive);
			kparams.AddIfNotNull("startTime", this.StartTime);
			kparams.AddIfNotNull("deliveryType", this.DeliveryType);
			return kparams;
		}
		#endregion
	}
}

