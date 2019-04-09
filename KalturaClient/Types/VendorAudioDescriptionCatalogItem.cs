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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class VendorAudioDescriptionCatalogItem : VendorCatalogItem
	{
		#region Constants
		public const string SOURCE_LANGUAGE = "sourceLanguage";
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		#endregion

		#region Private Fields
		private CatalogItemLanguage _SourceLanguage = null;
		private int _FlavorParamsId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public CatalogItemLanguage SourceLanguage
		{
			get { return _SourceLanguage; }
			set 
			{ 
				_SourceLanguage = value;
				OnPropertyChanged("SourceLanguage");
			}
		}
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
		#endregion

		#region CTor
		public VendorAudioDescriptionCatalogItem()
		{
		}

		public VendorAudioDescriptionCatalogItem(JToken node) : base(node)
		{
			if(node["sourceLanguage"] != null)
			{
				this._SourceLanguage = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguage"].Value<string>());
			}
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorAudioDescriptionCatalogItem");
			kparams.AddIfNotNull("sourceLanguage", this._SourceLanguage);
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SOURCE_LANGUAGE:
					return "SourceLanguage";
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

