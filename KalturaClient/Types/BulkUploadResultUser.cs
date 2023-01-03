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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class BulkUploadResultUser : BulkUploadResult
	{
		#region Constants
		public const string USER_ID = "userId";
		public const string SCREEN_NAME = "screenName";
		public const string EMAIL = "email";
		public const string DESCRIPTION = "description";
		public const string TAGS = "tags";
		public const string DATE_OF_BIRTH = "dateOfBirth";
		public const string COUNTRY = "country";
		public const string STATE = "state";
		public const string CITY = "city";
		public const string ZIP = "zip";
		public const string GENDER = "gender";
		public const string FIRST_NAME = "firstName";
		public const string LAST_NAME = "lastName";
		public const string GROUP = "group";
		public const string EXTERNAL_ID = "externalId";
		#endregion

		#region Private Fields
		private string _UserId = null;
		private string _ScreenName = null;
		private string _Email = null;
		private string _Description = null;
		private string _Tags = null;
		private int _DateOfBirth = Int32.MinValue;
		private string _Country = null;
		private string _State = null;
		private string _City = null;
		private string _Zip = null;
		private int _Gender = Int32.MinValue;
		private string _FirstName = null;
		private string _LastName = null;
		private string _Group = null;
		private string _ExternalId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
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
		/// Use DateOfBirthAsDouble property instead
		/// </summary>
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
		/// Use GenderAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Gender
		{
			get { return _Gender; }
			set 
			{ 
				_Gender = value;
				OnPropertyChanged("Gender");
			}
		}
		/// <summary>
		/// Use FirstNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use LastNameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use GroupAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Group
		{
			get { return _Group; }
			set 
			{ 
				_Group = value;
				OnPropertyChanged("Group");
			}
		}
		/// <summary>
		/// Use ExternalIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExternalId
		{
			get { return _ExternalId; }
			set 
			{ 
				_ExternalId = value;
				OnPropertyChanged("ExternalId");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultUser()
		{
		}

		public BulkUploadResultUser(JToken node) : base(node)
		{
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["screenName"] != null)
			{
				this._ScreenName = node["screenName"].Value<string>();
			}
			if(node["email"] != null)
			{
				this._Email = node["email"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["dateOfBirth"] != null)
			{
				this._DateOfBirth = ParseInt(node["dateOfBirth"].Value<string>());
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
			if(node["gender"] != null)
			{
				this._Gender = ParseInt(node["gender"].Value<string>());
			}
			if(node["firstName"] != null)
			{
				this._FirstName = node["firstName"].Value<string>();
			}
			if(node["lastName"] != null)
			{
				this._LastName = node["lastName"].Value<string>();
			}
			if(node["group"] != null)
			{
				this._Group = node["group"].Value<string>();
			}
			if(node["externalId"] != null)
			{
				this._ExternalId = node["externalId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultUser");
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("screenName", this._ScreenName);
			kparams.AddIfNotNull("email", this._Email);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("dateOfBirth", this._DateOfBirth);
			kparams.AddIfNotNull("country", this._Country);
			kparams.AddIfNotNull("state", this._State);
			kparams.AddIfNotNull("city", this._City);
			kparams.AddIfNotNull("zip", this._Zip);
			kparams.AddIfNotNull("gender", this._Gender);
			kparams.AddIfNotNull("firstName", this._FirstName);
			kparams.AddIfNotNull("lastName", this._LastName);
			kparams.AddIfNotNull("group", this._Group);
			kparams.AddIfNotNull("externalId", this._ExternalId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID:
					return "UserId";
				case SCREEN_NAME:
					return "ScreenName";
				case EMAIL:
					return "Email";
				case DESCRIPTION:
					return "Description";
				case TAGS:
					return "Tags";
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
				case GENDER:
					return "Gender";
				case FIRST_NAME:
					return "FirstName";
				case LAST_NAME:
					return "LastName";
				case GROUP:
					return "Group";
				case EXTERNAL_ID:
					return "ExternalId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

