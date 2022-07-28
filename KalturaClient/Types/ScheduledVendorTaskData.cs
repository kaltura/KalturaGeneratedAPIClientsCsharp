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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class ScheduledVendorTaskData : VendorTaskData
	{
		#region Constants
		public const string START_DATE = "startDate";
		public const string END_DATE = "endDate";
		public const string SCHEDULED_EVENT_ID = "scheduledEventId";
		#endregion

		#region Private Fields
		private int _StartDate = Int32.MinValue;
		private int _EndDate = Int32.MinValue;
		private int _ScheduledEventId = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use StartDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int StartDate
		{
			get { return _StartDate; }
			set 
			{ 
				_StartDate = value;
				OnPropertyChanged("StartDate");
			}
		}
		/// <summary>
		/// Use EndDateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EndDate
		{
			get { return _EndDate; }
			set 
			{ 
				_EndDate = value;
				OnPropertyChanged("EndDate");
			}
		}
		/// <summary>
		/// Use ScheduledEventIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ScheduledEventId
		{
			get { return _ScheduledEventId; }
			set 
			{ 
				_ScheduledEventId = value;
				OnPropertyChanged("ScheduledEventId");
			}
		}
		#endregion

		#region CTor
		public ScheduledVendorTaskData()
		{
		}

		public ScheduledVendorTaskData(JToken node) : base(node)
		{
			if(node["startDate"] != null)
			{
				this._StartDate = ParseInt(node["startDate"].Value<string>());
			}
			if(node["endDate"] != null)
			{
				this._EndDate = ParseInt(node["endDate"].Value<string>());
			}
			if(node["scheduledEventId"] != null)
			{
				this._ScheduledEventId = ParseInt(node["scheduledEventId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduledVendorTaskData");
			kparams.AddIfNotNull("startDate", this._StartDate);
			kparams.AddIfNotNull("endDate", this._EndDate);
			kparams.AddIfNotNull("scheduledEventId", this._ScheduledEventId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case START_DATE:
					return "StartDate";
				case END_DATE:
					return "EndDate";
				case SCHEDULED_EVENT_ID:
					return "ScheduledEventId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

