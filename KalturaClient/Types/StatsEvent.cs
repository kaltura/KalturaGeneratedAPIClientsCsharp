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
	public class StatsEvent : ObjectBase
	{
		#region Constants
		public const string CLIENT_VER = "clientVer";
		public const string EVENT_TYPE = "eventType";
		public const string EVENT_TIMESTAMP = "eventTimestamp";
		public const string SESSION_ID = "sessionId";
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string UNIQUE_VIEWER = "uniqueViewer";
		public const string WIDGET_ID = "widgetId";
		public const string UICONF_ID = "uiconfId";
		public const string USER_ID = "userId";
		public const string CURRENT_POINT = "currentPoint";
		public const string DURATION = "duration";
		public const string USER_IP = "userIp";
		public const string PROCESS_DURATION = "processDuration";
		public const string CONTROL_ID = "controlId";
		public const string SEEK = "seek";
		public const string NEW_POINT = "newPoint";
		public const string REFERRER = "referrer";
		public const string IS_FIRST_IN_SESSION = "isFirstInSession";
		public const string APPLICATION_ID = "applicationId";
		public const string CONTEXT_ID = "contextId";
		public const string FEATURE_TYPE = "featureType";
		#endregion

		#region Private Fields
		private string _ClientVer = null;
		private StatsEventType _EventType = (StatsEventType)Int32.MinValue;
		private float _EventTimestamp = Single.MinValue;
		private string _SessionId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _UniqueViewer = null;
		private string _WidgetId = null;
		private int _UiconfId = Int32.MinValue;
		private string _UserId = null;
		private int _CurrentPoint = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private string _UserIp = null;
		private int _ProcessDuration = Int32.MinValue;
		private string _ControlId = null;
		private bool? _Seek = null;
		private int _NewPoint = Int32.MinValue;
		private string _Referrer = null;
		private bool? _IsFirstInSession = null;
		private string _ApplicationId = null;
		private int _ContextId = Int32.MinValue;
		private StatsFeatureType _FeatureType = (StatsFeatureType)Int32.MinValue;
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
		public StatsEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
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
		public string UniqueViewer
		{
			get { return _UniqueViewer; }
			set 
			{ 
				_UniqueViewer = value;
				OnPropertyChanged("UniqueViewer");
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
		public int CurrentPoint
		{
			get { return _CurrentPoint; }
			set 
			{ 
				_CurrentPoint = value;
				OnPropertyChanged("CurrentPoint");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public string UserIp
		{
			get { return _UserIp; }
		}
		public int ProcessDuration
		{
			get { return _ProcessDuration; }
			set 
			{ 
				_ProcessDuration = value;
				OnPropertyChanged("ProcessDuration");
			}
		}
		public string ControlId
		{
			get { return _ControlId; }
			set 
			{ 
				_ControlId = value;
				OnPropertyChanged("ControlId");
			}
		}
		public bool? Seek
		{
			get { return _Seek; }
			set 
			{ 
				_Seek = value;
				OnPropertyChanged("Seek");
			}
		}
		public int NewPoint
		{
			get { return _NewPoint; }
			set 
			{ 
				_NewPoint = value;
				OnPropertyChanged("NewPoint");
			}
		}
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		public bool? IsFirstInSession
		{
			get { return _IsFirstInSession; }
			set 
			{ 
				_IsFirstInSession = value;
				OnPropertyChanged("IsFirstInSession");
			}
		}
		public string ApplicationId
		{
			get { return _ApplicationId; }
			set 
			{ 
				_ApplicationId = value;
				OnPropertyChanged("ApplicationId");
			}
		}
		public int ContextId
		{
			get { return _ContextId; }
			set 
			{ 
				_ContextId = value;
				OnPropertyChanged("ContextId");
			}
		}
		public StatsFeatureType FeatureType
		{
			get { return _FeatureType; }
			set 
			{ 
				_FeatureType = value;
				OnPropertyChanged("FeatureType");
			}
		}
		#endregion

		#region CTor
		public StatsEvent()
		{
		}

		public StatsEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "clientVer":
						this._ClientVer = propertyNode.InnerText;
						continue;
					case "eventType":
						this._EventType = (StatsEventType)ParseEnum(typeof(StatsEventType), propertyNode.InnerText);
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
					case "uniqueViewer":
						this._UniqueViewer = propertyNode.InnerText;
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
					case "currentPoint":
						this._CurrentPoint = ParseInt(propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
						continue;
					case "userIp":
						this._UserIp = propertyNode.InnerText;
						continue;
					case "processDuration":
						this._ProcessDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "controlId":
						this._ControlId = propertyNode.InnerText;
						continue;
					case "seek":
						this._Seek = ParseBool(propertyNode.InnerText);
						continue;
					case "newPoint":
						this._NewPoint = ParseInt(propertyNode.InnerText);
						continue;
					case "referrer":
						this._Referrer = propertyNode.InnerText;
						continue;
					case "isFirstInSession":
						this._IsFirstInSession = ParseBool(propertyNode.InnerText);
						continue;
					case "applicationId":
						this._ApplicationId = propertyNode.InnerText;
						continue;
					case "contextId":
						this._ContextId = ParseInt(propertyNode.InnerText);
						continue;
					case "featureType":
						this._FeatureType = (StatsFeatureType)ParseEnum(typeof(StatsFeatureType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public StatsEvent(IDictionary<string,object> data) : base(data)
		{
			    this._ClientVer = data.TryGetValueSafe<string>("clientVer");
			    this._EventType = (StatsEventType)ParseEnum(typeof(StatsEventType), data.TryGetValueSafe<int>("eventType"));
			    this._EventTimestamp = data.TryGetValueSafe<float>("eventTimestamp");
			    this._SessionId = data.TryGetValueSafe<string>("sessionId");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._UniqueViewer = data.TryGetValueSafe<string>("uniqueViewer");
			    this._WidgetId = data.TryGetValueSafe<string>("widgetId");
			    this._UiconfId = data.TryGetValueSafe<int>("uiconfId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._CurrentPoint = data.TryGetValueSafe<int>("currentPoint");
			    this._Duration = data.TryGetValueSafe<int>("duration");
			    this._UserIp = data.TryGetValueSafe<string>("userIp");
			    this._ProcessDuration = data.TryGetValueSafe<int>("processDuration");
			    this._ControlId = data.TryGetValueSafe<string>("controlId");
			    this._Seek = data.TryGetValueSafe<bool>("seek");
			    this._NewPoint = data.TryGetValueSafe<int>("newPoint");
			    this._Referrer = data.TryGetValueSafe<string>("referrer");
			    this._IsFirstInSession = data.TryGetValueSafe<bool>("isFirstInSession");
			    this._ApplicationId = data.TryGetValueSafe<string>("applicationId");
			    this._ContextId = data.TryGetValueSafe<int>("contextId");
			    this._FeatureType = (StatsFeatureType)ParseEnum(typeof(StatsFeatureType), data.TryGetValueSafe<int>("featureType"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStatsEvent");
			kparams.AddIfNotNull("clientVer", this._ClientVer);
			kparams.AddIfNotNull("eventType", this._EventType);
			kparams.AddIfNotNull("eventTimestamp", this._EventTimestamp);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("uniqueViewer", this._UniqueViewer);
			kparams.AddIfNotNull("widgetId", this._WidgetId);
			kparams.AddIfNotNull("uiconfId", this._UiconfId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("currentPoint", this._CurrentPoint);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("userIp", this._UserIp);
			kparams.AddIfNotNull("processDuration", this._ProcessDuration);
			kparams.AddIfNotNull("controlId", this._ControlId);
			kparams.AddIfNotNull("seek", this._Seek);
			kparams.AddIfNotNull("newPoint", this._NewPoint);
			kparams.AddIfNotNull("referrer", this._Referrer);
			kparams.AddIfNotNull("isFirstInSession", this._IsFirstInSession);
			kparams.AddIfNotNull("applicationId", this._ApplicationId);
			kparams.AddIfNotNull("contextId", this._ContextId);
			kparams.AddIfNotNull("featureType", this._FeatureType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CLIENT_VER:
					return "ClientVer";
				case EVENT_TYPE:
					return "EventType";
				case EVENT_TIMESTAMP:
					return "EventTimestamp";
				case SESSION_ID:
					return "SessionId";
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case UNIQUE_VIEWER:
					return "UniqueViewer";
				case WIDGET_ID:
					return "WidgetId";
				case UICONF_ID:
					return "UiconfId";
				case USER_ID:
					return "UserId";
				case CURRENT_POINT:
					return "CurrentPoint";
				case DURATION:
					return "Duration";
				case USER_IP:
					return "UserIp";
				case PROCESS_DURATION:
					return "ProcessDuration";
				case CONTROL_ID:
					return "ControlId";
				case SEEK:
					return "Seek";
				case NEW_POINT:
					return "NewPoint";
				case REFERRER:
					return "Referrer";
				case IS_FIRST_IN_SESSION:
					return "IsFirstInSession";
				case APPLICATION_ID:
					return "ApplicationId";
				case CONTEXT_ID:
					return "ContextId";
				case FEATURE_TYPE:
					return "FeatureType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

