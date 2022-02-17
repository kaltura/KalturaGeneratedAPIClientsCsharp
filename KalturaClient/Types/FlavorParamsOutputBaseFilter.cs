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
	public class FlavorParamsOutputBaseFilter : FlavorParamsFilter
	{
		#region Constants
		public const string FLAVOR_PARAMS_ID_EQUAL = "flavorParamsIdEqual";
		public const string FLAVOR_PARAMS_VERSION_EQUAL = "flavorParamsVersionEqual";
		public const string FLAVOR_ASSET_ID_EQUAL = "flavorAssetIdEqual";
		public const string FLAVOR_ASSET_VERSION_EQUAL = "flavorAssetVersionEqual";
		#endregion

		#region Private Fields
		private int _FlavorParamsIdEqual = Int32.MinValue;
		private string _FlavorParamsVersionEqual = null;
		private string _FlavorAssetIdEqual = null;
		private string _FlavorAssetVersionEqual = null;
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
		/// Use FlavorParamsVersionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorParamsVersionEqual
		{
			get { return _FlavorParamsVersionEqual; }
			set 
			{ 
				_FlavorParamsVersionEqual = value;
				OnPropertyChanged("FlavorParamsVersionEqual");
			}
		}
		/// <summary>
		/// Use FlavorAssetIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetIdEqual
		{
			get { return _FlavorAssetIdEqual; }
			set 
			{ 
				_FlavorAssetIdEqual = value;
				OnPropertyChanged("FlavorAssetIdEqual");
			}
		}
		/// <summary>
		/// Use FlavorAssetVersionEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetVersionEqual
		{
			get { return _FlavorAssetVersionEqual; }
			set 
			{ 
				_FlavorAssetVersionEqual = value;
				OnPropertyChanged("FlavorAssetVersionEqual");
			}
		}
		#endregion

		#region CTor
		public FlavorParamsOutputBaseFilter()
		{
		}

		public FlavorParamsOutputBaseFilter(JToken node) : base(node)
		{
			if(node["flavorParamsIdEqual"] != null)
			{
				this._FlavorParamsIdEqual = ParseInt(node["flavorParamsIdEqual"].Value<string>());
			}
			if(node["flavorParamsVersionEqual"] != null)
			{
				this._FlavorParamsVersionEqual = node["flavorParamsVersionEqual"].Value<string>();
			}
			if(node["flavorAssetIdEqual"] != null)
			{
				this._FlavorAssetIdEqual = node["flavorAssetIdEqual"].Value<string>();
			}
			if(node["flavorAssetVersionEqual"] != null)
			{
				this._FlavorAssetVersionEqual = node["flavorAssetVersionEqual"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorParamsOutputBaseFilter");
			kparams.AddIfNotNull("flavorParamsIdEqual", this._FlavorParamsIdEqual);
			kparams.AddIfNotNull("flavorParamsVersionEqual", this._FlavorParamsVersionEqual);
			kparams.AddIfNotNull("flavorAssetIdEqual", this._FlavorAssetIdEqual);
			kparams.AddIfNotNull("flavorAssetVersionEqual", this._FlavorAssetVersionEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_PARAMS_ID_EQUAL:
					return "FlavorParamsIdEqual";
				case FLAVOR_PARAMS_VERSION_EQUAL:
					return "FlavorParamsVersionEqual";
				case FLAVOR_ASSET_ID_EQUAL:
					return "FlavorAssetIdEqual";
				case FLAVOR_ASSET_VERSION_EQUAL:
					return "FlavorAssetVersionEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

