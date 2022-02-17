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
		/// Use ObjTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UiConfObjType ObjTypeEqual
		{
			get { return _ObjTypeEqual; }
			set 
			{ 
				_ObjTypeEqual = value;
				OnPropertyChanged("ObjTypeEqual");
			}
		}
		/// <summary>
		/// Use ObjTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ObjTypeIn
		{
			get { return _ObjTypeIn; }
			set 
			{ 
				_ObjTypeIn = value;
				OnPropertyChanged("ObjTypeIn");
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
		/// Use CreationModeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public UiConfCreationMode CreationModeEqual
		{
			get { return _CreationModeEqual; }
			set 
			{ 
				_CreationModeEqual = value;
				OnPropertyChanged("CreationModeEqual");
			}
		}
		/// <summary>
		/// Use CreationModeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CreationModeIn
		{
			get { return _CreationModeIn; }
			set 
			{ 
				_CreationModeIn = value;
				OnPropertyChanged("CreationModeIn");
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
		/// Use VersionMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionMultiLikeOr
		{
			get { return _VersionMultiLikeOr; }
			set 
			{ 
				_VersionMultiLikeOr = value;
				OnPropertyChanged("VersionMultiLikeOr");
			}
		}
		/// <summary>
		/// Use VersionMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VersionMultiLikeAnd
		{
			get { return _VersionMultiLikeAnd; }
			set 
			{ 
				_VersionMultiLikeAnd = value;
				OnPropertyChanged("VersionMultiLikeAnd");
			}
		}
		/// <summary>
		/// Use PartnerTagsMultiLikeOrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PartnerTagsMultiLikeOr
		{
			get { return _PartnerTagsMultiLikeOr; }
			set 
			{ 
				_PartnerTagsMultiLikeOr = value;
				OnPropertyChanged("PartnerTagsMultiLikeOr");
			}
		}
		/// <summary>
		/// Use PartnerTagsMultiLikeAndAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public UiConfBaseFilter(JToken node) : base(node)
		{
			if(node["idEqual"] != null)
			{
				this._IdEqual = ParseInt(node["idEqual"].Value<string>());
			}
			if(node["idIn"] != null)
			{
				this._IdIn = node["idIn"].Value<string>();
			}
			if(node["nameLike"] != null)
			{
				this._NameLike = node["nameLike"].Value<string>();
			}
			if(node["partnerIdEqual"] != null)
			{
				this._PartnerIdEqual = ParseInt(node["partnerIdEqual"].Value<string>());
			}
			if(node["partnerIdIn"] != null)
			{
				this._PartnerIdIn = node["partnerIdIn"].Value<string>();
			}
			if(node["objTypeEqual"] != null)
			{
				this._ObjTypeEqual = (UiConfObjType)ParseEnum(typeof(UiConfObjType), node["objTypeEqual"].Value<string>());
			}
			if(node["objTypeIn"] != null)
			{
				this._ObjTypeIn = node["objTypeIn"].Value<string>();
			}
			if(node["tagsMultiLikeOr"] != null)
			{
				this._TagsMultiLikeOr = node["tagsMultiLikeOr"].Value<string>();
			}
			if(node["tagsMultiLikeAnd"] != null)
			{
				this._TagsMultiLikeAnd = node["tagsMultiLikeAnd"].Value<string>();
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
			if(node["creationModeEqual"] != null)
			{
				this._CreationModeEqual = (UiConfCreationMode)ParseEnum(typeof(UiConfCreationMode), node["creationModeEqual"].Value<string>());
			}
			if(node["creationModeIn"] != null)
			{
				this._CreationModeIn = node["creationModeIn"].Value<string>();
			}
			if(node["versionEqual"] != null)
			{
				this._VersionEqual = node["versionEqual"].Value<string>();
			}
			if(node["versionMultiLikeOr"] != null)
			{
				this._VersionMultiLikeOr = node["versionMultiLikeOr"].Value<string>();
			}
			if(node["versionMultiLikeAnd"] != null)
			{
				this._VersionMultiLikeAnd = node["versionMultiLikeAnd"].Value<string>();
			}
			if(node["partnerTagsMultiLikeOr"] != null)
			{
				this._PartnerTagsMultiLikeOr = node["partnerTagsMultiLikeOr"].Value<string>();
			}
			if(node["partnerTagsMultiLikeAnd"] != null)
			{
				this._PartnerTagsMultiLikeAnd = node["partnerTagsMultiLikeAnd"].Value<string>();
			}
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

