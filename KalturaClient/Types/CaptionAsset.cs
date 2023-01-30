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
	public class CaptionAsset : Asset
	{
		#region Constants
		public const string CAPTION_PARAMS_ID = "captionParamsId";
		public const string LANGUAGE = "language";
		public const string LANGUAGE_CODE = "languageCode";
		public const string IS_DEFAULT = "isDefault";
		public const string LABEL = "label";
		public const string FORMAT = "format";
		public const string SOURCE = "source";
		public const string STATUS = "status";
		public const string PARENT_ID = "parentId";
		public const string ACCURACY = "accuracy";
		public const string DISPLAY_ON_PLAYER = "displayOnPlayer";
		public const string ASSOCIATED_TRANSCRIPT_IDS = "associatedTranscriptIds";
		#endregion

		#region Private Fields
		private int _CaptionParamsId = Int32.MinValue;
		private Language _Language = null;
		private LanguageCode _LanguageCode = null;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private string _Label = null;
		private CaptionType _Format = null;
		private CaptionSource _Source = null;
		private CaptionAssetStatus _Status = (CaptionAssetStatus)Int32.MinValue;
		private string _ParentId = null;
		private int _Accuracy = Int32.MinValue;
		private bool? _DisplayOnPlayer = null;
		private string _AssociatedTranscriptIds = null;
		#endregion

		#region Properties
		/// <summary>
		/// Use CaptionParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CaptionParamsId
		{
			get { return _CaptionParamsId; }
			set 
			{ 
				_CaptionParamsId = value;
				OnPropertyChanged("CaptionParamsId");
			}
		}
		/// <summary>
		/// Use LanguageAsDouble property instead
		/// </summary>
		[JsonProperty]
		public Language Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		/// <summary>
		/// Use LanguageCodeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public LanguageCode LanguageCode
		{
			get { return _LanguageCode; }
			private set 
			{ 
				_LanguageCode = value;
				OnPropertyChanged("LanguageCode");
			}
		}
		/// <summary>
		/// Use IsDefaultAsDouble property instead
		/// </summary>
		[JsonProperty]
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
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
		/// Use FormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CaptionType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		/// <summary>
		/// Use SourceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CaptionSource Source
		{
			get { return _Source; }
			set 
			{ 
				_Source = value;
				OnPropertyChanged("Source");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public CaptionAssetStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		/// <summary>
		/// Use ParentIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		/// <summary>
		/// Use AccuracyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		/// <summary>
		/// Use DisplayOnPlayerAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? DisplayOnPlayer
		{
			get { return _DisplayOnPlayer; }
			set 
			{ 
				_DisplayOnPlayer = value;
				OnPropertyChanged("DisplayOnPlayer");
			}
		}
		/// <summary>
		/// Use AssociatedTranscriptIdsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AssociatedTranscriptIds
		{
			get { return _AssociatedTranscriptIds; }
			set 
			{ 
				_AssociatedTranscriptIds = value;
				OnPropertyChanged("AssociatedTranscriptIds");
			}
		}
		#endregion

		#region CTor
		public CaptionAsset()
		{
		}

		public CaptionAsset(JToken node) : base(node)
		{
			if(node["captionParamsId"] != null)
			{
				this._CaptionParamsId = ParseInt(node["captionParamsId"].Value<string>());
			}
			if(node["language"] != null)
			{
				this._Language = (Language)StringEnum.Parse(typeof(Language), node["language"].Value<string>());
			}
			if(node["languageCode"] != null)
			{
				this._LanguageCode = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), node["languageCode"].Value<string>());
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isDefault"].Value<string>());
			}
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
			if(node["format"] != null)
			{
				this._Format = (CaptionType)StringEnum.Parse(typeof(CaptionType), node["format"].Value<string>());
			}
			if(node["source"] != null)
			{
				this._Source = (CaptionSource)StringEnum.Parse(typeof(CaptionSource), node["source"].Value<string>());
			}
			if(node["status"] != null)
			{
				this._Status = (CaptionAssetStatus)ParseEnum(typeof(CaptionAssetStatus), node["status"].Value<string>());
			}
			if(node["parentId"] != null)
			{
				this._ParentId = node["parentId"].Value<string>();
			}
			if(node["accuracy"] != null)
			{
				this._Accuracy = ParseInt(node["accuracy"].Value<string>());
			}
			if(node["displayOnPlayer"] != null)
			{
				this._DisplayOnPlayer = ParseBool(node["displayOnPlayer"].Value<string>());
			}
			if(node["associatedTranscriptIds"] != null)
			{
				this._AssociatedTranscriptIds = node["associatedTranscriptIds"].Value<string>();
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionAsset");
			kparams.AddIfNotNull("captionParamsId", this._CaptionParamsId);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("languageCode", this._LanguageCode);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("source", this._Source);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("accuracy", this._Accuracy);
			kparams.AddIfNotNull("displayOnPlayer", this._DisplayOnPlayer);
			kparams.AddIfNotNull("associatedTranscriptIds", this._AssociatedTranscriptIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CAPTION_PARAMS_ID:
					return "CaptionParamsId";
				case LANGUAGE:
					return "Language";
				case LANGUAGE_CODE:
					return "LanguageCode";
				case IS_DEFAULT:
					return "IsDefault";
				case LABEL:
					return "Label";
				case FORMAT:
					return "Format";
				case SOURCE:
					return "Source";
				case STATUS:
					return "Status";
				case PARENT_ID:
					return "ParentId";
				case ACCURACY:
					return "Accuracy";
				case DISPLAY_ON_PLAYER:
					return "DisplayOnPlayer";
				case ASSOCIATED_TRANSCRIPT_IDS:
					return "AssociatedTranscriptIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

