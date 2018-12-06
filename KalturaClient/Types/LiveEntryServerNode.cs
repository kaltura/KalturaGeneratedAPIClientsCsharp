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
	public class LiveEntryServerNode : EntryServerNode
	{
		#region Constants
		public const string STREAMS = "streams";
		public const string RECORDING_INFO = "recordingInfo";
		public const string IS_PLAYABLE_USER = "isPlayableUser";
		#endregion

		#region Private Fields
		private IList<LiveStreamParams> _Streams;
		private IList<LiveEntryServerNodeRecordingInfo> _RecordingInfo;
		private bool? _IsPlayableUser = null;
		#endregion

		#region Properties
		public IList<LiveStreamParams> Streams
		{
			get { return _Streams; }
			set 
			{ 
				_Streams = value;
				OnPropertyChanged("Streams");
			}
		}
		public IList<LiveEntryServerNodeRecordingInfo> RecordingInfo
		{
			get { return _RecordingInfo; }
			set 
			{ 
				_RecordingInfo = value;
				OnPropertyChanged("RecordingInfo");
			}
		}
		public bool? IsPlayableUser
		{
			get { return _IsPlayableUser; }
			set 
			{ 
				_IsPlayableUser = value;
				OnPropertyChanged("IsPlayableUser");
			}
		}
		#endregion

		#region CTor
		public LiveEntryServerNode()
		{
		}

		public LiveEntryServerNode(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "streams":
						this._Streams = new List<LiveStreamParams>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Streams.Add(ObjectFactory.Create<LiveStreamParams>(arrayNode));
						}
						continue;
					case "recordingInfo":
						this._RecordingInfo = new List<LiveEntryServerNodeRecordingInfo>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RecordingInfo.Add(ObjectFactory.Create<LiveEntryServerNodeRecordingInfo>(arrayNode));
						}
						continue;
					case "isPlayableUser":
						this._IsPlayableUser = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public LiveEntryServerNode(IDictionary<string,object> data) : base(data)
		{
			    this._Streams = new List<LiveStreamParams>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("streams", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._Streams.Add(ObjectFactory.Create<LiveStreamParams>((IDictionary<string,object>)dataDictionary));
			    }
			    this._RecordingInfo = new List<LiveEntryServerNodeRecordingInfo>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("recordingInfo", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._RecordingInfo.Add(ObjectFactory.Create<LiveEntryServerNodeRecordingInfo>((IDictionary<string,object>)dataDictionary));
			    }
			    this._IsPlayableUser = data.TryGetValueSafe<bool>("isPlayableUser");
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

