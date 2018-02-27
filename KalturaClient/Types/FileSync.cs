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
		private float _FileSize = Single.MinValue;
		private string _FileUrl = null;
		private string _FileContent = null;
		private float _FileDiscSize = Single.MinValue;
		private bool? _IsCurrentDc = null;
		private bool? _IsDir = null;
		private int _OriginalId = Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public FileSyncObjectType FileObjectType
		{
			get { return _FileObjectType; }
		}
		public string ObjectId
		{
			get { return _ObjectId; }
		}
		public string Version
		{
			get { return _Version; }
		}
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
		}
		public string Dc
		{
			get { return _Dc; }
		}
		public int Original
		{
			get { return _Original; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public int ReadyAt
		{
			get { return _ReadyAt; }
		}
		public int SyncTime
		{
			get { return _SyncTime; }
		}
		public FileSyncStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public FileSyncType FileType
		{
			get { return _FileType; }
		}
		public int LinkedId
		{
			get { return _LinkedId; }
		}
		public int LinkCount
		{
			get { return _LinkCount; }
		}
		public string FileRoot
		{
			get { return _FileRoot; }
			set 
			{ 
				_FileRoot = value;
				OnPropertyChanged("FileRoot");
			}
		}
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		public float FileSize
		{
			get { return _FileSize; }
		}
		public string FileUrl
		{
			get { return _FileUrl; }
		}
		public string FileContent
		{
			get { return _FileContent; }
		}
		public float FileDiscSize
		{
			get { return _FileDiscSize; }
		}
		public bool? IsCurrentDc
		{
			get { return _IsCurrentDc; }
		}
		public bool? IsDir
		{
			get { return _IsDir; }
		}
		public int OriginalId
		{
			get { return _OriginalId; }
		}
		#endregion

		#region CTor
		public FileSync()
		{
		}

		public FileSync(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseLong(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "fileObjectType":
						this._FileObjectType = (FileSyncObjectType)StringEnum.Parse(typeof(FileSyncObjectType), propertyNode.InnerText);
						continue;
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = propertyNode.InnerText;
						continue;
					case "objectSubType":
						this._ObjectSubType = ParseInt(propertyNode.InnerText);
						continue;
					case "dc":
						this._Dc = propertyNode.InnerText;
						continue;
					case "original":
						this._Original = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "readyAt":
						this._ReadyAt = ParseInt(propertyNode.InnerText);
						continue;
					case "syncTime":
						this._SyncTime = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (FileSyncStatus)ParseEnum(typeof(FileSyncStatus), propertyNode.InnerText);
						continue;
					case "fileType":
						this._FileType = (FileSyncType)ParseEnum(typeof(FileSyncType), propertyNode.InnerText);
						continue;
					case "linkedId":
						this._LinkedId = ParseInt(propertyNode.InnerText);
						continue;
					case "linkCount":
						this._LinkCount = ParseInt(propertyNode.InnerText);
						continue;
					case "fileRoot":
						this._FileRoot = propertyNode.InnerText;
						continue;
					case "filePath":
						this._FilePath = propertyNode.InnerText;
						continue;
					case "fileSize":
						this._FileSize = ParseFloat(propertyNode.InnerText);
						continue;
					case "fileUrl":
						this._FileUrl = propertyNode.InnerText;
						continue;
					case "fileContent":
						this._FileContent = propertyNode.InnerText;
						continue;
					case "fileDiscSize":
						this._FileDiscSize = ParseFloat(propertyNode.InnerText);
						continue;
					case "isCurrentDc":
						this._IsCurrentDc = ParseBool(propertyNode.InnerText);
						continue;
					case "isDir":
						this._IsDir = ParseBool(propertyNode.InnerText);
						continue;
					case "originalId":
						this._OriginalId = ParseInt(propertyNode.InnerText);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

