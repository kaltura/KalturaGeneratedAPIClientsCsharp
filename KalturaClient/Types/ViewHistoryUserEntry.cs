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
	public class ViewHistoryUserEntry : UserEntry
	{
		#region Constants
		public const string PLAYBACK_CONTEXT = "playbackContext";
		public const string LAST_TIME_REACHED = "lastTimeReached";
		public const string LAST_UPDATE_TIME = "lastUpdateTime";
		#endregion

		#region Private Fields
		private string _PlaybackContext = null;
		private int _LastTimeReached = Int32.MinValue;
		private int _LastUpdateTime = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string PlaybackContext
		{
			get { return _PlaybackContext; }
			set 
			{ 
				_PlaybackContext = value;
				OnPropertyChanged("PlaybackContext");
			}
		}
		[JsonProperty]
		public int LastTimeReached
		{
			get { return _LastTimeReached; }
			set 
			{ 
				_LastTimeReached = value;
				OnPropertyChanged("LastTimeReached");
			}
		}
		[JsonProperty]
		public int LastUpdateTime
		{
			get { return _LastUpdateTime; }
			set 
			{ 
				_LastUpdateTime = value;
				OnPropertyChanged("LastUpdateTime");
			}
		}
		#endregion

		#region CTor
		public ViewHistoryUserEntry()
		{
		}

		public ViewHistoryUserEntry(JToken node) : base(node)
		{
			if(node["playbackContext"] != null)
			{
				this._PlaybackContext = node["playbackContext"].Value<string>();
			}
			if(node["lastTimeReached"] != null)
			{
				this._LastTimeReached = ParseInt(node["lastTimeReached"].Value<string>());
			}
			if(node["lastUpdateTime"] != null)
			{
				this._LastUpdateTime = ParseInt(node["lastUpdateTime"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaViewHistoryUserEntry");
			kparams.AddIfNotNull("playbackContext", this._PlaybackContext);
			kparams.AddIfNotNull("lastTimeReached", this._LastTimeReached);
			kparams.AddIfNotNull("lastUpdateTime", this._LastUpdateTime);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PLAYBACK_CONTEXT:
					return "PlaybackContext";
				case LAST_TIME_REACHED:
					return "LastTimeReached";
				case LAST_UPDATE_TIME:
					return "LastUpdateTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

