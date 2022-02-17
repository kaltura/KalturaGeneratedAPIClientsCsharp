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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class FileSync : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string FILE_OBJECT_TYPE = "fileObjectType";
		public const string OBJECT_ID = "objectId";
		public const string VERSION = "version";
		public const string OBJECT_SUB_TYPE = "objectSubType";
		public const string DC = "dc";
		public const string ORIGINAL = "original";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string READY_AT = "readyAt";
		public const string SYNC_TIME = "syncTime";
		public const string STATUS = "status";
		public const string FILE_TYPE = "fileType";
		public const string LINKED_ID = "linkedId";
		public const string LINK_COUNT = "linkCount";
		public const string FILE_ROOT = "fileRoot";
		public const string FILE_PATH = "filePath";
		public const string FILE_SIZE = "fileSize";
		public const string FILE_URL = "fileUrl";
		public const string FILE_CONTENT = "fileContent";
		public const string FILE_DISC_SIZE = "fileDiscSize";
		public const string IS_CURRENT_DC = "isCurrentDc";
		public const string IS_DIR = "isDir";
		public const string ORIGINAL_ID = "originalId";
		public const string SRC_PATH = "srcPath";
		public const string SRC_ENC_KEY = "srcEncKey";
		public const string STORAGE_CLASS = "storageClass";
		#endregion

		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private FileSyncObjectType _FileObjectType = null;
		private string _ObjectId = null;
		private string _Version = null;
		private int _ObjectSubType = Int32.MinValue;
		private string _Dc = null;
		private int _Original = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _ReadyAt = Int32.MinValue;
		private int _SyncTime = Int32.MinValue;
		private FileSyncStatus _Status = (FileSyncStatus)Int32.MinValue;
		private FileSyncType _FileType = (FileSyncType)Int32.MinValue;
		private int _LinkedId = Int32.MinValue;
		private int _LinkCount = Int32.MinValue;
		private string _FileRoot = null;
		private string _FilePath = null;
		private double _FileSize = Double.MinValue;
		private string _FileUrl = null;
		private string _FileContent = null;
		private double _FileDiscSize = Double.MinValue;
		private bool? _IsCurrentDc = null;
		private bool? _IsDir = null;
		private int _OriginalId = Int32.MinValue;
		private string _SrcPath = null;
		private string _SrcEncKey = null;
		private string _StorageClass = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
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
		/// Use FileObjectTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncObjectType FileObjectType
		{
			get { return _FileObjectType; }
			private set 
			{ 
				_FileObjectType = value;
				OnPropertyChanged("FileObjectType");
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
		public string Version
		{
			get { return _Version; }
			private set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use ObjectSubTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
			private set 
			{ 
				_ObjectSubType = value;
				OnPropertyChanged("ObjectSubType");
			}
		}
		/// <summary>
		/// Use DcAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Dc
		{
			get { return _Dc; }
			private set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		/// <summary>
		/// Use OriginalAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Original
		{
			get { return _Original; }
			private set 
			{ 
				_Original = value;
				OnPropertyChanged("Original");
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
		/// Use ReadyAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ReadyAt
		{
			get { return _ReadyAt; }
			private set 
			{ 
				_ReadyAt = value;
				OnPropertyChanged("ReadyAt");
			}
		}
		/// <summary>
		/// Use SyncTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SyncTime
		{
			get { return _SyncTime; }
			private set 
			{ 
				_SyncTime = value;
				OnPropertyChanged("SyncTime");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use FileTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncType FileType
		{
			get { return _FileType; }
			private set 
			{ 
				_FileType = value;
				OnPropertyChanged("FileType");
			}
		}
		/// <summary>
		/// Use LinkedIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinkedId
		{
			get { return _LinkedId; }
			private set 
			{ 
				_LinkedId = value;
				OnPropertyChanged("LinkedId");
			}
		}
		/// <summary>
		/// Use LinkCountAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinkCount
		{
			get { return _LinkCount; }
			private set 
			{ 
				_LinkCount = value;
				OnPropertyChanged("LinkCount");
			}
		}
		/// <summary>
		/// Use FileRootAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileRoot
		{
			get { return _FileRoot; }
			set 
			{ 
				_FileRoot = value;
				OnPropertyChanged("FileRoot");
			}
		}
		/// <summary>
		/// Use FilePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		/// <summary>
		/// Use FileSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FileSize
		{
			get { return _FileSize; }
			private set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		/// <summary>
		/// Use FileUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileUrl
		{
			get { return _FileUrl; }
			private set 
			{ 
				_FileUrl = value;
				OnPropertyChanged("FileUrl");
			}
		}
		/// <summary>
		/// Use FileContentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileContent
		{
			get { return _FileContent; }
			private set 
			{ 
				_FileContent = value;
				OnPropertyChanged("FileContent");
			}
		}
		/// <summary>
		/// Use FileDiscSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FileDiscSize
		{
			get { return _FileDiscSize; }
			private set 
			{ 
				_FileDiscSize = value;
				OnPropertyChanged("FileDiscSize");
			}
		}
		/// <summary>
		/// Use IsCurrentDcAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsCurrentDc
		{
			get { return _IsCurrentDc; }
			private set 
			{ 
				_IsCurrentDc = value;
				OnPropertyChanged("IsCurrentDc");
			}
		}
		/// <summary>
		/// Use IsDirAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsDir
		{
			get { return _IsDir; }
			private set 
			{ 
				_IsDir = value;
				OnPropertyChanged("IsDir");
			}
		}
		/// <summary>
		/// Use OriginalIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int OriginalId
		{
			get { return _OriginalId; }
			private set 
			{ 
				_OriginalId = value;
				OnPropertyChanged("OriginalId");
			}
		}
		/// <summary>
		/// Use SrcPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcPath
		{
			get { return _SrcPath; }
			set 
			{ 
				_SrcPath = value;
				OnPropertyChanged("SrcPath");
			}
		}
		/// <summary>
		/// Use SrcEncKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcEncKey
		{
			get { return _SrcEncKey; }
			set 
			{ 
				_SrcEncKey = value;
				OnPropertyChanged("SrcEncKey");
			}
		}
		/// <summary>
		/// Use StorageClassAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StorageClass
		{
			get { return _StorageClass; }
			set 
			{ 
				_StorageClass = value;
				OnPropertyChanged("StorageClass");
			}
		}
		#endregion

		#region CTor
		public FileSync()
		{
		}

		public FileSync(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseLong(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["fileObjectType"] != null)
			{
				this._FileObjectType = (FileSyncObjectType)StringEnum.Parse(typeof(FileSyncObjectType), node["fileObjectType"].Value<string>());
			}
			if(node["objectId"] != null)
			{
				this._ObjectId = node["objectId"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["objectSubType"] != null)
			{
				this._ObjectSubType = ParseInt(node["objectSubType"].Value<string>());
			}
			if(node["dc"] != null)
			{
				this._Dc = node["dc"].Value<string>();
			}
			if(node["original"] != null)
			{
				this._Original = ParseInt(node["original"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["readyAt"] != null)
			{
				this._ReadyAt = ParseInt(node["readyAt"].Value<string>());
			}
			if(node["syncTime"] != null)
			{
				this._SyncTime = ParseInt(node["syncTime"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (FileSyncStatus)ParseEnum(typeof(FileSyncStatus), node["status"].Value<string>());
			}
			if(node["fileType"] != null)
			{
				this._FileType = (FileSyncType)ParseEnum(typeof(FileSyncType), node["fileType"].Value<string>());
			}
			if(node["linkedId"] != null)
			{
				this._LinkedId = ParseInt(node["linkedId"].Value<string>());
			}
			if(node["linkCount"] != null)
			{
				this._LinkCount = ParseInt(node["linkCount"].Value<string>());
			}
			if(node["fileRoot"] != null)
			{
				this._FileRoot = node["fileRoot"].Value<string>();
			}
			if(node["filePath"] != null)
			{
				this._FilePath = node["filePath"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseDouble(node["fileSize"].Value<string>());
			}
			if(node["fileUrl"] != null)
			{
				this._FileUrl = node["fileUrl"].Value<string>();
			}
			if(node["fileContent"] != null)
			{
				this._FileContent = node["fileContent"].Value<string>();
			}
			if(node["fileDiscSize"] != null)
			{
				this._FileDiscSize = ParseDouble(node["fileDiscSize"].Value<string>());
			}
			if(node["isCurrentDc"] != null)
			{
				this._IsCurrentDc = ParseBool(node["isCurrentDc"].Value<string>());
			}
			if(node["isDir"] != null)
			{
				this._IsDir = ParseBool(node["isDir"].Value<string>());
			}
			if(node["originalId"] != null)
			{
				this._OriginalId = ParseInt(node["originalId"].Value<string>());
			}
			if(node["srcPath"] != null)
			{
				this._SrcPath = node["srcPath"].Value<string>();
			}
			if(node["srcEncKey"] != null)
			{
				this._SrcEncKey = node["srcEncKey"].Value<string>();
			}
			if(node["storageClass"] != null)
			{
				this._StorageClass = node["storageClass"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFileSync");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("fileObjectType", this._FileObjectType);
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("objectSubType", this._ObjectSubType);
			kparams.AddIfNotNull("dc", this._Dc);
			kparams.AddIfNotNull("original", this._Original);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("readyAt", this._ReadyAt);
			kparams.AddIfNotNull("syncTime", this._SyncTime);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("fileType", this._FileType);
			kparams.AddIfNotNull("linkedId", this._LinkedId);
			kparams.AddIfNotNull("linkCount", this._LinkCount);
			kparams.AddIfNotNull("fileRoot", this._FileRoot);
			kparams.AddIfNotNull("filePath", this._FilePath);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			kparams.AddIfNotNull("fileUrl", this._FileUrl);
			kparams.AddIfNotNull("fileContent", this._FileContent);
			kparams.AddIfNotNull("fileDiscSize", this._FileDiscSize);
			kparams.AddIfNotNull("isCurrentDc", this._IsCurrentDc);
			kparams.AddIfNotNull("isDir", this._IsDir);
			kparams.AddIfNotNull("originalId", this._OriginalId);
			kparams.AddIfNotNull("srcPath", this._SrcPath);
			kparams.AddIfNotNull("srcEncKey", this._SrcEncKey);
			kparams.AddIfNotNull("storageClass", this._StorageClass);
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
				case FILE_OBJECT_TYPE:
					return "FileObjectType";
				case OBJECT_ID:
					return "ObjectId";
				case VERSION:
					return "Version";
				case OBJECT_SUB_TYPE:
					return "ObjectSubType";
				case DC:
					return "Dc";
				case ORIGINAL:
					return "Original";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case READY_AT:
					return "ReadyAt";
				case SYNC_TIME:
					return "SyncTime";
				case STATUS:
					return "Status";
				case FILE_TYPE:
					return "FileType";
				case LINKED_ID:
					return "LinkedId";
				case LINK_COUNT:
					return "LinkCount";
				case FILE_ROOT:
					return "FileRoot";
				case FILE_PATH:
					return "FilePath";
				case FILE_SIZE:
					return "FileSize";
				case FILE_URL:
					return "FileUrl";
				case FILE_CONTENT:
					return "FileContent";
				case FILE_DISC_SIZE:
					return "FileDiscSize";
				case IS_CURRENT_DC:
					return "IsCurrentDc";
				case IS_DIR:
					return "IsDir";
				case ORIGINAL_ID:
					return "OriginalId";
				case SRC_PATH:
					return "SrcPath";
				case SRC_ENC_KEY:
					return "SrcEncKey";
				case STORAGE_CLASS:
					return "StorageClass";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

