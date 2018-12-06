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
	public class UnicornDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string DOMAIN_NAME = "domainName";
		public const string CHANNEL_GUID = "channelGuid";
		public const string API_HOST_URL = "apiHostUrl";
		public const string DOMAIN_GUID = "domainGuid";
		public const string AD_FREE_APPLICATION_GUID = "adFreeApplicationGuid";
		public const string REMOTE_ASSET_PARAMS_ID = "remoteAssetParamsId";
		public const string STORAGE_PROFILE_ID = "storageProfileId";
		#endregion

		#region Private Fields
		private string _Username = null;
		private string _Password = null;
		private string _DomainName = null;
		private string _ChannelGuid = null;
		private string _ApiHostUrl = null;
		private string _DomainGuid = null;
		private string _AdFreeApplicationGuid = null;
		private int _RemoteAssetParamsId = Int32.MinValue;
		private string _StorageProfileId = null;
		#endregion

		#region Properties
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		public string DomainName
		{
			get { return _DomainName; }
			set 
			{ 
				_DomainName = value;
				OnPropertyChanged("DomainName");
			}
		}
		public string ChannelGuid
		{
			get { return _ChannelGuid; }
			set 
			{ 
				_ChannelGuid = value;
				OnPropertyChanged("ChannelGuid");
			}
		}
		public string ApiHostUrl
		{
			get { return _ApiHostUrl; }
			set 
			{ 
				_ApiHostUrl = value;
				OnPropertyChanged("ApiHostUrl");
			}
		}
		public string DomainGuid
		{
			get { return _DomainGuid; }
			set 
			{ 
				_DomainGuid = value;
				OnPropertyChanged("DomainGuid");
			}
		}
		public string AdFreeApplicationGuid
		{
			get { return _AdFreeApplicationGuid; }
			set 
			{ 
				_AdFreeApplicationGuid = value;
				OnPropertyChanged("AdFreeApplicationGuid");
			}
		}
		public int RemoteAssetParamsId
		{
			get { return _RemoteAssetParamsId; }
			set 
			{ 
				_RemoteAssetParamsId = value;
				OnPropertyChanged("RemoteAssetParamsId");
			}
		}
		public string StorageProfileId
		{
			get { return _StorageProfileId; }
			set 
			{ 
				_StorageProfileId = value;
				OnPropertyChanged("StorageProfileId");
			}
		}
		#endregion

		#region CTor
		public UnicornDistributionProfile()
		{
		}

		public UnicornDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "domainName":
						this._DomainName = propertyNode.InnerText;
						continue;
					case "channelGuid":
						this._ChannelGuid = propertyNode.InnerText;
						continue;
					case "apiHostUrl":
						this._ApiHostUrl = propertyNode.InnerText;
						continue;
					case "domainGuid":
						this._DomainGuid = propertyNode.InnerText;
						continue;
					case "adFreeApplicationGuid":
						this._AdFreeApplicationGuid = propertyNode.InnerText;
						continue;
					case "remoteAssetParamsId":
						this._RemoteAssetParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "storageProfileId":
						this._StorageProfileId = propertyNode.InnerText;
						continue;
				}
			}
		}

		public UnicornDistributionProfile(IDictionary<string,object> data) : base(data)
		{
			    this._Username = data.TryGetValueSafe<string>("username");
			    this._Password = data.TryGetValueSafe<string>("password");
			    this._DomainName = data.TryGetValueSafe<string>("domainName");
			    this._ChannelGuid = data.TryGetValueSafe<string>("channelGuid");
			    this._ApiHostUrl = data.TryGetValueSafe<string>("apiHostUrl");
			    this._DomainGuid = data.TryGetValueSafe<string>("domainGuid");
			    this._AdFreeApplicationGuid = data.TryGetValueSafe<string>("adFreeApplicationGuid");
			    this._RemoteAssetParamsId = data.TryGetValueSafe<int>("remoteAssetParamsId");
			    this._StorageProfileId = data.TryGetValueSafe<string>("storageProfileId");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUnicornDistributionProfile");
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("domainName", this._DomainName);
			kparams.AddIfNotNull("channelGuid", this._ChannelGuid);
			kparams.AddIfNotNull("apiHostUrl", this._ApiHostUrl);
			kparams.AddIfNotNull("domainGuid", this._DomainGuid);
			kparams.AddIfNotNull("adFreeApplicationGuid", this._AdFreeApplicationGuid);
			kparams.AddIfNotNull("remoteAssetParamsId", this._RemoteAssetParamsId);
			kparams.AddIfNotNull("storageProfileId", this._StorageProfileId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case DOMAIN_NAME:
					return "DomainName";
				case CHANNEL_GUID:
					return "ChannelGuid";
				case API_HOST_URL:
					return "ApiHostUrl";
				case DOMAIN_GUID:
					return "DomainGuid";
				case AD_FREE_APPLICATION_GUID:
					return "AdFreeApplicationGuid";
				case REMOTE_ASSET_PARAMS_ID:
					return "RemoteAssetParamsId";
				case STORAGE_PROFILE_ID:
					return "StorageProfileId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

