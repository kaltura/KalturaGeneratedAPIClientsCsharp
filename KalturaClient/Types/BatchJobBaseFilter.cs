// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class BatchJobBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_GREATER_THAN_OR_EQUAL = "idGreaterThanOrEqual";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string PARTNER_ID_NOT_IN = "partnerIdNotIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string EXECUTION_ATTEMPTS_GREATER_THAN_OR_EQUAL = "executionAttemptsGreaterThanOrEqual";
		public const string EXECUTION_ATTEMPTS_LESS_THAN_OR_EQUAL = "executionAttemptsLessThanOrEqual";
		public const string LOCK_VERSION_GREATER_THAN_OR_EQUAL = "lockVersionGreaterThanOrEqual";
		public const string LOCK_VERSION_LESS_THAN_OR_EQUAL = "lockVersionLessThanOrEqual";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string JOB_TYPE_EQUAL = "jobTypeEqual";
		public const string JOB_TYPE_IN = "jobTypeIn";
		public const string JOB_TYPE_NOT_IN = "jobTypeNotIn";
		public const string JOB_SUB_TYPE_EQUAL = "jobSubTypeEqual";
		public const string JOB_SUB_TYPE_IN = "jobSubTypeIn";
		public const string JOB_SUB_TYPE_NOT_IN = "jobSubTypeNotIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_NOT_IN = "statusNotIn";
		public const string PRIORITY_GREATER_THAN_OR_EQUAL = "priorityGreaterThanOrEqual";
		public const string PRIORITY_LESS_THAN_OR_EQUAL = "priorityLessThanOrEqual";
		public const string PRIORITY_EQUAL = "priorityEqual";
		public const string PRIORITY_IN = "priorityIn";
		public const string PRIORITY_NOT_IN = "priorityNotIn";
		public const string BATCH_VERSION_GREATER_THAN_OR_EQUAL = "batchVersionGreaterThanOrEqual";
		public const string BATCH_VERSION_LESS_THAN_OR_EQUAL = "batchVersionLessThanOrEqual";
		public const string BATCH_VERSION_EQUAL = "batchVersionEqual";
		public const string QUEUE_TIME_GREATER_THAN_OR_EQUAL = "queueTimeGreaterThanOrEqual";
		public const string QUEUE_TIME_LESS_THAN_OR_EQUAL = "queueTimeLessThanOrEqual";
		public const string FINISH_TIME_GREATER_THAN_OR_EQUAL = "finishTimeGreaterThanOrEqual";
		public const string FINISH_TIME_LESS_THAN_OR_EQUAL = "finishTimeLessThanOrEqual";
		public const string ERR_TYPE_EQUAL = "errTypeEqual";
		public const string ERR_TYPE_IN = "errTypeIn";
		public const string ERR_TYPE_NOT_IN = "errTypeNotIn";
		public const string ERR_NUMBER_EQUAL = "errNumberEqual";
		public const string ERR_NUMBER_IN = "errNumberIn";
		public const string ERR_NUMBER_NOT_IN = "errNumberNotIn";
		public const string ESTIMATED_EFFORT_LESS_THAN = "estimatedEffortLessThan";
		public const string ESTIMATED_EFFORT_GREATER_THAN = "estimatedEffortGreaterThan";
		public const string URGENCY_LESS_THAN_OR_EQUAL = "urgencyLessThanOrEqual";
		public const string URGENCY_GREATER_THAN_OR_EQUAL = "urgencyGreaterThanOrEqual";
		#endregion

		#region Private Fields
		private long _IdEqual = long.MinValue;
		private long _IdGreaterThanOrEqual = long.MinValue;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _PartnerIdNotIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsGreaterThanOrEqual = Int32.MinValue;
		private int _ExecutionAttemptsLessThanOrEqual = Int32.MinValue;
		private int _LockVersionGreaterThanOrEqual = Int32.MinValue;
		private int _LockVersionLessThanOrEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private BatchJobType _JobTypeEqual = null;
		private string _JobTypeIn = null;
		private string _JobTypeNotIn = null;
		private int _JobSubTypeEqual = Int32.MinValue;
		private string _JobSubTypeIn = null;
		private string _JobSubTypeNotIn = null;
		private BatchJobStatus _StatusEqual = (BatchJobStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private int _PriorityGreaterThanOrEqual = Int32.MinValue;
		private int _PriorityLessThanOrEqual = Int32.MinValue;
		private int _PriorityEqual = Int32.MinValue;
		private string _PriorityIn = null;
		private string _PriorityNotIn = null;
		private int _BatchVersionGreaterThanOrEqual = Int32.MinValue;
		private int _BatchVersionLessThanOrEqual = Int32.MinValue;
		private int _BatchVersionEqual = Int32.MinValue;
		private int _QueueTimeGreaterThanOrEqual = Int32.MinValue;
		private int _QueueTimeLessThanOrEqual = Int32.MinValue;
		private int _FinishTimeGreaterThanOrEqual = Int32.MinValue;
		private int _FinishTimeLessThanOrEqual = Int32.MinValue;
		private BatchJobErrorTypes _ErrTypeEqual = (BatchJobErrorTypes)Int32.MinValue;
		private string _ErrTypeIn = null;
		private string _ErrTypeNotIn = null;
		private int _ErrNumberEqual = Int32.MinValue;
		private string _ErrNumberIn = null;
		private string _ErrNumberNotIn = null;
		private int _EstimatedEffortLessThan = Int32.MinValue;
		private int _EstimatedEffortGreaterThan = Int32.MinValue;
		private int _UrgencyLessThanOrEqual = Int32.MinValue;
		private int _UrgencyGreaterThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		/// <summary>
		/// Use IdGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long IdGreaterThanOrEqual
		{
			get { return _IdGreaterThanOrEqual; }
			set 
			{ 
				_IdGreaterThanOrEqual = value;
				OnPropertyChanged("IdGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use PartnerIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		/// <summary>
		/// Use PartnerIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		/// <summary>
		/// Use PartnerIdNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerIdNotIn
		{
			get { return _PartnerIdNotIn; }
			set 
			{ 
				_PartnerIdNotIn = value;
				OnPropertyChanged("PartnerIdNotIn");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use ExecutionAttemptsGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExecutionAttemptsGreaterThanOrEqual
		{
			get { return _ExecutionAttemptsGreaterThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsGreaterThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use ExecutionAttemptsLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ExecutionAttemptsLessThanOrEqual
		{
			get { return _ExecutionAttemptsLessThanOrEqual; }
			set 
			{ 
				_ExecutionAttemptsLessThanOrEqual = value;
				OnPropertyChanged("ExecutionAttemptsLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use LockVersionGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LockVersionGreaterThanOrEqual
		{
			get { return _LockVersionGreaterThanOrEqual; }
			set 
			{ 
				_LockVersionGreaterThanOrEqual = value;
				OnPropertyChanged("LockVersionGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use LockVersionLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LockVersionLessThanOrEqual
		{
			get { return _LockVersionLessThanOrEqual; }
			set 
			{ 
				_LockVersionLessThanOrEqual = value;
				OnPropertyChanged("LockVersionLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use EntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		/// <summary>
		/// Use JobTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BatchJobType JobTypeEqual
		{
			get { return _JobTypeEqual; }
			set 
			{ 
				_JobTypeEqual = value;
				OnPropertyChanged("JobTypeEqual");
			}
		}
		/// <summary>
		/// Use JobTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string JobTypeIn
		{
			get { return _JobTypeIn; }
			set 
			{ 
				_JobTypeIn = value;
				OnPropertyChanged("JobTypeIn");
			}
		}
		/// <summary>
		/// Use JobTypeNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string JobTypeNotIn
		{
			get { return _JobTypeNotIn; }
			set 
			{ 
				_JobTypeNotIn = value;
				OnPropertyChanged("JobTypeNotIn");
			}
		}
		/// <summary>
		/// Use JobSubTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int JobSubTypeEqual
		{
			get { return _JobSubTypeEqual; }
			set 
			{ 
				_JobSubTypeEqual = value;
				OnPropertyChanged("JobSubTypeEqual");
			}
		}
		/// <summary>
		/// Use JobSubTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string JobSubTypeIn
		{
			get { return _JobSubTypeIn; }
			set 
			{ 
				_JobSubTypeIn = value;
				OnPropertyChanged("JobSubTypeIn");
			}
		}
		/// <summary>
		/// Use JobSubTypeNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string JobSubTypeNotIn
		{
			get { return _JobSubTypeNotIn; }
			set 
			{ 
				_JobSubTypeNotIn = value;
				OnPropertyChanged("JobSubTypeNotIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BatchJobStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use StatusNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		/// <summary>
		/// Use PriorityGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityGreaterThanOrEqual
		{
			get { return _PriorityGreaterThanOrEqual; }
			set 
			{ 
				_PriorityGreaterThanOrEqual = value;
				OnPropertyChanged("PriorityGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use PriorityLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityLessThanOrEqual
		{
			get { return _PriorityLessThanOrEqual; }
			set 
			{ 
				_PriorityLessThanOrEqual = value;
				OnPropertyChanged("PriorityLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use PriorityEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PriorityEqual
		{
			get { return _PriorityEqual; }
			set 
			{ 
				_PriorityEqual = value;
				OnPropertyChanged("PriorityEqual");
			}
		}
		/// <summary>
		/// Use PriorityInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PriorityIn
		{
			get { return _PriorityIn; }
			set 
			{ 
				_PriorityIn = value;
				OnPropertyChanged("PriorityIn");
			}
		}
		/// <summary>
		/// Use PriorityNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PriorityNotIn
		{
			get { return _PriorityNotIn; }
			set 
			{ 
				_PriorityNotIn = value;
				OnPropertyChanged("PriorityNotIn");
			}
		}
		/// <summary>
		/// Use BatchVersionGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int BatchVersionGreaterThanOrEqual
		{
			get { return _BatchVersionGreaterThanOrEqual; }
			set 
			{ 
				_BatchVersionGreaterThanOrEqual = value;
				OnPropertyChanged("BatchVersionGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use BatchVersionLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int BatchVersionLessThanOrEqual
		{
			get { return _BatchVersionLessThanOrEqual; }
			set 
			{ 
				_BatchVersionLessThanOrEqual = value;
				OnPropertyChanged("BatchVersionLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use BatchVersionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int BatchVersionEqual
		{
			get { return _BatchVersionEqual; }
			set 
			{ 
				_BatchVersionEqual = value;
				OnPropertyChanged("BatchVersionEqual");
			}
		}
		/// <summary>
		/// Use QueueTimeGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int QueueTimeGreaterThanOrEqual
		{
			get { return _QueueTimeGreaterThanOrEqual; }
			set 
			{ 
				_QueueTimeGreaterThanOrEqual = value;
				OnPropertyChanged("QueueTimeGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use QueueTimeLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int QueueTimeLessThanOrEqual
		{
			get { return _QueueTimeLessThanOrEqual; }
			set 
			{ 
				_QueueTimeLessThanOrEqual = value;
				OnPropertyChanged("QueueTimeLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use FinishTimeGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FinishTimeGreaterThanOrEqual
		{
			get { return _FinishTimeGreaterThanOrEqual; }
			set 
			{ 
				_FinishTimeGreaterThanOrEqual = value;
				OnPropertyChanged("FinishTimeGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use FinishTimeLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FinishTimeLessThanOrEqual
		{
			get { return _FinishTimeLessThanOrEqual; }
			set 
			{ 
				_FinishTimeLessThanOrEqual = value;
				OnPropertyChanged("FinishTimeLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use ErrTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BatchJobErrorTypes ErrTypeEqual
		{
			get { return _ErrTypeEqual; }
			set 
			{ 
				_ErrTypeEqual = value;
				OnPropertyChanged("ErrTypeEqual");
			}
		}
		/// <summary>
		/// Use ErrTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrTypeIn
		{
			get { return _ErrTypeIn; }
			set 
			{ 
				_ErrTypeIn = value;
				OnPropertyChanged("ErrTypeIn");
			}
		}
		/// <summary>
		/// Use ErrTypeNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrTypeNotIn
		{
			get { return _ErrTypeNotIn; }
			set 
			{ 
				_ErrTypeNotIn = value;
				OnPropertyChanged("ErrTypeNotIn");
			}
		}
		/// <summary>
		/// Use ErrNumberEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ErrNumberEqual
		{
			get { return _ErrNumberEqual; }
			set 
			{ 
				_ErrNumberEqual = value;
				OnPropertyChanged("ErrNumberEqual");
			}
		}
		/// <summary>
		/// Use ErrNumberInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrNumberIn
		{
			get { return _ErrNumberIn; }
			set 
			{ 
				_ErrNumberIn = value;
				OnPropertyChanged("ErrNumberIn");
			}
		}
		/// <summary>
		/// Use ErrNumberNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ErrNumberNotIn
		{
			get { return _ErrNumberNotIn; }
			set 
			{ 
				_ErrNumberNotIn = value;
				OnPropertyChanged("ErrNumberNotIn");
			}
		}
		/// <summary>
		/// Use EstimatedEffortLessThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EstimatedEffortLessThan
		{
			get { return _EstimatedEffortLessThan; }
			set 
			{ 
				_EstimatedEffortLessThan = value;
				OnPropertyChanged("EstimatedEffortLessThan");
			}
		}
		/// <summary>
		/// Use EstimatedEffortGreaterThanAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EstimatedEffortGreaterThan
		{
			get { return _EstimatedEffortGreaterThan; }
			set 
			{ 
				_EstimatedEffortGreaterThan = value;
				OnPropertyChanged("EstimatedEffortGreaterThan");
			}
		}
		/// <summary>
		/// Use UrgencyLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UrgencyLessThanOrEqual
		{
			get { return _UrgencyLessThanOrEqual; }
			set 
			{ 
				_UrgencyLessThanOrEqual = value;
				OnPropertyChanged("UrgencyLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UrgencyGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UrgencyGreaterThanOrEqual
		{
			get { return _UrgencyGreaterThanOrEqual; }
			set 
			{ 
				_UrgencyGreaterThanOrEqual = value;
				OnPropertyChanged("UrgencyGreaterThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public BatchJobBaseFilter()
		{
		}

		public BatchJobBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseLong(node["idEqual"].Value<string>());
			}
			if(node["idGreaterThanOrEqual"] != null)
			{
				this._IdGreaterThanOrEqual = ParseLong(node["idGreaterThanOrEqual"].Value<string>());
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["partnerIdNotIn"] != null)
			{
				this._PartnerIdNotIn = node["partnerIdNotIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["executionAttemptsGreaterThanOrEqual"] != null)
			{
				this._ExecutionAttemptsGreaterThanOrEqual = ParseInt(node["executionAttemptsGreaterThanOrEqual"].Value<string>());
			}
			if(node["executionAttemptsLessThanOrEqual"] != null)
			{
				this._ExecutionAttemptsLessThanOrEqual = ParseInt(node["executionAttemptsLessThanOrEqual"].Value<string>());
			}
			if(node["lockVersionGreaterThanOrEqual"] != null)
			{
				this._LockVersionGreaterThanOrEqual = ParseInt(node["lockVersionGreaterThanOrEqual"].Value<string>());
			}
			if(node["lockVersionLessThanOrEqual"] != null)
			{
				this._LockVersionLessThanOrEqual = ParseInt(node["lockVersionLessThanOrEqual"].Value<string>());
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["jobTypeEqual"] != null)
			{
				this._JobTypeEqual = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), node["jobTypeEqual"].Value<string>());
			}
			if(node["jobTypeIn"] != null)
			{
				this._JobTypeIn = node["jobTypeIn"].Value<string>();
			}
			if(node["jobTypeNotIn"] != null)
			{
				this._JobTypeNotIn = node["jobTypeNotIn"].Value<string>();
			}
			if(node["jobSubTypeEqual"] != null)
			{
				this._JobSubTypeEqual = ParseInt(node["jobSubTypeEqual"].Value<string>());
			}
			if(node["jobSubTypeIn"] != null)
			{
				this._JobSubTypeIn = node["jobSubTypeIn"].Value<string>();
			}
			if(node["jobSubTypeNotIn"] != null)
			{
				this._JobSubTypeNotIn = node["jobSubTypeNotIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (BatchJobStatus)ParseEnum(typeof(BatchJobStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["statusNotIn"] != null)
			{
				this._StatusNotIn = node["statusNotIn"].Value<string>();
			}
			if(node["priorityGreaterThanOrEqual"] != null)
			{
				this._PriorityGreaterThanOrEqual = ParseInt(node["priorityGreaterThanOrEqual"].Value<string>());
			}
			if(node["priorityLessThanOrEqual"] != null)
			{
				this._PriorityLessThanOrEqual = ParseInt(node["priorityLessThanOrEqual"].Value<string>());
			}
			if(node["priorityEqual"] != null)
			{
				this._PriorityEqual = ParseInt(node["priorityEqual"].Value<string>());
			}
			if(node["priorityIn"] != null)
			{
				this._PriorityIn = node["priorityIn"].Value<string>();
			}
			if(node["priorityNotIn"] != null)
			{
				this._PriorityNotIn = node["priorityNotIn"].Value<string>();
			}
			if(node["batchVersionGreaterThanOrEqual"] != null)
			{
				this._BatchVersionGreaterThanOrEqual = ParseInt(node["batchVersionGreaterThanOrEqual"].Value<string>());
			}
			if(node["batchVersionLessThanOrEqual"] != null)
			{
				this._BatchVersionLessThanOrEqual = ParseInt(node["batchVersionLessThanOrEqual"].Value<string>());
			}
			if(node["batchVersionEqual"] != null)
			{
				this._BatchVersionEqual = ParseInt(node["batchVersionEqual"].Value<string>());
			}
			if(node["queueTimeGreaterThanOrEqual"] != null)
			{
				this._QueueTimeGreaterThanOrEqual = ParseInt(node["queueTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["queueTimeLessThanOrEqual"] != null)
			{
				this._QueueTimeLessThanOrEqual = ParseInt(node["queueTimeLessThanOrEqual"].Value<string>());
			}
			if(node["finishTimeGreaterThanOrEqual"] != null)
			{
				this._FinishTimeGreaterThanOrEqual = ParseInt(node["finishTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["finishTimeLessThanOrEqual"] != null)
			{
				this._FinishTimeLessThanOrEqual = ParseInt(node["finishTimeLessThanOrEqual"].Value<string>());
			}
			if(node["errTypeEqual"] != null)
			{
				this._ErrTypeEqual = (BatchJobErrorTypes)ParseEnum(typeof(BatchJobErrorTypes), node["errTypeEqual"].Value<string>());
			}
			if(node["errTypeIn"] != null)
			{
				this._ErrTypeIn = node["errTypeIn"].Value<string>();
			}
			if(node["errTypeNotIn"] != null)
			{
				this._ErrTypeNotIn = node["errTypeNotIn"].Value<string>();
			}
			if(node["errNumberEqual"] != null)
			{
				this._ErrNumberEqual = ParseInt(node["errNumberEqual"].Value<string>());
			}
			if(node["errNumberIn"] != null)
			{
				this._ErrNumberIn = node["errNumberIn"].Value<string>();
			}
			if(node["errNumberNotIn"] != null)
			{
				this._ErrNumberNotIn = node["errNumberNotIn"].Value<string>();
			}
			if(node["estimatedEffortLessThan"] != null)
			{
				this._EstimatedEffortLessThan = ParseInt(node["estimatedEffortLessThan"].Value<string>());
			}
			if(node["estimatedEffortGreaterThan"] != null)
			{
				this._EstimatedEffortGreaterThan = ParseInt(node["estimatedEffortGreaterThan"].Value<string>());
			}
			if(node["urgencyLessThanOrEqual"] != null)
			{
				this._UrgencyLessThanOrEqual = ParseInt(node["urgencyLessThanOrEqual"].Value<string>());
			}
			if(node["urgencyGreaterThanOrEqual"] != null)
			{
				this._UrgencyGreaterThanOrEqual = ParseInt(node["urgencyGreaterThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBatchJobBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idGreaterThanOrEqual", this._IdGreaterThanOrEqual);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("partnerIdNotIn", this._PartnerIdNotIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("executionAttemptsGreaterThanOrEqual", this._ExecutionAttemptsGreaterThanOrEqual);
			kparams.AddIfNotNull("executionAttemptsLessThanOrEqual", this._ExecutionAttemptsLessThanOrEqual);
			kparams.AddIfNotNull("lockVersionGreaterThanOrEqual", this._LockVersionGreaterThanOrEqual);
			kparams.AddIfNotNull("lockVersionLessThanOrEqual", this._LockVersionLessThanOrEqual);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("jobTypeEqual", this._JobTypeEqual);
			kparams.AddIfNotNull("jobTypeIn", this._JobTypeIn);
			kparams.AddIfNotNull("jobTypeNotIn", this._JobTypeNotIn);
			kparams.AddIfNotNull("jobSubTypeEqual", this._JobSubTypeEqual);
			kparams.AddIfNotNull("jobSubTypeIn", this._JobSubTypeIn);
			kparams.AddIfNotNull("jobSubTypeNotIn", this._JobSubTypeNotIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			kparams.AddIfNotNull("priorityGreaterThanOrEqual", this._PriorityGreaterThanOrEqual);
			kparams.AddIfNotNull("priorityLessThanOrEqual", this._PriorityLessThanOrEqual);
			kparams.AddIfNotNull("priorityEqual", this._PriorityEqual);
			kparams.AddIfNotNull("priorityIn", this._PriorityIn);
			kparams.AddIfNotNull("priorityNotIn", this._PriorityNotIn);
			kparams.AddIfNotNull("batchVersionGreaterThanOrEqual", this._BatchVersionGreaterThanOrEqual);
			kparams.AddIfNotNull("batchVersionLessThanOrEqual", this._BatchVersionLessThanOrEqual);
			kparams.AddIfNotNull("batchVersionEqual", this._BatchVersionEqual);
			kparams.AddIfNotNull("queueTimeGreaterThanOrEqual", this._QueueTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("queueTimeLessThanOrEqual", this._QueueTimeLessThanOrEqual);
			kparams.AddIfNotNull("finishTimeGreaterThanOrEqual", this._FinishTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("finishTimeLessThanOrEqual", this._FinishTimeLessThanOrEqual);
			kparams.AddIfNotNull("errTypeEqual", this._ErrTypeEqual);
			kparams.AddIfNotNull("errTypeIn", this._ErrTypeIn);
			kparams.AddIfNotNull("errTypeNotIn", this._ErrTypeNotIn);
			kparams.AddIfNotNull("errNumberEqual", this._ErrNumberEqual);
			kparams.AddIfNotNull("errNumberIn", this._ErrNumberIn);
			kparams.AddIfNotNull("errNumberNotIn", this._ErrNumberNotIn);
			kparams.AddIfNotNull("estimatedEffortLessThan", this._EstimatedEffortLessThan);
			kparams.AddIfNotNull("estimatedEffortGreaterThan", this._EstimatedEffortGreaterThan);
			kparams.AddIfNotNull("urgencyLessThanOrEqual", this._UrgencyLessThanOrEqual);
			kparams.AddIfNotNull("urgencyGreaterThanOrEqual", this._UrgencyGreaterThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_GREATER_THAN_OR_EQUAL:
					return "IdGreaterThanOrEqual";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case PARTNER_ID_NOT_IN:
					return "PartnerIdNotIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case EXECUTION_ATTEMPTS_GREATER_THAN_OR_EQUAL:
					return "ExecutionAttemptsGreaterThanOrEqual";
				case EXECUTION_ATTEMPTS_LESS_THAN_OR_EQUAL:
					return "ExecutionAttemptsLessThanOrEqual";
				case LOCK_VERSION_GREATER_THAN_OR_EQUAL:
					return "LockVersionGreaterThanOrEqual";
				case LOCK_VERSION_LESS_THAN_OR_EQUAL:
					return "LockVersionLessThanOrEqual";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case JOB_TYPE_EQUAL:
					return "JobTypeEqual";
				case JOB_TYPE_IN:
					return "JobTypeIn";
				case JOB_TYPE_NOT_IN:
					return "JobTypeNotIn";
				case JOB_SUB_TYPE_EQUAL:
					return "JobSubTypeEqual";
				case JOB_SUB_TYPE_IN:
					return "JobSubTypeIn";
				case JOB_SUB_TYPE_NOT_IN:
					return "JobSubTypeNotIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_NOT_IN:
					return "StatusNotIn";
				case PRIORITY_GREATER_THAN_OR_EQUAL:
					return "PriorityGreaterThanOrEqual";
				case PRIORITY_LESS_THAN_OR_EQUAL:
					return "PriorityLessThanOrEqual";
				case PRIORITY_EQUAL:
					return "PriorityEqual";
				case PRIORITY_IN:
					return "PriorityIn";
				case PRIORITY_NOT_IN:
					return "PriorityNotIn";
				case BATCH_VERSION_GREATER_THAN_OR_EQUAL:
					return "BatchVersionGreaterThanOrEqual";
				case BATCH_VERSION_LESS_THAN_OR_EQUAL:
					return "BatchVersionLessThanOrEqual";
				case BATCH_VERSION_EQUAL:
					return "BatchVersionEqual";
				case QUEUE_TIME_GREATER_THAN_OR_EQUAL:
					return "QueueTimeGreaterThanOrEqual";
				case QUEUE_TIME_LESS_THAN_OR_EQUAL:
					return "QueueTimeLessThanOrEqual";
				case FINISH_TIME_GREATER_THAN_OR_EQUAL:
					return "FinishTimeGreaterThanOrEqual";
				case FINISH_TIME_LESS_THAN_OR_EQUAL:
					return "FinishTimeLessThanOrEqual";
				case ERR_TYPE_EQUAL:
					return "ErrTypeEqual";
				case ERR_TYPE_IN:
					return "ErrTypeIn";
				case ERR_TYPE_NOT_IN:
					return "ErrTypeNotIn";
				case ERR_NUMBER_EQUAL:
					return "ErrNumberEqual";
				case ERR_NUMBER_IN:
					return "ErrNumberIn";
				case ERR_NUMBER_NOT_IN:
					return "ErrNumberNotIn";
				case ESTIMATED_EFFORT_LESS_THAN:
					return "EstimatedEffortLessThan";
				case ESTIMATED_EFFORT_GREATER_THAN:
					return "EstimatedEffortGreaterThan";
				case URGENCY_LESS_THAN_OR_EQUAL:
					return "UrgencyLessThanOrEqual";
				case URGENCY_GREATER_THAN_OR_EQUAL:
					return "UrgencyGreaterThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

