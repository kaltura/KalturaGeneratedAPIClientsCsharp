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
	public class KalturaFlavorParams : KalturaAssetParams
	{
		#region Private Fields
		private KalturaVideoCodec _VideoCodec = null;
		private int _VideoBitrate = Int32.MinValue;
		private KalturaAudioCodec _AudioCodec = null;
		private int _AudioBitrate = Int32.MinValue;
		private int _AudioChannels = Int32.MinValue;
		private int _AudioSampleRate = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private float _FrameRate = Single.MinValue;
		private int _GopSize = Int32.MinValue;
		private string _ConversionEngines = null;
		private string _ConversionEnginesExtraParams = null;
		private bool? _TwoPass = false;
		private int _Deinterlice = Int32.MinValue;
		private int _Rotate = Int32.MinValue;
		private string _Operators = null;
		private int _EngineVersion = Int32.MinValue;
		private KalturaContainerFormat _Format = null;
		private int _AspectRatioProcessingMode = Int32.MinValue;
		private int _ForceFrameToMultiplication16 = Int32.MinValue;
		private int _IsGopInSec = Int32.MinValue;
		private int _IsAvoidVideoShrinkFramesizeToSource = Int32.MinValue;
		private int _IsAvoidVideoShrinkBitrateToSource = Int32.MinValue;
		private int _IsVideoFrameRateForLowBrAppleHls = Int32.MinValue;
		private string _MultiStream = null;
		private float _AnamorphicPixels = Single.MinValue;
		private int _IsAvoidForcedKeyFrames = Int32.MinValue;
		private int _IsCropIMX = Int32.MinValue;
		private int _OptimizationPolicy = Int32.MinValue;
		private int _MaxFrameRate = Int32.MinValue;
		private int _VideoConstantBitrate = Int32.MinValue;
		private int _VideoBitrateTolerance = Int32.MinValue;
		private string _WatermarkData = null;
		private int _ClipOffset = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaVideoCodec VideoCodec
		{
			get { return _VideoCodec; }
			set 
			{ 
				_VideoCodec = value;
				OnPropertyChanged("VideoCodec");
			}
		}
		public int VideoBitrate
		{
			get { return _VideoBitrate; }
			set 
			{ 
				_VideoBitrate = value;
				OnPropertyChanged("VideoBitrate");
			}
		}
		public KalturaAudioCodec AudioCodec
		{
			get { return _AudioCodec; }
			set 
			{ 
				_AudioCodec = value;
				OnPropertyChanged("AudioCodec");
			}
		}
		public int AudioBitrate
		{
			get { return _AudioBitrate; }
			set 
			{ 
				_AudioBitrate = value;
				OnPropertyChanged("AudioBitrate");
			}
		}
		public int AudioChannels
		{
			get { return _AudioChannels; }
			set 
			{ 
				_AudioChannels = value;
				OnPropertyChanged("AudioChannels");
			}
		}
		public int AudioSampleRate
		{
			get { return _AudioSampleRate; }
			set 
			{ 
				_AudioSampleRate = value;
				OnPropertyChanged("AudioSampleRate");
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
		public float FrameRate
		{
			get { return _FrameRate; }
			set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		public int GopSize
		{
			get { return _GopSize; }
			set 
			{ 
				_GopSize = value;
				OnPropertyChanged("GopSize");
			}
		}
		public string ConversionEngines
		{
			get { return _ConversionEngines; }
			set 
			{ 
				_ConversionEngines = value;
				OnPropertyChanged("ConversionEngines");
			}
		}
		public string ConversionEnginesExtraParams
		{
			get { return _ConversionEnginesExtraParams; }
			set 
			{ 
				_ConversionEnginesExtraParams = value;
				OnPropertyChanged("ConversionEnginesExtraParams");
			}
		}
		public bool? TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
			}
		}
		public int Deinterlice
		{
			get { return _Deinterlice; }
			set 
			{ 
				_Deinterlice = value;
				OnPropertyChanged("Deinterlice");
			}
		}
		public int Rotate
		{
			get { return _Rotate; }
			set 
			{ 
				_Rotate = value;
				OnPropertyChanged("Rotate");
			}
		}
		public string Operators
		{
			get { return _Operators; }
			set 
			{ 
				_Operators = value;
				OnPropertyChanged("Operators");
			}
		}
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
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
		public int AspectRatioProcessingMode
		{
			get { return _AspectRatioProcessingMode; }
			set 
			{ 
				_AspectRatioProcessingMode = value;
				OnPropertyChanged("AspectRatioProcessingMode");
			}
		}
		public int ForceFrameToMultiplication16
		{
			get { return _ForceFrameToMultiplication16; }
			set 
			{ 
				_ForceFrameToMultiplication16 = value;
				OnPropertyChanged("ForceFrameToMultiplication16");
			}
		}
		public int IsGopInSec
		{
			get { return _IsGopInSec; }
			set 
			{ 
				_IsGopInSec = value;
				OnPropertyChanged("IsGopInSec");
			}
		}
		public int IsAvoidVideoShrinkFramesizeToSource
		{
			get { return _IsAvoidVideoShrinkFramesizeToSource; }
			set 
			{ 
				_IsAvoidVideoShrinkFramesizeToSource = value;
				OnPropertyChanged("IsAvoidVideoShrinkFramesizeToSource");
			}
		}
		public int IsAvoidVideoShrinkBitrateToSource
		{
			get { return _IsAvoidVideoShrinkBitrateToSource; }
			set 
			{ 
				_IsAvoidVideoShrinkBitrateToSource = value;
				OnPropertyChanged("IsAvoidVideoShrinkBitrateToSource");
			}
		}
		public int IsVideoFrameRateForLowBrAppleHls
		{
			get { return _IsVideoFrameRateForLowBrAppleHls; }
			set 
			{ 
				_IsVideoFrameRateForLowBrAppleHls = value;
				OnPropertyChanged("IsVideoFrameRateForLowBrAppleHls");
			}
		}
		public string MultiStream
		{
			get { return _MultiStream; }
			set 
			{ 
				_MultiStream = value;
				OnPropertyChanged("MultiStream");
			}
		}
		public float AnamorphicPixels
		{
			get { return _AnamorphicPixels; }
			set 
			{ 
				_AnamorphicPixels = value;
				OnPropertyChanged("AnamorphicPixels");
			}
		}
		public int IsAvoidForcedKeyFrames
		{
			get { return _IsAvoidForcedKeyFrames; }
			set 
			{ 
				_IsAvoidForcedKeyFrames = value;
				OnPropertyChanged("IsAvoidForcedKeyFrames");
			}
		}
		public int IsCropIMX
		{
			get { return _IsCropIMX; }
			set 
			{ 
				_IsCropIMX = value;
				OnPropertyChanged("IsCropIMX");
			}
		}
		public int OptimizationPolicy
		{
			get { return _OptimizationPolicy; }
			set 
			{ 
				_OptimizationPolicy = value;
				OnPropertyChanged("OptimizationPolicy");
			}
		}
		public int MaxFrameRate
		{
			get { return _MaxFrameRate; }
			set 
			{ 
				_MaxFrameRate = value;
				OnPropertyChanged("MaxFrameRate");
			}
		}
		public int VideoConstantBitrate
		{
			get { return _VideoConstantBitrate; }
			set 
			{ 
				_VideoConstantBitrate = value;
				OnPropertyChanged("VideoConstantBitrate");
			}
		}
		public int VideoBitrateTolerance
		{
			get { return _VideoBitrateTolerance; }
			set 
			{ 
				_VideoBitrateTolerance = value;
				OnPropertyChanged("VideoBitrateTolerance");
			}
		}
		public string WatermarkData
		{
			get { return _WatermarkData; }
			set 
			{ 
				_WatermarkData = value;
				OnPropertyChanged("WatermarkData");
			}
		}
		public int ClipOffset
		{
			get { return _ClipOffset; }
			set 
			{ 
				_ClipOffset = value;
				OnPropertyChanged("ClipOffset");
			}
		}
		public int ClipDuration
		{
			get { return _ClipDuration; }
			set 
			{ 
				_ClipDuration = value;
				OnPropertyChanged("ClipDuration");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorParams()
		{
		}

		public KalturaFlavorParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "videoCodec":
						this.VideoCodec = (KalturaVideoCodec)KalturaStringEnum.Parse(typeof(KalturaVideoCodec), txt);
						continue;
					case "videoBitrate":
						this.VideoBitrate = ParseInt(txt);
						continue;
					case "audioCodec":
						this.AudioCodec = (KalturaAudioCodec)KalturaStringEnum.Parse(typeof(KalturaAudioCodec), txt);
						continue;
					case "audioBitrate":
						this.AudioBitrate = ParseInt(txt);
						continue;
					case "audioChannels":
						this.AudioChannels = ParseInt(txt);
						continue;
					case "audioSampleRate":
						this.AudioSampleRate = ParseInt(txt);
						continue;
					case "width":
						this.Width = ParseInt(txt);
						continue;
					case "height":
						this.Height = ParseInt(txt);
						continue;
					case "frameRate":
						this.FrameRate = ParseFloat(txt);
						continue;
					case "gopSize":
						this.GopSize = ParseInt(txt);
						continue;
					case "conversionEngines":
						this.ConversionEngines = txt;
						continue;
					case "conversionEnginesExtraParams":
						this.ConversionEnginesExtraParams = txt;
						continue;
					case "twoPass":
						this.TwoPass = ParseBool(txt);
						continue;
					case "deinterlice":
						this.Deinterlice = ParseInt(txt);
						continue;
					case "rotate":
						this.Rotate = ParseInt(txt);
						continue;
					case "operators":
						this.Operators = txt;
						continue;
					case "engineVersion":
						this.EngineVersion = ParseInt(txt);
						continue;
					case "format":
						this.Format = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
					case "aspectRatioProcessingMode":
						this.AspectRatioProcessingMode = ParseInt(txt);
						continue;
					case "forceFrameToMultiplication16":
						this.ForceFrameToMultiplication16 = ParseInt(txt);
						continue;
					case "isGopInSec":
						this.IsGopInSec = ParseInt(txt);
						continue;
					case "isAvoidVideoShrinkFramesizeToSource":
						this.IsAvoidVideoShrinkFramesizeToSource = ParseInt(txt);
						continue;
					case "isAvoidVideoShrinkBitrateToSource":
						this.IsAvoidVideoShrinkBitrateToSource = ParseInt(txt);
						continue;
					case "isVideoFrameRateForLowBrAppleHls":
						this.IsVideoFrameRateForLowBrAppleHls = ParseInt(txt);
						continue;
					case "multiStream":
						this.MultiStream = txt;
						continue;
					case "anamorphicPixels":
						this.AnamorphicPixels = ParseFloat(txt);
						continue;
					case "isAvoidForcedKeyFrames":
						this.IsAvoidForcedKeyFrames = ParseInt(txt);
						continue;
					case "isCropIMX":
						this.IsCropIMX = ParseInt(txt);
						continue;
					case "optimizationPolicy":
						this.OptimizationPolicy = ParseInt(txt);
						continue;
					case "maxFrameRate":
						this.MaxFrameRate = ParseInt(txt);
						continue;
					case "videoConstantBitrate":
						this.VideoConstantBitrate = ParseInt(txt);
						continue;
					case "videoBitrateTolerance":
						this.VideoBitrateTolerance = ParseInt(txt);
						continue;
					case "watermarkData":
						this.WatermarkData = txt;
						continue;
					case "clipOffset":
						this.ClipOffset = ParseInt(txt);
						continue;
					case "clipDuration":
						this.ClipDuration = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFlavorParams");
			kparams.AddIfNotNull("videoCodec", this.VideoCodec);
			kparams.AddIfNotNull("videoBitrate", this.VideoBitrate);
			kparams.AddIfNotNull("audioCodec", this.AudioCodec);
			kparams.AddIfNotNull("audioBitrate", this.AudioBitrate);
			kparams.AddIfNotNull("audioChannels", this.AudioChannels);
			kparams.AddIfNotNull("audioSampleRate", this.AudioSampleRate);
			kparams.AddIfNotNull("width", this.Width);
			kparams.AddIfNotNull("height", this.Height);
			kparams.AddIfNotNull("frameRate", this.FrameRate);
			kparams.AddIfNotNull("gopSize", this.GopSize);
			kparams.AddIfNotNull("conversionEngines", this.ConversionEngines);
			kparams.AddIfNotNull("conversionEnginesExtraParams", this.ConversionEnginesExtraParams);
			kparams.AddIfNotNull("twoPass", this.TwoPass);
			kparams.AddIfNotNull("deinterlice", this.Deinterlice);
			kparams.AddIfNotNull("rotate", this.Rotate);
			kparams.AddIfNotNull("operators", this.Operators);
			kparams.AddIfNotNull("engineVersion", this.EngineVersion);
			kparams.AddIfNotNull("format", this.Format);
			kparams.AddIfNotNull("aspectRatioProcessingMode", this.AspectRatioProcessingMode);
			kparams.AddIfNotNull("forceFrameToMultiplication16", this.ForceFrameToMultiplication16);
			kparams.AddIfNotNull("isGopInSec", this.IsGopInSec);
			kparams.AddIfNotNull("isAvoidVideoShrinkFramesizeToSource", this.IsAvoidVideoShrinkFramesizeToSource);
			kparams.AddIfNotNull("isAvoidVideoShrinkBitrateToSource", this.IsAvoidVideoShrinkBitrateToSource);
			kparams.AddIfNotNull("isVideoFrameRateForLowBrAppleHls", this.IsVideoFrameRateForLowBrAppleHls);
			kparams.AddIfNotNull("multiStream", this.MultiStream);
			kparams.AddIfNotNull("anamorphicPixels", this.AnamorphicPixels);
			kparams.AddIfNotNull("isAvoidForcedKeyFrames", this.IsAvoidForcedKeyFrames);
			kparams.AddIfNotNull("isCropIMX", this.IsCropIMX);
			kparams.AddIfNotNull("optimizationPolicy", this.OptimizationPolicy);
			kparams.AddIfNotNull("maxFrameRate", this.MaxFrameRate);
			kparams.AddIfNotNull("videoConstantBitrate", this.VideoConstantBitrate);
			kparams.AddIfNotNull("videoBitrateTolerance", this.VideoBitrateTolerance);
			kparams.AddIfNotNull("watermarkData", this.WatermarkData);
			kparams.AddIfNotNull("clipOffset", this.ClipOffset);
			kparams.AddIfNotNull("clipDuration", this.ClipDuration);
			return kparams;
		}
		#endregion
	}
}

