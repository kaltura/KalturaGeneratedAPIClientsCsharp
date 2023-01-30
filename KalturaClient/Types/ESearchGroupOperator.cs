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
	public class ESearchGroupOperator : ESearchGroupBaseItem
	{
		#region Constants
		public const string OPERATOR = "operator";
		public const string SEARCH_ITEMS = "searchItems";
		#endregion

		#region Private Fields
		private ESearchOperatorType _Operator = (ESearchOperatorType)Int32.MinValue;
		private IList<ESearchGroupBaseItem> _SearchItems;
		#endregion

		#region Properties
		/// <summary>
		/// Use OperatorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public ESearchOperatorType Operator
		{
			get { return _Operator; }
			set 
			{ 
				_Operator = value;
				OnPropertyChanged("Operator");
			}
		}
		/// <summary>
		/// Use SearchItemsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<ESearchGroupBaseItem> SearchItems
		{
			get { return _SearchItems; }
			set 
			{ 
				_SearchItems = value;
				OnPropertyChanged("SearchItems");
			}
		}
		#endregion

		#region CTor
		public ESearchGroupOperator()
		{
		}

		public ESearchGroupOperator(JToken node) : base(node)
		{
			if(node["operator"] != null)
			{
				this._Operator = (ESearchOperatorType)ParseEnum(typeof(ESearchOperatorType), node["operator"].Value<string>());
			}
			if(node["searchItems"] != null)
			{
				this._SearchItems = new List<ESearchGroupBaseItem>();
				foreach(var arrayNode in node["searchItems"].Children())
				{
					this._SearchItems.Add(ObjectFactory.Create<ESearchGroupBaseItem>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchGroupOperator");
			kparams.AddIfNotNull("operator", this._Operator);
			kparams.AddIfNotNull("searchItems", this._SearchItems);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OPERATOR:
					return "Operator";
				case SEARCH_ITEMS:
					return "SearchItems";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

