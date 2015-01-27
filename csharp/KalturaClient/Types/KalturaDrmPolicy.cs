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
// Copyright (C) 2006-2011  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaDrmPolicy : KalturaObjectBase
	{
		#region Private Fields
		private int _Id = Int32.MinValue;
		private int _PartnerId = Int32.MinValue;
		private string _Name = null;
		private string _SystemName = null;
		private string _Description = null;
		private KalturaDrmProviderType _Provider = null;
		private KalturaDrmPolicyStatus _Status = (KalturaDrmPolicyStatus)Int32.MinValue;
		private KalturaDrmLicenseScenario _Scenario = null;
		private KalturaDrmLicenseType _LicenseType = null;
		private KalturaDrmLicenseExpirationPolicy _LicenseExpirationPolicy = (KalturaDrmLicenseExpirationPolicy)Int32.MinValue;
		private int _Duration = Int32.MinValue;
		private int _CreatedAt = Int32.MinValue;
		private int _UpdatedAt = Int32.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
			set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
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
		public KalturaDrmProviderType Provider
		{
			get { return _Provider; }
			set 
			{ 
				_Provider = value;
				OnPropertyChanged("Provider");
			}
		}
		public KalturaDrmPolicyStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		public KalturaDrmLicenseScenario Scenario
		{
			get { return _Scenario; }
			set 
			{ 
				_Scenario = value;
				OnPropertyChanged("Scenario");
			}
		}
		public KalturaDrmLicenseType LicenseType
		{
			get { return _LicenseType; }
			set 
			{ 
				_LicenseType = value;
				OnPropertyChanged("LicenseType");
			}
		}
		public KalturaDrmLicenseExpirationPolicy LicenseExpirationPolicy
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
			set 
			{ 
				_CreatedAt = value;
				OnPropertyChanged("CreatedAt");
			}
		}
		public int UpdatedAt
		{
			get { return _UpdatedAt; }
			set 
			{ 
				_UpdatedAt = value;
				OnPropertyChanged("UpdatedAt");
			}
		}
		#endregion

		#region CTor
		public KalturaDrmPolicy()
		{
		}

		public KalturaDrmPolicy(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "id":
						this.Id = ParseInt(txt);
						continue;
					case "partnerId":
						this.PartnerId = ParseInt(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
					case "systemName":
						this.SystemName = txt;
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "provider":
						this.Provider = (KalturaDrmProviderType)KalturaStringEnum.Parse(typeof(KalturaDrmProviderType), txt);
						continue;
					case "status":
						this.Status = (KalturaDrmPolicyStatus)ParseEnum(typeof(KalturaDrmPolicyStatus), txt);
						continue;
					case "scenario":
						this.Scenario = (KalturaDrmLicenseScenario)KalturaStringEnum.Parse(typeof(KalturaDrmLicenseScenario), txt);
						continue;
					case "licenseType":
						this.LicenseType = (KalturaDrmLicenseType)KalturaStringEnum.Parse(typeof(KalturaDrmLicenseType), txt);
						continue;
					case "licenseExpirationPolicy":
						this.LicenseExpirationPolicy = (KalturaDrmLicenseExpirationPolicy)ParseEnum(typeof(KalturaDrmLicenseExpirationPolicy), txt);
						continue;
					case "duration":
						this.Duration = ParseInt(txt);
						continue;
					case "createdAt":
						this.CreatedAt = ParseInt(txt);
						continue;
					case "updatedAt":
						this.UpdatedAt = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDrmPolicy");
			kparams.AddIntIfNotNull("id", this.Id);
			kparams.AddIntIfNotNull("partnerId", this.PartnerId);
			kparams.AddStringIfNotNull("name", this.Name);
			kparams.AddStringIfNotNull("systemName", this.SystemName);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddStringEnumIfNotNull("provider", this.Provider);
			kparams.AddEnumIfNotNull("status", this.Status);
			kparams.AddStringEnumIfNotNull("scenario", this.Scenario);
			kparams.AddStringEnumIfNotNull("licenseType", this.LicenseType);
			kparams.AddEnumIfNotNull("licenseExpirationPolicy", this.LicenseExpirationPolicy);
			kparams.AddIntIfNotNull("duration", this.Duration);
			kparams.AddIntIfNotNull("createdAt", this.CreatedAt);
			kparams.AddIntIfNotNull("updatedAt", this.UpdatedAt);
			return kparams;
		}
		#endregion
	}
}

