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
	public class VendorDubbingCatalogItem : VendorCatalogItem
	{
		#region Constants
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string CLEAR_AUDIO_FLAVOR_PARAMS_ID = "clearAudioFlavorParamsId";
		public const string TARGET_LANGUAGE = "targetLanguage";
		#endregion

		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private int _ClearAudioFlavorParamsId = Int32.MinValue;
		private CatalogItemLanguage _TargetLanguage = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FlavorParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		/// <summary>
		/// Use ClearAudioFlavorParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ClearAudioFlavorParamsId
		{
			get { return _ClearAudioFlavorParamsId; }
			set 
			{ 
				_ClearAudioFlavorParamsId = value;
				OnPropertyChanged("ClearAudioFlavorParamsId");
			}
		}
		/// <summary>
		/// Use TargetLanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CatalogItemLanguage TargetLanguage
		{
			get { return _TargetLanguage; }
			set 
			{ 
				_TargetLanguage = value;
				OnPropertyChanged("TargetLanguage");
			}
		}
		#endregion

		#region CTor
		public VendorDubbingCatalogItem()
		{
		}

		public VendorDubbingCatalogItem(JToken node) : base(node)
		{
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
			if(node["clearAudioFlavorParamsId"] != null)
			{
				this._ClearAudioFlavorParamsId = ParseInt(node["clearAudioFlavorParamsId"].Value<string>());
			}
			if(node["targetLanguage"] != null)
			{
				this._TargetLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["targetLanguage"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorDubbingCatalogItem");
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			kparams.AddIfNotNull("clearAudioFlavorParamsId", this._ClearAudioFlavorParamsId);
			kparams.AddIfNotNull("targetLanguage", this._TargetLanguage);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				case CLEAR_AUDIO_FLAVOR_PARAMS_ID:
					return "ClearAudioFlavorParamsId";
				case TARGET_LANGUAGE:
					return "TargetLanguage";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

