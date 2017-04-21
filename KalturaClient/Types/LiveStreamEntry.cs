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
	public class LiveStreamEntry : LiveEntry
	{
		#region Constants
		public const string STREAM_REMOTE_ID = "streamRemoteId";
		public const string STREAM_REMOTE_BACKUP_ID = "streamRemoteBackupId";
		public const string BITRATES = "bitrates";
		public const string PRIMARY_BROADCASTING_URL = "primaryBroadcastingUrl";
		public const string SECONDARY_BROADCASTING_URL = "secondaryBroadcastingUrl";
		public const string PRIMARY_RTSP_BROADCASTING_URL = "primaryRtspBroadcastingUrl";
		public const string SECONDARY_RTSP_BROADCASTING_URL = "secondaryRtspBroadcastingUrl";
		public const string STREAM_NAME = "streamName";
		public const string STREAM_URL = "streamUrl";
		public const string HLS_STREAM_URL = "hlsStreamUrl";
		public const string URL_MANAGER = "urlManager";
		public const string ENCODING_IP1 = "encodingIP1";
		public const string ENCODING_IP2 = "encodingIP2";
		public const string STREAM_PASSWORD = "streamPassword";
		public const string STREAM_USERNAME = "streamUsername";
		public const string PRIMARY_SERVER_NODE_ID = "primaryServerNodeId";
		#endregion

		#region Private Fields
		private string _StreamRemoteId = null;
		private string _StreamRemoteBackupId = null;
		private IList<LiveStreamBitrate> _Bitrates;
		private string _PrimaryBroadcastingUrl = null;
		private string _SecondaryBroadcastingUrl = null;
		private string _PrimaryRtspBroadcastingUrl = null;
		private string _SecondaryRtspBroadcastingUrl = null;
		private string _StreamName = null;
		private string _StreamUrl = null;
		private string _HlsStreamUrl = null;
		private string _UrlManager = null;
		private string _EncodingIP1 = null;
		private string _EncodingIP2 = null;
		private string _StreamPassword = null;
		private string _StreamUsername = null;
		private int _PrimaryServerNodeId = Int32.MinValue;
		#endregion

		#region Properties
		public string StreamRemoteId
		{
			get { return _StreamRemoteId; }
		}
		public string StreamRemoteBackupId
		{
			get { return _StreamRemoteBackupId; }
		}
		public IList<LiveStreamBitrate> Bitrates
		{
			get { return _Bitrates; }
			set 
			{ 
				_Bitrates = value;
				OnPropertyChanged("Bitrates");
			}
		}
		public string PrimaryBroadcastingUrl
		{
			get { return _PrimaryBroadcastingUrl; }
			set 
			{ 
				_PrimaryBroadcastingUrl = value;
				OnPropertyChanged("PrimaryBroadcastingUrl");
			}
		}
		public string SecondaryBroadcastingUrl
		{
			get { return _SecondaryBroadcastingUrl; }
			set 
			{ 
				_SecondaryBroadcastingUrl = value;
				OnPropertyChanged("SecondaryBroadcastingUrl");
			}
		}
		public string PrimaryRtspBroadcastingUrl
		{
			get { return _PrimaryRtspBroadcastingUrl; }
			set 
			{ 
				_PrimaryRtspBroadcastingUrl = value;
				OnPropertyChanged("PrimaryRtspBroadcastingUrl");
			}
		}
		public string SecondaryRtspBroadcastingUrl
		{
			get { return _SecondaryRtspBroadcastingUrl; }
			set 
			{ 
				_SecondaryRtspBroadcastingUrl = value;
				OnPropertyChanged("SecondaryRtspBroadcastingUrl");
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
		public string StreamUrl
		{
			get { return _StreamUrl; }
			set 
			{ 
				_StreamUrl = value;
				OnPropertyChanged("StreamUrl");
			}
		}
		public string HlsStreamUrl
		{
			get { return _HlsStreamUrl; }
			set 
			{ 
				_HlsStreamUrl = value;
				OnPropertyChanged("HlsStreamUrl");
			}
		}
		public string UrlManager
		{
			get { return _UrlManager; }
			set 
			{ 
				_UrlManager = value;
				OnPropertyChanged("UrlManager");
			}
		}
		public string EncodingIP1
		{
			get { return _EncodingIP1; }
			set 
			{ 
				_EncodingIP1 = value;
				OnPropertyChanged("EncodingIP1");
			}
		}
		public string EncodingIP2
		{
			get { return _EncodingIP2; }
			set 
			{ 
				_EncodingIP2 = value;
				OnPropertyChanged("EncodingIP2");
			}
		}
		public string StreamPassword
		{
			get { return _StreamPassword; }
			set 
			{ 
				_StreamPassword = value;
				OnPropertyChanged("StreamPassword");
			}
		}
		public string StreamUsername
		{
			get { return _StreamUsername; }
		}
		public int PrimaryServerNodeId
		{
			get { return _PrimaryServerNodeId; }
		}
		#endregion

		#region CTor
		public LiveStreamEntry()
		{
		}

		public LiveStreamEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "streamRemoteId":
						this._StreamRemoteId = propertyNode.InnerText;
						continue;
					case "streamRemoteBackupId":
						this._StreamRemoteBackupId = propertyNode.InnerText;
						continue;
					case "bitrates":
						this._Bitrates = new List<LiveStreamBitrate>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Bitrates.Add(ObjectFactory.Create<LiveStreamBitrate>(arrayNode));
						}
						continue;
					case "primaryBroadcastingUrl":
						this._PrimaryBroadcastingUrl = propertyNode.InnerText;
						continue;
					case "secondaryBroadcastingUrl":
						this._SecondaryBroadcastingUrl = propertyNode.InnerText;
						continue;
					case "primaryRtspBroadcastingUrl":
						this._PrimaryRtspBroadcastingUrl = propertyNode.InnerText;
						continue;
					case "secondaryRtspBroadcastingUrl":
						this._SecondaryRtspBroadcastingUrl = propertyNode.InnerText;
						continue;
					case "streamName":
						this._StreamName = propertyNode.InnerText;
						continue;
					case "streamUrl":
						this._StreamUrl = propertyNode.InnerText;
						continue;
					case "hlsStreamUrl":
						this._HlsStreamUrl = propertyNode.InnerText;
						continue;
					case "urlManager":
						this._UrlManager = propertyNode.InnerText;
						continue;
					case "encodingIP1":
						this._EncodingIP1 = propertyNode.InnerText;
						continue;
					case "encodingIP2":
						this._EncodingIP2 = propertyNode.InnerText;
						continue;
					case "streamPassword":
						this._StreamPassword = propertyNode.InnerText;
						continue;
					case "streamUsername":
						this._StreamUsername = propertyNode.InnerText;
						continue;
					case "primaryServerNodeId":
						this._PrimaryServerNodeId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaLiveStreamEntry");
			kparams.AddIfNotNull("streamRemoteId", this._StreamRemoteId);
			kparams.AddIfNotNull("streamRemoteBackupId", this._StreamRemoteBackupId);
			kparams.AddIfNotNull("bitrates", this._Bitrates);
			kparams.AddIfNotNull("primaryBroadcastingUrl", this._PrimaryBroadcastingUrl);
			kparams.AddIfNotNull("secondaryBroadcastingUrl", this._SecondaryBroadcastingUrl);
			kparams.AddIfNotNull("primaryRtspBroadcastingUrl", this._PrimaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("secondaryRtspBroadcastingUrl", this._SecondaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("streamName", this._StreamName);
			kparams.AddIfNotNull("streamUrl", this._StreamUrl);
			kparams.AddIfNotNull("hlsStreamUrl", this._HlsStreamUrl);
			kparams.AddIfNotNull("urlManager", this._UrlManager);
			kparams.AddIfNotNull("encodingIP1", this._EncodingIP1);
			kparams.AddIfNotNull("encodingIP2", this._EncodingIP2);
			kparams.AddIfNotNull("streamPassword", this._StreamPassword);
			kparams.AddIfNotNull("streamUsername", this._StreamUsername);
			kparams.AddIfNotNull("primaryServerNodeId", this._PrimaryServerNodeId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case STREAM_REMOTE_ID:
					return "StreamRemoteId";
				case STREAM_REMOTE_BACKUP_ID:
					return "StreamRemoteBackupId";
				case BITRATES:
					return "Bitrates";
				case PRIMARY_BROADCASTING_URL:
					return "PrimaryBroadcastingUrl";
				case SECONDARY_BROADCASTING_URL:
					return "SecondaryBroadcastingUrl";
				case PRIMARY_RTSP_BROADCASTING_URL:
					return "PrimaryRtspBroadcastingUrl";
				case SECONDARY_RTSP_BROADCASTING_URL:
					return "SecondaryRtspBroadcastingUrl";
				case STREAM_NAME:
					return "StreamName";
				case STREAM_URL:
					return "StreamUrl";
				case HLS_STREAM_URL:
					return "HlsStreamUrl";
				case URL_MANAGER:
					return "UrlManager";
				case ENCODING_IP1:
					return "EncodingIP1";
				case ENCODING_IP2:
					return "EncodingIP2";
				case STREAM_PASSWORD:
					return "StreamPassword";
				case STREAM_USERNAME:
					return "StreamUsername";
				case PRIMARY_SERVER_NODE_ID:
					return "PrimaryServerNodeId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

