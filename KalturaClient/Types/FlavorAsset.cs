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
		private float _FrameRate = Single.MinValue;
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
		public int FlavorParamsId
		{
			get { return _FlavorParamsId; }
			set 
			{ 
				_FlavorParamsId = value;
				OnPropertyChanged("FlavorParamsId");
			}
		}
		public int Width
		{
			get { return _Width; }
		}
		public int Height
		{
			get { return _Height; }
		}
		public int Bitrate
		{
			get { return _Bitrate; }
		}
		public float FrameRate
		{
			get { return _FrameRate; }
		}
		public bool? IsOriginal
		{
			get { return _IsOriginal; }
		}
		public bool? IsWeb
		{
			get { return _IsWeb; }
		}
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
		}
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
		}
		public FlavorAssetStatus Status
		{
			get { return _Status; }
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
		public string Label
		{
			get { return _Label; }
			set 
			{ 
				_Label = value;
				OnPropertyChanged("Label");
			}
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
		#endregion

		#region CTor
		public FlavorAsset()
		{
		}

		public FlavorAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this._FlavorParamsId = ParseInt(propertyNode.InnerText);
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "bitrate":
						this._Bitrate = ParseInt(propertyNode.InnerText);
						continue;
					case "frameRate":
						this._FrameRate = ParseFloat(propertyNode.InnerText);
						continue;
					case "isOriginal":
						this._IsOriginal = ParseBool(propertyNode.InnerText);
						continue;
					case "isWeb":
						this._IsWeb = ParseBool(propertyNode.InnerText);
						continue;
					case "containerFormat":
						this._ContainerFormat = propertyNode.InnerText;
						continue;
					case "videoCodecId":
						this._VideoCodecId = propertyNode.InnerText;
						continue;
					case "status":
						this._Status = (FlavorAssetStatus)ParseEnum(typeof(FlavorAssetStatus), propertyNode.InnerText);
						continue;
					case "language":
						this._Language = (Language)StringEnum.Parse(typeof(Language), propertyNode.InnerText);
						continue;
					case "label":
						this._Label = propertyNode.InnerText;
						continue;
					case "isDefault":
						this._IsDefault = (NullableBoolean)ParseEnum(typeof(NullableBoolean), propertyNode.InnerText);
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

