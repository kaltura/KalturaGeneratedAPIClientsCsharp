// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class AnalyticsFilter : ObjectBase
	{
		#region Constants
		public const string FROM_TIME = "from_time";
		public const string TO_TIME = "to_time";
		public const string METRICS = "metrics";
		public const string UTC_OFFSET = "utcOffset";
		public const string DIMENSIONS = "dimensions";
		public const string FILTERS = "filters";
		public const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _From_time = null;
		private string _To_time = null;
		private string _Metrics = null;
		private double _UtcOffset = Double.MinValue;
		private string _Dimensions = null;
		private IList<ReportFilter> _Filters;
		private string _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use From_timeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string From_time
		{
			get { return _From_time; }
			set 
			{ 
				_From_time = value;
				OnPropertyChanged("From_time");
			}
		}
		/// <summary>
		/// Use To_timeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string To_time
		{
			get { return _To_time; }
			set 
			{ 
				_To_time = value;
				OnPropertyChanged("To_time");
			}
		}
		/// <summary>
		/// Use MetricsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Metrics
		{
			get { return _Metrics; }
			set 
			{ 
				_Metrics = value;
				OnPropertyChanged("Metrics");
			}
		}
		/// <summary>
		/// Use UtcOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double UtcOffset
		{
			get { return _UtcOffset; }
			set 
			{ 
				_UtcOffset = value;
				OnPropertyChanged("UtcOffset");
			}
		}
		/// <summary>
		/// Use DimensionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Dimensions
		{
			get { return _Dimensions; }
			set 
			{ 
				_Dimensions = value;
				OnPropertyChanged("Dimensions");
			}
		}
		/// <summary>
		/// Use FiltersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ReportFilter> Filters
		{
			get { return _Filters; }
			set 
			{ 
				_Filters = value;
				OnPropertyChanged("Filters");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OrderBy
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
		public AnalyticsFilter()
		{
		}

		public AnalyticsFilter(JToken node) : base(node)
		{
			if(node["from_time"] != null)
			{
				this._From_time = node["from_time"].Value<string>();
			}
			if(node["to_time"] != null)
			{
				this._To_time = node["to_time"].Value<string>();
			}
			if(node["metrics"] != null)
			{
				this._Metrics = node["metrics"].Value<string>();
			}
			if(node["utcOffset"] != null)
			{
				this._UtcOffset = ParseDouble(node["utcOffset"].Value<string>());
			}
			if(node["dimensions"] != null)
			{
				this._Dimensions = node["dimensions"].Value<string>();
			}
			if(node["filters"] != null)
			{
				this._Filters = new List<ReportFilter>();
				foreach(var arrayNode in node["filters"].Children())
				{
					this._Filters.Add(ObjectFactory.Create<ReportFilter>(arrayNode));
				}
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = node["orderBy"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAnalyticsFilter");
			kparams.AddIfNotNull("from_time", this._From_time);
			kparams.AddIfNotNull("to_time", this._To_time);
			kparams.AddIfNotNull("metrics", this._Metrics);
			kparams.AddIfNotNull("utcOffset", this._UtcOffset);
			kparams.AddIfNotNull("dimensions", this._Dimensions);
			kparams.AddIfNotNull("filters", this._Filters);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FROM_TIME:
					return "From_time";
				case TO_TIME:
					return "To_time";
				case METRICS:
					return "Metrics";
				case UTC_OFFSET:
					return "UtcOffset";
				case DIMENSIONS:
					return "Dimensions";
				case FILTERS:
					return "Filters";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

