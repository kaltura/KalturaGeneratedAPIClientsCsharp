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
		private double _FileSizeGreaterThanOrEqual = Double.MinValue;
		private double _FileSizeLessThanOrEqual = Double.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use PartnerIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		/// <summary>
		/// Use FileObjectTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncObjectType FileObjectTypeEqual
		{
			get { return _FileObjectTypeEqual; }
			set 
			{ 
				_FileObjectTypeEqual = value;
				OnPropertyChanged("FileObjectTypeEqual");
			}
		}
		/// <summary>
		/// Use FileObjectTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileObjectTypeIn
		{
			get { return _FileObjectTypeIn; }
			set 
			{ 
				_FileObjectTypeIn = value;
				OnPropertyChanged("FileObjectTypeIn");
			}
		}
		/// <summary>
		/// Use ObjectIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		/// <summary>
		/// Use ObjectIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		/// <summary>
		/// Use VersionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		/// <summary>
		/// Use VersionInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionIn
		{
			get { return _VersionIn; }
			set 
			{ 
				_VersionIn = value;
				OnPropertyChanged("VersionIn");
			}
		}
		/// <summary>
		/// Use ObjectSubTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ObjectSubTypeEqual
		{
			get { return _ObjectSubTypeEqual; }
			set 
			{ 
				_ObjectSubTypeEqual = value;
				OnPropertyChanged("ObjectSubTypeEqual");
			}
		}
		/// <summary>
		/// Use ObjectSubTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjectSubTypeIn
		{
			get { return _ObjectSubTypeIn; }
			set 
			{ 
				_ObjectSubTypeIn = value;
				OnPropertyChanged("ObjectSubTypeIn");
			}
		}
		/// <summary>
		/// Use DcEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		/// <summary>
		/// Use DcInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		/// <summary>
		/// Use OriginalEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int OriginalEqual
		{
			get { return _OriginalEqual; }
			set 
			{ 
				_OriginalEqual = value;
				OnPropertyChanged("OriginalEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use CreatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use UpdatedAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use ReadyAtGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ReadyAtGreaterThanOrEqual
		{
			get { return _ReadyAtGreaterThanOrEqual; }
			set 
			{ 
				_ReadyAtGreaterThanOrEqual = value;
				OnPropertyChanged("ReadyAtGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use ReadyAtLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ReadyAtLessThanOrEqual
		{
			get { return _ReadyAtLessThanOrEqual; }
			set 
			{ 
				_ReadyAtLessThanOrEqual = value;
				OnPropertyChanged("ReadyAtLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use SyncTimeGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SyncTimeGreaterThanOrEqual
		{
			get { return _SyncTimeGreaterThanOrEqual; }
			set 
			{ 
				_SyncTimeGreaterThanOrEqual = value;
				OnPropertyChanged("SyncTimeGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use SyncTimeLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SyncTimeLessThanOrEqual
		{
			get { return _SyncTimeLessThanOrEqual; }
			set 
			{ 
				_SyncTimeLessThanOrEqual = value;
				OnPropertyChanged("SyncTimeLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use FileTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileSyncType FileTypeEqual
		{
			get { return _FileTypeEqual; }
			set 
			{ 
				_FileTypeEqual = value;
				OnPropertyChanged("FileTypeEqual");
			}
		}
		/// <summary>
		/// Use FileTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileTypeIn
		{
			get { return _FileTypeIn; }
			set 
			{ 
				_FileTypeIn = value;
				OnPropertyChanged("FileTypeIn");
			}
		}
		/// <summary>
		/// Use LinkedIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinkedIdEqual
		{
			get { return _LinkedIdEqual; }
			set 
			{ 
				_LinkedIdEqual = value;
				OnPropertyChanged("LinkedIdEqual");
			}
		}
		/// <summary>
		/// Use LinkCountGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinkCountGreaterThanOrEqual
		{
			get { return _LinkCountGreaterThanOrEqual; }
			set 
			{ 
				_LinkCountGreaterThanOrEqual = value;
				OnPropertyChanged("LinkCountGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use LinkCountLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int LinkCountLessThanOrEqual
		{
			get { return _LinkCountLessThanOrEqual; }
			set 
			{ 
				_LinkCountLessThanOrEqual = value;
				OnPropertyChanged("LinkCountLessThanOrEqual");
			}
		}
		/// <summary>
		/// Use FileSizeGreaterThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FileSizeGreaterThanOrEqual
		{
			get { return _FileSizeGreaterThanOrEqual; }
			set 
			{ 
				_FileSizeGreaterThanOrEqual = value;
				OnPropertyChanged("FileSizeGreaterThanOrEqual");
			}
		}
		/// <summary>
		/// Use FileSizeLessThanOrEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FileSizeLessThanOrEqual
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

		public FileSyncBaseFilter(JToken node) : base(node)
		{
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["fileObjectTypeEqual"] != null)
			{
				this._FileObjectTypeEqual = (FileSyncObjectType)StringEnum.Parse(typeof(FileSyncObjectType), node["fileObjectTypeEqual"].Value<string>());
			}
			if(node["fileObjectTypeIn"] != null)
			{
				this._FileObjectTypeIn = node["fileObjectTypeIn"].Value<string>();
			}
			if(node["objectIdEqual"] != null)
			{
				this._ObjectIdEqual = node["objectIdEqual"].Value<string>();
			}
			if(node["objectIdIn"] != null)
			{
				this._ObjectIdIn = node["objectIdIn"].Value<string>();
			}
			if(node["versionEqual"] != null)
			{
				this._VersionEqual = node["versionEqual"].Value<string>();
			}
			if(node["versionIn"] != null)
			{
				this._VersionIn = node["versionIn"].Value<string>();
			}
			if(node["objectSubTypeEqual"] != null)
			{
				this._ObjectSubTypeEqual = ParseInt(node["objectSubTypeEqual"].Value<string>());
			}
			if(node["objectSubTypeIn"] != null)
			{
				this._ObjectSubTypeIn = node["objectSubTypeIn"].Value<string>();
			}
			if(node["dcEqual"] != null)
			{
				this._DcEqual = node["dcEqual"].Value<string>();
			}
			if(node["dcIn"] != null)
			{
				this._DcIn = node["dcIn"].Value<string>();
			}
			if(node["originalEqual"] != null)
			{
				this._OriginalEqual = ParseInt(node["originalEqual"].Value<string>());
			}
			if(node["createdAtGreaterThanOrEqual"] != null)
			{
				this._CreatedAtGreaterThanOrEqual = ParseInt(node["createdAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["createdAtLessThanOrEqual"] != null)
			{
				this._CreatedAtLessThanOrEqual = ParseInt(node["createdAtLessThanOrEqual"].Value<string>());
			}
			if(node["updatedAtGreaterThanOrEqual"] != null)
			{
				this._UpdatedAtGreaterThanOrEqual = ParseInt(node["updatedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["updatedAtLessThanOrEqual"] != null)
			{
				this._UpdatedAtLessThanOrEqual = ParseInt(node["updatedAtLessThanOrEqual"].Value<string>());
			}
			if(node["readyAtGreaterThanOrEqual"] != null)
			{
				this._ReadyAtGreaterThanOrEqual = ParseInt(node["readyAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["readyAtLessThanOrEqual"] != null)
			{
				this._ReadyAtLessThanOrEqual = ParseInt(node["readyAtLessThanOrEqual"].Value<string>());
			}
			if(node["syncTimeGreaterThanOrEqual"] != null)
			{
				this._SyncTimeGreaterThanOrEqual = ParseInt(node["syncTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["syncTimeLessThanOrEqual"] != null)
			{
				this._SyncTimeLessThanOrEqual = ParseInt(node["syncTimeLessThanOrEqual"].Value<string>());
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (FileSyncStatus)ParseEnum(typeof(FileSyncStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["fileTypeEqual"] != null)
			{
				this._FileTypeEqual = (FileSyncType)ParseEnum(typeof(FileSyncType), node["fileTypeEqual"].Value<string>());
			}
			if(node["fileTypeIn"] != null)
			{
				this._FileTypeIn = node["fileTypeIn"].Value<string>();
			}
			if(node["linkedIdEqual"] != null)
			{
				this._LinkedIdEqual = ParseInt(node["linkedIdEqual"].Value<string>());
			}
			if(node["linkCountGreaterThanOrEqual"] != null)
			{
				this._LinkCountGreaterThanOrEqual = ParseInt(node["linkCountGreaterThanOrEqual"].Value<string>());
			}
			if(node["linkCountLessThanOrEqual"] != null)
			{
				this._LinkCountLessThanOrEqual = ParseInt(node["linkCountLessThanOrEqual"].Value<string>());
			}
			if(node["fileSizeGreaterThanOrEqual"] != null)
			{
				this._FileSizeGreaterThanOrEqual = ParseDouble(node["fileSizeGreaterThanOrEqual"].Value<string>());
			}
			if(node["fileSizeLessThanOrEqual"] != null)
			{
				this._FileSizeLessThanOrEqual = ParseDouble(node["fileSizeLessThanOrEqual"].Value<string>());
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

