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
		public int Id
		{
			get { return _Id; }
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
		public BatchJobType WorkerType
		{
			get { return _WorkerType; }
			set 
			{ 
				_WorkerType = value;
				OnPropertyChanged("WorkerType");
			}
		}
		public SchedulerStatusType Type
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
		}
		public int WorkerId
		{
			get { return _WorkerId; }
		}
		#endregion

		#region CTor
		public SchedulerStatus()
		{
		}

		public SchedulerStatus(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "schedulerConfiguredId":
						this._SchedulerConfiguredId = ParseInt(txt);
						continue;
					case "workerConfiguredId":
						this._WorkerConfiguredId = ParseInt(txt);
						continue;
					case "workerType":
						this._WorkerType = (BatchJobType)StringEnum.Parse(typeof(BatchJobType), txt);
						continue;
					case "type":
						this._Type = (SchedulerStatusType)ParseEnum(typeof(SchedulerStatusType), txt);
						continue;
					case "value":
						this._Value = ParseInt(txt);
						continue;
					case "schedulerId":
						this._SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this._WorkerId = ParseInt(txt);
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

