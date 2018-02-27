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
	public class DrmPolicyBaseFilter : Filter
	{
		#region Constants
		public const string PARTNER_ID_EQUAL = "partnerIdEqual";
		public const string PARTNER_ID_IN = "partnerIdIn";
		public const string NAME_LIKE = "nameLike";
		public const string SYSTEM_NAME_LIKE = "systemNameLike";
		public const string PROVIDER_EQUAL = "providerEqual";
		public const string PROVIDER_IN = "providerIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string SCENARIO_EQUAL = "scenarioEqual";
		public const string SCENARIO_IN = "scenarioIn";
		#endregion

		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _NameLike = null;
		private string _SystemNameLike = null;
		private DrmProviderType _ProviderEqual = null;
		private string _ProviderIn = null;
		private DrmPolicyStatus _StatusEqual = (DrmPolicyStatus)Int32.MinValue;
		private string _StatusIn = null;
		private DrmLicenseScenario _ScenarioEqual = null;
		private string _ScenarioIn = null;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string NameLike
		{
			get { return _NameLike; }
			set 
			{ 
				_NameLike = value;
				OnPropertyChanged("NameLike");
			}
		}
		public string SystemNameLike
		{
			get { return _SystemNameLike; }
			set 
			{ 
				_SystemNameLike = value;
				OnPropertyChanged("SystemNameLike");
			}
		}
		public DrmProviderType ProviderEqual
		{
			get { return _ProviderEqual; }
			set 
			{ 
				_ProviderEqual = value;
				OnPropertyChanged("ProviderEqual");
			}
		}
		public string ProviderIn
		{
			get { return _ProviderIn; }
			set 
			{ 
				_ProviderIn = value;
				OnPropertyChanged("ProviderIn");
			}
		}
		public DrmPolicyStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public DrmLicenseScenario ScenarioEqual
		{
			get { return _ScenarioEqual; }
			set 
			{ 
				_ScenarioEqual = value;
				OnPropertyChanged("ScenarioEqual");
			}
		}
		public string ScenarioIn
		{
			get { return _ScenarioIn; }
			set 
			{ 
				_ScenarioIn = value;
				OnPropertyChanged("ScenarioIn");
			}
		}
		#endregion

		#region CTor
		public DrmPolicyBaseFilter()
		{
		}

		public DrmPolicyBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerIdIn":
						this._PartnerIdIn = propertyNode.InnerText;
						continue;
					case "nameLike":
						this._NameLike = propertyNode.InnerText;
						continue;
					case "systemNameLike":
						this._SystemNameLike = propertyNode.InnerText;
						continue;
					case "providerEqual":
						this._ProviderEqual = (DrmProviderType)StringEnum.Parse(typeof(DrmProviderType), propertyNode.InnerText);
						continue;
					case "providerIn":
						this._ProviderIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (DrmPolicyStatus)ParseEnum(typeof(DrmPolicyStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "scenarioEqual":
						this._ScenarioEqual = (DrmLicenseScenario)StringEnum.Parse(typeof(DrmLicenseScenario), propertyNode.InnerText);
						continue;
					case "scenarioIn":
						this._ScenarioIn = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaDrmPolicyBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this._PartnerIdEqual);
			kparams.AddIfNotNull("partnerIdIn", this._PartnerIdIn);
			kparams.AddIfNotNull("nameLike", this._NameLike);
			kparams.AddIfNotNull("systemNameLike", this._SystemNameLike);
			kparams.AddIfNotNull("providerEqual", this._ProviderEqual);
			kparams.AddIfNotNull("providerIn", this._ProviderIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("scenarioEqual", this._ScenarioEqual);
			kparams.AddIfNotNull("scenarioIn", this._ScenarioIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_ID_EQUAL:
					return "PartnerIdEqual";
				case PARTNER_ID_IN:
					return "PartnerIdIn";
				case NAME_LIKE:
					return "NameLike";
				case SYSTEM_NAME_LIKE:
					return "SystemNameLike";
				case PROVIDER_EQUAL:
					return "ProviderEqual";
				case PROVIDER_IN:
					return "ProviderIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case SCENARIO_EQUAL:
					return "ScenarioEqual";
				case SCENARIO_IN:
					return "ScenarioIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

