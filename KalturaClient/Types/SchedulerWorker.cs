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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class SchedulerWorker : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CONFIGURED_ID = "configuredId";
		public const string SCHEDULER_ID = "schedulerId";
		public const string SCHEDULER_CONFIGURED_ID = "schedulerConfiguredId";
		public const string TYPE = "type";
		public const string TYPE_NAME = "typeName";
		public const string NAME = "name";
		public const string STATUSES = "statuses";
		public const string CONFIGS = "configs";
		public const string LOCKED_JOBS = "lockedJobs";
		public const string AVG_WAIT = "avgWait";
		public const string AVG_WORK = "avgWork";
		public const string LAST_STATUS = "lastStatus";
		public const string LAST_STATUS_STR = "lastStatusStr";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _ConfiguredId = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _SchedulerConfiguredId = Int32.MinValue;
		private BatchJobType _Type = null;
		private string _TypeName = null;
		private string _Name = null;
		private IList<SchedulerStatus> _Statuses;
		private IList<SchedulerConfig> _Configs;
		private IList<BatchJob> _LockedJobs;
		private int _AvgWait = Int32.MinValue;
		private int _AvgWork = Int32.MinValue;
		private int _LastStatus = Int32.MinValue;
		private string _LastStatusStr = null;
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
		public int ConfiguredId
		{
			get { return _ConfiguredId; }
			set 
			{ 
				_ConfiguredId = value;
				OnPropertyChanged("ConfiguredId");
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
		public BatchJobType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string TypeName
		{
			get { return _TypeName; }
			set 
			{ 
				_TypeName = value;
				OnPropertyChanged("TypeName");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public IList<SchedulerStatus> Statuses
		{
			get { return _Statuses; }
			set 
			{ 
				_Statuses = value;
				OnPropertyChanged("Statuses");
			}
		}
		[JsonProperty]
		public IList<SchedulerConfig> Configs
		{
			get { return _Configs; }
			set 
			{ 
				_Configs = value;
				OnPropertyChanged("Configs");
			}
		}
		[JsonProperty]
		public IList<BatchJob> LockedJobs
		{
			get { return _LockedJobs; }
			set 
			{ 
				_LockedJobs = value;
				OnPropertyChanged("LockedJobs");
			}
		}
		[JsonProperty]
		public int AvgWait
		{
			get { return _AvgWait; }
			set 
			{ 
				_AvgWait = value;
				OnPropertyChanged("AvgWait");
			}
		}
		[JsonProperty]
		public int AvgWork
		{
			get { return _AvgWork; }
			set 
			{ 
				_AvgWork = value;
				OnPropertyChanged("AvgWork");
			}
		}
		[JsonProperty]
		public int LastStatus
		{
			get { return _LastStatus; }
			set 
			{ 
				_LastStatus = value;
				OnPropertyChanged("LastStatus");
			}
		}
		[JsonProperty]
		public string LastStatusStr
		{
			get { return _LastStatusStr; }
			set 
			{ 
				_LastStatusStr = value;
				OnPropertyChanged("LastStatusStr");
			}
		}
		#endregion

		#region CTor
		public SchedulerWorker()
		{
		}

		public SchedulerWorker(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["configuredId"] != null)
			{
				this._ConfiguredId = ParseInt(node["configuredId"].Value<string>());
			}
			if(node["schedulerId"] != null)
			{
				this._SchedulerId = ParseInt(node["schedulerId"].Value<string>());
			}
			if(node["schedulerConfiguredId"] != null)
			{
				this._SchedulerConfiguredId = ParseInt(node["schedulerConfiguredId"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), node["type"].Value<string>());
			}
			if(node["typeName"] != null)
			{
				this._TypeName = node["typeName"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["statuses"] != null)
			{
				this._Statuses = new List<SchedulerStatus>();
				foreach(var arrayNode in node["statuses"].Children())
				{
					this._Statuses.Add(ObjectFactory.Create<SchedulerStatus>(arrayNode));
				}
			}
			if(node["configs"] != null)
			{
				this._Configs = new List<SchedulerConfig>();
				foreach(var arrayNode in node["configs"].Children())
				{
					this._Configs.Add(ObjectFactory.Create<SchedulerConfig>(arrayNode));
				}
			}
			if(node["lockedJobs"] != null)
			{
				this._LockedJobs = new List<BatchJob>();
				foreach(var arrayNode in node["lockedJobs"].Children())
				{
					this._LockedJobs.Add(ObjectFactory.Create<BatchJob>(arrayNode));
				}
			}
			if(node["avgWait"] != null)
			{
				this._AvgWait = ParseInt(node["avgWait"].Value<string>());
			}
			if(node["avgWork"] != null)
			{
				this._AvgWork = ParseInt(node["avgWork"].Value<string>());
			}
			if(node["lastStatus"] != null)
			{
				this._LastStatus = ParseInt(node["lastStatus"].Value<string>());
			}
			if(node["lastStatusStr"] != null)
			{
				this._LastStatusStr = node["lastStatusStr"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSchedulerWorker");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("configuredId", this._ConfiguredId);
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("schedulerConfiguredId", this._SchedulerConfiguredId);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("typeName", this._TypeName);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("statuses", this._Statuses);
			kparams.AddIfNotNull("configs", this._Configs);
			kparams.AddIfNotNull("lockedJobs", this._LockedJobs);
			kparams.AddIfNotNull("avgWait", this._AvgWait);
			kparams.AddIfNotNull("avgWork", this._AvgWork);
			kparams.AddIfNotNull("lastStatus", this._LastStatus);
			kparams.AddIfNotNull("lastStatusStr", this._LastStatusStr);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CONFIGURED_ID:
					return "ConfiguredId";
				case SCHEDULER_ID:
					return "SchedulerId";
				case SCHEDULER_CONFIGURED_ID:
					return "SchedulerConfiguredId";
				case TYPE:
					return "Type";
				case TYPE_NAME:
					return "TypeName";
				case NAME:
					return "Name";
				case STATUSES:
					return "Statuses";
				case CONFIGS:
					return "Configs";
				case LOCKED_JOBS:
					return "LockedJobs";
				case AVG_WAIT:
					return "AvgWait";
				case AVG_WORK:
					return "AvgWork";
				case LAST_STATUS:
					return "LastStatus";
				case LAST_STATUS_STR:
					return "LastStatusStr";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

