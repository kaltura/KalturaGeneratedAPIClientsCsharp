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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class CategoryEntryAdvancedFilter : SearchItem
	{
		#region Constants
		public const string CATEGORIES_MATCH_OR = "categoriesMatchOr";
		public const string CATEGORY_ENTRY_STATUS_IN = "categoryEntryStatusIn";
		public const string ORDER_BY = "orderBy";
		public const string CATEGORY_ID_EQUAL = "categoryIdEqual";
		#endregion

		#region Private Fields
		private string _CategoriesMatchOr = null;
		private string _CategoryEntryStatusIn = null;
		private CategoryEntryAdvancedOrderBy _OrderBy = null;
		private int _CategoryIdEqual = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		[JsonProperty]
		public string CategoryEntryStatusIn
		{
			get { return _CategoryEntryStatusIn; }
			set 
			{ 
				_CategoryEntryStatusIn = value;
				OnPropertyChanged("CategoryEntryStatusIn");
			}
		}
		[JsonProperty]
		public CategoryEntryAdvancedOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		[JsonProperty]
		public int CategoryIdEqual
		{
			get { return _CategoryIdEqual; }
			set 
			{ 
				_CategoryIdEqual = value;
				OnPropertyChanged("CategoryIdEqual");
			}
		}
		#endregion

		#region CTor
		public CategoryEntryAdvancedFilter()
		{
		}

		public CategoryEntryAdvancedFilter(JToken node) : base(node)
		{
			if(node["categoriesMatchOr"] != null)
			{
				this._CategoriesMatchOr = node["categoriesMatchOr"].Value<string>();
			}
			if(node["categoryEntryStatusIn"] != null)
			{
				this._CategoryEntryStatusIn = node["categoryEntryStatusIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (CategoryEntryAdvancedOrderBy)StringEnum.Parse(typeof(CategoryEntryAdvancedOrderBy), node["orderBy"].Value<string>());
			}
			if(node["categoryIdEqual"] != null)
			{
				this._CategoryIdEqual = ParseInt(node["categoryIdEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryEntryAdvancedFilter");
			kparams.AddIfNotNull("categoriesMatchOr", this._CategoriesMatchOr);
			kparams.AddIfNotNull("categoryEntryStatusIn", this._CategoryEntryStatusIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			kparams.AddIfNotNull("categoryIdEqual", this._CategoryIdEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORIES_MATCH_OR:
					return "CategoriesMatchOr";
				case CATEGORY_ENTRY_STATUS_IN:
					return "CategoryEntryStatusIn";
				case ORDER_BY:
					return "OrderBy";
				case CATEGORY_ID_EQUAL:
					return "CategoryIdEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

