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
// Copyright (C) 2006-2016  Kaltura Inc.
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
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int DropFolderId
		{
			get { return _DropFolderId; }
			set 
			{ 
				_DropFolderId = value;
				OnPropertyChanged("DropFolderId");
			}
		}
		public string FileName
		{
			get { return _FileName; }
			set 
			{ 
				_FileName = value;
				OnPropertyChanged("FileName");
			}
		}
		public float FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public int FileSizeLastSetAt
		{
			get { return _FileSizeLastSetAt; }
		}
		public DropFolderFileStatus Status
		{
			get { return _Status; }
		}
		public DropFolderType Type
		{
			get { return _Type; }
		}
		public string ParsedSlug
		{
			get { return _ParsedSlug; }
			set 
			{ 
				_ParsedSlug = value;
				OnPropertyChanged("ParsedSlug");
			}
		}
		public string ParsedFlavor
		{
			get { return _ParsedFlavor; }
			set 
			{ 
				_ParsedFlavor = value;
				OnPropertyChanged("ParsedFlavor");
			}
		}
		public string ParsedUserId
		{
			get { return _ParsedUserId; }
			set 
			{ 
				_ParsedUserId = value;
				OnPropertyChanged("ParsedUserId");
			}
		}
		public int LeadDropFolderFileId
		{
			get { return _LeadDropFolderFileId; }
			set 
			{ 
				_LeadDropFolderFileId = value;
				OnPropertyChanged("LeadDropFolderFileId");
			}
		}
		public int DeletedDropFolderFileId
		{
			get { return _DeletedDropFolderFileId; }
			set 
			{ 
				_DeletedDropFolderFileId = value;
				OnPropertyChanged("DeletedDropFolderFileId");
			}
		}
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public DropFolderFileErrorCode ErrorCode
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
		public string LastModificationTime
		{
			get { return _LastModificationTime; }
			set 
			{ 
				_LastModificationTime = value;
				OnPropertyChanged("LastModificationTime");
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
		public int UploadStartDetectedAt
		{
			get { return _UploadStartDetectedAt; }
			set 
			{ 
				_UploadStartDetectedAt = value;
				OnPropertyChanged("UploadStartDetectedAt");
			}
		}
		public int UploadEndDetectedAt
		{
			get { return _UploadEndDetectedAt; }
			set 
			{ 
				_UploadEndDetectedAt = value;
				OnPropertyChanged("UploadEndDetectedAt");
			}
		}
		public int ImportStartedAt
		{
			get { return _ImportStartedAt; }
			set 
			{ 
				_ImportStartedAt = value;
				OnPropertyChanged("ImportStartedAt");
			}
		}
		public int ImportEndedAt
		{
			get { return _ImportEndedAt; }
			set 
			{ 
				_ImportEndedAt = value;
				OnPropertyChanged("ImportEndedAt");
			}
		}
		public int BatchJobId
		{
			get { return _BatchJobId; }
		}
		#endregion

		#region CTor
		public DropFolderFile()
		{
		}

		public DropFolderFile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "dropFolderId":
						this._DropFolderId = ParseInt(txt);
						continue;
					case "fileName":
						this._FileName = txt;
						continue;
					case "fileSize":
						this._FileSize = ParseFloat(txt);
						continue;
					case "fileSizeLastSetAt":
						this._FileSizeLastSetAt = ParseInt(txt);
						continue;
					case "status":
						this._Status = (DropFolderFileStatus)ParseEnum(typeof(DropFolderFileStatus), txt);
						continue;
					case "type":
						this._Type = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), txt);
						continue;
					case "parsedSlug":
						this._ParsedSlug = txt;
						continue;
					case "parsedFlavor":
						this._ParsedFlavor = txt;
						continue;
					case "parsedUserId":
						this._ParsedUserId = txt;
						continue;
					case "leadDropFolderFileId":
						this._LeadDropFolderFileId = ParseInt(txt);
						continue;
					case "deletedDropFolderFileId":
						this._DeletedDropFolderFileId = ParseInt(txt);
						continue;
					case "entryId":
						this._EntryId = txt;
						continue;
					case "errorCode":
						this._ErrorCode = (DropFolderFileErrorCode)StringEnum.Parse(typeof(DropFolderFileErrorCode), txt);
						continue;
					case "errorDescription":
						this._ErrorDescription = txt;
						continue;
					case "lastModificationTime":
						this._LastModificationTime = txt;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "uploadStartDetectedAt":
						this._UploadStartDetectedAt = ParseInt(txt);
						continue;
					case "uploadEndDetectedAt":
						this._UploadEndDetectedAt = ParseInt(txt);
						continue;
					case "importStartedAt":
						this._ImportStartedAt = ParseInt(txt);
						continue;
					case "importEndedAt":
						this._ImportEndedAt = ParseInt(txt);
						continue;
					case "batchJobId":
						this._BatchJobId = ParseInt(txt);
						continue;
				}
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

