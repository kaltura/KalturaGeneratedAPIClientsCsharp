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
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public DropFolderType TypeEqual
		{
			get { return _TypeEqual; }
			set 
			{ 
				_TypeEqual = value;
				OnPropertyChanged("TypeEqual");
			}
		}
		public string TypeIn
		{
			get { return _TypeIn; }
			set 
			{ 
				_TypeIn = value;
				OnPropertyChanged("TypeIn");
			}
		}
		public DropFolderStatus StatusEqual
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
		public int ConversionProfileIdEqual
		{
			get { return _ConversionProfileIdEqual; }
			set 
			{ 
				_ConversionProfileIdEqual = value;
				OnPropertyChanged("ConversionProfileIdEqual");
			}
		}
		public string ConversionProfileIdIn
		{
			get { return _ConversionProfileIdIn; }
			set 
			{ 
				_ConversionProfileIdIn = value;
				OnPropertyChanged("ConversionProfileIdIn");
			}
		}
		public int DcEqual
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
		public string PathEqual
		{
			get { return _PathEqual; }
			set 
			{ 
				_PathEqual = value;
				OnPropertyChanged("PathEqual");
			}
		}
		public string PathLike
		{
			get { return _PathLike; }
			set 
			{ 
				_PathLike = value;
				OnPropertyChanged("PathLike");
			}
		}
		public DropFolderFileHandlerType FileHandlerTypeEqual
		{
			get { return _FileHandlerTypeEqual; }
			set 
			{ 
				_FileHandlerTypeEqual = value;
				OnPropertyChanged("FileHandlerTypeEqual");
			}
		}
		public string FileHandlerTypeIn
		{
			get { return _FileHandlerTypeIn; }
			set 
			{ 
				_FileHandlerTypeIn = value;
				OnPropertyChanged("FileHandlerTypeIn");
			}
		}
		public string FileNamePatternsLike
		{
			get { return _FileNamePatternsLike; }
			set 
			{ 
				_FileNamePatternsLike = value;
				OnPropertyChanged("FileNamePatternsLike");
			}
		}
		public string FileNamePatternsMultiLikeOr
		{
			get { return _FileNamePatternsMultiLikeOr; }
			set 
			{ 
				_FileNamePatternsMultiLikeOr = value;
				OnPropertyChanged("FileNamePatternsMultiLikeOr");
			}
		}
		public string FileNamePatternsMultiLikeAnd
		{
			get { return _FileNamePatternsMultiLikeAnd; }
			set 
			{ 
				_FileNamePatternsMultiLikeAnd = value;
				OnPropertyChanged("FileNamePatternsMultiLikeAnd");
			}
		}
		public string TagsLike
		{
			get { return _TagsLike; }
			set 
			{ 
				_TagsLike = value;
				OnPropertyChanged("TagsLike");
			}
		}
		public string TagsMultiLikeOr
		{
			get { return _TagsMultiLikeOr; }
			set 
			{ 
				_TagsMultiLikeOr = value;
				OnPropertyChanged("TagsMultiLikeOr");
			}
		}
		public string TagsMultiLikeAnd
		{
			get { return _TagsMultiLikeAnd; }
			set 
			{ 
				_TagsMultiLikeAnd = value;
				OnPropertyChanged("TagsMultiLikeAnd");
			}
		}
		public DropFolderErrorCode ErrorCodeEqual
		{
			get { return _ErrorCodeEqual; }
			set 
			{ 
				_ErrorCodeEqual = value;
				OnPropertyChanged("ErrorCodeEqual");
			}
		}
		public string ErrorCodeIn
		{
			get { return _ErrorCodeIn; }
			set 
			{ 
				_ErrorCodeIn = value;
				OnPropertyChanged("ErrorCodeIn");
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
		#endregion

		#region CTor
		public DropFolderBaseFilter()
		{
		}

		public DropFolderBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "idEqual":
						this._IdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "idIn":
						this._IdIn = propertyNode.InnerText;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = propertyNode.InnerText;
						continue;
					case "nameLike":
						this._NameLike = propertyNode.InnerText;
						continue;
					case "typeEqual":
						this._TypeEqual = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), propertyNode.InnerText);
						continue;
					case "typeIn":
						this._TypeIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (DropFolderStatus)ParseEnum(typeof(DropFolderStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "conversionProfileIdEqual":
						this._ConversionProfileIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "conversionProfileIdIn":
						this._ConversionProfileIdIn = propertyNode.InnerText;
						continue;
					case "dcEqual":
						this._DcEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "dcIn":
						this._DcIn = propertyNode.InnerText;
						continue;
					case "pathEqual":
						this._PathEqual = propertyNode.InnerText;
						continue;
					case "pathLike":
						this._PathLike = propertyNode.InnerText;
						continue;
					case "fileHandlerTypeEqual":
						this._FileHandlerTypeEqual = (DropFolderFileHandlerType)StringEnum.Parse(typeof(DropFolderFileHandlerType), propertyNode.InnerText);
						continue;
					case "fileHandlerTypeIn":
						this._FileHandlerTypeIn = propertyNode.InnerText;
						continue;
					case "fileNamePatternsLike":
						this._FileNamePatternsLike = propertyNode.InnerText;
						continue;
					case "fileNamePatternsMultiLikeOr":
						this._FileNamePatternsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "fileNamePatternsMultiLikeAnd":
						this._FileNamePatternsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "tagsLike":
						this._TagsLike = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "errorCodeEqual":
						this._ErrorCodeEqual = (DropFolderErrorCode)StringEnum.Parse(typeof(DropFolderErrorCode), propertyNode.InnerText);
						continue;
					case "errorCodeIn":
						this._ErrorCodeIn = propertyNode.InnerText;
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
				}
			}
		}

		public DropFolderBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<int>("idEqual");
			    this._IdIn = data.TryGetValueSafe<string>("idIn");
			    this._PartnerIdEqual = data.TryGetValueSafe<int>("partnerIdEqual");
			    this._PartnerIdIn = data.TryGetValueSafe<string>("partnerIdIn");
			    this._NameLike = data.TryGetValueSafe<string>("nameLike");
			    this._TypeEqual = (DropFolderType)StringEnum.Parse(typeof(DropFolderType), data.TryGetValueSafe<string>("typeEqual"));
			    this._TypeIn = data.TryGetValueSafe<string>("typeIn");
			    this._StatusEqual = (DropFolderStatus)ParseEnum(typeof(DropFolderStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._ConversionProfileIdEqual = data.TryGetValueSafe<int>("conversionProfileIdEqual");
			    this._ConversionProfileIdIn = data.TryGetValueSafe<string>("conversionProfileIdIn");
			    this._DcEqual = data.TryGetValueSafe<int>("dcEqual");
			    this._DcIn = data.TryGetValueSafe<string>("dcIn");
			    this._PathEqual = data.TryGetValueSafe<string>("pathEqual");
			    this._PathLike = data.TryGetValueSafe<string>("pathLike");
			    this._FileHandlerTypeEqual = (DropFolderFileHandlerType)StringEnum.Parse(typeof(DropFolderFileHandlerType), data.TryGetValueSafe<string>("fileHandlerTypeEqual"));
			    this._FileHandlerTypeIn = data.TryGetValueSafe<string>("fileHandlerTypeIn");
			    this._FileNamePatternsLike = data.TryGetValueSafe<string>("fileNamePatternsLike");
			    this._FileNamePatternsMultiLikeOr = data.TryGetValueSafe<string>("fileNamePatternsMultiLikeOr");
			    this._FileNamePatternsMultiLikeAnd = data.TryGetValueSafe<string>("fileNamePatternsMultiLikeAnd");
			    this._TagsLike = data.TryGetValueSafe<string>("tagsLike");
			    this._TagsMultiLikeOr = data.TryGetValueSafe<string>("tagsMultiLikeOr");
			    this._TagsMultiLikeAnd = data.TryGetValueSafe<string>("tagsMultiLikeAnd");
			    this._ErrorCodeEqual = (DropFolderErrorCode)StringEnum.Parse(typeof(DropFolderErrorCode), data.TryGetValueSafe<string>("errorCodeEqual"));
			    this._ErrorCodeIn = data.TryGetValueSafe<string>("errorCodeIn");
			    this._CreatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("createdAtGreaterThanOrEqual");
			    this._CreatedAtLessThanOrEqual = data.TryGetValueSafe<int>("createdAtLessThanOrEqual");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<int>("updatedAtLessThanOrEqual");
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

