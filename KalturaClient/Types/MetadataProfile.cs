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
	public class MetadataProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string METADATA_OBJECT_TYPE = "metadataObjectType";
		public const string VERSION = "version";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string XSD = "xsd";
		public const string VIEWS = "views";
		public const string XSLT = "xslt";
		public const string CREATE_MODE = "createMode";
		public const string DISABLE_RE_INDEXING = "disableReIndexing";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private MetadataObjectType _MetadataObjectType = null;
		private int _Version = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private MetadataProfileStatus _Status = (MetadataProfileStatus)Int32.MinValue;
		private string _Xsd = null;
		private string _Views = null;
		private string _Xslt = null;
		private MetadataProfileCreateMode _CreateMode = (MetadataProfileCreateMode)Int32.MinValue;
		private bool? _DisableReIndexing = null;
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
		/// Use MetadataObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataObjectType MetadataObjectType
		{
			get { return _MetadataObjectType; }
			set 
			{ 
				_MetadataObjectType = value;
				OnPropertyChanged("MetadataObjectType");
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
		public MetadataProfileStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use XsdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xsd
		{
			get { return _Xsd; }
			private set 
			{ 
				_Xsd = value;
				OnPropertyChanged("Xsd");
			}
		}
		/// <summary>
		/// Use ViewsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Views
		{
			get { return _Views; }
			private set 
			{ 
				_Views = value;
				OnPropertyChanged("Views");
			}
		}
		/// <summary>
		/// Use XsltAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Xslt
		{
			get { return _Xslt; }
			private set 
			{ 
				_Xslt = value;
				OnPropertyChanged("Xslt");
			}
		}
		/// <summary>
		/// Use CreateModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public MetadataProfileCreateMode CreateMode
		{
			get { return _CreateMode; }
			set 
			{ 
				_CreateMode = value;
				OnPropertyChanged("CreateMode");
			}
		}
		/// <summary>
		/// Use DisableReIndexingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? DisableReIndexing
		{
			get { return _DisableReIndexing; }
			set 
			{ 
				_DisableReIndexing = value;
				OnPropertyChanged("DisableReIndexing");
			}
		}
		#endregion

		#region CTor
		public MetadataProfile()
		{
		}

		public MetadataProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["metadataObjectType"] != null)
			{
				this._MetadataObjectType = (MetadataObjectType)StringEnum.Parse(typeof(MetadataObjectType), node["metadataObjectType"].Value<string>());
			}
			if(node["version"] != null)
			{
				this._Version = ParseInt(node["version"].Value<string>());
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
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (MetadataProfileStatus)ParseEnum(typeof(MetadataProfileStatus), node["status"].Value<string>());
			}
			if(node["xsd"] != null)
			{
				this._Xsd = node["xsd"].Value<string>();
			}
			if(node["views"] != null)
			{
				this._Views = node["views"].Value<string>();
			}
			if(node["xslt"] != null)
			{
				this._Xslt = node["xslt"].Value<string>();
			}
			if(node["createMode"] != null)
			{
				this._CreateMode = (MetadataProfileCreateMode)ParseEnum(typeof(MetadataProfileCreateMode), node["createMode"].Value<string>());
			}
			if(node["disableReIndexing"] != null)
			{
				this._DisableReIndexing = ParseBool(node["disableReIndexing"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetadataProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("metadataObjectType", this._MetadataObjectType);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("xsd", this._Xsd);
			kparams.AddIfNotNull("views", this._Views);
			kparams.AddIfNotNull("xslt", this._Xslt);
			kparams.AddIfNotNull("createMode", this._CreateMode);
			kparams.AddIfNotNull("disableReIndexing", this._DisableReIndexing);
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
				case METADATA_OBJECT_TYPE:
					return "MetadataObjectType";
				case VERSION:
					return "Version";
				case NAME:
					return "Name";
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case XSD:
					return "Xsd";
				case VIEWS:
					return "Views";
				case XSLT:
					return "Xslt";
				case CREATE_MODE:
					return "CreateMode";
				case DISABLE_RE_INDEXING:
					return "DisableReIndexing";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

