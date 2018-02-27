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
	public class ScheduleEventResourceFilter : ScheduleEventResourceBaseFilter
	{
		#region Constants
		public const string EVENT_ID_OR_ITS_PARENT_ID_EQUAL = "eventIdOrItsParentIdEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private int _EventIdOrItsParentIdEqual = Int32.MinValue;
		private ScheduleEventResourceOrderBy _OrderBy = null;
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
		public new ScheduleEventResourceOrderBy OrderBy
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
		public ScheduleEventResourceFilter()
		{
		}

		public ScheduleEventResourceFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "eventIdOrItsParentIdEqual":
						this._EventIdOrItsParentIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "orderBy":
						this._OrderBy = (ScheduleEventResourceOrderBy)StringEnum.Parse(typeof(ScheduleEventResourceOrderBy), propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaScheduleEventResourceFilter");
			kparams.AddIfNotNull("eventIdOrItsParentIdEqual", this._EventIdOrItsParentIdEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EVENT_ID_OR_ITS_PARENT_ID_EQUAL:
					return "EventIdOrItsParentIdEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

