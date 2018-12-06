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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		public int FlavorParamsIdEqual
		{
			get { return _FlavorParamsIdEqual; }
			set 
			{ 
				_FlavorParamsIdEqual = value;
				OnPropertyChanged("FlavorParamsIdEqual");
			}
		}
		public string FlavorParamsIdIn
		{
			get { return _FlavorParamsIdIn; }
			set 
			{ 
				_FlavorParamsIdIn = value;
				OnPropertyChanged("FlavorParamsIdIn");
			}
		}
		public FlavorAssetStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
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

		public FlavorAssetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "flavorParamsIdEqual":
						this._FlavorParamsIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorParamsIdIn":
						this._FlavorParamsIdIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (FlavorAssetStatus)ParseEnum(typeof(FlavorAssetStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "statusNotIn":
						this._StatusNotIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public FlavorAssetBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._FlavorParamsIdEqual = data.TryGetValueSafe<int>("flavorParamsIdEqual");
			    this._FlavorParamsIdIn = data.TryGetValueSafe<string>("flavorParamsIdIn");
			    this._StatusEqual = (FlavorAssetStatus)ParseEnum(typeof(FlavorAssetStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._StatusNotIn = data.TryGetValueSafe<string>("statusNotIn");
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

