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
	public class BatchHistoryData : ObjectBase
	{
		#region Constants
		public const string SCHEDULER_ID = "schedulerId";
		public const string WORKER_ID = "workerId";
		public const string BATCH_INDEX = "batchIndex";
		public const string TIME_STAMP = "timeStamp";
		public const string MESSAGE = "message";
		public const string ERR_TYPE = "errType";
		public const string ERR_NUMBER = "errNumber";
		public const string HOST_NAME = "hostName";
		public const string SESSION_ID = "sessionId";
		#endregion

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
		public BatchHistoryData()
		{
		}

		public BatchHistoryData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "schedulerId":
						this._SchedulerId = ParseInt(propertyNode.InnerText);
						continue;
					case "workerId":
						this._WorkerId = ParseInt(propertyNode.InnerText);
						continue;
					case "batchIndex":
						this._BatchIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "timeStamp":
						this._TimeStamp = ParseInt(propertyNode.InnerText);
						continue;
					case "message":
						this._Message = propertyNode.InnerText;
						continue;
					case "errType":
						this._ErrType = ParseInt(propertyNode.InnerText);
						continue;
					case "errNumber":
						this._ErrNumber = ParseInt(propertyNode.InnerText);
						continue;
					case "hostName":
						this._HostName = propertyNode.InnerText;
						continue;
					case "sessionId":
						this._SessionId = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaBatchHistoryData");
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("workerId", this._WorkerId);
			kparams.AddIfNotNull("batchIndex", this._BatchIndex);
			kparams.AddIfNotNull("timeStamp", this._TimeStamp);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("errType", this._ErrType);
			kparams.AddIfNotNull("errNumber", this._ErrNumber);
			kparams.AddIfNotNull("hostName", this._HostName);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SCHEDULER_ID:
					return "SchedulerId";
				case WORKER_ID:
					return "WorkerId";
				case BATCH_INDEX:
					return "BatchIndex";
				case TIME_STAMP:
					return "TimeStamp";
				case MESSAGE:
					return "Message";
				case ERR_TYPE:
					return "ErrType";
				case ERR_NUMBER:
					return "ErrNumber";
				case HOST_NAME:
					return "HostName";
				case SESSION_ID:
					return "SessionId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

