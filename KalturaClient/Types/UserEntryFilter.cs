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
	public class UserEntryFilter : UserEntryBaseFilter
	{
		#region Constants
		public const string USER_ID_EQUAL_CURRENT = "userIdEqualCurrent";
		public const string IS_ANONYMOUS = "isAnonymous";
		public const string PRIVACY_CONTEXT_EQUAL = "privacyContextEqual";
		public const string PRIVACY_CONTEXT_IN = "privacyContextIn";
		public const string PARTNER_ID = "partnerId";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private NullableBoolean _UserIdEqualCurrent = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _IsAnonymous = (NullableBoolean)Int32.MinValue;
		private string _PrivacyContextEqual = null;
		private string _PrivacyContextIn = null;
		private int _PartnerId = Int32.MinValue;
		private UserEntryOrderBy _OrderBy = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UserIdEqualCurrentAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean UserIdEqualCurrent
		{
			get { return _UserIdEqualCurrent; }
			set 
			{ 
				_UserIdEqualCurrent = value;
				OnPropertyChanged("UserIdEqualCurrent");
			}
		}
		/// <summary>
		/// Use IsAnonymousAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsAnonymous
		{
			get { return _IsAnonymous; }
			set 
			{ 
				_IsAnonymous = value;
				OnPropertyChanged("IsAnonymous");
			}
		}
		/// <summary>
		/// Use PrivacyContextEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrivacyContextEqual
		{
			get { return _PrivacyContextEqual; }
			set 
			{ 
				_PrivacyContextEqual = value;
				OnPropertyChanged("PrivacyContextEqual");
			}
		}
		/// <summary>
		/// Use PrivacyContextInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PrivacyContextIn
		{
			get { return _PrivacyContextIn; }
			set 
			{ 
				_PrivacyContextIn = value;
				OnPropertyChanged("PrivacyContextIn");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use OrderByAsDouble property instead
		/// </summary>
		[JsonProperty]
		public new UserEntryOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public UserEntryFilter()
		{
		}

		public UserEntryFilter(JToken node) : base(node)
		{
			if(node["userIdEqualCurrent"] != null)
			{
				this._UserIdEqualCurrent = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["userIdEqualCurrent"].Value<string>());
			}
			if(node["isAnonymous"] != null)
			{
				this._IsAnonymous = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isAnonymous"].Value<string>());
			}
			if(node["privacyContextEqual"] != null)
			{
				this._PrivacyContextEqual = node["privacyContextEqual"].Value<string>();
			}
			if(node["privacyContextIn"] != null)
			{
				this._PrivacyContextIn = node["privacyContextIn"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (UserEntryOrderBy)StringEnum.Parse(typeof(UserEntryOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUserEntryFilter");
			kparams.AddIfNotNull("userIdEqualCurrent", this._UserIdEqualCurrent);
			kparams.AddIfNotNull("isAnonymous", this._IsAnonymous);
			kparams.AddIfNotNull("privacyContextEqual", this._PrivacyContextEqual);
			kparams.AddIfNotNull("privacyContextIn", this._PrivacyContextIn);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USER_ID_EQUAL_CURRENT:
					return "UserIdEqualCurrent";
				case IS_ANONYMOUS:
					return "IsAnonymous";
				case PRIVACY_CONTEXT_EQUAL:
					return "PrivacyContextEqual";
				case PRIVACY_CONTEXT_IN:
					return "PrivacyContextIn";
				case PARTNER_ID:
					return "PartnerId";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

