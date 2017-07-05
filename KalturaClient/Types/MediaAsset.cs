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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class MediaAsset : Asset
	{
		#region Constants
		public const string SYSTEM_START_DATE = "systemStartDate";
		public const string SYSTEM_FINAL_DATE = "systemFinalDate";
		public const string EXTERNAL_IDS = "externalIds";
		public const string CATCH_UP_BUFFER = "catchUpBuffer";
		public const string TRICK_PLAY_BUFFER = "trickPlayBuffer";
		public const string ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL = "enableRecordingPlaybackNonEntitledChannel";
		public const string ENABLE_RECORDING_PLAYBACK_NON_EXISTING_CHANNEL = "enableRecordingPlaybackNonExistingChannel";
		#endregion

		#region Private Fields
		private long _SystemStartDate = long.MinValue;
		private long _SystemFinalDate = long.MinValue;
		private string _ExternalIds = null;
		private long _CatchUpBuffer = long.MinValue;
		private long _TrickPlayBuffer = long.MinValue;
		private bool? _EnableRecordingPlaybackNonEntitledChannel = null;
		private bool? _EnableRecordingPlaybackNonExistingChannel = null;
		#endregion

		#region Properties
		public long SystemStartDate
		{
			get { return _SystemStartDate; }
			set 
			{ 
				_SystemStartDate = value;
				OnPropertyChanged("SystemStartDate");
			}
		}
		public long SystemFinalDate
		{
			get { return _SystemFinalDate; }
			set 
			{ 
				_SystemFinalDate = value;
				OnPropertyChanged("SystemFinalDate");
			}
		}
		public string ExternalIds
		{
			get { return _ExternalIds; }
			set 
			{ 
				_ExternalIds = value;
				OnPropertyChanged("ExternalIds");
			}
		}
		public long CatchUpBuffer
		{
			get { return _CatchUpBuffer; }
			set 
			{ 
				_CatchUpBuffer = value;
				OnPropertyChanged("CatchUpBuffer");
			}
		}
		public long TrickPlayBuffer
		{
			get { return _TrickPlayBuffer; }
			set 
			{ 
				_TrickPlayBuffer = value;
				OnPropertyChanged("TrickPlayBuffer");
			}
		}
		public bool? EnableRecordingPlaybackNonEntitledChannel
		{
			get { return _EnableRecordingPlaybackNonEntitledChannel; }
		}
		public bool? EnableRecordingPlaybackNonExistingChannel
		{
			get { return _EnableRecordingPlaybackNonExistingChannel; }
		}
		#endregion

		#region CTor
		public MediaAsset()
		{
		}

		public MediaAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "systemStartDate":
						this._SystemStartDate = ParseLong(propertyNode.InnerText);
						continue;
					case "systemFinalDate":
						this._SystemFinalDate = ParseLong(propertyNode.InnerText);
						continue;
					case "externalIds":
						this._ExternalIds = propertyNode.InnerText;
						continue;
					case "catchUpBuffer":
						this._CatchUpBuffer = ParseLong(propertyNode.InnerText);
						continue;
					case "trickPlayBuffer":
						this._TrickPlayBuffer = ParseLong(propertyNode.InnerText);
						continue;
					case "enableRecordingPlaybackNonEntitledChannel":
						this._EnableRecordingPlaybackNonEntitledChannel = ParseBool(propertyNode.InnerText);
						continue;
					case "enableRecordingPlaybackNonExistingChannel":
						this._EnableRecordingPlaybackNonExistingChannel = ParseBool(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaMediaAsset");
			kparams.AddIfNotNull("systemStartDate", this._SystemStartDate);
			kparams.AddIfNotNull("systemFinalDate", this._SystemFinalDate);
			kparams.AddIfNotNull("externalIds", this._ExternalIds);
			kparams.AddIfNotNull("catchUpBuffer", this._CatchUpBuffer);
			kparams.AddIfNotNull("trickPlayBuffer", this._TrickPlayBuffer);
			kparams.AddIfNotNull("enableRecordingPlaybackNonEntitledChannel", this._EnableRecordingPlaybackNonEntitledChannel);
			kparams.AddIfNotNull("enableRecordingPlaybackNonExistingChannel", this._EnableRecordingPlaybackNonExistingChannel);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SYSTEM_START_DATE:
					return "SystemStartDate";
				case SYSTEM_FINAL_DATE:
					return "SystemFinalDate";
				case EXTERNAL_IDS:
					return "ExternalIds";
				case CATCH_UP_BUFFER:
					return "CatchUpBuffer";
				case TRICK_PLAY_BUFFER:
					return "TrickPlayBuffer";
				case ENABLE_RECORDING_PLAYBACK_NON_ENTITLED_CHANNEL:
					return "EnableRecordingPlaybackNonEntitledChannel";
				case ENABLE_RECORDING_PLAYBACK_NON_EXISTING_CHANNEL:
					return "EnableRecordingPlaybackNonExistingChannel";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

