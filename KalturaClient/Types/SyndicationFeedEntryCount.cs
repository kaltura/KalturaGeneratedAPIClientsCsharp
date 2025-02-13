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
	public class SyndicationFeedEntryCount : ObjectBase
	{
		#region Constants
		public const string TOTAL_ENTRY_COUNT = "totalEntryCount";
		public const string ACTUAL_ENTRY_COUNT = "actualEntryCount";
		public const string REQUIRE_TRANSCODING_COUNT = "requireTranscodingCount";
		#endregion

		#region Private Fields
		private int _TotalEntryCount = Int32.MinValue;
		private int _ActualEntryCount = Int32.MinValue;
		private int _RequireTranscodingCount = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int TotalEntryCount
		{
			get { return _TotalEntryCount; }
			set 
			{ 
				_TotalEntryCount = value;
				OnPropertyChanged("TotalEntryCount");
			}
		}
		[JsonProperty]
		public int ActualEntryCount
		{
			get { return _ActualEntryCount; }
			set 
			{ 
				_ActualEntryCount = value;
				OnPropertyChanged("ActualEntryCount");
			}
		}
		[JsonProperty]
		public int RequireTranscodingCount
		{
			get { return _RequireTranscodingCount; }
			set 
			{ 
				_RequireTranscodingCount = value;
				OnPropertyChanged("RequireTranscodingCount");
			}
		}
		#endregion

		#region CTor
		public SyndicationFeedEntryCount()
		{
		}

		public SyndicationFeedEntryCount(JToken node) : base(node)
		{
			if(node["totalEntryCount"] != null)
			{
				this._TotalEntryCount = ParseInt(node["totalEntryCount"].Value<string>());
			}
			if(node["actualEntryCount"] != null)
			{
				this._ActualEntryCount = ParseInt(node["actualEntryCount"].Value<string>());
			}
			if(node["requireTranscodingCount"] != null)
			{
				this._RequireTranscodingCount = ParseInt(node["requireTranscodingCount"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSyndicationFeedEntryCount");
			kparams.AddIfNotNull("totalEntryCount", this._TotalEntryCount);
			kparams.AddIfNotNull("actualEntryCount", this._ActualEntryCount);
			kparams.AddIfNotNull("requireTranscodingCount", this._RequireTranscodingCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TOTAL_ENTRY_COUNT:
					return "TotalEntryCount";
				case ACTUAL_ENTRY_COUNT:
					return "ActualEntryCount";
				case REQUIRE_TRANSCODING_COUNT:
					return "RequireTranscodingCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

