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
	public class FileSyncBaseFilter : Filter
	{
		#region Constants
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string FILE_OBJECT_TYPE_EQUAL = "fileObjectTypeEqual";
		public const string FILE_OBJECT_TYPE_IN = "fileObjectTypeIn";
		public const string OBJECT_ID_EQUAL = "objectIdEqual";
		public const string OBJECT_ID_IN = "objectIdIn";
		public const string VERSION_EQUAL = "versionEqual";
		public const string VERSION_IN = "versionIn";
		public const string OBJECT_SUB_TYPE_EQUAL = "objectSubTypeEqual";
		public const string OBJECT_SUB_TYPE_IN = "objectSubTypeIn";
		public const string DC_EQUAL = "dcEqual";
		public const string DC_IN = "dcIn";
		public const string ORIGINAL_EQUAL = "originalEqual";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string READY_AT_GREATER_THAN_OR_EQUAL = "readyAtGreaterThanOrEqual";
		public const string READY_AT_LESS_THAN_OR_EQUAL = "readyAtLessThanOrEqual";
		public const string SYNC_TIME_GREATER_THAN_OR_EQUAL = "syncTimeGreaterThanOrEqual";
		public const string SYNC_TIME_LESS_THAN_OR_EQUAL = "syncTimeLessThanOrEqual";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string FILE_TYPE_EQUAL = "fileTypeEqual";
		public const string FILE_TYPE_IN = "fileTypeIn";
		public const string LINKED_ID_EQUAL = "linkedIdEqual";
		public const string LINK_COUNT_GREATER_THAN_OR_EQUAL = "linkCountGreaterThanOrEqual";
		public const string LINK_COUNT_LESS_THAN_OR_EQUAL = "linkCountLessThanOrEqual";
		public const string FILE_SIZE_GREATER_THAN_OR_EQUAL = "fileSizeGreaterThanOrEqual";
		public const string FILE_SIZE_LESS_THAN_OR_EQUAL = "fileSizeLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private FileSyncObjectType _FileObjectTypeEqual = null;
		private string _FileObjectTypeIn = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private string _VersionEqual = null;
		private string _VersionIn = null;
		private int _ObjectSubTypeEqual = Int32.MinValue;
		private string _ObjectSubTypeIn = null;
		private string _DcEqual = null;
		private string _DcIn = null;
		private int _OriginalEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _ReadyAtGreaterThanOrEqual = Int32.MinValue;
		private int _ReadyAtLessThanOrEqual = Int32.MinValue;
		private int _SyncTimeGreaterThanOrEqual = Int32.MinValue;
		private int _SyncTimeLessThanOrEqual = Int32.MinValue;
		private FileSyncStatus _StatusEqual = (FileSyncStatus)Int32.MinValue;
		private string _StatusIn = null;
		private FileSyncType _FileTypeEqual = (FileSyncType)Int32.MinValue;
		private string _FileTypeIn = null;
		private int _LinkedIdEqual = Int32.MinValue;
		private int _LinkCountGreaterThanOrEqual = Int32.MinValue;
		private int _LinkCountLessThanOrEqual = Int32.MinValue;
		private float _FileSizeGreaterThanOrEqual = Single.MinValue;
		private float _FileSizeLessThanOrEqual = Single.MinValue;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public FileSyncObjectType FileObjectTypeEqual
		{
			get { return _FileObjectTypeEqual; }
			set 
			{ 
				_FileObjectTypeEqual = value;
				OnPropertyChanged("FileObjectTypeEqual");
			}
		}
		public string FileObjectTypeIn
		{
			get { return _FileObjectTypeIn; }
			set 
			{ 
				_FileObjectTypeIn = value;
				OnPropertyChanged("FileObjectTypeIn");
			}
		}
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		public string VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		public string VersionIn
		{
			get { return _VersionIn; }
			set 
			{ 
				_VersionIn = value;
				OnPropertyChanged("VersionIn");
			}
		}
		public int ObjectSubTypeEqual
		{
			get { return _ObjectSubTypeEqual; }
			set 
			{ 
				_ObjectSubTypeEqual = value;
				OnPropertyChanged("ObjectSubTypeEqual");
			}
		}
		public string ObjectSubTypeIn
		{
			get { return _ObjectSubTypeIn; }
			set 
			{ 
				_ObjectSubTypeIn = value;
				OnPropertyChanged("ObjectSubTypeIn");
			}
		}
		public string DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		public int OriginalEqual
		{
			get { return _OriginalEqual; }
			set 
			{ 
				_OriginalEqual = value;
				OnPropertyChanged("OriginalEqual");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int ReadyAtGreaterThanOrEqual
		{
			get { return _ReadyAtGreaterThanOrEqual; }
			set 
			{ 
				_ReadyAtGreaterThanOrEqual = value;
				OnPropertyChanged("ReadyAtGreaterThanOrEqual");
			}
		}
		public int ReadyAtLessThanOrEqual
		{
			get { return _ReadyAtLessThanOrEqual; }
			set 
			{ 
				_ReadyAtLessThanOrEqual = value;
				OnPropertyChanged("ReadyAtLessThanOrEqual");
			}
		}
		public int SyncTimeGreaterThanOrEqual
		{
			get { return _SyncTimeGreaterThanOrEqual; }
			set 
			{ 
				_SyncTimeGreaterThanOrEqual = value;
				OnPropertyChanged("SyncTimeGreaterThanOrEqual");
			}
		}
		public int SyncTimeLessThanOrEqual
		{
			get { return _SyncTimeLessThanOrEqual; }
			set 
			{ 
				_SyncTimeLessThanOrEqual = value;
				OnPropertyChanged("SyncTimeLessThanOrEqual");
			}
		}
		public FileSyncStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public FileSyncType FileTypeEqual
		{
			get { return _FileTypeEqual; }
			set 
			{ 
				_FileTypeEqual = value;
				OnPropertyChanged("FileTypeEqual");
			}
		}
		public string FileTypeIn
		{
			get { return _FileTypeIn; }
			set 
			{ 
				_FileTypeIn = value;
				OnPropertyChanged("FileTypeIn");
			}
		}
		public int LinkedIdEqual
		{
			get { return _LinkedIdEqual; }
			set 
			{ 
				_LinkedIdEqual = value;
				OnPropertyChanged("LinkedIdEqual");
			}
		}
		public int LinkCountGreaterThanOrEqual
		{
			get { return _LinkCountGreaterThanOrEqual; }
			set 
			{ 
				_LinkCountGreaterThanOrEqual = value;
				OnPropertyChanged("LinkCountGreaterThanOrEqual");
			}
		}
		public int LinkCountLessThanOrEqual
		{
			get { return _LinkCountLessThanOrEqual; }
			set 
			{ 
				_LinkCountLessThanOrEqual = value;
				OnPropertyChanged("LinkCountLessThanOrEqual");
			}
		}
		public float FileSizeGreaterThanOrEqual
		{
			get { return _FileSizeGreaterThanOrEqual; }
			set 
			{ 
				_FileSizeGreaterThanOrEqual = value;
				OnPropertyChanged("FileSizeGreaterThanOrEqual");
			}
		}
		public float FileSizeLessThanOrEqual
		{
			get { return _FileSizeLessThanOrEqual; }
			set 
			{ 
				_FileSizeLessThanOrEqual = value;
				OnPropertyChanged("FileSizeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public FileSyncBaseFilter()
		{
		}

		public FileSyncBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "fileObjectTypeEqual":
						this._FileObjectTypeEqual = (FileSyncObjectType)StringEnum.Parse(typeof(FileSyncObjectType), propertyNode.InnerText);
						continue;
					case "fileObjectTypeIn":
						this._FileObjectTypeIn = propertyNode.InnerText;
						continue;
					case "objectIdEqual":
						this._ObjectIdEqual = propertyNode.InnerText;
						continue;
					case "objectIdIn":
						this._ObjectIdIn = propertyNode.InnerText;
						continue;
					case "versionEqual":
						this._VersionEqual = propertyNode.InnerText;
						continue;
					case "versionIn":
						this._VersionIn = propertyNode.InnerText;
						continue;
					case "objectSubTypeEqual":
						this._ObjectSubTypeEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "objectSubTypeIn":
						this._ObjectSubTypeIn = propertyNode.InnerText;
						continue;
					case "dcEqual":
						this._DcEqual = propertyNode.InnerText;
						continue;
					case "dcIn":
						this._DcIn = propertyNode.InnerText;
						continue;
					case "originalEqual":
						this._OriginalEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "readyAtGreaterThanOrEqual":
						this._ReadyAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "readyAtLessThanOrEqual":
						this._ReadyAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "syncTimeGreaterThanOrEqual":
						this._SyncTimeGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "syncTimeLessThanOrEqual":
						this._SyncTimeLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "statusEqual":
						this._StatusEqual = (FileSyncStatus)ParseEnum(typeof(FileSyncStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "fileTypeEqual":
						this._FileTypeEqual = (FileSyncType)ParseEnum(typeof(FileSyncType), propertyNode.InnerText);
						continue;
					case "fileTypeIn":
						this._FileTypeIn = propertyNode.InnerText;
						continue;
					case "linkedIdEqual":
						this._LinkedIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "linkCountGreaterThanOrEqual":
						this._LinkCountGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "linkCountLessThanOrEqual":
						this._LinkCountLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "fileSizeGreaterThanOrEqual":
						this._FileSizeGreaterThanOrEqual = ParseFloat(propertyNode.InnerText);
						continue;
					case "fileSizeLessThanOrEqual":
						this._FileSizeLessThanOrEqual = ParseFloat(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaFileSyncBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("fileObjectTypeEqual", this._FileObjectTypeEqual);
			kparams.AddIfNotNull("fileObjectTypeIn", this._FileObjectTypeIn);
			kparams.AddIfNotNull("objectIdEqual", this._ObjectIdEqual);
			kparams.AddIfNotNull("objectIdIn", this._ObjectIdIn);
			kparams.AddIfNotNull("versionEqual", this._VersionEqual);
			kparams.AddIfNotNull("versionIn", this._VersionIn);
			kparams.AddIfNotNull("objectSubTypeEqual", this._ObjectSubTypeEqual);
			kparams.AddIfNotNull("objectSubTypeIn", this._ObjectSubTypeIn);
			kparams.AddIfNotNull("dcEqual", this._DcEqual);
			kparams.AddIfNotNull("dcIn", this._DcIn);
			kparams.AddIfNotNull("originalEqual", this._OriginalEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("readyAtGreaterThanOrEqual", this._ReadyAtGreaterThanOrEqual);
			kparams.AddIfNotNull("readyAtLessThanOrEqual", this._ReadyAtLessThanOrEqual);
			kparams.AddIfNotNull("syncTimeGreaterThanOrEqual", this._SyncTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("syncTimeLessThanOrEqual", this._SyncTimeLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("fileTypeEqual", this._FileTypeEqual);
			kparams.AddIfNotNull("fileTypeIn", this._FileTypeIn);
			kparams.AddIfNotNull("linkedIdEqual", this._LinkedIdEqual);
			kparams.AddIfNotNull("linkCountGreaterThanOrEqual", this._LinkCountGreaterThanOrEqual);
			kparams.AddIfNotNull("linkCountLessThanOrEqual", this._LinkCountLessThanOrEqual);
			kparams.AddIfNotNull("fileSizeGreaterThanOrEqual", this._FileSizeGreaterThanOrEqual);
			kparams.AddIfNotNull("fileSizeLessThanOrEqual", this._FileSizeLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case FILE_OBJECT_TYPE_EQUAL:
					return "FileObjectTypeEqual";
				case FILE_OBJECT_TYPE_IN:
					return "FileObjectTypeIn";
				case OBJECT_ID_EQUAL:
					return "ObjectIdEqual";
				case OBJECT_ID_IN:
					return "ObjectIdIn";
				case VERSION_EQUAL:
					return "VersionEqual";
				case VERSION_IN:
					return "VersionIn";
				case OBJECT_SUB_TYPE_EQUAL:
					return "ObjectSubTypeEqual";
				case OBJECT_SUB_TYPE_IN:
					return "ObjectSubTypeIn";
				case DC_EQUAL:
					return "DcEqual";
				case DC_IN:
					return "DcIn";
				case ORIGINAL_EQUAL:
					return "OriginalEqual";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case READY_AT_GREATER_THAN_OR_EQUAL:
					return "ReadyAtGreaterThanOrEqual";
				case READY_AT_LESS_THAN_OR_EQUAL:
					return "ReadyAtLessThanOrEqual";
				case SYNC_TIME_GREATER_THAN_OR_EQUAL:
					return "SyncTimeGreaterThanOrEqual";
				case SYNC_TIME_LESS_THAN_OR_EQUAL:
					return "SyncTimeLessThanOrEqual";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case FILE_TYPE_EQUAL:
					return "FileTypeEqual";
				case FILE_TYPE_IN:
					return "FileTypeIn";
				case LINKED_ID_EQUAL:
					return "LinkedIdEqual";
				case LINK_COUNT_GREATER_THAN_OR_EQUAL:
					return "LinkCountGreaterThanOrEqual";
				case LINK_COUNT_LESS_THAN_OR_EQUAL:
					return "LinkCountLessThanOrEqual";
				case FILE_SIZE_GREATER_THAN_OR_EQUAL:
					return "FileSizeGreaterThanOrEqual";
				case FILE_SIZE_LESS_THAN_OR_EQUAL:
					return "FileSizeLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

