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
	public class BulkUploadResultCategoryUser : BulkUploadResult
	{
		#region Constants
		public const string CATEGORY_ID = "categoryId";
		public const string CATEGORY_REFERENCE_ID = "categoryReferenceId";
		public const string USER_ID = "userId";
		public const string PERMISSION_LEVEL = "permissionLevel";
		public const string UPDATE_METHOD = "updateMethod";
		public const string REQUIRED_OBJECT_STATUS = "requiredObjectStatus";
		#endregion

		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _CategoryReferenceId = null;
		private string _UserId = null;
		private int _PermissionLevel = Int32.MinValue;
		private int _UpdateMethod = Int32.MinValue;
		private int _RequiredObjectStatus = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		[JsonProperty]
		public string CategoryReferenceId
		{
			get { return _CategoryReferenceId; }
			set 
			{ 
				_CategoryReferenceId = value;
				OnPropertyChanged("CategoryReferenceId");
			}
		}
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
		[JsonProperty]
		public int PermissionLevel
		{
			get { return _PermissionLevel; }
			set 
			{ 
				_PermissionLevel = value;
				OnPropertyChanged("PermissionLevel");
			}
		}
		[JsonProperty]
		public int UpdateMethod
		{
			get { return _UpdateMethod; }
			set 
			{ 
				_UpdateMethod = value;
				OnPropertyChanged("UpdateMethod");
			}
		}
		[JsonProperty]
		public int RequiredObjectStatus
		{
			get { return _RequiredObjectStatus; }
			set 
			{ 
				_RequiredObjectStatus = value;
				OnPropertyChanged("RequiredObjectStatus");
			}
		}
		#endregion

		#region CTor
		public BulkUploadResultCategoryUser()
		{
		}

		public BulkUploadResultCategoryUser(JToken node) : base(node)
		{
			if(node["categoryId"] != null)
			{
				this._CategoryId = ParseInt(node["categoryId"].Value<string>());
			}
			if(node["categoryReferenceId"] != null)
			{
				this._CategoryReferenceId = node["categoryReferenceId"].Value<string>();
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["permissionLevel"] != null)
			{
				this._PermissionLevel = ParseInt(node["permissionLevel"].Value<string>());
			}
			if(node["updateMethod"] != null)
			{
				this._UpdateMethod = ParseInt(node["updateMethod"].Value<string>());
			}
			if(node["requiredObjectStatus"] != null)
			{
				this._RequiredObjectStatus = ParseInt(node["requiredObjectStatus"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBulkUploadResultCategoryUser");
			kparams.AddIfNotNull("categoryId", this._CategoryId);
			kparams.AddIfNotNull("categoryReferenceId", this._CategoryReferenceId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("permissionLevel", this._PermissionLevel);
			kparams.AddIfNotNull("updateMethod", this._UpdateMethod);
			kparams.AddIfNotNull("requiredObjectStatus", this._RequiredObjectStatus);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_ID:
					return "CategoryId";
				case CATEGORY_REFERENCE_ID:
					return "CategoryReferenceId";
				case USER_ID:
					return "UserId";
				case PERMISSION_LEVEL:
					return "PermissionLevel";
				case UPDATE_METHOD:
					return "UpdateMethod";
				case REQUIRED_OBJECT_STATUS:
					return "RequiredObjectStatus";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

