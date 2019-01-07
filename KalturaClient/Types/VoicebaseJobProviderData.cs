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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class VoicebaseJobProviderData : IntegrationJobProviderData
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string TRANSCRIPT_ID = "transcriptId";
		public const string CAPTION_ASSET_FORMATS = "captionAssetFormats";
		public const string API_KEY = "apiKey";
		public const string API_PASSWORD = "apiPassword";
		public const string SPOKEN_LANGUAGE = "spokenLanguage";
		public const string FILE_LOCATION = "fileLocation";
		public const string REPLACE_MEDIA_CONTENT = "replaceMediaContent";
		public const string ADDITIONAL_PARAMETERS = "additionalParameters";
		#endregion

		#region Private Fields
		private string _EntryId = null;
		private string _FlavorAssetId = null;
		private string _TranscriptId = null;
		private string _CaptionAssetFormats = null;
		private string _ApiKey = null;
		private string _ApiPassword = null;
		private Language _SpokenLanguage = null;
		private string _FileLocation = null;
		private bool? _ReplaceMediaContent = null;
		private string _AdditionalParameters = null;
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
		public string TranscriptId
		{
			get { return _TranscriptId; }
			set 
			{ 
				_TranscriptId = value;
				OnPropertyChanged("TranscriptId");
			}
		}
		[JsonProperty]
		public string CaptionAssetFormats
		{
			get { return _CaptionAssetFormats; }
			set 
			{ 
				_CaptionAssetFormats = value;
				OnPropertyChanged("CaptionAssetFormats");
			}
		}
		[JsonProperty]
		public string ApiKey
		{
			get { return _ApiKey; }
			private set 
			{ 
				_ApiKey = value;
				OnPropertyChanged("ApiKey");
			}
		}
		[JsonProperty]
		public string ApiPassword
		{
			get { return _ApiPassword; }
			private set 
			{ 
				_ApiPassword = value;
				OnPropertyChanged("ApiPassword");
			}
		}
		[JsonProperty]
		public Language SpokenLanguage
		{
			get { return _SpokenLanguage; }
			set 
			{ 
				_SpokenLanguage = value;
				OnPropertyChanged("SpokenLanguage");
			}
		}
		[JsonProperty]
		public string FileLocation
		{
			get { return _FileLocation; }
			private set 
			{ 
				_FileLocation = value;
				OnPropertyChanged("FileLocation");
			}
		}
		[JsonProperty]
		public bool? ReplaceMediaContent
		{
			get { return _ReplaceMediaContent; }
			set 
			{ 
				_ReplaceMediaContent = value;
				OnPropertyChanged("ReplaceMediaContent");
			}
		}
		[JsonProperty]
		public string AdditionalParameters
		{
			get { return _AdditionalParameters; }
			private set 
			{ 
				_AdditionalParameters = value;
				OnPropertyChanged("AdditionalParameters");
			}
		}
		#endregion

		#region CTor
		public VoicebaseJobProviderData()
		{
		}

		public VoicebaseJobProviderData(JToken node) : base(node)
		{
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["transcriptId"] != null)
			{
				this._TranscriptId = node["transcriptId"].Value<string>();
			}
			if(node["captionAssetFormats"] != null)
			{
				this._CaptionAssetFormats = node["captionAssetFormats"].Value<string>();
			}
			if(node["apiKey"] != null)
			{
				this._ApiKey = node["apiKey"].Value<string>();
			}
			if(node["apiPassword"] != null)
			{
				this._ApiPassword = node["apiPassword"].Value<string>();
			}
			if(node["spokenLanguage"] != null)
			{
				this._SpokenLanguage = (Language)StringEnum.Parse(typeof(Language), node["spokenLanguage"].Value<string>());
			}
			if(node["fileLocation"] != null)
			{
				this._FileLocation = node["fileLocation"].Value<string>();
			}
			if(node["replaceMediaContent"] != null)
			{
				this._ReplaceMediaContent = ParseBool(node["replaceMediaContent"].Value<string>());
			}
			if(node["additionalParameters"] != null)
			{
				this._AdditionalParameters = node["additionalParameters"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaVoicebaseJobProviderData");
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("transcriptId", this._TranscriptId);
			kparams.AddIfNotNull("captionAssetFormats", this._CaptionAssetFormats);
			kparams.AddIfNotNull("apiKey", this._ApiKey);
			kparams.AddIfNotNull("apiPassword", this._ApiPassword);
			kparams.AddIfNotNull("spokenLanguage", this._SpokenLanguage);
			kparams.AddIfNotNull("fileLocation", this._FileLocation);
			kparams.AddIfNotNull("replaceMediaContent", this._ReplaceMediaContent);
			kparams.AddIfNotNull("additionalParameters", this._AdditionalParameters);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ENTRY_ID:
					return "EntryId";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case TRANSCRIPT_ID:
					return "TranscriptId";
				case CAPTION_ASSET_FORMATS:
					return "CaptionAssetFormats";
				case API_KEY:
					return "ApiKey";
				case API_PASSWORD:
					return "ApiPassword";
				case SPOKEN_LANGUAGE:
					return "SpokenLanguage";
				case FILE_LOCATION:
					return "FileLocation";
				case REPLACE_MEDIA_CONTENT:
					return "ReplaceMediaContent";
				case ADDITIONAL_PARAMETERS:
					return "AdditionalParameters";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

