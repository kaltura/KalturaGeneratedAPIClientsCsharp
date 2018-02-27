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
	public class HttpNotificationTemplate : EventNotificationTemplate
	{
		#region Constants
		public const string URL = "url";
		public const string METHOD = "method";
		public const string DATA = "data";
		public const string TIMEOUT = "timeout";
		public const string CONNECT_TIMEOUT = "connectTimeout";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string AUTHENTICATION_METHOD = "authenticationMethod";
		public const string SSL_VERSION = "sslVersion";
		public const string SSL_CERTIFICATE = "sslCertificate";
		public const string SSL_CERTIFICATE_TYPE = "sslCertificateType";
		public const string SSL_CERTIFICATE_PASSWORD = "sslCertificatePassword";
		public const string SSL_ENGINE = "sslEngine";
		public const string SSL_ENGINE_DEFAULT = "sslEngineDefault";
		public const string SSL_KEY_TYPE = "sslKeyType";
		public const string SSL_KEY = "sslKey";
		public const string SSL_KEY_PASSWORD = "sslKeyPassword";
		public const string CUSTOM_HEADERS = "customHeaders";
		#endregion

		#region Private Fields
		private string _Url = null;
		private HttpNotificationMethod _Method = (HttpNotificationMethod)Int32.MinValue;
		private HttpNotificationData _Data;
		private int _Timeout = Int32.MinValue;
		private int _ConnectTimeout = Int32.MinValue;
		private string _Username = null;
		private string _Password = null;
		private HttpNotificationAuthenticationMethod _AuthenticationMethod = (HttpNotificationAuthenticationMethod)Int32.MinValue;
		private HttpNotificationSslVersion _SslVersion = (HttpNotificationSslVersion)Int32.MinValue;
		private string _SslCertificate = null;
		private HttpNotificationCertificateType _SslCertificateType = null;
		private string _SslCertificatePassword = null;
		private string _SslEngine = null;
		private string _SslEngineDefault = null;
		private HttpNotificationSslKeyType _SslKeyType = null;
		private string _SslKey = null;
		private string _SslKeyPassword = null;
		private IList<KeyValue> _CustomHeaders;
		#endregion

		#region Properties
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		public HttpNotificationMethod Method
		{
			get { return _Method; }
			set 
			{ 
				_Method = value;
				OnPropertyChanged("Method");
			}
		}
		public HttpNotificationData Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		public int Timeout
		{
			get { return _Timeout; }
			set 
			{ 
				_Timeout = value;
				OnPropertyChanged("Timeout");
			}
		}
		public int ConnectTimeout
		{
			get { return _ConnectTimeout; }
			set 
			{ 
				_ConnectTimeout = value;
				OnPropertyChanged("ConnectTimeout");
			}
		}
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
		public HttpNotificationAuthenticationMethod AuthenticationMethod
		{
			get { return _AuthenticationMethod; }
			set 
			{ 
				_AuthenticationMethod = value;
				OnPropertyChanged("AuthenticationMethod");
			}
		}
		public HttpNotificationSslVersion SslVersion
		{
			get { return _SslVersion; }
			set 
			{ 
				_SslVersion = value;
				OnPropertyChanged("SslVersion");
			}
		}
		public string SslCertificate
		{
			get { return _SslCertificate; }
			set 
			{ 
				_SslCertificate = value;
				OnPropertyChanged("SslCertificate");
			}
		}
		public HttpNotificationCertificateType SslCertificateType
		{
			get { return _SslCertificateType; }
			set 
			{ 
				_SslCertificateType = value;
				OnPropertyChanged("SslCertificateType");
			}
		}
		public string SslCertificatePassword
		{
			get { return _SslCertificatePassword; }
			set 
			{ 
				_SslCertificatePassword = value;
				OnPropertyChanged("SslCertificatePassword");
			}
		}
		public string SslEngine
		{
			get { return _SslEngine; }
			set 
			{ 
				_SslEngine = value;
				OnPropertyChanged("SslEngine");
			}
		}
		public string SslEngineDefault
		{
			get { return _SslEngineDefault; }
			set 
			{ 
				_SslEngineDefault = value;
				OnPropertyChanged("SslEngineDefault");
			}
		}
		public HttpNotificationSslKeyType SslKeyType
		{
			get { return _SslKeyType; }
			set 
			{ 
				_SslKeyType = value;
				OnPropertyChanged("SslKeyType");
			}
		}
		public string SslKey
		{
			get { return _SslKey; }
			set 
			{ 
				_SslKey = value;
				OnPropertyChanged("SslKey");
			}
		}
		public string SslKeyPassword
		{
			get { return _SslKeyPassword; }
			set 
			{ 
				_SslKeyPassword = value;
				OnPropertyChanged("SslKeyPassword");
			}
		}
		public IList<KeyValue> CustomHeaders
		{
			get { return _CustomHeaders; }
			set 
			{ 
				_CustomHeaders = value;
				OnPropertyChanged("CustomHeaders");
			}
		}
		#endregion

		#region CTor
		public HttpNotificationTemplate()
		{
		}

		public HttpNotificationTemplate(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "url":
						this._Url = propertyNode.InnerText;
						continue;
					case "method":
						this._Method = (HttpNotificationMethod)ParseEnum(typeof(HttpNotificationMethod), propertyNode.InnerText);
						continue;
					case "data":
						this._Data = ObjectFactory.Create<HttpNotificationData>(propertyNode);
						continue;
					case "timeout":
						this._Timeout = ParseInt(propertyNode.InnerText);
						continue;
					case "connectTimeout":
						this._ConnectTimeout = ParseInt(propertyNode.InnerText);
						continue;
					case "username":
						this._Username = propertyNode.InnerText;
						continue;
					case "password":
						this._Password = propertyNode.InnerText;
						continue;
					case "authenticationMethod":
						this._AuthenticationMethod = (HttpNotificationAuthenticationMethod)ParseEnum(typeof(HttpNotificationAuthenticationMethod), propertyNode.InnerText);
						continue;
					case "sslVersion":
						this._SslVersion = (HttpNotificationSslVersion)ParseEnum(typeof(HttpNotificationSslVersion), propertyNode.InnerText);
						continue;
					case "sslCertificate":
						this._SslCertificate = propertyNode.InnerText;
						continue;
					case "sslCertificateType":
						this._SslCertificateType = (HttpNotificationCertificateType)StringEnum.Parse(typeof(HttpNotificationCertificateType), propertyNode.InnerText);
						continue;
					case "sslCertificatePassword":
						this._SslCertificatePassword = propertyNode.InnerText;
						continue;
					case "sslEngine":
						this._SslEngine = propertyNode.InnerText;
						continue;
					case "sslEngineDefault":
						this._SslEngineDefault = propertyNode.InnerText;
						continue;
					case "sslKeyType":
						this._SslKeyType = (HttpNotificationSslKeyType)StringEnum.Parse(typeof(HttpNotificationSslKeyType), propertyNode.InnerText);
						continue;
					case "sslKey":
						this._SslKey = propertyNode.InnerText;
						continue;
					case "sslKeyPassword":
						this._SslKeyPassword = propertyNode.InnerText;
						continue;
					case "customHeaders":
						this._CustomHeaders = new List<KeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CustomHeaders.Add(ObjectFactory.Create<KeyValue>(arrayNode));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHttpNotificationTemplate");
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("method", this._Method);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("timeout", this._Timeout);
			kparams.AddIfNotNull("connectTimeout", this._ConnectTimeout);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("authenticationMethod", this._AuthenticationMethod);
			kparams.AddIfNotNull("sslVersion", this._SslVersion);
			kparams.AddIfNotNull("sslCertificate", this._SslCertificate);
			kparams.AddIfNotNull("sslCertificateType", this._SslCertificateType);
			kparams.AddIfNotNull("sslCertificatePassword", this._SslCertificatePassword);
			kparams.AddIfNotNull("sslEngine", this._SslEngine);
			kparams.AddIfNotNull("sslEngineDefault", this._SslEngineDefault);
			kparams.AddIfNotNull("sslKeyType", this._SslKeyType);
			kparams.AddIfNotNull("sslKey", this._SslKey);
			kparams.AddIfNotNull("sslKeyPassword", this._SslKeyPassword);
			kparams.AddIfNotNull("customHeaders", this._CustomHeaders);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case URL:
					return "Url";
				case METHOD:
					return "Method";
				case DATA:
					return "Data";
				case TIMEOUT:
					return "Timeout";
				case CONNECT_TIMEOUT:
					return "ConnectTimeout";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case AUTHENTICATION_METHOD:
					return "AuthenticationMethod";
				case SSL_VERSION:
					return "SslVersion";
				case SSL_CERTIFICATE:
					return "SslCertificate";
				case SSL_CERTIFICATE_TYPE:
					return "SslCertificateType";
				case SSL_CERTIFICATE_PASSWORD:
					return "SslCertificatePassword";
				case SSL_ENGINE:
					return "SslEngine";
				case SSL_ENGINE_DEFAULT:
					return "SslEngineDefault";
				case SSL_KEY_TYPE:
					return "SslKeyType";
				case SSL_KEY:
					return "SslKey";
				case SSL_KEY_PASSWORD:
					return "SslKeyPassword";
				case CUSTOM_HEADERS:
					return "CustomHeaders";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

