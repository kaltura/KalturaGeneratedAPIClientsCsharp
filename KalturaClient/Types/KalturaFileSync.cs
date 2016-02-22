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

namespace Kaltura
{
	public class KalturaFileSync : KalturaObjectBase
	{
		#region Private Fields
		private long _Id = long.MinValue;
		private int _PartnerId = Int32.MinValue;
		private KalturaFileSyncObjectType _FileObjectType = null;
		private string _ObjectId = null;
		private string _Version = null;
		private int _ObjectSubType = Int32.MinValue;
		private string _Dc = null;
		private int _Original = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private int _ReadyAt = Int32.MinValue;
		private int _SyncTime = Int32.MinValue;
		private KalturaFileSyncStatus _Status = (KalturaFileSyncStatus)Int32.MinValue;
		private KalturaFileSyncType _FileType = (KalturaFileSyncType)Int32.MinValue;
		private int _LinkedId = Int32.MinValue;
		private int _LinkCount = Int32.MinValue;
		private string _FileRoot = null;
		private string _FilePath = null;
		private float _FileSize = Single.MinValue;
		private string _FileUrl = null;
		private string _FileContent = null;
		private float _FileDiscSize = Single.MinValue;
		private bool? _IsCurrentDc = false;
		private bool? _IsDir = false;
		private int _OriginalId = Int32.MinValue;
		#endregion

