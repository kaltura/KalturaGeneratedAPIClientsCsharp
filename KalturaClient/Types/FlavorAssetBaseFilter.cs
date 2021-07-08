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
	public class FlavorAssetBaseFilter : AssetFilter
	{
		#region Constants
		public const string FLAVOR_PARAMS_ID_EQUAL = "flavorParamsIdEqual";
		public const string FLAVOR_PARAMS_ID_IN = "flavorParamsIdIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_NOT_IN = "statusNotIn";
		#endregion

		#region Private Fields
		private int _FlavorParamsIdEqual = Int32.MinValue;
		private string _FlavorParamsIdIn = null;
		private FlavorAssetStatus _StatusEqual = (FlavorAssetStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FlavorParamsIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsIdEqual
		{
			get { return _FlavorParamsIdEqual; }
			set 
			{ 
				_FlavorParamsIdEqual = value;
				OnPropertyChanged("FlavorParamsIdEqual");
			}
		}
		/// <summary>
		/// Use FlavorParamsIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorParamsIdIn
		{
			get { return _FlavorParamsIdIn; }
			set 
			{ 
				_FlavorParamsIdIn = value;
				OnPropertyChanged("FlavorParamsIdIn");
			}
		}
		/// <summary>
		/// Use StatusEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FlavorAssetStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		/// <summary>
		/// Use StatusInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		/// <summary>
		/// Use StatusNotInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		#endregion

		#region CTor
		public FlavorAssetBaseFilter()
		{
		}

		public FlavorAssetBaseFilter(JToken node) : base(node)
		{
			if(node["flavorParamsIdEqual"] != null)
			{
				this._FlavorParamsIdEqual = ParseInt(node["flavorParamsIdEqual"].Value<string>());
			}
			if(node["flavorParamsIdIn"] != null)
			{
				this._FlavorParamsIdIn = node["flavorParamsIdIn"].Value<string>();
			}
			if(node["statusEqual"] != null)
			{
				this._StatusEqual = (FlavorAssetStatus)ParseEnum(typeof(FlavorAssetStatus), node["statusEqual"].Value<string>());
			}
			if(node["statusIn"] != null)
			{
				this._StatusIn = node["statusIn"].Value<string>();
			}
			if(node["statusNotIn"] != null)
			{
				this._StatusNotIn = node["statusNotIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorAssetBaseFilter");
			kparams.AddIfNotNull("flavorParamsIdEqual", this._FlavorParamsIdEqual);
			kparams.AddIfNotNull("flavorParamsIdIn", this._FlavorParamsIdIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_PARAMS_ID_EQUAL:
					return "FlavorParamsIdEqual";
				case FLAVOR_PARAMS_ID_IN:
					return "FlavorParamsIdIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_NOT_IN:
					return "StatusNotIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

