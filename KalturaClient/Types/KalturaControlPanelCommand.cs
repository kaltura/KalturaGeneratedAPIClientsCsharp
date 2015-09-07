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
	public class KalturaControlPanelCommand : KalturaObjectBase
	{
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
		private KalturaControlPanelCommandType _Type = (KalturaControlPanelCommandType)Int32.MinValue;
		private KalturaControlPanelCommandTargetType _TargetType = (KalturaControlPanelCommandTargetType)Int32.MinValue;
		private KalturaControlPanelCommandStatus _Status = (KalturaControlPanelCommandStatus)Int32.MinValue;
		private string _Cause = null;
		private string _Description = null;
		private string _ErrorDescription = null;
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
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
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
		public KalturaControlPanelCommandType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaControlPanelCommandTargetType TargetType
		{
			get { return _TargetType; }
			set 
			{ 
				_TargetType = value;
				OnPropertyChanged("TargetType");
			}
		}
		public KalturaControlPanelCommandStatus Status
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
		public KalturaControlPanelCommand()
		{
		}

		public KalturaControlPanelCommand(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "createdBy":
						this.CreatedBy = txt;
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "updatedBy":
						this.UpdatedBy = txt;
						continue;
					case "createdById":
						this.CreatedById = ParseInt(txt);
						continue;
					case "schedulerId":
						this.SchedulerId = ParseInt(txt);
						continue;
					case "workerId":
						this.WorkerId = ParseInt(txt);
						continue;
					case "workerConfiguredId":
						this.WorkerConfiguredId = ParseInt(txt);
						continue;
					case "workerName":
						this.WorkerName = ParseInt(txt);
						continue;
					case "batchIndex":
						this.BatchIndex = ParseInt(txt);
						continue;
					case "type":
						this.Type = (KalturaControlPanelCommandType)ParseEnum(typeof(KalturaControlPanelCommandType), txt);
						continue;
					case "targetType":
						this.TargetType = (KalturaControlPanelCommandTargetType)ParseEnum(typeof(KalturaControlPanelCommandTargetType), txt);
						continue;
					case "status":
						this.Status = (KalturaControlPanelCommandStatus)ParseEnum(typeof(KalturaControlPanelCommandStatus), txt);
						continue;
					case "cause":
						this.Cause = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "errorDescription":
						this.ErrorDescription = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaControlPanelCommand");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("createdBy", this.CreatedBy);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("updatedBy", this.UpdatedBy);
			kparams.AddIfNotNull("createdById", this.CreatedById);
			kparams.AddIfNotNull("schedulerId", this.SchedulerId);
			kparams.AddIfNotNull("workerId", this.WorkerId);
			kparams.AddIfNotNull("workerConfiguredId", this.WorkerConfiguredId);
			kparams.AddIfNotNull("workerName", this.WorkerName);
			kparams.AddIfNotNull("batchIndex", this.BatchIndex);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("targetType", this.TargetType);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("cause", this.Cause);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("errorDescription", this.ErrorDescription);
			return kparams;
		}
		#endregion
	}
}

