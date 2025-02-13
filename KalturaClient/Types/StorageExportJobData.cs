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
	public class StorageExportJobData : StorageJobData
	{
		#region Constants
		public const string FORCE = "force";
		public const string CREATE_LINK = "createLink";
		public const string ASSET_ID = "assetId";
		public const string EXTERNAL_URL = "externalUrl";
		#endregion

		#region Private Fields
		private bool? _Force = null;
		private bool? _CreateLink = null;
		private string _AssetId = null;
		private string _ExternalUrl = null;
		#endregion

		#region Properties
		[JsonProperty]
		public bool? Force
		{
			get { return _Force; }
			set 
			{ 
				_Force = value;
				OnPropertyChanged("Force");
			}
		}
		[JsonProperty]
		public bool? CreateLink
		{
			get { return _CreateLink; }
			set 
			{ 
				_CreateLink = value;
				OnPropertyChanged("CreateLink");
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
		[JsonProperty]
		public string ExternalUrl
		{
			get { return _ExternalUrl; }
			set 
			{ 
				_ExternalUrl = value;
				OnPropertyChanged("ExternalUrl");
			}
		}
		#endregion

		#region CTor
		public StorageExportJobData()
		{
		}

		public StorageExportJobData(JToken node) : base(node)
		{
			if(node["force"] != null)
			{
				this._Force = ParseBool(node["force"].Value<string>());
			}
			if(node["createLink"] != null)
			{
				this._CreateLink = ParseBool(node["createLink"].Value<string>());
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["externalUrl"] != null)
			{
				this._ExternalUrl = node["externalUrl"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaStorageExportJobData");
			kparams.AddIfNotNull("force", this._Force);
			kparams.AddIfNotNull("createLink", this._CreateLink);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("externalUrl", this._ExternalUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FORCE:
					return "Force";
				case CREATE_LINK:
					return "CreateLink";
				case ASSET_ID:
					return "AssetId";
				case EXTERNAL_URL:
					return "ExternalUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

