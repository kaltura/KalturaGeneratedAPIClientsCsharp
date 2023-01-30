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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class LiveStreamEntry : LiveEntry
	{
		#region Constants
		public const string STREAM_REMOTE_ID = "streamRemoteId";
		public const string STREAM_REMOTE_BACKUP_ID = "streamRemoteBackupId";
		public const string BITRATES = "bitrates";
		public const string PRIMARY_BROADCASTING_URL = "primaryBroadcastingUrl";
		public const string SECONDARY_BROADCASTING_URL = "secondaryBroadcastingUrl";
		public const string PRIMARY_SECURED_BROADCASTING_URL = "primarySecuredBroadcastingUrl";
		public const string SECONDARY_SECURED_BROADCASTING_URL = "secondarySecuredBroadcastingUrl";
		public const string PRIMARY_RTSP_BROADCASTING_URL = "primaryRtspBroadcastingUrl";
		public const string SECONDARY_RTSP_BROADCASTING_URL = "secondaryRtspBroadcastingUrl";
		public const string PRIMARY_SRT_BROADCASTING_URL = "primarySrtBroadcastingUrl";
		public const string PRIMARY_SRT_STREAM_ID = "primarySrtStreamId";
		public const string SECONDARY_SRT_BROADCASTING_URL = "secondarySrtBroadcastingUrl";
		public const string SECONDARY_SRT_STREAM_ID = "secondarySrtStreamId";
		public const string STREAM_NAME = "streamName";
		public const string STREAM_URL = "streamUrl";
		public const string HLS_STREAM_URL = "hlsStreamUrl";
		public const string URL_MANAGER = "urlManager";
		public const string ENCODING_IP1 = "encodingIP1";
		public const string ENCODING_IP2 = "encodingIP2";
		public const string STREAM_PASSWORD = "streamPassword";
		public const string STREAM_USERNAME = "streamUsername";
		public const string SRT_PASS = "srtPass";
		public const string PRIMARY_SERVER_NODE_ID = "primaryServerNodeId";
		public const string SIP_TOKEN = "sipToken";
		public const string SIP_SOURCE_TYPE = "sipSourceType";
		#endregion

		#region Private Fields
		private string _StreamRemoteId = null;
		private string _StreamRemoteBackupId = null;
		private IList<LiveStreamBitrate> _Bitrates;
		private string _PrimaryBroadcastingUrl = null;
		private string _SecondaryBroadcastingUrl = null;
		private string _PrimarySecuredBroadcastingUrl = null;
		private string _SecondarySecuredBroadcastingUrl = null;
		private string _PrimaryRtspBroadcastingUrl = null;
		private string _SecondaryRtspBroadcastingUrl = null;
		private string _PrimarySrtBroadcastingUrl = null;
		private string _PrimarySrtStreamId = null;
		private string _SecondarySrtBroadcastingUrl = null;
		private string _SecondarySrtStreamId = null;
		private string _StreamName = null;
		private string _StreamUrl = null;
		private string _HlsStreamUrl = null;
		private string _UrlManager = null;
		private string _EncodingIP1 = null;
		private string _EncodingIP2 = null;
		private string _StreamPassword = null;
		private string _StreamUsername = null;
		private string _SrtPass = null;
		private int _PrimaryServerNodeId = Int32.MinValue;
		private string _SipToken = null;
		private SipSourceType _SipSourceType = (SipSourceType)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use StreamRemoteIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamRemoteId
		{
			get { return _StreamRemoteId; }
			private set 
			{ 
				_StreamRemoteId = value;
				OnPropertyChanged("StreamRemoteId");
			}
		}
		/// <summary>
		/// Use StreamRemoteBackupIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamRemoteBackupId
		{
			get { return _StreamRemoteBackupId; }
			private set 
			{ 
				_StreamRemoteBackupId = value;
				OnPropertyChanged("StreamRemoteBackupId");
			}
		}
		/// <summary>
		/// Use BitratesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<LiveStreamBitrate> Bitrates
		{
			get { return _Bitrates; }
			set 
			{ 
				_Bitrates = value;
				OnPropertyChanged("Bitrates");
			}
		}
		/// <summary>
		/// Use PrimaryBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimaryBroadcastingUrl
		{
			get { return _PrimaryBroadcastingUrl; }
			set 
			{ 
				_PrimaryBroadcastingUrl = value;
				OnPropertyChanged("PrimaryBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use SecondaryBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondaryBroadcastingUrl
		{
			get { return _SecondaryBroadcastingUrl; }
			set 
			{ 
				_SecondaryBroadcastingUrl = value;
				OnPropertyChanged("SecondaryBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use PrimarySecuredBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimarySecuredBroadcastingUrl
		{
			get { return _PrimarySecuredBroadcastingUrl; }
			set 
			{ 
				_PrimarySecuredBroadcastingUrl = value;
				OnPropertyChanged("PrimarySecuredBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use SecondarySecuredBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondarySecuredBroadcastingUrl
		{
			get { return _SecondarySecuredBroadcastingUrl; }
			set 
			{ 
				_SecondarySecuredBroadcastingUrl = value;
				OnPropertyChanged("SecondarySecuredBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use PrimaryRtspBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimaryRtspBroadcastingUrl
		{
			get { return _PrimaryRtspBroadcastingUrl; }
			set 
			{ 
				_PrimaryRtspBroadcastingUrl = value;
				OnPropertyChanged("PrimaryRtspBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use SecondaryRtspBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondaryRtspBroadcastingUrl
		{
			get { return _SecondaryRtspBroadcastingUrl; }
			set 
			{ 
				_SecondaryRtspBroadcastingUrl = value;
				OnPropertyChanged("SecondaryRtspBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use PrimarySrtBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimarySrtBroadcastingUrl
		{
			get { return _PrimarySrtBroadcastingUrl; }
			set 
			{ 
				_PrimarySrtBroadcastingUrl = value;
				OnPropertyChanged("PrimarySrtBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use PrimarySrtStreamIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrimarySrtStreamId
		{
			get { return _PrimarySrtStreamId; }
			set 
			{ 
				_PrimarySrtStreamId = value;
				OnPropertyChanged("PrimarySrtStreamId");
			}
		}
		/// <summary>
		/// Use SecondarySrtBroadcastingUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondarySrtBroadcastingUrl
		{
			get { return _SecondarySrtBroadcastingUrl; }
			set 
			{ 
				_SecondarySrtBroadcastingUrl = value;
				OnPropertyChanged("SecondarySrtBroadcastingUrl");
			}
		}
		/// <summary>
		/// Use SecondarySrtStreamIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SecondarySrtStreamId
		{
			get { return _SecondarySrtStreamId; }
			set 
			{ 
				_SecondarySrtStreamId = value;
				OnPropertyChanged("SecondarySrtStreamId");
			}
		}
		/// <summary>
		/// Use StreamNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use StreamUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamUrl
		{
			get { return _StreamUrl; }
			set 
			{ 
				_StreamUrl = value;
				OnPropertyChanged("StreamUrl");
			}
		}
		/// <summary>
		/// Use HlsStreamUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HlsStreamUrl
		{
			get { return _HlsStreamUrl; }
			set 
			{ 
				_HlsStreamUrl = value;
				OnPropertyChanged("HlsStreamUrl");
			}
		}
		/// <summary>
		/// Use UrlManagerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UrlManager
		{
			get { return _UrlManager; }
			set 
			{ 
				_UrlManager = value;
				OnPropertyChanged("UrlManager");
			}
		}
		/// <summary>
		/// Use EncodingIP1AsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EncodingIP1
		{
			get { return _EncodingIP1; }
			set 
			{ 
				_EncodingIP1 = value;
				OnPropertyChanged("EncodingIP1");
			}
		}
		/// <summary>
		/// Use EncodingIP2AsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EncodingIP2
		{
			get { return _EncodingIP2; }
			set 
			{ 
				_EncodingIP2 = value;
				OnPropertyChanged("EncodingIP2");
			}
		}
		/// <summary>
		/// Use StreamPasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamPassword
		{
			get { return _StreamPassword; }
			set 
			{ 
				_StreamPassword = value;
				OnPropertyChanged("StreamPassword");
			}
		}
		/// <summary>
		/// Use StreamUsernameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StreamUsername
		{
			get { return _StreamUsername; }
			private set 
			{ 
				_StreamUsername = value;
				OnPropertyChanged("StreamUsername");
			}
		}
		/// <summary>
		/// Use SrtPassAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrtPass
		{
			get { return _SrtPass; }
			set 
			{ 
				_SrtPass = value;
				OnPropertyChanged("SrtPass");
			}
		}
		/// <summary>
		/// Use PrimaryServerNodeIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PrimaryServerNodeId
		{
			get { return _PrimaryServerNodeId; }
			private set 
			{ 
				_PrimaryServerNodeId = value;
				OnPropertyChanged("PrimaryServerNodeId");
			}
		}
		/// <summary>
		/// Use SipTokenAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SipToken
		{
			get { return _SipToken; }
			private set 
			{ 
				_SipToken = value;
				OnPropertyChanged("SipToken");
			}
		}
		/// <summary>
		/// Use SipSourceTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SipSourceType SipSourceType
		{
			get { return _SipSourceType; }
			private set 
			{ 
				_SipSourceType = value;
				OnPropertyChanged("SipSourceType");
			}
		}
		#endregion

		#region CTor
		public LiveStreamEntry()
		{
		}

		public LiveStreamEntry(JToken node) : base(node)
		{
			if(node["streamRemoteId"] != null)
			{
				this._StreamRemoteId = node["streamRemoteId"].Value<string>();
			}
			if(node["streamRemoteBackupId"] != null)
			{
				this._StreamRemoteBackupId = node["streamRemoteBackupId"].Value<string>();
			}
			if(node["bitrates"] != null)
			{
				this._Bitrates = new List<LiveStreamBitrate>();
				foreach(var arrayNode in node["bitrates"].Children())
				{
					this._Bitrates.Add(ObjectFactory.Create<LiveStreamBitrate>(arrayNode));
				}
			}
			if(node["primaryBroadcastingUrl"] != null)
			{
				this._PrimaryBroadcastingUrl = node["primaryBroadcastingUrl"].Value<string>();
			}
			if(node["secondaryBroadcastingUrl"] != null)
			{
				this._SecondaryBroadcastingUrl = node["secondaryBroadcastingUrl"].Value<string>();
			}
			if(node["primarySecuredBroadcastingUrl"] != null)
			{
				this._PrimarySecuredBroadcastingUrl = node["primarySecuredBroadcastingUrl"].Value<string>();
			}
			if(node["secondarySecuredBroadcastingUrl"] != null)
			{
				this._SecondarySecuredBroadcastingUrl = node["secondarySecuredBroadcastingUrl"].Value<string>();
			}
			if(node["primaryRtspBroadcastingUrl"] != null)
			{
				this._PrimaryRtspBroadcastingUrl = node["primaryRtspBroadcastingUrl"].Value<string>();
			}
			if(node["secondaryRtspBroadcastingUrl"] != null)
			{
				this._SecondaryRtspBroadcastingUrl = node["secondaryRtspBroadcastingUrl"].Value<string>();
			}
			if(node["primarySrtBroadcastingUrl"] != null)
			{
				this._PrimarySrtBroadcastingUrl = node["primarySrtBroadcastingUrl"].Value<string>();
			}
			if(node["primarySrtStreamId"] != null)
			{
				this._PrimarySrtStreamId = node["primarySrtStreamId"].Value<string>();
			}
			if(node["secondarySrtBroadcastingUrl"] != null)
			{
				this._SecondarySrtBroadcastingUrl = node["secondarySrtBroadcastingUrl"].Value<string>();
			}
			if(node["secondarySrtStreamId"] != null)
			{
				this._SecondarySrtStreamId = node["secondarySrtStreamId"].Value<string>();
			}
			if(node["streamName"] != null)
			{
				this._StreamName = node["streamName"].Value<string>();
			}
			if(node["streamUrl"] != null)
			{
				this._StreamUrl = node["streamUrl"].Value<string>();
			}
			if(node["hlsStreamUrl"] != null)
			{
				this._HlsStreamUrl = node["hlsStreamUrl"].Value<string>();
			}
			if(node["urlManager"] != null)
			{
				this._UrlManager = node["urlManager"].Value<string>();
			}
			if(node["encodingIP1"] != null)
			{
				this._EncodingIP1 = node["encodingIP1"].Value<string>();
			}
			if(node["encodingIP2"] != null)
			{
				this._EncodingIP2 = node["encodingIP2"].Value<string>();
			}
			if(node["streamPassword"] != null)
			{
				this._StreamPassword = node["streamPassword"].Value<string>();
			}
			if(node["streamUsername"] != null)
			{
				this._StreamUsername = node["streamUsername"].Value<string>();
			}
			if(node["srtPass"] != null)
			{
				this._SrtPass = node["srtPass"].Value<string>();
			}
			if(node["primaryServerNodeId"] != null)
			{
				this._PrimaryServerNodeId = ParseInt(node["primaryServerNodeId"].Value<string>());
			}
			if(node["sipToken"] != null)
			{
				this._SipToken = node["sipToken"].Value<string>();
			}
			if(node["sipSourceType"] != null)
			{
				this._SipSourceType = (SipSourceType)ParseEnum(typeof(SipSourceType), node["sipSourceType"].Value<string>());
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
			kparams.AddIfNotNull("primarySecuredBroadcastingUrl", this._PrimarySecuredBroadcastingUrl);
			kparams.AddIfNotNull("secondarySecuredBroadcastingUrl", this._SecondarySecuredBroadcastingUrl);
			kparams.AddIfNotNull("primaryRtspBroadcastingUrl", this._PrimaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("secondaryRtspBroadcastingUrl", this._SecondaryRtspBroadcastingUrl);
			kparams.AddIfNotNull("primarySrtBroadcastingUrl", this._PrimarySrtBroadcastingUrl);
			kparams.AddIfNotNull("primarySrtStreamId", this._PrimarySrtStreamId);
			kparams.AddIfNotNull("secondarySrtBroadcastingUrl", this._SecondarySrtBroadcastingUrl);
			kparams.AddIfNotNull("secondarySrtStreamId", this._SecondarySrtStreamId);
			kparams.AddIfNotNull("streamName", this._StreamName);
			kparams.AddIfNotNull("streamUrl", this._StreamUrl);
			kparams.AddIfNotNull("hlsStreamUrl", this._HlsStreamUrl);
			kparams.AddIfNotNull("urlManager", this._UrlManager);
			kparams.AddIfNotNull("encodingIP1", this._EncodingIP1);
			kparams.AddIfNotNull("encodingIP2", this._EncodingIP2);
			kparams.AddIfNotNull("streamPassword", this._StreamPassword);
			kparams.AddIfNotNull("streamUsername", this._StreamUsername);
			kparams.AddIfNotNull("srtPass", this._SrtPass);
			kparams.AddIfNotNull("primaryServerNodeId", this._PrimaryServerNodeId);
			kparams.AddIfNotNull("sipToken", this._SipToken);
			kparams.AddIfNotNull("sipSourceType", this._SipSourceType);
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
				case PRIMARY_SECURED_BROADCASTING_URL:
					return "PrimarySecuredBroadcastingUrl";
				case SECONDARY_SECURED_BROADCASTING_URL:
					return "SecondarySecuredBroadcastingUrl";
				case PRIMARY_RTSP_BROADCASTING_URL:
					return "PrimaryRtspBroadcastingUrl";
				case SECONDARY_RTSP_BROADCASTING_URL:
					return "SecondaryRtspBroadcastingUrl";
				case PRIMARY_SRT_BROADCASTING_URL:
					return "PrimarySrtBroadcastingUrl";
				case PRIMARY_SRT_STREAM_ID:
					return "PrimarySrtStreamId";
				case SECONDARY_SRT_BROADCASTING_URL:
					return "SecondarySrtBroadcastingUrl";
				case SECONDARY_SRT_STREAM_ID:
					return "SecondarySrtStreamId";
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
				case SRT_PASS:
					return "SrtPass";
				case PRIMARY_SERVER_NODE_ID:
					return "PrimaryServerNodeId";
				case SIP_TOKEN:
					return "SipToken";
				case SIP_SOURCE_TYPE:
					return "SipSourceType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

