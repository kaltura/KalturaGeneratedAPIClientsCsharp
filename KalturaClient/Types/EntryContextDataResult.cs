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
	public class EntryContextDataResult : ContextDataResult
	{
		#region Constants
		public const string IS_SITE_RESTRICTED = "isSiteRestricted";
		public const string IS_COUNTRY_RESTRICTED = "isCountryRestricted";
		public const string IS_SESSION_RESTRICTED = "isSessionRestricted";
		public const string IS_IP_ADDRESS_RESTRICTED = "isIpAddressRestricted";
		public const string IS_USER_AGENT_RESTRICTED = "isUserAgentRestricted";
		public const string PREVIEW_LENGTH = "previewLength";
		public const string IS_SCHEDULED_NOW = "isScheduledNow";
		public const string IS_ADMIN = "isAdmin";
		public const string STREAMER_TYPE = "streamerType";
		public const string MEDIA_PROTOCOL = "mediaProtocol";
		public const string STORAGE_PROFILES_XML = "storageProfilesXML";
		public const string ACCESS_CONTROL_MESSAGES = "accessControlMessages";
		public const string ACCESS_CONTROL_ACTIONS = "accessControlActions";
		public const string FLAVOR_ASSETS = "flavorAssets";
		public const string MS_DURATION = "msDuration";
		public const string PLUGIN_DATA = "pluginData";
		#endregion

		#region Private Fields
		private bool? _IsSiteRestricted = null;
		private bool? _IsCountryRestricted = null;
		private bool? _IsSessionRestricted = null;
		private bool? _IsIpAddressRestricted = null;
		private bool? _IsUserAgentRestricted = null;
		private int _PreviewLength = Int32.MinValue;
		private bool? _IsScheduledNow = null;
		private bool? _IsAdmin = null;
		private string _StreamerType = null;
		private string _MediaProtocol = null;
		private string _StorageProfilesXML = null;
		private IList<String> _AccessControlMessages;
		private IList<RuleAction> _AccessControlActions;
		private IList<FlavorAsset> _FlavorAssets;
		private int _MsDuration = Int32.MinValue;
		private IDictionary<string, PluginData> _PluginData;
		#endregion

		#region Properties
		public bool? IsSiteRestricted
		{
			get { return _IsSiteRestricted; }
			set 
			{ 
				_IsSiteRestricted = value;
				OnPropertyChanged("IsSiteRestricted");
			}
		}
		public bool? IsCountryRestricted
		{
			get { return _IsCountryRestricted; }
			set 
			{ 
				_IsCountryRestricted = value;
				OnPropertyChanged("IsCountryRestricted");
			}
		}
		public bool? IsSessionRestricted
		{
			get { return _IsSessionRestricted; }
			set 
			{ 
				_IsSessionRestricted = value;
				OnPropertyChanged("IsSessionRestricted");
			}
		}
		public bool? IsIpAddressRestricted
		{
			get { return _IsIpAddressRestricted; }
			set 
			{ 
				_IsIpAddressRestricted = value;
				OnPropertyChanged("IsIpAddressRestricted");
			}
		}
		public bool? IsUserAgentRestricted
		{
			get { return _IsUserAgentRestricted; }
			set 
			{ 
				_IsUserAgentRestricted = value;
				OnPropertyChanged("IsUserAgentRestricted");
			}
		}
		public int PreviewLength
		{
			get { return _PreviewLength; }
			set 
			{ 
				_PreviewLength = value;
				OnPropertyChanged("PreviewLength");
			}
		}
		public bool? IsScheduledNow
		{
			get { return _IsScheduledNow; }
			set 
			{ 
				_IsScheduledNow = value;
				OnPropertyChanged("IsScheduledNow");
			}
		}
		public bool? IsAdmin
		{
			get { return _IsAdmin; }
			set 
			{ 
				_IsAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		public string MediaProtocol
		{
			get { return _MediaProtocol; }
			set 
			{ 
				_MediaProtocol = value;
				OnPropertyChanged("MediaProtocol");
			}
		}
		public string StorageProfilesXML
		{
			get { return _StorageProfilesXML; }
			set 
			{ 
				_StorageProfilesXML = value;
				OnPropertyChanged("StorageProfilesXML");
			}
		}
		public IList<String> AccessControlMessages
		{
			get { return _AccessControlMessages; }
			set 
			{ 
				_AccessControlMessages = value;
				OnPropertyChanged("AccessControlMessages");
			}
		}
		public IList<RuleAction> AccessControlActions
		{
			get { return _AccessControlActions; }
			set 
			{ 
				_AccessControlActions = value;
				OnPropertyChanged("AccessControlActions");
			}
		}
		public IList<FlavorAsset> FlavorAssets
		{
			get { return _FlavorAssets; }
			set 
			{ 
				_FlavorAssets = value;
				OnPropertyChanged("FlavorAssets");
			}
		}
		public int MsDuration
		{
			get { return _MsDuration; }
			set 
			{ 
				_MsDuration = value;
				OnPropertyChanged("MsDuration");
			}
		}
		public IDictionary<string, PluginData> PluginData
		{
			get { return _PluginData; }
			set 
			{ 
				_PluginData = value;
				OnPropertyChanged("PluginData");
			}
		}
		#endregion

		#region CTor
		public EntryContextDataResult()
		{
		}

		public EntryContextDataResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "isSiteRestricted":
						this._IsSiteRestricted = ParseBool(propertyNode.InnerText);
						continue;
					case "isCountryRestricted":
						this._IsCountryRestricted = ParseBool(propertyNode.InnerText);
						continue;
					case "isSessionRestricted":
						this._IsSessionRestricted = ParseBool(propertyNode.InnerText);
						continue;
					case "isIpAddressRestricted":
						this._IsIpAddressRestricted = ParseBool(propertyNode.InnerText);
						continue;
					case "isUserAgentRestricted":
						this._IsUserAgentRestricted = ParseBool(propertyNode.InnerText);
						continue;
					case "previewLength":
						this._PreviewLength = ParseInt(propertyNode.InnerText);
						continue;
					case "isScheduledNow":
						this._IsScheduledNow = ParseBool(propertyNode.InnerText);
						continue;
					case "isAdmin":
						this._IsAdmin = ParseBool(propertyNode.InnerText);
						continue;
					case "streamerType":
						this._StreamerType = propertyNode.InnerText;
						continue;
					case "mediaProtocol":
						this._MediaProtocol = propertyNode.InnerText;
						continue;
					case "storageProfilesXML":
						this._StorageProfilesXML = propertyNode.InnerText;
						continue;
					case "accessControlMessages":
						this._AccessControlMessages = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AccessControlMessages.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "accessControlActions":
						this._AccessControlActions = new List<RuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AccessControlActions.Add(ObjectFactory.Create<RuleAction>(arrayNode));
						}
						continue;
					case "flavorAssets":
						this._FlavorAssets = new List<FlavorAsset>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._FlavorAssets.Add(ObjectFactory.Create<FlavorAsset>(arrayNode));
						}
						continue;
					case "msDuration":
						this._MsDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "pluginData":
						{
							string key;
							this._PluginData = new Dictionary<string, PluginData>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this._PluginData[key] = ObjectFactory.Create<PluginData>(arrayNode);
							}
						}
						continue;
				}
			}
		}

		public EntryContextDataResult(IDictionary<string,object> data) : base(data)
		{
			    this._IsSiteRestricted = data.TryGetValueSafe<bool>("isSiteRestricted");
			    this._IsCountryRestricted = data.TryGetValueSafe<bool>("isCountryRestricted");
			    this._IsSessionRestricted = data.TryGetValueSafe<bool>("isSessionRestricted");
			    this._IsIpAddressRestricted = data.TryGetValueSafe<bool>("isIpAddressRestricted");
			    this._IsUserAgentRestricted = data.TryGetValueSafe<bool>("isUserAgentRestricted");
			    this._PreviewLength = data.TryGetValueSafe<int>("previewLength");
			    this._IsScheduledNow = data.TryGetValueSafe<bool>("isScheduledNow");
			    this._IsAdmin = data.TryGetValueSafe<bool>("isAdmin");
			    this._StreamerType = data.TryGetValueSafe<string>("streamerType");
			    this._MediaProtocol = data.TryGetValueSafe<string>("mediaProtocol");
			    this._StorageProfilesXML = data.TryGetValueSafe<string>("storageProfilesXML");
			    this._AccessControlMessages = new List<String>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("accessControlMessages", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._AccessControlMessages.Add(ObjectFactory.Create<String>((IDictionary<string,object>)dataDictionary));
			    }
			    this._AccessControlActions = new List<RuleAction>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("accessControlActions", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._AccessControlActions.Add(ObjectFactory.Create<RuleAction>((IDictionary<string,object>)dataDictionary));
			    }
			    this._FlavorAssets = new List<FlavorAsset>();
			    foreach(var dataDictionary in data.TryGetValueSafe<IEnumerable<object>>("flavorAssets", new List<object>()))
			    {
			        if (dataDictionary == null) { continue; }
			        this._FlavorAssets.Add(ObjectFactory.Create<FlavorAsset>((IDictionary<string,object>)dataDictionary));
			    }
			    this._MsDuration = data.TryGetValueSafe<int>("msDuration");
			    this._PluginData = new Dictionary<string, PluginData>();
			    foreach(var keyValuePair in data.TryGetValueSafe("pluginData", new Dictionary<string, object>()))
			    {
			        this._PluginData[keyValuePair.Key] = ObjectFactory.Create<PluginData>((IDictionary<string,object>)keyValuePair.Value);
				}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryContextDataResult");
			kparams.AddIfNotNull("isSiteRestricted", this._IsSiteRestricted);
			kparams.AddIfNotNull("isCountryRestricted", this._IsCountryRestricted);
			kparams.AddIfNotNull("isSessionRestricted", this._IsSessionRestricted);
			kparams.AddIfNotNull("isIpAddressRestricted", this._IsIpAddressRestricted);
			kparams.AddIfNotNull("isUserAgentRestricted", this._IsUserAgentRestricted);
			kparams.AddIfNotNull("previewLength", this._PreviewLength);
			kparams.AddIfNotNull("isScheduledNow", this._IsScheduledNow);
			kparams.AddIfNotNull("isAdmin", this._IsAdmin);
			kparams.AddIfNotNull("streamerType", this._StreamerType);
			kparams.AddIfNotNull("mediaProtocol", this._MediaProtocol);
			kparams.AddIfNotNull("storageProfilesXML", this._StorageProfilesXML);
			kparams.AddIfNotNull("accessControlMessages", this._AccessControlMessages);
			kparams.AddIfNotNull("accessControlActions", this._AccessControlActions);
			kparams.AddIfNotNull("flavorAssets", this._FlavorAssets);
			kparams.AddIfNotNull("msDuration", this._MsDuration);
			kparams.AddIfNotNull("pluginData", this._PluginData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case IS_SITE_RESTRICTED:
					return "IsSiteRestricted";
				case IS_COUNTRY_RESTRICTED:
					return "IsCountryRestricted";
				case IS_SESSION_RESTRICTED:
					return "IsSessionRestricted";
				case IS_IP_ADDRESS_RESTRICTED:
					return "IsIpAddressRestricted";
				case IS_USER_AGENT_RESTRICTED:
					return "IsUserAgentRestricted";
				case PREVIEW_LENGTH:
					return "PreviewLength";
				case IS_SCHEDULED_NOW:
					return "IsScheduledNow";
				case IS_ADMIN:
					return "IsAdmin";
				case STREAMER_TYPE:
					return "StreamerType";
				case MEDIA_PROTOCOL:
					return "MediaProtocol";
				case STORAGE_PROFILES_XML:
					return "StorageProfilesXML";
				case ACCESS_CONTROL_MESSAGES:
					return "AccessControlMessages";
				case ACCESS_CONTROL_ACTIONS:
					return "AccessControlActions";
				case FLAVOR_ASSETS:
					return "FlavorAssets";
				case MS_DURATION:
					return "MsDuration";
				case PLUGIN_DATA:
					return "PluginData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

