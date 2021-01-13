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
	public class LiveChannelSegmentBaseFilter : RelatedFilter
	{
		#region Constants
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CHANNEL_ID_EQUAL = "channelIdEqual";
		public const string CHANNEL_ID_IN = "channelIdIn";
		public const string START_TIME_GREATER_THAN_OR_EQUAL = "startTimeGreaterThanOrEqual";
		public const string START_TIME_LESS_THAN_OR_EQUAL = "startTimeLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private LiveChannelSegmentStatus _StatusEqual = null;
		private string _StatusIn = null;
		private string _ChannelIdEqual = null;
		private string _ChannelIdIn = null;
		private float _StartTimeGreaterThanOrEqual = Single.MinValue;
		private float _StartTimeLessThanOrEqual = Single.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public LiveChannelSegmentStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public string ChannelIdEqual
		{
			get { return _ChannelIdEqual; }
			set 
			{ 
				_ChannelIdEqual = value;
				OnPropertyChanged("ChannelIdEqual");
			}
		}
		[JsonProperty]
		public string ChannelIdIn
		{
			get { return _ChannelIdIn; }
			set 
			{ 
				_ChannelIdIn = value;
				OnPropertyChanged("ChannelIdIn");
			}
		}
		[JsonProperty]
		public float StartTimeGreaterThanOrEqual
		{
			get { return _StartTimeGreaterThanOrEqual; }
			set 
			{ 
				_StartTimeGreaterThanOrEqual = value;
				OnPropertyChanged("StartTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public float StartTimeLessThanOrEqual
		{
			get { return _StartTimeLessThanOrEqual; }
			set 
			{ 
				_StartTimeLessThanOrEqual = value;
				OnPropertyChanged("StartTimeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public LiveChannelSegmentBaseFilter()
		{
		}

		public LiveChannelSegmentBaseFilter(JToken node) : base(node)
		{
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (LiveChannelSegmentStatus)StringEnum.Parse(typeof(LiveChannelSegmentStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["channelIdEqual"] != null)
			{
				this._ChannelIdEqual = node["channelIdEqual"].Value<string>();
			}
			if(node["channelIdIn"] != null)
			{
				this._ChannelIdIn = node["channelIdIn"].Value<string>();
			}
			if(node["startTimeGreaterThanOrEqual"] != null)
			{
				this._StartTimeGreaterThanOrEqual = ParseFloat(node["startTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["startTimeLessThanOrEqual"] != null)
			{
				this._StartTimeLessThanOrEqual = ParseFloat(node["startTimeLessThanOrEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveChannelSegmentBaseFilter");
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("channelIdEqual", this._ChannelIdEqual);
			kparams.AddIfNotNull("channelIdIn", this._ChannelIdIn);
			kparams.AddIfNotNull("startTimeGreaterThanOrEqual", this._StartTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("startTimeLessThanOrEqual", this._StartTimeLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CHANNEL_ID_EQUAL:
					return "ChannelIdEqual";
				case CHANNEL_ID_IN:
					return "ChannelIdIn";
				case START_TIME_GREATER_THAN_OR_EQUAL:
					return "StartTimeGreaterThanOrEqual";
				case START_TIME_LESS_THAN_OR_EQUAL:
					return "StartTimeLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

