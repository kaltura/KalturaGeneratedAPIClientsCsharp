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
	public class CategoryFilter : CategoryBaseFilter
	{
		#region Constants
		public const string FREE_TEXT = "freeText";
		public const string MEMBERS_IN = "membersIn";
		public const string NAME_OR_REFERENCE_ID_STARTS_WITH = "nameOrReferenceIdStartsWith";
		public const string MANAGER_EQUAL = "managerEqual";
		public const string MEMBER_EQUAL = "memberEqual";
		public const string FULL_NAME_STARTS_WITH_IN = "fullNameStartsWithIn";
		public const string ANCESTOR_ID_IN = "ancestorIdIn";
		public const string ID_OR_INHERITED_PARENT_ID_IN = "idOrInheritedParentIdIn";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _FreeText = null;
		private string _MembersIn = null;
		private string _NameOrReferenceIdStartsWith = null;
		private string _ManagerEqual = null;
		private string _MemberEqual = null;
		private string _FullNameStartsWithIn = null;
		private string _AncestorIdIn = null;
		private string _IdOrInheritedParentIdIn = null;
		private CategoryOrderBy _OrderBy = null;
		#endregion

		#region Properties
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
		public string MembersIn
		{
			get { return _MembersIn; }
			set 
			{ 
				_MembersIn = value;
				OnPropertyChanged("MembersIn");
			}
		}
		[JsonProperty]
		public string NameOrReferenceIdStartsWith
		{
			get { return _NameOrReferenceIdStartsWith; }
			set 
			{ 
				_NameOrReferenceIdStartsWith = value;
				OnPropertyChanged("NameOrReferenceIdStartsWith");
			}
		}
		[JsonProperty]
		public string ManagerEqual
		{
			get { return _ManagerEqual; }
			set 
			{ 
				_ManagerEqual = value;
				OnPropertyChanged("ManagerEqual");
			}
		}
		[JsonProperty]
		public string MemberEqual
		{
			get { return _MemberEqual; }
			set 
			{ 
				_MemberEqual = value;
				OnPropertyChanged("MemberEqual");
			}
		}
		[JsonProperty]
		public string FullNameStartsWithIn
		{
			get { return _FullNameStartsWithIn; }
			set 
			{ 
				_FullNameStartsWithIn = value;
				OnPropertyChanged("FullNameStartsWithIn");
			}
		}
		[JsonProperty]
		public string AncestorIdIn
		{
			get { return _AncestorIdIn; }
			set 
			{ 
				_AncestorIdIn = value;
				OnPropertyChanged("AncestorIdIn");
			}
		}
		[JsonProperty]
		public string IdOrInheritedParentIdIn
		{
			get { return _IdOrInheritedParentIdIn; }
			set 
			{ 
				_IdOrInheritedParentIdIn = value;
				OnPropertyChanged("IdOrInheritedParentIdIn");
			}
		}
		[JsonProperty]
		public new CategoryOrderBy OrderBy
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
		public CategoryFilter()
		{
		}

		public CategoryFilter(JToken node) : base(node)
		{
			if(node["freeText"] != null)
			{
				this._FreeText = node["freeText"].Value<string>();
			}
			if(node["membersIn"] != null)
			{
				this._MembersIn = node["membersIn"].Value<string>();
			}
			if(node["nameOrReferenceIdStartsWith"] != null)
			{
				this._NameOrReferenceIdStartsWith = node["nameOrReferenceIdStartsWith"].Value<string>();
			}
			if(node["managerEqual"] != null)
			{
				this._ManagerEqual = node["managerEqual"].Value<string>();
			}
			if(node["memberEqual"] != null)
			{
				this._MemberEqual = node["memberEqual"].Value<string>();
			}
			if(node["fullNameStartsWithIn"] != null)
			{
				this._FullNameStartsWithIn = node["fullNameStartsWithIn"].Value<string>();
			}
			if(node["ancestorIdIn"] != null)
			{
				this._AncestorIdIn = node["ancestorIdIn"].Value<string>();
			}
			if(node["idOrInheritedParentIdIn"] != null)
			{
				this._IdOrInheritedParentIdIn = node["idOrInheritedParentIdIn"].Value<string>();
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCategoryFilter");
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("membersIn", this._MembersIn);
			kparams.AddIfNotNull("nameOrReferenceIdStartsWith", this._NameOrReferenceIdStartsWith);
			kparams.AddIfNotNull("managerEqual", this._ManagerEqual);
			kparams.AddIfNotNull("memberEqual", this._MemberEqual);
			kparams.AddIfNotNull("fullNameStartsWithIn", this._FullNameStartsWithIn);
			kparams.AddIfNotNull("ancestorIdIn", this._AncestorIdIn);
			kparams.AddIfNotNull("idOrInheritedParentIdIn", this._IdOrInheritedParentIdIn);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FREE_TEXT:
					return "FreeText";
				case MEMBERS_IN:
					return "MembersIn";
				case NAME_OR_REFERENCE_ID_STARTS_WITH:
					return "NameOrReferenceIdStartsWith";
				case MANAGER_EQUAL:
					return "ManagerEqual";
				case MEMBER_EQUAL:
					return "MemberEqual";
				case FULL_NAME_STARTS_WITH_IN:
					return "FullNameStartsWithIn";
				case ANCESTOR_ID_IN:
					return "AncestorIdIn";
				case ID_OR_INHERITED_PARENT_ID_IN:
					return "IdOrInheritedParentIdIn";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

