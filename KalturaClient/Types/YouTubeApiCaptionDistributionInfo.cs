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
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class YouTubeApiCaptionDistributionInfo : ObjectBase
	{
		#region Constants
		public const string LANGUAGE = "language";
		public const string LABEL = "label";
		public const string FILE_PATH = "filePath";
		public const string REMOTE_ID = "remoteId";
		public const string ACTION = "action";
		public const string VERSION = "version";
		public const string ASSET_ID = "assetId";
		#endregion

		#region Private Fields
		private string _Language = null;
		private string _Label = null;
		private string _FilePath = null;
		private string _RemoteId = null;
		private YouTubeApiDistributionCaptionAction _Action = (YouTubeApiDistributionCaptionAction)Int32.MinValue;
		private string _Version = null;
		private string _AssetId = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use LabelAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		/// <summary>
		/// Use FilePathAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FilePath
		{
			get { return _FilePath; }
			set 
			{ 
				_FilePath = value;
				OnPropertyChanged("FilePath");
			}
		}
		/// <summary>
		/// Use RemoteIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RemoteId
		{
			get { return _RemoteId; }
			set 
			{ 
				_RemoteId = value;
				OnPropertyChanged("RemoteId");
			}
		}
		/// <summary>
		/// Use ActionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public YouTubeApiDistributionCaptionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		/// <summary>
		/// Use VersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Version
		{
			get { return _Version; }
			set 
			{ 
				_Version = value;
				OnPropertyChanged("Version");
			}
		}
		/// <summary>
		/// Use AssetIdAsDouble property instead
		/// </summary>
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
		#endregion

		#region CTor
		public YouTubeApiCaptionDistributionInfo()
		{
		}

		public YouTubeApiCaptionDistributionInfo(JToken node) : base(node)
		{
			if(node["language"] != null)
			{
				this._Language = node["language"].Value<string>();
			}
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
			if(node["filePath"] != null)
			{
				this._FilePath = node["filePath"].Value<string>();
			}
			if(node["remoteId"] != null)
			{
				this._RemoteId = node["remoteId"].Value<string>();
			}
			if(node["action"] != null)
			{
				this._Action = (YouTubeApiDistributionCaptionAction)ParseEnum(typeof(YouTubeApiDistributionCaptionAction), node["action"].Value<string>());
			}
			if(node["version"] != null)
			{
				this._Version = node["version"].Value<string>();
			}
			if(node["assetId"] != null)
			{
				this._AssetId = node["assetId"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaYouTubeApiCaptionDistributionInfo");
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("filePath", this._FilePath);
			kparams.AddIfNotNull("remoteId", this._RemoteId);
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("version", this._Version);
			kparams.AddIfNotNull("assetId", this._AssetId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LANGUAGE:
					return "Language";
				case LABEL:
					return "Label";
				case FILE_PATH:
					return "FilePath";
				case REMOTE_ID:
					return "RemoteId";
				case ACTION:
					return "Action";
				case VERSION:
					return "Version";
				case ASSET_ID:
					return "AssetId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

