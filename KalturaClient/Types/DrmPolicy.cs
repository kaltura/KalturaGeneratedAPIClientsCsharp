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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class DrmPolicy : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string PARTNER_ID = "partnerId";
		public const string NAME = "name";
		public const string SYSTEM_NAME = "systemName";
		public const string DESCRIPTION = "description";
		public const string PROVIDER = "provider";
		public const string STATUS = "status";
		public const string SCENARIO = "scenario";
		public const string LICENSE_TYPE = "licenseType";
		public const string LICENSE_EXPIRATION_POLICY = "licenseExpirationPolicy";
		public const string DURATION = "duration";
		public const string CREATED_AT = "createdAt";
		public const string UPDATED_AT = "updatedAt";
		public const string LICENSE_PARAMS = "licenseParams";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private DrmProviderType _Provider = null;
		private DrmPolicyStatus _Status = (DrmPolicyStatus)Int32.MinValue;
		private DrmLicenseScenario _Scenario = null;
		private DrmLicenseType _LicenseType = null;
		private DrmLicenseExpirationPolicy _LicenseExpirationPolicy = (DrmLicenseExpirationPolicy)Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		private IList<KeyValue> _LicenseParams;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
			}
		}
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
		[JsonProperty]
		public DrmPolicyStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		[JsonProperty]
		public DrmLicenseScenario Scenario
		{
			get { return _Scenario; }
			set 
			{ 
				_Scenario = value;
				OnPropertyChanged("Scenario");
			}
		}
		[JsonProperty]
		public DrmLicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		[JsonProperty]
		public DrmLicenseExpirationPolicy LicenseExpirationPolicy
		{
			get { return _LicenseExpirationPolicy; }
			set 
			{ 
				_LicenseExpirationPolicy = value;
				OnPropertyChanged("LicenseExpirationPolicy");
			}
		}
		[JsonProperty]
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
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
		[JsonProperty]
		public IList<KeyValue> LicenseParams
		{
			get { return _LicenseParams; }
			set 
			{ 
				_LicenseParams = value;
				OnPropertyChanged("LicenseParams");
			}
		}
		#endregion

		#region CTor
		public DrmPolicy()
		{
		}

		public DrmPolicy(JToken node) : base(node)
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
			if(node["systemName"] != null)
			{
				this._SystemName = node["systemName"].Value<string>();
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
				this._Status = (DrmPolicyStatus)ParseEnum(typeof(DrmPolicyStatus), node["status"].Value<string>());
			}
			if(node["scenario"] != null)
			{
				this._Scenario = (DrmLicenseScenario)StringEnum.Parse(typeof(DrmLicenseScenario), node["scenario"].Value<string>());
			}
			if(node["licenseType"] != null)
			{
				this._LicenseType = (DrmLicenseType)StringEnum.Parse(typeof(DrmLicenseType), node["licenseType"].Value<string>());
			}
			if(node["licenseExpirationPolicy"] != null)
			{
				this._LicenseExpirationPolicy = (DrmLicenseExpirationPolicy)ParseEnum(typeof(DrmLicenseExpirationPolicy), node["licenseExpirationPolicy"].Value<string>());
			}
			if(node["duration"] != null)
			{
				this._Duration = ParseInt(node["duration"].Value<string>());
			}
			if(node["createdAt"] != null)
			{
				this._CreatedAt = ParseInt(node["createdAt"].Value<string>());
			}
			if(node["updatedAt"] != null)
			{
				this._UpdatedAt = ParseInt(node["updatedAt"].Value<string>());
			}
			if(node["licenseParams"] != null)
			{
				this._LicenseParams = new List<KeyValue>();
				foreach(var arrayNode in node["licenseParams"].Children())
				{
					this._LicenseParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDrmPolicy");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("partnerId", this._PartnerId);
			kparams.AddIfNotNull("name", this._Name);
			kparams.AddIfNotNull("systemName", this._SystemName);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("provider", this._Provider);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("scenario", this._Scenario);
			kparams.AddIfNotNull("licenseType", this._LicenseType);
			kparams.AddIfNotNull("licenseExpirationPolicy", this._LicenseExpirationPolicy);
			kparams.AddIfNotNull("duration", this._Duration);
			kparams.AddIfNotNull("createdAt", this._CreatedAt);
			kparams.AddIfNotNull("updatedAt", this._UpdatedAt);
			kparams.AddIfNotNull("licenseParams", this._LicenseParams);
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
				case SYSTEM_NAME:
					return "SystemName";
				case DESCRIPTION:
					return "Description";
				case PROVIDER:
					return "Provider";
				case STATUS:
					return "Status";
				case SCENARIO:
					return "Scenario";
				case LICENSE_TYPE:
					return "LicenseType";
				case LICENSE_EXPIRATION_POLICY:
					return "LicenseExpirationPolicy";
				case DURATION:
					return "Duration";
				case CREATED_AT:
					return "CreatedAt";
				case UPDATED_AT:
					return "UpdatedAt";
				case LICENSE_PARAMS:
					return "LicenseParams";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

