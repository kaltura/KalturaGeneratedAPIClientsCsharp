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
		public DrmProfileStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public string LicenseServerUrl
		{
			get { return _LicenseServerUrl; }
			set 
			{ 
				_LicenseServerUrl = value;
				OnPropertyChanged("LicenseServerUrl");
			}
		}
		public string DefaultPolicy
		{
			get { return _DefaultPolicy; }
			set 
			{ 
				_DefaultPolicy = value;
				OnPropertyChanged("DefaultPolicy");
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

		public DrmProfile(XmlElement node) : base(node)
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
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "provider":
						this._Provider = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (DrmProfileStatus)ParseEnum(typeof(DrmProfileStatus), propertyNode.InnerText);
						continue;
					case "licenseServerUrl":
						this._LicenseServerUrl = propertyNode.InnerText;
						continue;
					case "defaultPolicy":
						this._DefaultPolicy = propertyNode.InnerText;
						continue;
					case "createdAt":
						this._CreatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "updatedAt":
						this._UpdatedAt = ParseInt(propertyNode.InnerText);
						continue;
					case "signingKey":
						this._SigningKey = propertyNode.InnerText;
						continue;
				}
			}
		}

		public DrmProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Id = data.TryGetValueSafe<int>("id");
			    this._PartnerId = data.TryGetValueSafe<int>("partnerId");
			    this._Name = data.TryGetValueSafe<string>("name");
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Provider = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), data.TryGetValueSafe<string>("provider"));
			    this._Status = (DrmProfileStatus)ParseEnum(typeof(DrmProfileStatus), data.TryGetValueSafe<int>("status"));
			    this._LicenseServerUrl = data.TryGetValueSafe<string>("licenseServerUrl");
			    this._DefaultPolicy = data.TryGetValueSafe<string>("defaultPolicy");
			    this._CreatedAt = data.TryGetValueSafe<int>("createdAt");
			    this._UpdatedAt = data.TryGetValueSafe<int>("updatedAt");
			    this._SigningKey = data.TryGetValueSafe<string>("signingKey");
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

