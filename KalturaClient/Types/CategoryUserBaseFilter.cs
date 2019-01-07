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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class CategoryUserBaseFilter : RelatedFilter
	{
		#region Constants
		public const string CATEGORY_ID_EQUAL = "categoryIdEqual";
		public const string CATEGORY_ID_IN = "categoryIdIn";
		public const string USER_ID_EQUAL = "userIdEqual";
		public const string USER_ID_IN = "userIdIn";
		public const string PERMISSION_LEVEL_EQUAL = "permissionLevelEqual";
		public const string PERMISSION_LEVEL_IN = "permissionLevelIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string UPDATE_METHOD_EQUAL = "updateMethodEqual";
		public const string UPDATE_METHOD_IN = "updateMethodIn";
		public const string CATEGORY_FULL_IDS_STARTS_WITH = "categoryFullIdsStartsWith";
		public const string CATEGORY_FULL_IDS_EQUAL = "categoryFullIdsEqual";
		public const string PERMISSION_NAMES_MATCH_AND = "permissionNamesMatchAnd";
		public const string PERMISSION_NAMES_MATCH_OR = "permissionNamesMatchOr";
		public const string PERMISSION_NAMES_NOT_CONTAINS = "permissionNamesNotContains";
		#endregion

		#region Private Fields
		private int _CategoryIdEqual = Int32.MinValue;
		private string _CategoryIdIn = null;
		private string _UserIdEqual = null;
		private string _UserIdIn = null;
		private CategoryUserPermissionLevel _PermissionLevelEqual = (CategoryUserPermissionLevel)Int32.MinValue;
		private string _PermissionLevelIn = null;
		private CategoryUserStatus _StatusEqual = (CategoryUserStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private UpdateMethodType _UpdateMethodEqual = (UpdateMethodType)Int32.MinValue;
		private string _UpdateMethodIn = null;
		private string _CategoryFullIdsStartsWith = null;
		private string _CategoryFullIdsEqual = null;
		private string _PermissionNamesMatchAnd = null;
		private string _PermissionNamesMatchOr = null;
		private string _PermissionNamesNotContains = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int CategoryIdEqual
		{
			get { return _CategoryIdEqual; }
			set 
			{ 
				_CategoryIdEqual = value;
				OnPropertyChanged("CategoryIdEqual");
			}
		}
		[JsonProperty]
		public string CategoryIdIn
		{
			get { return _CategoryIdIn; }
			set 
			{ 
				_CategoryIdIn = value;
				OnPropertyChanged("CategoryIdIn");
			}
		}
		[JsonProperty]
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		[JsonProperty]
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		[JsonProperty]
		public CategoryUserPermissionLevel PermissionLevelEqual
		{
			get { return _PermissionLevelEqual; }
			set 
			{ 
				_PermissionLevelEqual = value;
				OnPropertyChanged("PermissionLevelEqual");
			}
		}
		[JsonProperty]
		public string PermissionLevelIn
		{
			get { return _PermissionLevelIn; }
			set 
			{ 
				_PermissionLevelIn = value;
				OnPropertyChanged("PermissionLevelIn");
			}
		}
		[JsonProperty]
		public CategoryUserStatus StatusEqual
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
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public UpdateMethodType UpdateMethodEqual
		{
			get { return _UpdateMethodEqual; }
			set 
			{ 
				_UpdateMethodEqual = value;
				OnPropertyChanged("UpdateMethodEqual");
			}
		}
		[JsonProperty]
		public string UpdateMethodIn
		{
			get { return _UpdateMethodIn; }
			set 
			{ 
				_UpdateMethodIn = value;
				OnPropertyChanged("UpdateMethodIn");
			}
		}
		[JsonProperty]
		public string CategoryFullIdsStartsWith
		{
			get { return _CategoryFullIdsStartsWith; }
			set 
			{ 
				_CategoryFullIdsStartsWith = value;
				OnPropertyChanged("CategoryFullIdsStartsWith");
			}
		}
		[JsonProperty]
		public string CategoryFullIdsEqual
		{
			get { return _CategoryFullIdsEqual; }
			set 
			{ 
				_CategoryFullIdsEqual = value;
				OnPropertyChanged("CategoryFullIdsEqual");
			}
		}
		[JsonProperty]
		public string PermissionNamesMatchAnd
		{
			get { return _PermissionNamesMatchAnd; }
			set 
			{ 
				_PermissionNamesMatchAnd = value;
				OnPropertyChanged("PermissionNamesMatchAnd");
			}
		}
		[JsonProperty]
		public string PermissionNamesMatchOr
		{
			get { return _PermissionNamesMatchOr; }
			set 
			{ 
				_PermissionNamesMatchOr = value;
				OnPropertyChanged("PermissionNamesMatchOr");
			}
		}
		[JsonProperty]
		public string PermissionNamesNotContains
		{
			get { return _PermissionNamesNotContains; }
			set 
			{ 
				_PermissionNamesNotContains = value;
				OnPropertyChanged("PermissionNamesNotContains");
			}
		}
		#endregion

		#region CTor
		public CategoryUserBaseFilter()
		{
		}

		public CategoryUserBaseFilter(JToken node) : base(node)
		{
			if(node["categoryIdEqual"] != null)
			{
				this._CategoryIdEqual = ParseInt(node["categoryIdEqual"].Value<string>());
			}
			if(node["categoryIdIn"] != null)
			{
				this._CategoryIdIn = node["categoryIdIn"].Value<string>();
			}
			if(node["userIdEqual"] != null)
			{
				this._UserIdEqual = node["userIdEqual"].Value<string>();
			}
			if(node["userIdIn"] != null)
			{
				this._UserIdIn = node["userIdIn"].Value<string>();
			}
			if(node["permissionLevelEqual"] != null)
			{
				this._PermissionLevelEqual = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), node["permissionLevelEqual"].Value<string>());
			}
			if(node["permissionLevelIn"] != null)
			{
				this._PermissionLevelIn = node["permissionLevelIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (CategoryUserStatus)ParseEnum(typeof(CategoryUserStatus), node["statusEqual"].Value<string>());
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
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["updateMethodEqual"] != null)
			{
				this._UpdateMethodEqual = (UpdateMethodType)ParseEnum(typeof(UpdateMethodType), node["updateMethodEqual"].Value<string>());
			}
			if(node["updateMethodIn"] != null)
			{
				this._UpdateMethodIn = node["updateMethodIn"].Value<string>();
			}
			if(node["categoryFullIdsStartsWith"] != null)
			{
				this._CategoryFullIdsStartsWith = node["categoryFullIdsStartsWith"].Value<string>();
			}
			if(node["categoryFullIdsEqual"] != null)
			{
				this._CategoryFullIdsEqual = node["categoryFullIdsEqual"].Value<string>();
			}
			if(node["permissionNamesMatchAnd"] != null)
			{
				this._PermissionNamesMatchAnd = node["permissionNamesMatchAnd"].Value<string>();
			}
			if(node["permissionNamesMatchOr"] != null)
			{
				this._PermissionNamesMatchOr = node["permissionNamesMatchOr"].Value<string>();
			}
			if(node["permissionNamesNotContains"] != null)
			{
				this._PermissionNamesNotContains = node["permissionNamesNotContains"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryUserBaseFilter");
			kparams.AddIfNotNull("categoryIdEqual", this._CategoryIdEqual);
			kparams.AddIfNotNull("categoryIdIn", this._CategoryIdIn);
			kparams.AddIfNotNull("userIdEqual", this._UserIdEqual);
			kparams.AddIfNotNull("userIdIn", this._UserIdIn);
			kparams.AddIfNotNull("permissionLevelEqual", this._PermissionLevelEqual);
			kparams.AddIfNotNull("permissionLevelIn", this._PermissionLevelIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updateMethodEqual", this._UpdateMethodEqual);
			kparams.AddIfNotNull("updateMethodIn", this._UpdateMethodIn);
			kparams.AddIfNotNull("categoryFullIdsStartsWith", this._CategoryFullIdsStartsWith);
			kparams.AddIfNotNull("categoryFullIdsEqual", this._CategoryFullIdsEqual);
			kparams.AddIfNotNull("permissionNamesMatchAnd", this._PermissionNamesMatchAnd);
			kparams.AddIfNotNull("permissionNamesMatchOr", this._PermissionNamesMatchOr);
			kparams.AddIfNotNull("permissionNamesNotContains", this._PermissionNamesNotContains);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID_EQUAL:
					return "CategoryIdEqual";
				case CATEGORY_ID_IN:
					return "CategoryIdIn";
				case USER_ID_EQUAL:
					return "UserIdEqual";
				case USER_ID_IN:
					return "UserIdIn";
				case PERMISSION_LEVEL_EQUAL:
					return "PermissionLevelEqual";
				case PERMISSION_LEVEL_IN:
					return "PermissionLevelIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case UPDATE_METHOD_EQUAL:
					return "UpdateMethodEqual";
				case UPDATE_METHOD_IN:
					return "UpdateMethodIn";
				case CATEGORY_FULL_IDS_STARTS_WITH:
					return "CategoryFullIdsStartsWith";
				case CATEGORY_FULL_IDS_EQUAL:
					return "CategoryFullIdsEqual";
				case PERMISSION_NAMES_MATCH_AND:
					return "PermissionNamesMatchAnd";
				case PERMISSION_NAMES_MATCH_OR:
					return "PermissionNamesMatchOr";
				case PERMISSION_NAMES_NOT_CONTAINS:
					return "PermissionNamesNotContains";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

