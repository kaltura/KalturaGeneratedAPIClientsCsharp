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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaEntryContextDataResult : KalturaContextDataResult
	{
		#region Private Fields
		private bool? _IsSiteRestricted = false;
		private bool? _IsCountryRestricted = false;
		private bool? _IsSessionRestricted = false;
		private bool? _IsIpAddressRestricted = false;
		private bool? _IsUserAgentRestricted = false;
		private int _PreviewLength = Int32.MinValue;
		private bool? _IsScheduledNow = false;
		private bool? _IsAdmin = false;
		private string _StreamerType = null;
		private string _MediaProtocol = null;
		private string _StorageProfilesXML = null;
		private IList<KalturaString> _AccessControlMessages;
		private IList<KalturaRuleAction> _AccessControlActions;
		private IList<KalturaFlavorAsset> _FlavorAssets;
		private IDictionary<string, KalturaPluginData> _PluginData;
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
		public IList<KalturaString> AccessControlMessages
		{
			get { return _AccessControlMessages; }
			set 
			{ 
				_AccessControlMessages = value;
				OnPropertyChanged("AccessControlMessages");
			}
		}
		public IList<KalturaRuleAction> AccessControlActions
		{
			get { return _AccessControlActions; }
			set 
			{ 
				_AccessControlActions = value;
				OnPropertyChanged("AccessControlActions");
			}
		}
		public IList<KalturaFlavorAsset> FlavorAssets
		{
			get { return _FlavorAssets; }
			set 
			{ 
				_FlavorAssets = value;
				OnPropertyChanged("FlavorAssets");
			}
		}
		public IDictionary<string, KalturaPluginData> PluginData
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
		public KalturaEntryContextDataResult()
		{
		}

		public KalturaEntryContextDataResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "isSiteRestricted":
						this.IsSiteRestricted = ParseBool(txt);
						continue;
					case "isCountryRestricted":
						this.IsCountryRestricted = ParseBool(txt);
						continue;
					case "isSessionRestricted":
						this.IsSessionRestricted = ParseBool(txt);
						continue;
					case "isIpAddressRestricted":
						this.IsIpAddressRestricted = ParseBool(txt);
						continue;
					case "isUserAgentRestricted":
						this.IsUserAgentRestricted = ParseBool(txt);
						continue;
					case "previewLength":
						this.PreviewLength = ParseInt(txt);
						continue;
					case "isScheduledNow":
						this.IsScheduledNow = ParseBool(txt);
						continue;
					case "isAdmin":
						this.IsAdmin = ParseBool(txt);
						continue;
					case "streamerType":
						this.StreamerType = txt;
						continue;
					case "mediaProtocol":
						this.MediaProtocol = txt;
						continue;
					case "storageProfilesXML":
						this.StorageProfilesXML = txt;
						continue;
					case "accessControlMessages":
						this.AccessControlMessages = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AccessControlMessages.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "accessControlActions":
						this.AccessControlActions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.AccessControlActions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
					case "flavorAssets":
						this.FlavorAssets = new List<KalturaFlavorAsset>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.FlavorAssets.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(arrayNode, "KalturaFlavorAsset"));
						}
						continue;
					case "pluginData":
						{
							string key;
							this.PluginData = new Dictionary<string, KalturaPluginData>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this.PluginData[key] = (KalturaPluginData)KalturaObjectFactory.Create(arrayNode, "KalturaPluginData");
							}
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
			kparams.AddReplace("objectType", "KalturaEntryContextDataResult");
			kparams.AddIfNotNull("isSiteRestricted", this.IsSiteRestricted);
			kparams.AddIfNotNull("isCountryRestricted", this.IsCountryRestricted);
			kparams.AddIfNotNull("isSessionRestricted", this.IsSessionRestricted);
			kparams.AddIfNotNull("isIpAddressRestricted", this.IsIpAddressRestricted);
			kparams.AddIfNotNull("isUserAgentRestricted", this.IsUserAgentRestricted);
			kparams.AddIfNotNull("previewLength", this.PreviewLength);
			kparams.AddIfNotNull("isScheduledNow", this.IsScheduledNow);
			kparams.AddIfNotNull("isAdmin", this.IsAdmin);
			kparams.AddIfNotNull("streamerType", this.StreamerType);
			kparams.AddIfNotNull("mediaProtocol", this.MediaProtocol);
			kparams.AddIfNotNull("storageProfilesXML", this.StorageProfilesXML);
			kparams.AddIfNotNull("accessControlMessages", this.AccessControlMessages);
			kparams.AddIfNotNull("accessControlActions", this.AccessControlActions);
			kparams.AddIfNotNull("flavorAssets", this.FlavorAssets);
			kparams.AddIfNotNull("pluginData", this.PluginData);
			return kparams;
		}
		#endregion
	}
}

