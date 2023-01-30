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
	public class Metadata : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string METADATA_PROFILE_VERSION = "metadataProfileVersion";
		public const string METADATA_OBJECT_TYPE = "metadataObjectType";
		public const string OBJECT_ID = "objectId";
		public const string VERSION = "version";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string XML = "xml";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _MetadataProfileId = Int32.MinValue;
		private int _MetadataProfileVersion = Int32.MinValue;
		private MetadataObjectType _MetadataObjectType = null;
		private string _ObjectId = null;
		private int _Version = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private MetadataStatus _Status = (MetadataStatus)Int32.MinValue;
		private string _Xml = null;
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
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use MetadataProfileIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			private set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		/// <summary>
		/// Use MetadataProfileVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MetadataProfileVersion
		{
			get { return _MetadataProfileVersion; }
			private set 
			{ 
				_MetadataProfileVersion = value;
				OnPropertyChanged("MetadataProfileVersion");
			}
		}
		/// <summary>
		/// Use MetadataObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
			private set 
			{ 
				_MetadataObjectType = value;
				OnPropertyChanged("MetadataObjectType");
			}
		}
		/// <summary>
		/// Use ObjectIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectId
		{
			get { return _ObjectId; }
			private set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
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
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use XmlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xml
		{
			get { return _Xml; }
			private set 
			{ 
				_Xml = value;
				OnPropertyChanged("Xml");
			}
		}
		#endregion

		#region CTor
		public Metadata()
		{
		}

		public Metadata(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["metadataProfileVersion"] != null)
			{
				this._MetadataProfileVersion = ParseInt(node["metadataProfileVersion"].Value<string>());
			}
			if(node["metadataObjectType"] != null)
			{
				this._MetadataObjectType = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), node["metadataObjectType"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
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
				this._Status = (MetadataStatus)ParseEnum(typeof(MetadataStatus), node["status"].Value<string>());
			}
			if(node["xml"] != null)
			{
				this._Xml = node["xml"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadata");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("metadataProfileVersion", this._MetadataProfileVersion);
			kparams.AddIfNotNull("metadataObjectType", this._MetadataObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("xml", this._Xml);
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
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case METADATA_PROFILE_VERSION:
					return "MetadataProfileVersion";
				case METADATA_OBJECT_TYPE:
					return "MetadataObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case VERSION:
					return "Version";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case XML:
					return "Xml";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

