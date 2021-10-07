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
	public class Asset : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string ENTRY_ID = "entryId";
		public const string PARTNER_ID = "partnerId";
		public const string VERSION = "version";
		public const string SIZE = "size";
		public const string TAGS = "tags";
		public const string FILE_EXT = "fileExt";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string DELETED_AT = "deletedAt";
		public const string DESCRIPTION = "description";
		public const string PARTNER_DATA = "partnerData";
		public const string PARTNER_DESCRIPTION = "partnerDescription";
		public const string ACTUAL_SOURCE_ASSET_PARAMS_IDS = "actualSourceAssetParamsIds";
		public const string SIZE_IN_BYTES = "sizeInBytes";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _EntryId = null;
		private int _PartnerId = Int32.MinValue;
		private int _Version = Int32.MinValue;
		private int _Size = Int32.MinValue;
		private string _Tags = null;
		private string _FileExt = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _DeletedAt = Int32.MinValue;
		private string _Description = null;
		private string _PartnerData = null;
		private string _PartnerDescription = null;
		private string _ActualSourceAssetParamsIds = null;
		private long _SizeInBytes = long.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			private set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use SizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Size
		{
			get { return _Size; }
			private set 
			{ 
				_Size = value;
				OnPropertyChanged("Size");
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
		/// Use FileExtAsDouble property instead
		/// </summary>
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
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use DeletedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DeletedAt
		{
			get { return _DeletedAt; }
			private set 
			{ 
				_DeletedAt = value;
				OnPropertyChanged("DeletedAt");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			private set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use PartnerDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerData
		{
			get { return _PartnerData; }
			set 
			{ 
				_PartnerData = value;
				OnPropertyChanged("PartnerData");
			}
		}
		/// <summary>
		/// Use PartnerDescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerDescription
		{
			get { return _PartnerDescription; }
			set 
			{ 
				_PartnerDescription = value;
				OnPropertyChanged("PartnerDescription");
			}
		}
		/// <summary>
		/// Use ActualSourceAssetParamsIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActualSourceAssetParamsIds
		{
			get { return _ActualSourceAssetParamsIds; }
			set 
			{ 
				_ActualSourceAssetParamsIds = value;
				OnPropertyChanged("ActualSourceAssetParamsIds");
			}
		}
		/// <summary>
		/// Use SizeInBytesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public long SizeInBytes
		{
			get { return _SizeInBytes; }
			private set 
			{ 
				_SizeInBytes = value;
				OnPropertyChanged("SizeInBytes");
			}
		}
		#endregion

		#region CTor
		public Asset()
		{
		}

		public Asset(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = node["id"].Value<string>();
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
			}
			if(node["size"] != null)
			{
				this._Size = ParseInt(node["size"].Value<string>());
			}
			if(node["tags"] != null)
			{
				this._Tags = node["tags"].Value<string>();
			}
			if(node["fileExt"] != null)
			{
				this._FileExt = node["fileExt"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["deletedAt"] != null)
			{
				this._DeletedAt = ParseInt(node["deletedAt"].Value<string>());
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["partnerData"] != null)
			{
				this._PartnerData = node["partnerData"].Value<string>();
			}
			if(node["partnerDescription"] != null)
			{
				this._PartnerDescription = node["partnerDescription"].Value<string>();
			}
			if(node["actualSourceAssetParamsIds"] != null)
			{
				this._ActualSourceAssetParamsIds = node["actualSourceAssetParamsIds"].Value<string>();
			}
			if(node["sizeInBytes"] != null)
			{
				this._SizeInBytes = ParseLong(node["sizeInBytes"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAsset");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("size", this._Size);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("fileExt", this._FileExt);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("deletedAt", this._DeletedAt);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("partnerData", this._PartnerData);
			kparams.AddIfNotNull("partnerDescription", this._PartnerDescription);
			kparams.AddIfNotNull("actualSourceAssetParamsIds", this._ActualSourceAssetParamsIds);
			kparams.AddIfNotNull("sizeInBytes", this._SizeInBytes);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case ENTRY_ID:
					return "EntryId";
				case PARTNER_ID:
					return "PartnerId";
				case VERSION:
					return "Version";
				case SIZE:
					return "Size";
				case TAGS:
					return "Tags";
				case FILE_EXT:
					return "FileExt";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case DELETED_AT:
					return "DeletedAt";
				case DESCRIPTION:
					return "Description";
				case PARTNER_DATA:
					return "PartnerData";
				case PARTNER_DESCRIPTION:
					return "PartnerDescription";
				case ACTUAL_SOURCE_ASSET_PARAMS_IDS:
					return "ActualSourceAssetParamsIds";
				case SIZE_IN_BYTES:
					return "SizeInBytes";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

