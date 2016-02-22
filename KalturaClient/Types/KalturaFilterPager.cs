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
	public class KalturaFilterPager : KalturaObjectBase
	{
		#region Private Fields
		private int _PageSize = Int32.MinValue;
		private int _PageIndex = Int32.MinValue;
		#endregion

		#region Properties
		public int PageSize
		{
			get { return _PageSize; }
			set 
			{ 
				_PageSize = value;
				OnPropertyChanged("PageSize");
			}
		}
		public int PageIndex
		{
			get { return _PageIndex; }
			set 
			{ 
				_PageIndex = value;
				OnPropertyChanged("PageIndex");
			}
		}
		#endregion

		#region CTor
		public KalturaFilterPager()
		{
		}

		public KalturaFilterPager(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "pageSize":
						this.PageSize = ParseInt(txt);
						continue;
					case "pageIndex":
						this.PageIndex = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFilterPager");
			kparams.AddIfNotNull("pageSize", this.PageSize);
			kparams.AddIfNotNull("pageIndex", this.PageIndex);
			return kparams;
		}
		#endregion
	}
}

