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
// Copyright (C) 2006-2016  Kaltura Inc.
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
	public class KalturaIntegrationJobData : KalturaJobData
	{
		#region Private Fields
		private string _CallbackNotificationUrl = null;
		private KalturaIntegrationProviderType _ProviderType = null;
		private KalturaIntegrationJobProviderData _ProviderData;
		private KalturaIntegrationTriggerType _TriggerType = null;
		private KalturaIntegrationJobTriggerData _TriggerData;
		#endregion

		#region Properties
		public string CallbackNotificationUrl
		{
			get { return _CallbackNotificationUrl; }
		}
		public KalturaIntegrationProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		public KalturaIntegrationJobProviderData ProviderData
		{
			get { return _ProviderData; }
			set 
			{ 
				_ProviderData = value;
				OnPropertyChanged("ProviderData");
			}
		}
		public KalturaIntegrationTriggerType TriggerType
		{
			get { return _TriggerType; }
			set 
			{ 
				_TriggerType = value;
				OnPropertyChanged("TriggerType");
			}
		}
		public KalturaIntegrationJobTriggerData TriggerData
		{
			get { return _TriggerData; }
			set 
			{ 
				_TriggerData = value;
				OnPropertyChanged("TriggerData");
			}
		}
		#endregion

		#region CTor
		public KalturaIntegrationJobData()
		{
		}

		public KalturaIntegrationJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "callbackNotificationUrl":
						this._CallbackNotificationUrl = txt;
						continue;
					case "providerType":
						this._ProviderType = (KalturaIntegrationProviderType)KalturaStringEnum.Parse(typeof(KalturaIntegrationProviderType), txt);
						continue;
					case "providerData":
						this._ProviderData = (KalturaIntegrationJobProviderData)KalturaObjectFactory.Create(propertyNode, "KalturaIntegrationJobProviderData");
						continue;
					case "triggerType":
						this._TriggerType = (KalturaIntegrationTriggerType)KalturaStringEnum.Parse(typeof(KalturaIntegrationTriggerType), txt);
						continue;
					case "triggerData":
						this._TriggerData = (KalturaIntegrationJobTriggerData)KalturaObjectFactory.Create(propertyNode, "KalturaIntegrationJobTriggerData");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaIntegrationJobData");
			kparams.AddIfNotNull("callbackNotificationUrl", this.CallbackNotificationUrl);
			kparams.AddIfNotNull("providerType", this.ProviderType);
			kparams.AddIfNotNull("providerData", this.ProviderData);
			kparams.AddIfNotNull("triggerType", this.TriggerType);
			kparams.AddIfNotNull("triggerData", this.TriggerData);
			return kparams;
		}
		#endregion
	}
}

