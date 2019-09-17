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
	public class PushToNewsDistributionProfile : ConfigurableDistributionProfile
	{
		#region Constants
		public const string PROTOCOL = "protocol";
		public const string HOST = "host";
		public const string IPS = "ips";
		public const string PORT = "port";
		public const string BASE_PATH = "basePath";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string CERTIFICATE_KEY = "certificateKey";
		public const string BODY_XSLT = "bodyXslt";
		public const string RECENT_NEWS_TIME_INTERVAL = "recentNewsTimeInterval";
		#endregion

		#region Private Fields
		private DistributionProtocol _Protocol = (DistributionProtocol)Int32.MinValue;
		private string _Host = null;
		private string _Ips = null;
		private int _Port = Int32.MinValue;
		private string _BasePath = null;
		private string _Username = null;
		private string _Password = null;
		private string _CertificateKey = null;
		private string _BodyXslt = null;
		private int _RecentNewsTimeInterval = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public DistributionProtocol Protocol
		{
			get { return _Protocol; }
			set 
			{ 
				_Protocol = value;
				OnPropertyChanged("Protocol");
			}
		}
		[JsonProperty]
		public string Host
		{
			get { return _Host; }
			set 
			{ 
				_Host = value;
				OnPropertyChanged("Host");
			}
		}
		[JsonProperty]
		public string Ips
		{
			get { return _Ips; }
			set 
			{ 
				_Ips = value;
				OnPropertyChanged("Ips");
			}
		}
		[JsonProperty]
		public int Port
		{
			get { return _Port; }
			set 
			{ 
				_Port = value;
				OnPropertyChanged("Port");
			}
		}
		[JsonProperty]
		public string BasePath
		{
			get { return _BasePath; }
			set 
			{ 
				_BasePath = value;
				OnPropertyChanged("BasePath");
			}
		}
		[JsonProperty]
		public string Username
		{
			get { return _Username; }
			set 
			{ 
				_Username = value;
				OnPropertyChanged("Username");
			}
		}
		[JsonProperty]
		public string Password
		{
			get { return _Password; }
			set 
			{ 
				_Password = value;
				OnPropertyChanged("Password");
			}
		}
		[JsonProperty]
		public string CertificateKey
		{
			get { return _CertificateKey; }
			set 
			{ 
				_CertificateKey = value;
				OnPropertyChanged("CertificateKey");
			}
		}
		[JsonProperty]
		public string BodyXslt
		{
			get { return _BodyXslt; }
			set 
			{ 
				_BodyXslt = value;
				OnPropertyChanged("BodyXslt");
			}
		}
		[JsonProperty]
		public int RecentNewsTimeInterval
		{
			get { return _RecentNewsTimeInterval; }
			set 
			{ 
				_RecentNewsTimeInterval = value;
				OnPropertyChanged("RecentNewsTimeInterval");
			}
		}
		#endregion

		#region CTor
		public PushToNewsDistributionProfile()
		{
		}

		public PushToNewsDistributionProfile(JToken node) : base(node)
		{
			if(node["protocol"] != null)
			{
				this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), node["protocol"].Value<string>());
			}
			if(node["host"] != null)
			{
				this._Host = node["host"].Value<string>();
			}
			if(node["ips"] != null)
			{
				this._Ips = node["ips"].Value<string>();
			}
			if(node["port"] != null)
			{
				this._Port = ParseInt(node["port"].Value<string>());
			}
			if(node["basePath"] != null)
			{
				this._BasePath = node["basePath"].Value<string>();
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["certificateKey"] != null)
			{
				this._CertificateKey = node["certificateKey"].Value<string>();
			}
			if(node["bodyXslt"] != null)
			{
				this._BodyXslt = node["bodyXslt"].Value<string>();
			}
			if(node["recentNewsTimeInterval"] != null)
			{
				this._RecentNewsTimeInterval = ParseInt(node["recentNewsTimeInterval"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPushToNewsDistributionProfile");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("host", this._Host);
			kparams.AddIfNotNull("ips", this._Ips);
			kparams.AddIfNotNull("port", this._Port);
			kparams.AddIfNotNull("basePath", this._BasePath);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("certificateKey", this._CertificateKey);
			kparams.AddIfNotNull("bodyXslt", this._BodyXslt);
			kparams.AddIfNotNull("recentNewsTimeInterval", this._RecentNewsTimeInterval);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL:
					return "Protocol";
				case HOST:
					return "Host";
				case IPS:
					return "Ips";
				case PORT:
					return "Port";
				case BASE_PATH:
					return "BasePath";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case CERTIFICATE_KEY:
					return "CertificateKey";
				case BODY_XSLT:
					return "BodyXslt";
				case RECENT_NEWS_TIME_INTERVAL:
					return "RecentNewsTimeInterval";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

