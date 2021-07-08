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
	public class AccessControlLimitDeliveryProfilesAction : RuleAction
	{
		#region Constants
		public const string DELIVERY_PROFILE_IDS = "deliveryProfileIds";
		public const string IS_BLOCKED_LIST = "isBlockedList";
		#endregion

		#region Private Fields
		private string _DeliveryProfileIds = null;
		private bool? _IsBlockedList = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use DeliveryProfileIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DeliveryProfileIds
		{
			get { return _DeliveryProfileIds; }
			set 
			{ 
				_DeliveryProfileIds = value;
				OnPropertyChanged("DeliveryProfileIds");
			}
		}
		/// <summary>
		/// Use IsBlockedListAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsBlockedList
		{
			get { return _IsBlockedList; }
			set 
			{ 
				_IsBlockedList = value;
				OnPropertyChanged("IsBlockedList");
			}
		}
		#endregion

		#region CTor
		public AccessControlLimitDeliveryProfilesAction()
		{
		}

		public AccessControlLimitDeliveryProfilesAction(JToken node) : base(node)
		{
			if(node["deliveryProfileIds"] != null)
			{
				this._DeliveryProfileIds = node["deliveryProfileIds"].Value<string>();
			}
			if(node["isBlockedList"] != null)
			{
				this._IsBlockedList = ParseBool(node["isBlockedList"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAccessControlLimitDeliveryProfilesAction");
			kparams.AddIfNotNull("deliveryProfileIds", this._DeliveryProfileIds);
			kparams.AddIfNotNull("isBlockedList", this._IsBlockedList);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DELIVERY_PROFILE_IDS:
					return "DeliveryProfileIds";
				case IS_BLOCKED_LIST:
					return "IsBlockedList";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

