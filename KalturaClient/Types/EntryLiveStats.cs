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
	public class EntryLiveStats : LiveStats
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string PEAK_AUDIENCE = "peakAudience";
		public const string PEAK_DVR_AUDIENCE = "peakDvrAudience";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private int _PeakAudience = Int32.MinValue;
		private int _PeakDvrAudience = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		[JsonProperty]
		public int PeakAudience
		{
			get { return _PeakAudience; }
			set 
			{ 
				_PeakAudience = value;
				OnPropertyChanged("PeakAudience");
			}
		}
		[JsonProperty]
		public int PeakDvrAudience
		{
			get { return _PeakDvrAudience; }
			set 
			{ 
				_PeakDvrAudience = value;
				OnPropertyChanged("PeakDvrAudience");
			}
		}
		#endregion

		#region CTor
		public EntryLiveStats()
		{
		}

		public EntryLiveStats(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["peakAudience"] != null)
			{
				this._PeakAudience = ParseInt(node["peakAudience"].Value<string>());
			}
			if(node["peakDvrAudience"] != null)
			{
				this._PeakDvrAudience = ParseInt(node["peakDvrAudience"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryLiveStats");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("peakAudience", this._PeakAudience);
			kparams.AddIfNotNull("peakDvrAudience", this._PeakDvrAudience);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case PEAK_AUDIENCE:
					return "PeakAudience";
				case PEAK_DVR_AUDIENCE:
					return "PeakDvrAudience";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

