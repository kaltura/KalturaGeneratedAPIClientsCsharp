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
	public class WidevineFlavorParamsOutput : FlavorParamsOutput
	{
		#region Constants
		public const string WIDEVINE_DISTRIBUTION_START_DATE = "widevineDistributionStartDate";
		public const string WIDEVINE_DISTRIBUTION_END_DATE = "widevineDistributionEndDate";
		#endregion

		#region Private Fields
		private int _WidevineDistributionStartDate = Int32.MinValue;
		private int _WidevineDistributionEndDate = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int WidevineDistributionStartDate
		{
			get { return _WidevineDistributionStartDate; }
			set 
			{ 
				_WidevineDistributionStartDate = value;
				OnPropertyChanged("WidevineDistributionStartDate");
			}
		}
		[JsonProperty]
		public int WidevineDistributionEndDate
		{
			get { return _WidevineDistributionEndDate; }
			set 
			{ 
				_WidevineDistributionEndDate = value;
				OnPropertyChanged("WidevineDistributionEndDate");
			}
		}
		#endregion

		#region CTor
		public WidevineFlavorParamsOutput()
		{
		}

		public WidevineFlavorParamsOutput(JToken node) : base(node)
		{
			if(node["widevineDistributionStartDate"] != null)
			{
				this._WidevineDistributionStartDate = ParseInt(node["widevineDistributionStartDate"].Value<string>());
			}
			if(node["widevineDistributionEndDate"] != null)
			{
				this._WidevineDistributionEndDate = ParseInt(node["widevineDistributionEndDate"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaWidevineFlavorParamsOutput");
			kparams.AddIfNotNull("widevineDistributionStartDate", this._WidevineDistributionStartDate);
			kparams.AddIfNotNull("widevineDistributionEndDate", this._WidevineDistributionEndDate);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case WIDEVINE_DISTRIBUTION_START_DATE:
					return "WidevineDistributionStartDate";
				case WIDEVINE_DISTRIBUTION_END_DATE:
					return "WidevineDistributionEndDate";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