		#region Properties
		public long Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
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
		public KalturaFileSyncObjectType FileObjectType
		{
			get { return _FileObjectType; }
			set 
			{ 
				_FileObjectType = value;
				OnPropertyChanged("FileObjectType");
			}
		}
		public string ObjectId
		{
			get { return _ObjectId; }
			set 
			{ 
				_ObjectId = value;
				OnPropertyChanged("ObjectId");
			}
		}
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public int ObjectSubType
		{
			get { return _ObjectSubType; }
			set 
			{ 
				_ObjectSubType = value;
				OnPropertyChanged("ObjectSubType");
			}
		}
		public string Dc
		{
			get { return _Dc; }
			set 
			{ 
				_Dc = value;
				OnPropertyChanged("Dc");
			}
		}
		public int Original
		{
			get { return _Original; }
			set 
			{ 
				_Original = value;
				OnPropertyChanged("Original");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		public int ReadyAt
		{
			get { return _ReadyAt; }
			set 
			{ 
				_ReadyAt = value;
				OnPropertyChanged("ReadyAt");
			}
		}
		public int SyncTime
		{
			get { return _SyncTime; }
			set 
			{ 
				_SyncTime = value;
				OnPropertyChanged("SyncTime");
			}
		}
		public KalturaFileSyncStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaFileSyncType FileType
		{
			get { return _FileType; }
			set 
			{ 
				_FileType = value;
				OnPropertyChanged("FileType");
			}
		}
		public int LinkedId
		{
			get { return _LinkedId; }
			set 
			{ 
				_LinkedId = value;
				OnPropertyChanged("LinkedId");
			}
		}
		public int LinkCount
		{
			get { return _LinkCount; }
			set 
			{ 
				_LinkCount = value;
				OnPropertyChanged("LinkCount");
			}
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
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		public string FileUrl
		{
			get { return _FileUrl; }
			set 
			{ 
				_FileUrl = value;
				OnPropertyChanged("FileUrl");
			}
		}
		public string FileContent
		{
			get { return _FileContent; }
			set 
			{ 
				_FileContent = value;
				OnPropertyChanged("FileContent");
			}
		}
		public float FileDiscSize
		{
			get { return _FileDiscSize; }
			set 
			{ 
				_FileDiscSize = value;
				OnPropertyChanged("FileDiscSize");
			}
		}
		public bool? IsCurrentDc
		{
			get { return _IsCurrentDc; }
			set 
			{ 
				_IsCurrentDc = value;
				OnPropertyChanged("IsCurrentDc");
			}
		}
		public bool? IsDir
		{
			get { return _IsDir; }
			set 
			{ 
				_IsDir = value;
				OnPropertyChanged("IsDir");
			}
		}
		public int OriginalId
		{
			get { return _OriginalId; }
			set 
			{ 
				_OriginalId = value;
				OnPropertyChanged("OriginalId");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSync()
		{
		}

		public KalturaFileSync(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseLong(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "fileObjectType":
						this.FileObjectType = (KalturaFileSyncObjectType)KalturaStringEnum.Parse(typeof(KalturaFileSyncObjectType), txt);
						continue;
					case "objectId":
						this.ObjectId = txt;
						continue;
					case "version":
						this.Version = txt;
						continue;
					case "objectSubType":
						this.ObjectSubType = ParseInt(txt);
						continue;
					case "dc":
						this.Dc = txt;
						continue;
					case "original":
						this.Original = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
					case "readyAt":
						this.ReadyAt = ParseInt(txt);
						continue;
					case "syncTime":
						this.SyncTime = ParseInt(txt);
						continue;
					case "status":
						this.Status = (KalturaFileSyncStatus)ParseEnum(typeof(KalturaFileSyncStatus), txt);
						continue;
					case "fileType":
						this.FileType = (KalturaFileSyncType)ParseEnum(typeof(KalturaFileSyncType), txt);
						continue;
					case "linkedId":
						this.LinkedId = ParseInt(txt);
						continue;
					case "linkCount":
						this.LinkCount = ParseInt(txt);
						continue;
					case "fileRoot":
						this.FileRoot = txt;
						continue;
					case "filePath":
						this.FilePath = txt;
						continue;
					case "fileSize":
						this.FileSize = ParseFloat(txt);
						continue;
					case "fileUrl":
						this.FileUrl = txt;
						continue;
					case "fileContent":
						this.FileContent = txt;
						continue;
					case "fileDiscSize":
						this.FileDiscSize = ParseFloat(txt);
						continue;
					case "isCurrentDc":
						this.IsCurrentDc = ParseBool(txt);
						continue;
					case "isDir":
						this.IsDir = ParseBool(txt);
						continue;
					case "originalId":
						this.OriginalId = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFileSync");
			kparams.AddIfNotNull("id", this.Id);
			kparams.AddIfNotNull("partnerId", this.PartnerId);
			kparams.AddIfNotNull("fileObjectType", this.FileObjectType);
			kparams.AddIfNotNull("objectId", this.ObjectId);
			kparams.AddIfNotNull("version", this.Version);
			kparams.AddIfNotNull("objectSubType", this.ObjectSubType);
			kparams.AddIfNotNull("dc", this.Dc);
			kparams.AddIfNotNull("original", this.Original);
			kparams.AddIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIfNotNull("updatedAt", this.UpdatedAt);
			kparams.AddIfNotNull("readyAt", this.ReadyAt);
			kparams.AddIfNotNull("syncTime", this.SyncTime);
			kparams.AddIfNotNull("status", this.Status);
			kparams.AddIfNotNull("fileType", this.FileType);
			kparams.AddIfNotNull("linkedId", this.LinkedId);
			kparams.AddIfNotNull("linkCount", this.LinkCount);
			kparams.AddIfNotNull("fileRoot", this.FileRoot);
			kparams.AddIfNotNull("filePath", this.FilePath);
			kparams.AddIfNotNull("fileSize", this.FileSize);
			kparams.AddIfNotNull("fileUrl", this.FileUrl);
			kparams.AddIfNotNull("fileContent", this.FileContent);
			kparams.AddIfNotNull("fileDiscSize", this.FileDiscSize);
			kparams.AddIfNotNull("isCurrentDc", this.IsCurrentDc);
			kparams.AddIfNotNull("isDir", this.IsDir);
			kparams.AddIfNotNull("originalId", this.OriginalId);
			return kparams;
		}
		#endregion
	}
}

