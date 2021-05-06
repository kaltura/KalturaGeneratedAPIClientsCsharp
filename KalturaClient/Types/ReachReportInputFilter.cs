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
	public class ReachReportInputFilter : ReportInputFilter
	{
		#region Constants
		public const string SERVICE_TYPE = "serviceType";
		public const string SERVICE_FEATURE = "serviceFeature";
		public const string TURN_AROUND_TIME = "turnAroundTime";
		#endregion

		#region Private Fields
		private VendorServiceType _ServiceType = (VendorServiceType)Int32.MinValue;
		private VendorServiceFeature _ServiceFeature = (VendorServiceFeature)Int32.MinValue;
		private VendorServiceTurnAroundTime _TurnAroundTime = (VendorServiceTurnAroundTime)Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public VendorServiceType ServiceType
		{
			get { return _ServiceType; }
			set 
			{ 
				_ServiceType = value;
				OnPropertyChanged("ServiceType");
			}
		}
		[JsonProperty]
		public VendorServiceFeature ServiceFeature
		{
			get { return _ServiceFeature; }
			set 
			{ 
				_ServiceFeature = value;
				OnPropertyChanged("ServiceFeature");
			}
		}
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTime
		{
			get { return _TurnAroundTime; }
			set 
			{ 
				_TurnAroundTime = value;
				OnPropertyChanged("TurnAroundTime");
			}
		}
		#endregion

		#region CTor
		public ReachReportInputFilter()
		{
		}

		public ReachReportInputFilter(JToken node) : base(node)
		{
			if(node["serviceType"] != null)
			{
				this._ServiceType = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceType"].Value<string>());
			}
			if(node["serviceFeature"] != null)
			{
				this._ServiceFeature = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeature"].Value<string>());
			}
			if(node["turnAroundTime"] != null)
			{
				this._TurnAroundTime = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTime"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReachReportInputFilter");
			kparams.AddIfNotNull("serviceType", this._ServiceType);
			kparams.AddIfNotNull("serviceFeature", this._ServiceFeature);
			kparams.AddIfNotNull("turnAroundTime", this._TurnAroundTime);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVICE_TYPE:
					return "ServiceType";
				case SERVICE_FEATURE:
					return "ServiceFeature";
				case TURN_AROUND_TIME:
					return "TurnAroundTime";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

