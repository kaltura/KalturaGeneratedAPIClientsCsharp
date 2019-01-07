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
	public class LimitFlavorsRestriction : BaseRestriction
	{
		#region Constants
		public const string LIMIT_FLAVORS_RESTRICTION_TYPE = "limitFlavorsRestrictionType";
		public const string FLAVOR_PARAMS_IDS = "flavorParamsIds";
		#endregion

		#region Private Fields
		private LimitFlavorsRestrictionType _LimitFlavorsRestrictionType = (LimitFlavorsRestrictionType)Int32.MinValue;
		private string _FlavorParamsIds = null;
		#endregion

		#region Properties
		[JsonProperty]
		public LimitFlavorsRestrictionType LimitFlavorsRestrictionType
		{
			get { return _LimitFlavorsRestrictionType; }
			set 
			{ 
				_LimitFlavorsRestrictionType = value;
				OnPropertyChanged("LimitFlavorsRestrictionType");
			}
		}
		[JsonProperty]
		public string FlavorParamsIds
		{
			get { return _FlavorParamsIds; }
			set 
			{ 
				_FlavorParamsIds = value;
				OnPropertyChanged("FlavorParamsIds");
			}
		}
		#endregion

		#region CTor
		public LimitFlavorsRestriction()
		{
		}

		public LimitFlavorsRestriction(JToken node) : base(node)
		{
			if(node["limitFlavorsRestrictionType"] != null)
			{
				this._LimitFlavorsRestrictionType = (LimitFlavorsRestrictionType)ParseEnum(typeof(LimitFlavorsRestrictionType), node["limitFlavorsRestrictionType"].Value<string>());
			}
			if(node["flavorParamsIds"] != null)
			{
				this._FlavorParamsIds = node["flavorParamsIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaLimitFlavorsRestriction");
			kparams.AddIfNotNull("limitFlavorsRestrictionType", this._LimitFlavorsRestrictionType);
			kparams.AddIfNotNull("flavorParamsIds", this._FlavorParamsIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LIMIT_FLAVORS_RESTRICTION_TYPE:
					return "LimitFlavorsRestrictionType";
				case FLAVOR_PARAMS_IDS:
					return "FlavorParamsIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

