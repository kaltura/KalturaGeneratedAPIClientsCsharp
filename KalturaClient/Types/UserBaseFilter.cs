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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class UserBaseFilter : RelatedFilter
	{
		#region Constants
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string SCREEN_NAME_LIKE = "screenNameLike";
		public const string SCREEN_NAME_STARTS_WITH = "screenNameStartsWith";
		public const string EMAIL_LIKE = "emailLike";
		public const string EMAIL_STARTS_WITH = "emailStartsWith";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string FIRST_NAME_STARTS_WITH = "firstNameStartsWith";
		public const string LAST_NAME_STARTS_WITH = "lastNameStartsWith";
		public const string IS_ADMIN_EQUAL = "isAdminEqual";
		#endregion

		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private UserType _TypeEqual = (UserType)Int32.MinValue;
		private string _TypeIn = null;
		private string _ScreenNameLike = null;
		private string _ScreenNameStartsWith = null;
		private string _EmailLike = null;
		private string _EmailStartsWith = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private UserStatus _StatusEqual = (UserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private string _FirstNameStartsWith = null;
		private string _LastNameStartsWith = null;
		private NullableBoolean _IsAdminEqual = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
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
		public string ScreenNameLike
		{
			get { return _ScreenNameLike; }
			set 
			{ 
				_ScreenNameLike = value;
				OnPropertyChanged("ScreenNameLike");
			}
		}
		[JsonProperty]
		public string ScreenNameStartsWith
		{
			get { return _ScreenNameStartsWith; }
			set 
			{ 
				_ScreenNameStartsWith = value;
				OnPropertyChanged("ScreenNameStartsWith");
			}
		}
		[JsonProperty]
		public string EmailLike
		{
			get { return _EmailLike; }
			set 
			{ 
				_EmailLike = value;
				OnPropertyChanged("EmailLike");
			}
		}
		[JsonProperty]
		public string EmailStartsWith
		{
			get { return _EmailStartsWith; }
			set 
			{ 
				_EmailStartsWith = value;
				OnPropertyChanged("EmailStartsWith");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public UserStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
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
		#endregion

		#region CTor
		public UserBaseFilter()
		{
		}

		public UserBaseFilter(JToken node) : base(node)
		{
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (UserType)ParseEnum(typeof(UserType), node["typeEqual"].Value<string>());
			}
			if(node["typeIn"] != null)
			{
				this._TypeIn = node["typeIn"].Value<string>();
			}
			if(node["screenNameLike"] != null)
			{
				this._ScreenNameLike = node["screenNameLike"].Value<string>();
			}
			if(node["screenNameStartsWith"] != null)
			{
				this._ScreenNameStartsWith = node["screenNameStartsWith"].Value<string>();
			}
			if(node["emailLike"] != null)
			{
				this._EmailLike = node["emailLike"].Value<string>();
			}
			if(node["emailStartsWith"] != null)
			{
				this._EmailStartsWith = node["emailStartsWith"].Value<string>();
			}
			if(node["tagsMultiLikeOr"] != null)
			{
				this._TagsMultiLikeOr = node["tagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsMultiLikeAnd"] != null)
			{
				this._TagsMultiLikeAnd = node["tagsMultiLikeAnd"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (UserStatus)ParseEnum(typeof(UserStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["firstNameStartsWith"] != null)
			{
				this._FirstNameStartsWith = node["firstNameStartsWith"].Value<string>();
			}
			if(node["lastNameStartsWith"] != null)
			{
				this._LastNameStartsWith = node["lastNameStartsWith"].Value<string>();
			}
			if(node["isAdminEqual"] != null)
			{
				this._IsAdminEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isAdminEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("screenNameLike", this._ScreenNameLike);
			kparams.AddIfNotNull("screenNameStartsWith", this._ScreenNameStartsWith);
			kparams.AddIfNotNull("emailLike", this._EmailLike);
			kparams.AddIfNotNull("emailStartsWith", this._EmailStartsWith);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("firstNameStartsWith", this._FirstNameStartsWith);
			kparams.AddIfNotNull("lastNameStartsWith", this._LastNameStartsWith);
			kparams.AddIfNotNull("isAdminEqual", this._IsAdminEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case SCREEN_NAME_LIKE:
					return "ScreenNameLike";
				case SCREEN_NAME_STARTS_WITH:
					return "ScreenNameStartsWith";
				case EMAIL_LIKE:
					return "EmailLike";
				case EMAIL_STARTS_WITH:
					return "EmailStartsWith";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case FIRST_NAME_STARTS_WITH:
					return "FirstNameStartsWith";
				case LAST_NAME_STARTS_WITH:
					return "LastNameStartsWith";
				case IS_ADMIN_EQUAL:
					return "IsAdminEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

