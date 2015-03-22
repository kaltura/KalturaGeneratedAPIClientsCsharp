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
	public class KalturaDrmPolicyBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _NameLike = null;
		private string _SystemNameLike = null;
		private KalturaDrmProviderType _ProviderEqual = null;
		private string _ProviderIn = null;
		private KalturaDrmPolicyStatus _StatusEqual = (KalturaDrmPolicyStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaDrmLicenseScenario _ScenarioEqual = null;
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
		public KalturaDrmProviderType ProviderEqual
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
		public KalturaDrmPolicyStatus StatusEqual
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
		public KalturaDrmLicenseScenario ScenarioEqual
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
		public KalturaDrmPolicyBaseFilter()
		{
		}

		public KalturaDrmPolicyBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "nameLike":
						this.NameLike = txt;
						continue;
					case "systemNameLike":
						this.SystemNameLike = txt;
						continue;
					case "providerEqual":
						this.ProviderEqual = (KalturaDrmProviderType)KalturaStringEnum.Parse(typeof(KalturaDrmProviderType), txt);
						continue;
					case "providerIn":
						this.ProviderIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaDrmPolicyStatus)ParseEnum(typeof(KalturaDrmPolicyStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "scenarioEqual":
						this.ScenarioEqual = (KalturaDrmLicenseScenario)KalturaStringEnum.Parse(typeof(KalturaDrmLicenseScenario), txt);
						continue;
					case "scenarioIn":
						this.ScenarioIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaDrmPolicyBaseFilter");
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("nameLike", this.NameLike);
			kparams.AddStringIfNotNull("systemNameLike", this.SystemNameLike);
			kparams.AddStringEnumIfNotNull("providerEqual", this.ProviderEqual);
			kparams.AddStringIfNotNull("providerIn", this.ProviderIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringEnumIfNotNull("scenarioEqual", this.ScenarioEqual);
			kparams.AddStringIfNotNull("scenarioIn", this.ScenarioIn);
			return kparams;
		}
		#endregion
	}
}

