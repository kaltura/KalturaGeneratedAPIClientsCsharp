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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class CaptureThumbJobData : JobData
	{
		#region Constants
		public const string FILE_CONTAINER = "fileContainer";
		public const string ACTUAL_SRC_FILE_SYNC_LOCAL_PATH = "actualSrcFileSyncLocalPath";
		public const string SRC_FILE_SYNC_REMOTE_URL = "srcFileSyncRemoteUrl";
		public const string THUMB_PARAMS_OUTPUT_ID = "thumbParamsOutputId";
		public const string THUMB_ASSET_ID = "thumbAssetId";
		public const string SRC_ASSET_ID = "srcAssetId";
		public const string SRC_ASSET_ENCRYPTION_KEY = "srcAssetEncryptionKey";
		public const string SRC_ASSET_TYPE = "srcAssetType";
		public const string THUMB_PATH = "thumbPath";
		#endregion

		#region Private Fields
		private FileContainer _FileContainer;
		private string _ActualSrcFileSyncLocalPath = null;
		private string _SrcFileSyncRemoteUrl = null;
		private int _ThumbParamsOutputId = Int32.MinValue;
		private string _ThumbAssetId = null;
		private string _SrcAssetId = null;
		private string _SrcAssetEncryptionKey = null;
		private AssetType _SrcAssetType = null;
		private string _ThumbPath = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use FileContainerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FileContainer FileContainer
		{
			get { return _FileContainer; }
			set 
			{ 
				_FileContainer = value;
				OnPropertyChanged("FileContainer");
			}
		}
		/// <summary>
		/// Use ActualSrcFileSyncLocalPathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ActualSrcFileSyncLocalPath
		{
			get { return _ActualSrcFileSyncLocalPath; }
			set 
			{ 
				_ActualSrcFileSyncLocalPath = value;
				OnPropertyChanged("ActualSrcFileSyncLocalPath");
			}
		}
		/// <summary>
		/// Use SrcFileSyncRemoteUrlAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcFileSyncRemoteUrl
		{
			get { return _SrcFileSyncRemoteUrl; }
			set 
			{ 
				_SrcFileSyncRemoteUrl = value;
				OnPropertyChanged("SrcFileSyncRemoteUrl");
			}
		}
		/// <summary>
		/// Use ThumbParamsOutputIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ThumbParamsOutputId
		{
			get { return _ThumbParamsOutputId; }
			set 
			{ 
				_ThumbParamsOutputId = value;
				OnPropertyChanged("ThumbParamsOutputId");
			}
		}
		/// <summary>
		/// Use ThumbAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ThumbAssetId
		{
			get { return _ThumbAssetId; }
			set 
			{ 
				_ThumbAssetId = value;
				OnPropertyChanged("ThumbAssetId");
			}
		}
		/// <summary>
		/// Use SrcAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcAssetId
		{
			get { return _SrcAssetId; }
			set 
			{ 
				_SrcAssetId = value;
				OnPropertyChanged("SrcAssetId");
			}
		}
		/// <summary>
		/// Use SrcAssetEncryptionKeyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SrcAssetEncryptionKey
		{
			get { return _SrcAssetEncryptionKey; }
			set 
			{ 
				_SrcAssetEncryptionKey = value;
				OnPropertyChanged("SrcAssetEncryptionKey");
			}
		}
		/// <summary>
		/// Use SrcAssetTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AssetType SrcAssetType
		{
			get { return _SrcAssetType; }
			set 
			{ 
				_SrcAssetType = value;
				OnPropertyChanged("SrcAssetType");
			}
		}
		/// <summary>
		/// Use ThumbPathAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public CaptureThumbJobData(JToken node) : base(node)
		{
			if(node["fileContainer"] != null)
			{
				this._FileContainer = ObjectFactory.Create<FileContainer>(node["fileContainer"]);
			}
			if(node["actualSrcFileSyncLocalPath"] != null)
			{
				this._ActualSrcFileSyncLocalPath = node["actualSrcFileSyncLocalPath"].Value<string>();
			}
			if(node["srcFileSyncRemoteUrl"] != null)
			{
				this._SrcFileSyncRemoteUrl = node["srcFileSyncRemoteUrl"].Value<string>();
			}
			if(node["thumbParamsOutputId"] != null)
			{
				this._ThumbParamsOutputId = ParseInt(node["thumbParamsOutputId"].Value<string>());
			}
			if(node["thumbAssetId"] != null)
			{
				this._ThumbAssetId = node["thumbAssetId"].Value<string>();
			}
			if(node["srcAssetId"] != null)
			{
				this._SrcAssetId = node["srcAssetId"].Value<string>();
			}
			if(node["srcAssetEncryptionKey"] != null)
			{
				this._SrcAssetEncryptionKey = node["srcAssetEncryptionKey"].Value<string>();
			}
			if(node["srcAssetType"] != null)
			{
				this._SrcAssetType = (AssetType)StringEnum.Parse(typeof(AssetType), node["srcAssetType"].Value<string>());
			}
			if(node["thumbPath"] != null)
			{
				this._ThumbPath = node["thumbPath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptureThumbJobData");
			kparams.AddIfNotNull("fileContainer", this._FileContainer);
			kparams.AddIfNotNull("actualSrcFileSyncLocalPath", this._ActualSrcFileSyncLocalPath);
			kparams.AddIfNotNull("srcFileSyncRemoteUrl", this._SrcFileSyncRemoteUrl);
			kparams.AddIfNotNull("thumbParamsOutputId", this._ThumbParamsOutputId);
			kparams.AddIfNotNull("thumbAssetId", this._ThumbAssetId);
			kparams.AddIfNotNull("srcAssetId", this._SrcAssetId);
			kparams.AddIfNotNull("srcAssetEncryptionKey", this._SrcAssetEncryptionKey);
			kparams.AddIfNotNull("srcAssetType", this._SrcAssetType);
			kparams.AddIfNotNull("thumbPath", this._ThumbPath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILE_CONTAINER:
					return "FileContainer";
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
				case SRC_ASSET_ENCRYPTION_KEY:
					return "SrcAssetEncryptionKey";
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

