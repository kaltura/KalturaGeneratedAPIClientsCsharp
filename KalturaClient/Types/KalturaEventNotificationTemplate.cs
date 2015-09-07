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
	public class KalturaEventNotificationTemplate : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private KalturaEventNotificationTemplateType _Type = null;
		private KalturaEventNotificationTemplateStatus _Status = (KalturaEventNotificationTemplateStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private bool? _ManualDispatchEnabled = false;
		private bool? _AutomaticDispatchEnabled = false;
		private KalturaEventNotificationEventType _EventType = null;
		private KalturaEventNotificationEventObjectType _EventObjectType = null;
		private IList<KalturaCondition> _EventConditions;
		private IList<KalturaEventNotificationParameter> _ContentParameters;
		private IList<KalturaEventNotificationParameter> _UserParameters;
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
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
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
		public KalturaEventNotificationTemplateType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaEventNotificationTemplateStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
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
		public KalturaEventNotificationEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
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
		public IList<KalturaCondition> EventConditions
		{
			get { return _EventConditions; }
			set 
			{ 
				_EventConditions = value;
				OnPropertyChanged("EventConditions");
			}
		}
		public IList<KalturaEventNotificationParameter> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
		public IList<KalturaEventNotificationParameter> UserParameters
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
		public KalturaEventNotificationTemplate()
		{
		}

		public KalturaEventNotificationTemplate(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "type":
						this.Type = (KalturaEventNotificationTemplateType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationTemplateType), txt);
						continue;
					case "status":
						this.Status = (KalturaEventNotificationTemplateStatus)ParseEnum(typeof(KalturaEventNotificationTemplateStatus), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "manualDispatchEnabled":
						this.ManualDispatchEnabled = ParseBool(txt);
						continue;
					case "automaticDispatchEnabled":
						this.AutomaticDispatchEnabled = ParseBool(txt);
						continue;
					case "eventType":
						this.EventType = (KalturaEventNotificationEventType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventType), txt);
						continue;
					case "eventObjectType":
						this.EventObjectType = (KalturaEventNotificationEventObjectType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventObjectType), txt);
						continue;
					case "eventConditions":
						this.EventConditions = new List<KalturaCondition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.EventConditions.Add((KalturaCondition)KalturaObjectFactory.Create(arrayNode, "KalturaCondition"));
						}
						continue;
					case "contentParameters":
						this.ContentParameters = new List<KalturaEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ContentParameters.Add((KalturaEventNotificationParameter)KalturaObjectFactory.Create(arrayNode, "KalturaEventNotificationParameter"));
						}
						continue;
					case "userParameters":
						this.UserParameters = new List<KalturaEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.UserParameters.Add((KalturaEventNotificationParameter)KalturaObjectFactory.Create(arrayNode, "KalturaEventNotificationParameter"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEventNotificationTemplate");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("systemName", this.SystemName);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("manualDispatchEnabled", this.ManualDispatchEnabled);
			kparams.AddIfNotNull("automaticDispatchEnabled", this.AutomaticDispatchEnabled);
			kparams.AddIfNotNull("eventType", this.EventType);
			kparams.AddIfNotNull("eventObjectType", this.EventObjectType);
			kparams.AddIfNotNull("eventConditions", this.EventConditions);
			kparams.AddIfNotNull("contentParameters", this.ContentParameters);
			kparams.AddIfNotNull("userParameters", this.UserParameters);
			return kparams;
		}
		#endregion
	}
}

