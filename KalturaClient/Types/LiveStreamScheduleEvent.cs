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
	public class LiveStreamScheduleEvent : EntryScheduleEvent
	{
		#region Constants
		public const string PROJECTED_AUDIENCE = "projectedAudience";
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string PRE_START_TIME = "preStartTime";
		public const string POST_END_TIME = "postEndTime";
		#endregion

		#region Private Fields
		private int _ProjectedAudience = Int32.MinValue;
		private string _SourceEntryId = null;
		private int _PreStartTime = Int32.MinValue;
		private int _PostEndTime = Int32.MinValue;
		#endregion

		#region Properties
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
		#endregion

		#region CTor
		public LiveStreamScheduleEvent()
		{
		}

		public LiveStreamScheduleEvent(JToken node) : base(node)
		{
			if(node["projectedAudience"] != null)
			{
				this._ProjectedAudience = ParseInt(node["projectedAudience"].Value<string>());
			}
			if(node["sourceEntryId"] != null)
			{
				this._SourceEntryId = node["sourceEntryId"].Value<string>();
			}
			if(node["preStartTime"] != null)
			{
				this._PreStartTime = ParseInt(node["preStartTime"].Value<string>());
			}
			if(node["postEndTime"] != null)
			{
				this._PostEndTime = ParseInt(node["postEndTime"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamScheduleEvent");
			kparams.AddIfNotNull("projectedAudience", this._ProjectedAudience);
			kparams.AddIfNotNull("sourceEntryId", this._SourceEntryId);
			kparams.AddIfNotNull("preStartTime", this._PreStartTime);
			kparams.AddIfNotNull("postEndTime", this._PostEndTime);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROJECTED_AUDIENCE:
					return "ProjectedAudience";
				case SOURCE_ENTRY_ID:
					return "SourceEntryId";
				case PRE_START_TIME:
					return "PreStartTime";
				case POST_END_TIME:
					return "PostEndTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

