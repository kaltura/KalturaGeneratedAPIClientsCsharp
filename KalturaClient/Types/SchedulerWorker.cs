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
		public int Id
		{
			get { return _Id; }
		}
		public int ConfiguredId
		{
			get { return _ConfiguredId; }
			set 
			{ 
				_ConfiguredId = value;
				OnPropertyChanged("ConfiguredId");
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
		public int SchedulerConfiguredId
		{
			get { return _SchedulerConfiguredId; }
			set 
			{ 
				_SchedulerConfiguredId = value;
				OnPropertyChanged("SchedulerConfiguredId");
			}
		}
		public BatchJobType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string TypeName
		{
			get { return _TypeName; }
			set 
			{ 
				_TypeName = value;
				OnPropertyChanged("TypeName");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public IList<SchedulerStatus> Statuses
		{
			get { return _Statuses; }
			set 
			{ 
				_Statuses = value;
				OnPropertyChanged("Statuses");
			}
		}
		public IList<SchedulerConfig> Configs
		{
			get { return _Configs; }
			set 
			{ 
				_Configs = value;
				OnPropertyChanged("Configs");
			}
		}
		public IList<BatchJob> LockedJobs
		{
			get { return _LockedJobs; }
			set 
			{ 
				_LockedJobs = value;
				OnPropertyChanged("LockedJobs");
			}
		}
		public int AvgWait
		{
			get { return _AvgWait; }
			set 
			{ 
				_AvgWait = value;
				OnPropertyChanged("AvgWait");
			}
		}
		public int AvgWork
		{
			get { return _AvgWork; }
			set 
			{ 
				_AvgWork = value;
				OnPropertyChanged("AvgWork");
			}
		}
		public int LastStatus
		{
			get { return _LastStatus; }
			set 
			{ 
				_LastStatus = value;
				OnPropertyChanged("LastStatus");
			}
		}
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

		public SchedulerWorker(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "configuredId":
						this._ConfiguredId = ParseInt(propertyNode.InnerText);
						continue;
					case "schedulerId":
						this._SchedulerId = ParseInt(propertyNode.InnerText);
						continue;
					case "schedulerConfiguredId":
						this._SchedulerConfiguredId = ParseInt(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), propertyNode.InnerText);
						continue;
					case "typeName":
						this._TypeName = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "statuses":
						this._Statuses = new List<SchedulerStatus>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Statuses.Add(ObjectFactory.Create<SchedulerStatus>(arrayNode));
						}
						continue;
					case "configs":
						this._Configs = new List<SchedulerConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Configs.Add(ObjectFactory.Create<SchedulerConfig>(arrayNode));
						}
						continue;
					case "lockedJobs":
						this._LockedJobs = new List<BatchJob>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._LockedJobs.Add(ObjectFactory.Create<BatchJob>(arrayNode));
						}
						continue;
					case "avgWait":
						this._AvgWait = ParseInt(propertyNode.InnerText);
						continue;
					case "avgWork":
						this._AvgWork = ParseInt(propertyNode.InnerText);
						continue;
					case "lastStatus":
						this._LastStatus = ParseInt(propertyNode.InnerText);
						continue;
					case "lastStatusStr":
						this._LastStatusStr = propertyNode.InnerText;
						continue;
				}
			}
		}

		public SchedulerWorker(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._ConfiguredId = data.TryGetValueSafe<int>("configuredId");
			    this._SchedulerId = data.TryGetValueSafe<int>("schedulerId");
			    this._SchedulerConfiguredId = data.TryGetValueSafe<int>("schedulerConfiguredId");
			    this._Type = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), data.TryGetValueSafe<string>("type"));
			    this._TypeName = data.TryGetValueSafe<string>("typeName");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Statuses = new List<SchedulerStatus>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("statuses", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Statuses.Add(ObjectFactory.Create<SchedulerStatus>((IDictionary<string,object>)dataDictionary));
			    }
			    this._Configs = new List<SchedulerConfig>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("configs", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Configs.Add(ObjectFactory.Create<SchedulerConfig>((IDictionary<string,object>)dataDictionary));
			    }
			    this._LockedJobs = new List<BatchJob>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("lockedJobs", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._LockedJobs.Add(ObjectFactory.Create<BatchJob>((IDictionary<string,object>)dataDictionary));
			    }
			    this._AvgWait = data.TryGetValueSafe<int>("avgWait");
			    this._AvgWork = data.TryGetValueSafe<int>("avgWork");
			    this._LastStatus = data.TryGetValueSafe<int>("lastStatus");
			    this._LastStatusStr = data.TryGetValueSafe<string>("lastStatusStr");
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

