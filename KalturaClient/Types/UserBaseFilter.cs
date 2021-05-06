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
	public class UserBaseFilter : BaseUserFilter
	{
		#region Constants
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string IS_ADMIN_EQUAL = "isAdminEqual";
		public const string FIRST_NAME_STARTS_WITH = "firstNameStartsWith";
		public const string LAST_NAME_STARTS_WITH = "lastNameStartsWith";
		#endregion

		#region Private Fields
		private UserType _TypeEqual = (UserType)Int32.MinValue;
		private string _TypeIn = null;
		private NullableBoolean _IsAdminEqual = (NullableBoolean)Int32.MinValue;
		private string _FirstNameStartsWith = null;
		private string _LastNameStartsWith = null;
		#endregion

		#region Properties
		[JsonProperty]
		public UserType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		[JsonProperty]
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		[JsonProperty]
		public NullableBoolean IsAdminEqual
		{
			get { return _IsAdminEqual; }
			set 
			{ 
				_IsAdminEqual = value;
				OnPropertyChanged("IsAdminEqual");
			}
		}
		[JsonProperty]
		public string FirstNameStartsWith
		{
			get { return _FirstNameStartsWith; }
			set 
			{ 
				_FirstNameStartsWith = value;
				OnPropertyChanged("FirstNameStartsWith");
			}
		}
		[JsonProperty]
		public string LastNameStartsWith
		{
			get { return _LastNameStartsWith; }
			set 
			{ 
				_LastNameStartsWith = value;
				OnPropertyChanged("LastNameStartsWith");
			}
		}
		#endregion

		#region CTor
		public UserBaseFilter()
		{
		}

		public UserBaseFilter(JToken node) : base(node)
		{
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (UserType)ParseEnum(typeof(UserType), node["typeEqual"].Value<string>());
			}
			if(node["typeIn"] != null)
			{
				this._TypeIn = node["typeIn"].Value<string>();
			}
			if(node["isAdminEqual"] != null)
			{
				this._IsAdminEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isAdminEqual"].Value<string>());
			}
			if(node["firstNameStartsWith"] != null)
			{
				this._FirstNameStartsWith = node["firstNameStartsWith"].Value<string>();
			}
			if(node["lastNameStartsWith"] != null)
			{
				this._LastNameStartsWith = node["lastNameStartsWith"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserBaseFilter");
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("isAdminEqual", this._IsAdminEqual);
			kparams.AddIfNotNull("firstNameStartsWith", this._FirstNameStartsWith);
			kparams.AddIfNotNull("lastNameStartsWith", this._LastNameStartsWith);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case IS_ADMIN_EQUAL:
					return "IsAdminEqual";
				case FIRST_NAME_STARTS_WITH:
					return "FirstNameStartsWith";
				case LAST_NAME_STARTS_WITH:
					return "LastNameStartsWith";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

