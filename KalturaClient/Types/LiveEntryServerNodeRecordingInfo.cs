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
	public class LiveEntryServerNodeRecordingInfo : ObjectBase
	{
		#region Constants
		public const string RECORDED_ENTRY_ID = "recordedEntryId";
		public const string DURATION = "duration";
		public const string RECORDING_STATUS = "recordingStatus";
		#endregion

		#region Private Fields
		private string _RecordedEntryId = null;
		private int _Duration = Int32.MinValue;
		private EntryServerNodeRecordingStatus _RecordingStatus = (EntryServerNodeRecordingStatus)Int32.MinValue;
		#endregion

		#region Properties
		public string RecordedEntryId
		{
			get { return _RecordedEntryId; }
			set 
			{ 
				_RecordedEntryId = value;
				OnPropertyChanged("RecordedEntryId");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public EntryServerNodeRecordingStatus RecordingStatus
		{
			get { return _RecordingStatus; }
			set 
			{ 
				_RecordingStatus = value;
				OnPropertyChanged("RecordingStatus");
			}
		}
		#endregion

		#region CTor
		public LiveEntryServerNodeRecordingInfo()
		{
		}

		public LiveEntryServerNodeRecordingInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "recordedEntryId":
						this._RecordedEntryId = propertyNode.InnerText;
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
						continue;
					case "recordingStatus":
						this._RecordingStatus = (EntryServerNodeRecordingStatus)ParseEnum(typeof(EntryServerNodeRecordingStatus), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveEntryServerNodeRecordingInfo");
			kparams.AddIfNotNull("recordedEntryId", this._RecordedEntryId);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("recordingStatus", this._RecordingStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RECORDED_ENTRY_ID:
					return "RecordedEntryId";
				case DURATION:
					return "Duration";
				case RECORDING_STATUS:
					return "RecordingStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

