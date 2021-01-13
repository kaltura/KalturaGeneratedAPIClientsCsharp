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
	public class IpAddressCondition : MatchCondition
	{
		#region Constants
		public const string ACCEPT_INTERNAL_IPS = "acceptInternalIps";
		public const string HTTP_HEADER = "httpHeader";
		#endregion

		#region Private Fields
		private bool? _AcceptInternalIps = null;
		private string _HttpHeader = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? AcceptInternalIps
		{
			get { return _AcceptInternalIps; }
			set 
			{ 
				_AcceptInternalIps = value;
				OnPropertyChanged("AcceptInternalIps");
			}
		}
		[JsonProperty]
		public string HttpHeader
		{
			get { return _HttpHeader; }
			set 
			{ 
				_HttpHeader = value;
				OnPropertyChanged("HttpHeader");
			}
		}
		#endregion

		#region CTor
		public IpAddressCondition()
		{
		}

		public IpAddressCondition(JToken node) : base(node)
		{
			if(node["acceptInternalIps"] != null)
			{
				this._AcceptInternalIps = ParseBool(node["acceptInternalIps"].Value<string>());
			}
			if(node["httpHeader"] != null)
			{
				this._HttpHeader = node["httpHeader"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIpAddressCondition");
			kparams.AddIfNotNull("acceptInternalIps", this._AcceptInternalIps);
			kparams.AddIfNotNull("httpHeader", this._HttpHeader);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACCEPT_INTERNAL_IPS:
					return "AcceptInternalIps";
				case HTTP_HEADER:
					return "HttpHeader";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

