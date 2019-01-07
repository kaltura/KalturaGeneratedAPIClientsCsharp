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
	public class ExtractMediaJobData : ConvartableJobData
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string CALCULATE_COMPLEXITY = "calculateComplexity";
		public const string EXTRACT_ID3TAGS = "extractId3Tags";
		public const string DEST_DATA_FILE_PATH = "destDataFilePath";
		public const string DETECT_GOP = "detectGOP";
		#endregion

		#region Private Fields
		private string _FlavorAssetId = null;
		private bool? _CalculateComplexity = null;
		private bool? _ExtractId3Tags = null;
		private string _DestDataFilePath = null;
		private int _DetectGOP = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		[JsonProperty]
		public bool? CalculateComplexity
		{
			get { return _CalculateComplexity; }
			set 
			{ 
				_CalculateComplexity = value;
				OnPropertyChanged("CalculateComplexity");
			}
		}
		[JsonProperty]
		public bool? ExtractId3Tags
		{
			get { return _ExtractId3Tags; }
			set 
			{ 
				_ExtractId3Tags = value;
				OnPropertyChanged("ExtractId3Tags");
			}
		}
		[JsonProperty]
		public string DestDataFilePath
		{
			get { return _DestDataFilePath; }
			set 
			{ 
				_DestDataFilePath = value;
				OnPropertyChanged("DestDataFilePath");
			}
		}
		[JsonProperty]
		public int DetectGOP
		{
			get { return _DetectGOP; }
			set 
			{ 
				_DetectGOP = value;
				OnPropertyChanged("DetectGOP");
			}
		}
		#endregion

		#region CTor
		public ExtractMediaJobData()
		{
		}

		public ExtractMediaJobData(JToken node) : base(node)
		{
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["calculateComplexity"] != null)
			{
				this._CalculateComplexity = ParseBool(node["calculateComplexity"].Value<string>());
			}
			if(node["extractId3Tags"] != null)
			{
				this._ExtractId3Tags = ParseBool(node["extractId3Tags"].Value<string>());
			}
			if(node["destDataFilePath"] != null)
			{
				this._DestDataFilePath = node["destDataFilePath"].Value<string>();
			}
			if(node["detectGOP"] != null)
			{
				this._DetectGOP = ParseInt(node["detectGOP"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaExtractMediaJobData");
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("calculateComplexity", this._CalculateComplexity);
			kparams.AddIfNotNull("extractId3Tags", this._ExtractId3Tags);
			kparams.AddIfNotNull("destDataFilePath", this._DestDataFilePath);
			kparams.AddIfNotNull("detectGOP", this._DetectGOP);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case CALCULATE_COMPLEXITY:
					return "CalculateComplexity";
				case EXTRACT_ID3TAGS:
					return "ExtractId3Tags";
				case DEST_DATA_FILE_PATH:
					return "DestDataFilePath";
				case DETECT_GOP:
					return "DetectGOP";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

