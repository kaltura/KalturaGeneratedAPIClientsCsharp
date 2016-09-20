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
	public class KalturaAnalyticsFilter : KalturaObjectBase
	{
		#region Private Fields
		private string _From_time = null;
		private string _To_time = null;
		private string _Metrics = null;
		private float _UtcOffset = Single.MinValue;
		private string _Dimensions = null;
		private IList<KalturaReportFilter> _Filters;
		#endregion

		#region Properties
		public string From_time
		{
			get { return _From_time; }
			set 
			{ 
				_From_time = value;
				OnPropertyChanged("From_time");
			}
		}
		public string To_time
		{
			get { return _To_time; }
			set 
			{ 
				_To_time = value;
				OnPropertyChanged("To_time");
			}
		}
		public string Metrics
		{
			get { return _Metrics; }
			set 
			{ 
				_Metrics = value;
				OnPropertyChanged("Metrics");
			}
		}
		public float UtcOffset
		{
			get { return _UtcOffset; }
			set 
			{ 
				_UtcOffset = value;
				OnPropertyChanged("UtcOffset");
			}
		}
		public string Dimensions
		{
			get { return _Dimensions; }
			set 
			{ 
				_Dimensions = value;
				OnPropertyChanged("Dimensions");
			}
		}
		public new IList<KalturaReportFilter> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		#endregion

		#region CTor
		public KalturaAnalyticsFilter()
		{
		}

		public KalturaAnalyticsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "from_time":
						this._From_time = txt;
						continue;
					case "to_time":
						this._To_time = txt;
						continue;
					case "metrics":
						this._Metrics = txt;
						continue;
					case "utcOffset":
						this._UtcOffset = ParseFloat(txt);
						continue;
					case "dimensions":
						this._Dimensions = txt;
						continue;
					case "filters":
						this._Filters = new List<KalturaReportFilter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Filters.Add((KalturaReportFilter)KalturaObjectFactory.Create(arrayNode, "KalturaReportFilter"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAnalyticsFilter");
			kparams.AddIfNotNull("from_time", this.From_time);
			kparams.AddIfNotNull("to_time", this.To_time);
			kparams.AddIfNotNull("metrics", this.Metrics);
			kparams.AddIfNotNull("utcOffset", this.UtcOffset);
			kparams.AddIfNotNull("dimensions", this.Dimensions);
			kparams.AddIfNotNull("filters", this.Filters);
			return kparams;
		}
		#endregion
	}
}

