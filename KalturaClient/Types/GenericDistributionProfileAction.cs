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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class GenericDistributionProfileAction : ObjectBase
	{
		#region Constants
		public const string PROTOCOL = "protocol";
		public const string SERVER_URL = "serverUrl";
		public const string SERVER_PATH = "serverPath";
		public const string USERNAME = "username";
		public const string PASSWORD = "password";
		public const string FTP_PASSIVE_MODE = "ftpPassiveMode";
		public const string HTTP_FIELD_NAME = "httpFieldName";
		public const string HTTP_FILE_NAME = "httpFileName";
		#endregion

		#region Private Fields
		private DistributionProtocol _Protocol = (DistributionProtocol)Int32.MinValue;
		private string _ServerUrl = null;
		private string _ServerPath = null;
		private string _Username = null;
		private string _Password = null;
		private bool? _FtpPassiveMode = null;
		private string _HttpFieldName = null;
		private string _HttpFileName = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use ProtocolAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use ServerUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerUrl
		{
			get { return _ServerUrl; }
			set 
			{ 
				_ServerUrl = value;
				OnPropertyChanged("ServerUrl");
			}
		}
		/// <summary>
		/// Use ServerPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerPath
		{
			get { return _ServerPath; }
			set 
			{ 
				_ServerPath = value;
				OnPropertyChanged("ServerPath");
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
		/// Use FtpPassiveModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? FtpPassiveMode
		{
			get { return _FtpPassiveMode; }
			set 
			{ 
				_FtpPassiveMode = value;
				OnPropertyChanged("FtpPassiveMode");
			}
		}
		/// <summary>
		/// Use HttpFieldNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HttpFieldName
		{
			get { return _HttpFieldName; }
			set 
			{ 
				_HttpFieldName = value;
				OnPropertyChanged("HttpFieldName");
			}
		}
		/// <summary>
		/// Use HttpFileNameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string HttpFileName
		{
			get { return _HttpFileName; }
			set 
			{ 
				_HttpFileName = value;
				OnPropertyChanged("HttpFileName");
			}
		}
		#endregion

		#region CTor
		public GenericDistributionProfileAction()
		{
		}

		public GenericDistributionProfileAction(JToken node) : base(node)
		{
			if(node["protocol"] != null)
			{
				this._Protocol = (DistributionProtocol)ParseEnum(typeof(DistributionProtocol), node["protocol"].Value<string>());
			}
			if(node["serverUrl"] != null)
			{
				this._ServerUrl = node["serverUrl"].Value<string>();
			}
			if(node["serverPath"] != null)
			{
				this._ServerPath = node["serverPath"].Value<string>();
			}
			if(node["username"] != null)
			{
				this._Username = node["username"].Value<string>();
			}
			if(node["password"] != null)
			{
				this._Password = node["password"].Value<string>();
			}
			if(node["ftpPassiveMode"] != null)
			{
				this._FtpPassiveMode = ParseBool(node["ftpPassiveMode"].Value<string>());
			}
			if(node["httpFieldName"] != null)
			{
				this._HttpFieldName = node["httpFieldName"].Value<string>();
			}
			if(node["httpFileName"] != null)
			{
				this._HttpFileName = node["httpFileName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaGenericDistributionProfileAction");
			kparams.AddIfNotNull("protocol", this._Protocol);
			kparams.AddIfNotNull("serverUrl", this._ServerUrl);
			kparams.AddIfNotNull("serverPath", this._ServerPath);
			kparams.AddIfNotNull("username", this._Username);
			kparams.AddIfNotNull("password", this._Password);
			kparams.AddIfNotNull("ftpPassiveMode", this._FtpPassiveMode);
			kparams.AddIfNotNull("httpFieldName", this._HttpFieldName);
			kparams.AddIfNotNull("httpFileName", this._HttpFileName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PROTOCOL:
					return "Protocol";
				case SERVER_URL:
					return "ServerUrl";
				case SERVER_PATH:
					return "ServerPath";
				case USERNAME:
					return "Username";
				case PASSWORD:
					return "Password";
				case FTP_PASSIVE_MODE:
					return "FtpPassiveMode";
				case HTTP_FIELD_NAME:
					return "HttpFieldName";
				case HTTP_FILE_NAME:
					return "HttpFileName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

