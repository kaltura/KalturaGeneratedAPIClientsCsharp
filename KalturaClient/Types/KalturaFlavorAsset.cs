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
		private bool? _IsOriginal = null;
		private bool? _IsWeb = null;
		private string _ContainerFormat = null;
		private string _VideoCodecId = null;
		private KalturaFlavorAssetStatus _Status = (KalturaFlavorAssetStatus)Int32.MinValue;
		private KalturaLanguage _Language = null;
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
		public KalturaFlavorAssetStatus Status
		{
			get { return _Status; }
		}
		public KalturaLanguage Language
		{
			get { return _Language; }
			set 
			{ 
				_Language = value;
				OnPropertyChanged("Language");
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
						this._FlavorParamsId = ParseInt(txt);
						continue;
					case "width":
						this._Width = ParseInt(txt);
						continue;
					case "height":
						this._Height = ParseInt(txt);
						continue;
					case "bitrate":
						this._Bitrate = ParseInt(txt);
						continue;
					case "frameRate":
						this._FrameRate = ParseFloat(txt);
						continue;
					case "isOriginal":
						this._IsOriginal = ParseBool(txt);
						continue;
					case "isWeb":
						this._IsWeb = ParseBool(txt);
						continue;
					case "containerFormat":
						this._ContainerFormat = txt;
						continue;
					case "videoCodecId":
						this._VideoCodecId = txt;
						continue;
					case "status":
						this._Status = (KalturaFlavorAssetStatus)ParseEnum(typeof(KalturaFlavorAssetStatus), txt);
						continue;
					case "language":
						this._Language = (KalturaLanguage)KalturaStringEnum.Parse(typeof(KalturaLanguage), txt);
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
			kparams.AddIfNotNull("language", this.Language);
			return kparams;
		}
		#endregion
	}
}

