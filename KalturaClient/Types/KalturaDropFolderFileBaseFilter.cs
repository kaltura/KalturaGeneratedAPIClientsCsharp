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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaDropFolderFileBaseFilter : KalturaFilter
	{
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
		private KalturaDropFolderFileStatus _StatusEqual = (KalturaDropFolderFileStatus)Int32.MinValue;
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
		private KalturaDropFolderFileErrorCode _ErrorCodeEqual = null;
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
		public int DropFolderIdEqual
		{
			get { return _DropFolderIdEqual; }
			set 
			{ 
				_DropFolderIdEqual = value;
				OnPropertyChanged("DropFolderIdEqual");
			}
		}
		public string DropFolderIdIn
		{
			get { return _DropFolderIdIn; }
			set 
			{ 
				_DropFolderIdIn = value;
				OnPropertyChanged("DropFolderIdIn");
			}
		}
		public string FileNameEqual
		{
			get { return _FileNameEqual; }
			set 
			{ 
				_FileNameEqual = value;
				OnPropertyChanged("FileNameEqual");
			}
		}
		public string FileNameIn
		{
			get { return _FileNameIn; }
			set 
			{ 
				_FileNameIn = value;
				OnPropertyChanged("FileNameIn");
			}
		}
		public string FileNameLike
		{
			get { return _FileNameLike; }
			set 
			{ 
				_FileNameLike = value;
				OnPropertyChanged("FileNameLike");
			}
		}
		public KalturaDropFolderFileStatus StatusEqual
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
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		public string ParsedSlugEqual
		{
			get { return _ParsedSlugEqual; }
			set 
			{ 
				_ParsedSlugEqual = value;
				OnPropertyChanged("ParsedSlugEqual");
			}
		}
		public string ParsedSlugIn
		{
			get { return _ParsedSlugIn; }
			set 
			{ 
				_ParsedSlugIn = value;
				OnPropertyChanged("ParsedSlugIn");
			}
		}
		public string ParsedSlugLike
		{
			get { return _ParsedSlugLike; }
			set 
			{ 
				_ParsedSlugLike = value;
				OnPropertyChanged("ParsedSlugLike");
			}
		}
		public string ParsedFlavorEqual
		{
			get { return _ParsedFlavorEqual; }
			set 
			{ 
				_ParsedFlavorEqual = value;
				OnPropertyChanged("ParsedFlavorEqual");
			}
		}
		public string ParsedFlavorIn
		{
			get { return _ParsedFlavorIn; }
			set 
			{ 
				_ParsedFlavorIn = value;
				OnPropertyChanged("ParsedFlavorIn");
			}
		}
		public string ParsedFlavorLike
		{
			get { return _ParsedFlavorLike; }
			set 
			{ 
				_ParsedFlavorLike = value;
				OnPropertyChanged("ParsedFlavorLike");
			}
		}
		public int LeadDropFolderFileIdEqual
		{
			get { return _LeadDropFolderFileIdEqual; }
			set 
			{ 
				_LeadDropFolderFileIdEqual = value;
				OnPropertyChanged("LeadDropFolderFileIdEqual");
			}
		}
		public int DeletedDropFolderFileIdEqual
		{
			get { return _DeletedDropFolderFileIdEqual; }
			set 
			{ 
				_DeletedDropFolderFileIdEqual = value;
				OnPropertyChanged("DeletedDropFolderFileIdEqual");
			}
		}
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		public KalturaDropFolderFileErrorCode ErrorCodeEqual
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
		public KalturaDropFolderFileBaseFilter()
		{
		}

		public KalturaDropFolderFileBaseFilter(XmlElement node) : base(node)
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
					case "dropFolderIdEqual":
						this.DropFolderIdEqual = ParseInt(txt);
						continue;
					case "dropFolderIdIn":
						this.DropFolderIdIn = txt;
						continue;
					case "fileNameEqual":
						this.FileNameEqual = txt;
						continue;
					case "fileNameIn":
						this.FileNameIn = txt;
						continue;
					case "fileNameLike":
						this.FileNameLike = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaDropFolderFileStatus)ParseEnum(typeof(KalturaDropFolderFileStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
						continue;
					case "parsedSlugEqual":
						this.ParsedSlugEqual = txt;
						continue;
					case "parsedSlugIn":
						this.ParsedSlugIn = txt;
						continue;
					case "parsedSlugLike":
						this.ParsedSlugLike = txt;
						continue;
					case "parsedFlavorEqual":
						this.ParsedFlavorEqual = txt;
						continue;
					case "parsedFlavorIn":
						this.ParsedFlavorIn = txt;
						continue;
					case "parsedFlavorLike":
						this.ParsedFlavorLike = txt;
						continue;
					case "leadDropFolderFileIdEqual":
						this.LeadDropFolderFileIdEqual = ParseInt(txt);
						continue;
					case "deletedDropFolderFileIdEqual":
						this.DeletedDropFolderFileIdEqual = ParseInt(txt);
						continue;
					case "entryIdEqual":
						this.EntryIdEqual = txt;
						continue;
					case "errorCodeEqual":
						this.ErrorCodeEqual = (KalturaDropFolderFileErrorCode)KalturaStringEnum.Parse(typeof(KalturaDropFolderFileErrorCode), txt);
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
			kparams.AddReplace("objectType", "KalturaDropFolderFileBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIfNotNull("dropFolderIdEqual", this.DropFolderIdEqual);
			kparams.AddIfNotNull("dropFolderIdIn", this.DropFolderIdIn);
			kparams.AddIfNotNull("fileNameEqual", this.FileNameEqual);
			kparams.AddIfNotNull("fileNameIn", this.FileNameIn);
			kparams.AddIfNotNull("fileNameLike", this.FileNameLike);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("statusNotIn", this.StatusNotIn);
			kparams.AddIfNotNull("parsedSlugEqual", this.ParsedSlugEqual);
			kparams.AddIfNotNull("parsedSlugIn", this.ParsedSlugIn);
			kparams.AddIfNotNull("parsedSlugLike", this.ParsedSlugLike);
			kparams.AddIfNotNull("parsedFlavorEqual", this.ParsedFlavorEqual);
			kparams.AddIfNotNull("parsedFlavorIn", this.ParsedFlavorIn);
			kparams.AddIfNotNull("parsedFlavorLike", this.ParsedFlavorLike);
			kparams.AddIfNotNull("leadDropFolderFileIdEqual", this.LeadDropFolderFileIdEqual);
			kparams.AddIfNotNull("deletedDropFolderFileIdEqual", this.DeletedDropFolderFileIdEqual);
			kparams.AddIfNotNull("entryIdEqual", this.EntryIdEqual);
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

