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
// Copyright (C) 2006-2017  Kaltura Inc.
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
		public string ResourceIdsLike
		{
			get { return _ResourceIdsLike; }
			set 
			{ 
				_ResourceIdsLike = value;
				OnPropertyChanged("ResourceIdsLike");
			}
		}
		public string ResourceIdsMultiLikeOr
		{
			get { return _ResourceIdsMultiLikeOr; }
			set 
			{ 
				_ResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ResourceIdsMultiLikeOr");
			}
		}
		public string ResourceIdsMultiLikeAnd
		{
			get { return _ResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ResourceIdsMultiLikeAnd");
			}
		}
		public string ParentResourceIdsLike
		{
			get { return _ParentResourceIdsLike; }
			set 
			{ 
				_ParentResourceIdsLike = value;
				OnPropertyChanged("ParentResourceIdsLike");
			}
		}
		public string ParentResourceIdsMultiLikeOr
		{
			get { return _ParentResourceIdsMultiLikeOr; }
			set 
			{ 
				_ParentResourceIdsMultiLikeOr = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeOr");
			}
		}
		public string ParentResourceIdsMultiLikeAnd
		{
			get { return _ParentResourceIdsMultiLikeAnd; }
			set 
			{ 
				_ParentResourceIdsMultiLikeAnd = value;
				OnPropertyChanged("ParentResourceIdsMultiLikeAnd");
			}
		}
		public string TemplateEntryCategoriesIdsMultiLikeAnd
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeAnd; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeAnd = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeAnd");
			}
		}
		public string TemplateEntryCategoriesIdsMultiLikeOr
		{
			get { return _TemplateEntryCategoriesIdsMultiLikeOr; }
			set 
			{ 
				_TemplateEntryCategoriesIdsMultiLikeOr = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsMultiLikeOr");
			}
		}
		public string ResourceSystemNamesMultiLikeOr
		{
			get { return _ResourceSystemNamesMultiLikeOr; }
			set 
			{ 
				_ResourceSystemNamesMultiLikeOr = value;
				OnPropertyChanged("ResourceSystemNamesMultiLikeOr");
			}
		}
		public string TemplateEntryCategoriesIdsLike
		{
			get { return _TemplateEntryCategoriesIdsLike; }
			set 
			{ 
				_TemplateEntryCategoriesIdsLike = value;
				OnPropertyChanged("TemplateEntryCategoriesIdsLike");
			}
		}
		public string ResourceSystemNamesMultiLikeAnd
		{
			get { return _ResourceSystemNamesMultiLikeAnd; }
			set 
			{ 
				_ResourceSystemNamesMultiLikeAnd = value;
				OnPropertyChanged("ResourceSystemNamesMultiLikeAnd");
			}
		}
		public string ResourceSystemNamesLike
		{
			get { return _ResourceSystemNamesLike; }
			set 
			{ 
				_ResourceSystemNamesLike = value;
				OnPropertyChanged("ResourceSystemNamesLike");
			}
		}
		public string ResourceIdEqual
		{
			get { return _ResourceIdEqual; }
			set 
			{ 
				_ResourceIdEqual = value;
				OnPropertyChanged("ResourceIdEqual");
			}
		}
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

		public ScheduleEventFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "resourceIdsLike":
						this._ResourceIdsLike = propertyNode.InnerText;
						continue;
					case "resourceIdsMultiLikeOr":
						this._ResourceIdsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "resourceIdsMultiLikeAnd":
						this._ResourceIdsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "parentResourceIdsLike":
						this._ParentResourceIdsLike = propertyNode.InnerText;
						continue;
					case "parentResourceIdsMultiLikeOr":
						this._ParentResourceIdsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "parentResourceIdsMultiLikeAnd":
						this._ParentResourceIdsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "templateEntryCategoriesIdsMultiLikeAnd":
						this._TemplateEntryCategoriesIdsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "templateEntryCategoriesIdsMultiLikeOr":
						this._TemplateEntryCategoriesIdsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "resourceSystemNamesMultiLikeOr":
						this._ResourceSystemNamesMultiLikeOr = propertyNode.InnerText;
						continue;
					case "templateEntryCategoriesIdsLike":
						this._TemplateEntryCategoriesIdsLike = propertyNode.InnerText;
						continue;
					case "resourceSystemNamesMultiLikeAnd":
						this._ResourceSystemNamesMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "resourceSystemNamesLike":
						this._ResourceSystemNamesLike = propertyNode.InnerText;
						continue;
					case "resourceIdEqual":
						this._ResourceIdEqual = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = (ScheduleEventOrderBy)StringEnum.Parse(typeof(ScheduleEventOrderBy), propertyNode.InnerText);
						continue;
				}
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

