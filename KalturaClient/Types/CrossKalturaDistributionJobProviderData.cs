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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class CrossKalturaDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string DISTRIBUTED_FLAVOR_ASSETS = "distributedFlavorAssets";
		public const string DISTRIBUTED_THUMB_ASSETS = "distributedThumbAssets";
		public const string DISTRIBUTED_METADATA = "distributedMetadata";
		public const string DISTRIBUTED_CAPTION_ASSETS = "distributedCaptionAssets";
		public const string DISTRIBUTED_CUE_POINTS = "distributedCuePoints";
		public const string DISTRIBUTED_THUMB_CUE_POINTS = "distributedThumbCuePoints";
		public const string DISTRIBUTED_TIMED_THUMB_ASSETS = "distributedTimedThumbAssets";
		#endregion

		#region Private Fields
		private string _DistributedFlavorAssets = null;
		private string _DistributedThumbAssets = null;
		private string _DistributedMetadata = null;
		private string _DistributedCaptionAssets = null;
		private string _DistributedCuePoints = null;
		private string _DistributedThumbCuePoints = null;
		private string _DistributedTimedThumbAssets = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string DistributedFlavorAssets
		{
			get { return _DistributedFlavorAssets; }
			set 
			{ 
				_DistributedFlavorAssets = value;
				OnPropertyChanged("DistributedFlavorAssets");
			}
		}
		[JsonProperty]
		public string DistributedThumbAssets
		{
			get { return _DistributedThumbAssets; }
			set 
			{ 
				_DistributedThumbAssets = value;
				OnPropertyChanged("DistributedThumbAssets");
			}
		}
		[JsonProperty]
		public string DistributedMetadata
		{
			get { return _DistributedMetadata; }
			set 
			{ 
				_DistributedMetadata = value;
				OnPropertyChanged("DistributedMetadata");
			}
		}
		[JsonProperty]
		public string DistributedCaptionAssets
		{
			get { return _DistributedCaptionAssets; }
			set 
			{ 
				_DistributedCaptionAssets = value;
				OnPropertyChanged("DistributedCaptionAssets");
			}
		}
		[JsonProperty]
		public string DistributedCuePoints
		{
			get { return _DistributedCuePoints; }
			set 
			{ 
				_DistributedCuePoints = value;
				OnPropertyChanged("DistributedCuePoints");
			}
		}
		[JsonProperty]
		public string DistributedThumbCuePoints
		{
			get { return _DistributedThumbCuePoints; }
			set 
			{ 
				_DistributedThumbCuePoints = value;
				OnPropertyChanged("DistributedThumbCuePoints");
			}
		}
		[JsonProperty]
		public string DistributedTimedThumbAssets
		{
			get { return _DistributedTimedThumbAssets; }
			set 
			{ 
				_DistributedTimedThumbAssets = value;
				OnPropertyChanged("DistributedTimedThumbAssets");
			}
		}
		#endregion

		#region CTor
		public CrossKalturaDistributionJobProviderData()
		{
		}

		public CrossKalturaDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["distributedFlavorAssets"] != null)
			{
				this._DistributedFlavorAssets = node["distributedFlavorAssets"].Value<string>();
			}
			if(node["distributedThumbAssets"] != null)
			{
				this._DistributedThumbAssets = node["distributedThumbAssets"].Value<string>();
			}
			if(node["distributedMetadata"] != null)
			{
				this._DistributedMetadata = node["distributedMetadata"].Value<string>();
			}
			if(node["distributedCaptionAssets"] != null)
			{
				this._DistributedCaptionAssets = node["distributedCaptionAssets"].Value<string>();
			}
			if(node["distributedCuePoints"] != null)
			{
				this._DistributedCuePoints = node["distributedCuePoints"].Value<string>();
			}
			if(node["distributedThumbCuePoints"] != null)
			{
				this._DistributedThumbCuePoints = node["distributedThumbCuePoints"].Value<string>();
			}
			if(node["distributedTimedThumbAssets"] != null)
			{
				this._DistributedTimedThumbAssets = node["distributedTimedThumbAssets"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCrossKalturaDistributionJobProviderData");
			kparams.AddIfNotNull("distributedFlavorAssets", this._DistributedFlavorAssets);
			kparams.AddIfNotNull("distributedThumbAssets", this._DistributedThumbAssets);
			kparams.AddIfNotNull("distributedMetadata", this._DistributedMetadata);
			kparams.AddIfNotNull("distributedCaptionAssets", this._DistributedCaptionAssets);
			kparams.AddIfNotNull("distributedCuePoints", this._DistributedCuePoints);
			kparams.AddIfNotNull("distributedThumbCuePoints", this._DistributedThumbCuePoints);
			kparams.AddIfNotNull("distributedTimedThumbAssets", this._DistributedTimedThumbAssets);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DISTRIBUTED_FLAVOR_ASSETS:
					return "DistributedFlavorAssets";
				case DISTRIBUTED_THUMB_ASSETS:
					return "DistributedThumbAssets";
				case DISTRIBUTED_METADATA:
					return "DistributedMetadata";
				case DISTRIBUTED_CAPTION_ASSETS:
					return "DistributedCaptionAssets";
				case DISTRIBUTED_CUE_POINTS:
					return "DistributedCuePoints";
				case DISTRIBUTED_THUMB_CUE_POINTS:
					return "DistributedThumbCuePoints";
				case DISTRIBUTED_TIMED_THUMB_ASSETS:
					return "DistributedTimedThumbAssets";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

