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
	public class ShortLink : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string EXPIRES_AT = "expiresAt";
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string FULL_URL = "fullUrl";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _ExpiresAt = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _FullUrl = null;
		private ShortLinkStatus _Status = (ShortLinkStatus)Int32.MinValue;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int ExpiresAt
		{
			get { return _ExpiresAt; }
			set 
			{ 
				_ExpiresAt = value;
				OnPropertyChanged("ExpiresAt");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string FullUrl
		{
			get { return _FullUrl; }
			set 
			{ 
				_FullUrl = value;
				OnPropertyChanged("FullUrl");
			}
		}
		public ShortLinkStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public ShortLink()
		{
		}

		public ShortLink(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "expiresAt":
						this._ExpiresAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "fullUrl":
						this._FullUrl = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (ShortLinkStatus)ParseEnum(typeof(ShortLinkStatus), propertyNode.InnerText);
						continue;
				}
			}
		}

		public ShortLink(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<string>("id");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._ExpiresAt = data.TryGetValueSafe<int>("expiresAt");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._FullUrl = data.TryGetValueSafe<string>("fullUrl");
			    this._Status = (ShortLinkStatus)ParseEnum(typeof(ShortLinkStatus), data.TryGetValueSafe<int>("status"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaShortLink");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("expiresAt", this._ExpiresAt);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("fullUrl", this._FullUrl);
			kparams.AddIfNotNull("status", this._Status);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case EXPIRES_AT:
					return "ExpiresAt";
				case PARTNER_ID:
					return "PartnerId";
				case USER_ID:
					return "UserId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case FULL_URL:
					return "FullUrl";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

