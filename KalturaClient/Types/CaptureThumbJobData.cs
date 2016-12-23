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
	public class CaptureThumbJobData : JobData
	{
		#region Constants
		public const string SRC_FILE_SYNC_LOCAL_PATH = "srcFileSyncLocalPath";
		public const string ACTUAL_SRC_FILE_SYNC_LOCAL_PATH = "actualSrcFileSyncLocalPath";
		public const string SRC_FILE_SYNC_REMOTE_URL = "srcFileSyncRemoteUrl";
		public const string THUMB_PARAMS_OUTPUT_ID = "thumbParamsOutputId";
		public const string THUMB_ASSET_ID = "thumbAssetId";
		public const string SRC_ASSET_ID = "srcAssetId";
		public const string SRC_ASSET_TYPE = "srcAssetType";
		public const string THUMB_PATH = "thumbPath";
		#endregion

		#region Private Fields
		private string _SrcFileSyncLocalPath = null;
		private string _ActualSrcFileSyncLocalPath = null;
		private string _SrcFileSyncRemoteUrl = null;
		private int _ThumbParamsOutputId = Int32.MinValue;
		private string _ThumbAssetId = null;
		private string _SrcAssetId = null;
		private AssetType _SrcAssetType = null;
		private string _ThumbPath = null;
		#endregion

		#region Properties
		public string SrcFileSyncLocalPath
		{
			get { return _SrcFileSyncLocalPath; }
			set 
			{ 
				_SrcFileSyncLocalPath = value;
				OnPropertyChanged("SrcFileSyncLocalPath");
			}
		}
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		public int ThumbParamsOutputId
		{
			get { return _ThumbParamsOutputId; }
			set 
			{ 
				_ThumbParamsOutputId = value;
				OnPropertyChanged("ThumbParamsOutputId");
			}
		}
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		public string SrcAssetId
		{
			get { return _SrcAssetId; }
			set 
			{ 
				_SrcAssetId = value;
				OnPropertyChanged("SrcAssetId");
			}
		}
		public AssetType SrcAssetType
		{
			get { return _SrcAssetType; }
			set 
			{ 
				_SrcAssetType = value;
				OnPropertyChanged("SrcAssetType");
			}
		}
		public string ThumbPath
		{
			get { return _ThumbPath; }
			set 
			{ 
				_ThumbPath = value;
				OnPropertyChanged("ThumbPath");
			}
		}
		#endregion

		#region CTor
		public CaptureThumbJobData()
		{
		}

		public CaptureThumbJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "srcFileSyncLocalPath":
						this._SrcFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "actualSrcFileSyncLocalPath":
						this._ActualSrcFileSyncLocalPath = propertyNode.InnerText;
						continue;
					case "srcFileSyncRemoteUrl":
						this._SrcFileSyncRemoteUrl = propertyNode.InnerText;
						continue;
					case "thumbParamsOutputId":
						this._ThumbParamsOutputId = ParseInt(propertyNode.InnerText);
						continue;
					case "thumbAssetId":
						this._ThumbAssetId = propertyNode.InnerText;
						continue;
					case "srcAssetId":
						this._SrcAssetId = propertyNode.InnerText;
						continue;
					case "srcAssetType":
						this._SrcAssetType = (AssetType)StringEnum.Parse(typeof(AssetType), propertyNode.InnerText);
						continue;
					case "thumbPath":
						this._ThumbPath = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaCaptureThumbJobData");
			kparams.AddIfNotNull("srcFileSyncLocalPath", this._SrcFileSyncLocalPath);
			kparams.AddIfNotNull("actualSrcFileSyncLocalPath", this._ActualSrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileSyncRemoteUrl", this._SrcFileSyncRemoteUrl);
			kparams.AddIfNotNull("thumbParamsOutputId", this._ThumbParamsOutputId);
			kparams.AddIfNotNull("thumbAssetId", this._ThumbAssetId);
			kparams.AddIfNotNull("srcAssetId", this._SrcAssetId);
			kparams.AddIfNotNull("srcAssetType", this._SrcAssetType);
			kparams.AddIfNotNull("thumbPath", this._ThumbPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SRC_FILE_SYNC_LOCAL_PATH:
					return "SrcFileSyncLocalPath";
				case ACTUAL_SRC_FILE_SYNC_LOCAL_PATH:
					return "ActualSrcFileSyncLocalPath";
				case SRC_FILE_SYNC_REMOTE_URL:
					return "SrcFileSyncRemoteUrl";
				case THUMB_PARAMS_OUTPUT_ID:
					return "ThumbParamsOutputId";
				case THUMB_ASSET_ID:
					return "ThumbAssetId";
				case SRC_ASSET_ID:
					return "SrcAssetId";
				case SRC_ASSET_TYPE:
					return "SrcAssetType";
				case THUMB_PATH:
					return "ThumbPath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

