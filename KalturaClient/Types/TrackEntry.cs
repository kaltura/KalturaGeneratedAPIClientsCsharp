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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class TrackEntry : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TRACK_EVENT_TYPE = "trackEventType";
		public const string PS_VERSION = "psVersion";
		public const string CONTEXT = "context";
		public const string PARTNER_ID = "partnerId";
		public const string ENTRY_ID = "entryId";
		public const string HOST_NAME = "hostName";
		public const string USER_ID = "userId";
		public const string CHANGED_PROPERTIES = "changedProperties";
		public const string PARAM_STR1 = "paramStr1";
		public const string PARAM_STR2 = "paramStr2";
		public const string PARAM_STR3 = "paramStr3";
		public const string KS = "ks";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string USER_IP = "userIp";
		public const string SESSION_ID = "sessionId";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private TrackEntryEventType _TrackEventType = (TrackEntryEventType)Int32.MinValue;
		private string _PsVersion = null;
		private string _Context = null;
		private int _PartnerId = Int32.MinValue;
		private string _EntryId = null;
		private string _HostName = null;
		private string _UserId = null;
		private string _ChangedProperties = null;
		private string _ParamStr1 = null;
		private string _ParamStr2 = null;
		private string _ParamStr3 = null;
		private string _Ks = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _UserIp = null;
		private int _SessionId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use TrackEventTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public TrackEntryEventType TrackEventType
		{
			get { return _TrackEventType; }
			set 
			{ 
				_TrackEventType = value;
				OnPropertyChanged("TrackEventType");
			}
		}
		/// <summary>
		/// Use PsVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PsVersion
		{
			get { return _PsVersion; }
			set 
			{ 
				_PsVersion = value;
				OnPropertyChanged("PsVersion");
			}
		}
		/// <summary>
		/// Use ContextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Context
		{
			get { return _Context; }
			set 
			{ 
				_Context = value;
				OnPropertyChanged("Context");
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
		/// Use HostNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HostName
		{
			get { return _HostName; }
			set 
			{ 
				_HostName = value;
				OnPropertyChanged("HostName");
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
		/// Use ChangedPropertiesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ChangedProperties
		{
			get { return _ChangedProperties; }
			set 
			{ 
				_ChangedProperties = value;
				OnPropertyChanged("ChangedProperties");
			}
		}
		/// <summary>
		/// Use ParamStr1AsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParamStr1
		{
			get { return _ParamStr1; }
			set 
			{ 
				_ParamStr1 = value;
				OnPropertyChanged("ParamStr1");
			}
		}
		/// <summary>
		/// Use ParamStr2AsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParamStr2
		{
			get { return _ParamStr2; }
			set 
			{ 
				_ParamStr2 = value;
				OnPropertyChanged("ParamStr2");
			}
		}
		/// <summary>
		/// Use ParamStr3AsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParamStr3
		{
			get { return _ParamStr3; }
			set 
			{ 
				_ParamStr3 = value;
				OnPropertyChanged("ParamStr3");
			}
		}
		/// <summary>
		/// Use KsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Ks
		{
			get { return _Ks; }
			set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use UserIpAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserIp
		{
			get { return _UserIp; }
			set 
			{ 
				_UserIp = value;
				OnPropertyChanged("UserIp");
			}
		}
		/// <summary>
		/// Use SessionIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SessionId
		{
			get { return _SessionId; }
			set 
			{ 
				_SessionId = value;
				OnPropertyChanged("SessionId");
			}
		}
		#endregion

		#region CTor
		public TrackEntry()
		{
		}

		public TrackEntry(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["trackEventType"] != null)
			{
				this._TrackEventType = (TrackEntryEventType)ParseEnum(typeof(TrackEntryEventType), node["trackEventType"].Value<string>());
			}
			if(node["psVersion"] != null)
			{
				this._PsVersion = node["psVersion"].Value<string>();
			}
			if(node["context"] != null)
			{
				this._Context = node["context"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["hostName"] != null)
			{
				this._HostName = node["hostName"].Value<string>();
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["changedProperties"] != null)
			{
				this._ChangedProperties = node["changedProperties"].Value<string>();
			}
			if(node["paramStr1"] != null)
			{
				this._ParamStr1 = node["paramStr1"].Value<string>();
			}
			if(node["paramStr2"] != null)
			{
				this._ParamStr2 = node["paramStr2"].Value<string>();
			}
			if(node["paramStr3"] != null)
			{
				this._ParamStr3 = node["paramStr3"].Value<string>();
			}
			if(node["ks"] != null)
			{
				this._Ks = node["ks"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["userIp"] != null)
			{
				this._UserIp = node["userIp"].Value<string>();
			}
			if(node["sessionId"] != null)
			{
				this._SessionId = ParseInt(node["sessionId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaTrackEntry");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("trackEventType", this._TrackEventType);
			kparams.AddIfNotNull("psVersion", this._PsVersion);
			kparams.AddIfNotNull("context", this._Context);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("hostName", this._HostName);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("changedProperties", this._ChangedProperties);
			kparams.AddIfNotNull("paramStr1", this._ParamStr1);
			kparams.AddIfNotNull("paramStr2", this._ParamStr2);
			kparams.AddIfNotNull("paramStr3", this._ParamStr3);
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("userIp", this._UserIp);
			kparams.AddIfNotNull("sessionId", this._SessionId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TRACK_EVENT_TYPE:
					return "TrackEventType";
				case PS_VERSION:
					return "PsVersion";
				case CONTEXT:
					return "Context";
				case PARTNER_ID:
					return "PartnerId";
				case ENTRY_ID:
					return "EntryId";
				case HOST_NAME:
					return "HostName";
				case USER_ID:
					return "UserId";
				case CHANGED_PROPERTIES:
					return "ChangedProperties";
				case PARAM_STR1:
					return "ParamStr1";
				case PARAM_STR2:
					return "ParamStr2";
				case PARAM_STR3:
					return "ParamStr3";
				case KS:
					return "Ks";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case USER_IP:
					return "UserIp";
				case SESSION_ID:
					return "SessionId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

