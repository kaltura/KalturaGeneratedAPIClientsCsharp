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
	public class NotificationJobData : JobData
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string TYPE = "type";
		public const string TYPE_AS_STRING = "typeAsString";
		public const string OBJECT_ID = "objectId";
		public const string STATUS = "status";
		public const string DATA = "data";
		public const string NUMBER_OF_ATTEMPTS = "numberOfAttempts";
		public const string NOTIFICATION_RESULT = "notificationResult";
		public const string OBJ_TYPE = "objType";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private NotificationType _Type = (NotificationType)Int32.MinValue;
		private string _TypeAsString = null;
		private string _ObjectId = null;
		private NotificationStatus _Status = (NotificationStatus)Int32.MinValue;
		private string _Data = null;
		private int _NumberOfAttempts = Int32.MinValue;
		private string _NotificationResult = null;
		private NotificationObjectType _ObjType = (NotificationObjectType)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		[JsonProperty]
		public NotificationType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string TypeAsString
		{
			get { return _TypeAsString; }
			set 
			{ 
				_TypeAsString = value;
				OnPropertyChanged("TypeAsString");
			}
		}
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		[JsonProperty]
		public NotificationStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		[JsonProperty]
		public int NumberOfAttempts
		{
			get { return _NumberOfAttempts; }
			set 
			{ 
				_NumberOfAttempts = value;
				OnPropertyChanged("NumberOfAttempts");
			}
		}
		[JsonProperty]
		public string NotificationResult
		{
			get { return _NotificationResult; }
			set 
			{ 
				_NotificationResult = value;
				OnPropertyChanged("NotificationResult");
			}
		}
		[JsonProperty]
		public NotificationObjectType ObjType
		{
			get { return _ObjType; }
			set 
			{ 
				_ObjType = value;
				OnPropertyChanged("ObjType");
			}
		}
		#endregion

		#region CTor
		public NotificationJobData()
		{
		}

		public NotificationJobData(JToken node) : base(node)
		{
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["type"] != null)
			{
				this._Type = (NotificationType)ParseEnum(typeof(NotificationType), node["type"].Value<string>());
			}
			if(node["typeAsString"] != null)
			{
				this._TypeAsString = node["typeAsString"].Value<string>();
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (NotificationStatus)ParseEnum(typeof(NotificationStatus), node["status"].Value<string>());
			}
			if(node["data"] != null)
			{
				this._Data = node["data"].Value<string>();
			}
			if(node["numberOfAttempts"] != null)
			{
				this._NumberOfAttempts = ParseInt(node["numberOfAttempts"].Value<string>());
			}
			if(node["notificationResult"] != null)
			{
				this._NotificationResult = node["notificationResult"].Value<string>();
			}
			if(node["objType"] != null)
			{
				this._ObjType = (NotificationObjectType)ParseEnum(typeof(NotificationObjectType), node["objType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaNotificationJobData");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("typeAsString", this._TypeAsString);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("numberOfAttempts", this._NumberOfAttempts);
			kparams.AddIfNotNull("notificationResult", this._NotificationResult);
			kparams.AddIfNotNull("objType", this._ObjType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case TYPE:
					return "Type";
				case TYPE_AS_STRING:
					return "TypeAsString";
				case OBJECT_ID:
					return "ObjectId";
				case STATUS:
					return "Status";
				case DATA:
					return "Data";
				case NUMBER_OF_ATTEMPTS:
					return "NumberOfAttempts";
				case NOTIFICATION_RESULT:
					return "NotificationResult";
				case OBJ_TYPE:
					return "ObjType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

