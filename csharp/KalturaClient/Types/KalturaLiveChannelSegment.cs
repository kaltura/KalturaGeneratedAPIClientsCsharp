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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaLiveChannelSegment : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private string _Tags = null;
		private KalturaLiveChannelSegmentType _Type = null;
		private KalturaLiveChannelSegmentStatus _Status = null;
		private string _ChannelId = null;
		private string _EntryId = null;
		private KalturaLiveChannelSegmentTriggerType _TriggerType = null;
		private string _TriggerSegmentId = null;
		private float _StartTime = Single.MinValue;
		private float _Duration = Single.MinValue;
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
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
		public KalturaLiveChannelSegmentType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public KalturaLiveChannelSegmentStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string ChannelId
		{
			get { return _ChannelId; }
			set 
			{ 
				_ChannelId = value;
				OnPropertyChanged("ChannelId");
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
		public KalturaLiveChannelSegmentTriggerType TriggerType
		{
			get { return _TriggerType; }
			set 
			{ 
				_TriggerType = value;
				OnPropertyChanged("TriggerType");
			}
		}
		public string TriggerSegmentId
		{
			get { return _TriggerSegmentId; }
			set 
			{ 
				_TriggerSegmentId = value;
				OnPropertyChanged("TriggerSegmentId");
			}
		}
		public float StartTime
		{
			get { return _StartTime; }
			set 
			{ 
				_StartTime = value;
				OnPropertyChanged("StartTime");
			}
		}
		public float Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveChannelSegment()
		{
		}

		public KalturaLiveChannelSegment(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
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
					case "name":
						this.Name = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "type":
						this.Type = (KalturaLiveChannelSegmentType)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentType), txt);
						continue;
					case "status":
						this.Status = (KalturaLiveChannelSegmentStatus)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentStatus), txt);
						continue;
					case "channelId":
						this.ChannelId = txt;
						continue;
					case "entryId":
						this.EntryId = txt;
						continue;
					case "triggerType":
						this.TriggerType = (KalturaLiveChannelSegmentTriggerType)KalturaStringEnum.Parse(typeof(KalturaLiveChannelSegmentTriggerType), txt);
						continue;
					case "triggerSegmentId":
						this.TriggerSegmentId = txt;
						continue;
					case "startTime":
						this.StartTime = ParseFloat(txt);
						continue;
					case "duration":
						this.Duration = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveChannelSegment");
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddStringEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("channelId", this.ChannelId);
			kparams.AddStringIfNotNull("entryId", this.EntryId);
			kparams.AddStringEnumIfNotNull("triggerType", this.TriggerType);
			kparams.AddStringIfNotNull("triggerSegmentId", this.TriggerSegmentId);
			kparams.AddFloatIfNotNull("startTime", this.StartTime);
			kparams.AddFloatIfNotNull("duration", this.Duration);
			return kparams;
		}
		#endregion
	}
}

