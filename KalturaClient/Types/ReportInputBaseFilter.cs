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
	public class ReportInputBaseFilter : ObjectBase
	{
		#region Constants
		public const string FROM_DATE = "fromDate";
		public const string TO_DATE = "toDate";
		public const string FROM_DAY = "fromDay";
		public const string TO_DAY = "toDay";
		#endregion

		#region Private Fields
		private int _FromDate = Int32.MinValue;
		private int _ToDate = Int32.MinValue;
		private string _FromDay = null;
		private string _ToDay = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int FromDate
		{
			get { return _FromDate; }
			set 
			{ 
				_FromDate = value;
				OnPropertyChanged("FromDate");
			}
		}
		[JsonProperty]
		public int ToDate
		{
			get { return _ToDate; }
			set 
			{ 
				_ToDate = value;
				OnPropertyChanged("ToDate");
			}
		}
		[JsonProperty]
		public string FromDay
		{
			get { return _FromDay; }
			set 
			{ 
				_FromDay = value;
				OnPropertyChanged("FromDay");
			}
		}
		[JsonProperty]
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
		public ReportInputBaseFilter()
		{
		}

		public ReportInputBaseFilter(JToken node) : base(node)
		{
			if(node["fromDate"] != null)
			{
				this._FromDate = ParseInt(node["fromDate"].Value<string>());
			}
			if(node["toDate"] != null)
			{
				this._ToDate = ParseInt(node["toDate"].Value<string>());
			}
			if(node["fromDay"] != null)
			{
				this._FromDay = node["fromDay"].Value<string>();
			}
			if(node["toDay"] != null)
			{
				this._ToDay = node["toDay"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportInputBaseFilter");
			kparams.AddIfNotNull("fromDate", this._FromDate);
			kparams.AddIfNotNull("toDate", this._ToDate);
			kparams.AddIfNotNull("fromDay", this._FromDay);
			kparams.AddIfNotNull("toDay", this._ToDay);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FROM_DATE:
					return "FromDate";
				case TO_DATE:
					return "ToDate";
				case FROM_DAY:
					return "FromDay";
				case TO_DAY:
					return "ToDay";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

