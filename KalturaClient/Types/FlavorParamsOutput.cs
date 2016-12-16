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
// Copyright (C) 2006-2016  Kaltura Inc.
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
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public string CommandLinesStr
		{
			get { return _CommandLinesStr; }
			set 
			{ 
				_CommandLinesStr = value;
				OnPropertyChanged("CommandLinesStr");
			}
		}
		public string FlavorParamsVersion
		{
			get { return _FlavorParamsVersion; }
			set 
			{ 
				_FlavorParamsVersion = value;
				OnPropertyChanged("FlavorParamsVersion");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string FlavorAssetVersion
		{
			get { return _FlavorAssetVersion; }
			set 
			{ 
				_FlavorAssetVersion = value;
				OnPropertyChanged("FlavorAssetVersion");
			}
		}
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

		public FlavorParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this._FlavorParamsId = ParseInt(txt);
						continue;
					case "commandLinesStr":
						this._CommandLinesStr = txt;
						continue;
					case "flavorParamsVersion":
						this._FlavorParamsVersion = txt;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "flavorAssetVersion":
						this._FlavorAssetVersion = txt;
						continue;
					case "readyBehavior":
						this._ReadyBehavior = ParseInt(txt);
						continue;
				}
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

