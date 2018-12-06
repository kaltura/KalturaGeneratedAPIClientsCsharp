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
	public class StatsKmcEvent : ObjectBase
	{
		#region Constants
		public const string CLIENT_VER = "clientVer";
		public const string KMC_EVENT_ACTION_PATH = "kmcEventActionPath";
		public const string KMC_EVENT_TYPE = "kmcEventType";
		public const string EVENT_TIMESTAMP = "eventTimestamp";
		public const string SESSION_ID = "sessionId";
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string WIDGET_ID = "widgetId";
		public const string UICONF_ID = "uiconfId";
		public const string USER_ID = "userId";
		public const string USER_IP = "userIp";
		#endregion

		#region Private Fields
		private string _ClientVer = null;
		private string _KmcEventActionPath = null;
		private StatsKmcEventType _KmcEventType = (StatsKmcEventType)Int32.MinValue;
		private float _EventTimestamp = Single.MinValue;
		private string _SessionId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _WidgetId = null;
		private int _UiconfId = Int32.MinValue;
		private string _UserId = null;
		private string _UserIp = null;
		#endregion

		#region Properties
		public string ClientVer
		{
			get { return _ClientVer; }
			set 
			{ 
				_ClientVer = value;
				OnPropertyChanged("ClientVer");
			}
		}
		public string KmcEventActionPath
		{
			get { return _KmcEventActionPath; }
			set 
			{ 
				_KmcEventActionPath = value;
				OnPropertyChanged("KmcEventActionPath");
			}
		}
		public StatsKmcEventType KmcEventType
		{
			get { return _KmcEventType; }
			set 
			{ 
				_KmcEventType = value;
				OnPropertyChanged("KmcEventType");
			}
		}
		public float EventTimestamp
		{
			get { return _EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
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
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string WidgetId
		{
			get { return _WidgetId; }
			set 
			{ 
				_WidgetId = value;
				OnPropertyChanged("WidgetId");
			}
		}
		public int UiconfId
		{
			get { return _UiconfId; }
			set 
			{ 
				_UiconfId = value;
				OnPropertyChanged("UiconfId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public string UserIp
		{
			get { return _UserIp; }
		}
		#endregion

		#region CTor
		public StatsKmcEvent()
		{
		}

		public StatsKmcEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "clientVer":
						this._ClientVer = propertyNode.InnerText;
						continue;
					case "kmcEventActionPath":
						this._KmcEventActionPath = propertyNode.InnerText;
						continue;
					case "kmcEventType":
						this._KmcEventType = (StatsKmcEventType)ParseEnum(typeof(StatsKmcEventType), propertyNode.InnerText);
						continue;
					case "eventTimestamp":
						this._EventTimestamp = ParseFloat(propertyNode.InnerText);
						continue;
					case "sessionId":
						this._SessionId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "widgetId":
						this._WidgetId = propertyNode.InnerText;
						continue;
					case "uiconfId":
						this._UiconfId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "userIp":
						this._UserIp = propertyNode.InnerText;
						continue;
				}
			}
		}

		public StatsKmcEvent(IDictionary<string,object> data) : base(data)
		{
			    this._ClientVer = data.TryGetValueSafe<string>("clientVer");
			    this._KmcEventActionPath = data.TryGetValueSafe<string>("kmcEventActionPath");
			    this._KmcEventType = (StatsKmcEventType)ParseEnum(typeof(StatsKmcEventType), data.TryGetValueSafe<int>("kmcEventType"));
			    this._EventTimestamp = data.TryGetValueSafe<float>("eventTimestamp");
			    this._SessionId = data.TryGetValueSafe<string>("sessionId");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._WidgetId = data.TryGetValueSafe<string>("widgetId");
			    this._UiconfId = data.TryGetValueSafe<int>("uiconfId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._UserIp = data.TryGetValueSafe<string>("userIp");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStatsKmcEvent");
			kparams.AddIfNotNull("clientVer", this._ClientVer);
			kparams.AddIfNotNull("kmcEventActionPath", this._KmcEventActionPath);
			kparams.AddIfNotNull("kmcEventType", this._KmcEventType);
			kparams.AddIfNotNull("eventTimestamp", this._EventTimestamp);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("widgetId", this._WidgetId);
			kparams.AddIfNotNull("uiconfId", this._UiconfId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("userIp", this._UserIp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CLIENT_VER:
					return "ClientVer";
				case KMC_EVENT_ACTION_PATH:
					return "KmcEventActionPath";
				case KMC_EVENT_TYPE:
					return "KmcEventType";
				case EVENT_TIMESTAMP:
					return "EventTimestamp";
				case SESSION_ID:
					return "SessionId";
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case WIDGET_ID:
					return "WidgetId";
				case UICONF_ID:
					return "UiconfId";
				case USER_ID:
					return "UserId";
				case USER_IP:
					return "UserIp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

