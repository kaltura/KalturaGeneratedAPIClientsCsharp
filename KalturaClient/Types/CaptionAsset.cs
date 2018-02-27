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
// Copyright (C) 2006-2018  Kaltura Inc.
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
		#endregion

		#region Properties
		public int CaptionParamsId
		{
			get { return _CaptionParamsId; }
			set 
			{ 
				_CaptionParamsId = value;
				OnPropertyChanged("CaptionParamsId");
			}
		}
		public Language Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
			}
		}
		public LanguageCode LanguageCode
		{
			get { return _LanguageCode; }
		}
		public NullableBoolean IsDefault
		{
			get { return _IsDefault; }
			set 
			{ 
				_IsDefault = value;
				OnPropertyChanged("IsDefault");
			}
		}
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
		}
		public CaptionType Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public CaptionAssetStatus Status
		{
			get { return _Status; }
		}
		public string ParentId
		{
			get { return _ParentId; }
			set 
			{ 
				_ParentId = value;
				OnPropertyChanged("ParentId");
			}
		}
		public int Accuracy
		{
			get { return _Accuracy; }
			set 
			{ 
				_Accuracy = value;
				OnPropertyChanged("Accuracy");
			}
		}
		#endregion

		#region CTor
		public CaptionAsset()
		{
		}

		public CaptionAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "captionParamsId":
						this._CaptionParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "language":
						this._Language = (Language)StringEnum.Parse(typeof(Language), propertyNode.InnerText);
						continue;
					case "languageCode":
						this._LanguageCode = (LanguageCode)StringEnum.Parse(typeof(LanguageCode), propertyNode.InnerText);
						continue;
					case "isDefault":
						this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
						continue;
					case "label":
						this._Label = propertyNode.InnerText;
						continue;
					case "format":
						this._Format = (CaptionType)StringEnum.Parse(typeof(CaptionType), propertyNode.InnerText);
						continue;
					case "status":
						this._Status = (CaptionAssetStatus)ParseEnum(typeof(CaptionAssetStatus), propertyNode.InnerText);
						continue;
					case "parentId":
						this._ParentId = propertyNode.InnerText;
						continue;
					case "accuracy":
						this._Accuracy = ParseInt(propertyNode.InnerText);
						continue;
				}
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

