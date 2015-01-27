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
// Copyright (C) 2006-2011  Kaltura Inc.
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
		private bool? _IsAdmin = false;
		private KalturaLanguageCode _Language = null;
		private int _LastLoginTime = Int32.MinValue;
		private int _StatusUpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private bool? _LoginEnabled = false;
		private string _RoleIds = null;
		private string _RoleNames = null;
		private bool? _IsAccountOwner = false;
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
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
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
			set 
			{ 
				_StorageSize = value;
				OnPropertyChanged("StorageSize");
			}
		}
		public string Password
		{
			get { return _Password; }
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
			set 
			{ 
				_LastLoginTime = value;
				OnPropertyChanged("LastLoginTime");
			}
		}
		public int StatusUpdatedAt
		{
			get { return _StatusUpdatedAt; }
			set 
			{ 
				_StatusUpdatedAt = value;
				OnPropertyChanged("StatusUpdatedAt");
			}
		}
		public int DeletedAt
		{
			get { return _DeletedAt; }
			set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
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
			set 
			{ 
				_RoleNames = value;
				OnPropertyChanged("RoleNames");
			}
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
		public KalturaUser()
		{
		}

		public KalturaUser(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = txt;
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "screenName":
						this.ScreenName = txt;
						continue;
					case "fullName":
						this.FullName = txt;
						continue;
					case "email":
						this.Email = txt;
						continue;
					case "dateOfBirth":
						this.DateOfBirth = ParseInt(txt);
						continue;
					case "country":
						this.Country = txt;
						continue;
					case "state":
						this.State = txt;
						continue;
					case "city":
						this.City = txt;
						continue;
					case "zip":
						this.Zip = txt;
						continue;
					case "thumbnailUrl":
						this.ThumbnailUrl = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "tags":
						this.Tags = txt;
						continue;
					case "adminTags":
						this.AdminTags = txt;
						continue;
					case "gender":
						this.Gender = (KalturaGender)ParseEnum(typeof(KalturaGender), txt);
						continue;
					case "status":
						this.Status = (KalturaUserStatus)ParseEnum(typeof(KalturaUserStatus), txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "partnerData":
						this.PartnerData = txt;
						continue;
					case "indexedPartnerDataInt":
						this.IndexedPartnerDataInt = ParseInt(txt);
						continue;
					case "indexedPartnerDataString":
						this.IndexedPartnerDataString = txt;
						continue;
					case "storageSize":
						this.StorageSize = ParseInt(txt);
						continue;
					case "password":
						this.Password = txt;
						continue;
					case "firstName":
						this.FirstName = txt;
						continue;
					case "lastName":
						this.LastName = txt;
						continue;
					case "isAdmin":
						this.IsAdmin = ParseBool(txt);
						continue;
					case "language":
						this.Language = (KalturaLanguageCode)KalturaStringEnum.Parse(typeof(KalturaLanguageCode), txt);
						continue;
					case "lastLoginTime":
						this.LastLoginTime = ParseInt(txt);
						continue;
					case "statusUpdatedAt":
						this.StatusUpdatedAt = ParseInt(txt);
						continue;
					case "deletedAt":
						this.DeletedAt = ParseInt(txt);
						continue;
					case "loginEnabled":
						this.LoginEnabled = ParseBool(txt);
						continue;
					case "roleIds":
						this.RoleIds = txt;
						continue;
					case "roleNames":
						this.RoleNames = txt;
						continue;
					case "isAccountOwner":
						this.IsAccountOwner = ParseBool(txt);
						continue;
					case "allowedPartnerIds":
						this.AllowedPartnerIds = txt;
						continue;
					case "allowedPartnerPackages":
						this.AllowedPartnerPackages = txt;
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
			kparams.AddStringIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("screenName", this.ScreenName);
			kparams.AddStringIfNotNull("fullName", this.FullName);
			kparams.AddStringIfNotNull("email", this.Email);
			kparams.AddIntIfNotNull("dateOfBirth", this.DateOfBirth);
			kparams.AddStringIfNotNull("country", this.Country);
			kparams.AddStringIfNotNull("state", this.State);
			kparams.AddStringIfNotNull("city", this.City);
			kparams.AddStringIfNotNull("zip", this.Zip);
			kparams.AddStringIfNotNull("thumbnailUrl", this.ThumbnailUrl);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringIfNotNull("tags", this.Tags);
			kparams.AddStringIfNotNull("adminTags", this.AdminTags);
			kparams.AddEnumIfNotNull("gender", this.Gender);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddStringIfNotNull("partnerData", this.PartnerData);
			kparams.AddIntIfNotNull("indexedPartnerDataInt", this.IndexedPartnerDataInt);
			kparams.AddStringIfNotNull("indexedPartnerDataString", this.IndexedPartnerDataString);
			kparams.AddIntIfNotNull("storageSize", this.StorageSize);
			kparams.AddStringIfNotNull("password", this.Password);
			kparams.AddStringIfNotNull("firstName", this.FirstName);
			kparams.AddStringIfNotNull("lastName", this.LastName);
			kparams.AddBoolIfNotNull("isAdmin", this.IsAdmin);
			kparams.AddStringEnumIfNotNull("language", this.Language);
			kparams.AddIntIfNotNull("lastLoginTime", this.LastLoginTime);
			kparams.AddIntIfNotNull("statusUpdatedAt", this.StatusUpdatedAt);
			kparams.AddIntIfNotNull("deletedAt", this.DeletedAt);
			kparams.AddBoolIfNotNull("loginEnabled", this.LoginEnabled);
			kparams.AddStringIfNotNull("roleIds", this.RoleIds);
			kparams.AddStringIfNotNull("roleNames", this.RoleNames);
			kparams.AddBoolIfNotNull("isAccountOwner", this.IsAccountOwner);
			kparams.AddStringIfNotNull("allowedPartnerIds", this.AllowedPartnerIds);
			kparams.AddStringIfNotNull("allowedPartnerPackages", this.AllowedPartnerPackages);
			return kparams;
		}
		#endregion
	}
}

