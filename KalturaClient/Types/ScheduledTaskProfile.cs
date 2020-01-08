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
// Copyright (C) 2006-2020  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		[JsonProperty]
		public ScheduledTaskProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public ObjectFilterEngineType ObjectFilterEngineType
		{
			get { return _ObjectFilterEngineType; }
			set 
			{ 
				_ObjectFilterEngineType = value;
				OnPropertyChanged("ObjectFilterEngineType");
			}
		}
		[JsonProperty]
		public Filter ObjectFilter
		{
			get { return _ObjectFilter; }
			set 
			{ 
				_ObjectFilter = value;
				OnPropertyChanged("ObjectFilter");
			}
		}
		[JsonProperty]
		public IList<ObjectTask> ObjectTasks
		{
			get { return _ObjectTasks; }
			set 
			{ 
				_ObjectTasks = value;
				OnPropertyChanged("ObjectTasks");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public int LastExecutionStartedAt
		{
			get { return _LastExecutionStartedAt; }
			set 
			{ 
				_LastExecutionStartedAt = value;
				OnPropertyChanged("LastExecutionStartedAt");
			}
		}
		[JsonProperty]
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

		public ScheduledTaskProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ScheduledTaskProfileStatus)ParseEnum(typeof(ScheduledTaskProfileStatus), node["status"].Value<string>());
			}
			if(node["objectFilterEngineType"] != null)
			{
				this._ObjectFilterEngineType = (ObjectFilterEngineType)StringEnum.Parse(typeof(ObjectFilterEngineType), node["objectFilterEngineType"].Value<string>());
			}
			if(node["objectFilter"] != null)
			{
				this._ObjectFilter = ObjectFactory.Create<Filter>(node["objectFilter"]);
			}
			if(node["objectTasks"] != null)
			{
				this._ObjectTasks = new List<ObjectTask>();
				foreach(var arrayNode in node["objectTasks"].Children())
				{
					this._ObjectTasks.Add(ObjectFactory.Create<ObjectTask>(arrayNode));
				}
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["lastExecutionStartedAt"] != null)
			{
				this._LastExecutionStartedAt = ParseInt(node["lastExecutionStartedAt"].Value<string>());
			}
			if(node["maxTotalCountAllowed"] != null)
			{
				this._MaxTotalCountAllowed = ParseInt(node["maxTotalCountAllowed"].Value<string>());
			}
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

