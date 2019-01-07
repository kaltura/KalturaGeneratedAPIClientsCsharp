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
	public class EntryScheduleEventFilter : EntryScheduleEventBaseFilter
	{
		#region Constants
		public const string PARENT_CATEGORY_IDS_LIKE = "parentCategoryIdsLike";
		public const string PARENT_CATEGORY_IDS_MULTI_LIKE_OR = "parentCategoryIdsMultiLikeOr";
		public const string PARENT_CATEGORY_IDS_MULTI_LIKE_AND = "parentCategoryIdsMultiLikeAnd";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _ParentCategoryIdsLike = null;
		private string _ParentCategoryIdsMultiLikeOr = null;
		private string _ParentCategoryIdsMultiLikeAnd = null;
		private EntryScheduleEventOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string ParentCategoryIdsLike
		{
			get { return _ParentCategoryIdsLike; }
			set 
			{ 
				_ParentCategoryIdsLike = value;
				OnPropertyChanged("ParentCategoryIdsLike");
			}
		}
		[JsonProperty]
		public string ParentCategoryIdsMultiLikeOr
		{
			get { return _ParentCategoryIdsMultiLikeOr; }
			set 
			{ 
				_ParentCategoryIdsMultiLikeOr = value;
				OnPropertyChanged("ParentCategoryIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string ParentCategoryIdsMultiLikeAnd
		{
			get { return _ParentCategoryIdsMultiLikeAnd; }
			set 
			{ 
				_ParentCategoryIdsMultiLikeAnd = value;
				OnPropertyChanged("ParentCategoryIdsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public new EntryScheduleEventOrderBy OrderBy
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
		public EntryScheduleEventFilter()
		{
		}

		public EntryScheduleEventFilter(JToken node) : base(node)
		{
			if(node["parentCategoryIdsLike"] != null)
			{
				this._ParentCategoryIdsLike = node["parentCategoryIdsLike"].Value<string>();
			}
			if(node["parentCategoryIdsMultiLikeOr"] != null)
			{
				this._ParentCategoryIdsMultiLikeOr = node["parentCategoryIdsMultiLikeOr"].Value<string>();
			}
			if(node["parentCategoryIdsMultiLikeAnd"] != null)
			{
				this._ParentCategoryIdsMultiLikeAnd = node["parentCategoryIdsMultiLikeAnd"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (EntryScheduleEventOrderBy)StringEnum.Parse(typeof(EntryScheduleEventOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryScheduleEventFilter");
			kparams.AddIfNotNull("parentCategoryIdsLike", this._ParentCategoryIdsLike);
			kparams.AddIfNotNull("parentCategoryIdsMultiLikeOr", this._ParentCategoryIdsMultiLikeOr);
			kparams.AddIfNotNull("parentCategoryIdsMultiLikeAnd", this._ParentCategoryIdsMultiLikeAnd);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARENT_CATEGORY_IDS_LIKE:
					return "ParentCategoryIdsLike";
				case PARENT_CATEGORY_IDS_MULTI_LIKE_OR:
					return "ParentCategoryIdsMultiLikeOr";
				case PARENT_CATEGORY_IDS_MULTI_LIKE_AND:
					return "ParentCategoryIdsMultiLikeAnd";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

