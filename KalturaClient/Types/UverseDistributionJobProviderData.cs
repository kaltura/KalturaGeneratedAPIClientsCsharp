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
	public class UverseDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string LOCAL_ASSET_FILE_PATH = "localAssetFilePath";
		public const string REMOTE_ASSET_URL = "remoteAssetUrl";
		public const string REMOTE_ASSET_FILE_NAME = "remoteAssetFileName";
		#endregion

		#region Private Fields
		private string _LocalAssetFilePath = null;
		private string _RemoteAssetUrl = null;
		private string _RemoteAssetFileName = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string LocalAssetFilePath
		{
			get { return _LocalAssetFilePath; }
			set 
			{ 
				_LocalAssetFilePath = value;
				OnPropertyChanged("LocalAssetFilePath");
			}
		}
		[JsonProperty]
		public string RemoteAssetUrl
		{
			get { return _RemoteAssetUrl; }
			set 
			{ 
				_RemoteAssetUrl = value;
				OnPropertyChanged("RemoteAssetUrl");
			}
		}
		[JsonProperty]
		public string RemoteAssetFileName
		{
			get { return _RemoteAssetFileName; }
			set 
			{ 
				_RemoteAssetFileName = value;
				OnPropertyChanged("RemoteAssetFileName");
			}
		}
		#endregion

		#region CTor
		public UverseDistributionJobProviderData()
		{
		}

		public UverseDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["localAssetFilePath"] != null)
			{
				this._LocalAssetFilePath = node["localAssetFilePath"].Value<string>();
			}
			if(node["remoteAssetUrl"] != null)
			{
				this._RemoteAssetUrl = node["remoteAssetUrl"].Value<string>();
			}
			if(node["remoteAssetFileName"] != null)
			{
				this._RemoteAssetFileName = node["remoteAssetFileName"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaUverseDistributionJobProviderData");
			kparams.AddIfNotNull("localAssetFilePath", this._LocalAssetFilePath);
			kparams.AddIfNotNull("remoteAssetUrl", this._RemoteAssetUrl);
			kparams.AddIfNotNull("remoteAssetFileName", this._RemoteAssetFileName);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LOCAL_ASSET_FILE_PATH:
					return "LocalAssetFilePath";
				case REMOTE_ASSET_URL:
					return "RemoteAssetUrl";
				case REMOTE_ASSET_FILE_NAME:
					return "RemoteAssetFileName";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

