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
	public class KalturaScheduleEventResourceFilter : KalturaScheduleEventResourceBaseFilter
	{
		#region Private Fields
		private int _EventIdOrItsParentIdEqual = Int32.MinValue;
		private KalturaScheduleEventResourceOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public int EventIdOrItsParentIdEqual
		{
			get { return _EventIdOrItsParentIdEqual; }
			set 
			{ 
				_EventIdOrItsParentIdEqual = value;
				OnPropertyChanged("EventIdOrItsParentIdEqual");
			}
		}
		public KalturaScheduleEventResourceOrderBy OrderBy
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
		public KalturaScheduleEventResourceFilter()
		{
		}

		public KalturaScheduleEventResourceFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "eventIdOrItsParentIdEqual":
						this._EventIdOrItsParentIdEqual = ParseInt(txt);
						continue;
					case "orderBy":
						this._OrderBy = (KalturaScheduleEventResourceOrderBy)KalturaStringEnum.Parse(typeof(KalturaScheduleEventResourceOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduleEventResourceFilter");
			kparams.AddIfNotNull("eventIdOrItsParentIdEqual", this._EventIdOrItsParentIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		#endregion
	}
}

