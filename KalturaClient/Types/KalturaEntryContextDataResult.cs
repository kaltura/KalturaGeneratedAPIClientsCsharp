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
	public class KalturaEntryContextDataResult : KalturaContextDataResult
	{
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
		private IList<KalturaString> _AccessControlMessages;
		private IList<KalturaRuleAction> _AccessControlActions;
		private IList<KalturaFlavorAsset> _FlavorAssets;
		private int _MsDuration = Int32.MinValue;
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
		public new IList<KalturaString> AccessControlMessages
		{
			get { return _AccessControlMessages; }
			set 
			{ 
				_AccessControlMessages = value;
				OnPropertyChanged("AccessControlMessages");
			}
		}
		public new IList<KalturaRuleAction> AccessControlActions
		{
			get { return _AccessControlActions; }
			set 
			{ 
				_AccessControlActions = value;
				OnPropertyChanged("AccessControlActions");
			}
		}
		public new IList<KalturaFlavorAsset> FlavorAssets
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
		public new IDictionary<string, KalturaPluginData> PluginData
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
						this._IsSiteRestricted = ParseBool(txt);
						continue;
					case "isCountryRestricted":
						this._IsCountryRestricted = ParseBool(txt);
						continue;
					case "isSessionRestricted":
						this._IsSessionRestricted = ParseBool(txt);
						continue;
					case "isIpAddressRestricted":
						this._IsIpAddressRestricted = ParseBool(txt);
						continue;
					case "isUserAgentRestricted":
						this._IsUserAgentRestricted = ParseBool(txt);
						continue;
					case "previewLength":
						this._PreviewLength = ParseInt(txt);
						continue;
					case "isScheduledNow":
						this._IsScheduledNow = ParseBool(txt);
						continue;
					case "isAdmin":
						this._IsAdmin = ParseBool(txt);
						continue;
					case "streamerType":
						this._StreamerType = txt;
						continue;
					case "mediaProtocol":
						this._MediaProtocol = txt;
						continue;
					case "storageProfilesXML":
						this._StorageProfilesXML = txt;
						continue;
					case "accessControlMessages":
						this._AccessControlMessages = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AccessControlMessages.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "accessControlActions":
						this._AccessControlActions = new List<KalturaRuleAction>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AccessControlActions.Add((KalturaRuleAction)KalturaObjectFactory.Create(arrayNode, "KalturaRuleAction"));
						}
						continue;
					case "flavorAssets":
						this._FlavorAssets = new List<KalturaFlavorAsset>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._FlavorAssets.Add((KalturaFlavorAsset)KalturaObjectFactory.Create(arrayNode, "KalturaFlavorAsset"));
						}
						continue;
					case "msDuration":
						this._MsDuration = ParseInt(txt);
						continue;
					case "pluginData":
						{
							string key;
							this._PluginData = new Dictionary<string, KalturaPluginData>();
							foreach(XmlElement arrayNode in propertyNode.ChildNodes)
							{
								key = arrayNode["itemKey"].InnerText;;
								this._PluginData[key] = (KalturaPluginData)KalturaObjectFactory.Create(arrayNode, "KalturaPluginData");
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
		#endregion
	}
}

