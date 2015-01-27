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
	public class KalturaPlayReadyPolicy : KalturaDrmPolicy
	{
		#region Private Fields
		private int _GracePeriod = Int32.MinValue;
		private KalturaPlayReadyLicenseRemovalPolicy _LicenseRemovalPolicy = (KalturaPlayReadyLicenseRemovalPolicy)Int32.MinValue;
		private int _LicenseRemovalDuration = Int32.MinValue;
		private KalturaPlayReadyMinimumLicenseSecurityLevel _MinSecurityLevel = (KalturaPlayReadyMinimumLicenseSecurityLevel)Int32.MinValue;
		private IList<KalturaPlayReadyRight> _Rights;
		#endregion

		#region Properties
		public int GracePeriod
		{
			get { return _GracePeriod; }
			set 
			{ 
				_GracePeriod = value;
				OnPropertyChanged("GracePeriod");
			}
		}
		public KalturaPlayReadyLicenseRemovalPolicy LicenseRemovalPolicy
		{
			get { return _LicenseRemovalPolicy; }
			set 
			{ 
				_LicenseRemovalPolicy = value;
				OnPropertyChanged("LicenseRemovalPolicy");
			}
		}
		public int LicenseRemovalDuration
		{
			get { return _LicenseRemovalDuration; }
			set 
			{ 
				_LicenseRemovalDuration = value;
				OnPropertyChanged("LicenseRemovalDuration");
			}
		}
		public KalturaPlayReadyMinimumLicenseSecurityLevel MinSecurityLevel
		{
			get { return _MinSecurityLevel; }
			set 
			{ 
				_MinSecurityLevel = value;
				OnPropertyChanged("MinSecurityLevel");
			}
		}
		public IList<KalturaPlayReadyRight> Rights
		{
			get { return _Rights; }
			set 
			{ 
				_Rights = value;
				OnPropertyChanged("Rights");
			}
		}
		#endregion

		#region CTor
		public KalturaPlayReadyPolicy()
		{
		}

		public KalturaPlayReadyPolicy(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "gracePeriod":
						this.GracePeriod = ParseInt(txt);
						continue;
					case "licenseRemovalPolicy":
						this.LicenseRemovalPolicy = (KalturaPlayReadyLicenseRemovalPolicy)ParseEnum(typeof(KalturaPlayReadyLicenseRemovalPolicy), txt);
						continue;
					case "licenseRemovalDuration":
						this.LicenseRemovalDuration = ParseInt(txt);
						continue;
					case "minSecurityLevel":
						this.MinSecurityLevel = (KalturaPlayReadyMinimumLicenseSecurityLevel)ParseEnum(typeof(KalturaPlayReadyMinimumLicenseSecurityLevel), txt);
						continue;
					case "rights":
						this.Rights = new List<KalturaPlayReadyRight>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Rights.Add((KalturaPlayReadyRight)KalturaObjectFactory.Create(arrayNode, "KalturaPlayReadyRight"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPlayReadyPolicy");
			kparams.AddIntIfNotNull("gracePeriod", this.GracePeriod);
			kparams.AddEnumIfNotNull("licenseRemovalPolicy", this.LicenseRemovalPolicy);
			kparams.AddIntIfNotNull("licenseRemovalDuration", this.LicenseRemovalDuration);
			kparams.AddEnumIfNotNull("minSecurityLevel", this.MinSecurityLevel);
			if (this.Rights != null)
			{
				if (this.Rights.Count == 0)
				{
					kparams.Add("rights:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaPlayReadyRight item in this.Rights)
					{
						kparams.Add("rights:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

