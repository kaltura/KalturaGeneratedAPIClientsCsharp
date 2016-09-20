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
	public class KalturaLiveStreamEntry : KalturaLiveEntry
	{
		#region Private Fields
		private string _StreamRemoteId = null;
		private string _StreamRemoteBackupId = null;
		private IList<KalturaLiveStreamBitrate> _Bitrates;
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
		public new IList<KalturaLiveStreamBitrate> Bitrates
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
		public KalturaLiveStreamEntry()
		{
		}

		public KalturaLiveStreamEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "streamRemoteId":
						this._StreamRemoteId = txt;
						continue;
					case "streamRemoteBackupId":
						this._StreamRemoteBackupId = txt;
						continue;
					case "bitrates":
						this._Bitrates = new List<KalturaLiveStreamBitrate>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Bitrates.Add((KalturaLiveStreamBitrate)KalturaObjectFactory.Create(arrayNode, "KalturaLiveStreamBitrate"));
						}
						continue;
					case "primaryBroadcastingUrl":
						this._PrimaryBroadcastingUrl = txt;
						continue;
					case "secondaryBroadcastingUrl":
						this._SecondaryBroadcastingUrl = txt;
						continue;
					case "primaryRtspBroadcastingUrl":
						this._PrimaryRtspBroadcastingUrl = txt;
						continue;
					case "secondaryRtspBroadcastingUrl":
						this._SecondaryRtspBroadcastingUrl = txt;
						continue;
					case "streamName":
						this._StreamName = txt;
						continue;
					case "streamUrl":
						this._StreamUrl = txt;
						continue;
					case "hlsStreamUrl":
						this._HlsStreamUrl = txt;
						continue;
					case "urlManager":
						this._UrlManager = txt;
						continue;
					case "encodingIP1":
						this._EncodingIP1 = txt;
						continue;
					case "encodingIP2":
						this._EncodingIP2 = txt;
						continue;
					case "streamPassword":
						this._StreamPassword = txt;
						continue;
					case "streamUsername":
						this._StreamUsername = txt;
						continue;
					case "primaryServerNodeId":
						this._PrimaryServerNodeId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveStreamEntry");
			kparams.AddIfNotNull("streamRemoteId", this.StreamRemoteId);
			kparams.AddIfNotNull("streamRemoteBackupId", this.StreamRemoteBackupId);
			kparams.AddIfNotNull("bitrates", this.Bitrates);
			kparams.AddIfNotNull("primaryBroadcastingUrl", this.PrimaryBroadcastingUrl);
			kparams.AddIfNotNull("secondaryBroadcastingUrl", this.SecondaryBroadcastingUrl);
			kparams.AddIfNotNull("primaryRtspBroadcastingUrl", this.PrimaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("secondaryRtspBroadcastingUrl", this.SecondaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("streamName", this.StreamName);
			kparams.AddIfNotNull("streamUrl", this.StreamUrl);
			kparams.AddIfNotNull("hlsStreamUrl", this.HlsStreamUrl);
			kparams.AddIfNotNull("urlManager", this.UrlManager);
			kparams.AddIfNotNull("encodingIP1", this.EncodingIP1);
			kparams.AddIfNotNull("encodingIP2", this.EncodingIP2);
			kparams.AddIfNotNull("streamPassword", this.StreamPassword);
			kparams.AddIfNotNull("streamUsername", this.StreamUsername);
			kparams.AddIfNotNull("primaryServerNodeId", this.PrimaryServerNodeId);
			return kparams;
		}
		#endregion
	}
}

