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

namespace Kaltura
{
	public class KalturaVoicebaseJobProviderData : KalturaIntegrationJobProviderData
	{
		#region Private Fields
		private string _EntryId = null;
		private string _FlavorAssetId = null;
		private string _TranscriptId = null;
		private string _CaptionAssetFormats = null;
		private string _ApiKey = null;
		private string _ApiPassword = null;
		private KalturaLanguage _SpokenLanguage = null;
		private string _FileLocation = null;
		private bool? _ReplaceMediaContent = null;
		#endregion

		#region Properties
		public string EntryId
		{
			get { return _EntryId; }
			set 
			{ 
				_EntryId = value;
				OnPropertyChanged("EntryId");
			}
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public string TranscriptId
		{
			get { return _TranscriptId; }
			set 
			{ 
				_TranscriptId = value;
				OnPropertyChanged("TranscriptId");
			}
		}
		public string CaptionAssetFormats
		{
			get { return _CaptionAssetFormats; }
			set 
			{ 
				_CaptionAssetFormats = value;
				OnPropertyChanged("CaptionAssetFormats");
			}
		}
		public string ApiKey
		{
			get { return _ApiKey; }
		}
		public string ApiPassword
		{
			get { return _ApiPassword; }
		}
		public KalturaLanguage SpokenLanguage
		{
			get { return _SpokenLanguage; }
			set 
			{ 
				_SpokenLanguage = value;
				OnPropertyChanged("SpokenLanguage");
			}
		}
		public string FileLocation
		{
			get { return _FileLocation; }
		}
		public bool? ReplaceMediaContent
		{
			get { return _ReplaceMediaContent; }
			set 
			{ 
				_ReplaceMediaContent = value;
				OnPropertyChanged("ReplaceMediaContent");
			}
		}
		#endregion

		#region CTor
		public KalturaVoicebaseJobProviderData()
		{
		}

		public KalturaVoicebaseJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "entryId":
						this._EntryId = txt;
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "transcriptId":
						this._TranscriptId = txt;
						continue;
					case "captionAssetFormats":
						this._CaptionAssetFormats = txt;
						continue;
					case "apiKey":
						this._ApiKey = txt;
						continue;
					case "apiPassword":
						this._ApiPassword = txt;
						continue;
					case "spokenLanguage":
						this._SpokenLanguage = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
						continue;
					case "fileLocation":
						this._FileLocation = txt;
						continue;
					case "replaceMediaContent":
						this._ReplaceMediaContent = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
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
			return kparams;
		}
		#endregion
	}
}

