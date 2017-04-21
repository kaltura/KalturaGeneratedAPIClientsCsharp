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
	public class UserFilter : UserBaseFilter
	{
		#region Constants
		public const string ID_OR_SCREEN_NAME_STARTS_WITH = "idOrScreenNameStartsWith";
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string LOGIN_ENABLED_EQUAL = "loginEnabledEqual";
		public const string ROLE_ID_EQUAL = "roleIdEqual";
		public const string ROLE_IDS_EQUAL = "roleIdsEqual";
		public const string ROLE_IDS_IN = "roleIdsIn";
		public const string FIRST_NAME_OR_LAST_NAME_STARTS_WITH = "firstNameOrLastNameStartsWith";
		public const string PERMISSION_NAMES_MULTI_LIKE_OR = "permissionNamesMultiLikeOr";
		public const string PERMISSION_NAMES_MULTI_LIKE_AND = "permissionNamesMultiLikeAnd";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _IdOrScreenNameStartsWith = null;
		private string _IdEqual = null;
		private string _IdIn = null;
		private NullableBoolean _LoginEnabledEqual = (NullableBoolean)Int32.MinValue;
		private string _RoleIdEqual = null;
		private string _RoleIdsEqual = null;
		private string _RoleIdsIn = null;
		private string _FirstNameOrLastNameStartsWith = null;
		private string _PermissionNamesMultiLikeOr = null;
		private string _PermissionNamesMultiLikeAnd = null;
		private UserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string IdOrScreenNameStartsWith
		{
			get { return _IdOrScreenNameStartsWith; }
			set 
			{ 
				_IdOrScreenNameStartsWith = value;
				OnPropertyChanged("IdOrScreenNameStartsWith");
			}
		}
		public string IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public NullableBoolean LoginEnabledEqual
		{
			get { return _LoginEnabledEqual; }
			set 
			{ 
				_LoginEnabledEqual = value;
				OnPropertyChanged("LoginEnabledEqual");
			}
		}
		public string RoleIdEqual
		{
			get { return _RoleIdEqual; }
			set 
			{ 
				_RoleIdEqual = value;
				OnPropertyChanged("RoleIdEqual");
			}
		}
		public string RoleIdsEqual
		{
			get { return _RoleIdsEqual; }
			set 
			{ 
				_RoleIdsEqual = value;
				OnPropertyChanged("RoleIdsEqual");
			}
		}
		public string RoleIdsIn
		{
			get { return _RoleIdsIn; }
			set 
			{ 
				_RoleIdsIn = value;
				OnPropertyChanged("RoleIdsIn");
			}
		}
		public string FirstNameOrLastNameStartsWith
		{
			get { return _FirstNameOrLastNameStartsWith; }
			set 
			{ 
				_FirstNameOrLastNameStartsWith = value;
				OnPropertyChanged("FirstNameOrLastNameStartsWith");
			}
		}
		public string PermissionNamesMultiLikeOr
		{
			get { return _PermissionNamesMultiLikeOr; }
			set 
			{ 
				_PermissionNamesMultiLikeOr = value;
				OnPropertyChanged("PermissionNamesMultiLikeOr");
			}
		}
		public string PermissionNamesMultiLikeAnd
		{
			get { return _PermissionNamesMultiLikeAnd; }
			set 
			{ 
				_PermissionNamesMultiLikeAnd = value;
				OnPropertyChanged("PermissionNamesMultiLikeAnd");
			}
		}
		public new UserOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public UserFilter()
		{
		}

		public UserFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idOrScreenNameStartsWith":
						this._IdOrScreenNameStartsWith = propertyNode.InnerText;
						continue;
					case "idEqual":
						this._IdEqual = propertyNode.InnerText;
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "loginEnabledEqual":
						this._LoginEnabledEqual = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "roleIdEqual":
						this._RoleIdEqual = propertyNode.InnerText;
						continue;
					case "roleIdsEqual":
						this._RoleIdsEqual = propertyNode.InnerText;
						continue;
					case "roleIdsIn":
						this._RoleIdsIn = propertyNode.InnerText;
						continue;
					case "firstNameOrLastNameStartsWith":
						this._FirstNameOrLastNameStartsWith = propertyNode.InnerText;
						continue;
					case "permissionNamesMultiLikeOr":
						this._PermissionNamesMultiLikeOr = propertyNode.InnerText;
						continue;
					case "permissionNamesMultiLikeAnd":
						this._PermissionNamesMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = (UserOrderBy)StringEnum.Parse(typeof(UserOrderBy), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaUserFilter");
			kparams.AddIfNotNull("idOrScreenNameStartsWith", this._IdOrScreenNameStartsWith);
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("loginEnabledEqual", this._LoginEnabledEqual);
			kparams.AddIfNotNull("roleIdEqual", this._RoleIdEqual);
			kparams.AddIfNotNull("roleIdsEqual", this._RoleIdsEqual);
			kparams.AddIfNotNull("roleIdsIn", this._RoleIdsIn);
			kparams.AddIfNotNull("firstNameOrLastNameStartsWith", this._FirstNameOrLastNameStartsWith);
			kparams.AddIfNotNull("permissionNamesMultiLikeOr", this._PermissionNamesMultiLikeOr);
			kparams.AddIfNotNull("permissionNamesMultiLikeAnd", this._PermissionNamesMultiLikeAnd);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_OR_SCREEN_NAME_STARTS_WITH:
					return "IdOrScreenNameStartsWith";
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case LOGIN_ENABLED_EQUAL:
					return "LoginEnabledEqual";
				case ROLE_ID_EQUAL:
					return "RoleIdEqual";
				case ROLE_IDS_EQUAL:
					return "RoleIdsEqual";
				case ROLE_IDS_IN:
					return "RoleIdsIn";
				case FIRST_NAME_OR_LAST_NAME_STARTS_WITH:
					return "FirstNameOrLastNameStartsWith";
				case PERMISSION_NAMES_MULTI_LIKE_OR:
					return "PermissionNamesMultiLikeOr";
				case PERMISSION_NAMES_MULTI_LIKE_AND:
					return "PermissionNamesMultiLikeAnd";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

