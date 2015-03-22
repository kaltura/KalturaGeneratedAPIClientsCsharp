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
	public class KalturaLiveEntry : KalturaMediaEntry
	{
		#region Private Fields
		private string _OfflineMessage = null;
		private KalturaRecordStatus _RecordStatus = (KalturaRecordStatus)Int32.MinValue;
		private KalturaDVRStatus _DvrStatus = (KalturaDVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private int _LastElapsedRecordingTime = Int32.MinValue;
		private IList<KalturaLiveStreamConfiguration> _LiveStreamConfigurations;
		private string _RecordedEntryId = null;
		private KalturaLivePublishStatus _PushPublishEnabled = (KalturaLivePublishStatus)Int32.MinValue;
		private IList<KalturaLiveStreamPushPublishConfiguration> _PublishConfigurations;
		private int _FirstBroadcast = Int32.MinValue;
		private int _LastBroadcast = Int32.MinValue;
		private float _CurrentBroadcastStartTime = Single.MinValue;
		#endregion

		#region Properties
		public string OfflineMessage
		{
			get { return _OfflineMessage; }
			set 
			{ 
				_OfflineMessage = value;
				OnPropertyChanged("OfflineMessage");
			}
		}
		public KalturaRecordStatus RecordStatus
		{
			get { return _RecordStatus; }
			set 
			{ 
				_RecordStatus = value;
				OnPropertyChanged("RecordStatus");
			}
		}
		public KalturaDVRStatus DvrStatus
		{
			get { return _DvrStatus; }
			set 
			{ 
				_DvrStatus = value;
				OnPropertyChanged("DvrStatus");
			}
		}
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		public int LastElapsedRecordingTime
		{
			get { return _LastElapsedRecordingTime; }
			set 
			{ 
				_LastElapsedRecordingTime = value;
				OnPropertyChanged("LastElapsedRecordingTime");
			}
		}
		public IList<KalturaLiveStreamConfiguration> LiveStreamConfigurations
		{
			get { return _LiveStreamConfigurations; }
			set 
			{ 
				_LiveStreamConfigurations = value;
				OnPropertyChanged("LiveStreamConfigurations");
			}
		}
		public string RecordedEntryId
		{
			get { return _RecordedEntryId; }
			set 
			{ 
				_RecordedEntryId = value;
				OnPropertyChanged("RecordedEntryId");
			}
		}
		public KalturaLivePublishStatus PushPublishEnabled
		{
			get { return _PushPublishEnabled; }
			set 
			{ 
				_PushPublishEnabled = value;
				OnPropertyChanged("PushPublishEnabled");
			}
		}
		public IList<KalturaLiveStreamPushPublishConfiguration> PublishConfigurations
		{
			get { return _PublishConfigurations; }
			set 
			{ 
				_PublishConfigurations = value;
				OnPropertyChanged("PublishConfigurations");
			}
		}
		public int FirstBroadcast
		{
			get { return _FirstBroadcast; }
			set 
			{ 
				_FirstBroadcast = value;
				OnPropertyChanged("FirstBroadcast");
			}
		}
		public int LastBroadcast
		{
			get { return _LastBroadcast; }
			set 
			{ 
				_LastBroadcast = value;
				OnPropertyChanged("LastBroadcast");
			}
		}
		public float CurrentBroadcastStartTime
		{
			get { return _CurrentBroadcastStartTime; }
			set 
			{ 
				_CurrentBroadcastStartTime = value;
				OnPropertyChanged("CurrentBroadcastStartTime");
			}
		}
		#endregion

		#region CTor
		public KalturaLiveEntry()
		{
		}

		public KalturaLiveEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "offlineMessage":
						this.OfflineMessage = txt;
						continue;
					case "recordStatus":
						this.RecordStatus = (KalturaRecordStatus)ParseEnum(typeof(KalturaRecordStatus), txt);
						continue;
					case "dvrStatus":
						this.DvrStatus = (KalturaDVRStatus)ParseEnum(typeof(KalturaDVRStatus), txt);
						continue;
					case "dvrWindow":
						this.DvrWindow = ParseInt(txt);
						continue;
					case "lastElapsedRecordingTime":
						this.LastElapsedRecordingTime = ParseInt(txt);
						continue;
					case "liveStreamConfigurations":
						this.LiveStreamConfigurations = new List<KalturaLiveStreamConfiguration>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.LiveStreamConfigurations.Add((KalturaLiveStreamConfiguration)KalturaObjectFactory.Create(arrayNode, "KalturaLiveStreamConfiguration"));
						}
						continue;
					case "recordedEntryId":
						this.RecordedEntryId = txt;
						continue;
					case "pushPublishEnabled":
						this.PushPublishEnabled = (KalturaLivePublishStatus)ParseEnum(typeof(KalturaLivePublishStatus), txt);
						continue;
					case "publishConfigurations":
						this.PublishConfigurations = new List<KalturaLiveStreamPushPublishConfiguration>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.PublishConfigurations.Add((KalturaLiveStreamPushPublishConfiguration)KalturaObjectFactory.Create(arrayNode, "KalturaLiveStreamPushPublishConfiguration"));
						}
						continue;
					case "firstBroadcast":
						this.FirstBroadcast = ParseInt(txt);
						continue;
					case "lastBroadcast":
						this.LastBroadcast = ParseInt(txt);
						continue;
					case "currentBroadcastStartTime":
						this.CurrentBroadcastStartTime = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveEntry");
			kparams.AddStringIfNotNull("offlineMessage", this.OfflineMessage);
			kparams.AddEnumIfNotNull("recordStatus", this.RecordStatus);
			kparams.AddEnumIfNotNull("dvrStatus", this.DvrStatus);
			kparams.AddIntIfNotNull("dvrWindow", this.DvrWindow);
			kparams.AddIntIfNotNull("lastElapsedRecordingTime", this.LastElapsedRecordingTime);
			if (this.LiveStreamConfigurations != null)
			{
				if (this.LiveStreamConfigurations.Count == 0)
				{
					kparams.Add("liveStreamConfigurations:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaLiveStreamConfiguration item in this.LiveStreamConfigurations)
					{
						kparams.Add("liveStreamConfigurations:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddStringIfNotNull("recordedEntryId", this.RecordedEntryId);
			kparams.AddEnumIfNotNull("pushPublishEnabled", this.PushPublishEnabled);
			if (this.PublishConfigurations != null)
			{
				if (this.PublishConfigurations.Count == 0)
				{
					kparams.Add("publishConfigurations:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaLiveStreamPushPublishConfiguration item in this.PublishConfigurations)
					{
						kparams.Add("publishConfigurations:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("firstBroadcast", this.FirstBroadcast);
			kparams.AddIntIfNotNull("lastBroadcast", this.LastBroadcast);
			kparams.AddFloatIfNotNull("currentBroadcastStartTime", this.CurrentBroadcastStartTime);
			return kparams;
		}
		#endregion
	}
}

