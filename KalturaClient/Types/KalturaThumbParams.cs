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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaThumbParams : KalturaAssetParams
	{
		#region Private Fields
		private KalturaThumbCropType _CropType = (KalturaThumbCropType)Int32.MinValue;
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
		private KalturaContainerFormat _Format = null;
		private int _Density = Int32.MinValue;
		private bool? _StripProfiles = false;
		private int _VideoOffsetInPercentage = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaThumbCropType CropType
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
		public KalturaContainerFormat Format
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
		public KalturaThumbParams()
		{
		}

		public KalturaThumbParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "cropType":
						this.CropType = (KalturaThumbCropType)ParseEnum(typeof(KalturaThumbCropType), txt);
						continue;
					case "quality":
						this.Quality = ParseInt(txt);
						continue;
					case "cropX":
						this.CropX = ParseInt(txt);
						continue;
					case "cropY":
						this.CropY = ParseInt(txt);
						continue;
					case "cropWidth":
						this.CropWidth = ParseInt(txt);
						continue;
					case "cropHeight":
						this.CropHeight = ParseInt(txt);
						continue;
					case "videoOffset":
						this.VideoOffset = ParseFloat(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "scaleWidth":
						this.ScaleWidth = ParseFloat(txt);
						continue;
					case "scaleHeight":
						this.ScaleHeight = ParseFloat(txt);
						continue;
					case "backgroundColor":
						this.BackgroundColor = txt;
						continue;
					case "sourceParamsId":
						this.SourceParamsId = ParseInt(txt);
						continue;
					case "format":
						this.Format = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
					case "density":
						this.Density = ParseInt(txt);
						continue;
					case "stripProfiles":
						this.StripProfiles = ParseBool(txt);
						continue;
					case "videoOffsetInPercentage":
						this.VideoOffsetInPercentage = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaThumbParams");
			kparams.AddIfNotNull("cropType", this.CropType);
			kparams.AddIfNotNull("quality", this.Quality);
			kparams.AddIfNotNull("cropX", this.CropX);
			kparams.AddIfNotNull("cropY", this.CropY);
			kparams.AddIfNotNull("cropWidth", this.CropWidth);
			kparams.AddIfNotNull("cropHeight", this.CropHeight);
			kparams.AddIfNotNull("videoOffset", this.VideoOffset);
			kparams.AddIfNotNull("width", this.Width);
			kparams.AddIfNotNull("height", this.Height);
			kparams.AddIfNotNull("scaleWidth", this.ScaleWidth);
			kparams.AddIfNotNull("scaleHeight", this.ScaleHeight);
			kparams.AddIfNotNull("backgroundColor", this.BackgroundColor);
			kparams.AddIfNotNull("sourceParamsId", this.SourceParamsId);
			kparams.AddIfNotNull("format", this.Format);
			kparams.AddIfNotNull("density", this.Density);
			kparams.AddIfNotNull("stripProfiles", this.StripProfiles);
			kparams.AddIfNotNull("videoOffsetInPercentage", this.VideoOffsetInPercentage);
			return kparams;
		}
		#endregion
	}
}

