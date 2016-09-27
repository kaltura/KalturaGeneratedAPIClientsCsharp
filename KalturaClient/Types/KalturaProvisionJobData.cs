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
	public class KalturaProvisionJobData : KalturaJobData
	{
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
		public string StreamID
		{
			get { return _StreamID; }
			set 
			{ 
				_StreamID = value;
				OnPropertyChanged("StreamID");
			}
		}
		public string BackupStreamID
		{
			get { return _BackupStreamID; }
			set 
			{ 
				_BackupStreamID = value;
				OnPropertyChanged("BackupStreamID");
			}
		}
		public string Rtmp
		{
			get { return _Rtmp; }
			set 
			{ 
				_Rtmp = value;
				OnPropertyChanged("Rtmp");
			}
		}
		public string EncoderIP
		{
			get { return _EncoderIP; }
			set 
			{ 
				_EncoderIP = value;
				OnPropertyChanged("EncoderIP");
			}
		}
		public string BackupEncoderIP
		{
			get { return _BackupEncoderIP; }
			set 
			{ 
				_BackupEncoderIP = value;
				OnPropertyChanged("BackupEncoderIP");
			}
		}
		public string EncoderPassword
		{
			get { return _EncoderPassword; }
			set 
			{ 
				_EncoderPassword = value;
				OnPropertyChanged("EncoderPassword");
			}
		}
		public string EncoderUsername
		{
			get { return _EncoderUsername; }
			set 
			{ 
				_EncoderUsername = value;
				OnPropertyChanged("EncoderUsername");
			}
		}
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		public string ReturnVal
		{
			get { return _ReturnVal; }
			set 
			{ 
				_ReturnVal = value;
				OnPropertyChanged("ReturnVal");
			}
		}
		public int MediaType
		{
			get { return _MediaType; }
			set 
			{ 
				_MediaType = value;
				OnPropertyChanged("MediaType");
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
		public KalturaProvisionJobData()
		{
		}

		public KalturaProvisionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "streamID":
						this._StreamID = txt;
						continue;
					case "backupStreamID":
						this._BackupStreamID = txt;
						continue;
					case "rtmp":
						this._Rtmp = txt;
						continue;
					case "encoderIP":
						this._EncoderIP = txt;
						continue;
					case "backupEncoderIP":
						this._BackupEncoderIP = txt;
						continue;
					case "encoderPassword":
						this._EncoderPassword = txt;
						continue;
					case "encoderUsername":
						this._EncoderUsername = txt;
						continue;
					case "endDate":
						this._EndDate = ParseInt(txt);
						continue;
					case "returnVal":
						this._ReturnVal = txt;
						continue;
					case "mediaType":
						this._MediaType = ParseInt(txt);
						continue;
					case "primaryBroadcastingUrl":
						this._PrimaryBroadcastingUrl = txt;
						continue;
					case "secondaryBroadcastingUrl":
						this._SecondaryBroadcastingUrl = txt;
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
		#endregion
	}
}

