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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class SessionInfo : ObjectBase
	{
		#region Constants
		public const string KS = "ks";
		public const string SESSION_TYPE = "sessionType";
		public const string PARTNER_ID = "partnerId";
		public const string USER_ID = "userId";
		public const string EXPIRY = "expiry";
		public const string PRIVILEGES = "privileges";
		#endregion

		#region Private Fields
		private string _Ks = null;
		private SessionType _SessionType = (SessionType)Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _UserId = null;
		private int _Expiry = Int32.MinValue;
		private string _Privileges = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use KsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Ks
		{
			get { return _Ks; }
			private set 
			{ 
				_Ks = value;
				OnPropertyChanged("Ks");
			}
		}
		/// <summary>
		/// Use SessionTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SessionType SessionType
		{
			get { return _SessionType; }
			private set 
			{ 
				_SessionType = value;
				OnPropertyChanged("SessionType");
			}
		}
		/// <summary>
		/// Use PartnerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int PartnerId
		{
			get { return _PartnerId; }
			private set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		/// <summary>
		/// Use UserIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string UserId
		{
			get { return _UserId; }
			private set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		/// <summary>
		/// Use ExpiryAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Expiry
		{
			get { return _Expiry; }
			private set 
			{ 
				_Expiry = value;
				OnPropertyChanged("Expiry");
			}
		}
		/// <summary>
		/// Use PrivilegesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Privileges
		{
			get { return _Privileges; }
			private set 
			{ 
				_Privileges = value;
				OnPropertyChanged("Privileges");
			}
		}
		#endregion

		#region CTor
		public SessionInfo()
		{
		}

		public SessionInfo(JToken node) : base(node)
		{
			if(node["ks"] != null)
			{
				this._Ks = node["ks"].Value<string>();
			}
			if(node["sessionType"] != null)
			{
				this._SessionType = (SessionType)ParseEnum(typeof(SessionType), node["sessionType"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["userId"] != null)
			{
				this._UserId = node["userId"].Value<string>();
			}
			if(node["expiry"] != null)
			{
				this._Expiry = ParseInt(node["expiry"].Value<string>());
			}
			if(node["privileges"] != null)
			{
				this._Privileges = node["privileges"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSessionInfo");
			kparams.AddIfNotNull("ks", this._Ks);
			kparams.AddIfNotNull("sessionType", this._SessionType);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("userId", this._UserId);
			kparams.AddIfNotNull("expiry", this._Expiry);
			kparams.AddIfNotNull("privileges", this._Privileges);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case KS:
					return "Ks";
				case SESSION_TYPE:
					return "SessionType";
				case PARTNER_ID:
					return "PartnerId";
				case USER_ID:
					return "UserId";
				case EXPIRY:
					return "Expiry";
				case PRIVILEGES:
					return "Privileges";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

