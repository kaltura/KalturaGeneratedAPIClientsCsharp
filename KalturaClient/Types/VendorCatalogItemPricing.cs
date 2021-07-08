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
	public class VendorCatalogItemPricing : ObjectBase
	{
		#region Constants
		public const string PRICE_PER_UNIT = "pricePerUnit";
		public const string PRICE_FUNCTION = "priceFunction";
		#endregion

		#region Private Fields
		private double _PricePerUnit = Double.MinValue;
		private VendorCatalogItemPriceFunction _PriceFunction = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PricePerUnitAsDouble property instead
		/// </summary>
		[JsonProperty]
		[Obsolete("Use PricePerUnitAsDouble property instead")]
		public float PricePerUnit
		{
			get { return (float)_PricePerUnit; }
			set 
			{ 
				_PricePerUnit = value;
				OnPropertyChanged("PricePerUnit");
			}
		}
		///<summary>
		///Use this property PricePerUnitAsDouble instead of the float PricePerUnit property version
		///</summary>
		[JsonProperty]
		public double PricePerUnitAsDouble
		{
			get { return _PricePerUnit; }
			set 
			{ 
				_PricePerUnit = value;
				OnPropertyChanged("PricePerUnit");
			}
		}
		/// <summary>
		/// Use PriceFunctionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorCatalogItemPriceFunction PriceFunction
		{
			get { return _PriceFunction; }
			set 
			{ 
				_PriceFunction = value;
				OnPropertyChanged("PriceFunction");
			}
		}
		#endregion

		#region CTor
		public VendorCatalogItemPricing()
		{
		}

		public VendorCatalogItemPricing(JToken node) : base(node)
		{
			if(node["pricePerUnit"] != null)
			{
				this._PricePerUnit = ParseDouble(node["pricePerUnit"].Value<string>());
			}
			if(node["priceFunction"] != null)
			{
				this._PriceFunction = (VendorCatalogItemPriceFunction)StringEnum.Parse(typeof(VendorCatalogItemPriceFunction), node["priceFunction"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCatalogItemPricing");
			kparams.AddIfNotNull("pricePerUnit", this._PricePerUnit);
			kparams.AddIfNotNull("priceFunction", this._PriceFunction);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PRICE_PER_UNIT:
					return "PricePerUnit";
				case PRICE_FUNCTION:
					return "PriceFunction";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

