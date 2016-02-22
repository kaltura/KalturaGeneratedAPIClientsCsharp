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
	public class KalturaDropFolderBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _NameLike = null;
		private KalturaDropFolderType _TypeEqual = null;
		private string _TypeIn = null;
		private KalturaDropFolderStatus _StatusEqual = (KalturaDropFolderStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private string _ConversionProfileIdIn = null;
		private int _DcEqual = Int32.MinValue;
		private string _DcIn = null;
		private string _PathEqual = null;
		private string _PathLike = null;
		private KalturaDropFolderFileHandlerType _FileHandlerTypeEqual = null;
		private string _FileHandlerTypeIn = null;
		private string _FileNamePatternsLike = null;
		private string _FileNamePatternsMultiLikeOr = null;
		private string _FileNamePatternsMultiLikeAnd = null;
		private string _TagsLike = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private KalturaDropFolderErrorCode _ErrorCodeEqual = null;
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
		public KalturaDropFolderType TypeEqual
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
		public KalturaDropFolderStatus StatusEqual
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
		public KalturaDropFolderFileHandlerType FileHandlerTypeEqual
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
		public KalturaDropFolderErrorCode ErrorCodeEqual
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
		public KalturaDropFolderBaseFilter()
		{
		}

		public KalturaDropFolderBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "typeEqual":
						this.TypeEqual = (KalturaDropFolderType)KalturaStringEnum.Parse(typeof(KalturaDropFolderType), txt);
						continue;
					case "typeIn":
						this.TypeIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaDropFolderStatus)ParseEnum(typeof(KalturaDropFolderStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "conversionProfileIdEqual":
						this.ConversionProfileIdEqual = ParseInt(txt);
						continue;
					case "conversionProfileIdIn":
						this.ConversionProfileIdIn = txt;
						continue;
					case "dcEqual":
						this.DcEqual = ParseInt(txt);
						continue;
					case "dcIn":
						this.DcIn = txt;
						continue;
					case "pathEqual":
						this.PathEqual = txt;
						continue;
					case "pathLike":
						this.PathLike = txt;
						continue;
					case "fileHandlerTypeEqual":
						this.FileHandlerTypeEqual = (KalturaDropFolderFileHandlerType)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileHandlerType), txt);
						continue;
					case "fileHandlerTypeIn":
						this.FileHandlerTypeIn = txt;
						continue;
					case "fileNamePatternsLike":
						this.FileNamePatternsLike = txt;
						continue;
					case "fileNamePatternsMultiLikeOr":
						this.FileNamePatternsMultiLikeOr = txt;
						continue;
					case "fileNamePatternsMultiLikeAnd":
						this.FileNamePatternsMultiLikeAnd = txt;
						continue;
					case "tagsLike":
						this.TagsLike = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
						continue;
					case "errorCodeEqual":
						this.ErrorCodeEqual = (KalturaDropFolderErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderErrorCode), txt);
						continue;
					case "errorCodeIn":
						this.ErrorCodeIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDropFolderBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIfNotNull("nameLike", this.NameLike);
			kparams.AddIfNotNull("typeEqual", this.TypeEqual);
			kparams.AddIfNotNull("typeIn", this.TypeIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("conversionProfileIdEqual", this.ConversionProfileIdEqual);
			kparams.AddIfNotNull("conversionProfileIdIn", this.ConversionProfileIdIn);
			kparams.AddIfNotNull("dcEqual", this.DcEqual);
			kparams.AddIfNotNull("dcIn", this.DcIn);
			kparams.AddIfNotNull("pathEqual", this.PathEqual);
			kparams.AddIfNotNull("pathLike", this.PathLike);
			kparams.AddIfNotNull("fileHandlerTypeEqual", this.FileHandlerTypeEqual);
			kparams.AddIfNotNull("fileHandlerTypeIn", this.FileHandlerTypeIn);
			kparams.AddIfNotNull("fileNamePatternsLike", this.FileNamePatternsLike);
			kparams.AddIfNotNull("fileNamePatternsMultiLikeOr", this.FileNamePatternsMultiLikeOr);
			kparams.AddIfNotNull("fileNamePatternsMultiLikeAnd", this.FileNamePatternsMultiLikeAnd);
			kparams.AddIfNotNull("tagsLike", this.TagsLike);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("errorCodeEqual", this.ErrorCodeEqual);
			kparams.AddIfNotNull("errorCodeIn", this.ErrorCodeIn);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

