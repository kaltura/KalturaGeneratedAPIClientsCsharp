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
	public class BusinessProcessCase : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string BUSINESS_PROCESS_ID = "businessProcessId";
		public const string BUSINESS_PROCESS_START_NOTIFICATION_TEMPLATE_ID = "businessProcessStartNotificationTemplateId";
		public const string SUSPENDED = "suspended";
		public const string ACTIVITY_ID = "activityId";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _BusinessProcessId = null;
		private int _BusinessProcessStartNotificationTemplateId = Int32.MinValue;
		private bool? _Suspended = null;
		private string _ActivityId = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public string BusinessProcessId
		{
			get { return _BusinessProcessId; }
			set 
			{ 
				_BusinessProcessId = value;
				OnPropertyChanged("BusinessProcessId");
			}
		}
		public int BusinessProcessStartNotificationTemplateId
		{
			get { return _BusinessProcessStartNotificationTemplateId; }
			set 
			{ 
				_BusinessProcessStartNotificationTemplateId = value;
				OnPropertyChanged("BusinessProcessStartNotificationTemplateId");
			}
		}
		public bool? Suspended
		{
			get { return _Suspended; }
			set 
			{ 
				_Suspended = value;
				OnPropertyChanged("Suspended");
			}
		}
		public string ActivityId
		{
			get { return _ActivityId; }
			set 
			{ 
				_ActivityId = value;
				OnPropertyChanged("ActivityId");
			}
		}
		#endregion

		#region CTor
		public BusinessProcessCase()
		{
		}

		public BusinessProcessCase(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "businessProcessId":
						this._BusinessProcessId = propertyNode.InnerText;
						continue;
					case "businessProcessStartNotificationTemplateId":
						this._BusinessProcessStartNotificationTemplateId = ParseInt(propertyNode.InnerText);
						continue;
					case "suspended":
						this._Suspended = ParseBool(propertyNode.InnerText);
						continue;
					case "activityId":
						this._ActivityId = propertyNode.InnerText;
						continue;
				}
			}
		}

		public BusinessProcessCase(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._BusinessProcessId = data.TryGetValueSafe<string>("businessProcessId");
			    this._BusinessProcessStartNotificationTemplateId = data.TryGetValueSafe<int>("businessProcessStartNotificationTemplateId");
			    this._Suspended = data.TryGetValueSafe<bool>("suspended");
			    this._ActivityId = data.TryGetValueSafe<string>("activityId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBusinessProcessCase");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("businessProcessId", this._BusinessProcessId);
			kparams.AddIfNotNull("businessProcessStartNotificationTemplateId", this._BusinessProcessStartNotificationTemplateId);
			kparams.AddIfNotNull("suspended", this._Suspended);
			kparams.AddIfNotNull("activityId", this._ActivityId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case BUSINESS_PROCESS_ID:
					return "BusinessProcessId";
				case BUSINESS_PROCESS_START_NOTIFICATION_TEMPLATE_ID:
					return "BusinessProcessStartNotificationTemplateId";
				case SUSPENDED:
					return "Suspended";
				case ACTIVITY_ID:
					return "ActivityId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

