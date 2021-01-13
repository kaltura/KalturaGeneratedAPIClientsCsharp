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
	public class FileAsset : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string FILE_ASSET_OBJECT_TYPE = "fileAssetObjectType";
		public const string OBJECT_ID = "objectId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string FILE_EXT = "fileExt";
		public const string VERSION = "version";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private FileAssetObjectType _FileAssetObjectType = null;
		private string _ObjectId = null;
		private string _Name = null;
		private string _SystemName = null;
		private string _FileExt = null;
		private int _Version = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private FileAssetStatus _Status = null;
		#endregion

		#region Properties
		[JsonProperty]
		public long Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
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
		public FileAssetObjectType FileAssetObjectType
		{
			get { return _FileAssetObjectType; }
			set 
			{ 
				_FileAssetObjectType = value;
				OnPropertyChanged("FileAssetObjectType");
			}
		}
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
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
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
		[JsonProperty]
		public string FileExt
		{
			get { return _FileExt; }
			set 
			{ 
				_FileExt = value;
				OnPropertyChanged("FileExt");
			}
		}
		[JsonProperty]
		public int Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
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
		public FileAssetStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public FileAsset()
		{
		}

		public FileAsset(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["fileAssetObjectType"] != null)
			{
				this._FileAssetObjectType = (FileAssetObjectType)StringEnum.Parse(typeof(FileAssetObjectType), node["fileAssetObjectType"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
			}
			if(node["fileExt"] != null)
			{
				this._FileExt = node["fileExt"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (FileAssetStatus)StringEnum.Parse(typeof(FileAssetStatus), node["status"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFileAsset");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("fileAssetObjectType", this._FileAssetObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("fileExt", this._FileExt);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
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
				case FILE_ASSET_OBJECT_TYPE:
					return "FileAssetObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case FILE_EXT:
					return "FileExt";
				case VERSION:
					return "Version";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

