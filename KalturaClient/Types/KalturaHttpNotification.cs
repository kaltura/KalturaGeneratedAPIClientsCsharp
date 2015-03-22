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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaHttpNotification : KalturaObjectBase
	{
		#region Private Fields
		private KalturaObjectBase _Object;
		private KalturaEventNotificationEventObjectType _EventObjectType = null;
		private int _EventNotificationJobId = Int32.MinValue;
		private int _TemplateId = Int32.MinValue;
		private string _TemplateName = null;
		private string _TemplateSystemName = null;
		private KalturaEventNotificationEventType _EventType = null;
		#endregion

		#region Properties
		public KalturaObjectBase Object
		{
			get { return _Object; }
			set 
			{ 
				_Object = value;
				OnPropertyChanged("Object");
			}
		}
		public KalturaEventNotificationEventObjectType EventObjectType
		{
			get { return _EventObjectType; }
			set 
			{ 
				_EventObjectType = value;
				OnPropertyChanged("EventObjectType");
			}
		}
		public int EventNotificationJobId
		{
			get { return _EventNotificationJobId; }
			set 
			{ 
				_EventNotificationJobId = value;
				OnPropertyChanged("EventNotificationJobId");
			}
		}
		public int TemplateId
		{
			get { return _TemplateId; }
			set 
			{ 
				_TemplateId = value;
				OnPropertyChanged("TemplateId");
			}
		}
		public string TemplateName
		{
			get { return _TemplateName; }
			set 
			{ 
				_TemplateName = value;
				OnPropertyChanged("TemplateName");
			}
		}
		public string TemplateSystemName
		{
			get { return _TemplateSystemName; }
			set 
			{ 
				_TemplateSystemName = value;
				OnPropertyChanged("TemplateSystemName");
			}
		}
		public KalturaEventNotificationEventType EventType
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
		public KalturaHttpNotification()
		{
		}

		public KalturaHttpNotification(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "object":
						this.Object = (KalturaObjectBase)KalturaObjectFactory.Create(propertyNode, "KalturaObjectBase");
						continue;
					case "eventObjectType":
						this.EventObjectType = (KalturaEventNotificationEventObjectType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventObjectType), txt);
						continue;
					case "eventNotificationJobId":
						this.EventNotificationJobId = ParseInt(txt);
						continue;
					case "templateId":
						this.TemplateId = ParseInt(txt);
						continue;
					case "templateName":
						this.TemplateName = txt;
						continue;
					case "templateSystemName":
						this.TemplateSystemName = txt;
						continue;
					case "eventType":
						this.EventType = (KalturaEventNotificationEventType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaHttpNotification");
			if (this.Object != null)
				kparams.Add("object", this.Object.ToParams());
			kparams.AddStringEnumIfNotNull("eventObjectType", this.EventObjectType);
			kparams.AddIntIfNotNull("eventNotificationJobId", this.EventNotificationJobId);
			kparams.AddIntIfNotNull("templateId", this.TemplateId);
			kparams.AddStringIfNotNull("templateName", this.TemplateName);
			kparams.AddStringIfNotNull("templateSystemName", this.TemplateSystemName);
			kparams.AddStringEnumIfNotNull("eventType", this.EventType);
			return kparams;
		}
		#endregion
	}
}

