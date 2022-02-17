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
	public class BaseEntryFilter : BaseEntryBaseFilter
	{
		#region Constants
		public const string FREE_TEXT = "freeText";
		public const string EXCLUDED_FREE_TEXT_GROUPS = "excludedFreeTextGroups";
		public const string DESCRIPTION_LIKE = "descriptionLike";
		public const string IS_ROOT = "isRoot";
		public const string CATEGORIES_FULL_NAME_IN = "categoriesFullNameIn";
		public const string CATEGORY_ANCESTOR_ID_IN = "categoryAncestorIdIn";
		public const string REDIRECT_FROM_ENTRY_ID = "redirectFromEntryId";
		public const string CONVERSION_PROFILE_ID_EQUAL = "conversionProfileIdEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _FreeText = null;
		private string _ExcludedFreeTextGroups = null;
		private string _DescriptionLike = null;
		private NullableBoolean _IsRoot = (NullableBoolean)Int32.MinValue;
		private string _CategoriesFullNameIn = null;
		private string _CategoryAncestorIdIn = null;
		private string _RedirectFromEntryId = null;
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private BaseEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FreeTextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FreeText
		{
			get { return _FreeText; }
			set 
			{ 
				_FreeText = value;
				OnPropertyChanged("FreeText");
			}
		}
		/// <summary>
		/// Use ExcludedFreeTextGroupsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ExcludedFreeTextGroups
		{
			get { return _ExcludedFreeTextGroups; }
			set 
			{ 
				_ExcludedFreeTextGroups = value;
				OnPropertyChanged("ExcludedFreeTextGroups");
			}
		}
		/// <summary>
		/// Use DescriptionLikeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DescriptionLike
		{
			get { return _DescriptionLike; }
			set 
			{ 
				_DescriptionLike = value;
				OnPropertyChanged("DescriptionLike");
			}
		}
		/// <summary>
		/// Use IsRootAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsRoot
		{
			get { return _IsRoot; }
			set 
			{ 
				_IsRoot = value;
				OnPropertyChanged("IsRoot");
			}
		}
		/// <summary>
		/// Use CategoriesFullNameInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoriesFullNameIn
		{
			get { return _CategoriesFullNameIn; }
			set 
			{ 
				_CategoriesFullNameIn = value;
				OnPropertyChanged("CategoriesFullNameIn");
			}
		}
		/// <summary>
		/// Use CategoryAncestorIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CategoryAncestorIdIn
		{
			get { return _CategoryAncestorIdIn; }
			set 
			{ 
				_CategoryAncestorIdIn = value;
				OnPropertyChanged("CategoryAncestorIdIn");
			}
		}
		/// <summary>
		/// Use RedirectFromEntryIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RedirectFromEntryId
		{
			get { return _RedirectFromEntryId; }
			set 
			{ 
				_RedirectFromEntryId = value;
				OnPropertyChanged("RedirectFromEntryId");
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
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new BaseEntryOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public BaseEntryFilter()
		{
		}

		public BaseEntryFilter(JToken node) : base(node)
		{
			if(node["freeText"] != null)
			{
				this._FreeText = node["freeText"].Value<string>();
			}
			if(node["excludedFreeTextGroups"] != null)
			{
				this._ExcludedFreeTextGroups = node["excludedFreeTextGroups"].Value<string>();
			}
			if(node["descriptionLike"] != null)
			{
				this._DescriptionLike = node["descriptionLike"].Value<string>();
			}
			if(node["isRoot"] != null)
			{
				this._IsRoot = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isRoot"].Value<string>());
			}
			if(node["categoriesFullNameIn"] != null)
			{
				this._CategoriesFullNameIn = node["categoriesFullNameIn"].Value<string>();
			}
			if(node["categoryAncestorIdIn"] != null)
			{
				this._CategoryAncestorIdIn = node["categoryAncestorIdIn"].Value<string>();
			}
			if(node["redirectFromEntryId"] != null)
			{
				this._RedirectFromEntryId = node["redirectFromEntryId"].Value<string>();
			}
			if(node["conversionProfileIdEqual"] != null)
			{
				this._ConversionProfileIdEqual = ParseInt(node["conversionProfileIdEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (BaseEntryOrderBy)StringEnum.Parse(typeof(BaseEntryOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseEntryFilter");
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("excludedFreeTextGroups", this._ExcludedFreeTextGroups);
			kparams.AddIfNotNull("descriptionLike", this._DescriptionLike);
			kparams.AddIfNotNull("isRoot", this._IsRoot);
			kparams.AddIfNotNull("categoriesFullNameIn", this._CategoriesFullNameIn);
			kparams.AddIfNotNull("categoryAncestorIdIn", this._CategoryAncestorIdIn);
			kparams.AddIfNotNull("redirectFromEntryId", this._RedirectFromEntryId);
			kparams.AddIfNotNull("conversionProfileIdEqual", this._ConversionProfileIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FREE_TEXT:
					return "FreeText";
				case EXCLUDED_FREE_TEXT_GROUPS:
					return "ExcludedFreeTextGroups";
				case DESCRIPTION_LIKE:
					return "DescriptionLike";
				case IS_ROOT:
					return "IsRoot";
				case CATEGORIES_FULL_NAME_IN:
					return "CategoriesFullNameIn";
				case CATEGORY_ANCESTOR_ID_IN:
					return "CategoryAncestorIdIn";
				case REDIRECT_FROM_ENTRY_ID:
					return "RedirectFromEntryId";
				case CONVERSION_PROFILE_ID_EQUAL:
					return "ConversionProfileIdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

