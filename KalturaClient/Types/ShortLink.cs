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
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public int ExpiresAt
		{
			get { return _ExpiresAt; }
			set 
			{ 
				_ExpiresAt = value;
				OnPropertyChanged("ExpiresAt");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
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
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string FullUrl
		{
			get { return _FullUrl; }
			set 
			{ 
				_FullUrl = value;
				OnPropertyChanged("FullUrl");
			}
		}
		[JsonProperty]
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

		public ShortLink(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["expiresAt"] != null)
			{
				this._ExpiresAt = ParseInt(node["expiresAt"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["fullUrl"] != null)
			{
				this._FullUrl = node["fullUrl"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (ShortLinkStatus)ParseEnum(typeof(ShortLinkStatus), node["status"].Value<string>());
			}
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

