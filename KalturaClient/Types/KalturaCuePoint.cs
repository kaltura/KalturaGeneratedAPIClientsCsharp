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
	public class KalturaCuePoint : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private KalturaCuePointType _CuePointType = null;
		private KalturaCuePointStatus _Status = (KalturaCuePointStatus)Int32.MinValue;
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
		private KalturaNullableBoolean _ForceStop = (KalturaNullableBoolean)Int32.MinValue;
		private int _ThumbOffset = Int32.MinValue;
		private string _SystemName = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public KalturaCuePointType CuePointType
		{
			get { return _CuePointType; }
		}
		public KalturaCuePointStatus Status
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
		public KalturaNullableBoolean ForceStop
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
		#endregion

		#region CTor
		public KalturaCuePoint()
		{
		}

		public KalturaCuePoint(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "cuePointType":
						this._CuePointType = (KalturaCuePointType)KalturaStringEnum.Parse(typeof(KalturaCuePointType), txt);
						continue;
					case "status":
						this._Status = (KalturaCuePointStatus)ParseEnum(typeof(KalturaCuePointStatus), txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "triggeredAt":
						this._TriggeredAt = ParseInt(txt);
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "startTime":
						this._StartTime = ParseInt(txt);
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "partnerData":
						this._PartnerData = txt;
						continue;
					case "partnerSortValue":
						this._PartnerSortValue = ParseInt(txt);
						continue;
					case "forceStop":
						this._ForceStop = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "thumbOffset":
						this._ThumbOffset = ParseInt(txt);
						continue;
					case "systemName":
						this._SystemName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
			return kparams;
		}
		#endregion
	}
}

