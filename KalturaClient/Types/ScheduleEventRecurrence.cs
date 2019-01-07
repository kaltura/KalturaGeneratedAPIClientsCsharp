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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ScheduleEventRecurrence : ObjectBase
	{
		#region Constants
		public const string NAME = "name";
		public const string FREQUENCY = "frequency";
		public const string UNTIL = "until";
		public const string TIME_ZONE = "timeZone";
		public const string COUNT = "count";
		public const string INTERVAL = "interval";
		public const string BY_SECOND = "bySecond";
		public const string BY_MINUTE = "byMinute";
		public const string BY_HOUR = "byHour";
		public const string BY_DAY = "byDay";
		public const string BY_MONTH_DAY = "byMonthDay";
		public const string BY_YEAR_DAY = "byYearDay";
		public const string BY_WEEK_NUMBER = "byWeekNumber";
		public const string BY_MONTH = "byMonth";
		public const string BY_OFFSET = "byOffset";
		public const string WEEK_START_DAY = "weekStartDay";
		#endregion

		#region Private Fields
		private string _Name = null;
		private ScheduleEventRecurrenceFrequency _Frequency = null;
		private int _Until = Int32.MinValue;
		private string _TimeZone = null;
		private int _Count = Int32.MinValue;
		private int _Interval = Int32.MinValue;
		private string _BySecond = null;
		private string _ByMinute = null;
		private string _ByHour = null;
		private string _ByDay = null;
		private string _ByMonthDay = null;
		private string _ByYearDay = null;
		private string _ByWeekNumber = null;
		private string _ByMonth = null;
		private string _ByOffset = null;
		private ScheduleEventRecurrenceDay _WeekStartDay = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		[JsonProperty]
		public ScheduleEventRecurrenceFrequency Frequency
		{
			get { return _Frequency; }
			set 
			{ 
				_Frequency = value;
				OnPropertyChanged("Frequency");
			}
		}
		[JsonProperty]
		public int Until
		{
			get { return _Until; }
			set 
			{ 
				_Until = value;
				OnPropertyChanged("Until");
			}
		}
		[JsonProperty]
		public string TimeZone
		{
			get { return _TimeZone; }
			set 
			{ 
				_TimeZone = value;
				OnPropertyChanged("TimeZone");
			}
		}
		[JsonProperty]
		public int Count
		{
			get { return _Count; }
			set 
			{ 
				_Count = value;
				OnPropertyChanged("Count");
			}
		}
		[JsonProperty]
		public int Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		[JsonProperty]
		public string BySecond
		{
			get { return _BySecond; }
			set 
			{ 
				_BySecond = value;
				OnPropertyChanged("BySecond");
			}
		}
		[JsonProperty]
		public string ByMinute
		{
			get { return _ByMinute; }
			set 
			{ 
				_ByMinute = value;
				OnPropertyChanged("ByMinute");
			}
		}
		[JsonProperty]
		public string ByHour
		{
			get { return _ByHour; }
			set 
			{ 
				_ByHour = value;
				OnPropertyChanged("ByHour");
			}
		}
		[JsonProperty]
		public string ByDay
		{
			get { return _ByDay; }
			set 
			{ 
				_ByDay = value;
				OnPropertyChanged("ByDay");
			}
		}
		[JsonProperty]
		public string ByMonthDay
		{
			get { return _ByMonthDay; }
			set 
			{ 
				_ByMonthDay = value;
				OnPropertyChanged("ByMonthDay");
			}
		}
		[JsonProperty]
		public string ByYearDay
		{
			get { return _ByYearDay; }
			set 
			{ 
				_ByYearDay = value;
				OnPropertyChanged("ByYearDay");
			}
		}
		[JsonProperty]
		public string ByWeekNumber
		{
			get { return _ByWeekNumber; }
			set 
			{ 
				_ByWeekNumber = value;
				OnPropertyChanged("ByWeekNumber");
			}
		}
		[JsonProperty]
		public string ByMonth
		{
			get { return _ByMonth; }
			set 
			{ 
				_ByMonth = value;
				OnPropertyChanged("ByMonth");
			}
		}
		[JsonProperty]
		public string ByOffset
		{
			get { return _ByOffset; }
			set 
			{ 
				_ByOffset = value;
				OnPropertyChanged("ByOffset");
			}
		}
		[JsonProperty]
		public ScheduleEventRecurrenceDay WeekStartDay
		{
			get { return _WeekStartDay; }
			set 
			{ 
				_WeekStartDay = value;
				OnPropertyChanged("WeekStartDay");
			}
		}
		#endregion

		#region CTor
		public ScheduleEventRecurrence()
		{
		}

		public ScheduleEventRecurrence(JToken node) : base(node)
		{
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["frequency"] != null)
			{
				this._Frequency = (ScheduleEventRecurrenceFrequency)StringEnum.Parse(typeof(ScheduleEventRecurrenceFrequency), node["frequency"].Value<string>());
			}
			if(node["until"] != null)
			{
				this._Until = ParseInt(node["until"].Value<string>());
			}
			if(node["timeZone"] != null)
			{
				this._TimeZone = node["timeZone"].Value<string>();
			}
			if(node["count"] != null)
			{
				this._Count = ParseInt(node["count"].Value<string>());
			}
			if(node["interval"] != null)
			{
				this._Interval = ParseInt(node["interval"].Value<string>());
			}
			if(node["bySecond"] != null)
			{
				this._BySecond = node["bySecond"].Value<string>();
			}
			if(node["byMinute"] != null)
			{
				this._ByMinute = node["byMinute"].Value<string>();
			}
			if(node["byHour"] != null)
			{
				this._ByHour = node["byHour"].Value<string>();
			}
			if(node["byDay"] != null)
			{
				this._ByDay = node["byDay"].Value<string>();
			}
			if(node["byMonthDay"] != null)
			{
				this._ByMonthDay = node["byMonthDay"].Value<string>();
			}
			if(node["byYearDay"] != null)
			{
				this._ByYearDay = node["byYearDay"].Value<string>();
			}
			if(node["byWeekNumber"] != null)
			{
				this._ByWeekNumber = node["byWeekNumber"].Value<string>();
			}
			if(node["byMonth"] != null)
			{
				this._ByMonth = node["byMonth"].Value<string>();
			}
			if(node["byOffset"] != null)
			{
				this._ByOffset = node["byOffset"].Value<string>();
			}
			if(node["weekStartDay"] != null)
			{
				this._WeekStartDay = (ScheduleEventRecurrenceDay)StringEnum.Parse(typeof(ScheduleEventRecurrenceDay), node["weekStartDay"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaScheduleEventRecurrence");
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("frequency", this._Frequency);
			kparams.AddIfNotNull("until", this._Until);
			kparams.AddIfNotNull("timeZone", this._TimeZone);
			kparams.AddIfNotNull("count", this._Count);
			kparams.AddIfNotNull("interval", this._Interval);
			kparams.AddIfNotNull("bySecond", this._BySecond);
			kparams.AddIfNotNull("byMinute", this._ByMinute);
			kparams.AddIfNotNull("byHour", this._ByHour);
			kparams.AddIfNotNull("byDay", this._ByDay);
			kparams.AddIfNotNull("byMonthDay", this._ByMonthDay);
			kparams.AddIfNotNull("byYearDay", this._ByYearDay);
			kparams.AddIfNotNull("byWeekNumber", this._ByWeekNumber);
			kparams.AddIfNotNull("byMonth", this._ByMonth);
			kparams.AddIfNotNull("byOffset", this._ByOffset);
			kparams.AddIfNotNull("weekStartDay", this._WeekStartDay);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case NAME:
					return "Name";
				case FREQUENCY:
					return "Frequency";
				case UNTIL:
					return "Until";
				case TIME_ZONE:
					return "TimeZone";
				case COUNT:
					return "Count";
				case INTERVAL:
					return "Interval";
				case BY_SECOND:
					return "BySecond";
				case BY_MINUTE:
					return "ByMinute";
				case BY_HOUR:
					return "ByHour";
				case BY_DAY:
					return "ByDay";
				case BY_MONTH_DAY:
					return "ByMonthDay";
				case BY_YEAR_DAY:
					return "ByYearDay";
				case BY_WEEK_NUMBER:
					return "ByWeekNumber";
				case BY_MONTH:
					return "ByMonth";
				case BY_OFFSET:
					return "ByOffset";
				case WEEK_START_DAY:
					return "WeekStartDay";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

