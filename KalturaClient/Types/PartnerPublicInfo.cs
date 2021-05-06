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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class PartnerPublicInfo : ObjectBase
	{
		#region Constants
		public const string ANALYTICS_URL = "analyticsUrl";
		public const string OTT_ENVIRONMENT_URL = "ottEnvironmentUrl";
		public const string ANALYTICS_PERSISTENT_SESSION_ID = "analyticsPersistentSessionId";
		#endregion

		#region Private Fields
		private string _AnalyticsUrl = null;
		private string _OttEnvironmentUrl = null;
		private bool? _AnalyticsPersistentSessionId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string AnalyticsUrl
		{
			get { return _AnalyticsUrl; }
			set 
			{ 
				_AnalyticsUrl = value;
				OnPropertyChanged("AnalyticsUrl");
			}
		}
		[JsonProperty]
		public string OttEnvironmentUrl
		{
			get { return _OttEnvironmentUrl; }
			set 
			{ 
				_OttEnvironmentUrl = value;
				OnPropertyChanged("OttEnvironmentUrl");
			}
		}
		[JsonProperty]
		public bool? AnalyticsPersistentSessionId
		{
			get { return _AnalyticsPersistentSessionId; }
			set 
			{ 
				_AnalyticsPersistentSessionId = value;
				OnPropertyChanged("AnalyticsPersistentSessionId");
			}
		}
		#endregion

		#region CTor
		public PartnerPublicInfo()
		{
		}

		public PartnerPublicInfo(JToken node) : base(node)
		{
			if(node["analyticsUrl"] != null)
			{
				this._AnalyticsUrl = node["analyticsUrl"].Value<string>();
			}
			if(node["ottEnvironmentUrl"] != null)
			{
				this._OttEnvironmentUrl = node["ottEnvironmentUrl"].Value<string>();
			}
			if(node["analyticsPersistentSessionId"] != null)
			{
				this._AnalyticsPersistentSessionId = ParseBool(node["analyticsPersistentSessionId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPartnerPublicInfo");
			kparams.AddIfNotNull("analyticsUrl", this._AnalyticsUrl);
			kparams.AddIfNotNull("ottEnvironmentUrl", this._OttEnvironmentUrl);
			kparams.AddIfNotNull("analyticsPersistentSessionId", this._AnalyticsPersistentSessionId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ANALYTICS_URL:
					return "AnalyticsUrl";
				case OTT_ENVIRONMENT_URL:
					return "OttEnvironmentUrl";
				case ANALYTICS_PERSISTENT_SESSION_ID:
					return "AnalyticsPersistentSessionId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

