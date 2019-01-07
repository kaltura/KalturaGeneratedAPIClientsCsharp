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
	public class CaptionAsset : Asset
	{
		#region Constants
		public const string CAPTION_PARAMS_ID = "captionParamsId";
		public const string LANGUAGE = "language";
		public const string LANGUAGE_CODE = "languageCode";
		public const string IS_DEFAULT = "isDefault";
		public const string LABEL = "label";
		public const string FORMAT = "format";
		public const string STATUS = "status";
		public const string PARENT_ID = "parentId";
		public const string ACCURACY = "accuracy";
		public const string DISPLAY_ON_PLAYER = "displayOnPlayer";
		#endregion

		#region Private Fields
		private int _CaptionParamsId = Int32.MinValue;
		private Language _Language = null;
		private LanguageCode _LanguageCode = null;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private string _Label = null;
		private CaptionType _Format = null;
		private CaptionAssetStatus _Status = (CaptionAssetStatus)Int32.MinValue;
		private string _ParentId = null;
		private int _Accuracy = Int32.MinValue;
		private bool? _DisplayOnPlayer = null;
		#endregion

		#region Properties
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
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("parentId", this._ParentId);
			kparams.AddIfNotNull("accuracy", this._Accuracy);
			kparams.AddIfNotNull("displayOnPlayer", this._DisplayOnPlayer);
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
				case STATUS:
					return "Status";
				case PARENT_ID:
					return "ParentId";
				case ACCURACY:
					return "Accuracy";
				case DISPLAY_ON_PLAYER:
					return "DisplayOnPlayer";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

