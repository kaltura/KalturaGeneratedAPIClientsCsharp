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
	public class DrmProfile : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string DESCRIPTION = "description";
		public const string PROVIDER = "provider";
		public const string STATUS = "status";
		public const string LICENSE_SERVER_URL = "licenseServerUrl";
		public const string DEFAULT_POLICY = "defaultPolicy";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string SIGNING_KEY = "signingKey";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _Description = null;
		private DrmProviderType _Provider = null;
		private DrmProfileStatus _Status = (DrmProfileStatus)Int32.MinValue;
		private string _LicenseServerUrl = null;
		private string _DefaultPolicy = null;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private string _SigningKey = null;
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
		/// Use NameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		/// <summary>
		/// Use DescriptionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		/// <summary>
		/// Use ProviderAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DrmProviderType Provider
		{
			get { return _Provider; }
			set 
			{ 
				_Provider = value;
				OnPropertyChanged("Provider");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public DrmProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use LicenseServerUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LicenseServerUrl
		{
			get { return _LicenseServerUrl; }
			set 
			{ 
				_LicenseServerUrl = value;
				OnPropertyChanged("LicenseServerUrl");
			}
		}
		/// <summary>
		/// Use DefaultPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DefaultPolicy
		{
			get { return _DefaultPolicy; }
			set 
			{ 
				_DefaultPolicy = value;
				OnPropertyChanged("DefaultPolicy");
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
		/// Use SigningKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SigningKey
		{
			get { return _SigningKey; }
			set 
			{ 
				_SigningKey = value;
				OnPropertyChanged("SigningKey");
			}
		}
		#endregion

		#region CTor
		public DrmProfile()
		{
		}

		public DrmProfile(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["partnerId"] != null)
			{
				this._PartnerId = ParseInt(node["partnerId"].Value<string>());
			}
			if(node["name"] != null)
			{
				this._Name = node["name"].Value<string>();
			}
			if(node["description"] != null)
			{
				this._Description = node["description"].Value<string>();
			}
			if(node["provider"] != null)
			{
				this._Provider = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), node["provider"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (DrmProfileStatus)ParseEnum(typeof(DrmProfileStatus), node["status"].Value<string>());
			}
			if(node["licenseServerUrl"] != null)
			{
				this._LicenseServerUrl = node["licenseServerUrl"].Value<string>();
			}
			if(node["defaultPolicy"] != null)
			{
				this._DefaultPolicy = node["defaultPolicy"].Value<string>();
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["signingKey"] != null)
			{
				this._SigningKey = node["signingKey"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDrmProfile");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("provider", this._Provider);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("licenseServerUrl", this._LicenseServerUrl);
			kparams.AddIfNotNull("defaultPolicy", this._DefaultPolicy);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("signingKey", this._SigningKey);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case PARTNER_ID:
					return "PartnerId";
				case NAME:
					return "Name";
				case DESCRIPTION:
					return "Description";
				case PROVIDER:
					return "Provider";
				case STATUS:
					return "Status";
				case LICENSE_SERVER_URL:
					return "LicenseServerUrl";
				case DEFAULT_POLICY:
					return "DefaultPolicy";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case SIGNING_KEY:
					return "SigningKey";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

