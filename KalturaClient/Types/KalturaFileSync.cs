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
		public KalturaFileSyncObjectType FileObjectType
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
						this._Id = ParseLong(txt);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(txt);
						continue;
					case "fileObjectType":
						this._FileObjectType = (KalturaFileSyncObjectType)KalturaStringEnum.Parse(typeof(KalturaFileSyncObjectType), txt);
						continue;
					case "objectId":
						this._ObjectId = txt;
						continue;
					case "version":
						this._Version = txt;
						continue;
					case "objectSubType":
						this._ObjectSubType = ParseInt(txt);
						continue;
					case "dc":
						this._Dc = txt;
						continue;
					case "original":
						this._Original = ParseInt(txt);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(txt);
						continue;
					case "readyAt":
						this._ReadyAt = ParseInt(txt);
						continue;
					case "syncTime":
						this._SyncTime = ParseInt(txt);
						continue;
					case "status":
						this._Status = (KalturaFileSyncStatus)ParseEnum(typeof(KalturaFileSyncStatus), txt);
						continue;
					case "fileType":
						this._FileType = (KalturaFileSyncType)ParseEnum(typeof(KalturaFileSyncType), txt);
						continue;
					case "linkedId":
						this._LinkedId = ParseInt(txt);
						continue;
					case "linkCount":
						this._LinkCount = ParseInt(txt);
						continue;
					case "fileRoot":
						this._FileRoot = txt;
						continue;
					case "filePath":
						this._FilePath = txt;
						continue;
					case "fileSize":
						this._FileSize = ParseFloat(txt);
						continue;
					case "fileUrl":
						this._FileUrl = txt;
						continue;
					case "fileContent":
						this._FileContent = txt;
						continue;
					case "fileDiscSize":
						this._FileDiscSize = ParseFloat(txt);
						continue;
					case "isCurrentDc":
						this._IsCurrentDc = ParseBool(txt);
						continue;
					case "isDir":
						this._IsDir = ParseBool(txt);
						continue;
					case "originalId":
						this._OriginalId = ParseInt(txt);
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
		#endregion
	}
}

