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
	public class DropFolderBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string NAME_LIKE = "nameLike";
		public const string TYPE_EQUAL = "typeEqual";
		public const string TYPE_IN = "typeIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string CONVERSION_PROFILE_ID_EQUAL = "conversionProfileIdEqual";
		public const string CONVERSION_PROFILE_ID_IN = "conversionProfileIdIn";
		public const string DC_EQUAL = "dcEqual";
		public const string DC_IN = "dcIn";
		public const string PATH_EQUAL = "pathEqual";
		public const string PATH_LIKE = "pathLike";
		public const string FILE_HANDLER_TYPE_EQUAL = "fileHandlerTypeEqual";
		public const string FILE_HANDLER_TYPE_IN = "fileHandlerTypeIn";
		public const string FILE_NAME_PATTERNS_LIKE = "fileNamePatternsLike";
		public const string FILE_NAME_PATTERNS_MULTI_LIKE_OR = "fileNamePatternsMultiLikeOr";
		public const string FILE_NAME_PATTERNS_MULTI_LIKE_AND = "fileNamePatternsMultiLikeAnd";
		public const string TAGS_LIKE = "tagsLike";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
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
		private string _NameLike = null;
		private DropFolderType _TypeEqual = null;
		private string _TypeIn = null;
		private DropFolderStatus _StatusEqual = (DropFolderStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private string _ConversionProfileIdIn = null;
		private int _DcEqual = Int32.MinValue;
		private string _DcIn = null;
		private string _PathEqual = null;
		private string _PathLike = null;
		private DropFolderFileHandlerType _FileHandlerTypeEqual = null;
		private string _FileHandlerTypeIn = null;
		private string _FileNamePatternsLike = null;
		private string _FileNamePatternsMultiLikeOr = null;
		private string _FileNamePatternsMultiLikeAnd = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private DropFolderErrorCode _ErrorCodeEqual = null;
		private string _ErrorCodeIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdEqualAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use IdInAsDouble property instead
		/// </summary>
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
		/// Use PartnerIdInAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use NameLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		/// <summary>
		/// Use TypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DropFolderType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		/// <summary>
		/// Use TypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DropFolderStatus StatusEqual
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
		/// Use ConversionProfileIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileIdEqual
		{
			get { return _ConversionProfileIdEqual; }
			set 
			{ 
				_ConversionProfileIdEqual = value;
				OnPropertyChanged("ConversionProfileIdEqual");
			}
		}
		/// <summary>
		/// Use ConversionProfileIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ConversionProfileIdIn
		{
			get { return _ConversionProfileIdIn; }
			set 
			{ 
				_ConversionProfileIdIn = value;
				OnPropertyChanged("ConversionProfileIdIn");
			}
		}
		/// <summary>
		/// Use DcEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DcEqual
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
		/// Use PathEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PathEqual
		{
			get { return _PathEqual; }
			set 
			{ 
				_PathEqual = value;
				OnPropertyChanged("PathEqual");
			}
		}
		/// <summary>
		/// Use PathLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PathLike
		{
			get { return _PathLike; }
			set 
			{ 
				_PathLike = value;
				OnPropertyChanged("PathLike");
			}
		}
		/// <summary>
		/// Use FileHandlerTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DropFolderFileHandlerType FileHandlerTypeEqual
		{
			get { return _FileHandlerTypeEqual; }
			set 
			{ 
				_FileHandlerTypeEqual = value;
				OnPropertyChanged("FileHandlerTypeEqual");
			}
		}
		/// <summary>
		/// Use FileHandlerTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileHandlerTypeIn
		{
			get { return _FileHandlerTypeIn; }
			set 
			{ 
				_FileHandlerTypeIn = value;
				OnPropertyChanged("FileHandlerTypeIn");
			}
		}
		/// <summary>
		/// Use FileNamePatternsLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNamePatternsLike
		{
			get { return _FileNamePatternsLike; }
			set 
			{ 
				_FileNamePatternsLike = value;
				OnPropertyChanged("FileNamePatternsLike");
			}
		}
		/// <summary>
		/// Use FileNamePatternsMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNamePatternsMultiLikeOr
		{
			get { return _FileNamePatternsMultiLikeOr; }
			set 
			{ 
				_FileNamePatternsMultiLikeOr = value;
				OnPropertyChanged("FileNamePatternsMultiLikeOr");
			}
		}
		/// <summary>
		/// Use FileNamePatternsMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FileNamePatternsMultiLikeAnd
		{
			get { return _FileNamePatternsMultiLikeAnd; }
			set 
			{ 
				_FileNamePatternsMultiLikeAnd = value;
				OnPropertyChanged("FileNamePatternsMultiLikeAnd");
			}
		}
		/// <summary>
		/// Use TagsLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		/// <summary>
		/// Use TagsMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		/// <summary>
		/// Use TagsMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		/// <summary>
		/// Use ErrorCodeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DropFolderErrorCode ErrorCodeEqual
		{
			get { return _ErrorCodeEqual; }
			set 
			{ 
				_ErrorCodeEqual = value;
				OnPropertyChanged("ErrorCodeEqual");
			}
		}
		/// <summary>
		/// Use ErrorCodeInAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public DropFolderBaseFilter()
		{
		}

		public DropFolderBaseFilter(JToken node) : base(node)
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
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["typeEqual"] != null)
			{
				this._TypeEqual = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), node["typeEqual"].Value<string>());
			}
			if(node["typeIn"] != null)
			{
				this._TypeIn = node["typeIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (DropFolderStatus)ParseEnum(typeof(DropFolderStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["conversionProfileIdEqual"] != null)
			{
				this._ConversionProfileIdEqual = ParseInt(node["conversionProfileIdEqual"].Value<string>());
			}
			if(node["conversionProfileIdIn"] != null)
			{
				this._ConversionProfileIdIn = node["conversionProfileIdIn"].Value<string>();
			}
			if(node["dcEqual"] != null)
			{
				this._DcEqual = ParseInt(node["dcEqual"].Value<string>());
			}
			if(node["dcIn"] != null)
			{
				this._DcIn = node["dcIn"].Value<string>();
			}
			if(node["pathEqual"] != null)
			{
				this._PathEqual = node["pathEqual"].Value<string>();
			}
			if(node["pathLike"] != null)
			{
				this._PathLike = node["pathLike"].Value<string>();
			}
			if(node["fileHandlerTypeEqual"] != null)
			{
				this._FileHandlerTypeEqual = (DropFolderFileHandlerType)StringEnum.Parse(typeof(DropFolderFileHandlerType), node["fileHandlerTypeEqual"].Value<string>());
			}
			if(node["fileHandlerTypeIn"] != null)
			{
				this._FileHandlerTypeIn = node["fileHandlerTypeIn"].Value<string>();
			}
			if(node["fileNamePatternsLike"] != null)
			{
				this._FileNamePatternsLike = node["fileNamePatternsLike"].Value<string>();
			}
			if(node["fileNamePatternsMultiLikeOr"] != null)
			{
				this._FileNamePatternsMultiLikeOr = node["fileNamePatternsMultiLikeOr"].Value<string>();
			}
			if(node["fileNamePatternsMultiLikeAnd"] != null)
			{
				this._FileNamePatternsMultiLikeAnd = node["fileNamePatternsMultiLikeAnd"].Value<string>();
			}
			if(node["tagsLike"] != null)
			{
				this._TagsLike = node["tagsLike"].Value<string>();
			}
			if(node["tagsMultiLikeOr"] != null)
			{
				this._TagsMultiLikeOr = node["tagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsMultiLikeAnd"] != null)
			{
				this._TagsMultiLikeAnd = node["tagsMultiLikeAnd"].Value<string>();
			}
			if(node["errorCodeEqual"] != null)
			{
				this._ErrorCodeEqual = (DropFolderErrorCode)StringEnum.Parse(typeof(DropFolderErrorCode), node["errorCodeEqual"].Value<string>());
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
				kparams.AddReplace("objectType", "KalturaDropFolderBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("typeEqual", this._TypeEqual);
			kparams.AddIfNotNull("typeIn", this._TypeIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("conversionProfileIdEqual", this._ConversionProfileIdEqual);
			kparams.AddIfNotNull("conversionProfileIdIn", this._ConversionProfileIdIn);
			kparams.AddIfNotNull("dcEqual", this._DcEqual);
			kparams.AddIfNotNull("dcIn", this._DcIn);
			kparams.AddIfNotNull("pathEqual", this._PathEqual);
			kparams.AddIfNotNull("pathLike", this._PathLike);
			kparams.AddIfNotNull("fileHandlerTypeEqual", this._FileHandlerTypeEqual);
			kparams.AddIfNotNull("fileHandlerTypeIn", this._FileHandlerTypeIn);
			kparams.AddIfNotNull("fileNamePatternsLike", this._FileNamePatternsLike);
			kparams.AddIfNotNull("fileNamePatternsMultiLikeOr", this._FileNamePatternsMultiLikeOr);
			kparams.AddIfNotNull("fileNamePatternsMultiLikeAnd", this._FileNamePatternsMultiLikeAnd);
			kparams.AddIfNotNull("tagsLike", this._TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
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
				case NAME_LIKE:
					return "NameLike";
				case TYPE_EQUAL:
					return "TypeEqual";
				case TYPE_IN:
					return "TypeIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case CONVERSION_PROFILE_ID_EQUAL:
					return "ConversionProfileIdEqual";
				case CONVERSION_PROFILE_ID_IN:
					return "ConversionProfileIdIn";
				case DC_EQUAL:
					return "DcEqual";
				case DC_IN:
					return "DcIn";
				case PATH_EQUAL:
					return "PathEqual";
				case PATH_LIKE:
					return "PathLike";
				case FILE_HANDLER_TYPE_EQUAL:
					return "FileHandlerTypeEqual";
				case FILE_HANDLER_TYPE_IN:
					return "FileHandlerTypeIn";
				case FILE_NAME_PATTERNS_LIKE:
					return "FileNamePatternsLike";
				case FILE_NAME_PATTERNS_MULTI_LIKE_OR:
					return "FileNamePatternsMultiLikeOr";
				case FILE_NAME_PATTERNS_MULTI_LIKE_AND:
					return "FileNamePatternsMultiLikeAnd";
				case TAGS_LIKE:
					return "TagsLike";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
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

