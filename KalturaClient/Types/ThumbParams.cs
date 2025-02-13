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
	public class ThumbParams : AssetParams
	{
		#region Constants
		public const string CROP_TYPE = "cropType";
		public const string QUALITY = "quality";
		public const string CROP_X = "cropX";
		public const string CROP_Y = "cropY";
		public const string CROP_WIDTH = "cropWidth";
		public const string CROP_HEIGHT = "cropHeight";
		public const string VIDEO_OFFSET = "videoOffset";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string SCALE_WIDTH = "scaleWidth";
		public const string SCALE_HEIGHT = "scaleHeight";
		public const string BACKGROUND_COLOR = "backgroundColor";
		public const string SOURCE_PARAMS_ID = "sourceParamsId";
		public const string FORMAT = "format";
		public const string DENSITY = "density";
		public const string STRIP_PROFILES = "stripProfiles";
		public const string VIDEO_OFFSET_IN_PERCENTAGE = "videoOffsetInPercentage";
		public const string INTERVAL = "interval";
		#endregion

		#region Private Fields
		private ThumbCropType _CropType = (ThumbCropType)Int32.MinValue;
		private int _Quality = Int32.MinValue;
		private int _CropX = Int32.MinValue;
		private int _CropY = Int32.MinValue;
		private int _CropWidth = Int32.MinValue;
		private int _CropHeight = Int32.MinValue;
		private float _VideoOffset = Single.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private float _ScaleWidth = Single.MinValue;
		private float _ScaleHeight = Single.MinValue;
		private string _BackgroundColor = null;
		private int _SourceParamsId = Int32.MinValue;
		private ContainerFormat _Format = null;
		private int _Density = Int32.MinValue;
		private bool? _StripProfiles = null;
		private int _VideoOffsetInPercentage = Int32.MinValue;
		private int _Interval = Int32.MinValue;
		#endregion

		#region Properties
		[JsonProperty]
		public ThumbCropType CropType
		{
			get { return _CropType; }
			set 
			{ 
				_CropType = value;
				OnPropertyChanged("CropType");
			}
		}
		[JsonProperty]
		public int Quality
		{
			get { return _Quality; }
			set 
			{ 
				_Quality = value;
				OnPropertyChanged("Quality");
			}
		}
		[JsonProperty]
		public int CropX
		{
			get { return _CropX; }
			set 
			{ 
				_CropX = value;
				OnPropertyChanged("CropX");
			}
		}
		[JsonProperty]
		public int CropY
		{
			get { return _CropY; }
			set 
			{ 
				_CropY = value;
				OnPropertyChanged("CropY");
			}
		}
		[JsonProperty]
		public int CropWidth
		{
			get { return _CropWidth; }
			set 
			{ 
				_CropWidth = value;
				OnPropertyChanged("CropWidth");
			}
		}
		[JsonProperty]
		public int CropHeight
		{
			get { return _CropHeight; }
			set 
			{ 
				_CropHeight = value;
				OnPropertyChanged("CropHeight");
			}
		}
		[JsonProperty]
		public float VideoOffset
		{
			get { return _VideoOffset; }
			set 
			{ 
				_VideoOffset = value;
				OnPropertyChanged("VideoOffset");
			}
		}
		[JsonProperty]
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		[JsonProperty]
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		[JsonProperty]
		public float ScaleWidth
		{
			get { return _ScaleWidth; }
			set 
			{ 
				_ScaleWidth = value;
				OnPropertyChanged("ScaleWidth");
			}
		}
		[JsonProperty]
		public float ScaleHeight
		{
			get { return _ScaleHeight; }
			set 
			{ 
				_ScaleHeight = value;
				OnPropertyChanged("ScaleHeight");
			}
		}
		[JsonProperty]
		public string BackgroundColor
		{
			get { return _BackgroundColor; }
			set 
			{ 
				_BackgroundColor = value;
				OnPropertyChanged("BackgroundColor");
			}
		}
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
		[JsonProperty]
		public ContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		[JsonProperty]
		public int Density
		{
			get { return _Density; }
			set 
			{ 
				_Density = value;
				OnPropertyChanged("Density");
			}
		}
		[JsonProperty]
		public bool? StripProfiles
		{
			get { return _StripProfiles; }
			set 
			{ 
				_StripProfiles = value;
				OnPropertyChanged("StripProfiles");
			}
		}
		[JsonProperty]
		public int VideoOffsetInPercentage
		{
			get { return _VideoOffsetInPercentage; }
			set 
			{ 
				_VideoOffsetInPercentage = value;
				OnPropertyChanged("VideoOffsetInPercentage");
			}
		}
		[JsonProperty]
		public int Interval
		{
			get { return _Interval; }
			set 
			{ 
				_Interval = value;
				OnPropertyChanged("Interval");
			}
		}
		#endregion

		#region CTor
		public ThumbParams()
		{
		}

		public ThumbParams(JToken node) : base(node)
		{
			if(node["cropType"] != null)
			{
				this._CropType = (ThumbCropType)ParseEnum(typeof(ThumbCropType), node["cropType"].Value<string>());
			}
			if(node["quality"] != null)
			{
				this._Quality = ParseInt(node["quality"].Value<string>());
			}
			if(node["cropX"] != null)
			{
				this._CropX = ParseInt(node["cropX"].Value<string>());
			}
			if(node["cropY"] != null)
			{
				this._CropY = ParseInt(node["cropY"].Value<string>());
			}
			if(node["cropWidth"] != null)
			{
				this._CropWidth = ParseInt(node["cropWidth"].Value<string>());
			}
			if(node["cropHeight"] != null)
			{
				this._CropHeight = ParseInt(node["cropHeight"].Value<string>());
			}
			if(node["videoOffset"] != null)
			{
				this._VideoOffset = ParseFloat(node["videoOffset"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["scaleWidth"] != null)
			{
				this._ScaleWidth = ParseFloat(node["scaleWidth"].Value<string>());
			}
			if(node["scaleHeight"] != null)
			{
				this._ScaleHeight = ParseFloat(node["scaleHeight"].Value<string>());
			}
			if(node["backgroundColor"] != null)
			{
				this._BackgroundColor = node["backgroundColor"].Value<string>();
			}
			if(node["sourceParamsId"] != null)
			{
				this._SourceParamsId = ParseInt(node["sourceParamsId"].Value<string>());
			}
			if(node["format"] != null)
			{
				this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), node["format"].Value<string>());
			}
			if(node["density"] != null)
			{
				this._Density = ParseInt(node["density"].Value<string>());
			}
			if(node["stripProfiles"] != null)
			{
				this._StripProfiles = ParseBool(node["stripProfiles"].Value<string>());
			}
			if(node["videoOffsetInPercentage"] != null)
			{
				this._VideoOffsetInPercentage = ParseInt(node["videoOffsetInPercentage"].Value<string>());
			}
			if(node["interval"] != null)
			{
				this._Interval = ParseInt(node["interval"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaThumbParams");
			kparams.AddIfNotNull("cropType", this._CropType);
			kparams.AddIfNotNull("quality", this._Quality);
			kparams.AddIfNotNull("cropX", this._CropX);
			kparams.AddIfNotNull("cropY", this._CropY);
			kparams.AddIfNotNull("cropWidth", this._CropWidth);
			kparams.AddIfNotNull("cropHeight", this._CropHeight);
			kparams.AddIfNotNull("videoOffset", this._VideoOffset);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("scaleWidth", this._ScaleWidth);
			kparams.AddIfNotNull("scaleHeight", this._ScaleHeight);
			kparams.AddIfNotNull("backgroundColor", this._BackgroundColor);
			kparams.AddIfNotNull("sourceParamsId", this._SourceParamsId);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("density", this._Density);
			kparams.AddIfNotNull("stripProfiles", this._StripProfiles);
			kparams.AddIfNotNull("videoOffsetInPercentage", this._VideoOffsetInPercentage);
			kparams.AddIfNotNull("interval", this._Interval);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CROP_TYPE:
					return "CropType";
				case QUALITY:
					return "Quality";
				case CROP_X:
					return "CropX";
				case CROP_Y:
					return "CropY";
				case CROP_WIDTH:
					return "CropWidth";
				case CROP_HEIGHT:
					return "CropHeight";
				case VIDEO_OFFSET:
					return "VideoOffset";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case SCALE_WIDTH:
					return "ScaleWidth";
				case SCALE_HEIGHT:
					return "ScaleHeight";
				case BACKGROUND_COLOR:
					return "BackgroundColor";
				case SOURCE_PARAMS_ID:
					return "SourceParamsId";
				case FORMAT:
					return "Format";
				case DENSITY:
					return "Density";
				case STRIP_PROFILES:
					return "StripProfiles";
				case VIDEO_OFFSET_IN_PERCENTAGE:
					return "VideoOffsetInPercentage";
				case INTERVAL:
					return "Interval";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

