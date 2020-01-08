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
// Copyright (C) 2006-2020  Kaltura Inc.
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
		[JsonProperty]
		public bool? IsSiteRestricted
		{
			get { return _IsSiteRestricted; }
			set 
			{ 
				_IsSiteRestricted = value;
				OnPropertyChanged("IsSiteRestricted");
			}
		}
		[JsonProperty]
		public bool? IsCountryRestricted
		{
			get { return _IsCountryRestricted; }
			set 
			{ 
				_IsCountryRestricted = value;
				OnPropertyChanged("IsCountryRestricted");
			}
		}
		[JsonProperty]
		public bool? IsSessionRestricted
		{
			get { return _IsSessionRestricted; }
			set 
			{ 
				_IsSessionRestricted = value;
				OnPropertyChanged("IsSessionRestricted");
			}
		}
		[JsonProperty]
		public bool? IsIpAddressRestricted
		{
			get { return _IsIpAddressRestricted; }
			set 
			{ 
				_IsIpAddressRestricted = value;
				OnPropertyChanged("IsIpAddressRestricted");
			}
		}
		[JsonProperty]
		public bool? IsUserAgentRestricted
		{
			get { return _IsUserAgentRestricted; }
			set 
			{ 
				_IsUserAgentRestricted = value;
				OnPropertyChanged("IsUserAgentRestricted");
			}
		}
		[JsonProperty]
		public int PreviewLength
		{
			get { return _PreviewLength; }
			set 
			{ 
				_PreviewLength = value;
				OnPropertyChanged("PreviewLength");
			}
		}
		[JsonProperty]
		public bool? IsScheduledNow
		{
			get { return _IsScheduledNow; }
			set 
			{ 
				_IsScheduledNow = value;
				OnPropertyChanged("IsScheduledNow");
			}
		}
		[JsonProperty]
		public bool? IsAdmin
		{
			get { return _IsAdmin; }
			set 
			{ 
				_IsAdmin = value;
				OnPropertyChanged("IsAdmin");
			}
		}
		[JsonProperty]
		public string StreamerType
		{
			get { return _StreamerType; }
			set 
			{ 
				_StreamerType = value;
				OnPropertyChanged("StreamerType");
			}
		}
		[JsonProperty]
		public string MediaProtocol
		{
			get { return _MediaProtocol; }
			set 
			{ 
				_MediaProtocol = value;
				OnPropertyChanged("MediaProtocol");
			}
		}
		[JsonProperty]
		public string StorageProfilesXML
		{
			get { return _StorageProfilesXML; }
			set 
			{ 
				_StorageProfilesXML = value;
				OnPropertyChanged("StorageProfilesXML");
			}
		}
		[JsonProperty]
		public IList<String> AccessControlMessages
		{
			get { return _AccessControlMessages; }
			set 
			{ 
				_AccessControlMessages = value;
				OnPropertyChanged("AccessControlMessages");
			}
		}
		[JsonProperty]
		public IList<RuleAction> AccessControlActions
		{
			get { return _AccessControlActions; }
			set 
			{ 
				_AccessControlActions = value;
				OnPropertyChanged("AccessControlActions");
			}
		}
		[JsonProperty]
		public IList<FlavorAsset> FlavorAssets
		{
			get { return _FlavorAssets; }
			set 
			{ 
				_FlavorAssets = value;
				OnPropertyChanged("FlavorAssets");
			}
		}
		[JsonProperty]
		public int MsDuration
		{
			get { return _MsDuration; }
			set 
			{ 
				_MsDuration = value;
				OnPropertyChanged("MsDuration");
			}
		}
		[JsonProperty]
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

		public EntryContextDataResult(JToken node) : base(node)
		{
			if(node["isSiteRestricted"] != null)
			{
				this._IsSiteRestricted = ParseBool(node["isSiteRestricted"].Value<string>());
			}
			if(node["isCountryRestricted"] != null)
			{
				this._IsCountryRestricted = ParseBool(node["isCountryRestricted"].Value<string>());
			}
			if(node["isSessionRestricted"] != null)
			{
				this._IsSessionRestricted = ParseBool(node["isSessionRestricted"].Value<string>());
			}
			if(node["isIpAddressRestricted"] != null)
			{
				this._IsIpAddressRestricted = ParseBool(node["isIpAddressRestricted"].Value<string>());
			}
			if(node["isUserAgentRestricted"] != null)
			{
				this._IsUserAgentRestricted = ParseBool(node["isUserAgentRestricted"].Value<string>());
			}
			if(node["previewLength"] != null)
			{
				this._PreviewLength = ParseInt(node["previewLength"].Value<string>());
			}
			if(node["isScheduledNow"] != null)
			{
				this._IsScheduledNow = ParseBool(node["isScheduledNow"].Value<string>());
			}
			if(node["isAdmin"] != null)
			{
				this._IsAdmin = ParseBool(node["isAdmin"].Value<string>());
			}
			if(node["streamerType"] != null)
			{
				this._StreamerType = node["streamerType"].Value<string>();
			}
			if(node["mediaProtocol"] != null)
			{
				this._MediaProtocol = node["mediaProtocol"].Value<string>();
			}
			if(node["storageProfilesXML"] != null)
			{
				this._StorageProfilesXML = node["storageProfilesXML"].Value<string>();
			}
			if(node["accessControlMessages"] != null)
			{
				this._AccessControlMessages = new List<String>();
				foreach(var arrayNode in node["accessControlMessages"].Children())
				{
					this._AccessControlMessages.Add(ObjectFactory.Create<String>(arrayNode));
				}
			}
			if(node["accessControlActions"] != null)
			{
				this._AccessControlActions = new List<RuleAction>();
				foreach(var arrayNode in node["accessControlActions"].Children())
				{
					this._AccessControlActions.Add(ObjectFactory.Create<RuleAction>(arrayNode));
				}
			}
			if(node["flavorAssets"] != null)
			{
				this._FlavorAssets = new List<FlavorAsset>();
				foreach(var arrayNode in node["flavorAssets"].Children())
				{
					this._FlavorAssets.Add(ObjectFactory.Create<FlavorAsset>(arrayNode));
				}
			}
			if(node["msDuration"] != null)
			{
				this._MsDuration = ParseInt(node["msDuration"].Value<string>());
			}
			if(node["pluginData"] != null)
			{
				{
					string key;
					this._PluginData = new Dictionary<string, PluginData>();
					foreach(var arrayNode in node["pluginData"].Children<JProperty>())
					{
						key = arrayNode.Name;
						this._PluginData[key] = ObjectFactory.Create<PluginData>(arrayNode.Value);
					}
				}
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

