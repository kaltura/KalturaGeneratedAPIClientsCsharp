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
	public class LiveChannelSegment : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string TYPE = "type";
		public const string STATUS = "status";
		public const string CHANNEL_ID = "channelId";
		public const string ENTRY_ID = "entryId";
		public const string TRIGGER_TYPE = "triggerType";
		public const string TRIGGER_SEGMENT_ID = "triggerSegmentId";
		public const string START_TIME = "startTime";
		public const string DURATION = "duration";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private string _Tags = null;
		private LiveChannelSegmentType _Type = null;
		private LiveChannelSegmentStatus _Status = null;
		private string _ChannelId = null;
		private string _EntryId = null;
		private LiveChannelSegmentTriggerType _TriggerType = null;
		private long _TriggerSegmentId = long.MinValue;
		private float _StartTime = Single.MinValue;
		private float _Duration = Single.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
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
		public LiveChannelSegmentType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public LiveChannelSegmentStatus Status
		{
			get { return _Status; }
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
		public LiveChannelSegmentTriggerType TriggerType
		{
			get { return _TriggerType; }
			set 
			{ 
				_TriggerType = value;
				OnPropertyChanged("TriggerType");
			}
		}
		public long TriggerSegmentId
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
		public LiveChannelSegment()
		{
		}

		public LiveChannelSegment(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
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
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = (LiveChannelSegmentType)StringEnum.Parse(typeof(LiveChannelSegmentType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (LiveChannelSegmentStatus)StringEnum.Parse(typeof(LiveChannelSegmentStatus), propertyNode.InnerText);
						continue;
					case "channelId":
						this._ChannelId = propertyNode.InnerText;
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "triggerType":
						this._TriggerType = (LiveChannelSegmentTriggerType)StringEnum.Parse(typeof(LiveChannelSegmentTriggerType), propertyNode.InnerText);
						continue;
					case "triggerSegmentId":
						this._TriggerSegmentId = ParseLong(propertyNode.InnerText);
						continue;
					case "startTime":
						this._StartTime = ParseFloat(propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseFloat(propertyNode.InnerText);
						continue;
				}
			}
		}

		public LiveChannelSegment(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<long>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._Type = (LiveChannelSegmentType)StringEnum.Parse(typeof(LiveChannelSegmentType), data.TryGetValueSafe<string>("type"));
			    this._Status = (LiveChannelSegmentStatus)StringEnum.Parse(typeof(LiveChannelSegmentStatus), data.TryGetValueSafe<string>("status"));
			    this._ChannelId = data.TryGetValueSafe<string>("channelId");
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._TriggerType = (LiveChannelSegmentTriggerType)StringEnum.Parse(typeof(LiveChannelSegmentTriggerType), data.TryGetValueSafe<string>("triggerType"));
			    this._TriggerSegmentId = data.TryGetValueSafe<long>("triggerSegmentId");
			    this._StartTime = data.TryGetValueSafe<float>("startTime");
			    this._Duration = data.TryGetValueSafe<float>("duration");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveChannelSegment");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("channelId", this._ChannelId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("triggerType", this._TriggerType);
			kparams.AddIfNotNull("triggerSegmentId", this._TriggerSegmentId);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("duration", this._Duration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case NAME:
					return "Name";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case TYPE:
					return "Type";
				case STATUS:
					return "Status";
				case CHANNEL_ID:
					return "ChannelId";
				case ENTRY_ID:
					return "EntryId";
				case TRIGGER_TYPE:
					return "TriggerType";
				case TRIGGER_SEGMENT_ID:
					return "TriggerSegmentId";
				case START_TIME:
					return "StartTime";
				case DURATION:
					return "Duration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

