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
		public int Id
		{
			get { return _Id; }
		}
		public int PartnerId
		{
			get { return _PartnerId; }
			set 
			{ 
				_PartnerId = value;
				OnPropertyChanged("PartnerId");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		public string SystemName
		{
			get { return _SystemName; }
			set 
			{ 
				_SystemName = value;
				OnPropertyChanged("SystemName");
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
		public DrmProviderType Provider
		{
			get { return _Provider; }
			set 
			{ 
				_Provider = value;
				OnPropertyChanged("Provider");
			}
		}
		public DrmPolicyStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public DrmLicenseScenario Scenario
		{
			get { return _Scenario; }
			set 
			{ 
				_Scenario = value;
				OnPropertyChanged("Scenario");
			}
		}
		public DrmLicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		public DrmLicenseExpirationPolicy LicenseExpirationPolicy
		{
			get { return _LicenseExpirationPolicy; }
			set 
			{ 
				_LicenseExpirationPolicy = value;
				OnPropertyChanged("LicenseExpirationPolicy");
			}
		}
		public int Duration
		{
			get { return _Duration; }
			set 
			{ 
				_Duration = value;
				OnPropertyChanged("Duration");
			}
		}
		public int CreatedAt
		{
			get { return _CreatedAt; }
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
		}
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

		public DrmPolicy(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerId":
						this._PartnerId = ParseInt(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
					case "systemName":
						this._SystemName = propertyNode.InnerText;
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "provider":
						this._Provider = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (DrmPolicyStatus)ParseEnum(typeof(DrmPolicyStatus), propertyNode.InnerText);
						continue;
					case "scenario":
						this._Scenario = (DrmLicenseScenario)StringEnum.Parse(typeof(DrmLicenseScenario), propertyNode.InnerText);
						continue;
					case "licenseType":
						this._LicenseType = (DrmLicenseType)StringEnum.Parse(typeof(DrmLicenseType), propertyNode.InnerText);
						continue;
					case "licenseExpirationPolicy":
						this._LicenseExpirationPolicy = (DrmLicenseExpirationPolicy)ParseEnum(typeof(DrmLicenseExpirationPolicy), propertyNode.InnerText);
						continue;
					case "duration":
						this._Duration = ParseInt(propertyNode.InnerText);
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "licenseParams":
						this._LicenseParams = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._LicenseParams.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
				}
			}
		}

		public DrmPolicy(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._SystemName = data.TryGetValueSafe<string>("systemName");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Provider = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), data.TryGetValueSafe<string>("provider"));
			    this._Status = (DrmPolicyStatus)ParseEnum(typeof(DrmPolicyStatus), data.TryGetValueSafe<int>("status"));
			    this._Scenario = (DrmLicenseScenario)StringEnum.Parse(typeof(DrmLicenseScenario), data.TryGetValueSafe<string>("scenario"));
			    this._LicenseType = (DrmLicenseType)StringEnum.Parse(typeof(DrmLicenseType), data.TryGetValueSafe<string>("licenseType"));
			    this._LicenseExpirationPolicy = (DrmLicenseExpirationPolicy)ParseEnum(typeof(DrmLicenseExpirationPolicy), data.TryGetValueSafe<int>("licenseExpirationPolicy"));
			    this._Duration = data.TryGetValueSafe<int>("duration");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._LicenseParams = new List<KeyValue>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("licenseParams", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._LicenseParams.Add(ObjectFactory.Create<KeyValue>((IDictionary<string,object>)dataDictionary));
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

