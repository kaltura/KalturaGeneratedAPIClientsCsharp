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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class SchedulerConfig : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_BY = "createdBy";
		public const string UPDATED_BY = "updatedBy";
		public const string COMMAND_ID = "commandId";
		public const string COMMAND_STATUS = "commandStatus";
		public const string SCHEDULER_ID = "schedulerId";
		public const string SCHEDULER_CONFIGURED_ID = "schedulerConfiguredId";
		public const string SCHEDULER_NAME = "schedulerName";
		public const string WORKER_ID = "workerId";
		public const string WORKER_CONFIGURED_ID = "workerConfiguredId";
		public const string WORKER_NAME = "workerName";
		public const string VARIABLE = "variable";
		public const string VARIABLE_PART = "variablePart";
		public const string VALUE = "value";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _CreatedBy = null;
		private string _UpdatedBy = null;
		private string _CommandId = null;
		private string _CommandStatus = null;
		private int _SchedulerId = Int32.MinValue;
		private int _SchedulerConfiguredId = Int32.MinValue;
		private string _SchedulerName = null;
		private int _WorkerId = Int32.MinValue;
		private int _WorkerConfiguredId = Int32.MinValue;
		private string _WorkerName = null;
		private string _Variable = null;
		private string _VariablePart = null;
		private string _Value = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public string CreatedBy
		{
			get { return _CreatedBy; }
			set 
			{ 
				_CreatedBy = value;
				OnPropertyChanged("CreatedBy");
			}
		}
		[JsonProperty]
		public string UpdatedBy
		{
			get { return _UpdatedBy; }
			set 
			{ 
				_UpdatedBy = value;
				OnPropertyChanged("UpdatedBy");
			}
		}
		[JsonProperty]
		public string CommandId
		{
			get { return _CommandId; }
			set 
			{ 
				_CommandId = value;
				OnPropertyChanged("CommandId");
			}
		}
		[JsonProperty]
		public string CommandStatus
		{
			get { return _CommandStatus; }
			set 
			{ 
				_CommandStatus = value;
				OnPropertyChanged("CommandStatus");
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
		public int SchedulerConfiguredId
		{
			get { return _SchedulerConfiguredId; }
			set 
			{ 
				_SchedulerConfiguredId = value;
				OnPropertyChanged("SchedulerConfiguredId");
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
		public int WorkerConfiguredId
		{
			get { return _WorkerConfiguredId; }
			set 
			{ 
				_WorkerConfiguredId = value;
				OnPropertyChanged("WorkerConfiguredId");
			}
		}
		[JsonProperty]
		public string WorkerName
		{
			get { return _WorkerName; }
			set 
			{ 
				_WorkerName = value;
				OnPropertyChanged("WorkerName");
			}
		}
		[JsonProperty]
		public string Variable
		{
			get { return _Variable; }
			set 
			{ 
				_Variable = value;
				OnPropertyChanged("Variable");
			}
		}
		[JsonProperty]
		public string VariablePart
		{
			get { return _VariablePart; }
			set 
			{ 
				_VariablePart = value;
				OnPropertyChanged("VariablePart");
			}
		}
		[JsonProperty]
		public string Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		#endregion

		#region CTor
		public SchedulerConfig()
		{
		}

		public SchedulerConfig(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["createdBy"] != null)
			{
				this._CreatedBy = node["createdBy"].Value<string>();
			}
			if(node["updatedBy"] != null)
			{
				this._UpdatedBy = node["updatedBy"].Value<string>();
			}
			if(node["commandId"] != null)
			{
				this._CommandId = node["commandId"].Value<string>();
			}
			if(node["commandStatus"] != null)
			{
				this._CommandStatus = node["commandStatus"].Value<string>();
			}
			if(node["schedulerId"] != null)
			{
				this._SchedulerId = ParseInt(node["schedulerId"].Value<string>());
			}
			if(node["schedulerConfiguredId"] != null)
			{
				this._SchedulerConfiguredId = ParseInt(node["schedulerConfiguredId"].Value<string>());
			}
			if(node["schedulerName"] != null)
			{
				this._SchedulerName = node["schedulerName"].Value<string>();
			}
			if(node["workerId"] != null)
			{
				this._WorkerId = ParseInt(node["workerId"].Value<string>());
			}
			if(node["workerConfiguredId"] != null)
			{
				this._WorkerConfiguredId = ParseInt(node["workerConfiguredId"].Value<string>());
			}
			if(node["workerName"] != null)
			{
				this._WorkerName = node["workerName"].Value<string>();
			}
			if(node["variable"] != null)
			{
				this._Variable = node["variable"].Value<string>();
			}
			if(node["variablePart"] != null)
			{
				this._VariablePart = node["variablePart"].Value<string>();
			}
			if(node["value"] != null)
			{
				this._Value = node["value"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSchedulerConfig");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdBy", this._CreatedBy);
			kparams.AddIfNotNull("updatedBy", this._UpdatedBy);
			kparams.AddIfNotNull("commandId", this._CommandId);
			kparams.AddIfNotNull("commandStatus", this._CommandStatus);
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("schedulerConfiguredId", this._SchedulerConfiguredId);
			kparams.AddIfNotNull("schedulerName", this._SchedulerName);
			kparams.AddIfNotNull("workerId", this._WorkerId);
			kparams.AddIfNotNull("workerConfiguredId", this._WorkerConfiguredId);
			kparams.AddIfNotNull("workerName", this._WorkerName);
			kparams.AddIfNotNull("variable", this._Variable);
			kparams.AddIfNotNull("variablePart", this._VariablePart);
			kparams.AddIfNotNull("value", this._Value);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_BY:
					return "CreatedBy";
				case UPDATED_BY:
					return "UpdatedBy";
				case COMMAND_ID:
					return "CommandId";
				case COMMAND_STATUS:
					return "CommandStatus";
				case SCHEDULER_ID:
					return "SchedulerId";
				case SCHEDULER_CONFIGURED_ID:
					return "SchedulerConfiguredId";
				case SCHEDULER_NAME:
					return "SchedulerName";
				case WORKER_ID:
					return "WorkerId";
				case WORKER_CONFIGURED_ID:
					return "WorkerConfiguredId";
				case WORKER_NAME:
					return "WorkerName";
				case VARIABLE:
					return "Variable";
				case VARIABLE_PART:
					return "VariablePart";
				case VALUE:
					return "Value";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

