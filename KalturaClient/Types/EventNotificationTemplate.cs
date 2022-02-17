// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class EventNotificationTemplate : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string TYPE = "type";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string MANUAL_DISPATCH_ENABLED = "manualDispatchEnabled";
		public const string AUTOMATIC_DISPATCH_ENABLED = "automaticDispatchEnabled";
		public const string EVENT_TYPE = "eventType";
		public const string EVENT_OBJECT_TYPE = "eventObjectType";
		public const string EVENT_CONDITIONS = "eventConditions";
		public const string CONTENT_PARAMETERS = "contentParameters";
		public const string USER_PARAMETERS = "userParameters";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private EventNotificationTemplateType _Type = null;
		private EventNotificationTemplateStatus _Status = (EventNotificationTemplateStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private bool? _ManualDispatchEnabled = null;
		private bool? _AutomaticDispatchEnabled = null;
		private EventNotificationEventType _EventType = null;
		private EventNotificationEventObjectType _EventObjectType = null;
		private IList<Condition> _EventConditions;
		private IList<EventNotificationParameter> _ContentParameters;
		private IList<EventNotificationParameter> _UserParameters;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use TypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EventNotificationTemplateType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EventNotificationTemplateStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ManualDispatchEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? ManualDispatchEnabled
		{
			get { return _ManualDispatchEnabled; }
			set 
			{ 
				_ManualDispatchEnabled = value;
				OnPropertyChanged("ManualDispatchEnabled");
			}
		}
		/// <summary>
		/// Use AutomaticDispatchEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? AutomaticDispatchEnabled
		{
			get { return _AutomaticDispatchEnabled; }
			set 
			{ 
				_AutomaticDispatchEnabled = value;
				OnPropertyChanged("AutomaticDispatchEnabled");
			}
		}
		/// <summary>
		/// Use EventTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EventNotificationEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		/// <summary>
		/// Use EventObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EventNotificationEventObjectType EventObjectType
		{
			get { return _EventObjectType; }
			set 
			{ 
				_EventObjectType = value;
				OnPropertyChanged("EventObjectType");
			}
		}
		/// <summary>
		/// Use EventConditionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<Condition> EventConditions
		{
			get { return _EventConditions; }
			set 
			{ 
				_EventConditions = value;
				OnPropertyChanged("EventConditions");
			}
		}
		/// <summary>
		/// Use ContentParametersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<EventNotificationParameter> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
		/// <summary>
		/// Use UserParametersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<EventNotificationParameter> UserParameters
		{
			get { return _UserParameters; }
			set 
			{ 
				_UserParameters = value;
				OnPropertyChanged("UserParameters");
			}
		}
		#endregion

		#region CTor
		public EventNotificationTemplate()
		{
		}

		public EventNotificationTemplate(JToken node) : base(node)
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
			if(node["type"] != null)
			{
				this._Type = (EventNotificationTemplateType)StringEnum.Parse(typeof(EventNotificationTemplateType), node["type"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (EventNotificationTemplateStatus)ParseEnum(typeof(EventNotificationTemplateStatus), node["status"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["manualDispatchEnabled"] != null)
			{
				this._ManualDispatchEnabled = ParseBool(node["manualDispatchEnabled"].Value<string>());
			}
			if(node["automaticDispatchEnabled"] != null)
			{
				this._AutomaticDispatchEnabled = ParseBool(node["automaticDispatchEnabled"].Value<string>());
			}
			if(node["eventType"] != null)
			{
				this._EventType = (EventNotificationEventType)StringEnum.Parse(typeof(EventNotificationEventType), node["eventType"].Value<string>());
			}
			if(node["eventObjectType"] != null)
			{
				this._EventObjectType = (EventNotificationEventObjectType)StringEnum.Parse(typeof(EventNotificationEventObjectType), node["eventObjectType"].Value<string>());
			}
			if(node["eventConditions"] != null)
			{
				this._EventConditions = new List<Condition>();
				foreach(var arrayNode in node["eventConditions"].Children())
				{
					this._EventConditions.Add(ObjectFactory.Create<Condition>(arrayNode));
				}
			}
			if(node["contentParameters"] != null)
			{
				this._ContentParameters = new List<EventNotificationParameter>();
				foreach(var arrayNode in node["contentParameters"].Children())
				{
					this._ContentParameters.Add(ObjectFactory.Create<EventNotificationParameter>(arrayNode));
				}
			}
			if(node["userParameters"] != null)
			{
				this._UserParameters = new List<EventNotificationParameter>();
				foreach(var arrayNode in node["userParameters"].Children())
				{
					this._UserParameters.Add(ObjectFactory.Create<EventNotificationParameter>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEventNotificationTemplate");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("manualDispatchEnabled", this._ManualDispatchEnabled);
			kparams.AddIfNotNull("automaticDispatchEnabled", this._AutomaticDispatchEnabled);
			kparams.AddIfNotNull("eventType", this._EventType);
			kparams.AddIfNotNull("eventObjectType", this._EventObjectType);
			kparams.AddIfNotNull("eventConditions", this._EventConditions);
			kparams.AddIfNotNull("contentParameters", this._ContentParameters);
			kparams.AddIfNotNull("userParameters", this._UserParameters);
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
				case TYPE:
					return "Type";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case MANUAL_DISPATCH_ENABLED:
					return "ManualDispatchEnabled";
				case AUTOMATIC_DISPATCH_ENABLED:
					return "AutomaticDispatchEnabled";
				case EVENT_TYPE:
					return "EventType";
				case EVENT_OBJECT_TYPE:
					return "EventObjectType";
				case EVENT_CONDITIONS:
					return "EventConditions";
				case CONTENT_PARAMETERS:
					return "ContentParameters";
				case USER_PARAMETERS:
					return "UserParameters";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

