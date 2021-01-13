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
	public class ReoccurringVendorCredit : TimeRangeVendorCredit
	{
		#region Constants
		public const string FREQUENCY = "frequency";
		#endregion

		#region Private Fields
		private VendorCreditRecurrenceFrequency _Frequency = null;
		#endregion

		#region Properties
		[JsonProperty]
		public VendorCreditRecurrenceFrequency Frequency
		{
			get { return _Frequency; }
			set 
			{ 
				_Frequency = value;
				OnPropertyChanged("Frequency");
			}
		}
		#endregion

		#region CTor
		public ReoccurringVendorCredit()
		{
		}

		public ReoccurringVendorCredit(JToken node) : base(node)
		{
			if(node["frequency"] != null)
			{
				this._Frequency = (VendorCreditRecurrenceFrequency)StringEnum.Parse(typeof(VendorCreditRecurrenceFrequency), node["frequency"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReoccurringVendorCredit");
			kparams.AddIfNotNull("frequency", this._Frequency);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FREQUENCY:
					return "Frequency";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

