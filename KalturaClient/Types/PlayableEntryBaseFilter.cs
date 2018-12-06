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
// Copyright (C) 2006-2018  Kaltura Inc.
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

namespace Kaltura.Types
{
	public class PlayableEntryBaseFilter : BaseEntryFilter
	{
		#region Constants
		public const string LAST_PLAYED_AT_GREATER_THAN_OR_EQUAL = "lastPlayedAtGreaterThanOrEqual";
		public const string LAST_PLAYED_AT_LESS_THAN_OR_EQUAL = "lastPlayedAtLessThanOrEqual";
		public const string DURATION_LESS_THAN = "durationLessThan";
		public const string DURATION_GREATER_THAN = "durationGreaterThan";
		public const string DURATION_LESS_THAN_OR_EQUAL = "durationLessThanOrEqual";
		public const string DURATION_GREATER_THAN_OR_EQUAL = "durationGreaterThanOrEqual";
		public const string DURATION_TYPE_MATCH_OR = "durationTypeMatchOr";
		#endregion

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
		public PlayableEntryBaseFilter()
		{
		}

		public PlayableEntryBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "lastPlayedAtGreaterThanOrEqual":
						this._LastPlayedAtGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "lastPlayedAtLessThanOrEqual":
						this._LastPlayedAtLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "durationLessThan":
						this._DurationLessThan = ParseInt(propertyNode.InnerText);
						continue;
					case "durationGreaterThan":
						this._DurationGreaterThan = ParseInt(propertyNode.InnerText);
						continue;
					case "durationLessThanOrEqual":
						this._DurationLessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "durationGreaterThanOrEqual":
						this._DurationGreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "durationTypeMatchOr":
						this._DurationTypeMatchOr = propertyNode.InnerText;
						continue;
				}
			}
		}

		public PlayableEntryBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._LastPlayedAtGreaterThanOrEqual = data.TryGetValueSafe<int>("lastPlayedAtGreaterThanOrEqual");
			    this._LastPlayedAtLessThanOrEqual = data.TryGetValueSafe<int>("lastPlayedAtLessThanOrEqual");
			    this._DurationLessThan = data.TryGetValueSafe<int>("durationLessThan");
			    this._DurationGreaterThan = data.TryGetValueSafe<int>("durationGreaterThan");
			    this._DurationLessThanOrEqual = data.TryGetValueSafe<int>("durationLessThanOrEqual");
			    this._DurationGreaterThanOrEqual = data.TryGetValueSafe<int>("durationGreaterThanOrEqual");
			    this._DurationTypeMatchOr = data.TryGetValueSafe<string>("durationTypeMatchOr");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
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
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LAST_PLAYED_AT_GREATER_THAN_OR_EQUAL:
					return "LastPlayedAtGreaterThanOrEqual";
				case LAST_PLAYED_AT_LESS_THAN_OR_EQUAL:
					return "LastPlayedAtLessThanOrEqual";
				case DURATION_LESS_THAN:
					return "DurationLessThan";
				case DURATION_GREATER_THAN:
					return "DurationGreaterThan";
				case DURATION_LESS_THAN_OR_EQUAL:
					return "DurationLessThanOrEqual";
				case DURATION_GREATER_THAN_OR_EQUAL:
					return "DurationGreaterThanOrEqual";
				case DURATION_TYPE_MATCH_OR:
					return "DurationTypeMatchOr";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

