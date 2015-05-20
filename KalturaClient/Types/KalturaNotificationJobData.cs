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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaNotificationJobData : KalturaJobData
	{
		#region Private Fields
		private string _UserId = null;
		private KalturaNotificationType _Type = (KalturaNotificationType)Int32.MinValue;
		private string _TypeAsString = null;
		private string _ObjectId = null;
		private KalturaNotificationStatus _Status = (KalturaNotificationStatus)Int32.MinValue;
		private string _Data = null;
		private int _NumberOfAttempts = Int32.MinValue;
		private string _NotificationResult = null;
		private KalturaNotificationObjectType _ObjType = (KalturaNotificationObjectType)Int32.MinValue;
		#endregion

		#region Properties
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public KalturaNotificationType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string TypeAsString
		{
			get { return _TypeAsString; }
			set 
			{ 
				_TypeAsString = value;
				OnPropertyChanged("TypeAsString");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public KalturaNotificationStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public int NumberOfAttempts
		{
			get { return _NumberOfAttempts; }
			set 
			{ 
				_NumberOfAttempts = value;
				OnPropertyChanged("NumberOfAttempts");
			}
		}
		public string NotificationResult
		{
			get { return _NotificationResult; }
			set 
			{ 
				_NotificationResult = value;
				OnPropertyChanged("NotificationResult");
			}
		}
		public KalturaNotificationObjectType ObjType
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
		public KalturaNotificationJobData()
		{
		}

		public KalturaNotificationJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "userId":
						this.UserId = txt;
						continue;
					case "type":
						this.Type = (KalturaNotificationType)ParseEnum(typeof(KalturaNotificationType), txt);
						continue;
					case "typeAsString":
						this.TypeAsString = txt;
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "status":
						this.Status = (KalturaNotificationStatus)ParseEnum(typeof(KalturaNotificationStatus), txt);
						continue;
					case "data":
						this.Data = txt;
						continue;
					case "numberOfAttempts":
						this.NumberOfAttempts = ParseInt(txt);
						continue;
					case "notificationResult":
						this.NotificationResult = txt;
						continue;
					case "objType":
						this.ObjType = (KalturaNotificationObjectType)ParseEnum(typeof(KalturaNotificationObjectType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaNotificationJobData");
			kparams.AddStringIfNotNull("userId", this.UserId);
			kparams.AddEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("typeAsString", this.TypeAsString);
			kparams.AddStringIfNotNull("objectId", this.ObjectId);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringIfNotNull("data", this.Data);
			kparams.AddIntIfNotNull("numberOfAttempts", this.NumberOfAttempts);
			kparams.AddStringIfNotNull("notificationResult", this.NotificationResult);
			kparams.AddEnumIfNotNull("objType", this.ObjType);
			return kparams;
		}
		#endregion
	}
}

