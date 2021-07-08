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
	public class StorageJobData : JobData
	{
		#region Constants
		public const string SERVER_URL = "serverUrl";
		public const string SERVER_USERNAME = "serverUsername";
		public const string SERVER_PASSWORD = "serverPassword";
		public const string SERVER_PRIVATE_KEY = "serverPrivateKey";
		public const string SERVER_PUBLIC_KEY = "serverPublicKey";
		public const string SERVER_PASS_PHRASE = "serverPassPhrase";
		public const string FTP_PASSIVE_MODE = "ftpPassiveMode";
		public const string SRC_FILE_SYNC_LOCAL_PATH = "srcFileSyncLocalPath";
		public const string SRC_FILE_ENCRYPTION_KEY = "srcFileEncryptionKey";
		public const string SRC_FILE_SYNC_ID = "srcFileSyncId";
		public const string DEST_FILE_SYNC_STORED_PATH = "destFileSyncStoredPath";
		#endregion

		#region Private Fields
		private string _ServerUrl = null;
		private string _ServerUsername = null;
		private string _ServerPassword = null;
		private string _ServerPrivateKey = null;
		private string _ServerPublicKey = null;
		private string _ServerPassPhrase = null;
		private bool? _FtpPassiveMode = null;
		private string _SrcFileSyncLocalPath = null;
		private string _SrcFileEncryptionKey = null;
		private string _SrcFileSyncId = null;
		private string _DestFileSyncStoredPath = null;
		#endregion

		#region Properties
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
		/// Use ServerUsernameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerUsername
		{
			get { return _ServerUsername; }
			set 
			{ 
				_ServerUsername = value;
				OnPropertyChanged("ServerUsername");
			}
		}
		/// <summary>
		/// Use ServerPasswordAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerPassword
		{
			get { return _ServerPassword; }
			set 
			{ 
				_ServerPassword = value;
				OnPropertyChanged("ServerPassword");
			}
		}
		/// <summary>
		/// Use ServerPrivateKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerPrivateKey
		{
			get { return _ServerPrivateKey; }
			set 
			{ 
				_ServerPrivateKey = value;
				OnPropertyChanged("ServerPrivateKey");
			}
		}
		/// <summary>
		/// Use ServerPublicKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerPublicKey
		{
			get { return _ServerPublicKey; }
			set 
			{ 
				_ServerPublicKey = value;
				OnPropertyChanged("ServerPublicKey");
			}
		}
		/// <summary>
		/// Use ServerPassPhraseAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ServerPassPhrase
		{
			get { return _ServerPassPhrase; }
			set 
			{ 
				_ServerPassPhrase = value;
				OnPropertyChanged("ServerPassPhrase");
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
		/// Use SrcFileSyncLocalPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		/// <summary>
		/// Use SrcFileEncryptionKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileEncryptionKey
		{
			get { return _SrcFileEncryptionKey; }
			set 
			{ 
				_SrcFileEncryptionKey = value;
				OnPropertyChanged("SrcFileEncryptionKey");
			}
		}
		/// <summary>
		/// Use SrcFileSyncIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileSyncId
		{
			get { return _SrcFileSyncId; }
			set 
			{ 
				_SrcFileSyncId = value;
				OnPropertyChanged("SrcFileSyncId");
			}
		}
		/// <summary>
		/// Use DestFileSyncStoredPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string DestFileSyncStoredPath
		{
			get { return _DestFileSyncStoredPath; }
			set 
			{ 
				_DestFileSyncStoredPath = value;
				OnPropertyChanged("DestFileSyncStoredPath");
			}
		}
		#endregion

		#region CTor
		public StorageJobData()
		{
		}

		public StorageJobData(JToken node) : base(node)
		{
			if(node["serverUrl"] != null)
			{
				this._ServerUrl = node["serverUrl"].Value<string>();
			}
			if(node["serverUsername"] != null)
			{
				this._ServerUsername = node["serverUsername"].Value<string>();
			}
			if(node["serverPassword"] != null)
			{
				this._ServerPassword = node["serverPassword"].Value<string>();
			}
			if(node["serverPrivateKey"] != null)
			{
				this._ServerPrivateKey = node["serverPrivateKey"].Value<string>();
			}
			if(node["serverPublicKey"] != null)
			{
				this._ServerPublicKey = node["serverPublicKey"].Value<string>();
			}
			if(node["serverPassPhrase"] != null)
			{
				this._ServerPassPhrase = node["serverPassPhrase"].Value<string>();
			}
			if(node["ftpPassiveMode"] != null)
			{
				this._FtpPassiveMode = ParseBool(node["ftpPassiveMode"].Value<string>());
			}
			if(node["srcFileSyncLocalPath"] != null)
			{
				this._SrcFileSyncLocalPath = node["srcFileSyncLocalPath"].Value<string>();
			}
			if(node["srcFileEncryptionKey"] != null)
			{
				this._SrcFileEncryptionKey = node["srcFileEncryptionKey"].Value<string>();
			}
			if(node["srcFileSyncId"] != null)
			{
				this._SrcFileSyncId = node["srcFileSyncId"].Value<string>();
			}
			if(node["destFileSyncStoredPath"] != null)
			{
				this._DestFileSyncStoredPath = node["destFileSyncStoredPath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStorageJobData");
			kparams.AddIfNotNull("serverUrl", this._ServerUrl);
			kparams.AddIfNotNull("serverUsername", this._ServerUsername);
			kparams.AddIfNotNull("serverPassword", this._ServerPassword);
			kparams.AddIfNotNull("serverPrivateKey", this._ServerPrivateKey);
			kparams.AddIfNotNull("serverPublicKey", this._ServerPublicKey);
			kparams.AddIfNotNull("serverPassPhrase", this._ServerPassPhrase);
			kparams.AddIfNotNull("ftpPassiveMode", this._FtpPassiveMode);
			kparams.AddIfNotNull("srcFileSyncLocalPath", this._SrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileEncryptionKey", this._SrcFileEncryptionKey);
			kparams.AddIfNotNull("srcFileSyncId", this._SrcFileSyncId);
			kparams.AddIfNotNull("destFileSyncStoredPath", this._DestFileSyncStoredPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SERVER_URL:
					return "ServerUrl";
				case SERVER_USERNAME:
					return "ServerUsername";
				case SERVER_PASSWORD:
					return "ServerPassword";
				case SERVER_PRIVATE_KEY:
					return "ServerPrivateKey";
				case SERVER_PUBLIC_KEY:
					return "ServerPublicKey";
				case SERVER_PASS_PHRASE:
					return "ServerPassPhrase";
				case FTP_PASSIVE_MODE:
					return "FtpPassiveMode";
				case SRC_FILE_SYNC_LOCAL_PATH:
					return "SrcFileSyncLocalPath";
				case SRC_FILE_ENCRYPTION_KEY:
					return "SrcFileEncryptionKey";
				case SRC_FILE_SYNC_ID:
					return "SrcFileSyncId";
				case DEST_FILE_SYNC_STORED_PATH:
					return "DestFileSyncStoredPath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

