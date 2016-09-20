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
	public class KalturaUser : KalturaObjectBase
	{
		#region Private Fields
		private string _Id = null;
		private int _PartnerId = Int32.MinValue;
		private KalturaUserType _Type = (KalturaUserType)Int32.MinValue;
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
		private KalturaGender _Gender = (KalturaGender)Int32.MinValue;
		private KalturaUserStatus _Status = (KalturaUserStatus)Int32.MinValue;
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
		private KalturaLanguageCode _Language = null;
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
		public KalturaUserType Type
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
		public KalturaGender Gender
		{
			get { return _Gender; }
			set 
			{ 
				_Gender = value;
				OnPropertyChanged("Gender");
			}
		}
		public KalturaUserStatus Status
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
		public KalturaLanguageCode Language
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
		public KalturaUser()
		{
		}

		public KalturaUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = txt;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "type":
						this._Type = (KalturaUserType)ParseEnum(typeof(KalturaUserType), txt);
						continue;
					case "screenName":
						this._ScreenName = txt;
						continue;
					case "fullName":
						this._FullName = txt;
						continue;
					case "email":
						this._Email = txt;
						continue;
					case "dateOfBirth":
						this._DateOfBirth = ParseInt(txt);
						continue;
					case "country":
						this._Country = txt;
						continue;
					case "state":
						this._State = txt;
						continue;
					case "city":
						this._City = txt;
						continue;
					case "zip":
						this._Zip = txt;
						continue;
					case "thumbnailUrl":
						this._ThumbnailUrl = txt;
						continue;
					case "description":
						this._Description = txt;
						continue;
					case "tags":
						this._Tags = txt;
						continue;
					case "adminTags":
						this._AdminTags = txt;
						continue;
					case "gender":
						this._Gender = (KalturaGender)ParseEnum(typeof(KalturaGender), txt);
						continue;
					case "status":
						this._Status = (KalturaUserStatus)ParseEnum(typeof(KalturaUserStatus), txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "partnerData":
						this._PartnerData = txt;
						continue;
					case "indexedPartnerDataInt":
						this._IndexedPartnerDataInt = ParseInt(txt);
						continue;
					case "indexedPartnerDataString":
						this._IndexedPartnerDataString = txt;
						continue;
					case "storageSize":
						this._StorageSize = ParseInt(txt);
						continue;
					case "password":
						this._Password = txt;
						continue;
					case "firstName":
						this._FirstName = txt;
						continue;
					case "lastName":
						this._LastName = txt;
						continue;
					case "isAdmin":
						this._IsAdmin = ParseBool(txt);
						continue;
					case "language":
						this._Language = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "lastLoginTime":
						this._LastLoginTime = ParseInt(txt);
						continue;
					case "statusUpdatedAt":
						this._StatusUpdatedAt = ParseInt(txt);
						continue;
					case "deletedAt":
						this._DeletedAt = ParseInt(txt);
						continue;
					case "loginEnabled":
						this._LoginEnabled = ParseBool(txt);
						continue;
					case "roleIds":
						this._RoleIds = txt;
						continue;
					case "roleNames":
						this._RoleNames = txt;
						continue;
					case "isAccountOwner":
						this._IsAccountOwner = ParseBool(txt);
						continue;
					case "allowedPartnerIds":
						this._AllowedPartnerIds = txt;
						continue;
					case "allowedPartnerPackages":
						this._AllowedPartnerPackages = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUser");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("type", this.Type);
			kparams.AddIfNotNull("screenName", this.ScreenName);
			kparams.AddIfNotNull("fullName", this.FullName);
			kparams.AddIfNotNull("email", this.Email);
			kparams.AddIfNotNull("dateOfBirth", this.DateOfBirth);
			kparams.AddIfNotNull("country", this.Country);
			kparams.AddIfNotNull("state", this.State);
			kparams.AddIfNotNull("city", this.City);
			kparams.AddIfNotNull("zip", this.Zip);
			kparams.AddIfNotNull("thumbnailUrl", this.ThumbnailUrl);
			kparams.AddIfNotNull("description", this.Description);
			kparams.AddIfNotNull("tags", this.Tags);
			kparams.AddIfNotNull("adminTags", this.AdminTags);
			kparams.AddIfNotNull("gender", this.Gender);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("partnerData", this.PartnerData);
			kparams.AddIfNotNull("indexedPartnerDataInt", this.IndexedPartnerDataInt);
			kparams.AddIfNotNull("indexedPartnerDataString", this.IndexedPartnerDataString);
			kparams.AddIfNotNull("storageSize", this.StorageSize);
			kparams.AddIfNotNull("password", this.Password);
			kparams.AddIfNotNull("firstName", this.FirstName);
			kparams.AddIfNotNull("lastName", this.LastName);
			kparams.AddIfNotNull("isAdmin", this.IsAdmin);
			kparams.AddIfNotNull("language", this.Language);
			kparams.AddIfNotNull("lastLoginTime", this.LastLoginTime);
			kparams.AddIfNotNull("statusUpdatedAt", this.StatusUpdatedAt);
			kparams.AddIfNotNull("deletedAt", this.DeletedAt);
			kparams.AddIfNotNull("loginEnabled", this.LoginEnabled);
			kparams.AddIfNotNull("roleIds", this.RoleIds);
			kparams.AddIfNotNull("roleNames", this.RoleNames);
			kparams.AddIfNotNull("isAccountOwner", this.IsAccountOwner);
			kparams.AddIfNotNull("allowedPartnerIds", this.AllowedPartnerIds);
			kparams.AddIfNotNull("allowedPartnerPackages", this.AllowedPartnerPackages);
			return kparams;
		}
		#endregion
	}
}

