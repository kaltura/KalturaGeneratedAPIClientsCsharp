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
// Copyright (C) 2006-2023  Kaltura Inc.
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
		public const string FORCED_KEY_FRAMES_MODE = "forcedKeyFramesMode";
		public const string IS_CROP_IMX = "isCropIMX";
		public const string OPTIMIZATION_POLICY = "optimizationPolicy";
		public const string MAX_FRAME_RATE = "maxFrameRate";
		public const string VIDEO_CONSTANT_BITRATE = "videoConstantBitrate";
		public const string VIDEO_BITRATE_TOLERANCE = "videoBitrateTolerance";
		public const string WATERMARK_DATA = "watermarkData";
		public const string SUBTITLES_DATA = "subtitlesData";
		public const string IS_ENCRYPTED = "isEncrypted";
		public const string CONTENT_AWARENESS = "contentAwareness";
		public const string CHUNKED_ENCODE_MODE = "chunkedEncodeMode";
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
		private double _FrameRate = Double.MinValue;
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
		private double _AnamorphicPixels = Double.MinValue;
		private int _IsAvoidForcedKeyFrames = Int32.MinValue;
		private int _ForcedKeyFramesMode = Int32.MinValue;
		private int _IsCropIMX = Int32.MinValue;
		private int _OptimizationPolicy = Int32.MinValue;
		private int _MaxFrameRate = Int32.MinValue;
		private int _VideoConstantBitrate = Int32.MinValue;
		private int _VideoBitrateTolerance = Int32.MinValue;
		private string _WatermarkData = null;
		private string _SubtitlesData = null;
		private int _IsEncrypted = Int32.MinValue;
		private double _ContentAwareness = Double.MinValue;
		private int _ChunkedEncodeMode = Int32.MinValue;
		private int _ClipOffset = Int32.MinValue;
		private int _ClipDuration = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use VideoCodecAsDouble property instead
		/// </summary>
		[JsonProperty]
		public VideoCodec VideoCodec
		{
			get { return _VideoCodec; }
			set 
			{ 
				_VideoCodec = value;
				OnPropertyChanged("VideoCodec");
			}
		}
		/// <summary>
		/// Use VideoBitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoBitrate
		{
			get { return _VideoBitrate; }
			set 
			{ 
				_VideoBitrate = value;
				OnPropertyChanged("VideoBitrate");
			}
		}
		/// <summary>
		/// Use AudioCodecAsDouble property instead
		/// </summary>
		[JsonProperty]
		public AudioCodec AudioCodec
		{
			get { return _AudioCodec; }
			set 
			{ 
				_AudioCodec = value;
				OnPropertyChanged("AudioCodec");
			}
		}
		/// <summary>
		/// Use AudioBitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioBitrate
		{
			get { return _AudioBitrate; }
			set 
			{ 
				_AudioBitrate = value;
				OnPropertyChanged("AudioBitrate");
			}
		}
		/// <summary>
		/// Use AudioChannelsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioChannels
		{
			get { return _AudioChannels; }
			set 
			{ 
				_AudioChannels = value;
				OnPropertyChanged("AudioChannels");
			}
		}
		/// <summary>
		/// Use AudioSampleRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioSampleRate
		{
			get { return _AudioSampleRate; }
			set 
			{ 
				_AudioSampleRate = value;
				OnPropertyChanged("AudioSampleRate");
			}
		}
		/// <summary>
		/// Use WidthAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use HeightAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use FrameRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double FrameRate
		{
			get { return _FrameRate; }
			set 
			{ 
				_FrameRate = value;
				OnPropertyChanged("FrameRate");
			}
		}
		/// <summary>
		/// Use GopSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int GopSize
		{
			get { return _GopSize; }
			set 
			{ 
				_GopSize = value;
				OnPropertyChanged("GopSize");
			}
		}
		/// <summary>
		/// Use ConversionEnginesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ConversionEngines
		{
			get { return _ConversionEngines; }
			set 
			{ 
				_ConversionEngines = value;
				OnPropertyChanged("ConversionEngines");
			}
		}
		/// <summary>
		/// Use ConversionEnginesExtraParamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ConversionEnginesExtraParams
		{
			get { return _ConversionEnginesExtraParams; }
			set 
			{ 
				_ConversionEnginesExtraParams = value;
				OnPropertyChanged("ConversionEnginesExtraParams");
			}
		}
		/// <summary>
		/// Use TwoPassAsDouble property instead
		/// </summary>
		[JsonProperty]
		public bool? TwoPass
		{
			get { return _TwoPass; }
			set 
			{ 
				_TwoPass = value;
				OnPropertyChanged("TwoPass");
			}
		}
		/// <summary>
		/// Use DeinterliceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Deinterlice
		{
			get { return _Deinterlice; }
			set 
			{ 
				_Deinterlice = value;
				OnPropertyChanged("Deinterlice");
			}
		}
		/// <summary>
		/// Use RotateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Rotate
		{
			get { return _Rotate; }
			set 
			{ 
				_Rotate = value;
				OnPropertyChanged("Rotate");
			}
		}
		/// <summary>
		/// Use OperatorsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string Operators
		{
			get { return _Operators; }
			set 
			{ 
				_Operators = value;
				OnPropertyChanged("Operators");
			}
		}
		/// <summary>
		/// Use EngineVersionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int EngineVersion
		{
			get { return _EngineVersion; }
			set 
			{ 
				_EngineVersion = value;
				OnPropertyChanged("EngineVersion");
			}
		}
		/// <summary>
		/// Use FormatAsDouble property instead
		/// </summary>
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
		/// <summary>
		/// Use AspectRatioProcessingModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AspectRatioProcessingMode
		{
			get { return _AspectRatioProcessingMode; }
			set 
			{ 
				_AspectRatioProcessingMode = value;
				OnPropertyChanged("AspectRatioProcessingMode");
			}
		}
		/// <summary>
		/// Use ForceFrameToMultiplication16AsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ForceFrameToMultiplication16
		{
			get { return _ForceFrameToMultiplication16; }
			set 
			{ 
				_ForceFrameToMultiplication16 = value;
				OnPropertyChanged("ForceFrameToMultiplication16");
			}
		}
		/// <summary>
		/// Use IsGopInSecAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsGopInSec
		{
			get { return _IsGopInSec; }
			set 
			{ 
				_IsGopInSec = value;
				OnPropertyChanged("IsGopInSec");
			}
		}
		/// <summary>
		/// Use IsAvoidVideoShrinkFramesizeToSourceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsAvoidVideoShrinkFramesizeToSource
		{
			get { return _IsAvoidVideoShrinkFramesizeToSource; }
			set 
			{ 
				_IsAvoidVideoShrinkFramesizeToSource = value;
				OnPropertyChanged("IsAvoidVideoShrinkFramesizeToSource");
			}
		}
		/// <summary>
		/// Use IsAvoidVideoShrinkBitrateToSourceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsAvoidVideoShrinkBitrateToSource
		{
			get { return _IsAvoidVideoShrinkBitrateToSource; }
			set 
			{ 
				_IsAvoidVideoShrinkBitrateToSource = value;
				OnPropertyChanged("IsAvoidVideoShrinkBitrateToSource");
			}
		}
		/// <summary>
		/// Use IsVideoFrameRateForLowBrAppleHlsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsVideoFrameRateForLowBrAppleHls
		{
			get { return _IsVideoFrameRateForLowBrAppleHls; }
			set 
			{ 
				_IsVideoFrameRateForLowBrAppleHls = value;
				OnPropertyChanged("IsVideoFrameRateForLowBrAppleHls");
			}
		}
		/// <summary>
		/// Use MultiStreamAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MultiStream
		{
			get { return _MultiStream; }
			set 
			{ 
				_MultiStream = value;
				OnPropertyChanged("MultiStream");
			}
		}
		/// <summary>
		/// Use AnamorphicPixelsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double AnamorphicPixels
		{
			get { return _AnamorphicPixels; }
			set 
			{ 
				_AnamorphicPixels = value;
				OnPropertyChanged("AnamorphicPixels");
			}
		}
		/// <summary>
		/// Use IsAvoidForcedKeyFramesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsAvoidForcedKeyFrames
		{
			get { return _IsAvoidForcedKeyFrames; }
			set 
			{ 
				_IsAvoidForcedKeyFrames = value;
				OnPropertyChanged("IsAvoidForcedKeyFrames");
			}
		}
		/// <summary>
		/// Use ForcedKeyFramesModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ForcedKeyFramesMode
		{
			get { return _ForcedKeyFramesMode; }
			set 
			{ 
				_ForcedKeyFramesMode = value;
				OnPropertyChanged("ForcedKeyFramesMode");
			}
		}
		/// <summary>
		/// Use IsCropIMXAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsCropIMX
		{
			get { return _IsCropIMX; }
			set 
			{ 
				_IsCropIMX = value;
				OnPropertyChanged("IsCropIMX");
			}
		}
		/// <summary>
		/// Use OptimizationPolicyAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int OptimizationPolicy
		{
			get { return _OptimizationPolicy; }
			set 
			{ 
				_OptimizationPolicy = value;
				OnPropertyChanged("OptimizationPolicy");
			}
		}
		/// <summary>
		/// Use MaxFrameRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int MaxFrameRate
		{
			get { return _MaxFrameRate; }
			set 
			{ 
				_MaxFrameRate = value;
				OnPropertyChanged("MaxFrameRate");
			}
		}
		/// <summary>
		/// Use VideoConstantBitrateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoConstantBitrate
		{
			get { return _VideoConstantBitrate; }
			set 
			{ 
				_VideoConstantBitrate = value;
				OnPropertyChanged("VideoConstantBitrate");
			}
		}
		/// <summary>
		/// Use VideoBitrateToleranceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoBitrateTolerance
		{
			get { return _VideoBitrateTolerance; }
			set 
			{ 
				_VideoBitrateTolerance = value;
				OnPropertyChanged("VideoBitrateTolerance");
			}
		}
		/// <summary>
		/// Use WatermarkDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string WatermarkData
		{
			get { return _WatermarkData; }
			set 
			{ 
				_WatermarkData = value;
				OnPropertyChanged("WatermarkData");
			}
		}
		/// <summary>
		/// Use SubtitlesDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string SubtitlesData
		{
			get { return _SubtitlesData; }
			set 
			{ 
				_SubtitlesData = value;
				OnPropertyChanged("SubtitlesData");
			}
		}
		/// <summary>
		/// Use IsEncryptedAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsEncrypted
		{
			get { return _IsEncrypted; }
			set 
			{ 
				_IsEncrypted = value;
				OnPropertyChanged("IsEncrypted");
			}
		}
		/// <summary>
		/// Use ContentAwarenessAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double ContentAwareness
		{
			get { return _ContentAwareness; }
			set 
			{ 
				_ContentAwareness = value;
				OnPropertyChanged("ContentAwareness");
			}
		}
		/// <summary>
		/// Use ChunkedEncodeModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ChunkedEncodeMode
		{
			get { return _ChunkedEncodeMode; }
			set 
			{ 
				_ChunkedEncodeMode = value;
				OnPropertyChanged("ChunkedEncodeMode");
			}
		}
		/// <summary>
		/// Use ClipOffsetAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ClipOffset
		{
			get { return _ClipOffset; }
			set 
			{ 
				_ClipOffset = value;
				OnPropertyChanged("ClipOffset");
			}
		}
		/// <summary>
		/// Use ClipDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
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

		public FlavorParams(JToken node) : base(node)
		{
			if(node["videoCodec"] != null)
			{
				this._VideoCodec = (VideoCodec)StringEnum.Parse(typeof(VideoCodec), node["videoCodec"].Value<string>());
			}
			if(node["videoBitrate"] != null)
			{
				this._VideoBitrate = ParseInt(node["videoBitrate"].Value<string>());
			}
			if(node["audioCodec"] != null)
			{
				this._AudioCodec = (AudioCodec)StringEnum.Parse(typeof(AudioCodec), node["audioCodec"].Value<string>());
			}
			if(node["audioBitrate"] != null)
			{
				this._AudioBitrate = ParseInt(node["audioBitrate"].Value<string>());
			}
			if(node["audioChannels"] != null)
			{
				this._AudioChannels = ParseInt(node["audioChannels"].Value<string>());
			}
			if(node["audioSampleRate"] != null)
			{
				this._AudioSampleRate = ParseInt(node["audioSampleRate"].Value<string>());
			}
			if(node["width"] != null)
			{
				this._Width = ParseInt(node["width"].Value<string>());
			}
			if(node["height"] != null)
			{
				this._Height = ParseInt(node["height"].Value<string>());
			}
			if(node["frameRate"] != null)
			{
				this._FrameRate = ParseDouble(node["frameRate"].Value<string>());
			}
			if(node["gopSize"] != null)
			{
				this._GopSize = ParseInt(node["gopSize"].Value<string>());
			}
			if(node["conversionEngines"] != null)
			{
				this._ConversionEngines = node["conversionEngines"].Value<string>();
			}
			if(node["conversionEnginesExtraParams"] != null)
			{
				this._ConversionEnginesExtraParams = node["conversionEnginesExtraParams"].Value<string>();
			}
			if(node["twoPass"] != null)
			{
				this._TwoPass = ParseBool(node["twoPass"].Value<string>());
			}
			if(node["deinterlice"] != null)
			{
				this._Deinterlice = ParseInt(node["deinterlice"].Value<string>());
			}
			if(node["rotate"] != null)
			{
				this._Rotate = ParseInt(node["rotate"].Value<string>());
			}
			if(node["operators"] != null)
			{
				this._Operators = node["operators"].Value<string>();
			}
			if(node["engineVersion"] != null)
			{
				this._EngineVersion = ParseInt(node["engineVersion"].Value<string>());
			}
			if(node["format"] != null)
			{
				this._Format = (ContainerFormat)StringEnum.Parse(typeof(ContainerFormat), node["format"].Value<string>());
			}
			if(node["aspectRatioProcessingMode"] != null)
			{
				this._AspectRatioProcessingMode = ParseInt(node["aspectRatioProcessingMode"].Value<string>());
			}
			if(node["forceFrameToMultiplication16"] != null)
			{
				this._ForceFrameToMultiplication16 = ParseInt(node["forceFrameToMultiplication16"].Value<string>());
			}
			if(node["isGopInSec"] != null)
			{
				this._IsGopInSec = ParseInt(node["isGopInSec"].Value<string>());
			}
			if(node["isAvoidVideoShrinkFramesizeToSource"] != null)
			{
				this._IsAvoidVideoShrinkFramesizeToSource = ParseInt(node["isAvoidVideoShrinkFramesizeToSource"].Value<string>());
			}
			if(node["isAvoidVideoShrinkBitrateToSource"] != null)
			{
				this._IsAvoidVideoShrinkBitrateToSource = ParseInt(node["isAvoidVideoShrinkBitrateToSource"].Value<string>());
			}
			if(node["isVideoFrameRateForLowBrAppleHls"] != null)
			{
				this._IsVideoFrameRateForLowBrAppleHls = ParseInt(node["isVideoFrameRateForLowBrAppleHls"].Value<string>());
			}
			if(node["multiStream"] != null)
			{
				this._MultiStream = node["multiStream"].Value<string>();
			}
			if(node["anamorphicPixels"] != null)
			{
				this._AnamorphicPixels = ParseDouble(node["anamorphicPixels"].Value<string>());
			}
			if(node["isAvoidForcedKeyFrames"] != null)
			{
				this._IsAvoidForcedKeyFrames = ParseInt(node["isAvoidForcedKeyFrames"].Value<string>());
			}
			if(node["forcedKeyFramesMode"] != null)
			{
				this._ForcedKeyFramesMode = ParseInt(node["forcedKeyFramesMode"].Value<string>());
			}
			if(node["isCropIMX"] != null)
			{
				this._IsCropIMX = ParseInt(node["isCropIMX"].Value<string>());
			}
			if(node["optimizationPolicy"] != null)
			{
				this._OptimizationPolicy = ParseInt(node["optimizationPolicy"].Value<string>());
			}
			if(node["maxFrameRate"] != null)
			{
				this._MaxFrameRate = ParseInt(node["maxFrameRate"].Value<string>());
			}
			if(node["videoConstantBitrate"] != null)
			{
				this._VideoConstantBitrate = ParseInt(node["videoConstantBitrate"].Value<string>());
			}
			if(node["videoBitrateTolerance"] != null)
			{
				this._VideoBitrateTolerance = ParseInt(node["videoBitrateTolerance"].Value<string>());
			}
			if(node["watermarkData"] != null)
			{
				this._WatermarkData = node["watermarkData"].Value<string>();
			}
			if(node["subtitlesData"] != null)
			{
				this._SubtitlesData = node["subtitlesData"].Value<string>();
			}
			if(node["isEncrypted"] != null)
			{
				this._IsEncrypted = ParseInt(node["isEncrypted"].Value<string>());
			}
			if(node["contentAwareness"] != null)
			{
				this._ContentAwareness = ParseDouble(node["contentAwareness"].Value<string>());
			}
			if(node["chunkedEncodeMode"] != null)
			{
				this._ChunkedEncodeMode = ParseInt(node["chunkedEncodeMode"].Value<string>());
			}
			if(node["clipOffset"] != null)
			{
				this._ClipOffset = ParseInt(node["clipOffset"].Value<string>());
			}
			if(node["clipDuration"] != null)
			{
				this._ClipDuration = ParseInt(node["clipDuration"].Value<string>());
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
			kparams.AddIfNotNull("forcedKeyFramesMode", this._ForcedKeyFramesMode);
			kparams.AddIfNotNull("isCropIMX", this._IsCropIMX);
			kparams.AddIfNotNull("optimizationPolicy", this._OptimizationPolicy);
			kparams.AddIfNotNull("maxFrameRate", this._MaxFrameRate);
			kparams.AddIfNotNull("videoConstantBitrate", this._VideoConstantBitrate);
			kparams.AddIfNotNull("videoBitrateTolerance", this._VideoBitrateTolerance);
			kparams.AddIfNotNull("watermarkData", this._WatermarkData);
			kparams.AddIfNotNull("subtitlesData", this._SubtitlesData);
			kparams.AddIfNotNull("isEncrypted", this._IsEncrypted);
			kparams.AddIfNotNull("contentAwareness", this._ContentAwareness);
			kparams.AddIfNotNull("chunkedEncodeMode", this._ChunkedEncodeMode);
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
				case FORCED_KEY_FRAMES_MODE:
					return "ForcedKeyFramesMode";
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
				case CHUNKED_ENCODE_MODE:
					return "ChunkedEncodeMode";
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

