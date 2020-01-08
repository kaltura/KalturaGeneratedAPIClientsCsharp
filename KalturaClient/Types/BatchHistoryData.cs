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
// Copyright (C) 2006-2020  Kaltura Inc.
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
		public const string SCHEDULER_NAME = "schedulerName";
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
		private string _SchedulerName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int SchedulerId
		{
			get { return _SchedulerId; }
			set 
			{ 
				_SchedulerId = value;
				OnPropertyChanged("SchedulerId");
			}
		}
		[JsonProperty]
		public int WorkerId
		{
			get { return _WorkerId; }
			set 
			{ 
				_WorkerId = value;
				OnPropertyChanged("WorkerId");
			}
		}
		[JsonProperty]
		public int BatchIndex
		{
			get { return _BatchIndex; }
			set 
			{ 
				_BatchIndex = value;
				OnPropertyChanged("BatchIndex");
			}
		}
		[JsonProperty]
		public int TimeStamp
		{
			get { return _TimeStamp; }
			set 
			{ 
				_TimeStamp = value;
				OnPropertyChanged("TimeStamp");
			}
		}
		[JsonProperty]
		public string Message
		{
			get { return _Message; }
			set 
			{ 
				_Message = value;
				OnPropertyChanged("Message");
			}
		}
		[JsonProperty]
		public int ErrType
		{
			get { return _ErrType; }
			set 
			{ 
				_ErrType = value;
				OnPropertyChanged("ErrType");
			}
		}
		[JsonProperty]
		public int ErrNumber
		{
			get { return _ErrNumber; }
			set 
			{ 
				_ErrNumber = value;
				OnPropertyChanged("ErrNumber");
			}
		}
		[JsonProperty]
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
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
		public string SchedulerName
		{
			get { return _SchedulerName; }
			set 
			{ 
				_SchedulerName = value;
				OnPropertyChanged("SchedulerName");
			}
		}
		#endregion

		#region CTor
		public BatchHistoryData()
		{
		}

		public BatchHistoryData(JToken node) : base(node)
		{
			if(node["schedulerId"] != null)
			{
				this._SchedulerId = ParseInt(node["schedulerId"].Value<string>());
			}
			if(node["workerId"] != null)
			{
				this._WorkerId = ParseInt(node["workerId"].Value<string>());
			}
			if(node["batchIndex"] != null)
			{
				this._BatchIndex = ParseInt(node["batchIndex"].Value<string>());
			}
			if(node["timeStamp"] != null)
			{
				this._TimeStamp = ParseInt(node["timeStamp"].Value<string>());
			}
			if(node["message"] != null)
			{
				this._Message = node["message"].Value<string>();
			}
			if(node["errType"] != null)
			{
				this._ErrType = ParseInt(node["errType"].Value<string>());
			}
			if(node["errNumber"] != null)
			{
				this._ErrNumber = ParseInt(node["errNumber"].Value<string>());
			}
			if(node["hostName"] != null)
			{
				this._HostName = node["hostName"].Value<string>();
			}
			if(node["sessionId"] != null)
			{
				this._SessionId = node["sessionId"].Value<string>();
			}
			if(node["schedulerName"] != null)
			{
				this._SchedulerName = node["schedulerName"].Value<string>();
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
			kparams.AddIfNotNull("schedulerName", this._SchedulerName);
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
				case SCHEDULER_NAME:
					return "SchedulerName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

