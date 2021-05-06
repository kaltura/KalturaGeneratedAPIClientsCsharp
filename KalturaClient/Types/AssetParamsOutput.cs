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
	public class AssetParamsOutput : AssetParams
	{
		#region Constants
		public const string ASSET_PARAMS_ID = "assetParamsId";
		public const string ASSET_PARAMS_VERSION = "assetParamsVersion";
		public const string ASSET_ID = "assetId";
		public const string ASSET_VERSION = "assetVersion";
		public const string READY_BEHAVIOR = "readyBehavior";
		public const string FORMAT = "format";
		#endregion

		#region Private Fields
		private int _AssetParamsId = Int32.MinValue;
		private string _AssetParamsVersion = null;
		private string _AssetId = null;
		private string _AssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		private ContainerFormat _Format = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		[JsonProperty]
		public string AssetParamsVersion
		{
			get { return _AssetParamsVersion; }
			set 
			{ 
				_AssetParamsVersion = value;
				OnPropertyChanged("AssetParamsVersion");
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
		public string AssetVersion
		{
			get { return _AssetVersion; }
			set 
			{ 
				_AssetVersion = value;
				OnPropertyChanged("AssetVersion");
			}
		}
		[JsonProperty]
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		[JsonProperty]
		public ContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		#endregion

		#region CTor
		public AssetParamsOutput()
		{
		}

		public AssetParamsOutput(JToken node) : base(node)
		{
			if(node["assetParamsId"] != null)
			{
				this._AssetParamsId = ParseInt(node["assetParamsId"].Value<string>());
			}
			if(node["assetParamsVersion"] != null)
			{
				this._AssetParamsVersion = node["assetParamsVersion"].Value<string>();
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["assetVersion"] != null)
			{
				this._AssetVersion = node["assetVersion"].Value<string>();
			}
			if(node["readyBehavior"] != null)
			{
				this._ReadyBehavior = ParseInt(node["readyBehavior"].Value<string>());
			}
			if(node["format"] != null)
			{
				this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), node["format"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaAssetParamsOutput");
			kparams.AddIfNotNull("assetParamsId", this._AssetParamsId);
			kparams.AddIfNotNull("assetParamsVersion", this._AssetParamsVersion);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetVersion", this._AssetVersion);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			kparams.AddIfNotNull("format", this._Format);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_PARAMS_ID:
					return "AssetParamsId";
				case ASSET_PARAMS_VERSION:
					return "AssetParamsVersion";
				case ASSET_ID:
					return "AssetId";
				case ASSET_VERSION:
					return "AssetVersion";
				case READY_BEHAVIOR:
					return "ReadyBehavior";
				case FORMAT:
					return "Format";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

