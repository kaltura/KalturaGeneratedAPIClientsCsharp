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
	public class ConvertLiveSegmentJobData : JobData
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string ASSET_ID = "assetId";
		public const string MEDIA_SERVER_INDEX = "mediaServerIndex";
		public const string FILE_INDEX = "fileIndex";
		public const string SRC_FILE_PATH = "srcFilePath";
		public const string DEST_FILE_PATH = "destFilePath";
		public const string END_TIME = "endTime";
		public const string DEST_DATA_FILE_PATH = "destDataFilePath";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private string _AssetId = null;
		private EntryServerNodeType _MediaServerIndex = null;
		private int _FileIndex = Int32.MinValue;
		private string _SrcFilePath = null;
		private string _DestFilePath = null;
		private float _EndTime = Single.MinValue;
		private string _DestDataFilePath = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
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
		public EntryServerNodeType MediaServerIndex
		{
			get { return _MediaServerIndex; }
			set 
			{ 
				_MediaServerIndex = value;
				OnPropertyChanged("MediaServerIndex");
			}
		}
		[JsonProperty]
		public int FileIndex
		{
			get { return _FileIndex; }
			set 
			{ 
				_FileIndex = value;
				OnPropertyChanged("FileIndex");
			}
		}
		[JsonProperty]
		public string SrcFilePath
		{
			get { return _SrcFilePath; }
			set 
			{ 
				_SrcFilePath = value;
				OnPropertyChanged("SrcFilePath");
			}
		}
		[JsonProperty]
		public string DestFilePath
		{
			get { return _DestFilePath; }
			set 
			{ 
				_DestFilePath = value;
				OnPropertyChanged("DestFilePath");
			}
		}
		[JsonProperty]
		public float EndTime
		{
			get { return _EndTime; }
			set 
			{ 
				_EndTime = value;
				OnPropertyChanged("EndTime");
			}
		}
		[JsonProperty]
		public string DestDataFilePath
		{
			get { return _DestDataFilePath; }
			set 
			{ 
				_DestDataFilePath = value;
				OnPropertyChanged("DestDataFilePath");
			}
		}
		#endregion

		#region CTor
		public ConvertLiveSegmentJobData()
		{
		}

		public ConvertLiveSegmentJobData(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
			if(node["mediaServerIndex"] != null)
			{
				this._MediaServerIndex = (EntryServerNodeType)StringEnum.Parse(typeof(EntryServerNodeType), node["mediaServerIndex"].Value<string>());
			}
			if(node["fileIndex"] != null)
			{
				this._FileIndex = ParseInt(node["fileIndex"].Value<string>());
			}
			if(node["srcFilePath"] != null)
			{
				this._SrcFilePath = node["srcFilePath"].Value<string>();
			}
			if(node["destFilePath"] != null)
			{
				this._DestFilePath = node["destFilePath"].Value<string>();
			}
			if(node["endTime"] != null)
			{
				this._EndTime = ParseFloat(node["endTime"].Value<string>());
			}
			if(node["destDataFilePath"] != null)
			{
				this._DestDataFilePath = node["destDataFilePath"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConvertLiveSegmentJobData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("assetId", this._AssetId);
			kparams.AddIfNotNull("mediaServerIndex", this._MediaServerIndex);
			kparams.AddIfNotNull("fileIndex", this._FileIndex);
			kparams.AddIfNotNull("srcFilePath", this._SrcFilePath);
			kparams.AddIfNotNull("destFilePath", this._DestFilePath);
			kparams.AddIfNotNull("endTime", this._EndTime);
			kparams.AddIfNotNull("destDataFilePath", this._DestDataFilePath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case ASSET_ID:
					return "AssetId";
				case MEDIA_SERVER_INDEX:
					return "MediaServerIndex";
				case FILE_INDEX:
					return "FileIndex";
				case SRC_FILE_PATH:
					return "SrcFilePath";
				case DEST_FILE_PATH:
					return "DestFilePath";
				case END_TIME:
					return "EndTime";
				case DEST_DATA_FILE_PATH:
					return "DestDataFilePath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

