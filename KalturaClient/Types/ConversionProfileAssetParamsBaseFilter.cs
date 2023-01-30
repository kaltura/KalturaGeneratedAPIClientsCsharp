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
	public class ConversionProfileAssetParamsBaseFilter : RelatedFilter
	{
		#region Constants
		public const string CONVERSION_PROFILE_ID_EQUAL = "conversionProfileIdEqual";
		public const string CONVERSION_PROFILE_ID_IN = "conversionProfileIdIn";
		public const string ASSET_PARAMS_ID_EQUAL = "assetParamsIdEqual";
		public const string ASSET_PARAMS_ID_IN = "assetParamsIdIn";
		public const string READY_BEHAVIOR_EQUAL = "readyBehaviorEqual";
		public const string READY_BEHAVIOR_IN = "readyBehaviorIn";
		public const string ORIGIN_EQUAL = "originEqual";
		public const string ORIGIN_IN = "originIn";
		public const string SYSTEM_NAME_EQUAL = "systemNameEqual";
		public const string SYSTEM_NAME_IN = "systemNameIn";
		#endregion

		#region Private Fields
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private string _ConversionProfileIdIn = null;
		private int _AssetParamsIdEqual = Int32.MinValue;
		private string _AssetParamsIdIn = null;
		private FlavorReadyBehaviorType _ReadyBehaviorEqual = (FlavorReadyBehaviorType)Int32.MinValue;
		private string _ReadyBehaviorIn = null;
		private AssetParamsOrigin _OriginEqual = (AssetParamsOrigin)Int32.MinValue;
		private string _OriginIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ConversionProfileIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConversionProfileIdEqual
		{
			get { return _ConversionProfileIdEqual; }
			set 
			{ 
				_ConversionProfileIdEqual = value;
				OnPropertyChanged("ConversionProfileIdEqual");
			}
		}
		/// <summary>
		/// Use ConversionProfileIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ConversionProfileIdIn
		{
			get { return _ConversionProfileIdIn; }
			set 
			{ 
				_ConversionProfileIdIn = value;
				OnPropertyChanged("ConversionProfileIdIn");
			}
		}
		/// <summary>
		/// Use AssetParamsIdEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AssetParamsIdEqual
		{
			get { return _AssetParamsIdEqual; }
			set 
			{ 
				_AssetParamsIdEqual = value;
				OnPropertyChanged("AssetParamsIdEqual");
			}
		}
		/// <summary>
		/// Use AssetParamsIdInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetParamsIdIn
		{
			get { return _AssetParamsIdIn; }
			set 
			{ 
				_AssetParamsIdIn = value;
				OnPropertyChanged("AssetParamsIdIn");
			}
		}
		/// <summary>
		/// Use ReadyBehaviorEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FlavorReadyBehaviorType ReadyBehaviorEqual
		{
			get { return _ReadyBehaviorEqual; }
			set 
			{ 
				_ReadyBehaviorEqual = value;
				OnPropertyChanged("ReadyBehaviorEqual");
			}
		}
		/// <summary>
		/// Use ReadyBehaviorInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ReadyBehaviorIn
		{
			get { return _ReadyBehaviorIn; }
			set 
			{ 
				_ReadyBehaviorIn = value;
				OnPropertyChanged("ReadyBehaviorIn");
			}
		}
		/// <summary>
		/// Use OriginEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetParamsOrigin OriginEqual
		{
			get { return _OriginEqual; }
			set 
			{ 
				_OriginEqual = value;
				OnPropertyChanged("OriginEqual");
			}
		}
		/// <summary>
		/// Use OriginInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string OriginIn
		{
			get { return _OriginIn; }
			set 
			{ 
				_OriginIn = value;
				OnPropertyChanged("OriginIn");
			}
		}
		/// <summary>
		/// Use SystemNameEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		/// <summary>
		/// Use SystemNameInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		#endregion

		#region CTor
		public ConversionProfileAssetParamsBaseFilter()
		{
		}

		public ConversionProfileAssetParamsBaseFilter(JToken node) : base(node)
		{
			if(node["conversionProfileIdEqual"] != null)
			{
				this._ConversionProfileIdEqual = ParseInt(node["conversionProfileIdEqual"].Value<string>());
			}
			if(node["conversionProfileIdIn"] != null)
			{
				this._ConversionProfileIdIn = node["conversionProfileIdIn"].Value<string>();
			}
			if(node["assetParamsIdEqual"] != null)
			{
				this._AssetParamsIdEqual = ParseInt(node["assetParamsIdEqual"].Value<string>());
			}
			if(node["assetParamsIdIn"] != null)
			{
				this._AssetParamsIdIn = node["assetParamsIdIn"].Value<string>();
			}
			if(node["readyBehaviorEqual"] != null)
			{
				this._ReadyBehaviorEqual = (FlavorReadyBehaviorType)ParseEnum(typeof(FlavorReadyBehaviorType), node["readyBehaviorEqual"].Value<string>());
			}
			if(node["readyBehaviorIn"] != null)
			{
				this._ReadyBehaviorIn = node["readyBehaviorIn"].Value<string>();
			}
			if(node["originEqual"] != null)
			{
				this._OriginEqual = (AssetParamsOrigin)ParseEnum(typeof(AssetParamsOrigin), node["originEqual"].Value<string>());
			}
			if(node["originIn"] != null)
			{
				this._OriginIn = node["originIn"].Value<string>();
			}
			if(node["systemNameEqual"] != null)
			{
				this._SystemNameEqual = node["systemNameEqual"].Value<string>();
			}
			if(node["systemNameIn"] != null)
			{
				this._SystemNameIn = node["systemNameIn"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConversionProfileAssetParamsBaseFilter");
			kparams.AddIfNotNull("conversionProfileIdEqual", this._ConversionProfileIdEqual);
			kparams.AddIfNotNull("conversionProfileIdIn", this._ConversionProfileIdIn);
			kparams.AddIfNotNull("assetParamsIdEqual", this._AssetParamsIdEqual);
			kparams.AddIfNotNull("assetParamsIdIn", this._AssetParamsIdIn);
			kparams.AddIfNotNull("readyBehaviorEqual", this._ReadyBehaviorEqual);
			kparams.AddIfNotNull("readyBehaviorIn", this._ReadyBehaviorIn);
			kparams.AddIfNotNull("originEqual", this._OriginEqual);
			kparams.AddIfNotNull("originIn", this._OriginIn);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CONVERSION_PROFILE_ID_EQUAL:
					return "ConversionProfileIdEqual";
				case CONVERSION_PROFILE_ID_IN:
					return "ConversionProfileIdIn";
				case ASSET_PARAMS_ID_EQUAL:
					return "AssetParamsIdEqual";
				case ASSET_PARAMS_ID_IN:
					return "AssetParamsIdIn";
				case READY_BEHAVIOR_EQUAL:
					return "ReadyBehaviorEqual";
				case READY_BEHAVIOR_IN:
					return "ReadyBehaviorIn";
				case ORIGIN_EQUAL:
					return "OriginEqual";
				case ORIGIN_IN:
					return "OriginIn";
				case SYSTEM_NAME_EQUAL:
					return "SystemNameEqual";
				case SYSTEM_NAME_IN:
					return "SystemNameIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

