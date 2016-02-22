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
	public class KalturaScheduler : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _ConfiguredId = Int32.MinValue;
		private string _Name = null;
		private string _Host = null;
		private IList<KalturaSchedulerStatus> _Statuses;
		private IList<KalturaSchedulerConfig> _Configs;
		private IList<KalturaSchedulerWorker> _Workers;
		private int _CreatedAt = Int32.MinValue;
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
		public IList<KalturaSchedulerWorker> Workers
		{
			get { return _Workers; }
			set 
			{ 
				_Workers = value;
				OnPropertyChanged("Workers");
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
		public KalturaScheduler()
		{
		}

		public KalturaScheduler(XmlElement node) : base(node)
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
					case "name":
						this.Name = txt;
						continue;
					case "host":
						this.Host = txt;
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
					case "workers":
						this.Workers = new List<KalturaSchedulerWorker>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Workers.Add((KalturaSchedulerWorker)KalturaObjectFactory.Create(arrayNode, "KalturaSchedulerWorker"));
						}
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
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
			kparams.AddReplace("objectType", "KalturaScheduler");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("configuredId", this.ConfiguredId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("host", this.Host);
			kparams.AddIfNotNull("statuses", this.Statuses);
			kparams.AddIfNotNull("configs", this.Configs);
			kparams.AddIfNotNull("workers", this.Workers);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("lastStatus", this.LastStatus);
			kparams.AddIfNotNull("lastStatusStr", this.LastStatusStr);
			return kparams;
		}
		#endregion
	}
}

