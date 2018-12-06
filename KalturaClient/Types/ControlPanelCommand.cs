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
	public class ControlPanelCommand : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string CREATED_BY = "createdBy";
		public const string UPDATED_AT = "updatedAt";
		public const string UPDATED_BY = "updatedBy";
		public const string CREATED_BY_ID = "createdById";
		public const string SCHEDULER_ID = "schedulerId";
		public const string WORKER_ID = "workerId";
		public const string WORKER_CONFIGURED_ID = "workerConfiguredId";
		public const string WORKER_NAME = "workerName";
		public const string BATCH_INDEX = "batchIndex";
		public const string TYPE = "type";
		public const string TARGET_TYPE = "targetType";
		public const string STATUS = "status";
		public const string CAUSE = "cause";
		public const string DESCRIPTION = "description";
		public const string ERROR_DESCRIPTION = "errorDescription";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private string _CreatedBy = null;
		private int _UpdatedAt = Int32.MinValue;
		private string _UpdatedBy = null;
		private int _CreatedById = Int32.MinValue;
		private int _SchedulerId = Int32.MinValue;
		private int _WorkerId = Int32.MinValue;
		private int _WorkerConfiguredId = Int32.MinValue;
		private int _WorkerName = Int32.MinValue;
		private int _BatchIndex = Int32.MinValue;
		private ControlPanelCommandType _Type = (ControlPanelCommandType)Int32.MinValue;
		private ControlPanelCommandTargetType _TargetType = (ControlPanelCommandTargetType)Int32.MinValue;
		private ControlPanelCommandStatus _Status = (ControlPanelCommandStatus)Int32.MinValue;
		private string _Cause = null;
		private string _Description = null;
		private string _ErrorDescription = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
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
		public int CreatedById
		{
			get { return _CreatedById; }
			set 
			{ 
				_CreatedById = value;
				OnPropertyChanged("CreatedById");
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
		public int WorkerConfiguredId
		{
			get { return _WorkerConfiguredId; }
			set 
			{ 
				_WorkerConfiguredId = value;
				OnPropertyChanged("WorkerConfiguredId");
			}
		}
		public int WorkerName
		{
			get { return _WorkerName; }
			set 
			{ 
				_WorkerName = value;
				OnPropertyChanged("WorkerName");
			}
		}
		public int BatchIndex
		{
			get { return _BatchIndex; }
			set 
			{ 
				_BatchIndex = value;
				OnPropertyChanged("BatchIndex");
			}
		}
		public ControlPanelCommandType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public ControlPanelCommandTargetType TargetType
		{
			get { return _TargetType; }
			set 
			{ 
				_TargetType = value;
				OnPropertyChanged("TargetType");
			}
		}
		public ControlPanelCommandStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string Cause
		{
			get { return _Cause; }
			set 
			{ 
				_Cause = value;
				OnPropertyChanged("Cause");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		#endregion

		#region CTor
		public ControlPanelCommand()
		{
		}

		public ControlPanelCommand(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "createdBy":
						this._CreatedBy = propertyNode.InnerText;
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedBy":
						this._UpdatedBy = propertyNode.InnerText;
						continue;
					case "createdById":
						this._CreatedById = ParseInt(propertyNode.InnerText);
						continue;
					case "schedulerId":
						this._SchedulerId = ParseInt(propertyNode.InnerText);
						continue;
					case "workerId":
						this._WorkerId = ParseInt(propertyNode.InnerText);
						continue;
					case "workerConfiguredId":
						this._WorkerConfiguredId = ParseInt(propertyNode.InnerText);
						continue;
					case "workerName":
						this._WorkerName = ParseInt(propertyNode.InnerText);
						continue;
					case "batchIndex":
						this._BatchIndex = ParseInt(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (ControlPanelCommandType)ParseEnum(typeof(ControlPanelCommandType), propertyNode.InnerText);
						continue;
					case "targetType":
						this._TargetType = (ControlPanelCommandTargetType)ParseEnum(typeof(ControlPanelCommandTargetType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (ControlPanelCommandStatus)ParseEnum(typeof(ControlPanelCommandStatus), propertyNode.InnerText);
						continue;
					case "cause":
						this._Cause = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
				}
			}
		}

		public ControlPanelCommand(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._CreatedBy = data.TryGetValueSafe<string>("createdBy");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._UpdatedBy = data.TryGetValueSafe<string>("updatedBy");
			    this._CreatedById = data.TryGetValueSafe<int>("createdById");
			    this._SchedulerId = data.TryGetValueSafe<int>("schedulerId");
			    this._WorkerId = data.TryGetValueSafe<int>("workerId");
			    this._WorkerConfiguredId = data.TryGetValueSafe<int>("workerConfiguredId");
			    this._WorkerName = data.TryGetValueSafe<int>("workerName");
			    this._BatchIndex = data.TryGetValueSafe<int>("batchIndex");
			    this._Type = (ControlPanelCommandType)ParseEnum(typeof(ControlPanelCommandType), data.TryGetValueSafe<int>("type"));
			    this._TargetType = (ControlPanelCommandTargetType)ParseEnum(typeof(ControlPanelCommandTargetType), data.TryGetValueSafe<int>("targetType"));
			    this._Status = (ControlPanelCommandStatus)ParseEnum(typeof(ControlPanelCommandStatus), data.TryGetValueSafe<int>("status"));
			    this._Cause = data.TryGetValueSafe<string>("cause");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._ErrorDescription = data.TryGetValueSafe<string>("errorDescription");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaControlPanelCommand");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("createdBy", this._CreatedBy);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("updatedBy", this._UpdatedBy);
			kparams.AddIfNotNull("createdById", this._CreatedById);
			kparams.AddIfNotNull("schedulerId", this._SchedulerId);
			kparams.AddIfNotNull("workerId", this._WorkerId);
			kparams.AddIfNotNull("workerConfiguredId", this._WorkerConfiguredId);
			kparams.AddIfNotNull("workerName", this._WorkerName);
			kparams.AddIfNotNull("batchIndex", this._BatchIndex);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("targetType", this._TargetType);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("cause", this._Cause);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case CREATED_BY:
					return "CreatedBy";
				case UPDATED_AT:
					return "UpdatedAt";
				case UPDATED_BY:
					return "UpdatedBy";
				case CREATED_BY_ID:
					return "CreatedById";
				case SCHEDULER_ID:
					return "SchedulerId";
				case WORKER_ID:
					return "WorkerId";
				case WORKER_CONFIGURED_ID:
					return "WorkerConfiguredId";
				case WORKER_NAME:
					return "WorkerName";
				case BATCH_INDEX:
					return "BatchIndex";
				case TYPE:
					return "Type";
				case TARGET_TYPE:
					return "TargetType";
				case STATUS:
					return "Status";
				case CAUSE:
					return "Cause";
				case DESCRIPTION:
					return "Description";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

