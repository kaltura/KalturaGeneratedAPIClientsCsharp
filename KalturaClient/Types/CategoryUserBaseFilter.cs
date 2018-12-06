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
		public int CategoryIdEqual
		{
			get { return _CategoryIdEqual; }
			set 
			{ 
				_CategoryIdEqual = value;
				OnPropertyChanged("CategoryIdEqual");
			}
		}
		public string CategoryIdIn
		{
			get { return _CategoryIdIn; }
			set 
			{ 
				_CategoryIdIn = value;
				OnPropertyChanged("CategoryIdIn");
			}
		}
		public string UserIdEqual
		{
			get { return _UserIdEqual; }
			set 
			{ 
				_UserIdEqual = value;
				OnPropertyChanged("UserIdEqual");
			}
		}
		public string UserIdIn
		{
			get { return _UserIdIn; }
			set 
			{ 
				_UserIdIn = value;
				OnPropertyChanged("UserIdIn");
			}
		}
		public CategoryUserPermissionLevel PermissionLevelEqual
		{
			get { return _PermissionLevelEqual; }
			set 
			{ 
				_PermissionLevelEqual = value;
				OnPropertyChanged("PermissionLevelEqual");
			}
		}
		public string PermissionLevelIn
		{
			get { return _PermissionLevelIn; }
			set 
			{ 
				_PermissionLevelIn = value;
				OnPropertyChanged("PermissionLevelIn");
			}
		}
		public CategoryUserStatus StatusEqual
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
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public UpdateMethodType UpdateMethodEqual
		{
			get { return _UpdateMethodEqual; }
			set 
			{ 
				_UpdateMethodEqual = value;
				OnPropertyChanged("UpdateMethodEqual");
			}
		}
		public string UpdateMethodIn
		{
			get { return _UpdateMethodIn; }
			set 
			{ 
				_UpdateMethodIn = value;
				OnPropertyChanged("UpdateMethodIn");
			}
		}
		public string CategoryFullIdsStartsWith
		{
			get { return _CategoryFullIdsStartsWith; }
			set 
			{ 
				_CategoryFullIdsStartsWith = value;
				OnPropertyChanged("CategoryFullIdsStartsWith");
			}
		}
		public string CategoryFullIdsEqual
		{
			get { return _CategoryFullIdsEqual; }
			set 
			{ 
				_CategoryFullIdsEqual = value;
				OnPropertyChanged("CategoryFullIdsEqual");
			}
		}
		public string PermissionNamesMatchAnd
		{
			get { return _PermissionNamesMatchAnd; }
			set 
			{ 
				_PermissionNamesMatchAnd = value;
				OnPropertyChanged("PermissionNamesMatchAnd");
			}
		}
		public string PermissionNamesMatchOr
		{
			get { return _PermissionNamesMatchOr; }
			set 
			{ 
				_PermissionNamesMatchOr = value;
				OnPropertyChanged("PermissionNamesMatchOr");
			}
		}
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

		public CategoryUserBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "categoryIdEqual":
						this._CategoryIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "categoryIdIn":
						this._CategoryIdIn = propertyNode.InnerText;
						continue;
					case "userIdEqual":
						this._UserIdEqual = propertyNode.InnerText;
						continue;
					case "userIdIn":
						this._UserIdIn = propertyNode.InnerText;
						continue;
					case "permissionLevelEqual":
						this._PermissionLevelEqual = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), propertyNode.InnerText);
						continue;
					case "permissionLevelIn":
						this._PermissionLevelIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (CategoryUserStatus)ParseEnum(typeof(CategoryUserStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updateMethodEqual":
						this._UpdateMethodEqual = (UpdateMethodType)ParseEnum(typeof(UpdateMethodType), propertyNode.InnerText);
						continue;
					case "updateMethodIn":
						this._UpdateMethodIn = propertyNode.InnerText;
						continue;
					case "categoryFullIdsStartsWith":
						this._CategoryFullIdsStartsWith = propertyNode.InnerText;
						continue;
					case "categoryFullIdsEqual":
						this._CategoryFullIdsEqual = propertyNode.InnerText;
						continue;
					case "permissionNamesMatchAnd":
						this._PermissionNamesMatchAnd = propertyNode.InnerText;
						continue;
					case "permissionNamesMatchOr":
						this._PermissionNamesMatchOr = propertyNode.InnerText;
						continue;
					case "permissionNamesNotContains":
						this._PermissionNamesNotContains = propertyNode.InnerText;
						continue;
				}
			}
		}

		public CategoryUserBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._CategoryIdEqual = data.TryGetValueSafe<int>("categoryIdEqual");
			    this._CategoryIdIn = data.TryGetValueSafe<string>("categoryIdIn");
			    this._UserIdEqual = data.TryGetValueSafe<string>("userIdEqual");
			    this._UserIdIn = data.TryGetValueSafe<string>("userIdIn");
			    this._PermissionLevelEqual = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), data.TryGetValueSafe<int>("permissionLevelEqual"));
			    this._PermissionLevelIn = data.TryGetValueSafe<string>("permissionLevelIn");
			    this._StatusEqual = (CategoryUserStatus)ParseEnum(typeof(CategoryUserStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._CreatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("createdAtGreaterThanOrEqual");
			    this._CreatedAtLessThanOrEqual = data.TryGetValueSafe<int>("createdAtLessThanOrEqual");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<int>("updatedAtLessThanOrEqual");
			    this._UpdateMethodEqual = (UpdateMethodType)ParseEnum(typeof(UpdateMethodType), data.TryGetValueSafe<int>("updateMethodEqual"));
			    this._UpdateMethodIn = data.TryGetValueSafe<string>("updateMethodIn");
			    this._CategoryFullIdsStartsWith = data.TryGetValueSafe<string>("categoryFullIdsStartsWith");
			    this._CategoryFullIdsEqual = data.TryGetValueSafe<string>("categoryFullIdsEqual");
			    this._PermissionNamesMatchAnd = data.TryGetValueSafe<string>("permissionNamesMatchAnd");
			    this._PermissionNamesMatchOr = data.TryGetValueSafe<string>("permissionNamesMatchOr");
			    this._PermissionNamesNotContains = data.TryGetValueSafe<string>("permissionNamesNotContains");
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

