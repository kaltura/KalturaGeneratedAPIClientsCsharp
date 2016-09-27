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

namespace Kaltura
{
	public class KalturaCategoryFilter : KalturaCategoryBaseFilter
	{
		#region Private Fields
		private string _FreeText = null;
		private string _MembersIn = null;
		private string _NameOrReferenceIdStartsWith = null;
		private string _ManagerEqual = null;
		private string _MemberEqual = null;
		private string _FullNameStartsWithIn = null;
		private string _AncestorIdIn = null;
		private string _IdOrInheritedParentIdIn = null;
		private KalturaCategoryOrderBy _OrderBy = null;
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
		public KalturaCategoryOrderBy OrderBy
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
		public KalturaCategoryFilter()
		{
		}

		public KalturaCategoryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "freeText":
						this._FreeText = txt;
						continue;
					case "membersIn":
						this._MembersIn = txt;
						continue;
					case "nameOrReferenceIdStartsWith":
						this._NameOrReferenceIdStartsWith = txt;
						continue;
					case "managerEqual":
						this._ManagerEqual = txt;
						continue;
					case "memberEqual":
						this._MemberEqual = txt;
						continue;
					case "fullNameStartsWithIn":
						this._FullNameStartsWithIn = txt;
						continue;
					case "ancestorIdIn":
						this._AncestorIdIn = txt;
						continue;
					case "idOrInheritedParentIdIn":
						this._IdOrInheritedParentIdIn = txt;
						continue;
					case "orderBy":
						this._OrderBy = (KalturaCategoryOrderBy)KalturaStringEnum.Parse(typeof(KalturaCategoryOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
		#endregion
	}
}

