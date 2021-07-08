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
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		/// <summary>
		/// Use FilenameAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Filename
		{
			get { return _Filename; }
			set 
			{ 
				_Filename = value;
				OnPropertyChanged("Filename");
			}
		}
		/// <summary>
		/// Use ContentsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Contents
		{
			get { return _Contents; }
			set 
			{ 
				_Contents = value;
				OnPropertyChanged("Contents");
			}
		}
		/// <summary>
		/// Use LocalFilePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string LocalFilePath
		{
			get { return _LocalFilePath; }
			set 
			{ 
				_LocalFilePath = value;
				OnPropertyChanged("LocalFilePath");
			}
		}
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use HashAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public FtpDistributionFile(JToken node) : base(node)
		{
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["filename"] != null)
			{
				this._Filename = node["filename"].Value<string>();
			}
			if(node["contents"] != null)
			{
				this._Contents = node["contents"].Value<string>();
			}
			if(node["localFilePath"] != null)
			{
				this._LocalFilePath = node["localFilePath"].Value<string>();
			}
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["hash"] != null)
			{
				this._Hash = node["hash"].Value<string>();
			}
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

