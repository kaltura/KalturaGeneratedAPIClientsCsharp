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
	public class BatchJob : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string DELETED_AT = "deletedAt";
		public const string LOCK_EXPIRATION = "lockExpiration";
		public const string EXECUTION_ATTEMPTS = "executionAttempts";
		public const string LOCK_VERSION = "lockVersion";
		public const string ENTRY_ID = "entryId";
		public const string ENTRY_NAME = "entryName";
		public const string JOB_TYPE = "jobType";
		public const string JOB_SUB_TYPE = "jobSubType";
		public const string DATA = "data";
		public const string STATUS = "status";
		public const string ABORT = "abort";
		public const string CHECK_AGAIN_TIMEOUT = "checkAgainTimeout";
		public const string MESSAGE = "message";
		public const string DESCRIPTION = "description";
		public const string PRIORITY = "priority";
		public const string HISTORY = "history";
		public const string BULK_JOB_ID = "bulkJobId";
		public const string BATCH_VERSION = "batchVersion";
		public const string PARENT_JOB_ID = "parentJobId";
		public const string ROOT_JOB_ID = "rootJobId";
		public const string QUEUE_TIME = "queueTime";
		public const string FINISH_TIME = "finishTime";
		public const string ERR_TYPE = "errType";
		public const string ERR_NUMBER = "errNumber";
		public const string ESTIMATED_EFFORT = "estimatedEffort";
		public const string URGENCY = "urgency";
		public const string SCHEDULER_ID = "schedulerId";
		public const string WORKER_ID = "workerId";
		public const string BATCH_INDEX = "batchIndex";
		public const string LAST_SCHEDULER_ID = "lastSchedulerId";
		public const string LAST_WORKER_ID = "lastWorkerId";
		public const string DC = "dc";
		public const string JOB_OBJECT_ID = "jobObjectId";
		public const string JOB_OBJECT_TYPE = "jobObjectType";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private int _LockExpiration = Int32.MinValue;
		private int _ExecutionAttempts = Int32.MinValue;
		private int _LockVersion = Int32.MinValue;
		private string _EntryId = null;
		private string _EntryName = null;
		private BatchJobType _JobType = null;
		private int _JobSubType = Int32.MinValue;
		private JobData _Data;
		private BatchJobStatus _Status = (BatchJobStatus)Int32.MinValue;
		private int _Abort = Int32.MinValue;
		private int _CheckAgainTimeout = Int32.MinValue;
		private string _Message = null;
		private string _Description = null;
		private int _Priority = Int32.MinValue;
		private IList<BatchHistoryData> _History;
		private int _BulkJobId = Int32.MinValue;
		private int _BatchVersion = Int32.MinValue;
		private int _ParentJobId = Int32.MinValue;
		private int _RootJobId = Int32.MinValue;
		private int _QueueTime = Int32.MinValue;
		private int _FinishTime = Int32.MinValue;
		private BatchJobErrorTypes _ErrType = (BatchJobErrorTypes)Int32.MinValue;
		private int _ErrNumber = Int32.MinValue;
		private int _EstimatedEffort = Int32.MinValue;
		private int _Urgency = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
		private int _BatchIndex = Int32.MinValue;
		private int _LastSchedulerId = Int32.MinValue;
		private int _LastWorkerId = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private string _JobObjectId = null;
		private int _JobObjectType = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public int DeletedAt
		{
			get { return _DeletedAt; }
			private set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
		}
		[JsonProperty]
		public int LockExpiration
		{
			get { return _LockExpiration; }
			private set 
			{ 
				_LockExpiration = value;
				OnPropertyChanged("LockExpiration");
			}
		}
		[JsonProperty]
		public int ExecutionAttempts
		{
			get { return _ExecutionAttempts; }
			private set 
			{ 
				_ExecutionAttempts = value;
				OnPropertyChanged("ExecutionAttempts");
			}
		}
		[JsonProperty]
		public int LockVersion
		{
			get { return _LockVersion; }
			private set 
			{ 
				_LockVersion = value;
				OnPropertyChanged("LockVersion");
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
		public string EntryName
		{
			get { return _EntryName; }
			set 
			{ 
				_EntryName = value;
				OnPropertyChanged("EntryName");
			}
		}
		[JsonProperty]
		public BatchJobType JobType
		{
			get { return _JobType; }
			private set 
			{ 
				_JobType = value;
				OnPropertyChanged("JobType");
			}
		}
		[JsonProperty]
		public int JobSubType
		{
			get { return _JobSubType; }
			set 
			{ 
				_JobSubType = value;
				OnPropertyChanged("JobSubType");
			}
		}
		[JsonProperty]
		public JobData Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		[JsonProperty]
		public BatchJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public int Abort
		{
			get { return _Abort; }
			set 
			{ 
				_Abort = value;
				OnPropertyChanged("Abort");
			}
		}
		[JsonProperty]
		public int CheckAgainTimeout
		{
			get { return _CheckAgainTimeout; }
			set 
			{ 
				_CheckAgainTimeout = value;
				OnPropertyChanged("CheckAgainTimeout");
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		[JsonProperty]
		public IList<BatchHistoryData> History
		{
			get { return _History; }
			set 
			{ 
				_History = value;
				OnPropertyChanged("History");
			}
		}
		[JsonProperty]
		public int BulkJobId
		{
			get { return _BulkJobId; }
			set 
			{ 
				_BulkJobId = value;
				OnPropertyChanged("BulkJobId");
			}
		}
		[JsonProperty]
		public int BatchVersion
		{
			get { return _BatchVersion; }
			set 
			{ 
				_BatchVersion = value;
				OnPropertyChanged("BatchVersion");
			}
		}
		[JsonProperty]
		public int ParentJobId
		{
			get { return _ParentJobId; }
			set 
			{ 
				_ParentJobId = value;
				OnPropertyChanged("ParentJobId");
			}
		}
		[JsonProperty]
		public int RootJobId
		{
			get { return _RootJobId; }
			set 
			{ 
				_RootJobId = value;
				OnPropertyChanged("RootJobId");
			}
		}
		[JsonProperty]
		public int QueueTime
		{
			get { return _QueueTime; }
			set 
			{ 
				_QueueTime = value;
				OnPropertyChanged("QueueTime");
			}
		}
		[JsonProperty]
		public int FinishTime
		{
			get { return _FinishTime; }
			set 
			{ 
				_FinishTime = value;
				OnPropertyChanged("FinishTime");
			}
		}
		[JsonProperty]
		public BatchJobErrorTypes ErrType
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
		public int EstimatedEffort
		{
			get { return _EstimatedEffort; }
			set 
			{ 
				_EstimatedEffort = value;
				OnPropertyChanged("EstimatedEffort");
			}
		}
		[JsonProperty]
		public int Urgency
		{
			get { return _Urgency; }
			set 
			{ 
				_Urgency = value;
				OnPropertyChanged("Urgency");
			}
		}
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
		public int LastSchedulerId
		{
			get { return _LastSchedulerId; }
			set 
			{ 
				_LastSchedulerId = value;
				OnPropertyChanged("LastSchedulerId");
			}
		}
		[JsonProperty]
		public int LastWorkerId
		{
			get { return _LastWorkerId; }
			set 
			{ 
				_LastWorkerId = value;
				OnPropertyChanged("LastWorkerId");
			}
		}
		[JsonProperty]
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		[JsonProperty]
		public string JobObjectId
		{
			get { return _JobObjectId; }
			set 
			{ 
				_JobObjectId = value;
				OnPropertyChanged("JobObjectId");
			}
		}
		[JsonProperty]
		public int JobObjectType
		{
			get { return _JobObjectType; }
			set 
			{ 
				_JobObjectType = value;
				OnPropertyChanged("JobObjectType");
			}
		}
		#endregion

		#region CTor
		public BatchJob()
		{
		}

		public BatchJob(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["deletedAt"] != null)
			{
				this._DeletedAt = ParseInt(node["deletedAt"].Value<string>());
			}
			if(node["lockExpiration"] != null)
			{
				this._LockExpiration = ParseInt(node["lockExpiration"].Value<string>());
			}
			if(node["executionAttempts"] != null)
			{
				this._ExecutionAttempts = ParseInt(node["executionAttempts"].Value<string>());
			}
			if(node["lockVersion"] != null)
			{
				this._LockVersion = ParseInt(node["lockVersion"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["entryName"] != null)
			{
				this._EntryName = node["entryName"].Value<string>();
			}
			if(node["jobType"] != null)
			{
				this._JobType = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), node["jobType"].Value<string>());
			}
			if(node["jobSubType"] != null)
			{
				this._JobSubType = ParseInt(node["jobSubType"].Value<string>());
			}
			if(node["data"] != null)
			{
				this._Data = ObjectFactory.Create<JobData>(node["data"]);
			}
			if(node["status"] != null)
			{
				this._Status = (BatchJobStatus)ParseEnum(typeof(BatchJobStatus), node["status"].Value<string>());
			}
			if(node["abort"] != null)
			{
				this._Abort = ParseInt(node["abort"].Value<string>());
			}
			if(node["checkAgainTimeout"] != null)
			{
				this._CheckAgainTimeout = ParseInt(node["checkAgainTimeout"].Value<string>());
			}
			if(node["message"] != null)
			{
				this._Message = node["message"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["priority"] != null)
			{
				this._Priority = ParseInt(node["priority"].Value<string>());
			}
			if(node["history"] != null)
			{
				this._History = new List<BatchHistoryData>();
				foreach(var arrayNode in node["history"].Children())
				{
					this._History.Add(ObjectFactory.Create<BatchHistoryData>(arrayNode));
				}
			}
			if(node["bulkJobId"] != null)
			{
				this._BulkJobId = ParseInt(node["bulkJobId"].Value<string>());
			}
			if(node["batchVersion"] != null)
			{
				this._BatchVersion = ParseInt(node["batchVersion"].Value<string>());
			}
			if(node["parentJobId"] != null)
			{
				this._ParentJobId = ParseInt(node["parentJobId"].Value<string>());
			}
			if(node["rootJobId"] != null)
			{
				this._RootJobId = ParseInt(node["rootJobId"].Value<string>());
			}
			if(node["queueTime"] != null)
			{
				this._QueueTime = ParseInt(node["queueTime"].Value<string>());
			}
			if(node["finishTime"] != null)
			{
				this._FinishTime = ParseInt(node["finishTime"].Value<string>());
			}
			if(node["errType"] != null)
			{
				this._ErrType = (BatchJobErrorTypes)ParseEnum(typeof(BatchJobErrorTypes), node["errType"].Value<string>());
			}
			if(node["errNumber"] != null)
			{
				this._ErrNumber = ParseInt(node["errNumber"].Value<string>());
			}
			if(node["estimatedEffort"] != null)
			{
				this._EstimatedEffort = ParseInt(node["estimatedEffort"].Value<string>());
			}
			if(node["urgency"] != null)
			{
				this._Urgency = ParseInt(node["urgency"].Value<string>());
			}
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
			if(node["lastSchedulerId"] != null)
			{
				this._LastSchedulerId = ParseInt(node["lastSchedulerId"].Value<string>());
			}
			if(node["lastWorkerId"] != null)
			{
				this._LastWorkerId = ParseInt(node["lastWorkerId"].Value<string>());
			}
			if(node["dc"] != null)
			{
				this._Dc = ParseInt(node["dc"].Value<string>());
			}
			if(node["jobObjectId"] != null)
			{
				this._JobObjectId = node["jobObjectId"].Value<string>();
			}
			if(node["jobObjectType"] != null)
			{
				this._JobObjectType = ParseInt(node["jobObjectType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBatchJob");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("deletedAt", this._DeletedAt);
			kparams.AddIfNotNull("lockExpiration", this._LockExpiration);
			kparams.AddIfNotNull("executionAttempts", this._ExecutionAttempts);
			kparams.AddIfNotNull("lockVersion", this._LockVersion);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("entryName", this._EntryName);
			kparams.AddIfNotNull("jobType", this._JobType);
			kparams.AddIfNotNull("jobSubType", this._JobSubType);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("abort", this._Abort);
			kparams.AddIfNotNull("checkAgainTimeout", this._CheckAgainTimeout);
			kparams.AddIfNotNull("message", this._Message);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("history", this._History);
			kparams.AddIfNotNull("bulkJobId", this._BulkJobId);
			kparams.AddIfNotNull("batchVersion", this._BatchVersion);
			kparams.AddIfNotNull("parentJobId", this._ParentJobId);
			kparams.AddIfNotNull("rootJobId", this._RootJobId);
			kparams.AddIfNotNull("queueTime", this._QueueTime);
			kparams.AddIfNotNull("finishTime", this._FinishTime);
			kparams.AddIfNotNull("errType", this._ErrType);
			kparams.AddIfNotNull("errNumber", this._ErrNumber);
			kparams.AddIfNotNull("estimatedEffort", this._EstimatedEffort);
			kparams.AddIfNotNull("urgency", this._Urgency);
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("workerId", this._WorkerId);
			kparams.AddIfNotNull("batchIndex", this._BatchIndex);
			kparams.AddIfNotNull("lastSchedulerId", this._LastSchedulerId);
			kparams.AddIfNotNull("lastWorkerId", this._LastWorkerId);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("jobObjectId", this._JobObjectId);
			kparams.AddIfNotNull("jobObjectType", this._JobObjectType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case DELETED_AT:
					return "DeletedAt";
				case LOCK_EXPIRATION:
					return "LockExpiration";
				case EXECUTION_ATTEMPTS:
					return "ExecutionAttempts";
				case LOCK_VERSION:
					return "LockVersion";
				case ENTRY_ID:
					return "EntryId";
				case ENTRY_NAME:
					return "EntryName";
				case JOB_TYPE:
					return "JobType";
				case JOB_SUB_TYPE:
					return "JobSubType";
				case DATA:
					return "Data";
				case STATUS:
					return "Status";
				case ABORT:
					return "Abort";
				case CHECK_AGAIN_TIMEOUT:
					return "CheckAgainTimeout";
				case MESSAGE:
					return "Message";
				case DESCRIPTION:
					return "Description";
				case PRIORITY:
					return "Priority";
				case HISTORY:
					return "History";
				case BULK_JOB_ID:
					return "BulkJobId";
				case BATCH_VERSION:
					return "BatchVersion";
				case PARENT_JOB_ID:
					return "ParentJobId";
				case ROOT_JOB_ID:
					return "RootJobId";
				case QUEUE_TIME:
					return "QueueTime";
				case FINISH_TIME:
					return "FinishTime";
				case ERR_TYPE:
					return "ErrType";
				case ERR_NUMBER:
					return "ErrNumber";
				case ESTIMATED_EFFORT:
					return "EstimatedEffort";
				case URGENCY:
					return "Urgency";
				case SCHEDULER_ID:
					return "SchedulerId";
				case WORKER_ID:
					return "WorkerId";
				case BATCH_INDEX:
					return "BatchIndex";
				case LAST_SCHEDULER_ID:
					return "LastSchedulerId";
				case LAST_WORKER_ID:
					return "LastWorkerId";
				case DC:
					return "Dc";
				case JOB_OBJECT_ID:
					return "JobObjectId";
				case JOB_OBJECT_TYPE:
					return "JobObjectType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

