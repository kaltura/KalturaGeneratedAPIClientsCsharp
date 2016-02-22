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
	public class KalturaUiConfBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _NameLike = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private KalturaUiConfObjType _ObjTypeEqual = (KalturaUiConfObjType)Int32.MinValue;
		private string _ObjTypeIn = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private KalturaUiConfCreationMode _CreationModeEqual = (KalturaUiConfCreationMode)Int32.MinValue;
		private string _CreationModeIn = null;
		private string _VersionEqual = null;
		private string _VersionMultiLikeOr = null;
		private string _VersionMultiLikeAnd = null;
		private string _PartnerTagsMultiLikeOr = null;
		private string _PartnerTagsMultiLikeAnd = null;
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
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
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
		public KalturaUiConfObjType ObjTypeEqual
		{
			get { return _ObjTypeEqual; }
			set 
			{ 
				_ObjTypeEqual = value;
				OnPropertyChanged("ObjTypeEqual");
			}
		}
		public string ObjTypeIn
		{
			get { return _ObjTypeIn; }
			set 
			{ 
				_ObjTypeIn = value;
				OnPropertyChanged("ObjTypeIn");
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
		public KalturaUiConfCreationMode CreationModeEqual
		{
			get { return _CreationModeEqual; }
			set 
			{ 
				_CreationModeEqual = value;
				OnPropertyChanged("CreationModeEqual");
			}
		}
		public string CreationModeIn
		{
			get { return _CreationModeIn; }
			set 
			{ 
				_CreationModeIn = value;
				OnPropertyChanged("CreationModeIn");
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
		public string VersionMultiLikeOr
		{
			get { return _VersionMultiLikeOr; }
			set 
			{ 
				_VersionMultiLikeOr = value;
				OnPropertyChanged("VersionMultiLikeOr");
			}
		}
		public string VersionMultiLikeAnd
		{
			get { return _VersionMultiLikeAnd; }
			set 
			{ 
				_VersionMultiLikeAnd = value;
				OnPropertyChanged("VersionMultiLikeAnd");
			}
		}
		public string PartnerTagsMultiLikeOr
		{
			get { return _PartnerTagsMultiLikeOr; }
			set 
			{ 
				_PartnerTagsMultiLikeOr = value;
				OnPropertyChanged("PartnerTagsMultiLikeOr");
			}
		}
		public string PartnerTagsMultiLikeAnd
		{
			get { return _PartnerTagsMultiLikeAnd; }
			set 
			{ 
				_PartnerTagsMultiLikeAnd = value;
				OnPropertyChanged("PartnerTagsMultiLikeAnd");
			}
		}
		#endregion

		#region CTor
		public KalturaUiConfBaseFilter()
		{
		}

		public KalturaUiConfBaseFilter(XmlElement node) : base(node)
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
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "objTypeEqual":
						this.ObjTypeEqual = (KalturaUiConfObjType)ParseEnum(typeof(KalturaUiConfObjType), txt);
						continue;
					case "objTypeIn":
						this.ObjTypeIn = txt;
						continue;
					case "tagsMultiLikeOr":
						this.TagsMultiLikeOr = txt;
						continue;
					case "tagsMultiLikeAnd":
						this.TagsMultiLikeAnd = txt;
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
					case "creationModeEqual":
						this.CreationModeEqual = (KalturaUiConfCreationMode)ParseEnum(typeof(KalturaUiConfCreationMode), txt);
						continue;
					case "creationModeIn":
						this.CreationModeIn = txt;
						continue;
					case "versionEqual":
						this.VersionEqual = txt;
						continue;
					case "versionMultiLikeOr":
						this.VersionMultiLikeOr = txt;
						continue;
					case "versionMultiLikeAnd":
						this.VersionMultiLikeAnd = txt;
						continue;
					case "partnerTagsMultiLikeOr":
						this.PartnerTagsMultiLikeOr = txt;
						continue;
					case "partnerTagsMultiLikeAnd":
						this.PartnerTagsMultiLikeAnd = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaUiConfBaseFilter");
			kparams.AddIfNotNull("idEqual", this.IdEqual);
			kparams.AddIfNotNull("idIn", this.IdIn);
			kparams.AddIfNotNull("nameLike", this.NameLike);
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddIfNotNull("objTypeEqual", this.ObjTypeEqual);
			kparams.AddIfNotNull("objTypeIn", this.ObjTypeIn);
			kparams.AddIfNotNull("tagsMultiLikeOr", this.TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this.TagsMultiLikeAnd);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("creationModeEqual", this.CreationModeEqual);
			kparams.AddIfNotNull("creationModeIn", this.CreationModeIn);
			kparams.AddIfNotNull("versionEqual", this.VersionEqual);
			kparams.AddIfNotNull("versionMultiLikeOr", this.VersionMultiLikeOr);
			kparams.AddIfNotNull("versionMultiLikeAnd", this.VersionMultiLikeAnd);
			kparams.AddIfNotNull("partnerTagsMultiLikeOr", this.PartnerTagsMultiLikeOr);
			kparams.AddIfNotNull("partnerTagsMultiLikeAnd", this.PartnerTagsMultiLikeAnd);
			return kparams;
		}
		#endregion
	}
}

