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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class VerizonVcastDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string FTP_HOST = "ftpHost";
		public const string FTP_LOGIN = "ftpLogin";
		public const string FTP_PASS = "ftpPass";
		public const string PROVIDER_NAME = "providerName";
		public const string PROVIDER_ID = "providerId";
		public const string ENTITLEMENT = "entitlement";
		public const string PRIORITY = "priority";
		public const string ALLOW_STREAMING = "allowStreaming";
		public const string STREAMING_PRICE_CODE = "streamingPriceCode";
		public const string ALLOW_DOWNLOAD = "allowDownload";
		public const string DOWNLOAD_PRICE_CODE = "downloadPriceCode";
		#endregion

		#region Private Fields
		private string _FtpHost = null;
		private string _FtpLogin = null;
		private string _FtpPass = null;
		private string _ProviderName = null;
		private string _ProviderId = null;
		private string _Entitlement = null;
		private string _Priority = null;
		private string _AllowStreaming = null;
		private string _StreamingPriceCode = null;
		private string _AllowDownload = null;
		private string _DownloadPriceCode = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string FtpHost
		{
			get { return _FtpHost; }
			set 
			{ 
				_FtpHost = value;
				OnPropertyChanged("FtpHost");
			}
		}
		[JsonProperty]
		public string FtpLogin
		{
			get { return _FtpLogin; }
			set 
			{ 
				_FtpLogin = value;
				OnPropertyChanged("FtpLogin");
			}
		}
		[JsonProperty]
		public string FtpPass
		{
			get { return _FtpPass; }
			set 
			{ 
				_FtpPass = value;
				OnPropertyChanged("FtpPass");
			}
		}
		[JsonProperty]
		public string ProviderName
		{
			get { return _ProviderName; }
			set 
			{ 
				_ProviderName = value;
				OnPropertyChanged("ProviderName");
			}
		}
		[JsonProperty]
		public string ProviderId
		{
			get { return _ProviderId; }
			set 
			{ 
				_ProviderId = value;
				OnPropertyChanged("ProviderId");
			}
		}
		[JsonProperty]
		public string Entitlement
		{
			get { return _Entitlement; }
			set 
			{ 
				_Entitlement = value;
				OnPropertyChanged("Entitlement");
			}
		}
		[JsonProperty]
		public string Priority
		{
			get { return _Priority; }
			set 
			{ 
				_Priority = value;
				OnPropertyChanged("Priority");
			}
		}
		[JsonProperty]
		public string AllowStreaming
		{
			get { return _AllowStreaming; }
			set 
			{ 
				_AllowStreaming = value;
				OnPropertyChanged("AllowStreaming");
			}
		}
		[JsonProperty]
		public string StreamingPriceCode
		{
			get { return _StreamingPriceCode; }
			set 
			{ 
				_StreamingPriceCode = value;
				OnPropertyChanged("StreamingPriceCode");
			}
		}
		[JsonProperty]
		public string AllowDownload
		{
			get { return _AllowDownload; }
			set 
			{ 
				_AllowDownload = value;
				OnPropertyChanged("AllowDownload");
			}
		}
		[JsonProperty]
		public string DownloadPriceCode
		{
			get { return _DownloadPriceCode; }
			set 
			{ 
				_DownloadPriceCode = value;
				OnPropertyChanged("DownloadPriceCode");
			}
		}
		#endregion

		#region CTor
		public VerizonVcastDistributionProfile()
		{
		}

		public VerizonVcastDistributionProfile(JToken node) : base(node)
		{
			if(node["ftpHost"] != null)
			{
				this._FtpHost = node["ftpHost"].Value<string>();
			}
			if(node["ftpLogin"] != null)
			{
				this._FtpLogin = node["ftpLogin"].Value<string>();
			}
			if(node["ftpPass"] != null)
			{
				this._FtpPass = node["ftpPass"].Value<string>();
			}
			if(node["providerName"] != null)
			{
				this._ProviderName = node["providerName"].Value<string>();
			}
			if(node["providerId"] != null)
			{
				this._ProviderId = node["providerId"].Value<string>();
			}
			if(node["entitlement"] != null)
			{
				this._Entitlement = node["entitlement"].Value<string>();
			}
			if(node["priority"] != null)
			{
				this._Priority = node["priority"].Value<string>();
			}
			if(node["allowStreaming"] != null)
			{
				this._AllowStreaming = node["allowStreaming"].Value<string>();
			}
			if(node["streamingPriceCode"] != null)
			{
				this._StreamingPriceCode = node["streamingPriceCode"].Value<string>();
			}
			if(node["allowDownload"] != null)
			{
				this._AllowDownload = node["allowDownload"].Value<string>();
			}
			if(node["downloadPriceCode"] != null)
			{
				this._DownloadPriceCode = node["downloadPriceCode"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVerizonVcastDistributionProfile");
			kparams.AddIfNotNull("ftpHost", this._FtpHost);
			kparams.AddIfNotNull("ftpLogin", this._FtpLogin);
			kparams.AddIfNotNull("ftpPass", this._FtpPass);
			kparams.AddIfNotNull("providerName", this._ProviderName);
			kparams.AddIfNotNull("providerId", this._ProviderId);
			kparams.AddIfNotNull("entitlement", this._Entitlement);
			kparams.AddIfNotNull("priority", this._Priority);
			kparams.AddIfNotNull("allowStreaming", this._AllowStreaming);
			kparams.AddIfNotNull("streamingPriceCode", this._StreamingPriceCode);
			kparams.AddIfNotNull("allowDownload", this._AllowDownload);
			kparams.AddIfNotNull("downloadPriceCode", this._DownloadPriceCode);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FTP_HOST:
					return "FtpHost";
				case FTP_LOGIN:
					return "FtpLogin";
				case FTP_PASS:
					return "FtpPass";
				case PROVIDER_NAME:
					return "ProviderName";
				case PROVIDER_ID:
					return "ProviderId";
				case ENTITLEMENT:
					return "Entitlement";
				case PRIORITY:
					return "Priority";
				case ALLOW_STREAMING:
					return "AllowStreaming";
				case STREAMING_PRICE_CODE:
					return "StreamingPriceCode";
				case ALLOW_DOWNLOAD:
					return "AllowDownload";
				case DOWNLOAD_PRICE_CODE:
					return "DownloadPriceCode";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

