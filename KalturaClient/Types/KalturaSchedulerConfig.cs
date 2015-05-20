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
	public class KalturaSchedulerConfig : KalturaObjectBase
	{
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
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string CreatedBy
		{
			get { return _CreatedBy; }
			set 
			{ 
				_CreatedBy = value;
				OnPropertyChanged("CreatedBy");
			}
		}
		public string UpdatedBy
		{
			get { return _UpdatedBy; }
			set 
			{ 
				_UpdatedBy = value;
				OnPropertyChanged("UpdatedBy");
			}
		}
		public string CommandId
		{
			get { return _CommandId; }
			set 
			{ 
				_CommandId = value;
				OnPropertyChanged("CommandId");
			}
		}
		public string CommandStatus
		{
			get { return _CommandStatus; }
			set 
			{ 
				_CommandStatus = value;
				OnPropertyChanged("CommandStatus");
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
		public string SchedulerName
		{
			get { return _SchedulerName; }
			set 
			{ 
				_SchedulerName = value;
				OnPropertyChanged("SchedulerName");
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
		public int WorkerConfiguredId
		{
			get { return _WorkerConfiguredId; }
			set 
			{ 
				_WorkerConfiguredId = value;
				OnPropertyChanged("WorkerConfiguredId");
			}
		}
		public string WorkerName
		{
			get { return _WorkerName; }
			set 
			{ 
				_WorkerName = value;
				OnPropertyChanged("WorkerName");
			}
		}
		public string Variable
		{
			get { return _Variable; }
			set 
			{ 
				_Variable = value;
				OnPropertyChanged("Variable");
			}
		}
		public string VariablePart
		{
			get { return _VariablePart; }
			set 
			{ 
				_VariablePart = value;
				OnPropertyChanged("VariablePart");
			}
		}
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
		public KalturaSchedulerConfig()
		{
		}

		public KalturaSchedulerConfig(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdBy":
						this.CreatedBy = txt;
						continue;
					case "updatedBy":
						this.UpdatedBy = txt;
						continue;
					case "commandId":
						this.CommandId = txt;
						continue;
					case "commandStatus":
						this.CommandStatus = txt;
						continue;
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "schedulerConfiguredId":
						this.SchedulerConfiguredId = ParseInt(txt);
						continue;
					case "schedulerName":
						this.SchedulerName = txt;
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "workerConfiguredId":
						this.WorkerConfiguredId = ParseInt(txt);
						continue;
					case "workerName":
						this.WorkerName = txt;
						continue;
					case "variable":
						this.Variable = txt;
						continue;
					case "variablePart":
						this.VariablePart = txt;
						continue;
					case "value":
						this.Value = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSchedulerConfig");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddStringIfNotNull("createdBy", this.CreatedBy);
			kparams.AddStringIfNotNull("updatedBy", this.UpdatedBy);
			kparams.AddStringIfNotNull("commandId", this.CommandId);
			kparams.AddStringIfNotNull("commandStatus", this.CommandStatus);
			kparams.AddIntIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIntIfNotNull("schedulerConfiguredId", this.SchedulerConfiguredId);
			kparams.AddStringIfNotNull("schedulerName", this.SchedulerName);
			kparams.AddIntIfNotNull("workerId", this.WorkerId);
			kparams.AddIntIfNotNull("workerConfiguredId", this.WorkerConfiguredId);
			kparams.AddStringIfNotNull("workerName", this.WorkerName);
			kparams.AddStringIfNotNull("variable", this.Variable);
			kparams.AddStringIfNotNull("variablePart", this.VariablePart);
			kparams.AddStringIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

