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
	public class ClipDescription : ObjectBase
	{
		#region Constants
		public const string SOURCE_ENTRY_ID = "sourceEntryId";
		public const string START_TIME = "startTime";
		public const string DURATION = "duration";
		public const string OFFSET_IN_DESTINATION = "offsetInDestination";
		#endregion

		#region Private Fields
		private string _SourceEntryId = null;
		private int _StartTime = Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _OffsetInDestination = Int32.MinValue;
		#endregion

		#region Properties
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
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		[JsonProperty]
		public int OffsetInDestination
		{
			get { return _OffsetInDestination; }
			set 
			{ 
				_OffsetInDestination = value;
				OnPropertyChanged("OffsetInDestination");
			}
		}
		#endregion

		#region CTor
		public ClipDescription()
		{
		}

		public ClipDescription(JToken node) : base(node)
		{
			if(node["sourceEntryId"] != null)
			{
				this._SourceEntryId = node["sourceEntryId"].Value<string>();
			}
			if(node["startTime"] != null)
			{
				this._StartTime = ParseInt(node["startTime"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["offsetInDestination"] != null)
			{
				this._OffsetInDestination = ParseInt(node["offsetInDestination"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaClipDescription");
			kparams.AddIfNotNull("sourceEntryId", this._SourceEntryId);
			kparams.AddIfNotNull("startTime", this._StartTime);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("offsetInDestination", this._OffsetInDestination);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_ENTRY_ID:
					return "SourceEntryId";
				case START_TIME:
					return "StartTime";
				case DURATION:
					return "Duration";
				case OFFSET_IN_DESTINATION:
					return "OffsetInDestination";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

