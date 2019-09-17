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
	public class DexterIntegrationJobProviderData : IntegrationJobProviderData
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		public const string TRANSCRIPT_ASSET_ID = "transcriptAssetId";
		public const string ENTRY_ID = "entryId";
		public const string VOICEBASE_API_KEY = "voicebaseApiKey";
		public const string VOICEBASE_API_PASSWORD = "voicebaseApiPassword";
		#endregion

		#region Private Fields
		private int _MetadataProfileId = Int32.MinValue;
		private string _TranscriptAssetId = null;
		private string _EntryId = null;
		private string _VoicebaseApiKey = null;
		private string _VoicebaseApiPassword = null;
		#endregion

		#region Properties
		[JsonProperty]
		public int MetadataProfileId
		{
			get { return _MetadataProfileId; }
			set 
			{ 
				_MetadataProfileId = value;
				OnPropertyChanged("MetadataProfileId");
			}
		}
		[JsonProperty]
		public string TranscriptAssetId
		{
			get { return _TranscriptAssetId; }
			set 
			{ 
				_TranscriptAssetId = value;
				OnPropertyChanged("TranscriptAssetId");
			}
		}
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
		public string VoicebaseApiKey
		{
			get { return _VoicebaseApiKey; }
			set 
			{ 
				_VoicebaseApiKey = value;
				OnPropertyChanged("VoicebaseApiKey");
			}
		}
		[JsonProperty]
		public string VoicebaseApiPassword
		{
			get { return _VoicebaseApiPassword; }
			set 
			{ 
				_VoicebaseApiPassword = value;
				OnPropertyChanged("VoicebaseApiPassword");
			}
		}
		#endregion

		#region CTor
		public DexterIntegrationJobProviderData()
		{
		}

		public DexterIntegrationJobProviderData(JToken node) : base(node)
		{
			if(node["metadataProfileId"] != null)
			{
				this._MetadataProfileId = ParseInt(node["metadataProfileId"].Value<string>());
			}
			if(node["transcriptAssetId"] != null)
			{
				this._TranscriptAssetId = node["transcriptAssetId"].Value<string>();
			}
			if(node["entryId"] != null)
			{
				this._EntryId = node["entryId"].Value<string>();
			}
			if(node["voicebaseApiKey"] != null)
			{
				this._VoicebaseApiKey = node["voicebaseApiKey"].Value<string>();
			}
			if(node["voicebaseApiPassword"] != null)
			{
				this._VoicebaseApiPassword = node["voicebaseApiPassword"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDexterIntegrationJobProviderData");
			kparams.AddIfNotNull("metadataProfileId", this._MetadataProfileId);
			kparams.AddIfNotNull("transcriptAssetId", this._TranscriptAssetId);
			kparams.AddIfNotNull("entryId", this._EntryId);
			kparams.AddIfNotNull("voicebaseApiKey", this._VoicebaseApiKey);
			kparams.AddIfNotNull("voicebaseApiPassword", this._VoicebaseApiPassword);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case METADATA_PROFILE_ID:
					return "MetadataProfileId";
				case TRANSCRIPT_ASSET_ID:
					return "TranscriptAssetId";
				case ENTRY_ID:
					return "EntryId";
				case VOICEBASE_API_KEY:
					return "VoicebaseApiKey";
				case VOICEBASE_API_PASSWORD:
					return "VoicebaseApiPassword";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

