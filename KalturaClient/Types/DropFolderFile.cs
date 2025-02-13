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
	public class DropFolderFile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string DROP_FOLDER_ID = "dropFolderId";
		public const string FILE_NAME = "fileName";
		public const string FILE_SIZE = "fileSize";
		public const string FILE_SIZE_LAST_SET_AT = "fileSizeLastSetAt";
		public const string STATUS = "status";
		public const string TYPE = "type";
		public const string PARSED_SLUG = "parsedSlug";
		public const string PARSED_FLAVOR = "parsedFlavor";
		public const string PARSED_USER_ID = "parsedUserId";
		public const string LEAD_DROP_FOLDER_FILE_ID = "leadDropFolderFileId";
		public const string DELETED_DROP_FOLDER_FILE_ID = "deletedDropFolderFileId";
		public const string ENTRY_ID = "entryId";
		public const string ERROR_CODE = "errorCode";
		public const string ERROR_DESCRIPTION = "errorDescription";
		public const string LAST_MODIFICATION_TIME = "lastModificationTime";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string UPLOAD_START_DETECTED_AT = "uploadStartDetectedAt";
		public const string UPLOAD_END_DETECTED_AT = "uploadEndDetectedAt";
		public const string IMPORT_STARTED_AT = "importStartedAt";
		public const string IMPORT_ENDED_AT = "importEndedAt";
		public const string BATCH_JOB_ID = "batchJobId";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private int _DropFolderId = Int32.MinValue;
		private string _FileName = null;
		private float _FileSize = Single.MinValue;
		private int _FileSizeLastSetAt = Int32.MinValue;
		private DropFolderFileStatus _Status = (DropFolderFileStatus)Int32.MinValue;
		private DropFolderType _Type = null;
		private string _ParsedSlug = null;
		private string _ParsedFlavor = null;
		private string _ParsedUserId = null;
		private int _LeadDropFolderFileId = Int32.MinValue;
		private int _DeletedDropFolderFileId = Int32.MinValue;
		private string _EntryId = null;
		private DropFolderFileErrorCode _ErrorCode = null;
		private string _ErrorDescription = null;
		private string _LastModificationTime = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _UploadStartDetectedAt = Int32.MinValue;
		private int _UploadEndDetectedAt = Int32.MinValue;
		private int _ImportStartedAt = Int32.MinValue;
		private int _ImportEndedAt = Int32.MinValue;
		private int _BatchJobId = Int32.MinValue;
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
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		[JsonProperty]
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		[JsonProperty]
		public float FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		[JsonProperty]
		public int FileSizeLastSetAt
		{
			get { return _FileSizeLastSetAt; }
			private set 
			{ 
				_FileSizeLastSetAt = value;
				OnPropertyChanged("FileSizeLastSetAt");
			}
		}
		[JsonProperty]
		public DropFolderFileStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public DropFolderType Type
		{
			get { return _Type; }
			private set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		[JsonProperty]
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		[JsonProperty]
		public string ParsedFlavor
		{
			get { return _ParsedFlavor; }
			set 
			{ 
				_ParsedFlavor = value;
				OnPropertyChanged("ParsedFlavor");
			}
		}
		[JsonProperty]
		public string ParsedUserId
		{
			get { return _ParsedUserId; }
			set 
			{ 
				_ParsedUserId = value;
				OnPropertyChanged("ParsedUserId");
			}
		}
		[JsonProperty]
		public int LeadDropFolderFileId
		{
			get { return _LeadDropFolderFileId; }
			set 
			{ 
				_LeadDropFolderFileId = value;
				OnPropertyChanged("LeadDropFolderFileId");
			}
		}
		[JsonProperty]
		public int DeletedDropFolderFileId
		{
			get { return _DeletedDropFolderFileId; }
			set 
			{ 
				_DeletedDropFolderFileId = value;
				OnPropertyChanged("DeletedDropFolderFileId");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public DropFolderFileErrorCode ErrorCode
		{
			get { return _ErrorCode; }
			set 
			{ 
				_ErrorCode = value;
				OnPropertyChanged("ErrorCode");
			}
		}
		[JsonProperty]
		public string ErrorDescription
		{
			get { return _ErrorDescription; }
			set 
			{ 
				_ErrorDescription = value;
				OnPropertyChanged("ErrorDescription");
			}
		}
		[JsonProperty]
		public string LastModificationTime
		{
			get { return _LastModificationTime; }
			set 
			{ 
				_LastModificationTime = value;
				OnPropertyChanged("LastModificationTime");
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
		public int UploadStartDetectedAt
		{
			get { return _UploadStartDetectedAt; }
			set 
			{ 
				_UploadStartDetectedAt = value;
				OnPropertyChanged("UploadStartDetectedAt");
			}
		}
		[JsonProperty]
		public int UploadEndDetectedAt
		{
			get { return _UploadEndDetectedAt; }
			set 
			{ 
				_UploadEndDetectedAt = value;
				OnPropertyChanged("UploadEndDetectedAt");
			}
		}
		[JsonProperty]
		public int ImportStartedAt
		{
			get { return _ImportStartedAt; }
			set 
			{ 
				_ImportStartedAt = value;
				OnPropertyChanged("ImportStartedAt");
			}
		}
		[JsonProperty]
		public int ImportEndedAt
		{
			get { return _ImportEndedAt; }
			set 
			{ 
				_ImportEndedAt = value;
				OnPropertyChanged("ImportEndedAt");
			}
		}
		[JsonProperty]
		public int BatchJobId
		{
			get { return _BatchJobId; }
			private set 
			{ 
				_BatchJobId = value;
				OnPropertyChanged("BatchJobId");
			}
		}
		#endregion

		#region CTor
		public DropFolderFile()
		{
		}

		public DropFolderFile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["dropFolderId"] != null)
			{
				this._DropFolderId = ParseInt(node["dropFolderId"].Value<string>());
			}
			if(node["fileName"] != null)
			{
				this._FileName = node["fileName"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseFloat(node["fileSize"].Value<string>());
			}
			if(node["fileSizeLastSetAt"] != null)
			{
				this._FileSizeLastSetAt = ParseInt(node["fileSizeLastSetAt"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (DropFolderFileStatus)ParseEnum(typeof(DropFolderFileStatus), node["status"].Value<string>());
			}
			if(node["type"] != null)
			{
				this._Type = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), node["type"].Value<string>());
			}
			if(node["parsedSlug"] != null)
			{
				this._ParsedSlug = node["parsedSlug"].Value<string>();
			}
			if(node["parsedFlavor"] != null)
			{
				this._ParsedFlavor = node["parsedFlavor"].Value<string>();
			}
			if(node["parsedUserId"] != null)
			{
				this._ParsedUserId = node["parsedUserId"].Value<string>();
			}
			if(node["leadDropFolderFileId"] != null)
			{
				this._LeadDropFolderFileId = ParseInt(node["leadDropFolderFileId"].Value<string>());
			}
			if(node["deletedDropFolderFileId"] != null)
			{
				this._DeletedDropFolderFileId = ParseInt(node["deletedDropFolderFileId"].Value<string>());
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["errorCode"] != null)
			{
				this._ErrorCode = (DropFolderFileErrorCode)StringEnum.Parse(typeof(DropFolderFileErrorCode), node["errorCode"].Value<string>());
			}
			if(node["errorDescription"] != null)
			{
				this._ErrorDescription = node["errorDescription"].Value<string>();
			}
			if(node["lastModificationTime"] != null)
			{
				this._LastModificationTime = node["lastModificationTime"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["uploadStartDetectedAt"] != null)
			{
				this._UploadStartDetectedAt = ParseInt(node["uploadStartDetectedAt"].Value<string>());
			}
			if(node["uploadEndDetectedAt"] != null)
			{
				this._UploadEndDetectedAt = ParseInt(node["uploadEndDetectedAt"].Value<string>());
			}
			if(node["importStartedAt"] != null)
			{
				this._ImportStartedAt = ParseInt(node["importStartedAt"].Value<string>());
			}
			if(node["importEndedAt"] != null)
			{
				this._ImportEndedAt = ParseInt(node["importEndedAt"].Value<string>());
			}
			if(node["batchJobId"] != null)
			{
				this._BatchJobId = ParseInt(node["batchJobId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderFile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("dropFolderId", this._DropFolderId);
			kparams.AddIfNotNull("fileName", this._FileName);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			kparams.AddIfNotNull("fileSizeLastSetAt", this._FileSizeLastSetAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("parsedSlug", this._ParsedSlug);
			kparams.AddIfNotNull("parsedFlavor", this._ParsedFlavor);
			kparams.AddIfNotNull("parsedUserId", this._ParsedUserId);
			kparams.AddIfNotNull("leadDropFolderFileId", this._LeadDropFolderFileId);
			kparams.AddIfNotNull("deletedDropFolderFileId", this._DeletedDropFolderFileId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("errorCode", this._ErrorCode);
			kparams.AddIfNotNull("errorDescription", this._ErrorDescription);
			kparams.AddIfNotNull("lastModificationTime", this._LastModificationTime);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("uploadStartDetectedAt", this._UploadStartDetectedAt);
			kparams.AddIfNotNull("uploadEndDetectedAt", this._UploadEndDetectedAt);
			kparams.AddIfNotNull("importStartedAt", this._ImportStartedAt);
			kparams.AddIfNotNull("importEndedAt", this._ImportEndedAt);
			kparams.AddIfNotNull("batchJobId", this._BatchJobId);
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
				case DROP_FOLDER_ID:
					return "DropFolderId";
				case FILE_NAME:
					return "FileName";
				case FILE_SIZE:
					return "FileSize";
				case FILE_SIZE_LAST_SET_AT:
					return "FileSizeLastSetAt";
				case STATUS:
					return "Status";
				case TYPE:
					return "Type";
				case PARSED_SLUG:
					return "ParsedSlug";
				case PARSED_FLAVOR:
					return "ParsedFlavor";
				case PARSED_USER_ID:
					return "ParsedUserId";
				case LEAD_DROP_FOLDER_FILE_ID:
					return "LeadDropFolderFileId";
				case DELETED_DROP_FOLDER_FILE_ID:
					return "DeletedDropFolderFileId";
				case ENTRY_ID:
					return "EntryId";
				case ERROR_CODE:
					return "ErrorCode";
				case ERROR_DESCRIPTION:
					return "ErrorDescription";
				case LAST_MODIFICATION_TIME:
					return "LastModificationTime";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case UPLOAD_START_DETECTED_AT:
					return "UploadStartDetectedAt";
				case UPLOAD_END_DETECTED_AT:
					return "UploadEndDetectedAt";
				case IMPORT_STARTED_AT:
					return "ImportStartedAt";
				case IMPORT_ENDED_AT:
					return "ImportEndedAt";
				case BATCH_JOB_ID:
					return "BatchJobId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

