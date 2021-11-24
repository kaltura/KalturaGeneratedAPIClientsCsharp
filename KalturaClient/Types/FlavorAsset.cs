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
// Copyright (C) 2006-2021  Kaltura Inc.
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
	public class FlavorAsset : Asset
	{
		#region Constants
		public const string FLAVOR_PARAMS_ID = "flavorParamsId";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string BITRATE = "bitrate";
		public const string FRAME_RATE = "frameRate";
		public const string IS_ORIGINAL = "isOriginal";
		public const string IS_WEB = "isWeb";
		public const string CONTAINER_FORMAT = "containerFormat";
		public const string VIDEO_CODEC_ID = "videoCodecId";
		public const string STATUS = "status";
		public const string LANGUAGE = "language";
		public const string LABEL = "label";
		public const string IS_DEFAULT = "isDefault";
		#endregion

		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Bitrate = Int32.MinValue;
		private double _FrameRate = Double.MinValue;
		private bool? _IsOriginal = null;
		private bool? _IsWeb = null;
		private string _ContainerFormat = null;
		private string _VideoCodecId = null;
		private FlavorAssetStatus _Status = (FlavorAssetStatus)Int32.MinValue;
		private Language _Language = null;
		private string _Label = null;
		private NullableBoolean _IsDefault = (NullableBoolean)Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use FlavorParamsIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		/// <summary>
		/// Use WidthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			private set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		/// <summary>
		/// Use HeightAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			private set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		/// <summary>
		/// Use BitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Bitrate
		{
			get { return _Bitrate; }
			private set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		/// <summary>
		/// Use FrameRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FrameRate
		{
			get { return _FrameRate; }
			private set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		/// <summary>
		/// Use IsOriginalAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsOriginal
		{
			get { return _IsOriginal; }
			private set 
			{ 
				_IsOriginal = value;
				OnPropertyChanged("IsOriginal");
			}
		}
		/// <summary>
		/// Use IsWebAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? IsWeb
		{
			get { return _IsWeb; }
			private set 
			{ 
				_IsWeb = value;
				OnPropertyChanged("IsWeb");
			}
		}
		/// <summary>
		/// Use ContainerFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
			private set 
			{ 
				_ContainerFormat = value;
				OnPropertyChanged("ContainerFormat");
			}
		}
		/// <summary>
		/// Use VideoCodecIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
			private set 
			{ 
				_VideoCodecId = value;
				OnPropertyChanged("VideoCodecId");
			}
		}
		/// <summary>
		/// Use StatusAsDouble property instead
		/// </summary>
		[JsonProperty]
		public FlavorAssetStatus Status
		{
			get { return _Status; }
			private set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
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
		#endregion

		#region CTor
		public FlavorAsset()
		{
		}

		public FlavorAsset(JToken node) : base(node)
		{
			if(node["flavorParamsId"] != null)
			{
				this._FlavorParamsId = ParseInt(node["flavorParamsId"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["bitrate"] != null)
			{
				this._Bitrate = ParseInt(node["bitrate"].Value<string>());
			}
			if(node["frameRate"] != null)
			{
				this._FrameRate = ParseDouble(node["frameRate"].Value<string>());
			}
			if(node["isOriginal"] != null)
			{
				this._IsOriginal = ParseBool(node["isOriginal"].Value<string>());
			}
			if(node["isWeb"] != null)
			{
				this._IsWeb = ParseBool(node["isWeb"].Value<string>());
			}
			if(node["containerFormat"] != null)
			{
				this._ContainerFormat = node["containerFormat"].Value<string>();
			}
			if(node["videoCodecId"] != null)
			{
				this._VideoCodecId = node["videoCodecId"].Value<string>();
			}
			if(node["status"] != null)
			{
				this._Status = (FlavorAssetStatus)ParseEnum(typeof(FlavorAssetStatus), node["status"].Value<string>());
			}
			if(node["language"] != null)
			{
				this._Language = (Language)StringEnum.Parse(typeof(Language), node["language"].Value<string>());
			}
			if(node["label"] != null)
			{
				this._Label = node["label"].Value<string>();
			}
			if(node["isDefault"] != null)
			{
				this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["isDefault"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFlavorAsset");
			kparams.AddIfNotNull("flavorParamsId", this._FlavorParamsId);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("bitrate", this._Bitrate);
			kparams.AddIfNotNull("frameRate", this._FrameRate);
			kparams.AddIfNotNull("isOriginal", this._IsOriginal);
			kparams.AddIfNotNull("isWeb", this._IsWeb);
			kparams.AddIfNotNull("containerFormat", this._ContainerFormat);
			kparams.AddIfNotNull("videoCodecId", this._VideoCodecId);
			kparams.AddIfNotNull("status", this._Status);
			kparams.AddIfNotNull("language", this._Language);
			kparams.AddIfNotNull("label", this._Label);
			kparams.AddIfNotNull("isDefault", this._IsDefault);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FLAVOR_PARAMS_ID:
					return "FlavorParamsId";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case BITRATE:
					return "Bitrate";
				case FRAME_RATE:
					return "FrameRate";
				case IS_ORIGINAL:
					return "IsOriginal";
				case IS_WEB:
					return "IsWeb";
				case CONTAINER_FORMAT:
					return "ContainerFormat";
				case VIDEO_CODEC_ID:
					return "VideoCodecId";
				case STATUS:
					return "Status";
				case LANGUAGE:
					return "Language";
				case LABEL:
					return "Label";
				case IS_DEFAULT:
					return "IsDefault";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

