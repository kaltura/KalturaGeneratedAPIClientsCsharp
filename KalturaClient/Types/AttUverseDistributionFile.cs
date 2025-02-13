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
	public class AttUverseDistributionFile : ObjectBase
	{
		#region Constants
		public const string REMOTE_FILENAME = "remoteFilename";
		public const string LOCAL_FILE_PATH = "localFilePath";
		public const string ASSET_TYPE = "assetType";
		public const string ASSET_ID = "assetId";
		#endregion

		#region Private Fields
		private string _RemoteFilename = null;
		private string _LocalFilePath = null;
		private AssetType _AssetType = null;
		private string _AssetId = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string RemoteFilename
		{
			get { return _RemoteFilename; }
			set 
			{ 
				_RemoteFilename = value;
				OnPropertyChanged("RemoteFilename");
			}
		}
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
		[JsonProperty]
		public AssetType AssetType
		{
			get { return _AssetType; }
			set 
			{ 
				_AssetType = value;
				OnPropertyChanged("AssetType");
			}
		}
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
		#endregion

		#region CTor
		public AttUverseDistributionFile()
		{
		}

		public AttUverseDistributionFile(JToken node) : base(node)
		{
			if(node["remoteFilename"] != null)
			{
				this._RemoteFilename = node["remoteFilename"].Value<string>();
			}
			if(node["localFilePath"] != null)
			{
				this._LocalFilePath = node["localFilePath"].Value<string>();
			}
			if(node["assetType"] != null)
			{
				this._AssetType = (AssetType)StringEnum.Parse(typeof(AssetType), node["assetType"].Value<string>());
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAttUverseDistributionFile");
			kparams.AddIfNotNull("remoteFilename", this._RemoteFilename);
			kparams.AddIfNotNull("localFilePath", this._LocalFilePath);
			kparams.AddIfNotNull("assetType", this._AssetType);
			kparams.AddIfNotNull("assetId", this._AssetId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case REMOTE_FILENAME:
					return "RemoteFilename";
				case LOCAL_FILE_PATH:
					return "LocalFilePath";
				case ASSET_TYPE:
					return "AssetType";
				case ASSET_ID:
					return "AssetId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

