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
	public class KalturaScheduleEventRecurrence : KalturaObjectBase
	{
		#region Private Fields
		private string _Name = null;
		private KalturaScheduleEventRecurrenceFrequency _Frequency = null;
		private int _Until = Int32.MinValue;
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
		private KalturaScheduleEventRecurrenceDay _WeekStartDay = null;
		#endregion

		#region Properties
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public KalturaScheduleEventRecurrenceFrequency Frequency
		{
			get { return _Frequency; }
			set 
			{ 
				_Frequency = value;
				OnPropertyChanged("Frequency");
			}
		}
		public int Until
		{
			get { return _Until; }
			set 
			{ 
				_Until = value;
				OnPropertyChanged("Until");
			}
		}
		public int Count
		{
			get { return _Count; }
			set 
			{ 
				_Count = value;
				OnPropertyChanged("Count");
			}
		}
		public int Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		public string BySecond
		{
			get { return _BySecond; }
			set 
			{ 
				_BySecond = value;
				OnPropertyChanged("BySecond");
			}
		}
		public string ByMinute
		{
			get { return _ByMinute; }
			set 
			{ 
				_ByMinute = value;
				OnPropertyChanged("ByMinute");
			}
		}
		public string ByHour
		{
			get { return _ByHour; }
			set 
			{ 
				_ByHour = value;
				OnPropertyChanged("ByHour");
			}
		}
		public string ByDay
		{
			get { return _ByDay; }
			set 
			{ 
				_ByDay = value;
				OnPropertyChanged("ByDay");
			}
		}
		public string ByMonthDay
		{
			get { return _ByMonthDay; }
			set 
			{ 
				_ByMonthDay = value;
				OnPropertyChanged("ByMonthDay");
			}
		}
		public string ByYearDay
		{
			get { return _ByYearDay; }
			set 
			{ 
				_ByYearDay = value;
				OnPropertyChanged("ByYearDay");
			}
		}
		public string ByWeekNumber
		{
			get { return _ByWeekNumber; }
			set 
			{ 
				_ByWeekNumber = value;
				OnPropertyChanged("ByWeekNumber");
			}
		}
		public string ByMonth
		{
			get { return _ByMonth; }
			set 
			{ 
				_ByMonth = value;
				OnPropertyChanged("ByMonth");
			}
		}
		public string ByOffset
		{
			get { return _ByOffset; }
			set 
			{ 
				_ByOffset = value;
				OnPropertyChanged("ByOffset");
			}
		}
		public KalturaScheduleEventRecurrenceDay WeekStartDay
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
		public KalturaScheduleEventRecurrence()
		{
		}

		public KalturaScheduleEventRecurrence(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "name":
						this.Name = txt;
						continue;
					case "frequency":
						this.Frequency = (KalturaScheduleEventRecurrenceFrequency)KalturaStringEnum.Parse(typeof(KalturaScheduleEventRecurrenceFrequency), txt);
						continue;
					case "until":
						this.Until = ParseInt(txt);
						continue;
					case "count":
						this.Count = ParseInt(txt);
						continue;
					case "interval":
						this.Interval = ParseInt(txt);
						continue;
					case "bySecond":
						this.BySecond = txt;
						continue;
					case "byMinute":
						this.ByMinute = txt;
						continue;
					case "byHour":
						this.ByHour = txt;
						continue;
					case "byDay":
						this.ByDay = txt;
						continue;
					case "byMonthDay":
						this.ByMonthDay = txt;
						continue;
					case "byYearDay":
						this.ByYearDay = txt;
						continue;
					case "byWeekNumber":
						this.ByWeekNumber = txt;
						continue;
					case "byMonth":
						this.ByMonth = txt;
						continue;
					case "byOffset":
						this.ByOffset = txt;
						continue;
					case "weekStartDay":
						this.WeekStartDay = (KalturaScheduleEventRecurrenceDay)KalturaStringEnum.Parse(typeof(KalturaScheduleEventRecurrenceDay), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduleEventRecurrence");
			kparams.AddIfNotNull("name", this.Name);
			kparams.AddIfNotNull("frequency", this.Frequency);
			kparams.AddIfNotNull("until", this.Until);
			kparams.AddIfNotNull("count", this.Count);
			kparams.AddIfNotNull("interval", this.Interval);
			kparams.AddIfNotNull("bySecond", this.BySecond);
			kparams.AddIfNotNull("byMinute", this.ByMinute);
			kparams.AddIfNotNull("byHour", this.ByHour);
			kparams.AddIfNotNull("byDay", this.ByDay);
			kparams.AddIfNotNull("byMonthDay", this.ByMonthDay);
			kparams.AddIfNotNull("byYearDay", this.ByYearDay);
			kparams.AddIfNotNull("byWeekNumber", this.ByWeekNumber);
			kparams.AddIfNotNull("byMonth", this.ByMonth);
			kparams.AddIfNotNull("byOffset", this.ByOffset);
			kparams.AddIfNotNull("weekStartDay", this.WeekStartDay);
			return kparams;
		}
		#endregion
	}
}

