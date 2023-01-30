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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class AssetParams : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string IS_SYSTEM_DEFAULT = "isSystemDefault";
		public const string TAGS = "tags";
		public const string REQUIRED_PERMISSIONS = "requiredPermissions";
		public const string SOURCE_REMOTE_STORAGE_PROFILE_ID = "sourceRemoteStorageProfileId";
		public const string REMOTE_STORAGE_PROFILE_IDS = "remoteStorageProfileIds";
		public const string MEDIA_PARSER_TYPE = "mediaParserType";
		public const string SOURCE_ASSET_PARAMS_IDS = "sourceAssetParamsIds";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private NullableBoolean _IsSystemDefault = (NullableBoolean)Int32.MinValue;
		private string _Tags = null;
		private IList<String> _RequiredPermissions;
		private int _SourceRemoteStorageProfileId = Int32.MinValue;
		private int _RemoteStorageProfileIds = Int32.MinValue;
		private MediaParserType _MediaParserType = null;
		private string _SourceAssetParamsIds = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use NameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use SystemNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use IsSystemDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsSystemDefault
		{
			get { return _IsSystemDefault; }
			private set 
			{ 
				_IsSystemDefault = value;
				OnPropertyChanged("IsSystemDefault");
			}
		}
		/// <summary>
		/// Use TagsAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use RequiredPermissionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<String> RequiredPermissions
		{
			get { return _RequiredPermissions; }
			set 
			{ 
				_RequiredPermissions = value;
				OnPropertyChanged("RequiredPermissions");
			}
		}
		/// <summary>
		/// Use SourceRemoteStorageProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SourceRemoteStorageProfileId
		{
			get { return _SourceRemoteStorageProfileId; }
			set 
			{ 
				_SourceRemoteStorageProfileId = value;
				OnPropertyChanged("SourceRemoteStorageProfileId");
			}
		}
		/// <summary>
		/// Use RemoteStorageProfileIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int RemoteStorageProfileIds
		{
			get { return _RemoteStorageProfileIds; }
			set 
			{ 
				_RemoteStorageProfileIds = value;
				OnPropertyChanged("RemoteStorageProfileIds");
			}
		}
		/// <summary>
		/// Use MediaParserTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
		/// <summary>
		/// Use SourceAssetParamsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SourceAssetParamsIds
		{
			get { return _SourceAssetParamsIds; }
			set 
			{ 
				_SourceAssetParamsIds = value;
				OnPropertyChanged("SourceAssetParamsIds");
			}
		}
		#endregion

		#region CTor
		public AssetParams()
		{
		}

		public AssetParams(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["isSystemDefault"] != null)
			{
				this._IsSystemDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isSystemDefault"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["requiredPermissions"] != null)
			{
				this._RequiredPermissions = new List<String>();
				foreach(var arrayNode in node["requiredPermissions"].Children())
				{
					this._RequiredPermissions.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["sourceRemoteStorageProfileId"] != null)
			{
				this._SourceRemoteStorageProfileId = ParseInt(node["sourceRemoteStorageProfileId"].Value<string>());
			}
			if(node["remoteStorageProfileIds"] != null)
			{
				this._RemoteStorageProfileIds = ParseInt(node["remoteStorageProfileIds"].Value<string>());
			}
			if(node["mediaParserType"] != null)
			{
				this._MediaParserType = (MediaParserType)StringEnum.Parse(typeof(MediaParserType), node["mediaParserType"].Value<string>());
			}
			if(node["sourceAssetParamsIds"] != null)
			{
				this._SourceAssetParamsIds = node["sourceAssetParamsIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetParams");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("isSystemDefault", this._IsSystemDefault);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("requiredPermissions", this._RequiredPermissions);
			kparams.AddIfNotNull("sourceRemoteStorageProfileId", this._SourceRemoteStorageProfileId);
			kparams.AddIfNotNull("remoteStorageProfileIds", this._RemoteStorageProfileIds);
			kparams.AddIfNotNull("mediaParserType", this._MediaParserType);
			kparams.AddIfNotNull("sourceAssetParamsIds", this._SourceAssetParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case IS_SYSTEM_DEFAULT:
					return "IsSystemDefault";
				case TAGS:
					return "Tags";
				case REQUIRED_PERMISSIONS:
					return "RequiredPermissions";
				case SOURCE_REMOTE_STORAGE_PROFILE_ID:
					return "SourceRemoteStorageProfileId";
				case REMOTE_STORAGE_PROFILE_IDS:
					return "RemoteStorageProfileIds";
				case MEDIA_PARSER_TYPE:
					return "MediaParserType";
				case SOURCE_ASSET_PARAMS_IDS:
					return "SourceAssetParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

