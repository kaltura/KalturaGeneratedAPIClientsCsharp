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
	public class ScheduledTaskProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string STATUS = "status";
		public const string OBJECT_FILTER_ENGINE_TYPE = "objectFilterEngineType";
		public const string OBJECT_FILTER = "objectFilter";
		public const string OBJECT_TASKS = "objectTasks";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string LAST_EXECUTION_STARTED_AT = "lastExecutionStartedAt";
		public const string MAX_TOTAL_COUNT_ALLOWED = "maxTotalCountAllowed";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private ScheduledTaskProfileStatus _Status = (ScheduledTaskProfileStatus)Int32.MinValue;
		private ObjectFilterEngineType _ObjectFilterEngineType = null;
		private Filter _ObjectFilter;
		private IList<ObjectTask> _ObjectTasks;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _LastExecutionStartedAt = Int32.MinValue;
		private int _MaxTotalCountAllowed = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
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
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
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
		public ScheduledTaskProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public ObjectFilterEngineType ObjectFilterEngineType
		{
			get { return _ObjectFilterEngineType; }
			set 
			{ 
				_ObjectFilterEngineType = value;
				OnPropertyChanged("ObjectFilterEngineType");
			}
		}
		public Filter ObjectFilter
		{
			get { return _ObjectFilter; }
			set 
			{ 
				_ObjectFilter = value;
				OnPropertyChanged("ObjectFilter");
			}
		}
		public IList<ObjectTask> ObjectTasks
		{
			get { return _ObjectTasks; }
			set 
			{ 
				_ObjectTasks = value;
				OnPropertyChanged("ObjectTasks");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int LastExecutionStartedAt
		{
			get { return _LastExecutionStartedAt; }
			set 
			{ 
				_LastExecutionStartedAt = value;
				OnPropertyChanged("LastExecutionStartedAt");
			}
		}
		public int MaxTotalCountAllowed
		{
			get { return _MaxTotalCountAllowed; }
			set 
			{ 
				_MaxTotalCountAllowed = value;
				OnPropertyChanged("MaxTotalCountAllowed");
			}
		}
		#endregion

		#region CTor
		public ScheduledTaskProfile()
		{
		}

		public ScheduledTaskProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (ScheduledTaskProfileStatus)ParseEnum(typeof(ScheduledTaskProfileStatus), propertyNode.InnerText);
						continue;
					case "objectFilterEngineType":
						this._ObjectFilterEngineType = (ObjectFilterEngineType)StringEnum.Parse(typeof(ObjectFilterEngineType), propertyNode.InnerText);
						continue;
					case "objectFilter":
						this._ObjectFilter = ObjectFactory.Create<Filter>(propertyNode);
						continue;
					case "objectTasks":
						this._ObjectTasks = new List<ObjectTask>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ObjectTasks.Add(ObjectFactory.Create<ObjectTask>(arrayNode));
						}
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "lastExecutionStartedAt":
						this._LastExecutionStartedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "maxTotalCountAllowed":
						this._MaxTotalCountAllowed = ParseInt(propertyNode.InnerText);
						continue;
				}
			}
		}

		public ScheduledTaskProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Status = (ScheduledTaskProfileStatus)ParseEnum(typeof(ScheduledTaskProfileStatus), data.TryGetValueSafe<int>("status"));
			    this._ObjectFilterEngineType = (ObjectFilterEngineType)StringEnum.Parse(typeof(ObjectFilterEngineType), data.TryGetValueSafe<string>("objectFilterEngineType"));
			    this._ObjectFilter = ObjectFactory.Create<Filter>(data.TryGetValueSafe<IDictionary<string,object>>("objectFilter"));
			    this._ObjectTasks = new List<ObjectTask>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("objectTasks", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._ObjectTasks.Add(ObjectFactory.Create<ObjectTask>((IDictionary<string,object>)dataDictionary));
			    }
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._LastExecutionStartedAt = data.TryGetValueSafe<int>("lastExecutionStartedAt");
			    this._MaxTotalCountAllowed = data.TryGetValueSafe<int>("maxTotalCountAllowed");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduledTaskProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("objectFilterEngineType", this._ObjectFilterEngineType);
			kparams.AddIfNotNull("objectFilter", this._ObjectFilter);
			kparams.AddIfNotNull("objectTasks", this._ObjectTasks);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("lastExecutionStartedAt", this._LastExecutionStartedAt);
			kparams.AddIfNotNull("maxTotalCountAllowed", this._MaxTotalCountAllowed);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case STATUS:
					return "Status";
				case OBJECT_FILTER_ENGINE_TYPE:
					return "ObjectFilterEngineType";
				case OBJECT_FILTER:
					return "ObjectFilter";
				case OBJECT_TASKS:
					return "ObjectTasks";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case LAST_EXECUTION_STARTED_AT:
					return "LastExecutionStartedAt";
				case MAX_TOTAL_COUNT_ALLOWED:
					return "MaxTotalCountAllowed";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

