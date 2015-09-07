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
	public class KalturaStatsEvent : KalturaObjectBase
	{
		#region Private Fields
		private string _ClientVer = null;
		private KalturaStatsEventType _EventType = (KalturaStatsEventType)Int32.MinValue;
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
		private bool? _Seek = false;
		private int _NewPoint = Int32.MinValue;
		private string _Referrer = null;
		private bool? _IsFirstInSession = false;
		private string _ApplicationId = null;
		private int _ContextId = Int32.MinValue;
		private KalturaStatsFeatureType _FeatureType = (KalturaStatsFeatureType)Int32.MinValue;
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
		public KalturaStatsEventType EventType
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
			set 
			{ 
				_UserIp = value;
				OnPropertyChanged("UserIp");
			}
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
		public KalturaStatsFeatureType FeatureType
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
		public KalturaStatsEvent()
		{
		}

		public KalturaStatsEvent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "clientVer":
						this.ClientVer = txt;
						continue;
					case "eventType":
						this.EventType = (KalturaStatsEventType)ParseEnum(typeof(KalturaStatsEventType), txt);
						continue;
					case "eventTimestamp":
						this.EventTimestamp = ParseFloat(txt);
						continue;
					case "sessionId":
						this.SessionId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "uniqueViewer":
						this.UniqueViewer = txt;
						continue;
					case "widgetId":
						this.WidgetId = txt;
						continue;
					case "uiconfId":
						this.UiconfId = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "currentPoint":
						this.CurrentPoint = ParseInt(txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "userIp":
						this.UserIp = txt;
						continue;
					case "processDuration":
						this.ProcessDuration = ParseInt(txt);
						continue;
					case "controlId":
						this.ControlId = txt;
						continue;
					case "seek":
						this.Seek = ParseBool(txt);
						continue;
					case "newPoint":
						this.NewPoint = ParseInt(txt);
						continue;
					case "referrer":
						this.Referrer = txt;
						continue;
					case "isFirstInSession":
						this.IsFirstInSession = ParseBool(txt);
						continue;
					case "applicationId":
						this.ApplicationId = txt;
						continue;
					case "contextId":
						this.ContextId = ParseInt(txt);
						continue;
					case "featureType":
						this.FeatureType = (KalturaStatsFeatureType)ParseEnum(typeof(KalturaStatsFeatureType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaStatsEvent");
			kparams.AddIfNotNull("clientVer", this.ClientVer);
			kparams.AddIfNotNull("eventType", this.EventType);
			kparams.AddIfNotNull("eventTimestamp", this.EventTimestamp);
			kparams.AddIfNotNull("sessionId", this.SessionId);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("entryId", this.EntryId);
			kparams.AddIfNotNull("uniqueViewer", this.UniqueViewer);
			kparams.AddIfNotNull("widgetId", this.WidgetId);
			kparams.AddIfNotNull("uiconfId", this.UiconfId);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("currentPoint", this.CurrentPoint);
			kparams.AddIfNotNull("duration", this.Duration);
			kparams.AddIfNotNull("userIp", this.UserIp);
			kparams.AddIfNotNull("processDuration", this.ProcessDuration);
			kparams.AddIfNotNull("controlId", this.ControlId);
			kparams.AddIfNotNull("seek", this.Seek);
			kparams.AddIfNotNull("newPoint", this.NewPoint);
			kparams.AddIfNotNull("referrer", this.Referrer);
			kparams.AddIfNotNull("isFirstInSession", this.IsFirstInSession);
			kparams.AddIfNotNull("applicationId", this.ApplicationId);
			kparams.AddIfNotNull("contextId", this.ContextId);
			kparams.AddIfNotNull("featureType", this.FeatureType);
			return kparams;
		}
		#endregion
	}
}

