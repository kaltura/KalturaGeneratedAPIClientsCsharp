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
	public class LiveStreamPushPublishConfiguration : ObjectBase
	{
		#region Constants
		public const string PUBLISH_URL = "publishUrl";
		public const string BACKUP_PUBLISH_URL = "backupPublishUrl";
		public const string PORT = "port";
		#endregion

		#region Private Fields
		private string _PublishUrl = null;
		private string _BackupPublishUrl = null;
		private string _Port = null;
		#endregion

		#region Properties
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
		public string BackupPublishUrl
		{
			get { return _BackupPublishUrl; }
			set 
			{ 
				_BackupPublishUrl = value;
				OnPropertyChanged("BackupPublishUrl");
			}
		}
		[JsonProperty]
		public string Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		#endregion

		#region CTor
		public LiveStreamPushPublishConfiguration()
		{
		}

		public LiveStreamPushPublishConfiguration(JToken node) : base(node)
		{
			if(node["publishUrl"] != null)
			{
				this._PublishUrl = node["publishUrl"].Value<string>();
			}
			if(node["backupPublishUrl"] != null)
			{
				this._BackupPublishUrl = node["backupPublishUrl"].Value<string>();
			}
			if(node["port"] != null)
			{
				this._Port = node["port"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLiveStreamPushPublishConfiguration");
			kparams.AddIfNotNull("publishUrl", this._PublishUrl);
			kparams.AddIfNotNull("backupPublishUrl", this._BackupPublishUrl);
			kparams.AddIfNotNull("port", this._Port);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PUBLISH_URL:
					return "PublishUrl";
				case BACKUP_PUBLISH_URL:
					return "BackupPublishUrl";
				case PORT:
					return "Port";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

