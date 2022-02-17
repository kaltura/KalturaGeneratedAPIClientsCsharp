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
	public class ESearchEntryParams : ESearchParams
	{
		#region Constants
		public const string SEARCH_OPERATOR = "searchOperator";
		public const string AGGREGATIONS = "aggregations";
		#endregion

		#region Private Fields
		private ESearchEntryOperator _SearchOperator;
		private ESearchAggregation _Aggregations;
		#endregion

		#region Properties
		/// <summary>
		/// Use SearchOperatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ESearchEntryOperator SearchOperator
		{
			get { return _SearchOperator; }
			set 
			{ 
				_SearchOperator = value;
				OnPropertyChanged("SearchOperator");
			}
		}
		/// <summary>
		/// Use AggregationsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ESearchAggregation Aggregations
		{
			get { return _Aggregations; }
			set 
			{ 
				_Aggregations = value;
				OnPropertyChanged("Aggregations");
			}
		}
		#endregion

		#region CTor
		public ESearchEntryParams()
		{
		}

		public ESearchEntryParams(JToken node) : base(node)
		{
			if(node["searchOperator"] != null)
			{
				this._SearchOperator = ObjectFactory.Create<ESearchEntryOperator>(node["searchOperator"]);
			}
			if(node["aggregations"] != null)
			{
				this._Aggregations = ObjectFactory.Create<ESearchAggregation>(node["aggregations"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchEntryParams");
			kparams.AddIfNotNull("searchOperator", this._SearchOperator);
			kparams.AddIfNotNull("aggregations", this._Aggregations);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SEARCH_OPERATOR:
					return "SearchOperator";
				case AGGREGATIONS:
					return "Aggregations";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

