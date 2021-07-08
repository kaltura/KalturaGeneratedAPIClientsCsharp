// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
		private double _EventTimestamp = Double.MinValue;
		private string _SessionId = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _WidgetId = null;
		private int _UiconfId = Int32.MinValue;
		private string _UserId = null;
		private string _UserIp = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ClientVerAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use KmcEventActionPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string KmcEventActionPath
		{
			get { return _KmcEventActionPath; }
			set 
			{ 
				_KmcEventActionPath = value;
				OnPropertyChanged("KmcEventActionPath");
			}
		}
		/// <summary>
		/// Use KmcEventTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public StatsKmcEventType KmcEventType
		{
			get { return _KmcEventType; }
			set 
			{ 
				_KmcEventType = value;
				OnPropertyChanged("KmcEventType");
			}
		}
		/// <summary>
		/// Use EventTimestampAsDouble property instead
		/// </summary>
		[JsonProperty]
		[Obsolete("Use EventTimestampAsDouble property instead")]
		public float EventTimestamp
		{
			get { return (float)_EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		///<summary>
		///Use this property EventTimestampAsDouble instead of the float EventTimestamp property version
		///</summary>
		[JsonProperty]
		public double EventTimestampAsDouble
		{
			get { return _EventTimestamp; }
			set 
			{ 
				_EventTimestamp = value;
				OnPropertyChanged("EventTimestamp");
			}
		}
		/// <summary>
		/// Use SessionIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use WidgetIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UiconfIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UserIpAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public StatsKmcEvent()
		{
		}

		public StatsKmcEvent(JToken node) : base(node)
		{
			if(node["clientVer"] != null)
			{
				this._ClientVer = node["clientVer"].Value<string>();
			}
			if(node["kmcEventActionPath"] != null)
			{
				this._KmcEventActionPath = node["kmcEventActionPath"].Value<string>();
			}
			if(node["kmcEventType"] != null)
			{
				this._KmcEventType = (StatsKmcEventType)ParseEnum(typeof(StatsKmcEventType), node["kmcEventType"].Value<string>());
			}
			if(node["eventTimestamp"] != null)
			{
				this._EventTimestamp = ParseDouble(node["eventTimestamp"].Value<string>());
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
			if(node["userIp"] != null)
			{
				this._UserIp = node["userIp"].Value<string>();
			}
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

