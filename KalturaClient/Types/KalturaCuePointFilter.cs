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
	public class KalturaCuePointFilter : KalturaCuePointBaseFilter
	{
		#region Private Fields
		private string _FreeText = null;
		private KalturaNullableBoolean _UserIdEqualCurrent = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaNullableBoolean _UserIdCurrent = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaCuePointOrderBy _OrderBy = null;
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
		public KalturaNullableBoolean UserIdEqualCurrent
		{
			get { return _UserIdEqualCurrent; }
			set 
			{ 
				_UserIdEqualCurrent = value;
				OnPropertyChanged("UserIdEqualCurrent");
			}
		}
		public KalturaNullableBoolean UserIdCurrent
		{
			get { return _UserIdCurrent; }
			set 
			{ 
				_UserIdCurrent = value;
				OnPropertyChanged("UserIdCurrent");
			}
		}
		public KalturaCuePointOrderBy OrderBy
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
		public KalturaCuePointFilter()
		{
		}

		public KalturaCuePointFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "freeText":
						this._FreeText = txt;
						continue;
					case "userIdEqualCurrent":
						this._UserIdEqualCurrent = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "userIdCurrent":
						this._UserIdCurrent = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "orderBy":
						this._OrderBy = (KalturaCuePointOrderBy)KalturaStringEnum.Parse(typeof(KalturaCuePointOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCuePointFilter");
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("userIdEqualCurrent", this._UserIdEqualCurrent);
			kparams.AddIfNotNull("userIdCurrent", this._UserIdCurrent);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		#endregion
	}
}

