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
using Kaltura.Enums;
using Kaltura.Request;

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
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public UserType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public string ScreenNameLike
		{
			get { return _ScreenNameLike; }
			set 
			{ 
				_ScreenNameLike = value;
				OnPropertyChanged("ScreenNameLike");
			}
		}
		public string ScreenNameStartsWith
		{
			get { return _ScreenNameStartsWith; }
			set 
			{ 
				_ScreenNameStartsWith = value;
				OnPropertyChanged("ScreenNameStartsWith");
			}
		}
		public string EmailLike
		{
			get { return _EmailLike; }
			set 
			{ 
				_EmailLike = value;
				OnPropertyChanged("EmailLike");
			}
		}
		public string EmailStartsWith
		{
			get { return _EmailStartsWith; }
			set 
			{ 
				_EmailStartsWith = value;
				OnPropertyChanged("EmailStartsWith");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public UserStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public string FirstNameStartsWith
		{
			get { return _FirstNameStartsWith; }
			set 
			{ 
				_FirstNameStartsWith = value;
				OnPropertyChanged("FirstNameStartsWith");
			}
		}
		public string LastNameStartsWith
		{
			get { return _LastNameStartsWith; }
			set 
			{ 
				_LastNameStartsWith = value;
				OnPropertyChanged("LastNameStartsWith");
			}
		}
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

		public UserBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(txt);
						continue;
					case "typeEqual":
						this._TypeEqual = (UserType)ParseEnum(typeof(UserType), txt);
						continue;
					case "typeIn":
						this._TypeIn = txt;
						continue;
					case "screenNameLike":
						this._ScreenNameLike = txt;
						continue;
					case "screenNameStartsWith":
						this._ScreenNameStartsWith = txt;
						continue;
					case "emailLike":
						this._EmailLike = txt;
						continue;
					case "emailStartsWith":
						this._EmailStartsWith = txt;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (UserStatus)ParseEnum(typeof(UserStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "firstNameStartsWith":
						this._FirstNameStartsWith = txt;
						continue;
					case "lastNameStartsWith":
						this._LastNameStartsWith = txt;
						continue;
					case "isAdminEqual":
						this._IsAdminEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), txt);
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

