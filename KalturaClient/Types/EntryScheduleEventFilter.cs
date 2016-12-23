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
using Kaltura.Enums;
using Kaltura.Request;

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
		public string ParentCategoryIdsLike
		{
			get { return _ParentCategoryIdsLike; }
			set 
			{ 
				_ParentCategoryIdsLike = value;
				OnPropertyChanged("ParentCategoryIdsLike");
			}
		}
		public string ParentCategoryIdsMultiLikeOr
		{
			get { return _ParentCategoryIdsMultiLikeOr; }
			set 
			{ 
				_ParentCategoryIdsMultiLikeOr = value;
				OnPropertyChanged("ParentCategoryIdsMultiLikeOr");
			}
		}
		public string ParentCategoryIdsMultiLikeAnd
		{
			get { return _ParentCategoryIdsMultiLikeAnd; }
			set 
			{ 
				_ParentCategoryIdsMultiLikeAnd = value;
				OnPropertyChanged("ParentCategoryIdsMultiLikeAnd");
			}
		}
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

		public EntryScheduleEventFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "parentCategoryIdsLike":
						this._ParentCategoryIdsLike = propertyNode.InnerText;
						continue;
					case "parentCategoryIdsMultiLikeOr":
						this._ParentCategoryIdsMultiLikeOr = propertyNode.InnerText;
						continue;
					case "parentCategoryIdsMultiLikeAnd":
						this._ParentCategoryIdsMultiLikeAnd = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = (EntryScheduleEventOrderBy)StringEnum.Parse(typeof(EntryScheduleEventOrderBy), propertyNode.InnerText);
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

