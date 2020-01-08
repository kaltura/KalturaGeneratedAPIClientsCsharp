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
	public class YouTubeDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string VIDEO_ASSET_FILE_PATH = "videoAssetFilePath";
		public const string THUMB_ASSET_FILE_PATH = "thumbAssetFilePath";
		public const string THUMB_ASSET_ID = "thumbAssetId";
		public const string CAPTION_ASSET_IDS = "captionAssetIds";
		public const string SFTP_DIRECTORY = "sftpDirectory";
		public const string SFTP_METADATA_FILENAME = "sftpMetadataFilename";
		public const string CURRENT_PLAYLISTS = "currentPlaylists";
		public const string NEW_PLAYLISTS = "newPlaylists";
		public const string SUBMIT_XML = "submitXml";
		public const string UPDATE_XML = "updateXml";
		public const string DELETE_XML = "deleteXml";
		public const string GOOGLE_CLIENT_ID = "googleClientId";
		public const string GOOGLE_CLIENT_SECRET = "googleClientSecret";
		public const string GOOGLE_TOKEN_DATA = "googleTokenData";
		public const string CAPTIONS_CSV_MAP = "captionsCsvMap";
		public const string SUBMIT_CSV_MAP = "submitCsvMap";
		public const string UPDATE_CSV_MAP = "updateCsvMap";
		public const string DELETE_VIDEO_IDS = "deleteVideoIds";
		#endregion

		#region Private Fields
		private string _VideoAssetFilePath = null;
		private string _ThumbAssetFilePath = null;
		private string _ThumbAssetId = null;
		private string _CaptionAssetIds = null;
		private string _SftpDirectory = null;
		private string _SftpMetadataFilename = null;
		private string _CurrentPlaylists = null;
		private string _NewPlaylists = null;
		private string _SubmitXml = null;
		private string _UpdateXml = null;
		private string _DeleteXml = null;
		private string _GoogleClientId = null;
		private string _GoogleClientSecret = null;
		private string _GoogleTokenData = null;
		private string _CaptionsCsvMap = null;
		private string _SubmitCsvMap = null;
		private string _UpdateCsvMap = null;
		private string _DeleteVideoIds = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string VideoAssetFilePath
		{
			get { return _VideoAssetFilePath; }
			set 
			{ 
				_VideoAssetFilePath = value;
				OnPropertyChanged("VideoAssetFilePath");
			}
		}
		[JsonProperty]
		public string ThumbAssetFilePath
		{
			get { return _ThumbAssetFilePath; }
			set 
			{ 
				_ThumbAssetFilePath = value;
				OnPropertyChanged("ThumbAssetFilePath");
			}
		}
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
		[JsonProperty]
		public string CaptionAssetIds
		{
			get { return _CaptionAssetIds; }
			set 
			{ 
				_CaptionAssetIds = value;
				OnPropertyChanged("CaptionAssetIds");
			}
		}
		[JsonProperty]
		public string SftpDirectory
		{
			get { return _SftpDirectory; }
			set 
			{ 
				_SftpDirectory = value;
				OnPropertyChanged("SftpDirectory");
			}
		}
		[JsonProperty]
		public string SftpMetadataFilename
		{
			get { return _SftpMetadataFilename; }
			set 
			{ 
				_SftpMetadataFilename = value;
				OnPropertyChanged("SftpMetadataFilename");
			}
		}
		[JsonProperty]
		public string CurrentPlaylists
		{
			get { return _CurrentPlaylists; }
			set 
			{ 
				_CurrentPlaylists = value;
				OnPropertyChanged("CurrentPlaylists");
			}
		}
		[JsonProperty]
		public string NewPlaylists
		{
			get { return _NewPlaylists; }
			set 
			{ 
				_NewPlaylists = value;
				OnPropertyChanged("NewPlaylists");
			}
		}
		[JsonProperty]
		public string SubmitXml
		{
			get { return _SubmitXml; }
			set 
			{ 
				_SubmitXml = value;
				OnPropertyChanged("SubmitXml");
			}
		}
		[JsonProperty]
		public string UpdateXml
		{
			get { return _UpdateXml; }
			set 
			{ 
				_UpdateXml = value;
				OnPropertyChanged("UpdateXml");
			}
		}
		[JsonProperty]
		public string DeleteXml
		{
			get { return _DeleteXml; }
			set 
			{ 
				_DeleteXml = value;
				OnPropertyChanged("DeleteXml");
			}
		}
		[JsonProperty]
		public string GoogleClientId
		{
			get { return _GoogleClientId; }
			set 
			{ 
				_GoogleClientId = value;
				OnPropertyChanged("GoogleClientId");
			}
		}
		[JsonProperty]
		public string GoogleClientSecret
		{
			get { return _GoogleClientSecret; }
			set 
			{ 
				_GoogleClientSecret = value;
				OnPropertyChanged("GoogleClientSecret");
			}
		}
		[JsonProperty]
		public string GoogleTokenData
		{
			get { return _GoogleTokenData; }
			set 
			{ 
				_GoogleTokenData = value;
				OnPropertyChanged("GoogleTokenData");
			}
		}
		[JsonProperty]
		public string CaptionsCsvMap
		{
			get { return _CaptionsCsvMap; }
			set 
			{ 
				_CaptionsCsvMap = value;
				OnPropertyChanged("CaptionsCsvMap");
			}
		}
		[JsonProperty]
		public string SubmitCsvMap
		{
			get { return _SubmitCsvMap; }
			set 
			{ 
				_SubmitCsvMap = value;
				OnPropertyChanged("SubmitCsvMap");
			}
		}
		[JsonProperty]
		public string UpdateCsvMap
		{
			get { return _UpdateCsvMap; }
			set 
			{ 
				_UpdateCsvMap = value;
				OnPropertyChanged("UpdateCsvMap");
			}
		}
		[JsonProperty]
		public string DeleteVideoIds
		{
			get { return _DeleteVideoIds; }
			set 
			{ 
				_DeleteVideoIds = value;
				OnPropertyChanged("DeleteVideoIds");
			}
		}
		#endregion

		#region CTor
		public YouTubeDistributionJobProviderData()
		{
		}

		public YouTubeDistributionJobProviderData(JToken node) : base(node)
		{
			if(node["videoAssetFilePath"] != null)
			{
				this._VideoAssetFilePath = node["videoAssetFilePath"].Value<string>();
			}
			if(node["thumbAssetFilePath"] != null)
			{
				this._ThumbAssetFilePath = node["thumbAssetFilePath"].Value<string>();
			}
			if(node["thumbAssetId"] != null)
			{
				this._ThumbAssetId = node["thumbAssetId"].Value<string>();
			}
			if(node["captionAssetIds"] != null)
			{
				this._CaptionAssetIds = node["captionAssetIds"].Value<string>();
			}
			if(node["sftpDirectory"] != null)
			{
				this._SftpDirectory = node["sftpDirectory"].Value<string>();
			}
			if(node["sftpMetadataFilename"] != null)
			{
				this._SftpMetadataFilename = node["sftpMetadataFilename"].Value<string>();
			}
			if(node["currentPlaylists"] != null)
			{
				this._CurrentPlaylists = node["currentPlaylists"].Value<string>();
			}
			if(node["newPlaylists"] != null)
			{
				this._NewPlaylists = node["newPlaylists"].Value<string>();
			}
			if(node["submitXml"] != null)
			{
				this._SubmitXml = node["submitXml"].Value<string>();
			}
			if(node["updateXml"] != null)
			{
				this._UpdateXml = node["updateXml"].Value<string>();
			}
			if(node["deleteXml"] != null)
			{
				this._DeleteXml = node["deleteXml"].Value<string>();
			}
			if(node["googleClientId"] != null)
			{
				this._GoogleClientId = node["googleClientId"].Value<string>();
			}
			if(node["googleClientSecret"] != null)
			{
				this._GoogleClientSecret = node["googleClientSecret"].Value<string>();
			}
			if(node["googleTokenData"] != null)
			{
				this._GoogleTokenData = node["googleTokenData"].Value<string>();
			}
			if(node["captionsCsvMap"] != null)
			{
				this._CaptionsCsvMap = node["captionsCsvMap"].Value<string>();
			}
			if(node["submitCsvMap"] != null)
			{
				this._SubmitCsvMap = node["submitCsvMap"].Value<string>();
			}
			if(node["updateCsvMap"] != null)
			{
				this._UpdateCsvMap = node["updateCsvMap"].Value<string>();
			}
			if(node["deleteVideoIds"] != null)
			{
				this._DeleteVideoIds = node["deleteVideoIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaYouTubeDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePath", this._VideoAssetFilePath);
			kparams.AddIfNotNull("thumbAssetFilePath", this._ThumbAssetFilePath);
			kparams.AddIfNotNull("thumbAssetId", this._ThumbAssetId);
			kparams.AddIfNotNull("captionAssetIds", this._CaptionAssetIds);
			kparams.AddIfNotNull("sftpDirectory", this._SftpDirectory);
			kparams.AddIfNotNull("sftpMetadataFilename", this._SftpMetadataFilename);
			kparams.AddIfNotNull("currentPlaylists", this._CurrentPlaylists);
			kparams.AddIfNotNull("newPlaylists", this._NewPlaylists);
			kparams.AddIfNotNull("submitXml", this._SubmitXml);
			kparams.AddIfNotNull("updateXml", this._UpdateXml);
			kparams.AddIfNotNull("deleteXml", this._DeleteXml);
			kparams.AddIfNotNull("googleClientId", this._GoogleClientId);
			kparams.AddIfNotNull("googleClientSecret", this._GoogleClientSecret);
			kparams.AddIfNotNull("googleTokenData", this._GoogleTokenData);
			kparams.AddIfNotNull("captionsCsvMap", this._CaptionsCsvMap);
			kparams.AddIfNotNull("submitCsvMap", this._SubmitCsvMap);
			kparams.AddIfNotNull("updateCsvMap", this._UpdateCsvMap);
			kparams.AddIfNotNull("deleteVideoIds", this._DeleteVideoIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_ASSET_FILE_PATH:
					return "VideoAssetFilePath";
				case THUMB_ASSET_FILE_PATH:
					return "ThumbAssetFilePath";
				case THUMB_ASSET_ID:
					return "ThumbAssetId";
				case CAPTION_ASSET_IDS:
					return "CaptionAssetIds";
				case SFTP_DIRECTORY:
					return "SftpDirectory";
				case SFTP_METADATA_FILENAME:
					return "SftpMetadataFilename";
				case CURRENT_PLAYLISTS:
					return "CurrentPlaylists";
				case NEW_PLAYLISTS:
					return "NewPlaylists";
				case SUBMIT_XML:
					return "SubmitXml";
				case UPDATE_XML:
					return "UpdateXml";
				case DELETE_XML:
					return "DeleteXml";
				case GOOGLE_CLIENT_ID:
					return "GoogleClientId";
				case GOOGLE_CLIENT_SECRET:
					return "GoogleClientSecret";
				case GOOGLE_TOKEN_DATA:
					return "GoogleTokenData";
				case CAPTIONS_CSV_MAP:
					return "CaptionsCsvMap";
				case SUBMIT_CSV_MAP:
					return "SubmitCsvMap";
				case UPDATE_CSV_MAP:
					return "UpdateCsvMap";
				case DELETE_VIDEO_IDS:
					return "DeleteVideoIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

