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
	public class DropFolder : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string TYPE = "type";
		public const string STATUS = "status";
		public const string CONVERSION_PROFILE_ID = "conversionProfileId";
		public const string DC = "dc";
		public const string PATH = "path";
		public const string FILE_SIZE_CHECK_INTERVAL = "fileSizeCheckInterval";
		public const string FILE_DELETE_POLICY = "fileDeletePolicy";
		public const string AUTO_FILE_DELETE_DAYS = "autoFileDeleteDays";
		public const string FILE_HANDLER_TYPE = "fileHandlerType";
		public const string FILE_NAME_PATTERNS = "fileNamePatterns";
		public const string FILE_HANDLER_CONFIG = "fileHandlerConfig";
		public const string TAGS = "tags";
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_DESCRIPTION = "errorDescription";
		public const string IGNORE_FILE_NAME_PATTERNS = "ignoreFileNamePatterns";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string LAST_ACCESSED_AT = "lastAccessedAt";
		public const string INCREMENTAL = "incremental";
		public const string LAST_FILE_TIMESTAMP = "lastFileTimestamp";
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string CATEGORIES_METADATA_FIELD_NAME = "categoriesMetadataFieldName";
		public const string ENFORCE_ENTITLEMENT = "enforceEntitlement";
		public const string SHOULD_VALIDATE_KS = "shouldValidateKS";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private DropFolderType _Type = null;
		private DropFolderStatus _Status = (DropFolderStatus)Int32.MinValue;
		private int _ConversionProfileId = Int32.MinValue;
		private int _Dc = Int32.MinValue;
		private string _Path = null;
		private int _FileSizeCheckInterval = Int32.MinValue;
		private DropFolderFileDeletePolicy _FileDeletePolicy = (DropFolderFileDeletePolicy)Int32.MinValue;
		private int _AutoFileDeleteDays = Int32.MinValue;
		private DropFolderFileHandlerType _FileHandlerType = null;
		private string _FileNamePatterns = null;
		private DropFolderFileHandlerConfig _FileHandlerConfig;
		private string _Tags = null;
		private DropFolderErrorCode _ErrorCode = null;
		private string _ErrorDescription = null;
		private string _IgnoreFileNamePatterns = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _LastAccessedAt = Int32.MinValue;
		private bool? _Incremental = null;
		private int _LastFileTimestamp = Int32.MinValue;
		private int _MetadataProfileId = Int32.MinValue;
		private string _CategoriesMetadataFieldName = null;
		private bool? _EnforceEntitlement = null;
		private bool? _ShouldValidateKS = null;
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
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public DropFolderType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public DropFolderStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public int ConversionProfileId
		{
			get { return _ConversionProfileId; }
			set 
			{ 
				_ConversionProfileId = value;
				OnPropertyChanged("ConversionProfileId");
			}
		}
		public int Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public string Path
		{
			get { return _Path; }
			set 
			{ 
				_Path = value;
				OnPropertyChanged("Path");
			}
		}
		public int FileSizeCheckInterval
		{
			get { return _FileSizeCheckInterval; }
			set 
			{ 
				_FileSizeCheckInterval = value;
				OnPropertyChanged("FileSizeCheckInterval");
			}
		}
		public DropFolderFileDeletePolicy FileDeletePolicy
		{
			get { return _FileDeletePolicy; }
			set 
			{ 
				_FileDeletePolicy = value;
				OnPropertyChanged("FileDeletePolicy");
			}
		}
		public int AutoFileDeleteDays
		{
			get { return _AutoFileDeleteDays; }
			set 
			{ 
				_AutoFileDeleteDays = value;
				OnPropertyChanged("AutoFileDeleteDays");
			}
		}
		public DropFolderFileHandlerType FileHandlerType
		{
			get { return _FileHandlerType; }
			set 
			{ 
				_FileHandlerType = value;
				OnPropertyChanged("FileHandlerType");
			}
		}
		public string FileNamePatterns
		{
			get { return _FileNamePatterns; }
			set 
			{ 
				_FileNamePatterns = value;
				OnPropertyChanged("FileNamePatterns");
			}
		}
		public DropFolderFileHandlerConfig FileHandlerConfig
		{
			get { return _FileHandlerConfig; }
			set 
			{ 
				_FileHandlerConfig = value;
				OnPropertyChanged("FileHandlerConfig");
			}
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
		public DropFolderErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		public string IgnoreFileNamePatterns
		{
			get { return _IgnoreFileNamePatterns; }
			set 
			{ 
				_IgnoreFileNamePatterns = value;
				OnPropertyChanged("IgnoreFileNamePatterns");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int LastAccessedAt
		{
			get { return _LastAccessedAt; }
			set 
			{ 
				_LastAccessedAt = value;
				OnPropertyChanged("LastAccessedAt");
			}
		}
		public bool? Incremental
		{
			get { return _Incremental; }
			set 
			{ 
				_Incremental = value;
				OnPropertyChanged("Incremental");
			}
		}
		public int LastFileTimestamp
		{
			get { return _LastFileTimestamp; }
			set 
			{ 
				_LastFileTimestamp = value;
				OnPropertyChanged("LastFileTimestamp");
			}
		}
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		public string CategoriesMetadataFieldName
		{
			get { return _CategoriesMetadataFieldName; }
			set 
			{ 
				_CategoriesMetadataFieldName = value;
				OnPropertyChanged("CategoriesMetadataFieldName");
			}
		}
		public bool? EnforceEntitlement
		{
			get { return _EnforceEntitlement; }
			set 
			{ 
				_EnforceEntitlement = value;
				OnPropertyChanged("EnforceEntitlement");
			}
		}
		public bool? ShouldValidateKS
		{
			get { return _ShouldValidateKS; }
			set 
			{ 
				_ShouldValidateKS = value;
				OnPropertyChanged("ShouldValidateKS");
			}
		}
		#endregion

		#region CTor
		public DropFolder()
		{
		}

		public DropFolder(XmlElement node) : base(node)
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
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "type":
						this._Type = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (DropFolderStatus)ParseEnum(typeof(DropFolderStatus), propertyNode.InnerText);
						continue;
					case "conversionProfileId":
						this._ConversionProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "dc":
						this._Dc = ParseInt(propertyNode.InnerText);
						continue;
					case "path":
						this._Path = propertyNode.InnerText;
						continue;
					case "fileSizeCheckInterval":
						this._FileSizeCheckInterval = ParseInt(propertyNode.InnerText);
						continue;
					case "fileDeletePolicy":
						this._FileDeletePolicy = (DropFolderFileDeletePolicy)ParseEnum(typeof(DropFolderFileDeletePolicy), propertyNode.InnerText);
						continue;
					case "autoFileDeleteDays":
						this._AutoFileDeleteDays = ParseInt(propertyNode.InnerText);
						continue;
					case "fileHandlerType":
						this._FileHandlerType = (DropFolderFileHandlerType)StringEnum.Parse(typeof(DropFolderFileHandlerType), propertyNode.InnerText);
						continue;
					case "fileNamePatterns":
						this._FileNamePatterns = propertyNode.InnerText;
						continue;
					case "fileHandlerConfig":
						this._FileHandlerConfig = ObjectFactory.Create<DropFolderFileHandlerConfig>(propertyNode);
						continue;
					case "tags":
						this._Tags = propertyNode.InnerText;
						continue;
					case "errorCode":
						this._ErrorCode = (DropFolderErrorCode)StringEnum.Parse(typeof(DropFolderErrorCode), propertyNode.InnerText);
						continue;
					case "errorDescription":
						this._ErrorDescription = propertyNode.InnerText;
						continue;
					case "ignoreFileNamePatterns":
						this._IgnoreFileNamePatterns = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "lastAccessedAt":
						this._LastAccessedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "incremental":
						this._Incremental = ParseBool(propertyNode.InnerText);
						continue;
					case "lastFileTimestamp":
						this._LastFileTimestamp = ParseInt(propertyNode.InnerText);
						continue;
					case "metadataProfileId":
						this._MetadataProfileId = ParseInt(propertyNode.InnerText);
						continue;
					case "categoriesMetadataFieldName":
						this._CategoriesMetadataFieldName = propertyNode.InnerText;
						continue;
					case "enforceEntitlement":
						this._EnforceEntitlement = ParseBool(propertyNode.InnerText);
						continue;
					case "shouldValidateKS":
						this._ShouldValidateKS = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public DropFolder(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Type = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), data.TryGetValueSafe<string>("type"));
			    this._Status = (DropFolderStatus)ParseEnum(typeof(DropFolderStatus), data.TryGetValueSafe<int>("status"));
			    this._ConversionProfileId = data.TryGetValueSafe<int>("conversionProfileId");
			    this._Dc = data.TryGetValueSafe<int>("dc");
			    this._Path = data.TryGetValueSafe<string>("path");
			    this._FileSizeCheckInterval = data.TryGetValueSafe<int>("fileSizeCheckInterval");
			    this._FileDeletePolicy = (DropFolderFileDeletePolicy)ParseEnum(typeof(DropFolderFileDeletePolicy), data.TryGetValueSafe<int>("fileDeletePolicy"));
			    this._AutoFileDeleteDays = data.TryGetValueSafe<int>("autoFileDeleteDays");
			    this._FileHandlerType = (DropFolderFileHandlerType)StringEnum.Parse(typeof(DropFolderFileHandlerType), data.TryGetValueSafe<string>("fileHandlerType"));
			    this._FileNamePatterns = data.TryGetValueSafe<string>("fileNamePatterns");
			    this._FileHandlerConfig = ObjectFactory.Create<DropFolderFileHandlerConfig>(data.TryGetValueSafe<IDictionary<string,object>>("fileHandlerConfig"));
			    this._Tags = data.TryGetValueSafe<string>("tags");
			    this._ErrorCode = (DropFolderErrorCode)StringEnum.Parse(typeof(DropFolderErrorCode), data.TryGetValueSafe<string>("errorCode"));
			    this._ErrorDescription = data.TryGetValueSafe<string>("errorDescription");
			    this._IgnoreFileNamePatterns = data.TryGetValueSafe<string>("ignoreFileNamePatterns");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._LastAccessedAt = data.TryGetValueSafe<int>("lastAccessedAt");
			    this._Incremental = data.TryGetValueSafe<bool>("incremental");
			    this._LastFileTimestamp = data.TryGetValueSafe<int>("lastFileTimestamp");
			    this._MetadataProfileId = data.TryGetValueSafe<int>("metadataProfileId");
			    this._CategoriesMetadataFieldName = data.TryGetValueSafe<string>("categoriesMetadataFieldName");
			    this._EnforceEntitlement = data.TryGetValueSafe<bool>("enforceEntitlement");
			    this._ShouldValidateKS = data.TryGetValueSafe<bool>("shouldValidateKS");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolder");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("conversionProfileId", this._ConversionProfileId);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("path", this._Path);
			kparams.AddIfNotNull("fileSizeCheckInterval", this._FileSizeCheckInterval);
			kparams.AddIfNotNull("fileDeletePolicy", this._FileDeletePolicy);
			kparams.AddIfNotNull("autoFileDeleteDays", this._AutoFileDeleteDays);
			kparams.AddIfNotNull("fileHandlerType", this._FileHandlerType);
			kparams.AddIfNotNull("fileNamePatterns", this._FileNamePatterns);
			kparams.AddIfNotNull("fileHandlerConfig", this._FileHandlerConfig);
			kparams.AddIfNotNull("tags", this._Tags);
			kparams.AddIfNotNull("errorCode", this._ErrorCode);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			kparams.AddIfNotNull("ignoreFileNamePatterns", this._IgnoreFileNamePatterns);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("lastAccessedAt", this._LastAccessedAt);
			kparams.AddIfNotNull("incremental", this._Incremental);
			kparams.AddIfNotNull("lastFileTimestamp", this._LastFileTimestamp);
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("categoriesMetadataFieldName", this._CategoriesMetadataFieldName);
			kparams.AddIfNotNull("enforceEntitlement", this._EnforceEntitlement);
			kparams.AddIfNotNull("shouldValidateKS", this._ShouldValidateKS);
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
				case DESCRIPTION:
					return "Description";
				case TYPE:
					return "Type";
				case STATUS:
					return "Status";
				case CONVERSION_PROFILE_ID:
					return "ConversionProfileId";
				case DC:
					return "Dc";
				case PATH:
					return "Path";
				case FILE_SIZE_CHECK_INTERVAL:
					return "FileSizeCheckInterval";
				case FILE_DELETE_POLICY:
					return "FileDeletePolicy";
				case AUTO_FILE_DELETE_DAYS:
					return "AutoFileDeleteDays";
				case FILE_HANDLER_TYPE:
					return "FileHandlerType";
				case FILE_NAME_PATTERNS:
					return "FileNamePatterns";
				case FILE_HANDLER_CONFIG:
					return "FileHandlerConfig";
				case TAGS:
					return "Tags";
				case ERROR_CODE:
					return "ErrorCode";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				case IGNORE_FILE_NAME_PATTERNS:
					return "IgnoreFileNamePatterns";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case LAST_ACCESSED_AT:
					return "LastAccessedAt";
				case INCREMENTAL:
					return "Incremental";
				case LAST_FILE_TIMESTAMP:
					return "LastFileTimestamp";
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case CATEGORIES_METADATA_FIELD_NAME:
					return "CategoriesMetadataFieldName";
				case ENFORCE_ENTITLEMENT:
					return "EnforceEntitlement";
				case SHOULD_VALIDATE_KS:
					return "ShouldValidateKS";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

