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
	public class KalturaHttpNotificationDispatchJobData : KalturaEventNotificationDispatchJobData
	{
		#region Private Fields
		private string _Url = null;
		private KalturaHttpNotificationMethod _Method = (KalturaHttpNotificationMethod)Int32.MinValue;
		private string _Data = null;
		private int _Timeout = Int32.MinValue;
		private int _ConnectTimeout = Int32.MinValue;
		private string _Username = null;
		private string _Password = null;
		private KalturaHttpNotificationAuthenticationMethod _AuthenticationMethod = (KalturaHttpNotificationAuthenticationMethod)Int32.MinValue;
		private KalturaHttpNotificationSslVersion _SslVersion = (KalturaHttpNotificationSslVersion)Int32.MinValue;
		private string _SslCertificate = null;
		private KalturaHttpNotificationCertificateType _SslCertificateType = null;
		private string _SslCertificatePassword = null;
		private string _SslEngine = null;
		private string _SslEngineDefault = null;
		private KalturaHttpNotificationSslKeyType _SslKeyType = null;
		private string _SslKey = null;
		private string _SslKeyPassword = null;
		private IList<KalturaKeyValue> _CustomHeaders;
		private string _SignSecret = null;
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
		public KalturaHttpNotificationMethod Method
		{
			get { return _Method; }
			set 
			{ 
				_Method = value;
				OnPropertyChanged("Method");
			}
		}
		public string Data
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
		public KalturaHttpNotificationAuthenticationMethod AuthenticationMethod
		{
			get { return _AuthenticationMethod; }
			set 
			{ 
				_AuthenticationMethod = value;
				OnPropertyChanged("AuthenticationMethod");
			}
		}
		public KalturaHttpNotificationSslVersion SslVersion
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
		public KalturaHttpNotificationCertificateType SslCertificateType
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
		public KalturaHttpNotificationSslKeyType SslKeyType
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
		public new IList<KalturaKeyValue> CustomHeaders
		{
			get { return _CustomHeaders; }
			set 
			{ 
				_CustomHeaders = value;
				OnPropertyChanged("CustomHeaders");
			}
		}
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
		public KalturaHttpNotificationDispatchJobData()
		{
		}

		public KalturaHttpNotificationDispatchJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "url":
						this._Url = txt;
						continue;
					case "method":
						this._Method = (KalturaHttpNotificationMethod)ParseEnum(typeof(KalturaHttpNotificationMethod), txt);
						continue;
					case "data":
						this._Data = txt;
						continue;
					case "timeout":
						this._Timeout = ParseInt(txt);
						continue;
					case "connectTimeout":
						this._ConnectTimeout = ParseInt(txt);
						continue;
					case "username":
						this._Username = txt;
						continue;
					case "password":
						this._Password = txt;
						continue;
					case "authenticationMethod":
						this._AuthenticationMethod = (KalturaHttpNotificationAuthenticationMethod)ParseEnum(typeof(KalturaHttpNotificationAuthenticationMethod), txt);
						continue;
					case "sslVersion":
						this._SslVersion = (KalturaHttpNotificationSslVersion)ParseEnum(typeof(KalturaHttpNotificationSslVersion), txt);
						continue;
					case "sslCertificate":
						this._SslCertificate = txt;
						continue;
					case "sslCertificateType":
						this._SslCertificateType = (KalturaHttpNotificationCertificateType)KalturaStringEnum.Parse(typeof(KalturaHttpNotificationCertificateType), txt);
						continue;
					case "sslCertificatePassword":
						this._SslCertificatePassword = txt;
						continue;
					case "sslEngine":
						this._SslEngine = txt;
						continue;
					case "sslEngineDefault":
						this._SslEngineDefault = txt;
						continue;
					case "sslKeyType":
						this._SslKeyType = (KalturaHttpNotificationSslKeyType)KalturaStringEnum.Parse(typeof(KalturaHttpNotificationSslKeyType), txt);
						continue;
					case "sslKey":
						this._SslKey = txt;
						continue;
					case "sslKeyPassword":
						this._SslKeyPassword = txt;
						continue;
					case "customHeaders":
						this._CustomHeaders = new List<KalturaKeyValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CustomHeaders.Add((KalturaKeyValue)KalturaObjectFactory.Create(arrayNode, "KalturaKeyValue"));
						}
						continue;
					case "signSecret":
						this._SignSecret = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaHttpNotificationDispatchJobData");
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
			kparams.AddIfNotNull("signSecret", this._SignSecret);
			return kparams;
		}
		#endregion
	}
}

