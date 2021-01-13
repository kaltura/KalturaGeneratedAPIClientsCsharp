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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class IntegrationJobData : JobData
	{
		#region Constants
		public const string CALLBACK_NOTIFICATION_URL = "callbackNotificationUrl";
		public const string PROVIDER_TYPE = "providerType";
		public const string PROVIDER_DATA = "providerData";
		public const string TRIGGER_TYPE = "triggerType";
		public const string TRIGGER_DATA = "triggerData";
		#endregion

		#region Private Fields
		private string _CallbackNotificationUrl = null;
		private IntegrationProviderType _ProviderType = null;
		private IntegrationJobProviderData _ProviderData;
		private IntegrationTriggerType _TriggerType = null;
		private IntegrationJobTriggerData _TriggerData;
		#endregion

		#region Properties
		[JsonProperty]
		public string CallbackNotificationUrl
		{
			get { return _CallbackNotificationUrl; }
			private set 
			{ 
				_CallbackNotificationUrl = value;
				OnPropertyChanged("CallbackNotificationUrl");
			}
		}
		[JsonProperty]
		public IntegrationProviderType ProviderType
		{
			get { return _ProviderType; }
			set 
			{ 
				_ProviderType = value;
				OnPropertyChanged("ProviderType");
			}
		}
		[JsonProperty]
		public IntegrationJobProviderData ProviderData
		{
			get { return _ProviderData; }
			set 
			{ 
				_ProviderData = value;
				OnPropertyChanged("ProviderData");
			}
		}
		[JsonProperty]
		public IntegrationTriggerType TriggerType
		{
			get { return _TriggerType; }
			set 
			{ 
				_TriggerType = value;
				OnPropertyChanged("TriggerType");
			}
		}
		[JsonProperty]
		public IntegrationJobTriggerData TriggerData
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
		public IntegrationJobData()
		{
		}

		public IntegrationJobData(JToken node) : base(node)
		{
			if(node["callbackNotificationUrl"] != null)
			{
				this._CallbackNotificationUrl = node["callbackNotificationUrl"].Value<string>();
			}
			if(node["providerType"] != null)
			{
				this._ProviderType = (IntegrationProviderType)StringEnum.Parse(typeof(IntegrationProviderType), node["providerType"].Value<string>());
			}
			if(node["providerData"] != null)
			{
				this._ProviderData = ObjectFactory.Create<IntegrationJobProviderData>(node["providerData"]);
			}
			if(node["triggerType"] != null)
			{
				this._TriggerType = (IntegrationTriggerType)StringEnum.Parse(typeof(IntegrationTriggerType), node["triggerType"].Value<string>());
			}
			if(node["triggerData"] != null)
			{
				this._TriggerData = ObjectFactory.Create<IntegrationJobTriggerData>(node["triggerData"]);
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaIntegrationJobData");
			kparams.AddIfNotNull("callbackNotificationUrl", this._CallbackNotificationUrl);
			kparams.AddIfNotNull("providerType", this._ProviderType);
			kparams.AddIfNotNull("providerData", this._ProviderData);
			kparams.AddIfNotNull("triggerType", this._TriggerType);
			kparams.AddIfNotNull("triggerData", this._TriggerData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CALLBACK_NOTIFICATION_URL:
					return "CallbackNotificationUrl";
				case PROVIDER_TYPE:
					return "ProviderType";
				case PROVIDER_DATA:
					return "ProviderData";
				case TRIGGER_TYPE:
					return "TriggerType";
				case TRIGGER_DATA:
					return "TriggerData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

