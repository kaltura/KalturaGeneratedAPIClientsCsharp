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
	public class CatalogItemAdvancedFilter : SearchItem
	{
		#region Constants
		public const string SERVICE_TYPE_EQUAL = "serviceTypeEqual";
		public const string SERVICE_TYPE_IN = "serviceTypeIn";
		public const string SERVICE_FEATURE_EQUAL = "serviceFeatureEqual";
		public const string SERVICE_FEATURE_IN = "serviceFeatureIn";
		public const string TURN_AROUND_TIME_EQUAL = "turnAroundTimeEqual";
		public const string TURN_AROUND_TIME_IN = "turnAroundTimeIn";
		public const string SOURCE_LANGUAGE_EQUAL = "sourceLanguageEqual";
		public const string TARGET_LANGUAGE_EQUAL = "targetLanguageEqual";
		#endregion

		#region Private Fields
		private VendorServiceType _ServiceTypeEqual = (VendorServiceType)Int32.MinValue;
		private string _ServiceTypeIn = null;
		private VendorServiceFeature _ServiceFeatureEqual = (VendorServiceFeature)Int32.MinValue;
		private string _ServiceFeatureIn = null;
		private VendorServiceTurnAroundTime _TurnAroundTimeEqual = (VendorServiceTurnAroundTime)Int32.MinValue;
		private string _TurnAroundTimeIn = null;
		private CatalogItemLanguage _SourceLanguageEqual = null;
		private CatalogItemLanguage _TargetLanguageEqual = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ServiceTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceType ServiceTypeEqual
		{
			get { return _ServiceTypeEqual; }
			set 
			{ 
				_ServiceTypeEqual = value;
				OnPropertyChanged("ServiceTypeEqual");
			}
		}
		/// <summary>
		/// Use ServiceTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServiceTypeIn
		{
			get { return _ServiceTypeIn; }
			set 
			{ 
				_ServiceTypeIn = value;
				OnPropertyChanged("ServiceTypeIn");
			}
		}
		/// <summary>
		/// Use ServiceFeatureEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceFeature ServiceFeatureEqual
		{
			get { return _ServiceFeatureEqual; }
			set 
			{ 
				_ServiceFeatureEqual = value;
				OnPropertyChanged("ServiceFeatureEqual");
			}
		}
		/// <summary>
		/// Use ServiceFeatureInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServiceFeatureIn
		{
			get { return _ServiceFeatureIn; }
			set 
			{ 
				_ServiceFeatureIn = value;
				OnPropertyChanged("ServiceFeatureIn");
			}
		}
		/// <summary>
		/// Use TurnAroundTimeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VendorServiceTurnAroundTime TurnAroundTimeEqual
		{
			get { return _TurnAroundTimeEqual; }
			set 
			{ 
				_TurnAroundTimeEqual = value;
				OnPropertyChanged("TurnAroundTimeEqual");
			}
		}
		/// <summary>
		/// Use TurnAroundTimeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string TurnAroundTimeIn
		{
			get { return _TurnAroundTimeIn; }
			set 
			{ 
				_TurnAroundTimeIn = value;
				OnPropertyChanged("TurnAroundTimeIn");
			}
		}
		/// <summary>
		/// Use SourceLanguageEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CatalogItemLanguage SourceLanguageEqual
		{
			get { return _SourceLanguageEqual; }
			set 
			{ 
				_SourceLanguageEqual = value;
				OnPropertyChanged("SourceLanguageEqual");
			}
		}
		/// <summary>
		/// Use TargetLanguageEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CatalogItemLanguage TargetLanguageEqual
		{
			get { return _TargetLanguageEqual; }
			set 
			{ 
				_TargetLanguageEqual = value;
				OnPropertyChanged("TargetLanguageEqual");
			}
		}
		#endregion

		#region CTor
		public CatalogItemAdvancedFilter()
		{
		}

		public CatalogItemAdvancedFilter(JToken node) : base(node)
		{
			if(node["serviceTypeEqual"] != null)
			{
				this._ServiceTypeEqual = (VendorServiceType)ParseEnum(typeof(VendorServiceType), node["serviceTypeEqual"].Value<string>());
			}
			if(node["serviceTypeIn"] != null)
			{
				this._ServiceTypeIn = node["serviceTypeIn"].Value<string>();
			}
			if(node["serviceFeatureEqual"] != null)
			{
				this._ServiceFeatureEqual = (VendorServiceFeature)ParseEnum(typeof(VendorServiceFeature), node["serviceFeatureEqual"].Value<string>());
			}
			if(node["serviceFeatureIn"] != null)
			{
				this._ServiceFeatureIn = node["serviceFeatureIn"].Value<string>();
			}
			if(node["turnAroundTimeEqual"] != null)
			{
				this._TurnAroundTimeEqual = (VendorServiceTurnAroundTime)ParseEnum(typeof(VendorServiceTurnAroundTime), node["turnAroundTimeEqual"].Value<string>());
			}
			if(node["turnAroundTimeIn"] != null)
			{
				this._TurnAroundTimeIn = node["turnAroundTimeIn"].Value<string>();
			}
			if(node["sourceLanguageEqual"] != null)
			{
				this._SourceLanguageEqual = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["sourceLanguageEqual"].Value<string>());
			}
			if(node["targetLanguageEqual"] != null)
			{
				this._TargetLanguageEqual = (CatalogItemLanguage)StringEnum.Parse(typeof(CatalogItemLanguage), node["targetLanguageEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCatalogItemAdvancedFilter");
			kparams.AddIfNotNull("serviceTypeEqual", this._ServiceTypeEqual);
			kparams.AddIfNotNull("serviceTypeIn", this._ServiceTypeIn);
			kparams.AddIfNotNull("serviceFeatureEqual", this._ServiceFeatureEqual);
			kparams.AddIfNotNull("serviceFeatureIn", this._ServiceFeatureIn);
			kparams.AddIfNotNull("turnAroundTimeEqual", this._TurnAroundTimeEqual);
			kparams.AddIfNotNull("turnAroundTimeIn", this._TurnAroundTimeIn);
			kparams.AddIfNotNull("sourceLanguageEqual", this._SourceLanguageEqual);
			kparams.AddIfNotNull("targetLanguageEqual", this._TargetLanguageEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVICE_TYPE_EQUAL:
					return "ServiceTypeEqual";
				case SERVICE_TYPE_IN:
					return "ServiceTypeIn";
				case SERVICE_FEATURE_EQUAL:
					return "ServiceFeatureEqual";
				case SERVICE_FEATURE_IN:
					return "ServiceFeatureIn";
				case TURN_AROUND_TIME_EQUAL:
					return "TurnAroundTimeEqual";
				case TURN_AROUND_TIME_IN:
					return "TurnAroundTimeIn";
				case SOURCE_LANGUAGE_EQUAL:
					return "SourceLanguageEqual";
				case TARGET_LANGUAGE_EQUAL:
					return "TargetLanguageEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

