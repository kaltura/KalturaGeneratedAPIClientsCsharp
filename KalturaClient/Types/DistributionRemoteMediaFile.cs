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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class DistributionRemoteMediaFile : ObjectBase
	{
		#region Constants
		public const string VERSION = "version";
		public const string ASSET_ID = "assetId";
		public const string REMOTE_ID = "remoteId";
		#endregion

		#region Private Fields
		private string _Version = null;
		private string _AssetId = null;
		private string _RemoteId = null;
		#endregion

		#region Properties
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
		/// Use RemoteIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RemoteId
		{
			get { return _RemoteId; }
			set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		#endregion

		#region CTor
		public DistributionRemoteMediaFile()
		{
		}

		public DistributionRemoteMediaFile(JToken node) : base(node)
		{
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["remoteId"] != null)
			{
				this._RemoteId = node["remoteId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDistributionRemoteMediaFile");
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("remoteId", this._RemoteId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VERSION:
					return "Version";
				case ASSET_ID:
					return "AssetId";
				case REMOTE_ID:
					return "RemoteId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

