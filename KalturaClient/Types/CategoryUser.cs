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
	public class CategoryUser : ObjectBase
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string USER_ID = "userId";
		public const string PARTNER_ID = "partnerId";
		public const string PERMISSION_LEVEL = "permissionLevel";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string UPDATE_METHOD = "updateMethod";
		public const string CATEGORY_FULL_IDS = "categoryFullIds";
		public const string PERMISSION_NAMES = "permissionNames";
		#endregion

		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _UserId = null;
		private int _PartnerId = Int32.MinValue;
		private CategoryUserPermissionLevel _PermissionLevel = (CategoryUserPermissionLevel)Int32.MinValue;
		private CategoryUserStatus _Status = (CategoryUserStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private UpdateMethodType _UpdateMethod = (UpdateMethodType)Int32.MinValue;
		private string _CategoryFullIds = null;
		private string _PermissionNames = null;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public CategoryUserPermissionLevel PermissionLevel
		{
			get { return _PermissionLevel; }
			set 
			{ 
				_PermissionLevel = value;
				OnPropertyChanged("PermissionLevel");
			}
		}
		public CategoryUserStatus Status
		{
			get { return _Status; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public UpdateMethodType UpdateMethod
		{
			get { return _UpdateMethod; }
			set 
			{ 
				_UpdateMethod = value;
				OnPropertyChanged("UpdateMethod");
			}
		}
		public string CategoryFullIds
		{
			get { return _CategoryFullIds; }
		}
		public string PermissionNames
		{
			get { return _PermissionNames; }
			set 
			{ 
				_PermissionNames = value;
				OnPropertyChanged("PermissionNames");
			}
		}
		#endregion

		#region CTor
		public CategoryUser()
		{
		}

		public CategoryUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "permissionLevel":
						this._PermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (CategoryUserStatus)ParseEnum(typeof(CategoryUserStatus), propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updateMethod":
						this._UpdateMethod = (UpdateMethodType)ParseEnum(typeof(UpdateMethodType), propertyNode.InnerText);
						continue;
					case "categoryFullIds":
						this._CategoryFullIds = propertyNode.InnerText;
						continue;
					case "permissionNames":
						this._PermissionNames = propertyNode.InnerText;
						continue;
				}
			}
		}

		public CategoryUser(IDictionary<string,object> data) : base(data)
		{
			    this._CategoryId = data.TryGetValueSafe<int>("categoryId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._PermissionLevel = (CategoryUserPermissionLevel)ParseEnum(typeof(CategoryUserPermissionLevel), data.TryGetValueSafe<int>("permissionLevel"));
			    this._Status = (CategoryUserStatus)ParseEnum(typeof(CategoryUserStatus), data.TryGetValueSafe<int>("status"));
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._UpdateMethod = (UpdateMethodType)ParseEnum(typeof(UpdateMethodType), data.TryGetValueSafe<int>("updateMethod"));
			    this._CategoryFullIds = data.TryGetValueSafe<string>("categoryFullIds");
			    this._PermissionNames = data.TryGetValueSafe<string>("permissionNames");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryUser");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("permissionLevel", this._PermissionLevel);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("updateMethod", this._UpdateMethod);
			kparams.AddIfNotNull("categoryFullIds", this._CategoryFullIds);
			kparams.AddIfNotNull("permissionNames", this._PermissionNames);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID:
					return "CategoryId";
				case USER_ID:
					return "UserId";
				case PARTNER_ID:
					return "PartnerId";
				case PERMISSION_LEVEL:
					return "PermissionLevel";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case UPDATE_METHOD:
					return "UpdateMethod";
				case CATEGORY_FULL_IDS:
					return "CategoryFullIds";
				case PERMISSION_NAMES:
					return "PermissionNames";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

