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
// Copyright (C) 2006-2022  Kaltura Inc.
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
	public class CaptionParams : AssetParams
	{
		#region Constants
		public const string LANGUAGE = "language";
		public const string IS_DEFAULT = "isDefault";
		public const string LABEL = "label";
		public const string FORMAT = "format";
		public const string SOURCE_PARAMS_ID = "sourceParamsId";
		#endregion

		#region Private Fields
		private Language _Language = null;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		private string _Label = null;
		private CaptionType _Format = null;
		private int _SourceParamsId = Int32.MinValue;
		#endregion

		#region Properties
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
		/// Use SourceParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int SourceParamsId
		{
			get { return _SourceParamsId; }
			set 
			{ 
				_SourceParamsId = value;
				OnPropertyChanged("SourceParamsId");
			}
		}
		#endregion

		#region CTor
		public CaptionParams()
		{
		}

		public CaptionParams(JToken node) : base(node)
		{
			if(node["language"] != null)
			{
				this._Language = (Language)StringEnum.Parse(typeof(Language), node["language"].Value<string>());
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
			if(node["sourceParamsId"] != null)
			{
				this._SourceParamsId = ParseInt(node["sourceParamsId"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionParams");
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("sourceParamsId", this._SourceParamsId);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LANGUAGE:
					return "Language";
				case IS_DEFAULT:
					return "IsDefault";
				case LABEL:
					return "Label";
				case FORMAT:
					return "Format";
				case SOURCE_PARAMS_ID:
					return "SourceParamsId";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

