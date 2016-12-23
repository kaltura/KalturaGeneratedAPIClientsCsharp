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
using Kaltura.Enums;
using Kaltura.Request;

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
		private string _SrcFileSyncId = null;
		private string _DestFileSyncStoredPath = null;
		#endregion

		#region Properties
		public string ServerUrl
		{
			get { return _ServerUrl; }
			set 
			{ 
				_ServerUrl = value;
				OnPropertyChanged("ServerUrl");
			}
		}
		public string ServerUsername
		{
			get { return _ServerUsername; }
			set 
			{ 
				_ServerUsername = value;
				OnPropertyChanged("ServerUsername");
			}
		}
		public string ServerPassword
		{
			get { return _ServerPassword; }
			set 
			{ 
				_ServerPassword = value;
				OnPropertyChanged("ServerPassword");
			}
		}
		public string ServerPrivateKey
		{
			get { return _ServerPrivateKey; }
			set 
			{ 
				_ServerPrivateKey = value;
				OnPropertyChanged("ServerPrivateKey");
			}
		}
		public string ServerPublicKey
		{
			get { return _ServerPublicKey; }
			set 
			{ 
				_ServerPublicKey = value;
				OnPropertyChanged("ServerPublicKey");
			}
		}
		public string ServerPassPhrase
		{
			get { return _ServerPassPhrase; }
			set 
			{ 
				_ServerPassPhrase = value;
				OnPropertyChanged("ServerPassPhrase");
			}
		}
		public bool? FtpPassiveMode
		{
			get { return _FtpPassiveMode; }
			set 
			{ 
				_FtpPassiveMode = value;
				OnPropertyChanged("FtpPassiveMode");
			}
		}
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		public string SrcFileSyncId
		{
			get { return _SrcFileSyncId; }
			set 
			{ 
				_SrcFileSyncId = value;
				OnPropertyChanged("SrcFileSyncId");
			}
		}
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

		public StorageJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "serverUrl":
						this._ServerUrl = propertyNode.InnerText;
						continue;
					case "serverUsername":
						this._ServerUsername = propertyNode.InnerText;
						continue;
					case "serverPassword":
						this._ServerPassword = propertyNode.InnerText;
						continue;
					case "serverPrivateKey":
						this._ServerPrivateKey = propertyNode.InnerText;
						continue;
					case "serverPublicKey":
						this._ServerPublicKey = propertyNode.InnerText;
						continue;
					case "serverPassPhrase":
						this._ServerPassPhrase = propertyNode.InnerText;
						continue;
					case "ftpPassiveMode":
						this._FtpPassiveMode = ParseBool(propertyNode.InnerText);
						continue;
					case "srcFileSyncLocalPath":
						this._SrcFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "srcFileSyncId":
						this._SrcFileSyncId = propertyNode.InnerText;
						continue;
					case "destFileSyncStoredPath":
						this._DestFileSyncStoredPath = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaStorageJobData");
			kparams.AddIfNotNull("serverUrl", this._ServerUrl);
			kparams.AddIfNotNull("serverUsername", this._ServerUsername);
			kparams.AddIfNotNull("serverPassword", this._ServerPassword);
			kparams.AddIfNotNull("serverPrivateKey", this._ServerPrivateKey);
			kparams.AddIfNotNull("serverPublicKey", this._ServerPublicKey);
			kparams.AddIfNotNull("serverPassPhrase", this._ServerPassPhrase);
			kparams.AddIfNotNull("ftpPassiveMode", this._FtpPassiveMode);
			kparams.AddIfNotNull("srcFileSyncLocalPath", this._SrcFileSyncLocalPath);
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

