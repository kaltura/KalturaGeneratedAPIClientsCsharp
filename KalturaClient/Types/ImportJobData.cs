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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class ImportJobData : JobData
	{
		#region Constants
		public const string SRC_FILE_URL = "srcFileUrl";
		public const string DEST_FILE_LOCAL_PATH = "destFileLocalPath";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FILE_SIZE = "fileSize";
		#endregion

		#region Private Fields
		private string _SrcFileUrl = null;
		private string _DestFileLocalPath = null;
		private string _FlavorAssetId = null;
		private int _FileSize = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public string SrcFileUrl
		{
			get { return _SrcFileUrl; }
			set 
			{ 
				_SrcFileUrl = value;
				OnPropertyChanged("SrcFileUrl");
			}
		}
		[JsonProperty]
		public string DestFileLocalPath
		{
			get { return _DestFileLocalPath; }
			set 
			{ 
				_DestFileLocalPath = value;
				OnPropertyChanged("DestFileLocalPath");
			}
		}
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		[JsonProperty]
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		#endregion

		#region CTor
		public ImportJobData()
		{
		}

		public ImportJobData(JToken node) : base(node)
		{
			if(node["srcFileUrl"] != null)
			{
				this._SrcFileUrl = node["srcFileUrl"].Value<string>();
			}
			if(node["destFileLocalPath"] != null)
			{
				this._DestFileLocalPath = node["destFileLocalPath"].Value<string>();
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseInt(node["fileSize"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaImportJobData");
			kparams.AddIfNotNull("srcFileUrl", this._SrcFileUrl);
			kparams.AddIfNotNull("destFileLocalPath", this._DestFileLocalPath);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILE_URL:
					return "SrcFileUrl";
				case DEST_FILE_LOCAL_PATH:
					return "DestFileLocalPath";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FILE_SIZE:
					return "FileSize";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

