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
	public class AssetDistributionPropertyCondition : AssetDistributionCondition
	{
		#region Constants
		public const string PROPERTY_NAME = "propertyName";
		public const string PROPERTY_VALUE = "propertyValue";
		#endregion

		#region Private Fields
		private string _PropertyName = null;
		private string _PropertyValue = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use PropertyNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PropertyName
		{
			get { return _PropertyName; }
			set 
			{ 
				_PropertyName = value;
				OnPropertyChanged("PropertyName");
			}
		}
		/// <summary>
		/// Use PropertyValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PropertyValue
		{
			get { return _PropertyValue; }
			set 
			{ 
				_PropertyValue = value;
				OnPropertyChanged("PropertyValue");
			}
		}
		#endregion

		#region CTor
		public AssetDistributionPropertyCondition()
		{
		}

		public AssetDistributionPropertyCondition(JToken node) : base(node)
		{
			if(node["propertyName"] != null)
			{
				this._PropertyName = node["propertyName"].Value<string>();
			}
			if(node["propertyValue"] != null)
			{
				this._PropertyValue = node["propertyValue"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetDistributionPropertyCondition");
			kparams.AddIfNotNull("propertyName", this._PropertyName);
			kparams.AddIfNotNull("propertyValue", this._PropertyValue);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROPERTY_NAME:
					return "PropertyName";
				case PROPERTY_VALUE:
					return "PropertyValue";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

