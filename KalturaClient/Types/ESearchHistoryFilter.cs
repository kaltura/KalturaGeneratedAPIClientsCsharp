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
	public class ESearchHistoryFilter : ESearchBaseFilter
	{
		#region Constants
		public const string SEARCH_TERM_STARTS_WITH = "searchTermStartsWith";
		public const string SEARCHED_OBJECT_IN = "searchedObjectIn";
		#endregion

		#region Private Fields
		private string _SearchTermStartsWith = null;
		private string _SearchedObjectIn = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string SearchTermStartsWith
		{
			get { return _SearchTermStartsWith; }
			set 
			{ 
				_SearchTermStartsWith = value;
				OnPropertyChanged("SearchTermStartsWith");
			}
		}
		[JsonProperty]
		public string SearchedObjectIn
		{
			get { return _SearchedObjectIn; }
			set 
			{ 
				_SearchedObjectIn = value;
				OnPropertyChanged("SearchedObjectIn");
			}
		}
		#endregion

		#region CTor
		public ESearchHistoryFilter()
		{
		}

		public ESearchHistoryFilter(JToken node) : base(node)
		{
			if(node["searchTermStartsWith"] != null)
			{
				this._SearchTermStartsWith = node["searchTermStartsWith"].Value<string>();
			}
			if(node["searchedObjectIn"] != null)
			{
				this._SearchedObjectIn = node["searchedObjectIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchHistoryFilter");
			kparams.AddIfNotNull("searchTermStartsWith", this._SearchTermStartsWith);
			kparams.AddIfNotNull("searchedObjectIn", this._SearchedObjectIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SEARCH_TERM_STARTS_WITH:
					return "SearchTermStartsWith";
				case SEARCHED_OBJECT_IN:
					return "SearchedObjectIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

