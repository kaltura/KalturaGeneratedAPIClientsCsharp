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
	public class KalturaLiveReportInputFilter : KalturaObjectBase
	{
		#region Private Fields
		private string _EntryIds = null;
		private int _FromTime = Int32.MinValue;
		private int _ToTime = Int32.MinValue;
		private KalturaNullableBoolean _Live = (KalturaNullableBoolean)Int32.MinValue;
		private KalturaLiveReportOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public string EntryIds
		{
			get { return _EntryIds; }
			set 
			{ 
				_EntryIds = value;
				OnPropertyChanged("EntryIds");
			}
		}
		public int FromTime
		{
			get { return _FromTime; }
			set 
			{ 
				_FromTime = value;
				OnPropertyChanged("FromTime");
			}
		}
		public int ToTime
		{
			get { return _ToTime; }
			set 
			{ 
				_ToTime = value;
				OnPropertyChanged("ToTime");
			}
		}
		public KalturaNullableBoolean Live
		{
			get { return _Live; }
			set 
			{ 
				_Live = value;
				OnPropertyChanged("Live");
			}
		}
		public KalturaLiveReportOrderBy OrderBy
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
		public KalturaLiveReportInputFilter()
		{
		}

		public KalturaLiveReportInputFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryIds":
						this._EntryIds = txt;
						continue;
					case "fromTime":
						this._FromTime = ParseInt(txt);
						continue;
					case "toTime":
						this._ToTime = ParseInt(txt);
						continue;
					case "live":
						this._Live = (KalturaNullableBoolean)ParseEnum(typeof(KalturaNullableBoolean), txt);
						continue;
					case "orderBy":
						this._OrderBy = (KalturaLiveReportOrderBy)KalturaStringEnum.Parse(typeof(KalturaLiveReportOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaLiveReportInputFilter");
			kparams.AddIfNotNull("entryIds", this._EntryIds);
			kparams.AddIfNotNull("fromTime", this._FromTime);
			kparams.AddIfNotNull("toTime", this._ToTime);
			kparams.AddIfNotNull("live", this._Live);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		#endregion
	}
}

