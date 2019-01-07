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
	public class CopyPartnerJobData : JobData
	{
		#region Constants
		public const string FROM_PARTNER_ID = "fromPartnerId";
		public const string TO_PARTNER_ID = "toPartnerId";
		#endregion

		#region Private Fields
		private int _FromPartnerId = Int32.MinValue;
		private int _ToPartnerId = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int FromPartnerId
		{
			get { return _FromPartnerId; }
			set 
			{ 
				_FromPartnerId = value;
				OnPropertyChanged("FromPartnerId");
			}
		}
		[JsonProperty]
		public int ToPartnerId
		{
			get { return _ToPartnerId; }
			set 
			{ 
				_ToPartnerId = value;
				OnPropertyChanged("ToPartnerId");
			}
		}
		#endregion

		#region CTor
		public CopyPartnerJobData()
		{
		}

		public CopyPartnerJobData(JToken node) : base(node)
		{
			if(node["fromPartnerId"] != null)
			{
				this._FromPartnerId = ParseInt(node["fromPartnerId"].Value<string>());
			}
			if(node["toPartnerId"] != null)
			{
				this._ToPartnerId = ParseInt(node["toPartnerId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCopyPartnerJobData");
			kparams.AddIfNotNull("fromPartnerId", this._FromPartnerId);
			kparams.AddIfNotNull("toPartnerId", this._ToPartnerId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FROM_PARTNER_ID:
					return "FromPartnerId";
				case TO_PARTNER_ID:
					return "ToPartnerId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

