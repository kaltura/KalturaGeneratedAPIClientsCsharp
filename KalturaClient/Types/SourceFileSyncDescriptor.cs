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
	public class SourceFileSyncDescriptor : FileSyncDescriptor
	{
		#region Constants
		public const string ACTUAL_FILE_SYNC_LOCAL_PATH = "actualFileSyncLocalPath";
		public const string ASSET_ID = "assetId";
		public const string ASSET_PARAMS_ID = "assetParamsId";
		#endregion

		#region Private Fields
		private string _ActualFileSyncLocalPath = null;
		private string _AssetId = null;
		private int _AssetParamsId = Int32.MinValue;
		#endregion

		#region Properties
		public string ActualFileSyncLocalPath
		{
			get { return _ActualFileSyncLocalPath; }
			set 
			{ 
				_ActualFileSyncLocalPath = value;
				OnPropertyChanged("ActualFileSyncLocalPath");
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
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		#endregion

		#region CTor
		public SourceFileSyncDescriptor()
		{
		}

		public SourceFileSyncDescriptor(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "actualFileSyncLocalPath":
						this._ActualFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "assetId":
						this._AssetId = propertyNode.InnerText;
						continue;
					case "assetParamsId":
						this._AssetParamsId = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaSourceFileSyncDescriptor");
			kparams.AddIfNotNull("actualFileSyncLocalPath", this._ActualFileSyncLocalPath);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("assetParamsId", this._AssetParamsId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACTUAL_FILE_SYNC_LOCAL_PATH:
					return "ActualFileSyncLocalPath";
				case ASSET_ID:
					return "AssetId";
				case ASSET_PARAMS_ID:
					return "AssetParamsId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

