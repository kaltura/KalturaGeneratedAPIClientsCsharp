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
	public class LiveEntryServerNode : EntryServerNode
	{
		#region Constants
		public const string STREAMS = "streams";
		public const string RECORDING_INFO = "recordingInfo";
		public const string IS_PLAYABLE_USER = "isPlayableUser";
		public const string VIEW_MODE = "viewMode";
		#endregion

		#region Private Fields
		private IList<LiveStreamParams> _Streams;
		private IList<LiveEntryServerNodeRecordingInfo> _RecordingInfo;
		private bool? _IsPlayableUser = null;
		private ViewMode _ViewMode = (ViewMode)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use StreamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveStreamParams> Streams
		{
			get { return _Streams; }
			set 
			{ 
				_Streams = value;
				OnPropertyChanged("Streams");
			}
		}
		/// <summary>
		/// Use RecordingInfoAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveEntryServerNodeRecordingInfo> RecordingInfo
		{
			get { return _RecordingInfo; }
			set 
			{ 
				_RecordingInfo = value;
				OnPropertyChanged("RecordingInfo");
			}
		}
		/// <summary>
		/// Use IsPlayableUserAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsPlayableUser
		{
			get { return _IsPlayableUser; }
			set 
			{ 
				_IsPlayableUser = value;
				OnPropertyChanged("IsPlayableUser");
			}
		}
		/// <summary>
		/// Use ViewModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ViewMode ViewMode
		{
			get { return _ViewMode; }
			set 
			{ 
				_ViewMode = value;
				OnPropertyChanged("ViewMode");
			}
		}
		#endregion

		#region CTor
		public LiveEntryServerNode()
		{
		}

		public LiveEntryServerNode(JToken node) : base(node)
		{
			if(node["streams"] != null)
			{
				this._Streams = new List<LiveStreamParams>();
				foreach(var arrayNode in node["streams"].Children())
				{
					this._Streams.Add(ObjectFactory.Create<LiveStreamParams>(arrayNode));
				}
			}
			if(node["recordingInfo"] != null)
			{
				this._RecordingInfo = new List<LiveEntryServerNodeRecordingInfo>();
				foreach(var arrayNode in node["recordingInfo"].Children())
				{
					this._RecordingInfo.Add(ObjectFactory.Create<LiveEntryServerNodeRecordingInfo>(arrayNode));
				}
			}
			if(node["isPlayableUser"] != null)
			{
				this._IsPlayableUser = ParseBool(node["isPlayableUser"].Value<string>());
			}
			if(node["viewMode"] != null)
			{
				this._ViewMode = (ViewMode)ParseEnum(typeof(ViewMode), node["viewMode"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryServerNode");
			kparams.AddIfNotNull("streams", this._Streams);
			kparams.AddIfNotNull("recordingInfo", this._RecordingInfo);
			kparams.AddIfNotNull("isPlayableUser", this._IsPlayableUser);
			kparams.AddIfNotNull("viewMode", this._ViewMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case STREAMS:
					return "Streams";
				case RECORDING_INFO:
					return "RecordingInfo";
				case IS_PLAYABLE_USER:
					return "IsPlayableUser";
				case VIEW_MODE:
					return "ViewMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

