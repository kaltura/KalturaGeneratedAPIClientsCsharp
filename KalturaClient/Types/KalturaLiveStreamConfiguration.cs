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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaLiveStreamConfiguration : KalturaObjectBase
	{
		#region Private Fields
		private KalturaPlaybackProtocol _Protocol = null;
		private string _Url = null;
		private string _PublishUrl = null;
		private string _BackupUrl = null;
		private string _StreamName = null;
		#endregion

		#region Properties
		public KalturaPlaybackProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public string PublishUrl
		{
			get { return _PublishUrl; }
			set 
			{ 
				_PublishUrl = value;
				OnPropertyChanged("PublishUrl");
			}
		}
		public string BackupUrl
		{
			get { return _BackupUrl; }
			set 
			{ 
				_BackupUrl = value;
				OnPropertyChanged("BackupUrl");
			}
		}
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
		public KalturaLiveStreamConfiguration()
		{
		}

		public KalturaLiveStreamConfiguration(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "protocol":
						this._Protocol = (KalturaPlaybackProtocol)KalturaStringEnum.Parse(typeof(KalturaPlaybackProtocol), txt);
						continue;
					case "url":
						this._Url = txt;
						continue;
					case "publishUrl":
						this._PublishUrl = txt;
						continue;
					case "backupUrl":
						this._BackupUrl = txt;
						continue;
					case "streamName":
						this._StreamName = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStreamConfiguration");
			kparams.AddIfNotNull("protocol", this.Protocol);
			kparams.AddIfNotNull("url", this.Url);
			kparams.AddIfNotNull("publishUrl", this.PublishUrl);
			kparams.AddIfNotNull("backupUrl", this.BackupUrl);
			kparams.AddIfNotNull("streamName", this.StreamName);
			return kparams;
		}
		#endregion
	}
}

