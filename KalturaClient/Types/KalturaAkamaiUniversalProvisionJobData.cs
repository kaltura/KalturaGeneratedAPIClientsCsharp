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
	public class KalturaAkamaiUniversalProvisionJobData : KalturaProvisionJobData
	{
		#region Private Fields
		private int _StreamId = Int32.MinValue;
		private string _SystemUserName = null;
		private string _SystemPassword = null;
		private string _DomainName = null;
		private KalturaDVRStatus _DvrEnabled = (KalturaDVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private string _PrimaryContact = null;
		private string _SecondaryContact = null;
		private KalturaAkamaiUniversalStreamType _StreamType = null;
		private string _NotificationEmail = null;
		#endregion

		#region Properties
		public int StreamId
		{
			get { return _StreamId; }
			set 
			{ 
				_StreamId = value;
				OnPropertyChanged("StreamId");
			}
		}
		public string SystemUserName
		{
			get { return _SystemUserName; }
			set 
			{ 
				_SystemUserName = value;
				OnPropertyChanged("SystemUserName");
			}
		}
		public string SystemPassword
		{
			get { return _SystemPassword; }
			set 
			{ 
				_SystemPassword = value;
				OnPropertyChanged("SystemPassword");
			}
		}
		public string DomainName
		{
			get { return _DomainName; }
			set 
			{ 
				_DomainName = value;
				OnPropertyChanged("DomainName");
			}
		}
		public KalturaDVRStatus DvrEnabled
		{
			get { return _DvrEnabled; }
			set 
			{ 
				_DvrEnabled = value;
				OnPropertyChanged("DvrEnabled");
			}
		}
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		public string PrimaryContact
		{
			get { return _PrimaryContact; }
			set 
			{ 
				_PrimaryContact = value;
				OnPropertyChanged("PrimaryContact");
			}
		}
		public string SecondaryContact
		{
			get { return _SecondaryContact; }
			set 
			{ 
				_SecondaryContact = value;
				OnPropertyChanged("SecondaryContact");
			}
		}
		public KalturaAkamaiUniversalStreamType StreamType
		{
			get { return _StreamType; }
			set 
			{ 
				_StreamType = value;
				OnPropertyChanged("StreamType");
			}
		}
		public string NotificationEmail
		{
			get { return _NotificationEmail; }
			set 
			{ 
				_NotificationEmail = value;
				OnPropertyChanged("NotificationEmail");
			}
		}
		#endregion

		#region CTor
		public KalturaAkamaiUniversalProvisionJobData()
		{
		}

		public KalturaAkamaiUniversalProvisionJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "streamId":
						this._StreamId = ParseInt(txt);
						continue;
					case "systemUserName":
						this._SystemUserName = txt;
						continue;
					case "systemPassword":
						this._SystemPassword = txt;
						continue;
					case "domainName":
						this._DomainName = txt;
						continue;
					case "dvrEnabled":
						this._DvrEnabled = (KalturaDVRStatus)ParseEnum(typeof(KalturaDVRStatus), txt);
						continue;
					case "dvrWindow":
						this._DvrWindow = ParseInt(txt);
						continue;
					case "primaryContact":
						this._PrimaryContact = txt;
						continue;
					case "secondaryContact":
						this._SecondaryContact = txt;
						continue;
					case "streamType":
						this._StreamType = (KalturaAkamaiUniversalStreamType)KalturaStringEnum.Parse(typeof(KalturaAkamaiUniversalStreamType), txt);
						continue;
					case "notificationEmail":
						this._NotificationEmail = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAkamaiUniversalProvisionJobData");
			kparams.AddIfNotNull("streamId", this._StreamId);
			kparams.AddIfNotNull("systemUserName", this._SystemUserName);
			kparams.AddIfNotNull("systemPassword", this._SystemPassword);
			kparams.AddIfNotNull("domainName", this._DomainName);
			kparams.AddIfNotNull("dvrEnabled", this._DvrEnabled);
			kparams.AddIfNotNull("dvrWindow", this._DvrWindow);
			kparams.AddIfNotNull("primaryContact", this._PrimaryContact);
			kparams.AddIfNotNull("secondaryContact", this._SecondaryContact);
			kparams.AddIfNotNull("streamType", this._StreamType);
			kparams.AddIfNotNull("notificationEmail", this._NotificationEmail);
			return kparams;
		}
		#endregion
	}
}

