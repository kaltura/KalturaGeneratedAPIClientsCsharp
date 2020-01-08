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
	public class VendorCredit : BaseVendorCredit
	{
		#region Constants
		public const string CREDIT = "credit";
		public const string FROM_DATE = "fromDate";
		public const string OVERAGE_CREDIT = "overageCredit";
		public const string ADD_ON = "addOn";
		#endregion

		#region Private Fields
		private int _Credit = Int32.MinValue;
		private int _FromDate = Int32.MinValue;
		private int _OverageCredit = Int32.MinValue;
		private int _AddOn = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public int Credit
		{
			get { return _Credit; }
			set 
			{ 
				_Credit = value;
				OnPropertyChanged("Credit");
			}
		}
		[JsonProperty]
		public int FromDate
		{
			get { return _FromDate; }
			set 
			{ 
				_FromDate = value;
				OnPropertyChanged("FromDate");
			}
		}
		[JsonProperty]
		public int OverageCredit
		{
			get { return _OverageCredit; }
			set 
			{ 
				_OverageCredit = value;
				OnPropertyChanged("OverageCredit");
			}
		}
		[JsonProperty]
		public int AddOn
		{
			get { return _AddOn; }
			set 
			{ 
				_AddOn = value;
				OnPropertyChanged("AddOn");
			}
		}
		#endregion

		#region CTor
		public VendorCredit()
		{
		}

		public VendorCredit(JToken node) : base(node)
		{
			if(node["credit"] != null)
			{
				this._Credit = ParseInt(node["credit"].Value<string>());
			}
			if(node["fromDate"] != null)
			{
				this._FromDate = ParseInt(node["fromDate"].Value<string>());
			}
			if(node["overageCredit"] != null)
			{
				this._OverageCredit = ParseInt(node["overageCredit"].Value<string>());
			}
			if(node["addOn"] != null)
			{
				this._AddOn = ParseInt(node["addOn"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVendorCredit");
			kparams.AddIfNotNull("credit", this._Credit);
			kparams.AddIfNotNull("fromDate", this._FromDate);
			kparams.AddIfNotNull("overageCredit", this._OverageCredit);
			kparams.AddIfNotNull("addOn", this._AddOn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CREDIT:
					return "Credit";
				case FROM_DATE:
					return "FromDate";
				case OVERAGE_CREDIT:
					return "OverageCredit";
				case ADD_ON:
					return "AddOn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

