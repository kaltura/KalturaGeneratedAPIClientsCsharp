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
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		public string AssetParamsVersion
		{
			get { return _AssetParamsVersion; }
			set 
			{ 
				_AssetParamsVersion = value;
				OnPropertyChanged("AssetParamsVersion");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string AssetVersion
		{
			get { return _AssetVersion; }
			set 
			{ 
				_AssetVersion = value;
				OnPropertyChanged("AssetVersion");
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

		public AssetParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetParamsId":
						this._AssetParamsId = ParseInt(txt);
						continue;
					case "assetParamsVersion":
						this._AssetParamsVersion = txt;
						continue;
					case "assetId":
						this._AssetId = txt;
						continue;
					case "assetVersion":
						this._AssetVersion = txt;
						continue;
					case "readyBehavior":
						this._ReadyBehavior = ParseInt(txt);
						continue;
					case "format":
						this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), txt);
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

