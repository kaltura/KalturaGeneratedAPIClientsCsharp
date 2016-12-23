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
	public class FlavorParams : AssetParams
	{
		#region Constants
		public const string VIDEO_CODEC = "videoCodec";
		public const string VIDEO_BITRATE = "videoBitrate";
		public const string AUDIO_CODEC = "audioCodec";
		public const string AUDIO_BITRATE = "audioBitrate";
		public const string AUDIO_CHANNELS = "audioChannels";
		public const string AUDIO_SAMPLE_RATE = "audioSampleRate";
		public const string WIDTH = "width";
		public const string HEIGHT = "height";
		public const string FRAME_RATE = "frameRate";
		public const string GOP_SIZE = "gopSize";
		public const string CONVERSION_ENGINES = "conversionEngines";
		public const string CONVERSION_ENGINES_EXTRA_PARAMS = "conversionEnginesExtraParams";
		public const string TWO_PASS = "twoPass";
		public const string DEINTERLICE = "deinterlice";
		public const string ROTATE = "rotate";
		public const string OPERATORS = "operators";
		public const string ENGINE_VERSION = "engineVersion";
		public const string FORMAT = "format";
		public const string ASPECT_RATIO_PROCESSING_MODE = "aspectRatioProcessingMode";
		public const string FORCE_FRAME_TO_MULTIPLICATION16 = "forceFrameToMultiplication16";
		public const string IS_GOP_IN_SEC = "isGopInSec";
		public const string IS_AVOID_VIDEO_SHRINK_FRAMESIZE_TO_SOURCE = "isAvoidVideoShrinkFramesizeToSource";
		public const string IS_AVOID_VIDEO_SHRINK_BITRATE_TO_SOURCE = "isAvoidVideoShrinkBitrateToSource";
		public const string IS_VIDEO_FRAME_RATE_FOR_LOW_BR_APPLE_HLS = "isVideoFrameRateForLowBrAppleHls";
		public const string MULTI_STREAM = "multiStream";
		public const string ANAMORPHIC_PIXELS = "anamorphicPixels";
		public const string IS_AVOID_FORCED_KEY_FRAMES = "isAvoidForcedKeyFrames";
		public const string IS_CROP_IMX = "isCropIMX";
		public const string OPTIMIZATION_POLICY = "optimizationPolicy";
		public const string MAX_FRAME_RATE = "maxFrameRate";
		public const string VIDEO_CONSTANT_BITRATE = "videoConstantBitrate";
		public const string VIDEO_BITRATE_TOLERANCE = "videoBitrateTolerance";
		public const string WATERMARK_DATA = "watermarkData";
		public const string SUBTITLES_DATA = "subtitlesData";
		public const string IS_ENCRYPTED = "isEncrypted";
		public const string CONTENT_AWARENESS = "contentAwareness";
		public const string CLIP_OFFSET = "clipOffset";
		public const string CLIP_DURATION = "clipDuration";
		#endregion

		#region Private Fields
		private VideoCodec _VideoCodec = null;
		private int _VideoBitrate = Int32.MinValue;
		private AudioCodec _AudioCodec = null;
		private int _AudioBitrate = Int32.MinValue;
		private int _AudioChannels = Int32.MinValue;
		private int _AudioSampleRate = Int32.MinValue;
		private int _Width = Int32.MinValue;
		private int _Height = Int32.MinValue;
		private float _FrameRate = Single.MinValue;
		private int _GopSize = Int32.MinValue;
		private string _ConversionEngines = null;
		private string _ConversionEnginesExtraParams = null;
		private bool? _TwoPass = null;
		private int _Deinterlice = Int32.MinValue;
		private int _Rotate = Int32.MinValue;
		private string _Operators = null;
		private int _EngineVersion = Int32.MinValue;
		private ContainerFormat _Format = null;
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
		private string _SubtitlesData = null;
		private int _IsEncrypted = Int32.MinValue;
		private float _ContentAwareness = Single.MinValue;
		private int _ClipOffset = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		#endregion

		#region Properties
		public VideoCodec VideoCodec
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
		public AudioCodec AudioCodec
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
		public ContainerFormat Format
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
		public string SubtitlesData
		{
			get { return _SubtitlesData; }
			set 
			{ 
				_SubtitlesData = value;
				OnPropertyChanged("SubtitlesData");
			}
		}
		public int IsEncrypted
		{
			get { return _IsEncrypted; }
			set 
			{ 
				_IsEncrypted = value;
				OnPropertyChanged("IsEncrypted");
			}
		}
		public float ContentAwareness
		{
			get { return _ContentAwareness; }
			set 
			{ 
				_ContentAwareness = value;
				OnPropertyChanged("ContentAwareness");
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
		public FlavorParams()
		{
		}

		public FlavorParams(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "videoCodec":
						this._VideoCodec = (VideoCodec)StringEnum.Parse(typeof(VideoCodec), propertyNode.InnerText);
						continue;
					case "videoBitrate":
						this._VideoBitrate = ParseInt(propertyNode.InnerText);
						continue;
					case "audioCodec":
						this._AudioCodec = (AudioCodec)StringEnum.Parse(typeof(AudioCodec), propertyNode.InnerText);
						continue;
					case "audioBitrate":
						this._AudioBitrate = ParseInt(propertyNode.InnerText);
						continue;
					case "audioChannels":
						this._AudioChannels = ParseInt(propertyNode.InnerText);
						continue;
					case "audioSampleRate":
						this._AudioSampleRate = ParseInt(propertyNode.InnerText);
						continue;
					case "width":
						this._Width = ParseInt(propertyNode.InnerText);
						continue;
					case "height":
						this._Height = ParseInt(propertyNode.InnerText);
						continue;
					case "frameRate":
						this._FrameRate = ParseFloat(propertyNode.InnerText);
						continue;
					case "gopSize":
						this._GopSize = ParseInt(propertyNode.InnerText);
						continue;
					case "conversionEngines":
						this._ConversionEngines = propertyNode.InnerText;
						continue;
					case "conversionEnginesExtraParams":
						this._ConversionEnginesExtraParams = propertyNode.InnerText;
						continue;
					case "twoPass":
						this._TwoPass = ParseBool(propertyNode.InnerText);
						continue;
					case "deinterlice":
						this._Deinterlice = ParseInt(propertyNode.InnerText);
						continue;
					case "rotate":
						this._Rotate = ParseInt(propertyNode.InnerText);
						continue;
					case "operators":
						this._Operators = propertyNode.InnerText;
						continue;
					case "engineVersion":
						this._EngineVersion = ParseInt(propertyNode.InnerText);
						continue;
					case "format":
						this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), propertyNode.InnerText);
						continue;
					case "aspectRatioProcessingMode":
						this._AspectRatioProcessingMode = ParseInt(propertyNode.InnerText);
						continue;
					case "forceFrameToMultiplication16":
						this._ForceFrameToMultiplication16 = ParseInt(propertyNode.InnerText);
						continue;
					case "isGopInSec":
						this._IsGopInSec = ParseInt(propertyNode.InnerText);
						continue;
					case "isAvoidVideoShrinkFramesizeToSource":
						this._IsAvoidVideoShrinkFramesizeToSource = ParseInt(propertyNode.InnerText);
						continue;
					case "isAvoidVideoShrinkBitrateToSource":
						this._IsAvoidVideoShrinkBitrateToSource = ParseInt(propertyNode.InnerText);
						continue;
					case "isVideoFrameRateForLowBrAppleHls":
						this._IsVideoFrameRateForLowBrAppleHls = ParseInt(propertyNode.InnerText);
						continue;
					case "multiStream":
						this._MultiStream = propertyNode.InnerText;
						continue;
					case "anamorphicPixels":
						this._AnamorphicPixels = ParseFloat(propertyNode.InnerText);
						continue;
					case "isAvoidForcedKeyFrames":
						this._IsAvoidForcedKeyFrames = ParseInt(propertyNode.InnerText);
						continue;
					case "isCropIMX":
						this._IsCropIMX = ParseInt(propertyNode.InnerText);
						continue;
					case "optimizationPolicy":
						this._OptimizationPolicy = ParseInt(propertyNode.InnerText);
						continue;
					case "maxFrameRate":
						this._MaxFrameRate = ParseInt(propertyNode.InnerText);
						continue;
					case "videoConstantBitrate":
						this._VideoConstantBitrate = ParseInt(propertyNode.InnerText);
						continue;
					case "videoBitrateTolerance":
						this._VideoBitrateTolerance = ParseInt(propertyNode.InnerText);
						continue;
					case "watermarkData":
						this._WatermarkData = propertyNode.InnerText;
						continue;
					case "subtitlesData":
						this._SubtitlesData = propertyNode.InnerText;
						continue;
					case "isEncrypted":
						this._IsEncrypted = ParseInt(propertyNode.InnerText);
						continue;
					case "contentAwareness":
						this._ContentAwareness = ParseFloat(propertyNode.InnerText);
						continue;
					case "clipOffset":
						this._ClipOffset = ParseInt(propertyNode.InnerText);
						continue;
					case "clipDuration":
						this._ClipDuration = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaFlavorParams");
			kparams.AddIfNotNull("videoCodec", this._VideoCodec);
			kparams.AddIfNotNull("videoBitrate", this._VideoBitrate);
			kparams.AddIfNotNull("audioCodec", this._AudioCodec);
			kparams.AddIfNotNull("audioBitrate", this._AudioBitrate);
			kparams.AddIfNotNull("audioChannels", this._AudioChannels);
			kparams.AddIfNotNull("audioSampleRate", this._AudioSampleRate);
			kparams.AddIfNotNull("width", this._Width);
			kparams.AddIfNotNull("height", this._Height);
			kparams.AddIfNotNull("frameRate", this._FrameRate);
			kparams.AddIfNotNull("gopSize", this._GopSize);
			kparams.AddIfNotNull("conversionEngines", this._ConversionEngines);
			kparams.AddIfNotNull("conversionEnginesExtraParams", this._ConversionEnginesExtraParams);
			kparams.AddIfNotNull("twoPass", this._TwoPass);
			kparams.AddIfNotNull("deinterlice", this._Deinterlice);
			kparams.AddIfNotNull("rotate", this._Rotate);
			kparams.AddIfNotNull("operators", this._Operators);
			kparams.AddIfNotNull("engineVersion", this._EngineVersion);
			kparams.AddIfNotNull("format", this._Format);
			kparams.AddIfNotNull("aspectRatioProcessingMode", this._AspectRatioProcessingMode);
			kparams.AddIfNotNull("forceFrameToMultiplication16", this._ForceFrameToMultiplication16);
			kparams.AddIfNotNull("isGopInSec", this._IsGopInSec);
			kparams.AddIfNotNull("isAvoidVideoShrinkFramesizeToSource", this._IsAvoidVideoShrinkFramesizeToSource);
			kparams.AddIfNotNull("isAvoidVideoShrinkBitrateToSource", this._IsAvoidVideoShrinkBitrateToSource);
			kparams.AddIfNotNull("isVideoFrameRateForLowBrAppleHls", this._IsVideoFrameRateForLowBrAppleHls);
			kparams.AddIfNotNull("multiStream", this._MultiStream);
			kparams.AddIfNotNull("anamorphicPixels", this._AnamorphicPixels);
			kparams.AddIfNotNull("isAvoidForcedKeyFrames", this._IsAvoidForcedKeyFrames);
			kparams.AddIfNotNull("isCropIMX", this._IsCropIMX);
			kparams.AddIfNotNull("optimizationPolicy", this._OptimizationPolicy);
			kparams.AddIfNotNull("maxFrameRate", this._MaxFrameRate);
			kparams.AddIfNotNull("videoConstantBitrate", this._VideoConstantBitrate);
			kparams.AddIfNotNull("videoBitrateTolerance", this._VideoBitrateTolerance);
			kparams.AddIfNotNull("watermarkData", this._WatermarkData);
			kparams.AddIfNotNull("subtitlesData", this._SubtitlesData);
			kparams.AddIfNotNull("isEncrypted", this._IsEncrypted);
			kparams.AddIfNotNull("contentAwareness", this._ContentAwareness);
			kparams.AddIfNotNull("clipOffset", this._ClipOffset);
			kparams.AddIfNotNull("clipDuration", this._ClipDuration);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_CODEC:
					return "VideoCodec";
				case VIDEO_BITRATE:
					return "VideoBitrate";
				case AUDIO_CODEC:
					return "AudioCodec";
				case AUDIO_BITRATE:
					return "AudioBitrate";
				case AUDIO_CHANNELS:
					return "AudioChannels";
				case AUDIO_SAMPLE_RATE:
					return "AudioSampleRate";
				case WIDTH:
					return "Width";
				case HEIGHT:
					return "Height";
				case FRAME_RATE:
					return "FrameRate";
				case GOP_SIZE:
					return "GopSize";
				case CONVERSION_ENGINES:
					return "ConversionEngines";
				case CONVERSION_ENGINES_EXTRA_PARAMS:
					return "ConversionEnginesExtraParams";
				case TWO_PASS:
					return "TwoPass";
				case DEINTERLICE:
					return "Deinterlice";
				case ROTATE:
					return "Rotate";
				case OPERATORS:
					return "Operators";
				case ENGINE_VERSION:
					return "EngineVersion";
				case FORMAT:
					return "Format";
				case ASPECT_RATIO_PROCESSING_MODE:
					return "AspectRatioProcessingMode";
				case FORCE_FRAME_TO_MULTIPLICATION16:
					return "ForceFrameToMultiplication16";
				case IS_GOP_IN_SEC:
					return "IsGopInSec";
				case IS_AVOID_VIDEO_SHRINK_FRAMESIZE_TO_SOURCE:
					return "IsAvoidVideoShrinkFramesizeToSource";
				case IS_AVOID_VIDEO_SHRINK_BITRATE_TO_SOURCE:
					return "IsAvoidVideoShrinkBitrateToSource";
				case IS_VIDEO_FRAME_RATE_FOR_LOW_BR_APPLE_HLS:
					return "IsVideoFrameRateForLowBrAppleHls";
				case MULTI_STREAM:
					return "MultiStream";
				case ANAMORPHIC_PIXELS:
					return "AnamorphicPixels";
				case IS_AVOID_FORCED_KEY_FRAMES:
					return "IsAvoidForcedKeyFrames";
				case IS_CROP_IMX:
					return "IsCropIMX";
				case OPTIMIZATION_POLICY:
					return "OptimizationPolicy";
				case MAX_FRAME_RATE:
					return "MaxFrameRate";
				case VIDEO_CONSTANT_BITRATE:
					return "VideoConstantBitrate";
				case VIDEO_BITRATE_TOLERANCE:
					return "VideoBitrateTolerance";
				case WATERMARK_DATA:
					return "WatermarkData";
				case SUBTITLES_DATA:
					return "SubtitlesData";
				case IS_ENCRYPTED:
					return "IsEncrypted";
				case CONTENT_AWARENESS:
					return "ContentAwareness";
				case CLIP_OFFSET:
					return "ClipOffset";
				case CLIP_DURATION:
					return "ClipDuration";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

