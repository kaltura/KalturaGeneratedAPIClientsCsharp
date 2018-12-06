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
		public string FreeText
		{
			get { return _FreeText; }
			set 
			{ 
				_FreeText = value;
				OnPropertyChanged("FreeText");
			}
		}
		public string MembersIn
		{
			get { return _MembersIn; }
			set 
			{ 
				_MembersIn = value;
				OnPropertyChanged("MembersIn");
			}
		}
		public string NameOrReferenceIdStartsWith
		{
			get { return _NameOrReferenceIdStartsWith; }
			set 
			{ 
				_NameOrReferenceIdStartsWith = value;
				OnPropertyChanged("NameOrReferenceIdStartsWith");
			}
		}
		public string ManagerEqual
		{
			get { return _ManagerEqual; }
			set 
			{ 
				_ManagerEqual = value;
				OnPropertyChanged("ManagerEqual");
			}
		}
		public string MemberEqual
		{
			get { return _MemberEqual; }
			set 
			{ 
				_MemberEqual = value;
				OnPropertyChanged("MemberEqual");
			}
		}
		public string FullNameStartsWithIn
		{
			get { return _FullNameStartsWithIn; }
			set 
			{ 
				_FullNameStartsWithIn = value;
				OnPropertyChanged("FullNameStartsWithIn");
			}
		}
		public string AncestorIdIn
		{
			get { return _AncestorIdIn; }
			set 
			{ 
				_AncestorIdIn = value;
				OnPropertyChanged("AncestorIdIn");
			}
		}
		public string IdOrInheritedParentIdIn
		{
			get { return _IdOrInheritedParentIdIn; }
			set 
			{ 
				_IdOrInheritedParentIdIn = value;
				OnPropertyChanged("IdOrInheritedParentIdIn");
			}
		}
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

		public CategoryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "freeText":
						this._FreeText = propertyNode.InnerText;
						continue;
					case "membersIn":
						this._MembersIn = propertyNode.InnerText;
						continue;
					case "nameOrReferenceIdStartsWith":
						this._NameOrReferenceIdStartsWith = propertyNode.InnerText;
						continue;
					case "managerEqual":
						this._ManagerEqual = propertyNode.InnerText;
						continue;
					case "memberEqual":
						this._MemberEqual = propertyNode.InnerText;
						continue;
					case "fullNameStartsWithIn":
						this._FullNameStartsWithIn = propertyNode.InnerText;
						continue;
					case "ancestorIdIn":
						this._AncestorIdIn = propertyNode.InnerText;
						continue;
					case "idOrInheritedParentIdIn":
						this._IdOrInheritedParentIdIn = propertyNode.InnerText;
						continue;
					case "orderBy":
						this._OrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), propertyNode.InnerText);
						continue;
				}
			}
		}

		public CategoryFilter(IDictionary<string,object> data) : base(data)
		{
			    this._FreeText = data.TryGetValueSafe<string>("freeText");
			    this._MembersIn = data.TryGetValueSafe<string>("membersIn");
			    this._NameOrReferenceIdStartsWith = data.TryGetValueSafe<string>("nameOrReferenceIdStartsWith");
			    this._ManagerEqual = data.TryGetValueSafe<string>("managerEqual");
			    this._MemberEqual = data.TryGetValueSafe<string>("memberEqual");
			    this._FullNameStartsWithIn = data.TryGetValueSafe<string>("fullNameStartsWithIn");
			    this._AncestorIdIn = data.TryGetValueSafe<string>("ancestorIdIn");
			    this._IdOrInheritedParentIdIn = data.TryGetValueSafe<string>("idOrInheritedParentIdIn");
			    this._OrderBy = (CategoryOrderBy)StringEnum.Parse(typeof(CategoryOrderBy), data.TryGetValueSafe<string>("orderBy"));
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

