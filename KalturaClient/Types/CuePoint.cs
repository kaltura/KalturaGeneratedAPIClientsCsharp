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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class CuePoint : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string INT_ID = "intId";
		public const string CUE_POINT_TYPE = "cuePointType";
		public const string STATUS = "status";
		public const string ENTRY_ID = "entryId";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string TRIGGERED_AT = "triggeredAt";
		public const string TAGS = "tags";
		public const string START_TIME = "startTime";
		public const string USER_ID = "userId";
		public const string PARTNER_DATA = "partnerData";
		public const string PARTNER_SORT_VALUE = "partnerSortValue";
		public const string FORCE_STOP = "forceStop";
		public const string THUMB_OFFSET = "thumbOffset";
		public const string SYSTEM_NAME = "systemName";
		public const string IS_MOMENTARY = "isMomentary";
		public const string COPIED_FROM = "copiedFrom";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _IntId = Int32.MinValue;
		private CuePointType _CuePointType = null;
		private CuePointStatus _Status = (CuePointStatus)Int32.MinValue;
		private string _EntryId = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _TriggeredAt = Int32.MinValue;
		private string _Tags = null;
		private int _StartTime = Int32.MinValue;
		private string _UserId = null;
		private string _PartnerData = null;
		private int _PartnerSortValue = Int32.MinValue;
		private NullableBoolean _ForceStop = (NullableBoolean)Int32.MinValue;
		private int _ThumbOffset = Int32.MinValue;
		private string _SystemName = null;
		private bool? _IsMomentary = null;
		private string _CopiedFrom = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public int IntId
		{
			get { return _IntId; }
			private set 
			{ 
				_IntId = value;
				OnPropertyChanged("IntId");
			}
		}
		[JsonProperty]
		public CuePointType CuePointType
		{
			get { return _CuePointType; }
			private set 
			{ 
				_CuePointType = value;
				OnPropertyChanged("CuePointType");
			}
		}
		[JsonProperty]
		public CuePointStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public int TriggeredAt
		{
			get { return _TriggeredAt; }
			set 
			{ 
				_TriggeredAt = value;
				OnPropertyChanged("TriggeredAt");
			}
		}
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		[JsonProperty]
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		[JsonProperty]
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		[JsonProperty]
		public NullableBoolean ForceStop
		{
			get { return _ForceStop; }
			set 
			{ 
				_ForceStop = value;
				OnPropertyChanged("ForceStop");
			}
		}
		[JsonProperty]
		public int ThumbOffset
		{
			get { return _ThumbOffset; }
			set 
			{ 
				_ThumbOffset = value;
				OnPropertyChanged("ThumbOffset");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public bool? IsMomentary
		{
			get { return _IsMomentary; }
			private set 
			{ 
				_IsMomentary = value;
				OnPropertyChanged("IsMomentary");
			}
		}
		[JsonProperty]
		public string CopiedFrom
		{
			get { return _CopiedFrom; }
			private set 
			{ 
				_CopiedFrom = value;
				OnPropertyChanged("CopiedFrom");
			}
		}
		#endregion

		#region CTor
		public CuePoint()
		{
		}

		public CuePoint(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["intId"] != null)
			{
				this._IntId = ParseInt(node["intId"].Value<string>());
			}
			if(node["cuePointType"] != null)
			{
				this._CuePointType = (CuePointType)StringEnum.Parse(typeof(CuePointType), node["cuePointType"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (CuePointStatus)ParseEnum(typeof(CuePointStatus), node["status"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["triggeredAt"] != null)
			{
				this._TriggeredAt = ParseInt(node["triggeredAt"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["startTime"] != null)
			{
				this._StartTime = ParseInt(node["startTime"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["partnerSortValue"] != null)
			{
				this._PartnerSortValue = ParseInt(node["partnerSortValue"].Value<string>());
			}
			if(node["forceStop"] != null)
			{
				this._ForceStop = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["forceStop"].Value<string>());
			}
			if(node["thumbOffset"] != null)
			{
				this._ThumbOffset = ParseInt(node["thumbOffset"].Value<string>());
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["isMomentary"] != null)
			{
				this._IsMomentary = ParseBool(node["isMomentary"].Value<string>());
			}
			if(node["copiedFrom"] != null)
			{
				this._CopiedFrom = node["copiedFrom"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCuePoint");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("intId", this._IntId);
			kparams.AddIfNotNull("cuePointType", this._CuePointType);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("triggeredAt", this._TriggeredAt);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("partnerSortValue", this._PartnerSortValue);
			kparams.AddIfNotNull("forceStop", this._ForceStop);
			kparams.AddIfNotNull("thumbOffset", this._ThumbOffset);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("isMomentary", this._IsMomentary);
			kparams.AddIfNotNull("copiedFrom", this._CopiedFrom);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case INT_ID:
					return "IntId";
				case CUE_POINT_TYPE:
					return "CuePointType";
				case STATUS:
					return "Status";
				case ENTRY_ID:
					return "EntryId";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case TRIGGERED_AT:
					return "TriggeredAt";
				case TAGS:
					return "Tags";
				case START_TIME:
					return "StartTime";
				case USER_ID:
					return "UserId";
				case PARTNER_DATA:
					return "PartnerData";
				case PARTNER_SORT_VALUE:
					return "PartnerSortValue";
				case FORCE_STOP:
					return "ForceStop";
				case THUMB_OFFSET:
					return "ThumbOffset";
				case SYSTEM_NAME:
					return "SystemName";
				case IS_MOMENTARY:
					return "IsMomentary";
				case COPIED_FROM:
					return "CopiedFrom";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

