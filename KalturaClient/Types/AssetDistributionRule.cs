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
	public class AssetDistributionRule : ObjectBase
	{
		#region Constants
		public const string VALIDATION_ERROR = "validationError";
		public const string ASSET_DISTRIBUTION_CONDITIONS = "assetDistributionConditions";
		#endregion

		#region Private Fields
		private string _ValidationError = null;
		private IList<AssetDistributionCondition> _AssetDistributionConditions;
		#endregion

		#region Properties
		/// <summary>
		/// Use ValidationErrorAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ValidationError
		{
			get { return _ValidationError; }
			set 
			{ 
				_ValidationError = value;
				OnPropertyChanged("ValidationError");
			}
		}
		/// <summary>
		/// Use AssetDistributionConditionsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<AssetDistributionCondition> AssetDistributionConditions
		{
			get { return _AssetDistributionConditions; }
			set 
			{ 
				_AssetDistributionConditions = value;
				OnPropertyChanged("AssetDistributionConditions");
			}
		}
		#endregion

		#region CTor
		public AssetDistributionRule()
		{
		}

		public AssetDistributionRule(JToken node) : base(node)
		{
			if(node["validationError"] != null)
			{
				this._ValidationError = node["validationError"].Value<string>();
			}
			if(node["assetDistributionConditions"] != null)
			{
				this._AssetDistributionConditions = new List<AssetDistributionCondition>();
				foreach(var arrayNode in node["assetDistributionConditions"].Children())
				{
					this._AssetDistributionConditions.Add(ObjectFactory.Create<AssetDistributionCondition>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetDistributionRule");
			kparams.AddIfNotNull("validationError", this._ValidationError);
			kparams.AddIfNotNull("assetDistributionConditions", this._AssetDistributionConditions);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VALIDATION_ERROR:
					return "ValidationError";
				case ASSET_DISTRIBUTION_CONDITIONS:
					return "AssetDistributionConditions";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

