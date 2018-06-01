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
	public class CuePoint : ObjectBase
	{
		#region Constants
		public const string ID = "id";
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
		#endregion

		#region Private Fields
		private string _Id = null;
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
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public CuePointType CuePointType
		{
			get { return _CuePointType; }
		}
		public CuePointStatus Status
		{
			get { return _Status; }
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
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int TriggeredAt
		{
			get { return _TriggeredAt; }
			set 
			{ 
				_TriggeredAt = value;
				OnPropertyChanged("TriggeredAt");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public int StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public int PartnerSortValue
		{
			get { return _PartnerSortValue; }
			set 
			{ 
				_PartnerSortValue = value;
				OnPropertyChanged("PartnerSortValue");
			}
		}
		public NullableBoolean ForceStop
		{
			get { return _ForceStop; }
			set 
			{ 
				_ForceStop = value;
				OnPropertyChanged("ForceStop");
			}
		}
		public int ThumbOffset
		{
			get { return _ThumbOffset; }
			set 
			{ 
				_ThumbOffset = value;
				OnPropertyChanged("ThumbOffset");
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
		public bool? IsMomentary
		{
			get { return _IsMomentary; }
		}
		#endregion

		#region CTor
		public CuePoint()
		{
		}

		public CuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "cuePointType":
						this._CuePointType = (CuePointType)StringEnum.Parse(typeof(CuePointType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (CuePointStatus)ParseEnum(typeof(CuePointStatus), propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "triggeredAt":
						this._TriggeredAt = ParseInt(propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "startTime":
						this._StartTime = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(propertyNode.InnerText);
						continue;
					case "forceStop":
						this._ForceStop = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "thumbOffset":
						this._ThumbOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "isMomentary":
						this._IsMomentary = ParseBool(propertyNode.InnerText);
						continue;
				}
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
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

