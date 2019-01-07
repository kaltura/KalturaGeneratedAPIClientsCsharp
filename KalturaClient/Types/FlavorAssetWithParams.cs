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
	public class FlavorAssetWithParams : ObjectBase
	{
		#region Constants
		public const string FLAVOR_ASSET = "flavorAsset";
		public const string FLAVOR_PARAMS = "flavorParams";
		public const string ENTRY_ID = "entryId";
		#endregion

		#region Private Fields
		private FlavorAsset _FlavorAsset;
		private FlavorParams _FlavorParams;
		private string _EntryId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public FlavorAsset FlavorAsset
		{
			get { return _FlavorAsset; }
			set 
			{ 
				_FlavorAsset = value;
				OnPropertyChanged("FlavorAsset");
			}
		}
		[JsonProperty]
		public FlavorParams FlavorParams
		{
			get { return _FlavorParams; }
			set 
			{ 
				_FlavorParams = value;
				OnPropertyChanged("FlavorParams");
			}
		}
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		#endregion

		#region CTor
		public FlavorAssetWithParams()
		{
		}

		public FlavorAssetWithParams(JToken node) : base(node)
		{
			if(node["flavorAsset"] != null)
			{
				this._FlavorAsset = ObjectFactory.Create<FlavorAsset>(node["flavorAsset"]);
			}
			if(node["flavorParams"] != null)
			{
				this._FlavorParams = ObjectFactory.Create<FlavorParams>(node["flavorParams"]);
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorAssetWithParams");
			kparams.AddIfNotNull("flavorAsset", this._FlavorAsset);
			kparams.AddIfNotNull("flavorParams", this._FlavorParams);
			kparams.AddIfNotNull("entryId", this._EntryId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_ASSET:
					return "FlavorAsset";
				case FLAVOR_PARAMS:
					return "FlavorParams";
				case ENTRY_ID:
					return "EntryId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

