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
	public class BaseUser : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string SCREEN_NAME = "screenName";
		public const string FULL_NAME = "fullName";
		public const string EMAIL = "email";
		public const string COUNTRY = "country";
		public const string STATE = "state";
		public const string CITY = "city";
		public const string ZIP = "zip";
		public const string THUMBNAIL_URL = "thumbnailUrl";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string ADMIN_TAGS = "adminTags";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_DATA = "partnerData";
		public const string INDEXED_PARTNER_DATA_INT = "indexedPartnerDataInt";
		public const string INDEXED_PARTNER_DATA_STRING = "indexedPartnerDataString";
		public const string STORAGE_SIZE = "storageSize";
		public const string LANGUAGE = "language";
		public const string LAST_LOGIN_TIME = "lastLoginTime";
		public const string STATUS_UPDATED_AT = "statusUpdatedAt";
		public const string DELETED_AT = "deletedAt";
		public const string ALLOWED_PARTNER_IDS = "allowedPartnerIds";
		public const string ALLOWED_PARTNER_PACKAGES = "allowedPartnerPackages";
		public const string USER_MODE = "userMode";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private string _ScreenName = null;
		private string _FullName = null;
		private string _Email = null;
		private string _Country = null;
		private string _State = null;
		private string _City = null;
		private string _Zip = null;
		private string _ThumbnailUrl = null;
		private string _Description = null;
		private string _Tags = null;
		private string _AdminTags = null;
		private UserStatus _Status = (UserStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerData = null;
		private int _IndexedPartnerDataInt = Int32.MinValue;
		private string _IndexedPartnerDataString = null;
		private int _StorageSize = Int32.MinValue;
		private LanguageCode _Language = null;
		private int _LastLoginTime = Int32.MinValue;
		private int _StatusUpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private string _AllowedPartnerIds = null;
		private string _AllowedPartnerPackages = null;
		private UserMode _UserMode = (UserMode)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ScreenNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ScreenName
		{
			get { return _ScreenName; }
			set 
			{ 
				_ScreenName = value;
				OnPropertyChanged("ScreenName");
			}
		}
		/// <summary>
		/// Use FullNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FullName
		{
			get { return _FullName; }
			set 
			{ 
				_FullName = value;
				OnPropertyChanged("FullName");
			}
		}
		/// <summary>
		/// Use EmailAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		/// <summary>
		/// Use CountryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		/// <summary>
		/// Use StateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		/// <summary>
		/// Use CityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string City
		{
			get { return _City; }
			set 
			{ 
				_City = value;
				OnPropertyChanged("City");
			}
		}
		/// <summary>
		/// Use ZipAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Zip
		{
			get { return _Zip; }
			set 
			{ 
				_Zip = value;
				OnPropertyChanged("Zip");
			}
		}
		/// <summary>
		/// Use ThumbnailUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		/// <summary>
		/// Use AdminTagsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AdminTags
		{
			get { return _AdminTags; }
			set 
			{ 
				_AdminTags = value;
				OnPropertyChanged("AdminTags");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use IndexedPartnerDataIntAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IndexedPartnerDataInt
		{
			get { return _IndexedPartnerDataInt; }
			set 
			{ 
				_IndexedPartnerDataInt = value;
				OnPropertyChanged("IndexedPartnerDataInt");
			}
		}
		/// <summary>
		/// Use IndexedPartnerDataStringAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string IndexedPartnerDataString
		{
			get { return _IndexedPartnerDataString; }
			set 
			{ 
				_IndexedPartnerDataString = value;
				OnPropertyChanged("IndexedPartnerDataString");
			}
		}
		/// <summary>
		/// Use StorageSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StorageSize
		{
			get { return _StorageSize; }
			private set 
			{ 
				_StorageSize = value;
				OnPropertyChanged("StorageSize");
			}
		}
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LanguageCode Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use LastLoginTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LastLoginTime
		{
			get { return _LastLoginTime; }
			private set 
			{ 
				_LastLoginTime = value;
				OnPropertyChanged("LastLoginTime");
			}
		}
		/// <summary>
		/// Use StatusUpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StatusUpdatedAt
		{
			get { return _StatusUpdatedAt; }
			private set 
			{ 
				_StatusUpdatedAt = value;
				OnPropertyChanged("StatusUpdatedAt");
			}
		}
		/// <summary>
		/// Use DeletedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DeletedAt
		{
			get { return _DeletedAt; }
			private set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
		}
		/// <summary>
		/// Use AllowedPartnerIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AllowedPartnerIds
		{
			get { return _AllowedPartnerIds; }
			set 
			{ 
				_AllowedPartnerIds = value;
				OnPropertyChanged("AllowedPartnerIds");
			}
		}
		/// <summary>
		/// Use AllowedPartnerPackagesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AllowedPartnerPackages
		{
			get { return _AllowedPartnerPackages; }
			set 
			{ 
				_AllowedPartnerPackages = value;
				OnPropertyChanged("AllowedPartnerPackages");
			}
		}
		/// <summary>
		/// Use UserModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UserMode UserMode
		{
			get { return _UserMode; }
			set 
			{ 
				_UserMode = value;
				OnPropertyChanged("UserMode");
			}
		}
		#endregion

		#region CTor
		public BaseUser()
		{
		}

		public BaseUser(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["screenName"] != null)
			{
				this._ScreenName = node["screenName"].Value<string>();
			}
			if(node["fullName"] != null)
			{
				this._FullName = node["fullName"].Value<string>();
			}
			if(node["email"] != null)
			{
				this._Email = node["email"].Value<string>();
			}
			if(node["country"] != null)
			{
				this._Country = node["country"].Value<string>();
			}
			if(node["state"] != null)
			{
				this._State = node["state"].Value<string>();
			}
			if(node["city"] != null)
			{
				this._City = node["city"].Value<string>();
			}
			if(node["zip"] != null)
			{
				this._Zip = node["zip"].Value<string>();
			}
			if(node["thumbnailUrl"] != null)
			{
				this._ThumbnailUrl = node["thumbnailUrl"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["adminTags"] != null)
			{
				this._AdminTags = node["adminTags"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (UserStatus)ParseEnum(typeof(UserStatus), node["status"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["indexedPartnerDataInt"] != null)
			{
				this._IndexedPartnerDataInt = ParseInt(node["indexedPartnerDataInt"].Value<string>());
			}
			if(node["indexedPartnerDataString"] != null)
			{
				this._IndexedPartnerDataString = node["indexedPartnerDataString"].Value<string>();
			}
			if(node["storageSize"] != null)
			{
				this._StorageSize = ParseInt(node["storageSize"].Value<string>());
			}
			if(node["language"] != null)
			{
				this._Language = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), node["language"].Value<string>());
			}
			if(node["lastLoginTime"] != null)
			{
				this._LastLoginTime = ParseInt(node["lastLoginTime"].Value<string>());
			}
			if(node["statusUpdatedAt"] != null)
			{
				this._StatusUpdatedAt = ParseInt(node["statusUpdatedAt"].Value<string>());
			}
			if(node["deletedAt"] != null)
			{
				this._DeletedAt = ParseInt(node["deletedAt"].Value<string>());
			}
			if(node["allowedPartnerIds"] != null)
			{
				this._AllowedPartnerIds = node["allowedPartnerIds"].Value<string>();
			}
			if(node["allowedPartnerPackages"] != null)
			{
				this._AllowedPartnerPackages = node["allowedPartnerPackages"].Value<string>();
			}
			if(node["userMode"] != null)
			{
				this._UserMode = (UserMode)ParseEnum(typeof(UserMode), node["userMode"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseUser");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("screenName", this._ScreenName);
			kparams.AddIfNotNull("fullName", this._FullName);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("country", this._Country);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("city", this._City);
			kparams.AddIfNotNull("zip", this._Zip);
			kparams.AddIfNotNull("thumbnailUrl", this._ThumbnailUrl);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("adminTags", this._AdminTags);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("indexedPartnerDataInt", this._IndexedPartnerDataInt);
			kparams.AddIfNotNull("indexedPartnerDataString", this._IndexedPartnerDataString);
			kparams.AddIfNotNull("storageSize", this._StorageSize);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("lastLoginTime", this._LastLoginTime);
			kparams.AddIfNotNull("statusUpdatedAt", this._StatusUpdatedAt);
			kparams.AddIfNotNull("deletedAt", this._DeletedAt);
			kparams.AddIfNotNull("allowedPartnerIds", this._AllowedPartnerIds);
			kparams.AddIfNotNull("allowedPartnerPackages", this._AllowedPartnerPackages);
			kparams.AddIfNotNull("userMode", this._UserMode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case SCREEN_NAME:
					return "ScreenName";
				case FULL_NAME:
					return "FullName";
				case EMAIL:
					return "Email";
				case COUNTRY:
					return "Country";
				case STATE:
					return "State";
				case CITY:
					return "City";
				case ZIP:
					return "Zip";
				case THUMBNAIL_URL:
					return "ThumbnailUrl";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
				case ADMIN_TAGS:
					return "AdminTags";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_DATA:
					return "PartnerData";
				case INDEXED_PARTNER_DATA_INT:
					return "IndexedPartnerDataInt";
				case INDEXED_PARTNER_DATA_STRING:
					return "IndexedPartnerDataString";
				case STORAGE_SIZE:
					return "StorageSize";
				case LANGUAGE:
					return "Language";
				case LAST_LOGIN_TIME:
					return "LastLoginTime";
				case STATUS_UPDATED_AT:
					return "StatusUpdatedAt";
				case DELETED_AT:
					return "DeletedAt";
				case ALLOWED_PARTNER_IDS:
					return "AllowedPartnerIds";
				case ALLOWED_PARTNER_PACKAGES:
					return "AllowedPartnerPackages";
				case USER_MODE:
					return "UserMode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

