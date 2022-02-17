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
	public class Scheduler : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CONFIGURED_ID = "configuredId";
		public const string NAME = "name";
		public const string HOST = "host";
		public const string STATUSES = "statuses";
		public const string CONFIGS = "configs";
		public const string WORKERS = "workers";
		public const string CREATED_AT = "createdAt";
		public const string LAST_STATUS = "lastStatus";
		public const string LAST_STATUS_STR = "lastStatusStr";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _ConfiguredId = Int32.MinValue;
		private string _Name = null;
		private string _Host = null;
		private IList<SchedulerStatus> _Statuses;
		private IList<SchedulerConfig> _Configs;
		private IList<SchedulerWorker> _Workers;
		private int _CreatedAt = Int32.MinValue;
		private int _LastStatus = Int32.MinValue;
		private string _LastStatusStr = null;
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
		/// Use ConfiguredIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use HostAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		/// <summary>
		/// Use StatusesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SchedulerStatus> Statuses
		{
			get { return _Statuses; }
			private set 
			{ 
				_Statuses = value;
				OnPropertyChanged("Statuses");
			}
		}
		/// <summary>
		/// Use ConfigsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SchedulerConfig> Configs
		{
			get { return _Configs; }
			private set 
			{ 
				_Configs = value;
				OnPropertyChanged("Configs");
			}
		}
		/// <summary>
		/// Use WorkersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<SchedulerWorker> Workers
		{
			get { return _Workers; }
			private set 
			{ 
				_Workers = value;
				OnPropertyChanged("Workers");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use LastStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastStatus
		{
			get { return _LastStatus; }
			private set 
			{ 
				_LastStatus = value;
				OnPropertyChanged("LastStatus");
			}
		}
		/// <summary>
		/// Use LastStatusStrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LastStatusStr
		{
			get { return _LastStatusStr; }
			private set 
			{ 
				_LastStatusStr = value;
				OnPropertyChanged("LastStatusStr");
			}
		}
		#endregion

		#region CTor
		public Scheduler()
		{
		}

		public Scheduler(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["configuredId"] != null)
			{
				this._ConfiguredId = ParseInt(node["configuredId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["host"] != null)
			{
				this._Host = node["host"].Value<string>();
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
			if(node["workers"] != null)
			{
				this._Workers = new List<SchedulerWorker>();
				foreach(var arrayNode in node["workers"].Children())
				{
					this._Workers.Add(ObjectFactory.Create<SchedulerWorker>(arrayNode));
				}
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
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
				kparams.AddReplace("objectType", "KalturaScheduler");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("configuredId", this._ConfiguredId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("statuses", this._Statuses);
			kparams.AddIfNotNull("configs", this._Configs);
			kparams.AddIfNotNull("workers", this._Workers);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
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
				case NAME:
					return "Name";
				case HOST:
					return "Host";
				case STATUSES:
					return "Statuses";
				case CONFIGS:
					return "Configs";
				case WORKERS:
					return "Workers";
				case CREATED_AT:
					return "CreatedAt";
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

