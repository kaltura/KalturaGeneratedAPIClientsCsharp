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
	public class KalturaSchedulerStatus : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _SchedulerConfiguredId = Int32.MinValue;
		private int _WorkerConfiguredId = Int32.MinValue;
		private KalturaBatchJobType _WorkerType = null;
		private KalturaSchedulerStatusType _Type = (KalturaSchedulerStatusType)Int32.MinValue;
		private int _Value = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
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
		public int SchedulerConfiguredId
		{
			get { return _SchedulerConfiguredId; }
			set 
			{ 
				_SchedulerConfiguredId = value;
				OnPropertyChanged("SchedulerConfiguredId");
			}
		}
		public int WorkerConfiguredId
		{
			get { return _WorkerConfiguredId; }
			set 
			{ 
				_WorkerConfiguredId = value;
				OnPropertyChanged("WorkerConfiguredId");
			}
		}
		public KalturaBatchJobType WorkerType
		{
			get { return _WorkerType; }
			set 
			{ 
				_WorkerType = value;
				OnPropertyChanged("WorkerType");
			}
		}
		public KalturaSchedulerStatusType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public int Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
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
		#endregion

		#region CTor
		public KalturaSchedulerStatus()
		{
		}

		public KalturaSchedulerStatus(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "schedulerConfiguredId":
						this.SchedulerConfiguredId = ParseInt(txt);
						continue;
					case "workerConfiguredId":
						this.WorkerConfiguredId = ParseInt(txt);
						continue;
					case "workerType":
						this.WorkerType = (KalturaBatchJobType)KalturaStringEnum.Parse(typeof(KalturaBatchJobType), txt);
						continue;
					case "type":
						this.Type = (KalturaSchedulerStatusType)ParseEnum(typeof(KalturaSchedulerStatusType), txt);
						continue;
					case "value":
						this.Value = ParseInt(txt);
						continue;
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSchedulerStatus");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("schedulerConfiguredId", this.SchedulerConfiguredId);
			kparams.AddIntIfNotNull("workerConfiguredId", this.WorkerConfiguredId);
			kparams.AddStringEnumIfNotNull("workerType", this.WorkerType);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddIntIfNotNull("value", this.Value);
			kparams.AddIntIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIntIfNotNull("workerId", this.WorkerId);
			return kparams;
		}
		#endregion
	}
}

