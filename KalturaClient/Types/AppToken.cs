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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class AppToken : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string TOKEN = "token";
		public const string PARTNER_ID = "partnerId";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string STATUS = "status";
		public const string EXPIRY = "expiry";
		public const string SESSION_TYPE = "sessionType";
		public const string SESSION_USER_ID = "sessionUserId";
		public const string SESSION_DURATION = "sessionDuration";
		public const string SESSION_PRIVILEGES = "sessionPrivileges";
		public const string HASH_TYPE = "hashType";
		public const string DESCRIPTION = "description";
		#endregion

		#region Private Fields
		private string _Id = null;
		private string _Token = null;
		private int _PartnerId = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private AppTokenStatus _Status = (AppTokenStatus)Int32.MinValue;
		private int _Expiry = Int32.MinValue;
		private SessionType _SessionType = (SessionType)Int32.MinValue;
		private string _SessionUserId = null;
		private int _SessionDuration = Int32.MinValue;
		private string _SessionPrivileges = null;
		private AppTokenHashType _HashType = null;
		private string _Description = null;
		#endregion

		#region Properties
		public string Id
		{
			get { return _Id; }
		}
		public string Token
		{
			get { return _Token; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
		public AppTokenStatus Status
		{
			get { return _Status; }
		}
		public int Expiry
		{
			get { return _Expiry; }
			set 
			{ 
				_Expiry = value;
				OnPropertyChanged("Expiry");
			}
		}
		public SessionType SessionType
		{
			get { return _SessionType; }
			set 
			{ 
				_SessionType = value;
				OnPropertyChanged("SessionType");
			}
		}
		public string SessionUserId
		{
			get { return _SessionUserId; }
			set 
			{ 
				_SessionUserId = value;
				OnPropertyChanged("SessionUserId");
			}
		}
		public int SessionDuration
		{
			get { return _SessionDuration; }
			set 
			{ 
				_SessionDuration = value;
				OnPropertyChanged("SessionDuration");
			}
		}
		public string SessionPrivileges
		{
			get { return _SessionPrivileges; }
			set 
			{ 
				_SessionPrivileges = value;
				OnPropertyChanged("SessionPrivileges");
			}
		}
		public AppTokenHashType HashType
		{
			get { return _HashType; }
			set 
			{ 
				_HashType = value;
				OnPropertyChanged("HashType");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public AppToken()
		{
		}

		public AppToken(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = propertyNode.InnerText;
						continue;
					case "token":
						this._Token = propertyNode.InnerText;
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (AppTokenStatus)ParseEnum(typeof(AppTokenStatus), propertyNode.InnerText);
						continue;
					case "expiry":
						this._Expiry = ParseInt(propertyNode.InnerText);
						continue;
					case "sessionType":
						this._SessionType = (SessionType)ParseEnum(typeof(SessionType), propertyNode.InnerText);
						continue;
					case "sessionUserId":
						this._SessionUserId = propertyNode.InnerText;
						continue;
					case "sessionDuration":
						this._SessionDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "sessionPrivileges":
						this._SessionPrivileges = propertyNode.InnerText;
						continue;
					case "hashType":
						this._HashType = (AppTokenHashType)StringEnum.Parse(typeof(AppTokenHashType), propertyNode.InnerText);
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAppToken");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("token", this._Token);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("expiry", this._Expiry);
			kparams.AddIfNotNull("sessionType", this._SessionType);
			kparams.AddIfNotNull("sessionUserId", this._SessionUserId);
			kparams.AddIfNotNull("sessionDuration", this._SessionDuration);
			kparams.AddIfNotNull("sessionPrivileges", this._SessionPrivileges);
			kparams.AddIfNotNull("hashType", this._HashType);
			kparams.AddIfNotNull("description", this._Description);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case TOKEN:
					return "Token";
				case PARTNER_ID:
					return "PartnerId";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case STATUS:
					return "Status";
				case EXPIRY:
					return "Expiry";
				case SESSION_TYPE:
					return "SessionType";
				case SESSION_USER_ID:
					return "SessionUserId";
				case SESSION_DURATION:
					return "SessionDuration";
				case SESSION_PRIVILEGES:
					return "SessionPrivileges";
				case HASH_TYPE:
					return "HashType";
				case DESCRIPTION:
					return "Description";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

