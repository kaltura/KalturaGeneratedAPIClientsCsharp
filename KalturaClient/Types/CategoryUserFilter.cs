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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class CategoryUserFilter : CategoryUserBaseFilter
	{
		#region Constants
		public const string CATEGORY_DIRECT_MEMBERS = "categoryDirectMembers";
		public const string FREE_TEXT = "freeText";
		public const string RELATED_GROUPS_BY_USER_ID = "relatedGroupsByUserId";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private bool? _CategoryDirectMembers = null;
		private string _FreeText = null;
		private string _RelatedGroupsByUserId = null;
		private CategoryUserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? CategoryDirectMembers
		{
			get { return _CategoryDirectMembers; }
			set 
			{ 
				_CategoryDirectMembers = value;
				OnPropertyChanged("CategoryDirectMembers");
			}
		}
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
		[JsonProperty]
		public string RelatedGroupsByUserId
		{
			get { return _RelatedGroupsByUserId; }
			set 
			{ 
				_RelatedGroupsByUserId = value;
				OnPropertyChanged("RelatedGroupsByUserId");
			}
		}
		[JsonProperty]
		public new CategoryUserOrderBy OrderBy
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
		public CategoryUserFilter()
		{
		}

		public CategoryUserFilter(JToken node) : base(node)
		{
			if(node["categoryDirectMembers"] != null)
			{
				this._CategoryDirectMembers = ParseBool(node["categoryDirectMembers"].Value<string>());
			}
			if(node["freeText"] != null)
			{
				this._FreeText = node["freeText"].Value<string>();
			}
			if(node["relatedGroupsByUserId"] != null)
			{
				this._RelatedGroupsByUserId = node["relatedGroupsByUserId"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (CategoryUserOrderBy)StringEnum.Parse(typeof(CategoryUserOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryUserFilter");
			kparams.AddIfNotNull("categoryDirectMembers", this._CategoryDirectMembers);
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("relatedGroupsByUserId", this._RelatedGroupsByUserId);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CATEGORY_DIRECT_MEMBERS:
					return "CategoryDirectMembers";
				case FREE_TEXT:
					return "FreeText";
				case RELATED_GROUPS_BY_USER_ID:
					return "RelatedGroupsByUserId";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

