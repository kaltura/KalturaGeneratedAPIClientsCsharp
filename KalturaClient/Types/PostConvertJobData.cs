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
// Copyright (C) 2006-2020  Kaltura Inc.
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
	public class PostConvertJobData : ConvartableJobData
	{
		#region Constants
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FLAVOR_ASSET_ENCRYPTION_KEY = "flavorAssetEncryptionKey";
		public const string CREATE_THUMB = "createThumb";
		public const string THUMB_PATH = "thumbPath";
		public const string THUMB_OFFSET = "thumbOffset";
		public const string THUMB_HEIGHT = "thumbHeight";
		public const string THUMB_BITRATE = "thumbBitrate";
		public const string CUSTOM_DATA = "customData";
		#endregion

		#region Private Fields
		private string _FlavorAssetId = null;
		private string _FlavorAssetEncryptionKey = null;
		private bool? _CreateThumb = null;
		private string _ThumbPath = null;
		private int _ThumbOffset = Int32.MinValue;
		private int _ThumbHeight = Int32.MinValue;
		private int _ThumbBitrate = Int32.MinValue;
		private string _CustomData = null;
		#endregion

		#region Properties
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
		[JsonProperty]
		public string FlavorAssetEncryptionKey
		{
			get { return _FlavorAssetEncryptionKey; }
			set 
			{ 
				_FlavorAssetEncryptionKey = value;
				OnPropertyChanged("FlavorAssetEncryptionKey");
			}
		}
		[JsonProperty]
		public bool? CreateThumb
		{
			get { return _CreateThumb; }
			set 
			{ 
				_CreateThumb = value;
				OnPropertyChanged("CreateThumb");
			}
		}
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
		[JsonProperty]
		public int ThumbOffset
		{
			get { return _ThumbOffset; }
			set 
			{ 
				_ThumbOffset = value;
				OnPropertyChanged("ThumbOffset");
			}
		}
		[JsonProperty]
		public int ThumbHeight
		{
			get { return _ThumbHeight; }
			set 
			{ 
				_ThumbHeight = value;
				OnPropertyChanged("ThumbHeight");
			}
		}
		[JsonProperty]
		public int ThumbBitrate
		{
			get { return _ThumbBitrate; }
			set 
			{ 
				_ThumbBitrate = value;
				OnPropertyChanged("ThumbBitrate");
			}
		}
		[JsonProperty]
		public string CustomData
		{
			get { return _CustomData; }
			set 
			{ 
				_CustomData = value;
				OnPropertyChanged("CustomData");
			}
		}
		#endregion

		#region CTor
		public PostConvertJobData()
		{
		}

		public PostConvertJobData(JToken node) : base(node)
		{
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["flavorAssetEncryptionKey"] != null)
			{
				this._FlavorAssetEncryptionKey = node["flavorAssetEncryptionKey"].Value<string>();
			}
			if(node["createThumb"] != null)
			{
				this._CreateThumb = ParseBool(node["createThumb"].Value<string>());
			}
			if(node["thumbPath"] != null)
			{
				this._ThumbPath = node["thumbPath"].Value<string>();
			}
			if(node["thumbOffset"] != null)
			{
				this._ThumbOffset = ParseInt(node["thumbOffset"].Value<string>());
			}
			if(node["thumbHeight"] != null)
			{
				this._ThumbHeight = ParseInt(node["thumbHeight"].Value<string>());
			}
			if(node["thumbBitrate"] != null)
			{
				this._ThumbBitrate = ParseInt(node["thumbBitrate"].Value<string>());
			}
			if(node["customData"] != null)
			{
				this._CustomData = node["customData"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaPostConvertJobData");
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("flavorAssetEncryptionKey", this._FlavorAssetEncryptionKey);
			kparams.AddIfNotNull("createThumb", this._CreateThumb);
			kparams.AddIfNotNull("thumbPath", this._ThumbPath);
			kparams.AddIfNotNull("thumbOffset", this._ThumbOffset);
			kparams.AddIfNotNull("thumbHeight", this._ThumbHeight);
			kparams.AddIfNotNull("thumbBitrate", this._ThumbBitrate);
			kparams.AddIfNotNull("customData", this._CustomData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FLAVOR_ASSET_ENCRYPTION_KEY:
					return "FlavorAssetEncryptionKey";
				case CREATE_THUMB:
					return "CreateThumb";
				case THUMB_PATH:
					return "ThumbPath";
				case THUMB_OFFSET:
					return "ThumbOffset";
				case THUMB_HEIGHT:
					return "ThumbHeight";
				case THUMB_BITRATE:
					return "ThumbBitrate";
				case CUSTOM_DATA:
					return "CustomData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

