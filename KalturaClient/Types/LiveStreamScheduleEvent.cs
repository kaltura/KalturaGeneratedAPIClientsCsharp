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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class LiveStreamScheduleEvent : BaseLiveScheduleEvent
	{
		#region Constants
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string PROJECTED_AUDIENCE = "projectedAudience";
		public const string PRE_START_TIME = "preStartTime";
		public const string POST_END_TIME = "postEndTime";
		public const string PRE_START_ENTRY_ID = "preStartEntryId";
		public const string POST_END_ENTRY_ID = "postEndEntryId";
		public const string IS_CONTENT_INTERRUPTIBLE = "isContentInterruptible";
		#endregion

		#region Private Fields
		private string _SourceEntryId = null;
		private int _ProjectedAudience = Int32.MinValue;
		private int _PreStartTime = Int32.MinValue;
		private int _PostEndTime = Int32.MinValue;
		private string _PreStartEntryId = null;
		private string _PostEndEntryId = null;
		private bool? _IsContentInterruptible = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use SourceEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SourceEntryId
		{
			get { return _SourceEntryId; }
			set 
			{ 
				_SourceEntryId = value;
				OnPropertyChanged("SourceEntryId");
			}
		}
		/// <summary>
		/// Use ProjectedAudienceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ProjectedAudience
		{
			get { return _ProjectedAudience; }
			set 
			{ 
				_ProjectedAudience = value;
				OnPropertyChanged("ProjectedAudience");
			}
		}
		/// <summary>
		/// Use PreStartTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PreStartTime
		{
			get { return _PreStartTime; }
			set 
			{ 
				_PreStartTime = value;
				OnPropertyChanged("PreStartTime");
			}
		}
		/// <summary>
		/// Use PostEndTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PostEndTime
		{
			get { return _PostEndTime; }
			set 
			{ 
				_PostEndTime = value;
				OnPropertyChanged("PostEndTime");
			}
		}
		/// <summary>
		/// Use PreStartEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PreStartEntryId
		{
			get { return _PreStartEntryId; }
			set 
			{ 
				_PreStartEntryId = value;
				OnPropertyChanged("PreStartEntryId");
			}
		}
		/// <summary>
		/// Use PostEndEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PostEndEntryId
		{
			get { return _PostEndEntryId; }
			set 
			{ 
				_PostEndEntryId = value;
				OnPropertyChanged("PostEndEntryId");
			}
		}
		/// <summary>
		/// Use IsContentInterruptibleAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsContentInterruptible
		{
			get { return _IsContentInterruptible; }
			set 
			{ 
				_IsContentInterruptible = value;
				OnPropertyChanged("IsContentInterruptible");
			}
		}
		#endregion

		#region CTor
		public LiveStreamScheduleEvent()
		{
		}

		public LiveStreamScheduleEvent(JToken node) : base(node)
		{
			if(node["sourceEntryId"] != null)
			{
				this._SourceEntryId = node["sourceEntryId"].Value<string>();
			}
			if(node["projectedAudience"] != null)
			{
				this._ProjectedAudience = ParseInt(node["projectedAudience"].Value<string>());
			}
			if(node["preStartTime"] != null)
			{
				this._PreStartTime = ParseInt(node["preStartTime"].Value<string>());
			}
			if(node["postEndTime"] != null)
			{
				this._PostEndTime = ParseInt(node["postEndTime"].Value<string>());
			}
			if(node["preStartEntryId"] != null)
			{
				this._PreStartEntryId = node["preStartEntryId"].Value<string>();
			}
			if(node["postEndEntryId"] != null)
			{
				this._PostEndEntryId = node["postEndEntryId"].Value<string>();
			}
			if(node["isContentInterruptible"] != null)
			{
				this._IsContentInterruptible = ParseBool(node["isContentInterruptible"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamScheduleEvent");
			kparams.AddIfNotNull("sourceEntryId", this._SourceEntryId);
			kparams.AddIfNotNull("projectedAudience", this._ProjectedAudience);
			kparams.AddIfNotNull("preStartTime", this._PreStartTime);
			kparams.AddIfNotNull("postEndTime", this._PostEndTime);
			kparams.AddIfNotNull("preStartEntryId", this._PreStartEntryId);
			kparams.AddIfNotNull("postEndEntryId", this._PostEndEntryId);
			kparams.AddIfNotNull("isContentInterruptible", this._IsContentInterruptible);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_ENTRY_ID:
					return "SourceEntryId";
				case PROJECTED_AUDIENCE:
					return "ProjectedAudience";
				case PRE_START_TIME:
					return "PreStartTime";
				case POST_END_TIME:
					return "PostEndTime";
				case PRE_START_ENTRY_ID:
					return "PreStartEntryId";
				case POST_END_ENTRY_ID:
					return "PostEndEntryId";
				case IS_CONTENT_INTERRUPTIBLE:
					return "IsContentInterruptible";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

