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
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public KalturaCuePointType CuePointType
		{
			get { return _CuePointType; }
			set 
			{ 
				_CuePointType = value;
				OnPropertyChanged("CuePointType");
			}
		}
		public KalturaCuePointStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
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
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
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

		public KalturaCuePoint(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "cuePointType":
						this.CuePointType = (KalturaCuePointType)KalturaStringEnum.Parse(typeof(KalturaCuePointType), txt);
						continue;
					case "status":
						this.Status = (KalturaCuePointStatus)ParseEnum(typeof(KalturaCuePointStatus), txt);
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "triggeredAt":
						this.TriggeredAt = ParseInt(txt);
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "startTime":
						this.StartTime = ParseInt(txt);
						continue;
					case "userId":
						this.UserId = txt;
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "partnerSortValue":
						this.PartnerSortValue = ParseInt(txt);
						continue;
					case "forceStop":
						this.ForceStop = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "thumbOffset":
						this.ThumbOffset = ParseInt(txt);
						continue;
					case "systemName":
						this.SystemName = txt;
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
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddStringEnumIfNotNull("cuePointType", this.CuePointType);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIntIfNotNull("triggeredAt", this.TriggeredAt);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddIntIfNotNull("startTime", this.StartTime);
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddStringIfNotNull("partnerData", this.PartnerData);
			kparams.AddIntIfNotNull("partnerSortValue", this.PartnerSortValue);
			kparams.AddEnumIfNotNull("forceStop", this.ForceStop);
			kparams.AddIntIfNotNull("thumbOffset", this.ThumbOffset);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			return kparams;
		}
		#endregion
	}
}

