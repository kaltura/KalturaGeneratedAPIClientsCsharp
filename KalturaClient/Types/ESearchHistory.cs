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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ESearchHistory : ObjectBase
	{
		#region Constants
		public const string SEARCH_TERM = "searchTerm";
		public const string SEARCHED_OBJECT = "searchedObject";
		public const string TIMESTAMP = "timestamp";
		#endregion

		#region Private Fields
		private string _SearchTerm = null;
		private string _SearchedObject = null;
		private int _Timestamp = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string SearchTerm
		{
			get { return _SearchTerm; }
			private set 
			{ 
				_SearchTerm = value;
				OnPropertyChanged("SearchTerm");
			}
		}
		[JsonProperty]
		public string SearchedObject
		{
			get { return _SearchedObject; }
			private set 
			{ 
				_SearchedObject = value;
				OnPropertyChanged("SearchedObject");
			}
		}
		[JsonProperty]
		public int Timestamp
		{
			get { return _Timestamp; }
			private set 
			{ 
				_Timestamp = value;
				OnPropertyChanged("Timestamp");
			}
		}
		#endregion

		#region CTor
		public ESearchHistory()
		{
		}

		public ESearchHistory(JToken node) : base(node)
		{
			if(node["searchTerm"] != null)
			{
				this._SearchTerm = node["searchTerm"].Value<string>();
			}
			if(node["searchedObject"] != null)
			{
				this._SearchedObject = node["searchedObject"].Value<string>();
			}
			if(node["timestamp"] != null)
			{
				this._Timestamp = ParseInt(node["timestamp"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchHistory");
			kparams.AddIfNotNull("searchTerm", this._SearchTerm);
			kparams.AddIfNotNull("searchedObject", this._SearchedObject);
			kparams.AddIfNotNull("timestamp", this._Timestamp);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SEARCH_TERM:
					return "SearchTerm";
				case SEARCHED_OBJECT:
					return "SearchedObject";
				case TIMESTAMP:
					return "Timestamp";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

