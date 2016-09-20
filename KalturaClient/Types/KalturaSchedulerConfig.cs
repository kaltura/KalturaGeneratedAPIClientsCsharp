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

		public KalturaSchedulerConfig(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "createdBy":
						this._CreatedBy = txt;
						continue;
					case "updatedBy":
						this._UpdatedBy = txt;
						continue;
					case "commandId":
						this._CommandId = txt;
						continue;
					case "commandStatus":
						this._CommandStatus = txt;
						continue;
					case "schedulerId":
						this._SchedulerId = ParseInt(txt);
						continue;
					case "schedulerConfiguredId":
						this._SchedulerConfiguredId = ParseInt(txt);
						continue;
					case "schedulerName":
						this._SchedulerName = txt;
						continue;
					case "workerId":
						this._WorkerId = ParseInt(txt);
						continue;
					case "workerConfiguredId":
						this._WorkerConfiguredId = ParseInt(txt);
						continue;
					case "workerName":
						this._WorkerName = txt;
						continue;
					case "variable":
						this._Variable = txt;
						continue;
					case "variablePart":
						this._VariablePart = txt;
						continue;
					case "value":
						this._Value = txt;
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
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("createdBy", this.CreatedBy);
			kparams.AddIfNotNull("updatedBy", this.UpdatedBy);
			kparams.AddIfNotNull("commandId", this.CommandId);
			kparams.AddIfNotNull("commandStatus", this.CommandStatus);
			kparams.AddIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIfNotNull("schedulerConfiguredId", this.SchedulerConfiguredId);
			kparams.AddIfNotNull("schedulerName", this.SchedulerName);
			kparams.AddIfNotNull("workerId", this.WorkerId);
			kparams.AddIfNotNull("workerConfiguredId", this.WorkerConfiguredId);
			kparams.AddIfNotNull("workerName", this.WorkerName);
			kparams.AddIfNotNull("variable", this.Variable);
			kparams.AddIfNotNull("variablePart", this.VariablePart);
			kparams.AddIfNotNull("value", this.Value);
			return kparams;
		}
		#endregion
	}
}

