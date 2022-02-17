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
	public class RatingCount : ObjectBase
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string RANK = "rank";
		public const string COUNT = "count";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private int _Rank = Int32.MinValue;
		private int _Count = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use RankAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Rank
		{
			get { return _Rank; }
			set 
			{ 
				_Rank = value;
				OnPropertyChanged("Rank");
			}
		}
		/// <summary>
		/// Use CountAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public RatingCount()
		{
		}

		public RatingCount(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["rank"] != null)
			{
				this._Rank = ParseInt(node["rank"].Value<string>());
			}
			if(node["count"] != null)
			{
				this._Count = ParseInt(node["count"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRatingCount");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("rank", this._Rank);
			kparams.AddIfNotNull("count", this._Count);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case RANK:
					return "Rank";
				case COUNT:
					return "Count";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

