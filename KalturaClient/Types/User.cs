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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class User : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string TYPE = "type";
		public const string SCREEN_NAME = "screenName";
		public const string FULL_NAME = "fullName";
		public const string EMAIL = "email";
		public const string DATE_OF_BIRTH = "dateOfBirth";
		public const string COUNTRY = "country";
		public const string STATE = "state";
		public const string CITY = "city";
		public const string ZIP = "zip";
		public const string THUMBNAIL_URL = "thumbnailUrl";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string ADMIN_TAGS = "adminTags";
		public const string GENDER = "gender";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_DATA = "partnerData";
		public const string INDEXED_PARTNER_DATA_INT = "indexedPartnerDataInt";
		public const string INDEXED_PARTNER_DATA_STRING = "indexedPartnerDataString";
		public const string STORAGE_SIZE = "storageSize";
		public const string PASSWORD = "password";
		public const string FIRST_NAME = "firstName";
		public const string LAST_NAME = "lastName";
		public const string IS_ADMIN = "isAdmin";
		public const string LANGUAGE = "language";
		public const string LAST_LOGIN_TIME = "lastLoginTime";
		public const string STATUS_UPDATED_AT = "statusUpdatedAt";
		public const string DELETED_AT = "deletedAt";
		public const string LOGIN_ENABLED = "loginEnabled";
		public const string ROLE_IDS = "roleIds";
		public const string ROLE_NAMES = "roleNames";
		public const string IS_ACCOUNT_OWNER = "isAccountOwner";
		public const string ALLOWED_PARTNER_IDS = "allowedPartnerIds";
		public const string ALLOWED_PARTNER_PACKAGES = "allowedPartnerPackages";
		#endregion

		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private UserType _Type = (UserType)Int32.MinValue;
		private string _ScreenName = null;
		private string _FullName = null;
		private string _Email = null;
		private int _DateOfBirth = Int32.MinValue;
		private string _Country = null;
		private string _State = null;
		private string _City = null;
		private string _Zip = null;
		private string _ThumbnailUrl = null;
		private string _Description = null;
		private string _Tags = null;
		private string _AdminTags = null;
		private Gender _Gender = (Gender)Int32.MinValue;
		private UserStatus _Status = (UserStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerData = null;
		private int _IndexedPartnerDataInt = Int32.MinValue;
		private string _IndexedPartnerDataString = null;
		private int _StorageSize = Int32.MinValue;
		private string _Password = null;
		private string _FirstName = null;
		private string _LastName = null;
		private bool? _IsAdmin = null;
		private LanguageCode _Language = null;
		private int _LastLoginTime = Int32.MinValue;
		private int _StatusUpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private bool? _LoginEnabled = null;
		private string _RoleIds = null;
		private string _RoleNames = null;
		private bool? _IsAccountOwner = null;
		private string _AllowedPartnerIds = null;
		private string _AllowedPartnerPackages = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public UserType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string ScreenName
		{
			get { return _ScreenName; }
			set 
			{ 
				_ScreenName = value;
				OnPropertyChanged("ScreenName");
			}
		}
		public string FullName
		{
			get { return _FullName; }
			set 
			{ 
				_FullName = value;
				OnPropertyChanged("FullName");
			}
		}
		public string Email
		{
			get { return _Email; }
			set 
			{ 
				_Email = value;
				OnPropertyChanged("Email");
			}
		}
		public int DateOfBirth
		{
			get { return _DateOfBirth; }
			set 
			{ 
				_DateOfBirth = value;
				OnPropertyChanged("DateOfBirth");
			}
		}
		public string Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		public string State
		{
			get { return _State; }
			set 
			{ 
				_State = value;
				OnPropertyChanged("State");
			}
		}
		public string City
		{
			get { return _City; }
			set 
			{ 
				_City = value;
				OnPropertyChanged("City");
			}
		}
		public string Zip
		{
			get { return _Zip; }
			set 
			{ 
				_Zip = value;
				OnPropertyChanged("Zip");
			}
		}
		public string ThumbnailUrl
		{
			get { return _ThumbnailUrl; }
			set 
			{ 
				_ThumbnailUrl = value;
				OnPropertyChanged("ThumbnailUrl");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public string AdminTags
		{
			get { return _AdminTags; }
			set 
			{ 
				_AdminTags = value;
				OnPropertyChanged("AdminTags");
			}
		}
		public Gender Gender
		{
			get { return _Gender; }
			set 
			{ 
				_Gender = value;
				OnPropertyChanged("Gender");
			}
		}
		public UserStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		public int IndexedPartnerDataInt
		{
			get { return _IndexedPartnerDataInt; }
			set 
			{ 
				_IndexedPartnerDataInt = value;
				OnPropertyChanged("IndexedPartnerDataInt");
			}
		}
		public string IndexedPartnerDataString
		{
			get { return _IndexedPartnerDataString; }
			set 
			{ 
				_IndexedPartnerDataString = value;
				OnPropertyChanged("IndexedPartnerDataString");
			}
		}
		public int StorageSize
		{
			get { return _StorageSize; }
		}
		public string Password
		{
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string FirstName
		{
			get { return _FirstName; }
			set 
			{ 
				_FirstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		public string LastName
		{
			get { return _LastName; }
			set 
			{ 
				_LastName = value;
				OnPropertyChanged("LastName");
			}
		}
		public bool? IsAdmin
		{
			get { return _IsAdmin; }
			set 
			{ 
				_IsAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}
		public LanguageCode Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public int LastLoginTime
		{
			get { return _LastLoginTime; }
		}
		public int StatusUpdatedAt
		{
			get { return _StatusUpdatedAt; }
		}
		public int DeletedAt
		{
			get { return _DeletedAt; }
		}
		public bool? LoginEnabled
		{
			get { return _LoginEnabled; }
			set 
			{ 
				_LoginEnabled = value;
				OnPropertyChanged("LoginEnabled");
			}
		}
		public string RoleIds
		{
			get { return _RoleIds; }
			set 
			{ 
				_RoleIds = value;
				OnPropertyChanged("RoleIds");
			}
		}
		public string RoleNames
		{
			get { return _RoleNames; }
		}
		public bool? IsAccountOwner
		{
			get { return _IsAccountOwner; }
			set 
			{ 
				_IsAccountOwner = value;
				OnPropertyChanged("IsAccountOwner");
			}
		}
		public string AllowedPartnerIds
		{
			get { return _AllowedPartnerIds; }
			set 
			{ 
				_AllowedPartnerIds = value;
				OnPropertyChanged("AllowedPartnerIds");
			}
		}
		public string AllowedPartnerPackages
		{
			get { return _AllowedPartnerPackages; }
			set 
			{ 
				_AllowedPartnerPackages = value;
				OnPropertyChanged("AllowedPartnerPackages");
			}
		}
		#endregion

		#region CTor
		public User()
		{
		}

		public User(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "type":
						this._Type = (UserType)ParseEnum(typeof(UserType), propertyNode.InnerText);
						continue;
					case "screenName":
						this._ScreenName = propertyNode.InnerText;
						continue;
					case "fullName":
						this._FullName = propertyNode.InnerText;
						continue;
					case "email":
						this._Email = propertyNode.InnerText;
						continue;
					case "dateOfBirth":
						this._DateOfBirth = ParseInt(propertyNode.InnerText);
						continue;
					case "country":
						this._Country = propertyNode.InnerText;
						continue;
					case "state":
						this._State = propertyNode.InnerText;
						continue;
					case "city":
						this._City = propertyNode.InnerText;
						continue;
					case "zip":
						this._Zip = propertyNode.InnerText;
						continue;
					case "thumbnailUrl":
						this._ThumbnailUrl = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "adminTags":
						this._AdminTags = propertyNode.InnerText;
						continue;
					case "gender":
						this._Gender = (Gender)ParseEnum(typeof(Gender), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (UserStatus)ParseEnum(typeof(UserStatus), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerData":
						this._PartnerData = propertyNode.InnerText;
						continue;
					case "indexedPartnerDataInt":
						this._IndexedPartnerDataInt = ParseInt(propertyNode.InnerText);
						continue;
					case "indexedPartnerDataString":
						this._IndexedPartnerDataString = propertyNode.InnerText;
						continue;
					case "storageSize":
						this._StorageSize = ParseInt(propertyNode.InnerText);
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "firstName":
						this._FirstName = propertyNode.InnerText;
						continue;
					case "lastName":
						this._LastName = propertyNode.InnerText;
						continue;
					case "isAdmin":
						this._IsAdmin = ParseBool(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), propertyNode.InnerText);
						continue;
					case "lastLoginTime":
						this._LastLoginTime = ParseInt(propertyNode.InnerText);
						continue;
					case "statusUpdatedAt":
						this._StatusUpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "deletedAt":
						this._DeletedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "loginEnabled":
						this._LoginEnabled = ParseBool(propertyNode.InnerText);
						continue;
					case "roleIds":
						this._RoleIds = propertyNode.InnerText;
						continue;
					case "roleNames":
						this._RoleNames = propertyNode.InnerText;
						continue;
					case "isAccountOwner":
						this._IsAccountOwner = ParseBool(propertyNode.InnerText);
						continue;
					case "allowedPartnerIds":
						this._AllowedPartnerIds = propertyNode.InnerText;
						continue;
					case "allowedPartnerPackages":
						this._AllowedPartnerPackages = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUser");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("screenName", this._ScreenName);
			kparams.AddIfNotNull("fullName", this._FullName);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("dateOfBirth", this._DateOfBirth);
			kparams.AddIfNotNull("country", this._Country);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("city", this._City);
			kparams.AddIfNotNull("zip", this._Zip);
			kparams.AddIfNotNull("thumbnailUrl", this._ThumbnailUrl);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("adminTags", this._AdminTags);
			kparams.AddIfNotNull("gender", this._Gender);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("indexedPartnerDataInt", this._IndexedPartnerDataInt);
			kparams.AddIfNotNull("indexedPartnerDataString", this._IndexedPartnerDataString);
			kparams.AddIfNotNull("storageSize", this._StorageSize);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("firstName", this._FirstName);
			kparams.AddIfNotNull("lastName", this._LastName);
			kparams.AddIfNotNull("isAdmin", this._IsAdmin);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("lastLoginTime", this._LastLoginTime);
			kparams.AddIfNotNull("statusUpdatedAt", this._StatusUpdatedAt);
			kparams.AddIfNotNull("deletedAt", this._DeletedAt);
			kparams.AddIfNotNull("loginEnabled", this._LoginEnabled);
			kparams.AddIfNotNull("roleIds", this._RoleIds);
			kparams.AddIfNotNull("roleNames", this._RoleNames);
			kparams.AddIfNotNull("isAccountOwner", this._IsAccountOwner);
			kparams.AddIfNotNull("allowedPartnerIds", this._AllowedPartnerIds);
			kparams.AddIfNotNull("allowedPartnerPackages", this._AllowedPartnerPackages);
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
				case TYPE:
					return "Type";
				case SCREEN_NAME:
					return "ScreenName";
				case FULL_NAME:
					return "FullName";
				case EMAIL:
					return "Email";
				case DATE_OF_BIRTH:
					return "DateOfBirth";
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
				case GENDER:
					return "Gender";
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
				case PASSWORD:
					return "Password";
				case FIRST_NAME:
					return "FirstName";
				case LAST_NAME:
					return "LastName";
				case IS_ADMIN:
					return "IsAdmin";
				case LANGUAGE:
					return "Language";
				case LAST_LOGIN_TIME:
					return "LastLoginTime";
				case STATUS_UPDATED_AT:
					return "StatusUpdatedAt";
				case DELETED_AT:
					return "DeletedAt";
				case LOGIN_ENABLED:
					return "LoginEnabled";
				case ROLE_IDS:
					return "RoleIds";
				case ROLE_NAMES:
					return "RoleNames";
				case IS_ACCOUNT_OWNER:
					return "IsAccountOwner";
				case ALLOWED_PARTNER_IDS:
					return "AllowedPartnerIds";
				case ALLOWED_PARTNER_PACKAGES:
					return "AllowedPartnerPackages";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

