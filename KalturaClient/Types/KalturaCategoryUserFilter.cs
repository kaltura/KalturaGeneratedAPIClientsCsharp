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
	public class KalturaCategoryUserFilter : KalturaCategoryUserBaseFilter
	{
		#region Private Fields
		private bool? _CategoryDirectMembers = false;
		private string _FreeText = null;
		private string _RelatedGroupsByUserId = null;
		private KalturaCategoryUserOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public bool? CategoryDirectMembers
		{
			get { return _CategoryDirectMembers; }
			set 
			{ 
				_CategoryDirectMembers = value;
				OnPropertyChanged("CategoryDirectMembers");
			}
		}
		public string FreeText
		{
			get { return _FreeText; }
			set 
			{ 
				_FreeText = value;
				OnPropertyChanged("FreeText");
			}
		}
		public string RelatedGroupsByUserId
		{
			get { return _RelatedGroupsByUserId; }
			set 
			{ 
				_RelatedGroupsByUserId = value;
				OnPropertyChanged("RelatedGroupsByUserId");
			}
		}
		public new KalturaCategoryUserOrderBy OrderBy
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
		public KalturaCategoryUserFilter()
		{
		}

		public KalturaCategoryUserFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryDirectMembers":
						this.CategoryDirectMembers = ParseBool(txt);
						continue;
					case "freeText":
						this.FreeText = txt;
						continue;
					case "relatedGroupsByUserId":
						this.RelatedGroupsByUserId = txt;
						continue;
					case "orderBy":
						this.OrderBy = (KalturaCategoryUserOrderBy)KalturaStringEnum.Parse(typeof(KalturaCategoryUserOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCategoryUserFilter");
			kparams.AddBoolIfNotNull("categoryDirectMembers", this.CategoryDirectMembers);
			kparams.AddStringIfNotNull("freeText", this.FreeText);
			kparams.AddStringIfNotNull("relatedGroupsByUserId", this.RelatedGroupsByUserId);
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

