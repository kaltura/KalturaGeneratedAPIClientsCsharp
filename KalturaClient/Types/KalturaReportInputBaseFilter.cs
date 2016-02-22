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
	public class KalturaReportInputBaseFilter : KalturaObjectBase
	{
		#region Private Fields
		private int _FromDate = Int32.MinValue;
		private int _ToDate = Int32.MinValue;
		private string _FromDay = null;
		private string _ToDay = null;
		#endregion

		#region Properties
		public int FromDate
		{
			get { return _FromDate; }
			set 
			{ 
				_FromDate = value;
				OnPropertyChanged("FromDate");
			}
		}
		public int ToDate
		{
			get { return _ToDate; }
			set 
			{ 
				_ToDate = value;
				OnPropertyChanged("ToDate");
			}
		}
		public string FromDay
		{
			get { return _FromDay; }
			set 
			{ 
				_FromDay = value;
				OnPropertyChanged("FromDay");
			}
		}
		public string ToDay
		{
			get { return _ToDay; }
			set 
			{ 
				_ToDay = value;
				OnPropertyChanged("ToDay");
			}
		}
		#endregion

		#region CTor
		public KalturaReportInputBaseFilter()
		{
		}

		public KalturaReportInputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fromDate":
						this.FromDate = ParseInt(txt);
						continue;
					case "toDate":
						this.ToDate = ParseInt(txt);
						continue;
					case "fromDay":
						this.FromDay = txt;
						continue;
					case "toDay":
						this.ToDay = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaReportInputBaseFilter");
			kparams.AddIfNotNull("fromDate", this.FromDate);
			kparams.AddIfNotNull("toDate", this.ToDate);
			kparams.AddIfNotNull("fromDay", this.FromDay);
			kparams.AddIfNotNull("toDay", this.ToDay);
			return kparams;
		}
		#endregion
	}
}

