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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaBatchJob : KalturaObjectBase
	{
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
		private KalturaBatchJobType _JobType = null;
		private int _JobSubType = Int32.MinValue;
		private KalturaJobData _Data;
		private KalturaBatchJobStatus _Status = (KalturaBatchJobStatus)Int32.MinValue;
		private int _Abort = Int32.MinValue;
		private int _CheckAgainTimeout = Int32.MinValue;
		private string _Message = null;
		private string _Description = null;
		private int _Priority = Int32.MinValue;
		private IList<KalturaBatchHistoryData> _History;
		private int _BulkJobId = Int32.MinValue;
		private int _BatchVersion = Int32.MinValue;
		private int _ParentJobId = Int32.MinValue;
		private int _RootJobId = Int32.MinValue;
		private int _QueueTime = Int32.MinValue;
		private int _FinishTime = Int32.MinValue;
		private KalturaBatchJobErrorTypes _ErrType = (KalturaBatchJobErrorTypes)Int32.MinValue;
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
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public int DeletedAt
		{
			get { return _DeletedAt; }
			set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
		}
		public int LockExpiration
		{
			get { return _LockExpiration; }
			set 
			{ 
				_LockExpiration = value;
				OnPropertyChanged("LockExpiration");
			}
		}
		public int ExecutionAttempts
		{
			get { return _ExecutionAttempts; }
			set 
			{ 
				_ExecutionAttempts = value;
				OnPropertyChanged("ExecutionAttempts");
			}
		}
		public int LockVersion
		{
			get { return _LockVersion; }
			set 
			{ 
				_LockVersion = value;
				OnPropertyChanged("LockVersion");
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
		public string EntryName
		{
			get { return _EntryName; }
			set 
			{ 
				_EntryName = value;
				OnPropertyChanged("EntryName");
			}
		}
		public KalturaBatchJobType JobType
		{
			get { return _JobType; }
			set 
			{ 
				_JobType = value;
				OnPropertyChanged("JobType");
			}
		}
		public int JobSubType
		{
			get { return _JobSubType; }
			set 
			{ 
				_JobSubType = value;
				OnPropertyChanged("JobSubType");
			}
		}
		public KalturaJobData Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public KalturaBatchJobStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int Abort
		{
			get { return _Abort; }
			set 
			{ 
				_Abort = value;
				OnPropertyChanged("Abort");
			}
		}
		public int CheckAgainTimeout
		{
			get { return _CheckAgainTimeout; }
			set 
			{ 
				_CheckAgainTimeout = value;
				OnPropertyChanged("CheckAgainTimeout");
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		public IList<KalturaBatchHistoryData> History
		{
			get { return _History; }
			set 
			{ 
				_History = value;
				OnPropertyChanged("History");
			}
		}
		public int BulkJobId
		{
			get { return _BulkJobId; }
			set 
			{ 
				_BulkJobId = value;
				OnPropertyChanged("BulkJobId");
			}
		}
		public int BatchVersion
		{
			get { return _BatchVersion; }
			set 
			{ 
				_BatchVersion = value;
				OnPropertyChanged("BatchVersion");
			}
		}
		public int ParentJobId
		{
			get { return _ParentJobId; }
			set 
			{ 
				_ParentJobId = value;
				OnPropertyChanged("ParentJobId");
			}
		}
		public int RootJobId
		{
			get { return _RootJobId; }
			set 
			{ 
				_RootJobId = value;
				OnPropertyChanged("RootJobId");
			}
		}
		public int QueueTime
		{
			get { return _QueueTime; }
			set 
			{ 
				_QueueTime = value;
				OnPropertyChanged("QueueTime");
			}
		}
		public int FinishTime
		{
			get { return _FinishTime; }
			set 
			{ 
				_FinishTime = value;
				OnPropertyChanged("FinishTime");
			}
		}
		public KalturaBatchJobErrorTypes ErrType
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
		public int EstimatedEffort
		{
			get { return _EstimatedEffort; }
			set 
			{ 
				_EstimatedEffort = value;
				OnPropertyChanged("EstimatedEffort");
			}
		}
		public int Urgency
		{
			get { return _Urgency; }
			set 
			{ 
				_Urgency = value;
				OnPropertyChanged("Urgency");
			}
		}
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
		public int LastSchedulerId
		{
			get { return _LastSchedulerId; }
			set 
			{ 
				_LastSchedulerId = value;
				OnPropertyChanged("LastSchedulerId");
			}
		}
		public int LastWorkerId
		{
			get { return _LastWorkerId; }
			set 
			{ 
				_LastWorkerId = value;
				OnPropertyChanged("LastWorkerId");
			}
		}
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public string JobObjectId
		{
			get { return _JobObjectId; }
			set 
			{ 
				_JobObjectId = value;
				OnPropertyChanged("JobObjectId");
			}
		}
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
		public KalturaBatchJob()
		{
		}

		public KalturaBatchJob(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseLong(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "deletedAt":
						this.DeletedAt = ParseInt(txt);
						continue;
					case "lockExpiration":
						this.LockExpiration = ParseInt(txt);
						continue;
					case "executionAttempts":
						this.ExecutionAttempts = ParseInt(txt);
						continue;
					case "lockVersion":
						this.LockVersion = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "entryName":
						this.EntryName = txt;
						continue;
					case "jobType":
						this.JobType = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "jobSubType":
						this.JobSubType = ParseInt(txt);
						continue;
					case "data":
						this.Data = (KalturaJobData)KalturaObjectFactory.Create(propertyNode, "KalturaJobData");
						continue;
					case "status":
						this.Status = (KalturaBatchJobStatus)ParseEnum(typeof(KalturaBatchJobStatus), txt);
						continue;
					case "abort":
						this.Abort = ParseInt(txt);
						continue;
					case "checkAgainTimeout":
						this.CheckAgainTimeout = ParseInt(txt);
						continue;
					case "message":
						this.Message = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "priority":
						this.Priority = ParseInt(txt);
						continue;
					case "history":
						this.History = new List<KalturaBatchHistoryData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.History.Add((KalturaBatchHistoryData)KalturaObjectFactory.Create(arrayNode, "KalturaBatchHistoryData"));
						}
						continue;
					case "bulkJobId":
						this.BulkJobId = ParseInt(txt);
						continue;
					case "batchVersion":
						this.BatchVersion = ParseInt(txt);
						continue;
					case "parentJobId":
						this.ParentJobId = ParseInt(txt);
						continue;
					case "rootJobId":
						this.RootJobId = ParseInt(txt);
						continue;
					case "queueTime":
						this.QueueTime = ParseInt(txt);
						continue;
					case "finishTime":
						this.FinishTime = ParseInt(txt);
						continue;
					case "errType":
						this.ErrType = (KalturaBatchJobErrorTypes)ParseEnum(typeof(KalturaBatchJobErrorTypes), txt);
						continue;
					case "errNumber":
						this.ErrNumber = ParseInt(txt);
						continue;
					case "estimatedEffort":
						this.EstimatedEffort = ParseInt(txt);
						continue;
					case "urgency":
						this.Urgency = ParseInt(txt);
						continue;
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "batchIndex":
						this.BatchIndex = ParseInt(txt);
						continue;
					case "lastSchedulerId":
						this.LastSchedulerId = ParseInt(txt);
						continue;
					case "lastWorkerId":
						this.LastWorkerId = ParseInt(txt);
						continue;
					case "dc":
						this.Dc = ParseInt(txt);
						continue;
					case "jobObjectId":
						this.JobObjectId = txt;
						continue;
					case "jobObjectType":
						this.JobObjectType = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBatchJob");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("deletedAt", this.DeletedAt);
			kparams.AddIfNotNull("lockExpiration", this.LockExpiration);
			kparams.AddIfNotNull("executionAttempts", this.ExecutionAttempts);
			kparams.AddIfNotNull("lockVersion", this.LockVersion);
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("entryName", this.EntryName);
			kparams.AddIfNotNull("jobType", this.JobType);
			kparams.AddIfNotNull("jobSubType", this.JobSubType);
			kparams.AddIfNotNull("data", this.Data);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("abort", this.Abort);
			kparams.AddIfNotNull("checkAgainTimeout", this.CheckAgainTimeout);
			kparams.AddIfNotNull("message", this.Message);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("priority", this.Priority);
			kparams.AddIfNotNull("history", this.History);
			kparams.AddIfNotNull("bulkJobId", this.BulkJobId);
			kparams.AddIfNotNull("batchVersion", this.BatchVersion);
			kparams.AddIfNotNull("parentJobId", this.ParentJobId);
			kparams.AddIfNotNull("rootJobId", this.RootJobId);
			kparams.AddIfNotNull("queueTime", this.QueueTime);
			kparams.AddIfNotNull("finishTime", this.FinishTime);
			kparams.AddIfNotNull("errType", this.ErrType);
			kparams.AddIfNotNull("errNumber", this.ErrNumber);
			kparams.AddIfNotNull("estimatedEffort", this.EstimatedEffort);
			kparams.AddIfNotNull("urgency", this.Urgency);
			kparams.AddIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIfNotNull("workerId", this.WorkerId);
			kparams.AddIfNotNull("batchIndex", this.BatchIndex);
			kparams.AddIfNotNull("lastSchedulerId", this.LastSchedulerId);
			kparams.AddIfNotNull("lastWorkerId", this.LastWorkerId);
			kparams.AddIfNotNull("dc", this.Dc);
			kparams.AddIfNotNull("jobObjectId", this.JobObjectId);
			kparams.AddIfNotNull("jobObjectType", this.JobObjectType);
			return kparams;
		}
		#endregion
	}
}

