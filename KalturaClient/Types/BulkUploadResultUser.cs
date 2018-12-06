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
		public string ScreenName
		{
			get { return _ScreenName; }
			set 
			{ 
				_ScreenName = value;
				OnPropertyChanged("ScreenName");
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
		public int Gender
		{
			get { return _Gender; }
			set 
			{ 
				_Gender = value;
				OnPropertyChanged("Gender");
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
		public string Group
		{
			get { return _Group; }
			set 
			{ 
				_Group = value;
				OnPropertyChanged("Group");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultUser()
		{
		}

		public BulkUploadResultUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "screenName":
						this._ScreenName = propertyNode.InnerText;
						continue;
					case "email":
						this._Email = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
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
					case "gender":
						this._Gender = ParseInt(propertyNode.InnerText);
						continue;
					case "firstName":
						this._FirstName = propertyNode.InnerText;
						continue;
					case "lastName":
						this._LastName = propertyNode.InnerText;
						continue;
					case "group":
						this._Group = propertyNode.InnerText;
						continue;
				}
			}
		}

		public BulkUploadResultUser(IDictionary<string,object> data) : base(data)
		{
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._ScreenName = data.TryGetValueSafe<string>("screenName");
			    this._Email = data.TryGetValueSafe<string>("email");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._DateOfBirth = data.TryGetValueSafe<int>("dateOfBirth");
			    this._Country = data.TryGetValueSafe<string>("country");
			    this._State = data.TryGetValueSafe<string>("state");
			    this._City = data.TryGetValueSafe<string>("city");
			    this._Zip = data.TryGetValueSafe<string>("zip");
			    this._Gender = data.TryGetValueSafe<int>("gender");
			    this._FirstName = data.TryGetValueSafe<string>("firstName");
			    this._LastName = data.TryGetValueSafe<string>("lastName");
			    this._Group = data.TryGetValueSafe<string>("group");
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

