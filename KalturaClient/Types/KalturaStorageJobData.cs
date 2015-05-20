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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaStorageJobData : KalturaJobData
	{
		#region Private Fields
		private string _ServerUrl = null;
		private string _ServerUsername = null;
		private string _ServerPassword = null;
		private string _ServerPrivateKey = null;
		private string _ServerPublicKey = null;
		private string _ServerPassPhrase = null;
		private bool? _FtpPassiveMode = false;
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
		public KalturaStorageJobData()
		{
		}

		public KalturaStorageJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "serverUrl":
						this.ServerUrl = txt;
						continue;
					case "serverUsername":
						this.ServerUsername = txt;
						continue;
					case "serverPassword":
						this.ServerPassword = txt;
						continue;
					case "serverPrivateKey":
						this.ServerPrivateKey = txt;
						continue;
					case "serverPublicKey":
						this.ServerPublicKey = txt;
						continue;
					case "serverPassPhrase":
						this.ServerPassPhrase = txt;
						continue;
					case "ftpPassiveMode":
						this.FtpPassiveMode = ParseBool(txt);
						continue;
					case "srcFileSyncLocalPath":
						this.SrcFileSyncLocalPath = txt;
						continue;
					case "srcFileSyncId":
						this.SrcFileSyncId = txt;
						continue;
					case "destFileSyncStoredPath":
						this.DestFileSyncStoredPath = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaStorageJobData");
			kparams.AddStringIfNotNull("serverUrl", this.ServerUrl);
			kparams.AddStringIfNotNull("serverUsername", this.ServerUsername);
			kparams.AddStringIfNotNull("serverPassword", this.ServerPassword);
			kparams.AddStringIfNotNull("serverPrivateKey", this.ServerPrivateKey);
			kparams.AddStringIfNotNull("serverPublicKey", this.ServerPublicKey);
			kparams.AddStringIfNotNull("serverPassPhrase", this.ServerPassPhrase);
			kparams.AddBoolIfNotNull("ftpPassiveMode", this.FtpPassiveMode);
			kparams.AddStringIfNotNull("srcFileSyncLocalPath", this.SrcFileSyncLocalPath);
			kparams.AddStringIfNotNull("srcFileSyncId", this.SrcFileSyncId);
			kparams.AddStringIfNotNull("destFileSyncStoredPath", this.DestFileSyncStoredPath);
			return kparams;
		}
		#endregion
	}
}

