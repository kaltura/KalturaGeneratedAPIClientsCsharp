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
	public class FileSyncDescriptor : ObjectBase
	{
		#region Constants
		public const string FILE_SYNC_LOCAL_PATH = "fileSyncLocalPath";
		public const string FILE_ENCRYPTION_KEY = "fileEncryptionKey";
		public const string FILE_SYNC_REMOTE_URL = "fileSyncRemoteUrl";
		public const string FILE_SYNC_OBJECT_SUB_TYPE = "fileSyncObjectSubType";
		#endregion

		#region Private Fields
		private string _FileSyncLocalPath = null;
		private string _FileEncryptionKey = null;
		private string _FileSyncRemoteUrl = null;
		private int _FileSyncObjectSubType = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string FileSyncLocalPath
		{
			get { return _FileSyncLocalPath; }
			set 
			{ 
				_FileSyncLocalPath = value;
				OnPropertyChanged("FileSyncLocalPath");
			}
		}
		[JsonProperty]
		public string FileEncryptionKey
		{
			get { return _FileEncryptionKey; }
			set 
			{ 
				_FileEncryptionKey = value;
				OnPropertyChanged("FileEncryptionKey");
			}
		}
		[JsonProperty]
		public string FileSyncRemoteUrl
		{
			get { return _FileSyncRemoteUrl; }
			set 
			{ 
				_FileSyncRemoteUrl = value;
				OnPropertyChanged("FileSyncRemoteUrl");
			}
		}
		[JsonProperty]
		public int FileSyncObjectSubType
		{
			get { return _FileSyncObjectSubType; }
			set 
			{ 
				_FileSyncObjectSubType = value;
				OnPropertyChanged("FileSyncObjectSubType");
			}
		}
		#endregion

		#region CTor
		public FileSyncDescriptor()
		{
		}

		public FileSyncDescriptor(JToken node) : base(node)
		{
			if(node["fileSyncLocalPath"] != null)
			{
				this._FileSyncLocalPath = node["fileSyncLocalPath"].Value<string>();
			}
			if(node["fileEncryptionKey"] != null)
			{
				this._FileEncryptionKey = node["fileEncryptionKey"].Value<string>();
			}
			if(node["fileSyncRemoteUrl"] != null)
			{
				this._FileSyncRemoteUrl = node["fileSyncRemoteUrl"].Value<string>();
			}
			if(node["fileSyncObjectSubType"] != null)
			{
				this._FileSyncObjectSubType = ParseInt(node["fileSyncObjectSubType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFileSyncDescriptor");
			kparams.AddIfNotNull("fileSyncLocalPath", this._FileSyncLocalPath);
			kparams.AddIfNotNull("fileEncryptionKey", this._FileEncryptionKey);
			kparams.AddIfNotNull("fileSyncRemoteUrl", this._FileSyncRemoteUrl);
			kparams.AddIfNotNull("fileSyncObjectSubType", this._FileSyncObjectSubType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_SYNC_LOCAL_PATH:
					return "FileSyncLocalPath";
				case FILE_ENCRYPTION_KEY:
					return "FileEncryptionKey";
				case FILE_SYNC_REMOTE_URL:
					return "FileSyncRemoteUrl";
				case FILE_SYNC_OBJECT_SUB_TYPE:
					return "FileSyncObjectSubType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

