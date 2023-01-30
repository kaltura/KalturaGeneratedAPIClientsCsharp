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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class RatingCountBaseFilter : RelatedFilter
	{
		#region Constants
		public const string ENTRY_ID_EQUAL = "entryIdEqual";
		public const string RANK_IN = "rankIn";
		#endregion

		#region Private Fields
		private string _EntryIdEqual = null;
		private string _RankIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use EntryIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string EntryIdEqual
		{
			get { return _EntryIdEqual; }
			set 
			{ 
				_EntryIdEqual = value;
				OnPropertyChanged("EntryIdEqual");
			}
		}
		/// <summary>
		/// Use RankInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RankIn
		{
			get { return _RankIn; }
			set 
			{ 
				_RankIn = value;
				OnPropertyChanged("RankIn");
			}
		}
		#endregion

		#region CTor
		public RatingCountBaseFilter()
		{
		}

		public RatingCountBaseFilter(JToken node) : base(node)
		{
			if(node["entryIdEqual"] != null)
			{
				this._EntryIdEqual = node["entryIdEqual"].Value<string>();
			}
			if(node["rankIn"] != null)
			{
				this._RankIn = node["rankIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaRatingCountBaseFilter");
			kparams.AddIfNotNull("entryIdEqual", this._EntryIdEqual);
			kparams.AddIfNotNull("rankIn", this._RankIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID_EQUAL:
					return "EntryIdEqual";
				case RANK_IN:
					return "RankIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

