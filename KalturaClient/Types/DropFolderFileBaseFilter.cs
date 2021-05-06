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
	public class DropFolderFileBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string DROP_FOLDER_ID_EQUAL = "dropFolderIdEqual";
		public const string DROP_FOLDER_ID_IN = "dropFolderIdIn";
		public const string FILE_NAME_EQUAL = "fileNameEqual";
		public const string FILE_NAME_IN = "fileNameIn";
		public const string FILE_NAME_LIKE = "fileNameLike";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_NOT_IN = "statusNotIn";
		public const string PARSED_SLUG_EQUAL = "parsedSlugEqual";
		public const string PARSED_SLUG_IN = "parsedSlugIn";
		public const string PARSED_SLUG_LIKE = "parsedSlugLike";
		public const string PARSED_FLAVOR_EQUAL = "parsedFlavorEqual";
		public const string PARSED_FLAVOR_IN = "parsedFlavorIn";
		public const string PARSED_FLAVOR_LIKE = "parsedFlavorLike";
		public const string LEAD_DROP_FOLDER_FILE_ID_EQUAL = "leadDropFolderFileIdEqual";
		public const string DELETED_DROP_FOLDER_FILE_ID_EQUAL = "deletedDropFolderFileIdEqual";
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string ERROR_CODE_EQUAL = "errorCodeEqual";
		public const string ERROR_CODE_IN = "errorCodeIn";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private int _DropFolderIdEqual = Int32.MinValue;
		private string _DropFolderIdIn = null;
		private string _FileNameEqual = null;
		private string _FileNameIn = null;
		private string _FileNameLike = null;
		private DropFolderFileStatus _StatusEqual = (DropFolderFileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		private string _ParsedSlugEqual = null;
		private string _ParsedSlugIn = null;
		private string _ParsedSlugLike = null;
		private string _ParsedFlavorEqual = null;
		private string _ParsedFlavorIn = null;
		private string _ParsedFlavorLike = null;
		private int _LeadDropFolderFileIdEqual = Int32.MinValue;
		private int _DeletedDropFolderFileIdEqual = Int32.MinValue;
		private string _EntryIdEqual = null;
		private DropFolderFileErrorCode _ErrorCodeEqual = null;
		private string _ErrorCodeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		[JsonProperty]
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
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
		[JsonProperty]
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		[JsonProperty]
		public int DropFolderIdEqual
		{
			get { return _DropFolderIdEqual; }
			set 
			{ 
				_DropFolderIdEqual = value;
				OnPropertyChanged("DropFolderIdEqual");
			}
		}
		[JsonProperty]
		public string DropFolderIdIn
		{
			get { return _DropFolderIdIn; }
			set 
			{ 
				_DropFolderIdIn = value;
				OnPropertyChanged("DropFolderIdIn");
			}
		}
		[JsonProperty]
		public string FileNameEqual
		{
			get { return _FileNameEqual; }
			set 
			{ 
				_FileNameEqual = value;
				OnPropertyChanged("FileNameEqual");
			}
		}
		[JsonProperty]
		public string FileNameIn
		{
			get { return _FileNameIn; }
			set 
			{ 
				_FileNameIn = value;
				OnPropertyChanged("FileNameIn");
			}
		}
		[JsonProperty]
		public string FileNameLike
		{
			get { return _FileNameLike; }
			set 
			{ 
				_FileNameLike = value;
				OnPropertyChanged("FileNameLike");
			}
		}
		[JsonProperty]
		public DropFolderFileStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
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
		[JsonProperty]
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		[JsonProperty]
		public string ParsedSlugEqual
		{
			get { return _ParsedSlugEqual; }
			set 
			{ 
				_ParsedSlugEqual = value;
				OnPropertyChanged("ParsedSlugEqual");
			}
		}
		[JsonProperty]
		public string ParsedSlugIn
		{
			get { return _ParsedSlugIn; }
			set 
			{ 
				_ParsedSlugIn = value;
				OnPropertyChanged("ParsedSlugIn");
			}
		}
		[JsonProperty]
		public string ParsedSlugLike
		{
			get { return _ParsedSlugLike; }
			set 
			{ 
				_ParsedSlugLike = value;
				OnPropertyChanged("ParsedSlugLike");
			}
		}
		[JsonProperty]
		public string ParsedFlavorEqual
		{
			get { return _ParsedFlavorEqual; }
			set 
			{ 
				_ParsedFlavorEqual = value;
				OnPropertyChanged("ParsedFlavorEqual");
			}
		}
		[JsonProperty]
		public string ParsedFlavorIn
		{
			get { return _ParsedFlavorIn; }
			set 
			{ 
				_ParsedFlavorIn = value;
				OnPropertyChanged("ParsedFlavorIn");
			}
		}
		[JsonProperty]
		public string ParsedFlavorLike
		{
			get { return _ParsedFlavorLike; }
			set 
			{ 
				_ParsedFlavorLike = value;
				OnPropertyChanged("ParsedFlavorLike");
			}
		}
		[JsonProperty]
		public int LeadDropFolderFileIdEqual
		{
			get { return _LeadDropFolderFileIdEqual; }
			set 
			{ 
				_LeadDropFolderFileIdEqual = value;
				OnPropertyChanged("LeadDropFolderFileIdEqual");
			}
		}
		[JsonProperty]
		public int DeletedDropFolderFileIdEqual
		{
			get { return _DeletedDropFolderFileIdEqual; }
			set 
			{ 
				_DeletedDropFolderFileIdEqual = value;
				OnPropertyChanged("DeletedDropFolderFileIdEqual");
			}
		}
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		[JsonProperty]
		public DropFolderFileErrorCode ErrorCodeEqual
		{
			get { return _ErrorCodeEqual; }
			set 
			{ 
				_ErrorCodeEqual = value;
				OnPropertyChanged("ErrorCodeEqual");
			}
		}
		[JsonProperty]
		public string ErrorCodeIn
		{
			get { return _ErrorCodeIn; }
			set 
			{ 
				_ErrorCodeIn = value;
				OnPropertyChanged("ErrorCodeIn");
			}
		}
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
		#endregion

		#region CTor
		public DropFolderFileBaseFilter()
		{
		}

		public DropFolderFileBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["dropFolderIdEqual"] != null)
			{
				this._DropFolderIdEqual = ParseInt(node["dropFolderIdEqual"].Value<string>());
			}
			if(node["dropFolderIdIn"] != null)
			{
				this._DropFolderIdIn = node["dropFolderIdIn"].Value<string>();
			}
			if(node["fileNameEqual"] != null)
			{
				this._FileNameEqual = node["fileNameEqual"].Value<string>();
			}
			if(node["fileNameIn"] != null)
			{
				this._FileNameIn = node["fileNameIn"].Value<string>();
			}
			if(node["fileNameLike"] != null)
			{
				this._FileNameLike = node["fileNameLike"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (DropFolderFileStatus)ParseEnum(typeof(DropFolderFileStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["statusNotIn"] != null)
			{
				this._StatusNotIn = node["statusNotIn"].Value<string>();
			}
			if(node["parsedSlugEqual"] != null)
			{
				this._ParsedSlugEqual = node["parsedSlugEqual"].Value<string>();
			}
			if(node["parsedSlugIn"] != null)
			{
				this._ParsedSlugIn = node["parsedSlugIn"].Value<string>();
			}
			if(node["parsedSlugLike"] != null)
			{
				this._ParsedSlugLike = node["parsedSlugLike"].Value<string>();
			}
			if(node["parsedFlavorEqual"] != null)
			{
				this._ParsedFlavorEqual = node["parsedFlavorEqual"].Value<string>();
			}
			if(node["parsedFlavorIn"] != null)
			{
				this._ParsedFlavorIn = node["parsedFlavorIn"].Value<string>();
			}
			if(node["parsedFlavorLike"] != null)
			{
				this._ParsedFlavorLike = node["parsedFlavorLike"].Value<string>();
			}
			if(node["leadDropFolderFileIdEqual"] != null)
			{
				this._LeadDropFolderFileIdEqual = ParseInt(node["leadDropFolderFileIdEqual"].Value<string>());
			}
			if(node["deletedDropFolderFileIdEqual"] != null)
			{
				this._DeletedDropFolderFileIdEqual = ParseInt(node["deletedDropFolderFileIdEqual"].Value<string>());
			}
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["errorCodeEqual"] != null)
			{
				this._ErrorCodeEqual = (DropFolderFileErrorCode)StringEnum.Parse(typeof(DropFolderFileErrorCode), node["errorCodeEqual"].Value<string>());
			}
			if(node["errorCodeIn"] != null)
			{
				this._ErrorCodeIn = node["errorCodeIn"].Value<string>();
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
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDropFolderFileBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("dropFolderIdEqual", this._DropFolderIdEqual);
			kparams.AddIfNotNull("dropFolderIdIn", this._DropFolderIdIn);
			kparams.AddIfNotNull("fileNameEqual", this._FileNameEqual);
			kparams.AddIfNotNull("fileNameIn", this._FileNameIn);
			kparams.AddIfNotNull("fileNameLike", this._FileNameLike);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			kparams.AddIfNotNull("parsedSlugEqual", this._ParsedSlugEqual);
			kparams.AddIfNotNull("parsedSlugIn", this._ParsedSlugIn);
			kparams.AddIfNotNull("parsedSlugLike", this._ParsedSlugLike);
			kparams.AddIfNotNull("parsedFlavorEqual", this._ParsedFlavorEqual);
			kparams.AddIfNotNull("parsedFlavorIn", this._ParsedFlavorIn);
			kparams.AddIfNotNull("parsedFlavorLike", this._ParsedFlavorLike);
			kparams.AddIfNotNull("leadDropFolderFileIdEqual", this._LeadDropFolderFileIdEqual);
			kparams.AddIfNotNull("deletedDropFolderFileIdEqual", this._DeletedDropFolderFileIdEqual);
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("errorCodeEqual", this._ErrorCodeEqual);
			kparams.AddIfNotNull("errorCodeIn", this._ErrorCodeIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID_EQUAL:
					return "IdEqual";
				case ID_IN:
					return "IdIn";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case DROP_FOLDER_ID_EQUAL:
					return "DropFolderIdEqual";
				case DROP_FOLDER_ID_IN:
					return "DropFolderIdIn";
				case FILE_NAME_EQUAL:
					return "FileNameEqual";
				case FILE_NAME_IN:
					return "FileNameIn";
				case FILE_NAME_LIKE:
					return "FileNameLike";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_NOT_IN:
					return "StatusNotIn";
				case PARSED_SLUG_EQUAL:
					return "ParsedSlugEqual";
				case PARSED_SLUG_IN:
					return "ParsedSlugIn";
				case PARSED_SLUG_LIKE:
					return "ParsedSlugLike";
				case PARSED_FLAVOR_EQUAL:
					return "ParsedFlavorEqual";
				case PARSED_FLAVOR_IN:
					return "ParsedFlavorIn";
				case PARSED_FLAVOR_LIKE:
					return "ParsedFlavorLike";
				case LEAD_DROP_FOLDER_FILE_ID_EQUAL:
					return "LeadDropFolderFileIdEqual";
				case DELETED_DROP_FOLDER_FILE_ID_EQUAL:
					return "DeletedDropFolderFileIdEqual";
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case ERROR_CODE_EQUAL:
					return "ErrorCodeEqual";
				case ERROR_CODE_IN:
					return "ErrorCodeIn";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

