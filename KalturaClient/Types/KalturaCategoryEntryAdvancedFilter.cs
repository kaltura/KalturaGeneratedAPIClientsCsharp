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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaCategoryEntryAdvancedFilter : KalturaSearchItem
	{
		#region Private Fields
		private string _CategoriesMatchOr = null;
		private string _CategoryEntryStatusIn = null;
		private KalturaCategoryEntryAdvancedOrderBy _OrderBy = null;
		private int _CategoryIdEqual = Int32.MinValue;
		#endregion

		#region Properties
		public string CategoriesMatchOr
		{
			get { return _CategoriesMatchOr; }
			set 
			{ 
				_CategoriesMatchOr = value;
				OnPropertyChanged("CategoriesMatchOr");
			}
		}
		public string CategoryEntryStatusIn
		{
			get { return _CategoryEntryStatusIn; }
			set 
			{ 
				_CategoryEntryStatusIn = value;
				OnPropertyChanged("CategoryEntryStatusIn");
			}
		}
		public KalturaCategoryEntryAdvancedOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
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
		public KalturaCategoryEntryAdvancedFilter()
		{
		}

		public KalturaCategoryEntryAdvancedFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoriesMatchOr":
						this.CategoriesMatchOr = txt;
						continue;
					case "categoryEntryStatusIn":
						this.CategoryEntryStatusIn = txt;
						continue;
					case "orderBy":
						this.OrderBy = (KalturaCategoryEntryAdvancedOrderBy)KalturaStringEnum.Parse(typeof(KalturaCategoryEntryAdvancedOrderBy), txt);
						continue;
					case "categoryIdEqual":
						this.CategoryIdEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryEntryAdvancedFilter");
			kparams.AddIfNotNull("categoriesMatchOr", this.CategoriesMatchOr);
			kparams.AddIfNotNull("categoryEntryStatusIn", this.CategoryEntryStatusIn);
			kparams.AddIfNotNull("orderBy", this.OrderBy);
			kparams.AddIfNotNull("categoryIdEqual", this.CategoryIdEqual);
			return kparams;
		}
		#endregion
	}
}

