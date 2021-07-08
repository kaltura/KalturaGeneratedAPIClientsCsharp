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
	public class SchedulerStatus : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string SCHEDULER_CONFIGURED_ID = "schedulerConfiguredId";
		public const string WORKER_CONFIGURED_ID = "workerConfiguredId";
		public const string WORKER_TYPE = "workerType";
		public const string TYPE = "type";
		public const string VALUE = "value";
		public const string SCHEDULER_ID = "schedulerId";
		public const string WORKER_ID = "workerId";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _SchedulerConfiguredId = Int32.MinValue;
		private int _WorkerConfiguredId = Int32.MinValue;
		private BatchJobType _WorkerType = null;
		private SchedulerStatusType _Type = (SchedulerStatusType)Int32.MinValue;
		private int _Value = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use SchedulerConfiguredIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use WorkerConfiguredIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use WorkerTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BatchJobType WorkerType
		{
			get { return _WorkerType; }
			set 
			{ 
				_WorkerType = value;
				OnPropertyChanged("WorkerType");
			}
		}
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SchedulerStatusType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use ValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		/// <summary>
		/// Use SchedulerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SchedulerId
		{
			get { return _SchedulerId; }
			private set 
			{ 
				_SchedulerId = value;
				OnPropertyChanged("SchedulerId");
			}
		}
		/// <summary>
		/// Use WorkerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int WorkerId
		{
			get { return _WorkerId; }
			private set 
			{ 
				_WorkerId = value;
				OnPropertyChanged("WorkerId");
			}
		}
		#endregion

		#region CTor
		public SchedulerStatus()
		{
		}

		public SchedulerStatus(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["schedulerConfiguredId"] != null)
			{
				this._SchedulerConfiguredId = ParseInt(node["schedulerConfiguredId"].Value<string>());
			}
			if(node["workerConfiguredId"] != null)
			{
				this._WorkerConfiguredId = ParseInt(node["workerConfiguredId"].Value<string>());
			}
			if(node["workerType"] != null)
			{
				this._WorkerType = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), node["workerType"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (SchedulerStatusType)ParseEnum(typeof(SchedulerStatusType), node["type"].Value<string>());
			}
			if(node["value"] != null)
			{
				this._Value = ParseInt(node["value"].Value<string>());
			}
			if(node["schedulerId"] != null)
			{
				this._SchedulerId = ParseInt(node["schedulerId"].Value<string>());
			}
			if(node["workerId"] != null)
			{
				this._WorkerId = ParseInt(node["workerId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSchedulerStatus");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("schedulerConfiguredId", this._SchedulerConfiguredId);
			kparams.AddIfNotNull("workerConfiguredId", this._WorkerConfiguredId);
			kparams.AddIfNotNull("workerType", this._WorkerType);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("value", this._Value);
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("workerId", this._WorkerId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case SCHEDULER_CONFIGURED_ID:
					return "SchedulerConfiguredId";
				case WORKER_CONFIGURED_ID:
					return "WorkerConfiguredId";
				case WORKER_TYPE:
					return "WorkerType";
				case TYPE:
					return "Type";
				case VALUE:
					return "Value";
				case SCHEDULER_ID:
					return "SchedulerId";
				case WORKER_ID:
					return "WorkerId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

