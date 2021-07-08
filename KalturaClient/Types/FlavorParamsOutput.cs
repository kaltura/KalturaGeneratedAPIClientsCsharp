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
	public class FlavorParamsOutput : FlavorParams
	{
		#region Constants
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string COMMAND_LINES_STR = "commandLinesStr";
		public const string FLAVOR_PARAMS_VERSION = "flavorParamsVersion";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FLAVOR_ASSET_VERSION = "flavorAssetVersion";
		public const string READY_BEHAVIOR = "readyBehavior";
		#endregion

		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private string _CommandLinesStr = null;
		private string _FlavorParamsVersion = null;
		private string _FlavorAssetId = null;
		private string _FlavorAssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use FlavorParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		/// <summary>
		/// Use CommandLinesStrAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		/// <summary>
		/// Use FlavorParamsVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorParamsVersion
		{
			get { return _FlavorParamsVersion; }
			set 
			{ 
				_FlavorParamsVersion = value;
				OnPropertyChanged("FlavorParamsVersion");
			}
		}
		/// <summary>
		/// Use FlavorAssetIdAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use FlavorAssetVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetVersion
		{
			get { return _FlavorAssetVersion; }
			set 
			{ 
				_FlavorAssetVersion = value;
				OnPropertyChanged("FlavorAssetVersion");
			}
		}
		/// <summary>
		/// Use ReadyBehaviorAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public FlavorParamsOutput()
		{
		}

		public FlavorParamsOutput(JToken node) : base(node)
		{
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
			if(node["commandLinesStr"] != null)
			{
				this._CommandLinesStr = node["commandLinesStr"].Value<string>();
			}
			if(node["flavorParamsVersion"] != null)
			{
				this._FlavorParamsVersion = node["flavorParamsVersion"].Value<string>();
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["flavorAssetVersion"] != null)
			{
				this._FlavorAssetVersion = node["flavorAssetVersion"].Value<string>();
			}
			if(node["readyBehavior"] != null)
			{
				this._ReadyBehavior = ParseInt(node["readyBehavior"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorParamsOutput");
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			kparams.AddIfNotNull("commandLinesStr", this._CommandLinesStr);
			kparams.AddIfNotNull("flavorParamsVersion", this._FlavorParamsVersion);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("flavorAssetVersion", this._FlavorAssetVersion);
			kparams.AddIfNotNull("readyBehavior", this._ReadyBehavior);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				case COMMAND_LINES_STR:
					return "CommandLinesStr";
				case FLAVOR_PARAMS_VERSION:
					return "FlavorParamsVersion";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FLAVOR_ASSET_VERSION:
					return "FlavorAssetVersion";
				case READY_BEHAVIOR:
					return "ReadyBehavior";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

