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
	public class KalturaFlavorAsset : KalturaAsset
	{
		#region Private Fields
		private int _FlavorParamsId = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private int _Bitrate = Int32.MinValue;
		private float _FrameRate = Single.MinValue;
		private bool? _IsOriginal = false;
		private bool? _IsWeb = false;
		private string _ContainerFormat = null;
		private string _VideoCodecId = null;
		private KalturaFlavorAssetStatus _Status = (KalturaFlavorAssetStatus)Int32.MinValue;
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
		public int Bitrate
		{
			get { return _Bitrate; }
			set 
			{ 
				_Bitrate = value;
				OnPropertyChanged("Bitrate");
			}
		}
		public float FrameRate
		{
			get { return _FrameRate; }
			set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		public bool? IsOriginal
		{
			get { return _IsOriginal; }
			set 
			{ 
				_IsOriginal = value;
				OnPropertyChanged("IsOriginal");
			}
		}
		public bool? IsWeb
		{
			get { return _IsWeb; }
			set 
			{ 
				_IsWeb = value;
				OnPropertyChanged("IsWeb");
			}
		}
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
			set 
			{ 
				_ContainerFormat = value;
				OnPropertyChanged("ContainerFormat");
			}
		}
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
			set 
			{ 
				_VideoCodecId = value;
				OnPropertyChanged("VideoCodecId");
			}
		}
		public KalturaFlavorAssetStatus Status
		{
			get { return _Status; }
			set 
			{ 
				_Status = value;
				OnPropertyChanged("Status");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorAsset()
		{
		}

		public KalturaFlavorAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsId":
						this.FlavorParamsId = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "bitrate":
						this.Bitrate = ParseInt(txt);
						continue;
					case "frameRate":
						this.FrameRate = ParseFloat(txt);
						continue;
					case "isOriginal":
						this.IsOriginal = ParseBool(txt);
						continue;
					case "isWeb":
						this.IsWeb = ParseBool(txt);
						continue;
					case "containerFormat":
						this.ContainerFormat = txt;
						continue;
					case "videoCodecId":
						this.VideoCodecId = txt;
						continue;
					case "status":
						this.Status = (KalturaFlavorAssetStatus)ParseEnum(typeof(KalturaFlavorAssetStatus), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFlavorAsset");
			kparams.AddIfNotNull("flavorParamsId", this.FlavorParamsId);
			kparams.AddIfNotNull("width", this.Width);
			kparams.AddIfNotNull("height", this.Height);
			kparams.AddIfNotNull("bitrate", this.Bitrate);
			kparams.AddIfNotNull("frameRate", this.FrameRate);
			kparams.AddIfNotNull("isOriginal", this.IsOriginal);
			kparams.AddIfNotNull("isWeb", this.IsWeb);
			kparams.AddIfNotNull("containerFormat", this.ContainerFormat);
			kparams.AddIfNotNull("videoCodecId", this.VideoCodecId);
			kparams.AddIfNotNull("status", this.Status);
			return kparams;
		}
		#endregion
	}
}

