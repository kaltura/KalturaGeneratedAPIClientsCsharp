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
	public class HttpNotification : ObjectBase
	{
		#region Constants
		public const string OBJECT = "object";
		public const string EVENT_OBJECT_TYPE = "eventObjectType";
		public const string EVENT_NOTIFICATION_JOB_ID = "eventNotificationJobId";
		public const string TEMPLATE_ID = "templateId";
		public const string TEMPLATE_NAME = "templateName";
		public const string TEMPLATE_SYSTEM_NAME = "templateSystemName";
		public const string EVENT_TYPE = "eventType";
		#endregion

		#region Private Fields
		private ObjectBase _Object;
		private EventNotificationEventObjectType _EventObjectType = null;
		private long _EventNotificationJobId = long.MinValue;
		private int _TemplateId = Int32.MinValue;
		private string _TemplateName = null;
		private string _TemplateSystemName = null;
		private EventNotificationEventType _EventType = null;
		#endregion

		#region Properties
		[JsonProperty]
		public ObjectBase Object
		{
			get { return _Object; }
			set 
			{ 
				_Object = value;
				OnPropertyChanged("Object");
			}
		}
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
		[JsonProperty]
		public long EventNotificationJobId
		{
			get { return _EventNotificationJobId; }
			set 
			{ 
				_EventNotificationJobId = value;
				OnPropertyChanged("EventNotificationJobId");
			}
		}
		[JsonProperty]
		public int TemplateId
		{
			get { return _TemplateId; }
			set 
			{ 
				_TemplateId = value;
				OnPropertyChanged("TemplateId");
			}
		}
		[JsonProperty]
		public string TemplateName
		{
			get { return _TemplateName; }
			set 
			{ 
				_TemplateName = value;
				OnPropertyChanged("TemplateName");
			}
		}
		[JsonProperty]
		public string TemplateSystemName
		{
			get { return _TemplateSystemName; }
			set 
			{ 
				_TemplateSystemName = value;
				OnPropertyChanged("TemplateSystemName");
			}
		}
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
		#endregion

		#region CTor
		public HttpNotification()
		{
		}

		public HttpNotification(JToken node) : base(node)
		{
			if(node["object"] != null)
			{
				this._Object = ObjectFactory.Create<ObjectBase>(node["object"]);
			}
			if(node["eventObjectType"] != null)
			{
				this._EventObjectType = (EventNotificationEventObjectType)StringEnum.Parse(typeof(EventNotificationEventObjectType), node["eventObjectType"].Value<string>());
			}
			if(node["eventNotificationJobId"] != null)
			{
				this._EventNotificationJobId = ParseLong(node["eventNotificationJobId"].Value<string>());
			}
			if(node["templateId"] != null)
			{
				this._TemplateId = ParseInt(node["templateId"].Value<string>());
			}
			if(node["templateName"] != null)
			{
				this._TemplateName = node["templateName"].Value<string>();
			}
			if(node["templateSystemName"] != null)
			{
				this._TemplateSystemName = node["templateSystemName"].Value<string>();
			}
			if(node["eventType"] != null)
			{
				this._EventType = (EventNotificationEventType)StringEnum.Parse(typeof(EventNotificationEventType), node["eventType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHttpNotification");
			kparams.AddIfNotNull("object", this._Object);
			kparams.AddIfNotNull("eventObjectType", this._EventObjectType);
			kparams.AddIfNotNull("eventNotificationJobId", this._EventNotificationJobId);
			kparams.AddIfNotNull("templateId", this._TemplateId);
			kparams.AddIfNotNull("templateName", this._TemplateName);
			kparams.AddIfNotNull("templateSystemName", this._TemplateSystemName);
			kparams.AddIfNotNull("eventType", this._EventType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT:
					return "Object";
				case EVENT_OBJECT_TYPE:
					return "EventObjectType";
				case EVENT_NOTIFICATION_JOB_ID:
					return "EventNotificationJobId";
				case TEMPLATE_ID:
					return "TemplateId";
				case TEMPLATE_NAME:
					return "TemplateName";
				case TEMPLATE_SYSTEM_NAME:
					return "TemplateSystemName";
				case EVENT_TYPE:
					return "EventType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

