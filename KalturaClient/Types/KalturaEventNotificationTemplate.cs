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
		private bool? _ManualDispatchEnabled = null;
		private bool? _AutomaticDispatchEnabled = null;
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
		public new IList<KalturaCondition> EventConditions
		{
			get { return _EventConditions; }
			set 
			{ 
				_EventConditions = value;
				OnPropertyChanged("EventConditions");
			}
		}
		public new IList<KalturaEventNotificationParameter> ContentParameters
		{
			get { return _ContentParameters; }
			set 
			{ 
				_ContentParameters = value;
				OnPropertyChanged("ContentParameters");
			}
		}
		public new IList<KalturaEventNotificationParameter> UserParameters
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
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "name":
						this._Name = txt;
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "type":
						this._Type = (KalturaEventNotificationTemplateType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationTemplateType), txt);
						continue;
					case "status":
						this._Status = (KalturaEventNotificationTemplateStatus)ParseEnum(typeof(KalturaEventNotificationTemplateStatus), txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "manualDispatchEnabled":
						this._ManualDispatchEnabled = ParseBool(txt);
						continue;
					case "automaticDispatchEnabled":
						this._AutomaticDispatchEnabled = ParseBool(txt);
						continue;
					case "eventType":
						this._EventType = (KalturaEventNotificationEventType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventType), txt);
						continue;
					case "eventObjectType":
						this._EventObjectType = (KalturaEventNotificationEventObjectType)KalturaStringEnum.Parse(typeof(KalturaEventNotificationEventObjectType), txt);
						continue;
					case "eventConditions":
						this._EventConditions = new List<KalturaCondition>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._EventConditions.Add((KalturaCondition)KalturaObjectFactory.Create(arrayNode, "KalturaCondition"));
						}
						continue;
					case "contentParameters":
						this._ContentParameters = new List<KalturaEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ContentParameters.Add((KalturaEventNotificationParameter)KalturaObjectFactory.Create(arrayNode, "KalturaEventNotificationParameter"));
						}
						continue;
					case "userParameters":
						this._UserParameters = new List<KalturaEventNotificationParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._UserParameters.Add((KalturaEventNotificationParameter)KalturaObjectFactory.Create(arrayNode, "KalturaEventNotificationParameter"));
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
		#endregion
	}
}

