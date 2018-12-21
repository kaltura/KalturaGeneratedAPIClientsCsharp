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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class LiveStreamPushPublishRTMPConfiguration : LiveStreamPushPublishConfiguration
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string PASSWORD = "password";
		public const string STREAM_NAME = "streamName";
		public const string APPLICATION_NAME = "applicationName";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private string _Password = null;
		private string _StreamName = null;
		private string _ApplicationName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		[JsonProperty]
		public string StreamName
		{
			get { return _StreamName; }
			set 
			{ 
				_StreamName = value;
				OnPropertyChanged("StreamName");
			}
		}
		[JsonProperty]
		public string ApplicationName
		{
			get { return _ApplicationName; }
			set 
			{ 
				_ApplicationName = value;
				OnPropertyChanged("ApplicationName");
			}
		}
		#endregion

		#region CTor
		public LiveStreamPushPublishRTMPConfiguration()
		{
		}

		public LiveStreamPushPublishRTMPConfiguration(JToken node) : base(node)
		{
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["streamName"] != null)
			{
				this._StreamName = node["streamName"].Value<string>();
			}
			if(node["applicationName"] != null)
			{
				this._ApplicationName = node["applicationName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamPushPublishRTMPConfiguration");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("streamName", this._StreamName);
			kparams.AddIfNotNull("applicationName", this._ApplicationName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case PASSWORD:
					return "Password";
				case STREAM_NAME:
					return "StreamName";
				case APPLICATION_NAME:
					return "ApplicationName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

