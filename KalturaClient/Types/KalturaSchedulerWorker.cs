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

namespace Kaltura
{
	public class KalturaSchedulerWorker : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _ConfiguredId = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _SchedulerConfiguredId = Int32.MinValue;
		private KalturaBatchJobType _Type = null;
		private string _TypeName = null;
		private string _Name = null;
		private IList<KalturaSchedulerStatus> _Statuses;
		private IList<KalturaSchedulerConfig> _Configs;
		private IList<KalturaBatchJob> _LockedJobs;
		private int _AvgWait = Int32.MinValue;
		private int _AvgWork = Int32.MinValue;
		private int _LastStatus = Int32.MinValue;
		private string _LastStatusStr = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
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
		public KalturaBatchJobType Type
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
		public IList<KalturaSchedulerStatus> Statuses
		{
			get { return _Statuses; }
			set 
			{ 
				_Statuses = value;
				OnPropertyChanged("Statuses");
			}
		}
		public IList<KalturaSchedulerConfig> Configs
		{
			get { return _Configs; }
			set 
			{ 
				_Configs = value;
				OnPropertyChanged("Configs");
			}
		}
		public IList<KalturaBatchJob> LockedJobs
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
		public KalturaSchedulerWorker()
		{
		}

		public KalturaSchedulerWorker(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "configuredId":
						this.ConfiguredId = ParseInt(txt);
						continue;
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "schedulerConfiguredId":
						this.SchedulerConfiguredId = ParseInt(txt);
						continue;
					case "type":
						this.Type = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "typeName":
						this.TypeName = txt;
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "statuses":
						this.Statuses = new List<KalturaSchedulerStatus>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Statuses.Add((KalturaSchedulerStatus)KalturaObjectFactory.Create(arrayNode, "KalturaSchedulerStatus"));
						}
						continue;
					case "configs":
						this.Configs = new List<KalturaSchedulerConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Configs.Add((KalturaSchedulerConfig)KalturaObjectFactory.Create(arrayNode, "KalturaSchedulerConfig"));
						}
						continue;
					case "lockedJobs":
						this.LockedJobs = new List<KalturaBatchJob>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.LockedJobs.Add((KalturaBatchJob)KalturaObjectFactory.Create(arrayNode, "KalturaBatchJob"));
						}
						continue;
					case "avgWait":
						this.AvgWait = ParseInt(txt);
						continue;
					case "avgWork":
						this.AvgWork = ParseInt(txt);
						continue;
					case "lastStatus":
						this.LastStatus = ParseInt(txt);
						continue;
					case "lastStatusStr":
						this.LastStatusStr = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSchedulerWorker");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("configuredId", this.ConfiguredId);
			kparams.AddIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIfNotNull("schedulerConfiguredId", this.SchedulerConfiguredId);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("typeName", this.TypeName);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("statuses", this.Statuses);
			kparams.AddIfNotNull("configs", this.Configs);
			kparams.AddIfNotNull("lockedJobs", this.LockedJobs);
			kparams.AddIfNotNull("avgWait", this.AvgWait);
			kparams.AddIfNotNull("avgWork", this.AvgWork);
			kparams.AddIfNotNull("lastStatus", this.LastStatus);
			kparams.AddIfNotNull("lastStatusStr", this.LastStatusStr);
			return kparams;
		}
		#endregion
	}
}

