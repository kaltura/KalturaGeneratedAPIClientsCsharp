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
	public class KalturaPlayableEntryBaseFilter : KalturaBaseEntryFilter
	{
		#region Private Fields
		private int _LastPlayedAtGreaterThanOrEqual = Int32.MinValue;
		private int _LastPlayedAtLessThanOrEqual = Int32.MinValue;
		private int _DurationLessThan = Int32.MinValue;
		private int _DurationGreaterThan = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private string _DurationTypeMatchOr = null;
		#endregion

		#region Properties
		public int LastPlayedAtGreaterThanOrEqual
		{
			get { return _LastPlayedAtGreaterThanOrEqual; }
			set 
			{ 
				_LastPlayedAtGreaterThanOrEqual = value;
				OnPropertyChanged("LastPlayedAtGreaterThanOrEqual");
			}
		}
		public int LastPlayedAtLessThanOrEqual
		{
			get { return _LastPlayedAtLessThanOrEqual; }
			set 
			{ 
				_LastPlayedAtLessThanOrEqual = value;
				OnPropertyChanged("LastPlayedAtLessThanOrEqual");
			}
		}
		public int DurationLessThan
		{
			get { return _DurationLessThan; }
			set 
			{ 
				_DurationLessThan = value;
				OnPropertyChanged("DurationLessThan");
			}
		}
		public int DurationGreaterThan
		{
			get { return _DurationGreaterThan; }
			set 
			{ 
				_DurationGreaterThan = value;
				OnPropertyChanged("DurationGreaterThan");
			}
		}
		public int DurationLessThanOrEqual
		{
			get { return _DurationLessThanOrEqual; }
			set 
			{ 
				_DurationLessThanOrEqual = value;
				OnPropertyChanged("DurationLessThanOrEqual");
			}
		}
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		public string DurationTypeMatchOr
		{
			get { return _DurationTypeMatchOr; }
			set 
			{ 
				_DurationTypeMatchOr = value;
				OnPropertyChanged("DurationTypeMatchOr");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayableEntryBaseFilter()
		{
		}

		public KalturaPlayableEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "lastPlayedAtGreaterThanOrEqual":
						this._LastPlayedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "lastPlayedAtLessThanOrEqual":
						this._LastPlayedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationLessThan":
						this._DurationLessThan = ParseInt(txt);
						continue;
					case "durationGreaterThan":
						this._DurationGreaterThan = ParseInt(txt);
						continue;
					case "durationLessThanOrEqual":
						this._DurationLessThanOrEqual = ParseInt(txt);
						continue;
					case "durationGreaterThanOrEqual":
						this._DurationGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "durationTypeMatchOr":
						this._DurationTypeMatchOr = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayableEntryBaseFilter");
			kparams.AddIfNotNull("lastPlayedAtGreaterThanOrEqual", this._LastPlayedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("lastPlayedAtLessThanOrEqual", this._LastPlayedAtLessThanOrEqual);
			kparams.AddIfNotNull("durationLessThan", this._DurationLessThan);
			kparams.AddIfNotNull("durationGreaterThan", this._DurationGreaterThan);
			kparams.AddIfNotNull("durationLessThanOrEqual", this._DurationLessThanOrEqual);
			kparams.AddIfNotNull("durationGreaterThanOrEqual", this._DurationGreaterThanOrEqual);
			kparams.AddIfNotNull("durationTypeMatchOr", this._DurationTypeMatchOr);
			return kparams;
		}
		#endregion
	}
}

