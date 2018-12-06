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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class UserEntry : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		public const string USER_ID = "userId";
		public const string PARTNER_ID = "partnerId";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string TYPE = "type";
		public const string EXTENDED_STATUS = "extendedStatus";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _EntryId = null;
		private string _UserId = null;
		private int _PartnerId = Int32.MinValue;
		private UserEntryStatus _Status = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private UserEntryType _Type = null;
		private UserEntryExtendedStatus _ExtendedStatus = null;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public UserEntryStatus Status
		{
			get { return _Status; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public UserEntryType Type
		{
			get { return _Type; }
		}
		public UserEntryExtendedStatus ExtendedStatus
		{
			get { return _ExtendedStatus; }
			set 
			{ 
				_ExtendedStatus = value;
				OnPropertyChanged("ExtendedStatus");
			}
		}
		#endregion

		#region CTor
		public UserEntry()
		{
		}

		public UserEntry(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "entryId":
						this._EntryId = propertyNode.InnerText;
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (UserEntryStatus)StringEnum.Parse(typeof(UserEntryStatus), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (UserEntryType)StringEnum.Parse(typeof(UserEntryType), propertyNode.InnerText);
						continue;
					case "extendedStatus":
						this._ExtendedStatus = (UserEntryExtendedStatus)StringEnum.Parse(typeof(UserEntryExtendedStatus), propertyNode.InnerText);
						continue;
				}
			}
		}

		public UserEntry(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._EntryId = data.TryGetValueSafe<string>("entryId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Status = (UserEntryStatus)StringEnum.Parse(typeof(UserEntryStatus), data.TryGetValueSafe<string>("status"));
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._Type = (UserEntryType)StringEnum.Parse(typeof(UserEntryType), data.TryGetValueSafe<string>("type"));
			    this._ExtendedStatus = (UserEntryExtendedStatus)StringEnum.Parse(typeof(UserEntryExtendedStatus), data.TryGetValueSafe<string>("extendedStatus"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserEntry");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("extendedStatus", this._ExtendedStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case ENTRY_ID:
					return "EntryId";
				case USER_ID:
					return "UserId";
				case PARTNER_ID:
					return "PartnerId";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case TYPE:
					return "Type";
				case EXTENDED_STATUS:
					return "ExtendedStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

