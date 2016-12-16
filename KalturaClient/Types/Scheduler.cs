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
// Copyright (C) 2006-2016  Kaltura Inc.
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		public IList<SchedulerStatus> Statuses
		{
			get { return _Statuses; }
		}
		public IList<SchedulerConfig> Configs
		{
			get { return _Configs; }
		}
		public IList<SchedulerWorker> Workers
		{
			get { return _Workers; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int LastStatus
		{
			get { return _LastStatus; }
		}
		public string LastStatusStr
		{
			get { return _LastStatusStr; }
		}
		#endregion

		#region CTor
		public Scheduler()
		{
		}

		public Scheduler(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "configuredId":
						this._ConfiguredId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "host":
						this._Host = txt;
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
					case "workers":
						this._Workers = new List<SchedulerWorker>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Workers.Add(ObjectFactory.Create<SchedulerWorker>(arrayNode));
						}
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "lastStatus":
						this._LastStatus = ParseInt(txt);
						continue;
					case "lastStatusStr":
						this._LastStatusStr = txt;
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

