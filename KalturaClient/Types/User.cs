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
	public class User : BaseUser
	{
		#region Constants
		public const string TYPE = "type";
		public const string DATE_OF_BIRTH = "dateOfBirth";
		public const string GENDER = "gender";
		public const string IS_ADMIN = "isAdmin";
		public const string ROLE_IDS = "roleIds";
		public const string ROLE_NAMES = "roleNames";
		public const string IS_ACCOUNT_OWNER = "isAccountOwner";
		public const string PASSWORD = "password";
		public const string FIRST_NAME = "firstName";
		public const string LAST_NAME = "lastName";
		public const string LOGIN_ENABLED = "loginEnabled";
		public const string REGISTRATION_INFO = "registrationInfo";
		public const string ATTENDANCE_INFO = "attendanceInfo";
		public const string TITLE = "title";
		public const string COMPANY = "company";
		public const string KS_PRIVILEGES = "ksPrivileges";
		#endregion

		#region Private Fields
		private UserType _Type = (UserType)Int32.MinValue;
		private int _DateOfBirth = Int32.MinValue;
		private Gender _Gender = (Gender)Int32.MinValue;
		private bool? _IsAdmin = null;
		private string _RoleIds = null;
		private string _RoleNames = null;
		private bool? _IsAccountOwner = null;
		private string _Password = null;
		private string _FirstName = null;
		private string _LastName = null;
		private bool? _LoginEnabled = null;
		private string _RegistrationInfo = null;
		private string _AttendanceInfo = null;
		private string _Title = null;
		private string _Company = null;
		private string _KsPrivileges = null;
		#endregion

		#region Properties
		[JsonProperty]
		public UserType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public int DateOfBirth
		{
			get { return _DateOfBirth; }
			set 
			{ 
				_DateOfBirth = value;
				OnPropertyChanged("DateOfBirth");
			}
		}
		[JsonProperty]
		public Gender Gender
		{
			get { return _Gender; }
			set 
			{ 
				_Gender = value;
				OnPropertyChanged("Gender");
			}
		}
		[JsonProperty]
		public bool? IsAdmin
		{
			get { return _IsAdmin; }
			set 
			{ 
				_IsAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}
		[JsonProperty]
		public string RoleIds
		{
			get { return _RoleIds; }
			set 
			{ 
				_RoleIds = value;
				OnPropertyChanged("RoleIds");
			}
		}
		[JsonProperty]
		public string RoleNames
		{
			get { return _RoleNames; }
			private set 
			{ 
				_RoleNames = value;
				OnPropertyChanged("RoleNames");
			}
		}
		[JsonProperty]
		public bool? IsAccountOwner
		{
			get { return _IsAccountOwner; }
			set 
			{ 
				_IsAccountOwner = value;
				OnPropertyChanged("IsAccountOwner");
			}
		}
		[JsonProperty]
		public string Password
		{
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		[JsonProperty]
		public string FirstName
		{
			get { return _FirstName; }
			set 
			{ 
				_FirstName = value;
				OnPropertyChanged("FirstName");
			}
		}
		[JsonProperty]
		public string LastName
		{
			get { return _LastName; }
			set 
			{ 
				_LastName = value;
				OnPropertyChanged("LastName");
			}
		}
		[JsonProperty]
		public bool? LoginEnabled
		{
			get { return _LoginEnabled; }
			set 
			{ 
				_LoginEnabled = value;
				OnPropertyChanged("LoginEnabled");
			}
		}
		[JsonProperty]
		public string RegistrationInfo
		{
			get { return _RegistrationInfo; }
			set 
			{ 
				_RegistrationInfo = value;
				OnPropertyChanged("RegistrationInfo");
			}
		}
		[JsonProperty]
		public string AttendanceInfo
		{
			get { return _AttendanceInfo; }
			set 
			{ 
				_AttendanceInfo = value;
				OnPropertyChanged("AttendanceInfo");
			}
		}
		[JsonProperty]
		public string Title
		{
			get { return _Title; }
			set 
			{ 
				_Title = value;
				OnPropertyChanged("Title");
			}
		}
		[JsonProperty]
		public string Company
		{
			get { return _Company; }
			set 
			{ 
				_Company = value;
				OnPropertyChanged("Company");
			}
		}
		[JsonProperty]
		public string KsPrivileges
		{
			get { return _KsPrivileges; }
			set 
			{ 
				_KsPrivileges = value;
				OnPropertyChanged("KsPrivileges");
			}
		}
		#endregion

		#region CTor
		public User()
		{
		}

		public User(JToken node) : base(node)
		{
			if(node["type"] != null)
			{
				this._Type = (UserType)ParseEnum(typeof(UserType), node["type"].Value<string>());
			}
			if(node["dateOfBirth"] != null)
			{
				this._DateOfBirth = ParseInt(node["dateOfBirth"].Value<string>());
			}
			if(node["gender"] != null)
			{
				this._Gender = (Gender)ParseEnum(typeof(Gender), node["gender"].Value<string>());
			}
			if(node["isAdmin"] != null)
			{
				this._IsAdmin = ParseBool(node["isAdmin"].Value<string>());
			}
			if(node["roleIds"] != null)
			{
				this._RoleIds = node["roleIds"].Value<string>();
			}
			if(node["roleNames"] != null)
			{
				this._RoleNames = node["roleNames"].Value<string>();
			}
			if(node["isAccountOwner"] != null)
			{
				this._IsAccountOwner = ParseBool(node["isAccountOwner"].Value<string>());
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["firstName"] != null)
			{
				this._FirstName = node["firstName"].Value<string>();
			}
			if(node["lastName"] != null)
			{
				this._LastName = node["lastName"].Value<string>();
			}
			if(node["loginEnabled"] != null)
			{
				this._LoginEnabled = ParseBool(node["loginEnabled"].Value<string>());
			}
			if(node["registrationInfo"] != null)
			{
				this._RegistrationInfo = node["registrationInfo"].Value<string>();
			}
			if(node["attendanceInfo"] != null)
			{
				this._AttendanceInfo = node["attendanceInfo"].Value<string>();
			}
			if(node["title"] != null)
			{
				this._Title = node["title"].Value<string>();
			}
			if(node["company"] != null)
			{
				this._Company = node["company"].Value<string>();
			}
			if(node["ksPrivileges"] != null)
			{
				this._KsPrivileges = node["ksPrivileges"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUser");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("dateOfBirth", this._DateOfBirth);
			kparams.AddIfNotNull("gender", this._Gender);
			kparams.AddIfNotNull("isAdmin", this._IsAdmin);
			kparams.AddIfNotNull("roleIds", this._RoleIds);
			kparams.AddIfNotNull("roleNames", this._RoleNames);
			kparams.AddIfNotNull("isAccountOwner", this._IsAccountOwner);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("firstName", this._FirstName);
			kparams.AddIfNotNull("lastName", this._LastName);
			kparams.AddIfNotNull("loginEnabled", this._LoginEnabled);
			kparams.AddIfNotNull("registrationInfo", this._RegistrationInfo);
			kparams.AddIfNotNull("attendanceInfo", this._AttendanceInfo);
			kparams.AddIfNotNull("title", this._Title);
			kparams.AddIfNotNull("company", this._Company);
			kparams.AddIfNotNull("ksPrivileges", this._KsPrivileges);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case DATE_OF_BIRTH:
					return "DateOfBirth";
				case GENDER:
					return "Gender";
				case IS_ADMIN:
					return "IsAdmin";
				case ROLE_IDS:
					return "RoleIds";
				case ROLE_NAMES:
					return "RoleNames";
				case IS_ACCOUNT_OWNER:
					return "IsAccountOwner";
				case PASSWORD:
					return "Password";
				case FIRST_NAME:
					return "FirstName";
				case LAST_NAME:
					return "LastName";
				case LOGIN_ENABLED:
					return "LoginEnabled";
				case REGISTRATION_INFO:
					return "RegistrationInfo";
				case ATTENDANCE_INFO:
					return "AttendanceInfo";
				case TITLE:
					return "Title";
				case COMPANY:
					return "Company";
				case KS_PRIVILEGES:
					return "KsPrivileges";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

