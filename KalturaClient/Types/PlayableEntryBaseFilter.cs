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
	public class PlayableEntryBaseFilter : BaseEntryFilter
	{
		#region Constants
		public const string LAST_PLAYED_AT_GREATER_THAN_OR_EQUAL = "lastPlayedAtGreaterThanOrEqual";
		public const string LAST_PLAYED_AT_LESS_THAN_OR_EQUAL = "lastPlayedAtLessThanOrEqual";
		public const string LAST_PLAYED_AT_LESS_THAN_OR_EQUAL_OR_NULL = "lastPlayedAtLessThanOrEqualOrNull";
		public const string DURATION_LESS_THAN = "durationLessThan";
		public const string DURATION_GREATER_THAN = "durationGreaterThan";
		public const string DURATION_LESS_THAN_OR_EQUAL = "durationLessThanOrEqual";
		public const string DURATION_GREATER_THAN_OR_EQUAL = "durationGreaterThanOrEqual";
		public const string DURATION_TYPE_MATCH_OR = "durationTypeMatchOr";
		#endregion

		#region Private Fields
		private int _LastPlayedAtGreaterThanOrEqual = Int32.MinValue;
		private int _LastPlayedAtLessThanOrEqual = Int32.MinValue;
		private int _LastPlayedAtLessThanOrEqualOrNull = Int32.MinValue;
		private int _DurationLessThan = Int32.MinValue;
		private int _DurationGreaterThan = Int32.MinValue;
		private int _DurationLessThanOrEqual = Int32.MinValue;
		private int _DurationGreaterThanOrEqual = Int32.MinValue;
		private string _DurationTypeMatchOr = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int LastPlayedAtGreaterThanOrEqual
		{
			get { return _LastPlayedAtGreaterThanOrEqual; }
			set 
			{ 
				_LastPlayedAtGreaterThanOrEqual = value;
				OnPropertyChanged("LastPlayedAtGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int LastPlayedAtLessThanOrEqual
		{
			get { return _LastPlayedAtLessThanOrEqual; }
			set 
			{ 
				_LastPlayedAtLessThanOrEqual = value;
				OnPropertyChanged("LastPlayedAtLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int LastPlayedAtLessThanOrEqualOrNull
		{
			get { return _LastPlayedAtLessThanOrEqualOrNull; }
			set 
			{ 
				_LastPlayedAtLessThanOrEqualOrNull = value;
				OnPropertyChanged("LastPlayedAtLessThanOrEqualOrNull");
			}
		}
		[JsonProperty]
		public int DurationLessThan
		{
			get { return _DurationLessThan; }
			set 
			{ 
				_DurationLessThan = value;
				OnPropertyChanged("DurationLessThan");
			}
		}
		[JsonProperty]
		public int DurationGreaterThan
		{
			get { return _DurationGreaterThan; }
			set 
			{ 
				_DurationGreaterThan = value;
				OnPropertyChanged("DurationGreaterThan");
			}
		}
		[JsonProperty]
		public int DurationLessThanOrEqual
		{
			get { return _DurationLessThanOrEqual; }
			set 
			{ 
				_DurationLessThanOrEqual = value;
				OnPropertyChanged("DurationLessThanOrEqual");
			}
		}
		[JsonProperty]
		public int DurationGreaterThanOrEqual
		{
			get { return _DurationGreaterThanOrEqual; }
			set 
			{ 
				_DurationGreaterThanOrEqual = value;
				OnPropertyChanged("DurationGreaterThanOrEqual");
			}
		}
		[JsonProperty]
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

		public PlayableEntryBaseFilter(JToken node) : base(node)
		{
			if(node["lastPlayedAtGreaterThanOrEqual"] != null)
			{
				this._LastPlayedAtGreaterThanOrEqual = ParseInt(node["lastPlayedAtGreaterThanOrEqual"].Value<string>());
			}
			if(node["lastPlayedAtLessThanOrEqual"] != null)
			{
				this._LastPlayedAtLessThanOrEqual = ParseInt(node["lastPlayedAtLessThanOrEqual"].Value<string>());
			}
			if(node["lastPlayedAtLessThanOrEqualOrNull"] != null)
			{
				this._LastPlayedAtLessThanOrEqualOrNull = ParseInt(node["lastPlayedAtLessThanOrEqualOrNull"].Value<string>());
			}
			if(node["durationLessThan"] != null)
			{
				this._DurationLessThan = ParseInt(node["durationLessThan"].Value<string>());
			}
			if(node["durationGreaterThan"] != null)
			{
				this._DurationGreaterThan = ParseInt(node["durationGreaterThan"].Value<string>());
			}
			if(node["durationLessThanOrEqual"] != null)
			{
				this._DurationLessThanOrEqual = ParseInt(node["durationLessThanOrEqual"].Value<string>());
			}
			if(node["durationGreaterThanOrEqual"] != null)
			{
				this._DurationGreaterThanOrEqual = ParseInt(node["durationGreaterThanOrEqual"].Value<string>());
			}
			if(node["durationTypeMatchOr"] != null)
			{
				this._DurationTypeMatchOr = node["durationTypeMatchOr"].Value<string>();
			}
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
			kparams.AddIfNotNull("lastPlayedAtLessThanOrEqualOrNull", this._LastPlayedAtLessThanOrEqualOrNull);
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
				case LAST_PLAYED_AT_LESS_THAN_OR_EQUAL_OR_NULL:
					return "LastPlayedAtLessThanOrEqualOrNull";
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

