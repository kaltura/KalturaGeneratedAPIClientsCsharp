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
		public EventNotificationTemplateType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public EventNotificationTemplateStatus Status
		{
			get { return _Status; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public bool? ManualDispatchEnabled
		{
			get { return _ManualDispatchEnabled; }
			set 
			{ 
				_ManualDispatchEnabled = value;
				OnPropertyChanged("ManualDispatchEnabled");
			}
		}
		public bool? AutomaticDispatchEnabled
		{
			get { return _AutomaticDispatchEnabled; }
			set 
			{ 
				_AutomaticDispatchEnabled = value;
				OnPropertyChanged("AutomaticDispatchEnabled");
			}
		}
		public EventNotificationEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		public EventNotificationEventObjectType EventObjectType
		{
			get { return _EventObjectType; }
			set 
			{ 
				_EventObjectType = value;
				OnPropertyChanged("EventObjectType");
			}
		}
		public IList<Condition> EventConditions
		{
			get { return _EventConditions; }
			set 
			{ 
				_EventConditions = value;
				OnPropertyChanged("EventConditions");
			}
		}
		public IList<EventNotificationParameter> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
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

		public EventNotificationTemplate(XmlElement node) : base(node)
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
					case "type":
						this._Type = (EventNotificationTemplateType)StringEnum.Parse(typeof(EventNotificationTemplateType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (EventNotificationTemplateStatus)ParseEnum(typeof(EventNotificationTemplateStatus), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "manualDispatchEnabled":
						this._ManualDispatchEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "automaticDispatchEnabled":
						this._AutomaticDispatchEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "eventType":
						this._EventType = (EventNotificationEventType)StringEnum.Parse(typeof(EventNotificationEventType), propertyNode.InnerText);
						continue;
					case "eventObjectType":
						this._EventObjectType = (EventNotificationEventObjectType)StringEnum.Parse(typeof(EventNotificationEventObjectType), propertyNode.InnerText);
						continue;
					case "eventConditions":
						this._EventConditions = new List<Condition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._EventConditions.Add(ObjectFactory.Create<Condition>(arrayNode));
						}
						continue;
					case "contentParameters":
						this._ContentParameters = new List<EventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ContentParameters.Add(ObjectFactory.Create<EventNotificationParameter>(arrayNode));
						}
						continue;
					case "userParameters":
						this._UserParameters = new List<EventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UserParameters.Add(ObjectFactory.Create<EventNotificationParameter>(arrayNode));
						}
						continue;
				}
			}
		}

		public EventNotificationTemplate(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Type = (EventNotificationTemplateType)StringEnum.Parse(typeof(EventNotificationTemplateType), data.TryGetValueSafe<string>("type"));
			    this._Status = (EventNotificationTemplateStatus)ParseEnum(typeof(EventNotificationTemplateStatus), data.TryGetValueSafe<int>("status"));
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._ManualDispatchEnabled = data.TryGetValueSafe<bool>("manualDispatchEnabled");
			    this._AutomaticDispatchEnabled = data.TryGetValueSafe<bool>("automaticDispatchEnabled");
			    this._EventType = (EventNotificationEventType)StringEnum.Parse(typeof(EventNotificationEventType), data.TryGetValueSafe<string>("eventType"));
			    this._EventObjectType = (EventNotificationEventObjectType)StringEnum.Parse(typeof(EventNotificationEventObjectType), data.TryGetValueSafe<string>("eventObjectType"));
			    this._EventConditions = new List<Condition>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("eventConditions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._EventConditions.Add(ObjectFactory.Create<Condition>((IDictionary<string,object>)dataDictionary));
			    }
			    this._ContentParameters = new List<EventNotificationParameter>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("contentParameters", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._ContentParameters.Add(ObjectFactory.Create<EventNotificationParameter>((IDictionary<string,object>)dataDictionary));
			    }
			    this._UserParameters = new List<EventNotificationParameter>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("userParameters", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._UserParameters.Add(ObjectFactory.Create<EventNotificationParameter>((IDictionary<string,object>)dataDictionary));
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

