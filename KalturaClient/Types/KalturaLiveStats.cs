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
	public class KalturaLiveStats : KalturaObjectBase
	{
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
		public int Audience
		{
			get { return _Audience; }
			set 
			{ 
				_Audience = value;
				OnPropertyChanged("Audience");
			}
		}
		public int DvrAudience
		{
			get { return _DvrAudience; }
			set 
			{ 
				_DvrAudience = value;
				OnPropertyChanged("DvrAudience");
			}
		}
		public float AvgBitrate
		{
			get { return _AvgBitrate; }
			set 
			{ 
				_AvgBitrate = value;
				OnPropertyChanged("AvgBitrate");
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
		public int Plays
		{
			get { return _Plays; }
			set 
			{ 
				_Plays = value;
				OnPropertyChanged("Plays");
			}
		}
		public int SecondsViewed
		{
			get { return _SecondsViewed; }
			set 
			{ 
				_SecondsViewed = value;
				OnPropertyChanged("SecondsViewed");
			}
		}
		public long StartEvent
		{
			get { return _StartEvent; }
			set 
			{ 
				_StartEvent = value;
				OnPropertyChanged("StartEvent");
			}
		}
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
		public KalturaLiveStats()
		{
		}

		public KalturaLiveStats(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "audience":
						this.Audience = ParseInt(txt);
						continue;
					case "dvrAudience":
						this.DvrAudience = ParseInt(txt);
						continue;
					case "avgBitrate":
						this.AvgBitrate = ParseFloat(txt);
						continue;
					case "bufferTime":
						this.BufferTime = ParseInt(txt);
						continue;
					case "plays":
						this.Plays = ParseInt(txt);
						continue;
					case "secondsViewed":
						this.SecondsViewed = ParseInt(txt);
						continue;
					case "startEvent":
						this.StartEvent = ParseLong(txt);
						continue;
					case "timestamp":
						this.Timestamp = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStats");
			kparams.AddIfNotNull("audience", this.Audience);
			kparams.AddIfNotNull("dvrAudience", this.DvrAudience);
			kparams.AddIfNotNull("avgBitrate", this.AvgBitrate);
			kparams.AddIfNotNull("bufferTime", this.BufferTime);
			kparams.AddIfNotNull("plays", this.Plays);
			kparams.AddIfNotNull("secondsViewed", this.SecondsViewed);
			kparams.AddIfNotNull("startEvent", this.StartEvent);
			kparams.AddIfNotNull("timestamp", this.Timestamp);
			return kparams;
		}
		#endregion
	}
}

