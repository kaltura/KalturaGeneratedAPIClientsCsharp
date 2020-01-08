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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ScheduleEventFilter : ScheduleEventBaseFilter
	{
		#region Constants
		public const string RESOURCE_IDS_LIKE = "resourceIdsLike";
		public const string RESOURCE_IDS_MULTI_LIKE_OR = "resourceIdsMultiLikeOr";
		public const string RESOURCE_IDS_MULTI_LIKE_AND = "resourceIdsMultiLikeAnd";
		public const string PARENT_RESOURCE_IDS_LIKE = "parentResourceIdsLike";
		public const string PARENT_RESOURCE_IDS_MULTI_LIKE_OR = "parentResourceIdsMultiLikeOr";
		public const string PARENT_RESOURCE_IDS_MULTI_LIKE_AND = "parentResourceIdsMultiLikeAnd";
		public const string TEMPLATE_ENTRY_CATEGORIES_IDS_MULTI_LIKE_AND = "templateEntryCategoriesIdsMultiLikeAnd";
		public const string TEMPLATE_ENTRY_CATEGORIES_IDS_MULTI_LIKE_OR = "templateEntryCategoriesIdsMultiLikeOr";
		public const string RESOURCE_SYSTEM_NAMES_MULTI_LIKE_OR = "resourceSystemNamesMultiLikeOr";
		public const string TEMPLATE_ENTRY_CATEGORIES_IDS_LIKE = "templateEntryCategoriesIdsLike";
		public const string RESOURCE_SYSTEM_NAMES_MULTI_LIKE_AND = "resourceSystemNamesMultiLikeAnd";
		public const string RESOURCE_SYSTEM_NAMES_LIKE = "resourceSystemNamesLike";
		public const string RESOURCE_ID_EQUAL = "resourceIdEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _ResourceIdsLike = null;
		private string _ResourceIdsMultiLikeOr = null;
		private string _ResourceIdsMultiLikeAnd = null;
		private string _ParentResourceIdsLike = null;
		private string _ParentResourceIdsMultiLikeOr = null;
		private string _ParentResourceIdsMultiLikeAnd = null;
		private string _TemplateEntryCategoriesIdsMultiLikeAnd = null;
		private string _TemplateEntryCategoriesIdsMultiLikeOr = null;
		private string _ResourceSystemNamesMultiLikeOr = null;
		private string _TemplateEntryCategoriesIdsLike = null;
		private string _ResourceSystemNamesMultiLikeAnd = null;
		private string _ResourceSystemNamesLike = null;
		private string _ResourceIdEqual = null;
		private ScheduleEventOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string ResourceIdsLike
		{
			get { return _ResourceIdsLike; }
			set 
			{ 
				_ResourceIdsLike = value;
				OnPropertyChanged("ResourceIdsLike");
			}
		}
		[JsonProperty]
		public string ResourceIdsMultiLikeOr
		{
			get { return _ResourceIdsMultiLikeOr; }
			set 
			{ 
				_ResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ResourceIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string ResourceIdsMultiLikeAnd
		{
			get { return _ResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ResourceIdsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string ParentResourceIdsLike
		{
			get { return _ParentResourceIdsLike; }
			set 
			{ 
				_ParentResourceIdsLike = value;
				OnPropertyChanged("ParentResourceIdsLike");
			}
		}
		[JsonProperty]
		public string ParentResourceIdsMultiLikeOr
		{
			get { return _ParentResourceIdsMultiLikeOr; }
			set 
			{ 
				_ParentResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string ParentResourceIdsMultiLikeAnd
		{
			get { return _ParentResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ParentResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string TemplateEntryCategoriesIdsMultiLikeAnd
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeAnd; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeAnd = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string TemplateEntryCategoriesIdsMultiLikeOr
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeOr; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeOr = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeOr");
			}
		}
		[JsonProperty]
		public string ResourceSystemNamesMultiLikeOr
		{
			get { return _ResourceSystemNamesMultiLikeOr; }
			set 
			{ 
				_ResourceSystemNamesMultiLikeOr = value;
				OnPropertyChanged("ResourceSystemNamesMultiLikeOr");
			}
		}
		[JsonProperty]
		public string TemplateEntryCategoriesIdsLike
		{
			get { return _TemplateEntryCategoriesIdsLike; }
			set 
			{ 
				_TemplateEntryCategoriesIdsLike = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsLike");
			}
		}
		[JsonProperty]
		public string ResourceSystemNamesMultiLikeAnd
		{
			get { return _ResourceSystemNamesMultiLikeAnd; }
			set 
			{ 
				_ResourceSystemNamesMultiLikeAnd = value;
				OnPropertyChanged("ResourceSystemNamesMultiLikeAnd");
			}
		}
		[JsonProperty]
		public string ResourceSystemNamesLike
		{
			get { return _ResourceSystemNamesLike; }
			set 
			{ 
				_ResourceSystemNamesLike = value;
				OnPropertyChanged("ResourceSystemNamesLike");
			}
		}
		[JsonProperty]
		public string ResourceIdEqual
		{
			get { return _ResourceIdEqual; }
			set 
			{ 
				_ResourceIdEqual = value;
				OnPropertyChanged("ResourceIdEqual");
			}
		}
		[JsonProperty]
		public new ScheduleEventOrderBy OrderBy
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
		public ScheduleEventFilter()
		{
		}

		public ScheduleEventFilter(JToken node) : base(node)
		{
			if(node["resourceIdsLike"] != null)
			{
				this._ResourceIdsLike = node["resourceIdsLike"].Value<string>();
			}
			if(node["resourceIdsMultiLikeOr"] != null)
			{
				this._ResourceIdsMultiLikeOr = node["resourceIdsMultiLikeOr"].Value<string>();
			}
			if(node["resourceIdsMultiLikeAnd"] != null)
			{
				this._ResourceIdsMultiLikeAnd = node["resourceIdsMultiLikeAnd"].Value<string>();
			}
			if(node["parentResourceIdsLike"] != null)
			{
				this._ParentResourceIdsLike = node["parentResourceIdsLike"].Value<string>();
			}
			if(node["parentResourceIdsMultiLikeOr"] != null)
			{
				this._ParentResourceIdsMultiLikeOr = node["parentResourceIdsMultiLikeOr"].Value<string>();
			}
			if(node["parentResourceIdsMultiLikeAnd"] != null)
			{
				this._ParentResourceIdsMultiLikeAnd = node["parentResourceIdsMultiLikeAnd"].Value<string>();
			}
			if(node["templateEntryCategoriesIdsMultiLikeAnd"] != null)
			{
				this._TemplateEntryCategoriesIdsMultiLikeAnd = node["templateEntryCategoriesIdsMultiLikeAnd"].Value<string>();
			}
			if(node["templateEntryCategoriesIdsMultiLikeOr"] != null)
			{
				this._TemplateEntryCategoriesIdsMultiLikeOr = node["templateEntryCategoriesIdsMultiLikeOr"].Value<string>();
			}
			if(node["resourceSystemNamesMultiLikeOr"] != null)
			{
				this._ResourceSystemNamesMultiLikeOr = node["resourceSystemNamesMultiLikeOr"].Value<string>();
			}
			if(node["templateEntryCategoriesIdsLike"] != null)
			{
				this._TemplateEntryCategoriesIdsLike = node["templateEntryCategoriesIdsLike"].Value<string>();
			}
			if(node["resourceSystemNamesMultiLikeAnd"] != null)
			{
				this._ResourceSystemNamesMultiLikeAnd = node["resourceSystemNamesMultiLikeAnd"].Value<string>();
			}
			if(node["resourceSystemNamesLike"] != null)
			{
				this._ResourceSystemNamesLike = node["resourceSystemNamesLike"].Value<string>();
			}
			if(node["resourceIdEqual"] != null)
			{
				this._ResourceIdEqual = node["resourceIdEqual"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (ScheduleEventOrderBy)StringEnum.Parse(typeof(ScheduleEventOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduleEventFilter");
			kparams.AddIfNotNull("resourceIdsLike", this._ResourceIdsLike);
			kparams.AddIfNotNull("resourceIdsMultiLikeOr", this._ResourceIdsMultiLikeOr);
			kparams.AddIfNotNull("resourceIdsMultiLikeAnd", this._ResourceIdsMultiLikeAnd);
			kparams.AddIfNotNull("parentResourceIdsLike", this._ParentResourceIdsLike);
			kparams.AddIfNotNull("parentResourceIdsMultiLikeOr", this._ParentResourceIdsMultiLikeOr);
			kparams.AddIfNotNull("parentResourceIdsMultiLikeAnd", this._ParentResourceIdsMultiLikeAnd);
			kparams.AddIfNotNull("templateEntryCategoriesIdsMultiLikeAnd", this._TemplateEntryCategoriesIdsMultiLikeAnd);
			kparams.AddIfNotNull("templateEntryCategoriesIdsMultiLikeOr", this._TemplateEntryCategoriesIdsMultiLikeOr);
			kparams.AddIfNotNull("resourceSystemNamesMultiLikeOr", this._ResourceSystemNamesMultiLikeOr);
			kparams.AddIfNotNull("templateEntryCategoriesIdsLike", this._TemplateEntryCategoriesIdsLike);
			kparams.AddIfNotNull("resourceSystemNamesMultiLikeAnd", this._ResourceSystemNamesMultiLikeAnd);
			kparams.AddIfNotNull("resourceSystemNamesLike", this._ResourceSystemNamesLike);
			kparams.AddIfNotNull("resourceIdEqual", this._ResourceIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case RESOURCE_IDS_LIKE:
					return "ResourceIdsLike";
				case RESOURCE_IDS_MULTI_LIKE_OR:
					return "ResourceIdsMultiLikeOr";
				case RESOURCE_IDS_MULTI_LIKE_AND:
					return "ResourceIdsMultiLikeAnd";
				case PARENT_RESOURCE_IDS_LIKE:
					return "ParentResourceIdsLike";
				case PARENT_RESOURCE_IDS_MULTI_LIKE_OR:
					return "ParentResourceIdsMultiLikeOr";
				case PARENT_RESOURCE_IDS_MULTI_LIKE_AND:
					return "ParentResourceIdsMultiLikeAnd";
				case TEMPLATE_ENTRY_CATEGORIES_IDS_MULTI_LIKE_AND:
					return "TemplateEntryCategoriesIdsMultiLikeAnd";
				case TEMPLATE_ENTRY_CATEGORIES_IDS_MULTI_LIKE_OR:
					return "TemplateEntryCategoriesIdsMultiLikeOr";
				case RESOURCE_SYSTEM_NAMES_MULTI_LIKE_OR:
					return "ResourceSystemNamesMultiLikeOr";
				case TEMPLATE_ENTRY_CATEGORIES_IDS_LIKE:
					return "TemplateEntryCategoriesIdsLike";
				case RESOURCE_SYSTEM_NAMES_MULTI_LIKE_AND:
					return "ResourceSystemNamesMultiLikeAnd";
				case RESOURCE_SYSTEM_NAMES_LIKE:
					return "ResourceSystemNamesLike";
				case RESOURCE_ID_EQUAL:
					return "ResourceIdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

