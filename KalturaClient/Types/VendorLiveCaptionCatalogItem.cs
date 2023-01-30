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
	public class VendorLiveCaptionCatalogItem : VendorCaptionsCatalogItem
	{
		#region Constants
		public const string MINIMAL_REFUND_TIME = "minimalRefundTime";
		public const string MINIMAL_ORDER_TIME = "minimalOrderTime";
		public const string DURATION_LIMIT = "durationLimit";
		#endregion

		#region Private Fields
		private int _MinimalRefundTime = Int32.MinValue;
		private int _MinimalOrderTime = Int32.MinValue;
		private int _DurationLimit = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use MinimalRefundTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinimalRefundTime
		{
			get { return _MinimalRefundTime; }
			set 
			{ 
				_MinimalRefundTime = value;
				OnPropertyChanged("MinimalRefundTime");
			}
		}
		/// <summary>
		/// Use MinimalOrderTimeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MinimalOrderTime
		{
			get { return _MinimalOrderTime; }
			set 
			{ 
				_MinimalOrderTime = value;
				OnPropertyChanged("MinimalOrderTime");
			}
		}
		/// <summary>
		/// Use DurationLimitAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int DurationLimit
		{
			get { return _DurationLimit; }
			set 
			{ 
				_DurationLimit = value;
				OnPropertyChanged("DurationLimit");
			}
		}
		#endregion

		#region CTor
		public VendorLiveCaptionCatalogItem()
		{
		}

		public VendorLiveCaptionCatalogItem(JToken node) : base(node)
		{
			if(node["minimalRefundTime"] != null)
			{
				this._MinimalRefundTime = ParseInt(node["minimalRefundTime"].Value<string>());
			}
			if(node["minimalOrderTime"] != null)
			{
				this._MinimalOrderTime = ParseInt(node["minimalOrderTime"].Value<string>());
			}
			if(node["durationLimit"] != null)
			{
				this._DurationLimit = ParseInt(node["durationLimit"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorLiveCaptionCatalogItem");
			kparams.AddIfNotNull("minimalRefundTime", this._MinimalRefundTime);
			kparams.AddIfNotNull("minimalOrderTime", this._MinimalOrderTime);
			kparams.AddIfNotNull("durationLimit", this._DurationLimit);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case MINIMAL_REFUND_TIME:
					return "MinimalRefundTime";
				case MINIMAL_ORDER_TIME:
					return "MinimalOrderTime";
				case DURATION_LIMIT:
					return "DurationLimit";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

