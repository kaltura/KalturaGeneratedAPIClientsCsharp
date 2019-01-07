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
	public class Permission : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TYPE = "type";
		public const string NAME = "name";
		public const string FRIENDLY_NAME = "friendlyName";
		public const string DESCRIPTION = "description";
		public const string STATUS = "status";
		public const string PARTNER_ID = "partnerId";
		public const string DEPENDS_ON_PERMISSION_NAMES = "dependsOnPermissionNames";
		public const string TAGS = "tags";
		public const string PERMISSION_ITEMS_IDS = "permissionItemsIds";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string PARTNER_GROUP = "partnerGroup";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private PermissionType _Type = (PermissionType)Int32.MinValue;
		private string _Name = null;
		private string _FriendlyName = null;
		private string _Description = null;
		private PermissionStatus _Status = (PermissionStatus)Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _DependsOnPermissionNames = null;
		private string _Tags = null;
		private string _PermissionItemsIds = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _PartnerGroup = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		[JsonProperty]
		public PermissionType Type
		{
			get { return _Type; }
			private set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public string FriendlyName
		{
			get { return _FriendlyName; }
			set 
			{ 
				_FriendlyName = value;
				OnPropertyChanged("FriendlyName");
			}
		}
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
		[JsonProperty]
		public PermissionStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		[JsonProperty]
		public string DependsOnPermissionNames
		{
			get { return _DependsOnPermissionNames; }
			set 
			{ 
				_DependsOnPermissionNames = value;
				OnPropertyChanged("DependsOnPermissionNames");
			}
		}
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
		[JsonProperty]
		public string PermissionItemsIds
		{
			get { return _PermissionItemsIds; }
			set 
			{ 
				_PermissionItemsIds = value;
				OnPropertyChanged("PermissionItemsIds");
			}
		}
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		[JsonProperty]
		public string PartnerGroup
		{
			get { return _PartnerGroup; }
			set 
			{ 
				_PartnerGroup = value;
				OnPropertyChanged("PartnerGroup");
			}
		}
		#endregion

		#region CTor
		public Permission()
		{
		}

		public Permission(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (PermissionType)ParseEnum(typeof(PermissionType), node["type"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["friendlyName"] != null)
			{
				this._FriendlyName = node["friendlyName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (PermissionStatus)ParseEnum(typeof(PermissionStatus), node["status"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["dependsOnPermissionNames"] != null)
			{
				this._DependsOnPermissionNames = node["dependsOnPermissionNames"].Value<string>();
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["permissionItemsIds"] != null)
			{
				this._PermissionItemsIds = node["permissionItemsIds"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["partnerGroup"] != null)
			{
				this._PartnerGroup = node["partnerGroup"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPermission");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("friendlyName", this._FriendlyName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("dependsOnPermissionNames", this._DependsOnPermissionNames);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("permissionItemsIds", this._PermissionItemsIds);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("partnerGroup", this._PartnerGroup);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TYPE:
					return "Type";
				case NAME:
					return "Name";
				case FRIENDLY_NAME:
					return "FriendlyName";
				case DESCRIPTION:
					return "Description";
				case STATUS:
					return "Status";
				case PARTNER_ID:
					return "PartnerId";
				case DEPENDS_ON_PERMISSION_NAMES:
					return "DependsOnPermissionNames";
				case TAGS:
					return "Tags";
				case PERMISSION_ITEMS_IDS:
					return "PermissionItemsIds";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case PARTNER_GROUP:
					return "PartnerGroup";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

