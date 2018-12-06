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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		public string Ks
		{
			get { return _Ks; }
		}
		public SessionType SessionType
		{
			get { return _SessionType; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public string UserId
		{
			get { return _UserId; }
		}
		public int Expiry
		{
			get { return _Expiry; }
		}
		public string Privileges
		{
			get { return _Privileges; }
		}
		#endregion

		#region CTor
		public SessionInfo()
		{
		}

		public SessionInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "ks":
						this._Ks = propertyNode.InnerText;
						continue;
					case "sessionType":
						this._SessionType = (SessionType)ParseEnum(typeof(SessionType), propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "userId":
						this._UserId = propertyNode.InnerText;
						continue;
					case "expiry":
						this._Expiry = ParseInt(propertyNode.InnerText);
						continue;
					case "privileges":
						this._Privileges = propertyNode.InnerText;
						continue;
				}
			}
		}

		public SessionInfo(IDictionary<string,object> data) : base(data)
		{
			    this._Ks = data.TryGetValueSafe<string>("ks");
			    this._SessionType = (SessionType)ParseEnum(typeof(SessionType), data.TryGetValueSafe<int>("sessionType"));
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._UserId = data.TryGetValueSafe<string>("userId");
			    this._Expiry = data.TryGetValueSafe<int>("expiry");
			    this._Privileges = data.TryGetValueSafe<string>("privileges");
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

