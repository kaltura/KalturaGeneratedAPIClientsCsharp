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
	public class ProvisionJobData : JobData
	{
		#region Constants
		public const string STREAM_ID = "streamID";
		public const string BACKUP_STREAM_ID = "backupStreamID";
		public const string RTMP = "rtmp";
		public const string ENCODER_IP = "encoderIP";
		public const string BACKUP_ENCODER_IP = "backupEncoderIP";
		public const string ENCODER_PASSWORD = "encoderPassword";
		public const string ENCODER_USERNAME = "encoderUsername";
		public const string END_DATE = "endDate";
		public const string RETURN_VAL = "returnVal";
		public const string MEDIA_TYPE = "mediaType";
		public const string PRIMARY_BROADCASTING_URL = "primaryBroadcastingUrl";
		public const string SECONDARY_BROADCASTING_URL = "secondaryBroadcastingUrl";
		public const string STREAM_NAME = "streamName";
		#endregion

		#region Private Fields
		private string _StreamID = null;
		private string _BackupStreamID = null;
		private string _Rtmp = null;
		private string _EncoderIP = null;
		private string _BackupEncoderIP = null;
		private string _EncoderPassword = null;
		private string _EncoderUsername = null;
		private int _EndDate = Int32.MinValue;
		private string _ReturnVal = null;
		private int _MediaType = Int32.MinValue;
		private string _PrimaryBroadcastingUrl = null;
		private string _SecondaryBroadcastingUrl = null;
		private string _StreamName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string StreamID
		{
			get { return _StreamID; }
			set 
			{ 
				_StreamID = value;
				OnPropertyChanged("StreamID");
			}
		}
		[JsonProperty]
		public string BackupStreamID
		{
			get { return _BackupStreamID; }
			set 
			{ 
				_BackupStreamID = value;
				OnPropertyChanged("BackupStreamID");
			}
		}
		[JsonProperty]
		public string Rtmp
		{
			get { return _Rtmp; }
			set 
			{ 
				_Rtmp = value;
				OnPropertyChanged("Rtmp");
			}
		}
		[JsonProperty]
		public string EncoderIP
		{
			get { return _EncoderIP; }
			set 
			{ 
				_EncoderIP = value;
				OnPropertyChanged("EncoderIP");
			}
		}
		[JsonProperty]
		public string BackupEncoderIP
		{
			get { return _BackupEncoderIP; }
			set 
			{ 
				_BackupEncoderIP = value;
				OnPropertyChanged("BackupEncoderIP");
			}
		}
		[JsonProperty]
		public string EncoderPassword
		{
			get { return _EncoderPassword; }
			set 
			{ 
				_EncoderPassword = value;
				OnPropertyChanged("EncoderPassword");
			}
		}
		[JsonProperty]
		public string EncoderUsername
		{
			get { return _EncoderUsername; }
			set 
			{ 
				_EncoderUsername = value;
				OnPropertyChanged("EncoderUsername");
			}
		}
		[JsonProperty]
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		[JsonProperty]
		public string ReturnVal
		{
			get { return _ReturnVal; }
			set 
			{ 
				_ReturnVal = value;
				OnPropertyChanged("ReturnVal");
			}
		}
		[JsonProperty]
		public int MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
			}
		}
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
		public ProvisionJobData()
		{
		}

		public ProvisionJobData(JToken node) : base(node)
		{
			if(node["streamID"] != null)
			{
				this._StreamID = node["streamID"].Value<string>();
			}
			if(node["backupStreamID"] != null)
			{
				this._BackupStreamID = node["backupStreamID"].Value<string>();
			}
			if(node["rtmp"] != null)
			{
				this._Rtmp = node["rtmp"].Value<string>();
			}
			if(node["encoderIP"] != null)
			{
				this._EncoderIP = node["encoderIP"].Value<string>();
			}
			if(node["backupEncoderIP"] != null)
			{
				this._BackupEncoderIP = node["backupEncoderIP"].Value<string>();
			}
			if(node["encoderPassword"] != null)
			{
				this._EncoderPassword = node["encoderPassword"].Value<string>();
			}
			if(node["encoderUsername"] != null)
			{
				this._EncoderUsername = node["encoderUsername"].Value<string>();
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseInt(node["endDate"].Value<string>());
			}
			if(node["returnVal"] != null)
			{
				this._ReturnVal = node["returnVal"].Value<string>();
			}
			if(node["mediaType"] != null)
			{
				this._MediaType = ParseInt(node["mediaType"].Value<string>());
			}
			if(node["primaryBroadcastingUrl"] != null)
			{
				this._PrimaryBroadcastingUrl = node["primaryBroadcastingUrl"].Value<string>();
			}
			if(node["secondaryBroadcastingUrl"] != null)
			{
				this._SecondaryBroadcastingUrl = node["secondaryBroadcastingUrl"].Value<string>();
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
				kparams.AddReplace("objectType", "KalturaProvisionJobData");
			kparams.AddIfNotNull("streamID", this._StreamID);
			kparams.AddIfNotNull("backupStreamID", this._BackupStreamID);
			kparams.AddIfNotNull("rtmp", this._Rtmp);
			kparams.AddIfNotNull("encoderIP", this._EncoderIP);
			kparams.AddIfNotNull("backupEncoderIP", this._BackupEncoderIP);
			kparams.AddIfNotNull("encoderPassword", this._EncoderPassword);
			kparams.AddIfNotNull("encoderUsername", this._EncoderUsername);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("returnVal", this._ReturnVal);
			kparams.AddIfNotNull("mediaType", this._MediaType);
			kparams.AddIfNotNull("primaryBroadcastingUrl", this._PrimaryBroadcastingUrl);
			kparams.AddIfNotNull("secondaryBroadcastingUrl", this._SecondaryBroadcastingUrl);
			kparams.AddIfNotNull("streamName", this._StreamName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case STREAM_ID:
					return "StreamID";
				case BACKUP_STREAM_ID:
					return "BackupStreamID";
				case RTMP:
					return "Rtmp";
				case ENCODER_IP:
					return "EncoderIP";
				case BACKUP_ENCODER_IP:
					return "BackupEncoderIP";
				case ENCODER_PASSWORD:
					return "EncoderPassword";
				case ENCODER_USERNAME:
					return "EncoderUsername";
				case END_DATE:
					return "EndDate";
				case RETURN_VAL:
					return "ReturnVal";
				case MEDIA_TYPE:
					return "MediaType";
				case PRIMARY_BROADCASTING_URL:
					return "PrimaryBroadcastingUrl";
				case SECONDARY_BROADCASTING_URL:
					return "SecondaryBroadcastingUrl";
				case STREAM_NAME:
					return "StreamName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

