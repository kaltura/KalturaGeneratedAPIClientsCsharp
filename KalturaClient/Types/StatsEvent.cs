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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
		[JsonProperty]
		public string ClientVer
		{
			get { return _ClientVer; }
			set 
			{ 
				_ClientVer = value;
				OnPropertyChanged("ClientVer");
			}
		}
		[JsonProperty]
		public StatsEventType EventType
		{
			get { return _EventType; }
			set 
			{ 
				_EventType = value;
				OnPropertyChanged("EventType");
			}
		}
		[JsonProperty]
		public float EventTimestamp
		{
			get { return _EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		[JsonProperty]
		public string SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public string UniqueViewer
		{
			get { return _UniqueViewer; }
			set 
			{ 
				_UniqueViewer = value;
				OnPropertyChanged("UniqueViewer");
			}
		}
		[JsonProperty]
		public string WidgetId
		{
			get { return _WidgetId; }
			set 
			{ 
				_WidgetId = value;
				OnPropertyChanged("WidgetId");
			}
		}
		[JsonProperty]
		public int UiconfId
		{
			get { return _UiconfId; }
			set 
			{ 
				_UiconfId = value;
				OnPropertyChanged("UiconfId");
			}
		}
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public int CurrentPoint
		{
			get { return _CurrentPoint; }
			set 
			{ 
				_CurrentPoint = value;
				OnPropertyChanged("CurrentPoint");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public string UserIp
		{
			get { return _UserIp; }
			private set 
			{ 
				_UserIp = value;
				OnPropertyChanged("UserIp");
			}
		}
		[JsonProperty]
		public int ProcessDuration
		{
			get { return _ProcessDuration; }
			set 
			{ 
				_ProcessDuration = value;
				OnPropertyChanged("ProcessDuration");
			}
		}
		[JsonProperty]
		public string ControlId
		{
			get { return _ControlId; }
			set 
			{ 
				_ControlId = value;
				OnPropertyChanged("ControlId");
			}
		}
		[JsonProperty]
		public bool? Seek
		{
			get { return _Seek; }
			set 
			{ 
				_Seek = value;
				OnPropertyChanged("Seek");
			}
		}
		[JsonProperty]
		public int NewPoint
		{
			get { return _NewPoint; }
			set 
			{ 
				_NewPoint = value;
				OnPropertyChanged("NewPoint");
			}
		}
		[JsonProperty]
		public string Referrer
		{
			get { return _Referrer; }
			set 
			{ 
				_Referrer = value;
				OnPropertyChanged("Referrer");
			}
		}
		[JsonProperty]
		public bool? IsFirstInSession
		{
			get { return _IsFirstInSession; }
			set 
			{ 
				_IsFirstInSession = value;
				OnPropertyChanged("IsFirstInSession");
			}
		}
		[JsonProperty]
		public string ApplicationId
		{
			get { return _ApplicationId; }
			set 
			{ 
				_ApplicationId = value;
				OnPropertyChanged("ApplicationId");
			}
		}
		[JsonProperty]
		public int ContextId
		{
			get { return _ContextId; }
			set 
			{ 
				_ContextId = value;
				OnPropertyChanged("ContextId");
			}
		}
		[JsonProperty]
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

		public StatsEvent(JToken node) : base(node)
		{
			if(node["clientVer"] != null)
			{
				this._ClientVer = node["clientVer"].Value<string>();
			}
			if(node["eventType"] != null)
			{
				this._EventType = (StatsEventType)ParseEnum(typeof(StatsEventType), node["eventType"].Value<string>());
			}
			if(node["eventTimestamp"] != null)
			{
				this._EventTimestamp = ParseFloat(node["eventTimestamp"].Value<string>());
			}
			if(node["sessionId"] != null)
			{
				this._SessionId = node["sessionId"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["uniqueViewer"] != null)
			{
				this._UniqueViewer = node["uniqueViewer"].Value<string>();
			}
			if(node["widgetId"] != null)
			{
				this._WidgetId = node["widgetId"].Value<string>();
			}
			if(node["uiconfId"] != null)
			{
				this._UiconfId = ParseInt(node["uiconfId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["currentPoint"] != null)
			{
				this._CurrentPoint = ParseInt(node["currentPoint"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["userIp"] != null)
			{
				this._UserIp = node["userIp"].Value<string>();
			}
			if(node["processDuration"] != null)
			{
				this._ProcessDuration = ParseInt(node["processDuration"].Value<string>());
			}
			if(node["controlId"] != null)
			{
				this._ControlId = node["controlId"].Value<string>();
			}
			if(node["seek"] != null)
			{
				this._Seek = ParseBool(node["seek"].Value<string>());
			}
			if(node["newPoint"] != null)
			{
				this._NewPoint = ParseInt(node["newPoint"].Value<string>());
			}
			if(node["referrer"] != null)
			{
				this._Referrer = node["referrer"].Value<string>();
			}
			if(node["isFirstInSession"] != null)
			{
				this._IsFirstInSession = ParseBool(node["isFirstInSession"].Value<string>());
			}
			if(node["applicationId"] != null)
			{
				this._ApplicationId = node["applicationId"].Value<string>();
			}
			if(node["contextId"] != null)
			{
				this._ContextId = ParseInt(node["contextId"].Value<string>());
			}
			if(node["featureType"] != null)
			{
				this._FeatureType = (StatsFeatureType)ParseEnum(typeof(StatsFeatureType), node["featureType"].Value<string>());
			}
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

