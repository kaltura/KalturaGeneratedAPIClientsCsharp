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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class AkamaiUniversalProvisionJobData : ProvisionJobData
	{
		#region Constants
		public new const string STREAM_ID = "streamId";
		public const string SYSTEM_USER_NAME = "systemUserName";
		public const string SYSTEM_PASSWORD = "systemPassword";
		public const string DOMAIN_NAME = "domainName";
		public const string DVR_ENABLED = "dvrEnabled";
		public const string DVR_WINDOW = "dvrWindow";
		public const string PRIMARY_CONTACT = "primaryContact";
		public const string SECONDARY_CONTACT = "secondaryContact";
		public const string STREAM_TYPE = "streamType";
		public const string NOTIFICATION_EMAIL = "notificationEmail";
		#endregion

		#region Private Fields
		private int _StreamId = Int32.MinValue;
		private string _SystemUserName = null;
		private string _SystemPassword = null;
		private string _DomainName = null;
		private DVRStatus _DvrEnabled = (DVRStatus)Int32.MinValue;
		private int _DvrWindow = Int32.MinValue;
		private string _PrimaryContact = null;
		private string _SecondaryContact = null;
		private AkamaiUniversalStreamType _StreamType = null;
		private string _NotificationEmail = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int StreamId
		{
			get { return _StreamId; }
			set 
			{ 
				_StreamId = value;
				OnPropertyChanged("StreamId");
			}
		}
		[JsonProperty]
		public string SystemUserName
		{
			get { return _SystemUserName; }
			set 
			{ 
				_SystemUserName = value;
				OnPropertyChanged("SystemUserName");
			}
		}
		[JsonProperty]
		public string SystemPassword
		{
			get { return _SystemPassword; }
			set 
			{ 
				_SystemPassword = value;
				OnPropertyChanged("SystemPassword");
			}
		}
		[JsonProperty]
		public string DomainName
		{
			get { return _DomainName; }
			set 
			{ 
				_DomainName = value;
				OnPropertyChanged("DomainName");
			}
		}
		[JsonProperty]
		public DVRStatus DvrEnabled
		{
			get { return _DvrEnabled; }
			set 
			{ 
				_DvrEnabled = value;
				OnPropertyChanged("DvrEnabled");
			}
		}
		[JsonProperty]
		public int DvrWindow
		{
			get { return _DvrWindow; }
			set 
			{ 
				_DvrWindow = value;
				OnPropertyChanged("DvrWindow");
			}
		}
		[JsonProperty]
		public string PrimaryContact
		{
			get { return _PrimaryContact; }
			set 
			{ 
				_PrimaryContact = value;
				OnPropertyChanged("PrimaryContact");
			}
		}
		[JsonProperty]
		public string SecondaryContact
		{
			get { return _SecondaryContact; }
			set 
			{ 
				_SecondaryContact = value;
				OnPropertyChanged("SecondaryContact");
			}
		}
		[JsonProperty]
		public AkamaiUniversalStreamType StreamType
		{
			get { return _StreamType; }
			set 
			{ 
				_StreamType = value;
				OnPropertyChanged("StreamType");
			}
		}
		[JsonProperty]
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
		public AkamaiUniversalProvisionJobData()
		{
		}

		public AkamaiUniversalProvisionJobData(JToken node) : base(node)
		{
			if(node["streamId"] != null)
			{
				this._StreamId = ParseInt(node["streamId"].Value<string>());
			}
			if(node["systemUserName"] != null)
			{
				this._SystemUserName = node["systemUserName"].Value<string>();
			}
			if(node["systemPassword"] != null)
			{
				this._SystemPassword = node["systemPassword"].Value<string>();
			}
			if(node["domainName"] != null)
			{
				this._DomainName = node["domainName"].Value<string>();
			}
			if(node["dvrEnabled"] != null)
			{
				this._DvrEnabled = (DVRStatus)ParseEnum(typeof(DVRStatus), node["dvrEnabled"].Value<string>());
			}
			if(node["dvrWindow"] != null)
			{
				this._DvrWindow = ParseInt(node["dvrWindow"].Value<string>());
			}
			if(node["primaryContact"] != null)
			{
				this._PrimaryContact = node["primaryContact"].Value<string>();
			}
			if(node["secondaryContact"] != null)
			{
				this._SecondaryContact = node["secondaryContact"].Value<string>();
			}
			if(node["streamType"] != null)
			{
				this._StreamType = (AkamaiUniversalStreamType)StringEnum.Parse(typeof(AkamaiUniversalStreamType), node["streamType"].Value<string>());
			}
			if(node["notificationEmail"] != null)
			{
				this._NotificationEmail = node["notificationEmail"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
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
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case STREAM_ID:
					return "StreamId";
				case SYSTEM_USER_NAME:
					return "SystemUserName";
				case SYSTEM_PASSWORD:
					return "SystemPassword";
				case DOMAIN_NAME:
					return "DomainName";
				case DVR_ENABLED:
					return "DvrEnabled";
				case DVR_WINDOW:
					return "DvrWindow";
				case PRIMARY_CONTACT:
					return "PrimaryContact";
				case SECONDARY_CONTACT:
					return "SecondaryContact";
				case STREAM_TYPE:
					return "StreamType";
				case NOTIFICATION_EMAIL:
					return "NotificationEmail";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

