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
	public class UiConfBaseFilter : Filter
	{
		#region Constants
		public const string ID_EQUAL = "idEqual";
		public const string ID_IN = "idIn";
		public const string NAME_LIKE = "nameLike";
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string OBJ_TYPE_EQUAL = "objTypeEqual";
		public const string OBJ_TYPE_IN = "objTypeIn";
		public const string TAGS_MULTI_LIKE_OR = "tagsMultiLikeOr";
		public const string TAGS_MULTI_LIKE_AND = "tagsMultiLikeAnd";
		public const string CREATED_AT_GREATER_THAN_OR_EQUAL = "createdAtGreaterThanOrEqual";
		public const string CREATED_AT_LESS_THAN_OR_EQUAL = "createdAtLessThanOrEqual";
		public const string UPDATED_AT_GREATER_THAN_OR_EQUAL = "updatedAtGreaterThanOrEqual";
		public const string UPDATED_AT_LESS_THAN_OR_EQUAL = "updatedAtLessThanOrEqual";
		public const string CREATION_MODE_EQUAL = "creationModeEqual";
		public const string CREATION_MODE_IN = "creationModeIn";
		public const string VERSION_EQUAL = "versionEqual";
		public const string VERSION_MULTI_LIKE_OR = "versionMultiLikeOr";
		public const string VERSION_MULTI_LIKE_AND = "versionMultiLikeAnd";
		public const string PARTNER_TAGS_MULTI_LIKE_OR = "partnerTagsMultiLikeOr";
		public const string PARTNER_TAGS_MULTI_LIKE_AND = "partnerTagsMultiLikeAnd";
		#endregion

		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private string _NameLike = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private UiConfObjType _ObjTypeEqual = (UiConfObjType)Int32.MinValue;
		private string _ObjTypeIn = null;
		private string _TagsMultiLikeOr = null;
		private string _TagsMultiLikeAnd = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private UiConfCreationMode _CreationModeEqual = (UiConfCreationMode)Int32.MinValue;
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
		public UiConfObjType ObjTypeEqual
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
		public UiConfCreationMode CreationModeEqual
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
		public UiConfBaseFilter()
		{
		}

		public UiConfBaseFilter(XmlElement node) : base(node)
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
					case "nameLike":
						this._NameLike = propertyNode.InnerText;
						continue;
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = propertyNode.InnerText;
						continue;
					case "objTypeEqual":
						this._ObjTypeEqual = (UiConfObjType)ParseEnum(typeof(UiConfObjType), propertyNode.InnerText);
						continue;
					case "objTypeIn":
						this._ObjTypeIn = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeOr":
						this._TagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "tagsMultiLikeAnd":
						this._TagsMultiLikeAnd = propertyNode.InnerText;
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
					case "creationModeEqual":
						this._CreationModeEqual = (UiConfCreationMode)ParseEnum(typeof(UiConfCreationMode), propertyNode.InnerText);
						continue;
					case "creationModeIn":
						this._CreationModeIn = propertyNode.InnerText;
						continue;
					case "versionEqual":
						this._VersionEqual = propertyNode.InnerText;
						continue;
					case "versionMultiLikeOr":
						this._VersionMultiLikeOr = propertyNode.InnerText;
						continue;
					case "versionMultiLikeAnd":
						this._VersionMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "partnerTagsMultiLikeOr":
						this._PartnerTagsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "partnerTagsMultiLikeAnd":
						this._PartnerTagsMultiLikeAnd = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UiConfBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._IdEqual = data.TryGetValueSafe<int>("idEqual");
			    this._IdIn = data.TryGetValueSafe<string>("idIn");
			    this._NameLike = data.TryGetValueSafe<string>("nameLike");
			    this._PartnerIdEqual = data.TryGetValueSafe<int>("partnerIdEqual");
			    this._PartnerIdIn = data.TryGetValueSafe<string>("partnerIdIn");
			    this._ObjTypeEqual = (UiConfObjType)ParseEnum(typeof(UiConfObjType), data.TryGetValueSafe<int>("objTypeEqual"));
			    this._ObjTypeIn = data.TryGetValueSafe<string>("objTypeIn");
			    this._TagsMultiLikeOr = data.TryGetValueSafe<string>("tagsMultiLikeOr");
			    this._TagsMultiLikeAnd = data.TryGetValueSafe<string>("tagsMultiLikeAnd");
			    this._CreatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("createdAtGreaterThanOrEqual");
			    this._CreatedAtLessThanOrEqual = data.TryGetValueSafe<int>("createdAtLessThanOrEqual");
			    this._UpdatedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("updatedAtGreaterThanOrEqual");
			    this._UpdatedAtLessThanOrEqual = data.TryGetValueSafe<int>("updatedAtLessThanOrEqual");
			    this._CreationModeEqual = (UiConfCreationMode)ParseEnum(typeof(UiConfCreationMode), data.TryGetValueSafe<int>("creationModeEqual"));
			    this._CreationModeIn = data.TryGetValueSafe<string>("creationModeIn");
			    this._VersionEqual = data.TryGetValueSafe<string>("versionEqual");
			    this._VersionMultiLikeOr = data.TryGetValueSafe<string>("versionMultiLikeOr");
			    this._VersionMultiLikeAnd = data.TryGetValueSafe<string>("versionMultiLikeAnd");
			    this._PartnerTagsMultiLikeOr = data.TryGetValueSafe<string>("partnerTagsMultiLikeOr");
			    this._PartnerTagsMultiLikeAnd = data.TryGetValueSafe<string>("partnerTagsMultiLikeAnd");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUiConfBaseFilter");
			kparams.AddIfNotNull("idEqual", this._IdEqual);
			kparams.AddIfNotNull("idIn", this._IdIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("objTypeEqual", this._ObjTypeEqual);
			kparams.AddIfNotNull("objTypeIn", this._ObjTypeIn);
			kparams.AddIfNotNull("tagsMultiLikeOr", this._TagsMultiLikeOr);
			kparams.AddIfNotNull("tagsMultiLikeAnd", this._TagsMultiLikeAnd);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this._CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this._CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this._UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this._UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("creationModeEqual", this._CreationModeEqual);
			kparams.AddIfNotNull("creationModeIn", this._CreationModeIn);
			kparams.AddIfNotNull("versionEqual", this._VersionEqual);
			kparams.AddIfNotNull("versionMultiLikeOr", this._VersionMultiLikeOr);
			kparams.AddIfNotNull("versionMultiLikeAnd", this._VersionMultiLikeAnd);
			kparams.AddIfNotNull("partnerTagsMultiLikeOr", this._PartnerTagsMultiLikeOr);
			kparams.AddIfNotNull("partnerTagsMultiLikeAnd", this._PartnerTagsMultiLikeAnd);
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
				case NAME_LIKE:
					return "NameLike";
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case OBJ_TYPE_EQUAL:
					return "ObjTypeEqual";
				case OBJ_TYPE_IN:
					return "ObjTypeIn";
				case TAGS_MULTI_LIKE_OR:
					return "TagsMultiLikeOr";
				case TAGS_MULTI_LIKE_AND:
					return "TagsMultiLikeAnd";
				case CREATED_AT_GREATER_THAN_OR_EQUAL:
					return "CreatedAtGreaterThanOrEqual";
				case CREATED_AT_LESS_THAN_OR_EQUAL:
					return "CreatedAtLessThanOrEqual";
				case UPDATED_AT_GREATER_THAN_OR_EQUAL:
					return "UpdatedAtGreaterThanOrEqual";
				case UPDATED_AT_LESS_THAN_OR_EQUAL:
					return "UpdatedAtLessThanOrEqual";
				case CREATION_MODE_EQUAL:
					return "CreationModeEqual";
				case CREATION_MODE_IN:
					return "CreationModeIn";
				case VERSION_EQUAL:
					return "VersionEqual";
				case VERSION_MULTI_LIKE_OR:
					return "VersionMultiLikeOr";
				case VERSION_MULTI_LIKE_AND:
					return "VersionMultiLikeAnd";
				case PARTNER_TAGS_MULTI_LIKE_OR:
					return "PartnerTagsMultiLikeOr";
				case PARTNER_TAGS_MULTI_LIKE_AND:
					return "PartnerTagsMultiLikeAnd";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

