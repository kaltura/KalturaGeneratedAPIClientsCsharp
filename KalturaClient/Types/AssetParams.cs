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
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public NullableBoolean IsSystemDefault
		{
			get { return _IsSystemDefault; }
		}
		public string Tags
		{
			get { return _Tags; }
			set 
			{ 
				_Tags = value;
				OnPropertyChanged("Tags");
			}
		}
		public IList<String> RequiredPermissions
		{
			get { return _RequiredPermissions; }
			set 
			{ 
				_RequiredPermissions = value;
				OnPropertyChanged("RequiredPermissions");
			}
		}
		public int SourceRemoteStorageProfileId
		{
			get { return _SourceRemoteStorageProfileId; }
			set 
			{ 
				_SourceRemoteStorageProfileId = value;
				OnPropertyChanged("SourceRemoteStorageProfileId");
			}
		}
		public int RemoteStorageProfileIds
		{
			get { return _RemoteStorageProfileIds; }
			set 
			{ 
				_RemoteStorageProfileIds = value;
				OnPropertyChanged("RemoteStorageProfileIds");
			}
		}
		public MediaParserType MediaParserType
		{
			get { return _MediaParserType; }
			set 
			{ 
				_MediaParserType = value;
				OnPropertyChanged("MediaParserType");
			}
		}
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

		public AssetParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "isSystemDefault":
						this._IsSystemDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "requiredPermissions":
						this._RequiredPermissions = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._RequiredPermissions.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "sourceRemoteStorageProfileId":
						this._SourceRemoteStorageProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "remoteStorageProfileIds":
						this._RemoteStorageProfileIds = ParseInt(propertyNode.InnerText);
						continue;
					case "mediaParserType":
						this._MediaParserType = (MediaParserType)StringEnum.Parse(typeof(MediaParserType), propertyNode.InnerText);
						continue;
					case "sourceAssetParamsIds":
						this._SourceAssetParamsIds = propertyNode.InnerText;
						continue;
				}
			}
		}

		public AssetParams(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._IsSystemDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), data.TryGetValueSafe<int>("isSystemDefault"));
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._RequiredPermissions = new List<String>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("requiredPermissions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._RequiredPermissions.Add(ObjectFactory.Create<String>((IDictionary<string,object>)dataDictionary));
			    }
			    this._SourceRemoteStorageProfileId = data.TryGetValueSafe<int>("sourceRemoteStorageProfileId");
			    this._RemoteStorageProfileIds = data.TryGetValueSafe<int>("remoteStorageProfileIds");
			    this._MediaParserType = (MediaParserType)StringEnum.Parse(typeof(MediaParserType), data.TryGetValueSafe<string>("mediaParserType"));
			    this._SourceAssetParamsIds = data.TryGetValueSafe<string>("sourceAssetParamsIds");
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

