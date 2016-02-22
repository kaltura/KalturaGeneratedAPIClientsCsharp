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
	public class KalturaBatchHistoryData : KalturaObjectBase
	{
		#region Private Fields
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
		private int _BatchIndex = Int32.MinValue;
		private int _TimeStamp = Int32.MinValue;
		private string _Message = null;
		private int _ErrType = Int32.MinValue;
		private int _ErrNumber = Int32.MinValue;
		private string _HostName = null;
		private string _SessionId = null;
		#endregion

		#region Properties
		public int SchedulerId
		{
			get { return _SchedulerId; }
			set 
			{ 
				_SchedulerId = value;
				OnPropertyChanged("SchedulerId");
			}
		}
		public int WorkerId
		{
			get { return _WorkerId; }
			set 
			{ 
				_WorkerId = value;
				OnPropertyChanged("WorkerId");
			}
		}
		public int BatchIndex
		{
			get { return _BatchIndex; }
			set 
			{ 
				_BatchIndex = value;
				OnPropertyChanged("BatchIndex");
			}
		}
		public int TimeStamp
		{
			get { return _TimeStamp; }
			set 
			{ 
				_TimeStamp = value;
				OnPropertyChanged("TimeStamp");
			}
		}
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		public int ErrType
		{
			get { return _ErrType; }
			set 
			{ 
				_ErrType = value;
				OnPropertyChanged("ErrType");
			}
		}
		public int ErrNumber
		{
			get { return _ErrNumber; }
			set 
			{ 
				_ErrNumber = value;
				OnPropertyChanged("ErrNumber");
			}
		}
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
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
		#endregion

		#region CTor
		public KalturaBatchHistoryData()
		{
		}

		public KalturaBatchHistoryData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "batchIndex":
						this.BatchIndex = ParseInt(txt);
						continue;
					case "timeStamp":
						this.TimeStamp = ParseInt(txt);
						continue;
					case "message":
						this.Message = txt;
						continue;
					case "errType":
						this.ErrType = ParseInt(txt);
						continue;
					case "errNumber":
						this.ErrNumber = ParseInt(txt);
						continue;
					case "hostName":
						this.HostName = txt;
						continue;
					case "sessionId":
						this.SessionId = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBatchHistoryData");
			kparams.AddIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIfNotNull("workerId", this.WorkerId);
			kparams.AddIfNotNull("batchIndex", this.BatchIndex);
			kparams.AddIfNotNull("timeStamp", this.TimeStamp);
			kparams.AddIfNotNull("message", this.Message);
			kparams.AddIfNotNull("errType", this.ErrType);
			kparams.AddIfNotNull("errNumber", this.ErrNumber);
			kparams.AddIfNotNull("hostName", this.HostName);
			kparams.AddIfNotNull("sessionId", this.SessionId);
			return kparams;
		}
		#endregion
	}
}

