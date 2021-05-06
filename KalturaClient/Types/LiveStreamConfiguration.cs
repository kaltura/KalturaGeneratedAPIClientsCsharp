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
	public class LiveStreamConfiguration : ObjectBase
	{
		#region Constants
		public const string PROTOCOL = "protocol";
		public const string URL = "url";
		public const string PUBLISH_URL = "publishUrl";
		public const string BACKUP_URL = "backupUrl";
		public const string STREAM_NAME = "streamName";
		#endregion

		#region Private Fields
		private PlaybackProtocol _Protocol = null;
		private string _Url = null;
		private string _PublishUrl = null;
		private string _BackupUrl = null;
		private string _StreamName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public PlaybackProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		[JsonProperty]
		public string PublishUrl
		{
			get { return _PublishUrl; }
			set 
			{ 
				_PublishUrl = value;
				OnPropertyChanged("PublishUrl");
			}
		}
		[JsonProperty]
		public string BackupUrl
		{
			get { return _BackupUrl; }
			set 
			{ 
				_BackupUrl = value;
				OnPropertyChanged("BackupUrl");
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
		#endregion

		#region CTor
		public LiveStreamConfiguration()
		{
		}

		public LiveStreamConfiguration(JToken node) : base(node)
		{
			if(node["protocol"] != null)
			{
				this._Protocol = (PlaybackProtocol)StringEnum.Parse(typeof(PlaybackProtocol), node["protocol"].Value<string>());
			}
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["publishUrl"] != null)
			{
				this._PublishUrl = node["publishUrl"].Value<string>();
			}
			if(node["backupUrl"] != null)
			{
				this._BackupUrl = node["backupUrl"].Value<string>();
			}
			if(node["streamName"] != null)
			{
				this._StreamName = node["streamName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamConfiguration");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("publishUrl", this._PublishUrl);
			kparams.AddIfNotNull("backupUrl", this._BackupUrl);
			kparams.AddIfNotNull("streamName", this._StreamName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL:
					return "Protocol";
				case URL:
					return "Url";
				case PUBLISH_URL:
					return "PublishUrl";
				case BACKUP_URL:
					return "BackupUrl";
				case STREAM_NAME:
					return "StreamName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

