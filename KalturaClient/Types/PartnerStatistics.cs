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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class PartnerStatistics : ObjectBase
	{
		#region Constants
		public const string PACKAGE_BANDWIDTH_AND_STORAGE = "packageBandwidthAndStorage";
		public const string HOSTING = "hosting";
		public const string BANDWIDTH = "bandwidth";
		public const string USAGE = "usage";
		public const string USAGE_PERCENT = "usagePercent";
		public const string REACHED_LIMIT_DATE = "reachedLimitDate";
		#endregion

		#region Private Fields
		private int _PackageBandwidthAndStorage = Int32.MinValue;
		private float _Hosting = Single.MinValue;
		private float _Bandwidth = Single.MinValue;
		private int _Usage = Int32.MinValue;
		private float _UsagePercent = Single.MinValue;
		private int _ReachedLimitDate = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int PackageBandwidthAndStorage
		{
			get { return _PackageBandwidthAndStorage; }
			private set 
			{ 
				_PackageBandwidthAndStorage = value;
				OnPropertyChanged("PackageBandwidthAndStorage");
			}
		}
		[JsonProperty]
		public float Hosting
		{
			get { return _Hosting; }
			private set 
			{ 
				_Hosting = value;
				OnPropertyChanged("Hosting");
			}
		}
		[JsonProperty]
		public float Bandwidth
		{
			get { return _Bandwidth; }
			private set 
			{ 
				_Bandwidth = value;
				OnPropertyChanged("Bandwidth");
			}
		}
		[JsonProperty]
		public int Usage
		{
			get { return _Usage; }
			private set 
			{ 
				_Usage = value;
				OnPropertyChanged("Usage");
			}
		}
		[JsonProperty]
		public float UsagePercent
		{
			get { return _UsagePercent; }
			private set 
			{ 
				_UsagePercent = value;
				OnPropertyChanged("UsagePercent");
			}
		}
		[JsonProperty]
		public int ReachedLimitDate
		{
			get { return _ReachedLimitDate; }
			private set 
			{ 
				_ReachedLimitDate = value;
				OnPropertyChanged("ReachedLimitDate");
			}
		}
		#endregion

		#region CTor
		public PartnerStatistics()
		{
		}

		public PartnerStatistics(JToken node) : base(node)
		{
			if(node["packageBandwidthAndStorage"] != null)
			{
				this._PackageBandwidthAndStorage = ParseInt(node["packageBandwidthAndStorage"].Value<string>());
			}
			if(node["hosting"] != null)
			{
				this._Hosting = ParseFloat(node["hosting"].Value<string>());
			}
			if(node["bandwidth"] != null)
			{
				this._Bandwidth = ParseFloat(node["bandwidth"].Value<string>());
			}
			if(node["usage"] != null)
			{
				this._Usage = ParseInt(node["usage"].Value<string>());
			}
			if(node["usagePercent"] != null)
			{
				this._UsagePercent = ParseFloat(node["usagePercent"].Value<string>());
			}
			if(node["reachedLimitDate"] != null)
			{
				this._ReachedLimitDate = ParseInt(node["reachedLimitDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPartnerStatistics");
			kparams.AddIfNotNull("packageBandwidthAndStorage", this._PackageBandwidthAndStorage);
			kparams.AddIfNotNull("hosting", this._Hosting);
			kparams.AddIfNotNull("bandwidth", this._Bandwidth);
			kparams.AddIfNotNull("usage", this._Usage);
			kparams.AddIfNotNull("usagePercent", this._UsagePercent);
			kparams.AddIfNotNull("reachedLimitDate", this._ReachedLimitDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PACKAGE_BANDWIDTH_AND_STORAGE:
					return "PackageBandwidthAndStorage";
				case HOSTING:
					return "Hosting";
				case BANDWIDTH:
					return "Bandwidth";
				case USAGE:
					return "Usage";
				case USAGE_PERCENT:
					return "UsagePercent";
				case REACHED_LIMIT_DATE:
					return "ReachedLimitDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

