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
using Kaltura.Enums;
using Kaltura.Request;

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
		#endregion

		#region Properties
		public ThumbCropType CropType
		{
			get { return _CropType; }
			set 
			{ 
				_CropType = value;
				OnPropertyChanged("CropType");
			}
		}
		public int Quality
		{
			get { return _Quality; }
			set 
			{ 
				_Quality = value;
				OnPropertyChanged("Quality");
			}
		}
		public int CropX
		{
			get { return _CropX; }
			set 
			{ 
				_CropX = value;
				OnPropertyChanged("CropX");
			}
		}
		public int CropY
		{
			get { return _CropY; }
			set 
			{ 
				_CropY = value;
				OnPropertyChanged("CropY");
			}
		}
		public int CropWidth
		{
			get { return _CropWidth; }
			set 
			{ 
				_CropWidth = value;
				OnPropertyChanged("CropWidth");
			}
		}
		public int CropHeight
		{
			get { return _CropHeight; }
			set 
			{ 
				_CropHeight = value;
				OnPropertyChanged("CropHeight");
			}
		}
		public float VideoOffset
		{
			get { return _VideoOffset; }
			set 
			{ 
				_VideoOffset = value;
				OnPropertyChanged("VideoOffset");
			}
		}
		public int Width
		{
			get { return _Width; }
			set 
			{ 
				_Width = value;
				OnPropertyChanged("Width");
			}
		}
		public int Height
		{
			get { return _Height; }
			set 
			{ 
				_Height = value;
				OnPropertyChanged("Height");
			}
		}
		public float ScaleWidth
		{
			get { return _ScaleWidth; }
			set 
			{ 
				_ScaleWidth = value;
				OnPropertyChanged("ScaleWidth");
			}
		}
		public float ScaleHeight
		{
			get { return _ScaleHeight; }
			set 
			{ 
				_ScaleHeight = value;
				OnPropertyChanged("ScaleHeight");
			}
		}
		public string BackgroundColor
		{
			get { return _BackgroundColor; }
			set 
			{ 
				_BackgroundColor = value;
				OnPropertyChanged("BackgroundColor");
			}
		}
		public int SourceParamsId
		{
			get { return _SourceParamsId; }
			set 
			{ 
				_SourceParamsId = value;
				OnPropertyChanged("SourceParamsId");
			}
		}
		public ContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		public int Density
		{
			get { return _Density; }
			set 
			{ 
				_Density = value;
				OnPropertyChanged("Density");
			}
		}
		public bool? StripProfiles
		{
			get { return _StripProfiles; }
			set 
			{ 
				_StripProfiles = value;
				OnPropertyChanged("StripProfiles");
			}
		}
		public int VideoOffsetInPercentage
		{
			get { return _VideoOffsetInPercentage; }
			set 
			{ 
				_VideoOffsetInPercentage = value;
				OnPropertyChanged("VideoOffsetInPercentage");
			}
		}
		#endregion

		#region CTor
		public ThumbParams()
		{
		}

		public ThumbParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "cropType":
						this._CropType = (ThumbCropType)ParseEnum(typeof(ThumbCropType), propertyNode.InnerText);
						continue;
					case "quality":
						this._Quality = ParseInt(propertyNode.InnerText);
						continue;
					case "cropX":
						this._CropX = ParseInt(propertyNode.InnerText);
						continue;
					case "cropY":
						this._CropY = ParseInt(propertyNode.InnerText);
						continue;
					case "cropWidth":
						this._CropWidth = ParseInt(propertyNode.InnerText);
						continue;
					case "cropHeight":
						this._CropHeight = ParseInt(propertyNode.InnerText);
						continue;
					case "videoOffset":
						this._VideoOffset = ParseFloat(propertyNode.InnerText);
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "scaleWidth":
						this._ScaleWidth = ParseFloat(propertyNode.InnerText);
						continue;
					case "scaleHeight":
						this._ScaleHeight = ParseFloat(propertyNode.InnerText);
						continue;
					case "backgroundColor":
						this._BackgroundColor = propertyNode.InnerText;
						continue;
					case "sourceParamsId":
						this._SourceParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "format":
						this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), propertyNode.InnerText);
						continue;
					case "density":
						this._Density = ParseInt(propertyNode.InnerText);
						continue;
					case "stripProfiles":
						this._StripProfiles = ParseBool(propertyNode.InnerText);
						continue;
					case "videoOffsetInPercentage":
						this._VideoOffsetInPercentage = ParseInt(propertyNode.InnerText);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

