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
	public class KalturaBaseEntryFilter : KalturaBaseEntryBaseFilter
	{
		#region Private Fields
		private string _FreeText = null;
		private KalturaNullableBoolean _IsRoot = (KalturaNullableBoolean)Int32.MinValue;
		private string _CategoriesFullNameIn = null;
		private string _CategoryAncestorIdIn = null;
		private string _RedirectFromEntryId = null;
		private KalturaBaseEntryOrderBy _OrderBy = null;
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
		public KalturaNullableBoolean IsRoot
		{
			get { return _IsRoot; }
			set 
			{ 
				_IsRoot = value;
				OnPropertyChanged("IsRoot");
			}
		}
		public string CategoriesFullNameIn
		{
			get { return _CategoriesFullNameIn; }
			set 
			{ 
				_CategoriesFullNameIn = value;
				OnPropertyChanged("CategoriesFullNameIn");
			}
		}
		public string CategoryAncestorIdIn
		{
			get { return _CategoryAncestorIdIn; }
			set 
			{ 
				_CategoryAncestorIdIn = value;
				OnPropertyChanged("CategoryAncestorIdIn");
			}
		}
		public string RedirectFromEntryId
		{
			get { return _RedirectFromEntryId; }
			set 
			{ 
				_RedirectFromEntryId = value;
				OnPropertyChanged("RedirectFromEntryId");
			}
		}
		public new KalturaBaseEntryOrderBy OrderBy
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
		public KalturaBaseEntryFilter()
		{
		}

		public KalturaBaseEntryFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "freeText":
						this.FreeText = txt;
						continue;
					case "isRoot":
						this.IsRoot = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "categoriesFullNameIn":
						this.CategoriesFullNameIn = txt;
						continue;
					case "categoryAncestorIdIn":
						this.CategoryAncestorIdIn = txt;
						continue;
					case "redirectFromEntryId":
						this.RedirectFromEntryId = txt;
						continue;
					case "orderBy":
						this.OrderBy = (KalturaBaseEntryOrderBy)KalturaStringEnum.Parse(typeof(KalturaBaseEntryOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseEntryFilter");
			kparams.AddIfNotNull("freeText", this.FreeText);
			kparams.AddIfNotNull("isRoot", this.IsRoot);
			kparams.AddIfNotNull("categoriesFullNameIn", this.CategoriesFullNameIn);
			kparams.AddIfNotNull("categoryAncestorIdIn", this.CategoryAncestorIdIn);
			kparams.AddIfNotNull("redirectFromEntryId", this.RedirectFromEntryId);
			kparams.AddIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

