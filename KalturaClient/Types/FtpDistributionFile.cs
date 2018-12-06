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
	public class FtpDistributionFile : ObjectBase
	{
		#region Constants
		public const string ASSET_ID = "assetId";
		public const string FILENAME = "filename";
		public const string CONTENTS = "contents";
		public const string LOCAL_FILE_PATH = "localFilePath";
		public const string VERSION = "version";
		public const string HASH = "hash";
		#endregion

		#region Private Fields
		private string _AssetId = null;
		private string _Filename = null;
		private string _Contents = null;
		private string _LocalFilePath = null;
		private string _Version = null;
		private string _Hash = null;
		#endregion

		#region Properties
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		public string Contents
		{
			get { return _Contents; }
			set 
			{ 
				_Contents = value;
				OnPropertyChanged("Contents");
			}
		}
		public string LocalFilePath
		{
			get { return _LocalFilePath; }
			set 
			{ 
				_LocalFilePath = value;
				OnPropertyChanged("LocalFilePath");
			}
		}
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		public string Hash
		{
			get { return _Hash; }
			set 
			{ 
				_Hash = value;
				OnPropertyChanged("Hash");
			}
		}
		#endregion

		#region CTor
		public FtpDistributionFile()
		{
		}

		public FtpDistributionFile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "assetId":
						this._AssetId = propertyNode.InnerText;
						continue;
					case "filename":
						this._Filename = propertyNode.InnerText;
						continue;
					case "contents":
						this._Contents = propertyNode.InnerText;
						continue;
					case "localFilePath":
						this._LocalFilePath = propertyNode.InnerText;
						continue;
					case "version":
						this._Version = propertyNode.InnerText;
						continue;
					case "hash":
						this._Hash = propertyNode.InnerText;
						continue;
				}
			}
		}

		public FtpDistributionFile(IDictionary<string,object> data) : base(data)
		{
			    this._AssetId = data.TryGetValueSafe<string>("assetId");
			    this._Filename = data.TryGetValueSafe<string>("filename");
			    this._Contents = data.TryGetValueSafe<string>("contents");
			    this._LocalFilePath = data.TryGetValueSafe<string>("localFilePath");
			    this._Version = data.TryGetValueSafe<string>("version");
			    this._Hash = data.TryGetValueSafe<string>("hash");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFtpDistributionFile");
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("filename", this._Filename);
			kparams.AddIfNotNull("contents", this._Contents);
			kparams.AddIfNotNull("localFilePath", this._LocalFilePath);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("hash", this._Hash);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_ID:
					return "AssetId";
				case FILENAME:
					return "Filename";
				case CONTENTS:
					return "Contents";
				case LOCAL_FILE_PATH:
					return "LocalFilePath";
				case VERSION:
					return "Version";
				case HASH:
					return "Hash";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

