// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
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
	public class HttpNotificationDispatchJobData : EventNotificationDispatchJobData
	{
		#region Constants
		public const string URL = "url";
		public const string METHOD = "method";
		public const string CONTENT_TYPE = "contentType";
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
		public const string SIGN_SECRET = "signSecret";
		#endregion

		#region Private Fields
		private string _Url = null;
		private HttpNotificationMethod _Method = (HttpNotificationMethod)Int32.MinValue;
		private string _ContentType = null;
		private string _Data = null;
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
		private string _SignSecret = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use UrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Url
		{
			get { return _Url; }
			set 
			{ 
				_Url = value;
				OnPropertyChanged("Url");
			}
		}
		/// <summary>
		/// Use MethodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HttpNotificationMethod Method
		{
			get { return _Method; }
			set 
			{ 
				_Method = value;
				OnPropertyChanged("Method");
			}
		}
		/// <summary>
		/// Use ContentTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContentType
		{
			get { return _ContentType; }
			set 
			{ 
				_ContentType = value;
				OnPropertyChanged("ContentType");
			}
		}
		/// <summary>
		/// Use DataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Data
		{
			get { return _Data; }
			set 
			{ 
				_Data = value;
				OnPropertyChanged("Data");
			}
		}
		/// <summary>
		/// Use TimeoutAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Timeout
		{
			get { return _Timeout; }
			set 
			{ 
				_Timeout = value;
				OnPropertyChanged("Timeout");
			}
		}
		/// <summary>
		/// Use ConnectTimeoutAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ConnectTimeout
		{
			get { return _ConnectTimeout; }
			set 
			{ 
				_ConnectTimeout = value;
				OnPropertyChanged("ConnectTimeout");
			}
		}
		/// <summary>
		/// Use UsernameAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use PasswordAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use AuthenticationMethodAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HttpNotificationAuthenticationMethod AuthenticationMethod
		{
			get { return _AuthenticationMethod; }
			set 
			{ 
				_AuthenticationMethod = value;
				OnPropertyChanged("AuthenticationMethod");
			}
		}
		/// <summary>
		/// Use SslVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HttpNotificationSslVersion SslVersion
		{
			get { return _SslVersion; }
			set 
			{ 
				_SslVersion = value;
				OnPropertyChanged("SslVersion");
			}
		}
		/// <summary>
		/// Use SslCertificateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslCertificate
		{
			get { return _SslCertificate; }
			set 
			{ 
				_SslCertificate = value;
				OnPropertyChanged("SslCertificate");
			}
		}
		/// <summary>
		/// Use SslCertificateTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HttpNotificationCertificateType SslCertificateType
		{
			get { return _SslCertificateType; }
			set 
			{ 
				_SslCertificateType = value;
				OnPropertyChanged("SslCertificateType");
			}
		}
		/// <summary>
		/// Use SslCertificatePasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslCertificatePassword
		{
			get { return _SslCertificatePassword; }
			set 
			{ 
				_SslCertificatePassword = value;
				OnPropertyChanged("SslCertificatePassword");
			}
		}
		/// <summary>
		/// Use SslEngineAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslEngine
		{
			get { return _SslEngine; }
			set 
			{ 
				_SslEngine = value;
				OnPropertyChanged("SslEngine");
			}
		}
		/// <summary>
		/// Use SslEngineDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslEngineDefault
		{
			get { return _SslEngineDefault; }
			set 
			{ 
				_SslEngineDefault = value;
				OnPropertyChanged("SslEngineDefault");
			}
		}
		/// <summary>
		/// Use SslKeyTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public HttpNotificationSslKeyType SslKeyType
		{
			get { return _SslKeyType; }
			set 
			{ 
				_SslKeyType = value;
				OnPropertyChanged("SslKeyType");
			}
		}
		/// <summary>
		/// Use SslKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslKey
		{
			get { return _SslKey; }
			set 
			{ 
				_SslKey = value;
				OnPropertyChanged("SslKey");
			}
		}
		/// <summary>
		/// Use SslKeyPasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SslKeyPassword
		{
			get { return _SslKeyPassword; }
			set 
			{ 
				_SslKeyPassword = value;
				OnPropertyChanged("SslKeyPassword");
			}
		}
		/// <summary>
		/// Use CustomHeadersAsDouble property instead
		/// </summary>
		[JsonProperty]
		public IList<KeyValue> CustomHeaders
		{
			get { return _CustomHeaders; }
			set 
			{ 
				_CustomHeaders = value;
				OnPropertyChanged("CustomHeaders");
			}
		}
		/// <summary>
		/// Use SignSecretAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SignSecret
		{
			get { return _SignSecret; }
			set 
			{ 
				_SignSecret = value;
				OnPropertyChanged("SignSecret");
			}
		}
		#endregion

		#region CTor
		public HttpNotificationDispatchJobData()
		{
		}

		public HttpNotificationDispatchJobData(JToken node) : base(node)
		{
			if(node["url"] != null)
			{
				this._Url = node["url"].Value<string>();
			}
			if(node["method"] != null)
			{
				this._Method = (HttpNotificationMethod)ParseEnum(typeof(HttpNotificationMethod), node["method"].Value<string>());
			}
			if(node["contentType"] != null)
			{
				this._ContentType = node["contentType"].Value<string>();
			}
			if(node["data"] != null)
			{
				this._Data = node["data"].Value<string>();
			}
			if(node["timeout"] != null)
			{
				this._Timeout = ParseInt(node["timeout"].Value<string>());
			}
			if(node["connectTimeout"] != null)
			{
				this._ConnectTimeout = ParseInt(node["connectTimeout"].Value<string>());
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["authenticationMethod"] != null)
			{
				this._AuthenticationMethod = (HttpNotificationAuthenticationMethod)ParseEnum(typeof(HttpNotificationAuthenticationMethod), node["authenticationMethod"].Value<string>());
			}
			if(node["sslVersion"] != null)
			{
				this._SslVersion = (HttpNotificationSslVersion)ParseEnum(typeof(HttpNotificationSslVersion), node["sslVersion"].Value<string>());
			}
			if(node["sslCertificate"] != null)
			{
				this._SslCertificate = node["sslCertificate"].Value<string>();
			}
			if(node["sslCertificateType"] != null)
			{
				this._SslCertificateType = (HttpNotificationCertificateType)StringEnum.Parse(typeof(HttpNotificationCertificateType), node["sslCertificateType"].Value<string>());
			}
			if(node["sslCertificatePassword"] != null)
			{
				this._SslCertificatePassword = node["sslCertificatePassword"].Value<string>();
			}
			if(node["sslEngine"] != null)
			{
				this._SslEngine = node["sslEngine"].Value<string>();
			}
			if(node["sslEngineDefault"] != null)
			{
				this._SslEngineDefault = node["sslEngineDefault"].Value<string>();
			}
			if(node["sslKeyType"] != null)
			{
				this._SslKeyType = (HttpNotificationSslKeyType)StringEnum.Parse(typeof(HttpNotificationSslKeyType), node["sslKeyType"].Value<string>());
			}
			if(node["sslKey"] != null)
			{
				this._SslKey = node["sslKey"].Value<string>();
			}
			if(node["sslKeyPassword"] != null)
			{
				this._SslKeyPassword = node["sslKeyPassword"].Value<string>();
			}
			if(node["customHeaders"] != null)
			{
				this._CustomHeaders = new List<KeyValue>();
				foreach(var arrayNode in node["customHeaders"].Children())
				{
					this._CustomHeaders.Add(ObjectFactory.Create<KeyValue>(arrayNode));
				}
			}
			if(node["signSecret"] != null)
			{
				this._SignSecret = node["signSecret"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaHttpNotificationDispatchJobData");
			kparams.AddIfNotNull("url", this._Url);
			kparams.AddIfNotNull("method", this._Method);
			kparams.AddIfNotNull("contentType", this._ContentType);
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
			kparams.AddIfNotNull("signSecret", this._SignSecret);
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
				case CONTENT_TYPE:
					return "ContentType";
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
				case SIGN_SECRET:
					return "SignSecret";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

