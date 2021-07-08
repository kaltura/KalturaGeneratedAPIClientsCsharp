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
	public class GeoTimeLiveStats : EntryLiveStats
	{
		#region Constants
		public const string CITY = "city";
		public const string COUNTRY = "country";
		#endregion

		#region Private Fields
		private Coordinate _City;
		private Coordinate _Country;
		#endregion

		#region Properties
		/// <summary>
		/// Use CityAsDouble property instead
		/// </summary>
		[JsonProperty]
		public Coordinate City
		{
			get { return _City; }
			set 
			{ 
				_City = value;
				OnPropertyChanged("City");
			}
		}
		/// <summary>
		/// Use CountryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public Coordinate Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		#endregion

		#region CTor
		public GeoTimeLiveStats()
		{
		}

		public GeoTimeLiveStats(JToken node) : base(node)
		{
			if(node["city"] != null)
			{
				this._City = ObjectFactory.Create<Coordinate>(node["city"]);
			}
			if(node["country"] != null)
			{
				this._Country = ObjectFactory.Create<Coordinate>(node["country"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGeoTimeLiveStats");
			kparams.AddIfNotNull("city", this._City);
			kparams.AddIfNotNull("country", this._Country);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CITY:
					return "City";
				case COUNTRY:
					return "Country";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

