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
	public class LiveEntry : MediaEntry
	{
		#region Constants
		public const string OFFLINE_MESSAGE = "offlineMessage";
		public const string RECORD_STATUS = "recordStatus";
		public const string DVR_STATUS = "dvrStatus";
		public const string DVR_WINDOW = "dvrWindow";
		public const string LAST_ELAPSED_RECORDING_TIME = "lastElapsedRecordingTime";
		public const string LIVE_STREAM_CONFIGURATIONS = "liveStreamConfigurations";
		public const string RECORDED_ENTRY_ID = "recordedEntryId";
		public const string PUSH_PUBLISH_ENABLED = "pushPublishEnabled";
		public const string PUBLISH_CONFIGURATIONS = "publishConfigurations";
		public const string FIRST_BROADCAST = "firstBroadcast";
		public const string LAST_BROADCAST = "lastBroadcast";
		public const string CURRENT_BROADCAST_START_TIME = "currentBroadcastStartTime";
		public const string RECORDING_OPTIONS = "recordingOptions";
		public const string LIVE_STATUS = "liveStatus";
		public const string SEGMENT_DURATION = "segmentDuration";
		public const string EXPLICIT_LIVE = "explicitLive";
		public const string VIEW_MODE = "viewMode";
		public const string RECORDING_STATUS = "recordingStatus";
		public const string LAST_BROADCAST_END_TIME = "lastBroadcastEndTime";
		public const string BROADCAST_TIME = "broadcastTime";
		#endregion

		#region Private Fields
		private string _OfflineMessage = null;
		private RecordStatus _RecordStatus = (RecordStatus)Int32.MinValue;
		private DVRStatus _DvrStatus = (DVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private int _LastElapsedRecordingTime = Int32.MinValue;
		private IList<LiveStreamConfiguration> _LiveStreamConfigurations;
		private string _RecordedEntryId = null;
		private LivePublishStatus _PushPublishEnabled = (LivePublishStatus)Int32.MinValue;
		private IList<LiveStreamPushPublishConfiguration> _PublishConfigurations;
		private int _FirstBroadcast = Int32.MinValue;
		private int _LastBroadcast = Int32.MinValue;
		private int _CurrentBroadcastStartTime = Int32.MinValue;
		private LiveEntryRecordingOptions _RecordingOptions;
		private EntryServerNodeStatus _LiveStatus = (EntryServerNodeStatus)Int32.MinValue;
		private int _SegmentDuration = Int32.MinValue;
		private NullableBoolean _ExplicitLive = (NullableBoolean)Int32.MinValue;
		private ViewMode _ViewMode = (ViewMode)Int32.MinValue;
		private RecordingStatus _RecordingStatus = (RecordingStatus)Int32.MinValue;
		private int _LastBroadcastEndTime = Int32.MinValue;
		private int _BroadcastTime = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use OfflineMessageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OfflineMessage
		{
			get { return _OfflineMessage; }
			set 
			{ 
				_OfflineMessage = value;
				OnPropertyChanged("OfflineMessage");
			}
		}
		/// <summary>
		/// Use RecordStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RecordStatus RecordStatus
		{
			get { return _RecordStatus; }
			set 
			{ 
				_RecordStatus = value;
				OnPropertyChanged("RecordStatus");
			}
		}
		/// <summary>
		/// Use DvrStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DVRStatus DvrStatus
		{
			get { return _DvrStatus; }
			set 
			{ 
				_DvrStatus = value;
				OnPropertyChanged("DvrStatus");
			}
		}
		/// <summary>
		/// Use DvrWindowAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		/// <summary>
		/// Use LastElapsedRecordingTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastElapsedRecordingTime
		{
			get { return _LastElapsedRecordingTime; }
			set 
			{ 
				_LastElapsedRecordingTime = value;
				OnPropertyChanged("LastElapsedRecordingTime");
			}
		}
		/// <summary>
		/// Use LiveStreamConfigurationsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveStreamConfiguration> LiveStreamConfigurations
		{
			get { return _LiveStreamConfigurations; }
			set 
			{ 
				_LiveStreamConfigurations = value;
				OnPropertyChanged("LiveStreamConfigurations");
			}
		}
		/// <summary>
		/// Use RecordedEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RecordedEntryId
		{
			get { return _RecordedEntryId; }
			set 
			{ 
				_RecordedEntryId = value;
				OnPropertyChanged("RecordedEntryId");
			}
		}
		/// <summary>
		/// Use PushPublishEnabledAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LivePublishStatus PushPublishEnabled
		{
			get { return _PushPublishEnabled; }
			set 
			{ 
				_PushPublishEnabled = value;
				OnPropertyChanged("PushPublishEnabled");
			}
		}
		/// <summary>
		/// Use PublishConfigurationsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveStreamPushPublishConfiguration> PublishConfigurations
		{
			get { return _PublishConfigurations; }
			set 
			{ 
				_PublishConfigurations = value;
				OnPropertyChanged("PublishConfigurations");
			}
		}
		/// <summary>
		/// Use FirstBroadcastAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FirstBroadcast
		{
			get { return _FirstBroadcast; }
			private set 
			{ 
				_FirstBroadcast = value;
				OnPropertyChanged("FirstBroadcast");
			}
		}
		/// <summary>
		/// Use LastBroadcastAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastBroadcast
		{
			get { return _LastBroadcast; }
			private set 
			{ 
				_LastBroadcast = value;
				OnPropertyChanged("LastBroadcast");
			}
		}
		/// <summary>
		/// Use CurrentBroadcastStartTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CurrentBroadcastStartTime
		{
			get { return _CurrentBroadcastStartTime; }
			set 
			{ 
				_CurrentBroadcastStartTime = value;
				OnPropertyChanged("CurrentBroadcastStartTime");
			}
		}
		/// <summary>
		/// Use RecordingOptionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LiveEntryRecordingOptions RecordingOptions
		{
			get { return _RecordingOptions; }
			set 
			{ 
				_RecordingOptions = value;
				OnPropertyChanged("RecordingOptions");
			}
		}
		/// <summary>
		/// Use LiveStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public EntryServerNodeStatus LiveStatus
		{
			get { return _LiveStatus; }
			private set 
			{ 
				_LiveStatus = value;
				OnPropertyChanged("LiveStatus");
			}
		}
		/// <summary>
		/// Use SegmentDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SegmentDuration
		{
			get { return _SegmentDuration; }
			set 
			{ 
				_SegmentDuration = value;
				OnPropertyChanged("SegmentDuration");
			}
		}
		/// <summary>
		/// Use ExplicitLiveAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean ExplicitLive
		{
			get { return _ExplicitLive; }
			set 
			{ 
				_ExplicitLive = value;
				OnPropertyChanged("ExplicitLive");
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
		/// <summary>
		/// Use RecordingStatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public RecordingStatus RecordingStatus
		{
			get { return _RecordingStatus; }
			set 
			{ 
				_RecordingStatus = value;
				OnPropertyChanged("RecordingStatus");
			}
		}
		/// <summary>
		/// Use LastBroadcastEndTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastBroadcastEndTime
		{
			get { return _LastBroadcastEndTime; }
			private set 
			{ 
				_LastBroadcastEndTime = value;
				OnPropertyChanged("LastBroadcastEndTime");
			}
		}
		/// <summary>
		/// Use BroadcastTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int BroadcastTime
		{
			get { return _BroadcastTime; }
			set 
			{ 
				_BroadcastTime = value;
				OnPropertyChanged("BroadcastTime");
			}
		}
		#endregion

		#region CTor
		public LiveEntry()
		{
		}

		public LiveEntry(JToken node) : base(node)
		{
			if(node["offlineMessage"] != null)
			{
				this._OfflineMessage = node["offlineMessage"].Value<string>();
			}
			if(node["recordStatus"] != null)
			{
				this._RecordStatus = (RecordStatus)ParseEnum(typeof(RecordStatus), node["recordStatus"].Value<string>());
			}
			if(node["dvrStatus"] != null)
			{
				this._DvrStatus = (DVRStatus)ParseEnum(typeof(DVRStatus), node["dvrStatus"].Value<string>());
			}
			if(node["dvrWindow"] != null)
			{
				this._DvrWindow = ParseInt(node["dvrWindow"].Value<string>());
			}
			if(node["lastElapsedRecordingTime"] != null)
			{
				this._LastElapsedRecordingTime = ParseInt(node["lastElapsedRecordingTime"].Value<string>());
			}
			if(node["liveStreamConfigurations"] != null)
			{
				this._LiveStreamConfigurations = new List<LiveStreamConfiguration>();
				foreach(var arrayNode in node["liveStreamConfigurations"].Children())
				{
					this._LiveStreamConfigurations.Add(ObjectFactory.Create<LiveStreamConfiguration>(arrayNode));
				}
			}
			if(node["recordedEntryId"] != null)
			{
				this._RecordedEntryId = node["recordedEntryId"].Value<string>();
			}
			if(node["pushPublishEnabled"] != null)
			{
				this._PushPublishEnabled = (LivePublishStatus)ParseEnum(typeof(LivePublishStatus), node["pushPublishEnabled"].Value<string>());
			}
			if(node["publishConfigurations"] != null)
			{
				this._PublishConfigurations = new List<LiveStreamPushPublishConfiguration>();
				foreach(var arrayNode in node["publishConfigurations"].Children())
				{
					this._PublishConfigurations.Add(ObjectFactory.Create<LiveStreamPushPublishConfiguration>(arrayNode));
				}
			}
			if(node["firstBroadcast"] != null)
			{
				this._FirstBroadcast = ParseInt(node["firstBroadcast"].Value<string>());
			}
			if(node["lastBroadcast"] != null)
			{
				this._LastBroadcast = ParseInt(node["lastBroadcast"].Value<string>());
			}
			if(node["currentBroadcastStartTime"] != null)
			{
				this._CurrentBroadcastStartTime = ParseInt(node["currentBroadcastStartTime"].Value<string>());
			}
			if(node["recordingOptions"] != null)
			{
				this._RecordingOptions = ObjectFactory.Create<LiveEntryRecordingOptions>(node["recordingOptions"]);
			}
			if(node["liveStatus"] != null)
			{
				this._LiveStatus = (EntryServerNodeStatus)ParseEnum(typeof(EntryServerNodeStatus), node["liveStatus"].Value<string>());
			}
			if(node["segmentDuration"] != null)
			{
				this._SegmentDuration = ParseInt(node["segmentDuration"].Value<string>());
			}
			if(node["explicitLive"] != null)
			{
				this._ExplicitLive = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["explicitLive"].Value<string>());
			}
			if(node["viewMode"] != null)
			{
				this._ViewMode = (ViewMode)ParseEnum(typeof(ViewMode), node["viewMode"].Value<string>());
			}
			if(node["recordingStatus"] != null)
			{
				this._RecordingStatus = (RecordingStatus)ParseEnum(typeof(RecordingStatus), node["recordingStatus"].Value<string>());
			}
			if(node["lastBroadcastEndTime"] != null)
			{
				this._LastBroadcastEndTime = ParseInt(node["lastBroadcastEndTime"].Value<string>());
			}
			if(node["broadcastTime"] != null)
			{
				this._BroadcastTime = ParseInt(node["broadcastTime"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntry");
			kparams.AddIfNotNull("offlineMessage", this._OfflineMessage);
			kparams.AddIfNotNull("recordStatus", this._RecordStatus);
			kparams.AddIfNotNull("dvrStatus", this._DvrStatus);
			kparams.AddIfNotNull("dvrWindow", this._DvrWindow);
			kparams.AddIfNotNull("lastElapsedRecordingTime", this._LastElapsedRecordingTime);
			kparams.AddIfNotNull("liveStreamConfigurations", this._LiveStreamConfigurations);
			kparams.AddIfNotNull("recordedEntryId", this._RecordedEntryId);
			kparams.AddIfNotNull("pushPublishEnabled", this._PushPublishEnabled);
			kparams.AddIfNotNull("publishConfigurations", this._PublishConfigurations);
			kparams.AddIfNotNull("firstBroadcast", this._FirstBroadcast);
			kparams.AddIfNotNull("lastBroadcast", this._LastBroadcast);
			kparams.AddIfNotNull("currentBroadcastStartTime", this._CurrentBroadcastStartTime);
			kparams.AddIfNotNull("recordingOptions", this._RecordingOptions);
			kparams.AddIfNotNull("liveStatus", this._LiveStatus);
			kparams.AddIfNotNull("segmentDuration", this._SegmentDuration);
			kparams.AddIfNotNull("explicitLive", this._ExplicitLive);
			kparams.AddIfNotNull("viewMode", this._ViewMode);
			kparams.AddIfNotNull("recordingStatus", this._RecordingStatus);
			kparams.AddIfNotNull("lastBroadcastEndTime", this._LastBroadcastEndTime);
			kparams.AddIfNotNull("broadcastTime", this._BroadcastTime);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OFFLINE_MESSAGE:
					return "OfflineMessage";
				case RECORD_STATUS:
					return "RecordStatus";
				case DVR_STATUS:
					return "DvrStatus";
				case DVR_WINDOW:
					return "DvrWindow";
				case LAST_ELAPSED_RECORDING_TIME:
					return "LastElapsedRecordingTime";
				case LIVE_STREAM_CONFIGURATIONS:
					return "LiveStreamConfigurations";
				case RECORDED_ENTRY_ID:
					return "RecordedEntryId";
				case PUSH_PUBLISH_ENABLED:
					return "PushPublishEnabled";
				case PUBLISH_CONFIGURATIONS:
					return "PublishConfigurations";
				case FIRST_BROADCAST:
					return "FirstBroadcast";
				case LAST_BROADCAST:
					return "LastBroadcast";
				case CURRENT_BROADCAST_START_TIME:
					return "CurrentBroadcastStartTime";
				case RECORDING_OPTIONS:
					return "RecordingOptions";
				case LIVE_STATUS:
					return "LiveStatus";
				case SEGMENT_DURATION:
					return "SegmentDuration";
				case EXPLICIT_LIVE:
					return "ExplicitLive";
				case VIEW_MODE:
					return "ViewMode";
				case RECORDING_STATUS:
					return "RecordingStatus";
				case LAST_BROADCAST_END_TIME:
					return "LastBroadcastEndTime";
				case BROADCAST_TIME:
					return "BroadcastTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

