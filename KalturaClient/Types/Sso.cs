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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class Sso : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string APPLICATION_TYPE = "applicationType";
		public const string PARTNER_ID = "partnerId";
		public const string DOMAIN = "domain";
		public const string STATUS = "status";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string REDIRECT_URL = "redirectUrl";
		public const string DATA = "data";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _ApplicationType = null;
		private int _PartnerId = Int32.MinValue;
		private string _Domain = null;
		private SsoStatus _Status = (SsoStatus)Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _RedirectUrl = null;
		private string _Data = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use ApplicationTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ApplicationType
		{
			get { return _ApplicationType; }
			set 
			{ 
				_ApplicationType = value;
				OnPropertyChanged("ApplicationType");
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
		/// Use DomainAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Domain
		{
			get { return _Domain; }
			set 
			{ 
				_Domain = value;
				OnPropertyChanged("Domain");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public SsoStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use CreatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CreatedAt
		{
			get { return _CreatedAt; }
			private set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		/// <summary>
		/// Use UpdatedAtAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			private set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		/// <summary>
		/// Use RedirectUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RedirectUrl
		{
			get { return _RedirectUrl; }
			set 
			{ 
				_RedirectUrl = value;
				OnPropertyChanged("RedirectUrl");
			}
		}
		/// <summary>
		/// Use DataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		#endregion

		#region CTor
		public Sso()
		{
		}

		public Sso(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["applicationType"] != null)
			{
				this._ApplicationType = node["applicationType"].Value<string>();
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["domain"] != null)
			{
				this._Domain = node["domain"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (SsoStatus)ParseEnum(typeof(SsoStatus), node["status"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["redirectUrl"] != null)
			{
				this._RedirectUrl = node["redirectUrl"].Value<string>();
			}
			if(node["data"] != null)
			{
				this._Data = node["data"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSso");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("applicationType", this._ApplicationType);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("domain", this._Domain);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("redirectUrl", this._RedirectUrl);
			kparams.AddIfNotNull("data", this._Data);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case APPLICATION_TYPE:
					return "ApplicationType";
				case PARTNER_ID:
					return "PartnerId";
				case DOMAIN:
					return "Domain";
				case STATUS:
					return "Status";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case REDIRECT_URL:
					return "RedirectUrl";
				case DATA:
					return "Data";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

