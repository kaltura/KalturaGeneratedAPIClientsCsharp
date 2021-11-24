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
	public class MediaInfo : ObjectBase
	{
		#region Constants
		public const string ID = "id";
		public const string FLAVOR_ASSET_ID = "flavorAssetId";
		public const string FILE_SIZE = "fileSize";
		public const string CONTAINER_FORMAT = "containerFormat";
		public const string CONTAINER_ID = "containerId";
		public const string CONTAINER_PROFILE = "containerProfile";
		public const string CONTAINER_DURATION = "containerDuration";
		public const string CONTAINER_BIT_RATE = "containerBitRate";
		public const string VIDEO_FORMAT = "videoFormat";
		public const string VIDEO_CODEC_ID = "videoCodecId";
		public const string VIDEO_DURATION = "videoDuration";
		public const string VIDEO_BIT_RATE = "videoBitRate";
		public const string VIDEO_BIT_RATE_MODE = "videoBitRateMode";
		public const string VIDEO_WIDTH = "videoWidth";
		public const string VIDEO_HEIGHT = "videoHeight";
		public const string VIDEO_FRAME_RATE = "videoFrameRate";
		public const string VIDEO_DAR = "videoDar";
		public const string VIDEO_ROTATION = "videoRotation";
		public const string AUDIO_FORMAT = "audioFormat";
		public const string AUDIO_CODEC_ID = "audioCodecId";
		public const string AUDIO_DURATION = "audioDuration";
		public const string AUDIO_BIT_RATE = "audioBitRate";
		public const string AUDIO_BIT_RATE_MODE = "audioBitRateMode";
		public const string AUDIO_CHANNELS = "audioChannels";
		public const string AUDIO_SAMPLING_RATE = "audioSamplingRate";
		public const string AUDIO_RESOLUTION = "audioResolution";
		public const string WRITING_LIB = "writingLib";
		public const string RAW_DATA = "rawData";
		public const string MULTI_STREAM_INFO = "multiStreamInfo";
		public const string SCAN_TYPE = "scanType";
		public const string MULTI_STREAM = "multiStream";
		public const string IS_FAST_START = "isFastStart";
		public const string CONTENT_STREAMS = "contentStreams";
		public const string COMPLEXITY_VALUE = "complexityValue";
		public const string MAX_GOP = "maxGOP";
		public const string MATRIX_COEFFICIENTS = "matrixCoefficients";
		public const string COLOR_TRANSFER = "colorTransfer";
		public const string COLOR_PRIMARIES = "colorPrimaries";
		public const string PIXEL_FORMAT = "pixelFormat";
		public const string COLOR_SPACE = "colorSpace";
		public const string CHROMA_SUBSAMPLING = "chromaSubsampling";
		public const string BITS_DEPTH = "bitsDepth";
		#endregion

		#region Private Fields
		private int _Id = Int32.MinValue;
		private string _FlavorAssetId = null;
		private int _FileSize = Int32.MinValue;
		private string _ContainerFormat = null;
		private string _ContainerId = null;
		private string _ContainerProfile = null;
		private int _ContainerDuration = Int32.MinValue;
		private int _ContainerBitRate = Int32.MinValue;
		private string _VideoFormat = null;
		private string _VideoCodecId = null;
		private int _VideoDuration = Int32.MinValue;
		private int _VideoBitRate = Int32.MinValue;
		private BitRateMode _VideoBitRateMode = (BitRateMode)Int32.MinValue;
		private int _VideoWidth = Int32.MinValue;
		private int _VideoHeight = Int32.MinValue;
		private double _VideoFrameRate = Double.MinValue;
		private double _VideoDar = Double.MinValue;
		private int _VideoRotation = Int32.MinValue;
		private string _AudioFormat = null;
		private string _AudioCodecId = null;
		private int _AudioDuration = Int32.MinValue;
		private int _AudioBitRate = Int32.MinValue;
		private BitRateMode _AudioBitRateMode = (BitRateMode)Int32.MinValue;
		private int _AudioChannels = Int32.MinValue;
		private int _AudioSamplingRate = Int32.MinValue;
		private int _AudioResolution = Int32.MinValue;
		private string _WritingLib = null;
		private string _RawData = null;
		private string _MultiStreamInfo = null;
		private int _ScanType = Int32.MinValue;
		private string _MultiStream = null;
		private int _IsFastStart = Int32.MinValue;
		private string _ContentStreams = null;
		private int _ComplexityValue = Int32.MinValue;
		private double _MaxGOP = Double.MinValue;
		private string _MatrixCoefficients = null;
		private string _ColorTransfer = null;
		private string _ColorPrimaries = null;
		private string _PixelFormat = null;
		private string _ColorSpace = null;
		private string _ChromaSubsampling = null;
		private int _BitsDepth = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use IdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int Id
		{
			get { return _Id; }
			private set 
			{ 
				_Id = value;
				OnPropertyChanged("Id");
			}
		}
		/// <summary>
		/// Use FlavorAssetIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		/// <summary>
		/// Use FileSizeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
			}
		}
		/// <summary>
		/// Use ContainerFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContainerFormat
		{
			get { return _ContainerFormat; }
			set 
			{ 
				_ContainerFormat = value;
				OnPropertyChanged("ContainerFormat");
			}
		}
		/// <summary>
		/// Use ContainerIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContainerId
		{
			get { return _ContainerId; }
			set 
			{ 
				_ContainerId = value;
				OnPropertyChanged("ContainerId");
			}
		}
		/// <summary>
		/// Use ContainerProfileAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContainerProfile
		{
			get { return _ContainerProfile; }
			set 
			{ 
				_ContainerProfile = value;
				OnPropertyChanged("ContainerProfile");
			}
		}
		/// <summary>
		/// Use ContainerDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ContainerDuration
		{
			get { return _ContainerDuration; }
			set 
			{ 
				_ContainerDuration = value;
				OnPropertyChanged("ContainerDuration");
			}
		}
		/// <summary>
		/// Use ContainerBitRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ContainerBitRate
		{
			get { return _ContainerBitRate; }
			set 
			{ 
				_ContainerBitRate = value;
				OnPropertyChanged("ContainerBitRate");
			}
		}
		/// <summary>
		/// Use VideoFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VideoFormat
		{
			get { return _VideoFormat; }
			set 
			{ 
				_VideoFormat = value;
				OnPropertyChanged("VideoFormat");
			}
		}
		/// <summary>
		/// Use VideoCodecIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string VideoCodecId
		{
			get { return _VideoCodecId; }
			set 
			{ 
				_VideoCodecId = value;
				OnPropertyChanged("VideoCodecId");
			}
		}
		/// <summary>
		/// Use VideoDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoDuration
		{
			get { return _VideoDuration; }
			set 
			{ 
				_VideoDuration = value;
				OnPropertyChanged("VideoDuration");
			}
		}
		/// <summary>
		/// Use VideoBitRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoBitRate
		{
			get { return _VideoBitRate; }
			set 
			{ 
				_VideoBitRate = value;
				OnPropertyChanged("VideoBitRate");
			}
		}
		/// <summary>
		/// Use VideoBitRateModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BitRateMode VideoBitRateMode
		{
			get { return _VideoBitRateMode; }
			set 
			{ 
				_VideoBitRateMode = value;
				OnPropertyChanged("VideoBitRateMode");
			}
		}
		/// <summary>
		/// Use VideoWidthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoWidth
		{
			get { return _VideoWidth; }
			set 
			{ 
				_VideoWidth = value;
				OnPropertyChanged("VideoWidth");
			}
		}
		/// <summary>
		/// Use VideoHeightAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoHeight
		{
			get { return _VideoHeight; }
			set 
			{ 
				_VideoHeight = value;
				OnPropertyChanged("VideoHeight");
			}
		}
		/// <summary>
		/// Use VideoFrameRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double VideoFrameRate
		{
			get { return _VideoFrameRate; }
			set 
			{ 
				_VideoFrameRate = value;
				OnPropertyChanged("VideoFrameRate");
			}
		}
		/// <summary>
		/// Use VideoDarAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double VideoDar
		{
			get { return _VideoDar; }
			set 
			{ 
				_VideoDar = value;
				OnPropertyChanged("VideoDar");
			}
		}
		/// <summary>
		/// Use VideoRotationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int VideoRotation
		{
			get { return _VideoRotation; }
			set 
			{ 
				_VideoRotation = value;
				OnPropertyChanged("VideoRotation");
			}
		}
		/// <summary>
		/// Use AudioFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AudioFormat
		{
			get { return _AudioFormat; }
			set 
			{ 
				_AudioFormat = value;
				OnPropertyChanged("AudioFormat");
			}
		}
		/// <summary>
		/// Use AudioCodecIdAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string AudioCodecId
		{
			get { return _AudioCodecId; }
			set 
			{ 
				_AudioCodecId = value;
				OnPropertyChanged("AudioCodecId");
			}
		}
		/// <summary>
		/// Use AudioDurationAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioDuration
		{
			get { return _AudioDuration; }
			set 
			{ 
				_AudioDuration = value;
				OnPropertyChanged("AudioDuration");
			}
		}
		/// <summary>
		/// Use AudioBitRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioBitRate
		{
			get { return _AudioBitRate; }
			set 
			{ 
				_AudioBitRate = value;
				OnPropertyChanged("AudioBitRate");
			}
		}
		/// <summary>
		/// Use AudioBitRateModeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public BitRateMode AudioBitRateMode
		{
			get { return _AudioBitRateMode; }
			set 
			{ 
				_AudioBitRateMode = value;
				OnPropertyChanged("AudioBitRateMode");
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
		/// Use AudioSamplingRateAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioSamplingRate
		{
			get { return _AudioSamplingRate; }
			set 
			{ 
				_AudioSamplingRate = value;
				OnPropertyChanged("AudioSamplingRate");
			}
		}
		/// <summary>
		/// Use AudioResolutionAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int AudioResolution
		{
			get { return _AudioResolution; }
			set 
			{ 
				_AudioResolution = value;
				OnPropertyChanged("AudioResolution");
			}
		}
		/// <summary>
		/// Use WritingLibAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string WritingLib
		{
			get { return _WritingLib; }
			set 
			{ 
				_WritingLib = value;
				OnPropertyChanged("WritingLib");
			}
		}
		/// <summary>
		/// Use RawDataAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string RawData
		{
			get { return _RawData; }
			set 
			{ 
				_RawData = value;
				OnPropertyChanged("RawData");
			}
		}
		/// <summary>
		/// Use MultiStreamInfoAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MultiStreamInfo
		{
			get { return _MultiStreamInfo; }
			set 
			{ 
				_MultiStreamInfo = value;
				OnPropertyChanged("MultiStreamInfo");
			}
		}
		/// <summary>
		/// Use ScanTypeAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ScanType
		{
			get { return _ScanType; }
			set 
			{ 
				_ScanType = value;
				OnPropertyChanged("ScanType");
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
		/// Use IsFastStartAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int IsFastStart
		{
			get { return _IsFastStart; }
			set 
			{ 
				_IsFastStart = value;
				OnPropertyChanged("IsFastStart");
			}
		}
		/// <summary>
		/// Use ContentStreamsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ContentStreams
		{
			get { return _ContentStreams; }
			set 
			{ 
				_ContentStreams = value;
				OnPropertyChanged("ContentStreams");
			}
		}
		/// <summary>
		/// Use ComplexityValueAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int ComplexityValue
		{
			get { return _ComplexityValue; }
			set 
			{ 
				_ComplexityValue = value;
				OnPropertyChanged("ComplexityValue");
			}
		}
		/// <summary>
		/// Use MaxGOPAsDouble property instead
		/// </summary>
		[JsonProperty]
		public double MaxGOP
		{
			get { return _MaxGOP; }
			set 
			{ 
				_MaxGOP = value;
				OnPropertyChanged("MaxGOP");
			}
		}
		/// <summary>
		/// Use MatrixCoefficientsAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string MatrixCoefficients
		{
			get { return _MatrixCoefficients; }
			set 
			{ 
				_MatrixCoefficients = value;
				OnPropertyChanged("MatrixCoefficients");
			}
		}
		/// <summary>
		/// Use ColorTransferAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ColorTransfer
		{
			get { return _ColorTransfer; }
			set 
			{ 
				_ColorTransfer = value;
				OnPropertyChanged("ColorTransfer");
			}
		}
		/// <summary>
		/// Use ColorPrimariesAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ColorPrimaries
		{
			get { return _ColorPrimaries; }
			set 
			{ 
				_ColorPrimaries = value;
				OnPropertyChanged("ColorPrimaries");
			}
		}
		/// <summary>
		/// Use PixelFormatAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string PixelFormat
		{
			get { return _PixelFormat; }
			set 
			{ 
				_PixelFormat = value;
				OnPropertyChanged("PixelFormat");
			}
		}
		/// <summary>
		/// Use ColorSpaceAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ColorSpace
		{
			get { return _ColorSpace; }
			set 
			{ 
				_ColorSpace = value;
				OnPropertyChanged("ColorSpace");
			}
		}
		/// <summary>
		/// Use ChromaSubsamplingAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string ChromaSubsampling
		{
			get { return _ChromaSubsampling; }
			set 
			{ 
				_ChromaSubsampling = value;
				OnPropertyChanged("ChromaSubsampling");
			}
		}
		/// <summary>
		/// Use BitsDepthAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int BitsDepth
		{
			get { return _BitsDepth; }
			set 
			{ 
				_BitsDepth = value;
				OnPropertyChanged("BitsDepth");
			}
		}
		#endregion

		#region CTor
		public MediaInfo()
		{
		}

		public MediaInfo(JToken node) : base(node)
		{
			if(node["id"] != null)
			{
				this._Id = ParseInt(node["id"].Value<string>());
			}
			if(node["flavorAssetId"] != null)
			{
				this._FlavorAssetId = node["flavorAssetId"].Value<string>();
			}
			if(node["fileSize"] != null)
			{
				this._FileSize = ParseInt(node["fileSize"].Value<string>());
			}
			if(node["containerFormat"] != null)
			{
				this._ContainerFormat = node["containerFormat"].Value<string>();
			}
			if(node["containerId"] != null)
			{
				this._ContainerId = node["containerId"].Value<string>();
			}
			if(node["containerProfile"] != null)
			{
				this._ContainerProfile = node["containerProfile"].Value<string>();
			}
			if(node["containerDuration"] != null)
			{
				this._ContainerDuration = ParseInt(node["containerDuration"].Value<string>());
			}
			if(node["containerBitRate"] != null)
			{
				this._ContainerBitRate = ParseInt(node["containerBitRate"].Value<string>());
			}
			if(node["videoFormat"] != null)
			{
				this._VideoFormat = node["videoFormat"].Value<string>();
			}
			if(node["videoCodecId"] != null)
			{
				this._VideoCodecId = node["videoCodecId"].Value<string>();
			}
			if(node["videoDuration"] != null)
			{
				this._VideoDuration = ParseInt(node["videoDuration"].Value<string>());
			}
			if(node["videoBitRate"] != null)
			{
				this._VideoBitRate = ParseInt(node["videoBitRate"].Value<string>());
			}
			if(node["videoBitRateMode"] != null)
			{
				this._VideoBitRateMode = (BitRateMode)ParseEnum(typeof(BitRateMode), node["videoBitRateMode"].Value<string>());
			}
			if(node["videoWidth"] != null)
			{
				this._VideoWidth = ParseInt(node["videoWidth"].Value<string>());
			}
			if(node["videoHeight"] != null)
			{
				this._VideoHeight = ParseInt(node["videoHeight"].Value<string>());
			}
			if(node["videoFrameRate"] != null)
			{
				this._VideoFrameRate = ParseDouble(node["videoFrameRate"].Value<string>());
			}
			if(node["videoDar"] != null)
			{
				this._VideoDar = ParseDouble(node["videoDar"].Value<string>());
			}
			if(node["videoRotation"] != null)
			{
				this._VideoRotation = ParseInt(node["videoRotation"].Value<string>());
			}
			if(node["audioFormat"] != null)
			{
				this._AudioFormat = node["audioFormat"].Value<string>();
			}
			if(node["audioCodecId"] != null)
			{
				this._AudioCodecId = node["audioCodecId"].Value<string>();
			}
			if(node["audioDuration"] != null)
			{
				this._AudioDuration = ParseInt(node["audioDuration"].Value<string>());
			}
			if(node["audioBitRate"] != null)
			{
				this._AudioBitRate = ParseInt(node["audioBitRate"].Value<string>());
			}
			if(node["audioBitRateMode"] != null)
			{
				this._AudioBitRateMode = (BitRateMode)ParseEnum(typeof(BitRateMode), node["audioBitRateMode"].Value<string>());
			}
			if(node["audioChannels"] != null)
			{
				this._AudioChannels = ParseInt(node["audioChannels"].Value<string>());
			}
			if(node["audioSamplingRate"] != null)
			{
				this._AudioSamplingRate = ParseInt(node["audioSamplingRate"].Value<string>());
			}
			if(node["audioResolution"] != null)
			{
				this._AudioResolution = ParseInt(node["audioResolution"].Value<string>());
			}
			if(node["writingLib"] != null)
			{
				this._WritingLib = node["writingLib"].Value<string>();
			}
			if(node["rawData"] != null)
			{
				this._RawData = node["rawData"].Value<string>();
			}
			if(node["multiStreamInfo"] != null)
			{
				this._MultiStreamInfo = node["multiStreamInfo"].Value<string>();
			}
			if(node["scanType"] != null)
			{
				this._ScanType = ParseInt(node["scanType"].Value<string>());
			}
			if(node["multiStream"] != null)
			{
				this._MultiStream = node["multiStream"].Value<string>();
			}
			if(node["isFastStart"] != null)
			{
				this._IsFastStart = ParseInt(node["isFastStart"].Value<string>());
			}
			if(node["contentStreams"] != null)
			{
				this._ContentStreams = node["contentStreams"].Value<string>();
			}
			if(node["complexityValue"] != null)
			{
				this._ComplexityValue = ParseInt(node["complexityValue"].Value<string>());
			}
			if(node["maxGOP"] != null)
			{
				this._MaxGOP = ParseDouble(node["maxGOP"].Value<string>());
			}
			if(node["matrixCoefficients"] != null)
			{
				this._MatrixCoefficients = node["matrixCoefficients"].Value<string>();
			}
			if(node["colorTransfer"] != null)
			{
				this._ColorTransfer = node["colorTransfer"].Value<string>();
			}
			if(node["colorPrimaries"] != null)
			{
				this._ColorPrimaries = node["colorPrimaries"].Value<string>();
			}
			if(node["pixelFormat"] != null)
			{
				this._PixelFormat = node["pixelFormat"].Value<string>();
			}
			if(node["colorSpace"] != null)
			{
				this._ColorSpace = node["colorSpace"].Value<string>();
			}
			if(node["chromaSubsampling"] != null)
			{
				this._ChromaSubsampling = node["chromaSubsampling"].Value<string>();
			}
			if(node["bitsDepth"] != null)
			{
				this._BitsDepth = ParseInt(node["bitsDepth"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMediaInfo");
			kparams.AddIfNotNull("id", this._Id);
			kparams.AddIfNotNull("flavorAssetId", this._FlavorAssetId);
			kparams.AddIfNotNull("fileSize", this._FileSize);
			kparams.AddIfNotNull("containerFormat", this._ContainerFormat);
			kparams.AddIfNotNull("containerId", this._ContainerId);
			kparams.AddIfNotNull("containerProfile", this._ContainerProfile);
			kparams.AddIfNotNull("containerDuration", this._ContainerDuration);
			kparams.AddIfNotNull("containerBitRate", this._ContainerBitRate);
			kparams.AddIfNotNull("videoFormat", this._VideoFormat);
			kparams.AddIfNotNull("videoCodecId", this._VideoCodecId);
			kparams.AddIfNotNull("videoDuration", this._VideoDuration);
			kparams.AddIfNotNull("videoBitRate", this._VideoBitRate);
			kparams.AddIfNotNull("videoBitRateMode", this._VideoBitRateMode);
			kparams.AddIfNotNull("videoWidth", this._VideoWidth);
			kparams.AddIfNotNull("videoHeight", this._VideoHeight);
			kparams.AddIfNotNull("videoFrameRate", this._VideoFrameRate);
			kparams.AddIfNotNull("videoDar", this._VideoDar);
			kparams.AddIfNotNull("videoRotation", this._VideoRotation);
			kparams.AddIfNotNull("audioFormat", this._AudioFormat);
			kparams.AddIfNotNull("audioCodecId", this._AudioCodecId);
			kparams.AddIfNotNull("audioDuration", this._AudioDuration);
			kparams.AddIfNotNull("audioBitRate", this._AudioBitRate);
			kparams.AddIfNotNull("audioBitRateMode", this._AudioBitRateMode);
			kparams.AddIfNotNull("audioChannels", this._AudioChannels);
			kparams.AddIfNotNull("audioSamplingRate", this._AudioSamplingRate);
			kparams.AddIfNotNull("audioResolution", this._AudioResolution);
			kparams.AddIfNotNull("writingLib", this._WritingLib);
			kparams.AddIfNotNull("rawData", this._RawData);
			kparams.AddIfNotNull("multiStreamInfo", this._MultiStreamInfo);
			kparams.AddIfNotNull("scanType", this._ScanType);
			kparams.AddIfNotNull("multiStream", this._MultiStream);
			kparams.AddIfNotNull("isFastStart", this._IsFastStart);
			kparams.AddIfNotNull("contentStreams", this._ContentStreams);
			kparams.AddIfNotNull("complexityValue", this._ComplexityValue);
			kparams.AddIfNotNull("maxGOP", this._MaxGOP);
			kparams.AddIfNotNull("matrixCoefficients", this._MatrixCoefficients);
			kparams.AddIfNotNull("colorTransfer", this._ColorTransfer);
			kparams.AddIfNotNull("colorPrimaries", this._ColorPrimaries);
			kparams.AddIfNotNull("pixelFormat", this._PixelFormat);
			kparams.AddIfNotNull("colorSpace", this._ColorSpace);
			kparams.AddIfNotNull("chromaSubsampling", this._ChromaSubsampling);
			kparams.AddIfNotNull("bitsDepth", this._BitsDepth);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ID:
					return "Id";
				case FLAVOR_ASSET_ID:
					return "FlavorAssetId";
				case FILE_SIZE:
					return "FileSize";
				case CONTAINER_FORMAT:
					return "ContainerFormat";
				case CONTAINER_ID:
					return "ContainerId";
				case CONTAINER_PROFILE:
					return "ContainerProfile";
				case CONTAINER_DURATION:
					return "ContainerDuration";
				case CONTAINER_BIT_RATE:
					return "ContainerBitRate";
				case VIDEO_FORMAT:
					return "VideoFormat";
				case VIDEO_CODEC_ID:
					return "VideoCodecId";
				case VIDEO_DURATION:
					return "VideoDuration";
				case VIDEO_BIT_RATE:
					return "VideoBitRate";
				case VIDEO_BIT_RATE_MODE:
					return "VideoBitRateMode";
				case VIDEO_WIDTH:
					return "VideoWidth";
				case VIDEO_HEIGHT:
					return "VideoHeight";
				case VIDEO_FRAME_RATE:
					return "VideoFrameRate";
				case VIDEO_DAR:
					return "VideoDar";
				case VIDEO_ROTATION:
					return "VideoRotation";
				case AUDIO_FORMAT:
					return "AudioFormat";
				case AUDIO_CODEC_ID:
					return "AudioCodecId";
				case AUDIO_DURATION:
					return "AudioDuration";
				case AUDIO_BIT_RATE:
					return "AudioBitRate";
				case AUDIO_BIT_RATE_MODE:
					return "AudioBitRateMode";
				case AUDIO_CHANNELS:
					return "AudioChannels";
				case AUDIO_SAMPLING_RATE:
					return "AudioSamplingRate";
				case AUDIO_RESOLUTION:
					return "AudioResolution";
				case WRITING_LIB:
					return "WritingLib";
				case RAW_DATA:
					return "RawData";
				case MULTI_STREAM_INFO:
					return "MultiStreamInfo";
				case SCAN_TYPE:
					return "ScanType";
				case MULTI_STREAM:
					return "MultiStream";
				case IS_FAST_START:
					return "IsFastStart";
				case CONTENT_STREAMS:
					return "ContentStreams";
				case COMPLEXITY_VALUE:
					return "ComplexityValue";
				case MAX_GOP:
					return "MaxGOP";
				case MATRIX_COEFFICIENTS:
					return "MatrixCoefficients";
				case COLOR_TRANSFER:
					return "ColorTransfer";
				case COLOR_PRIMARIES:
					return "ColorPrimaries";
				case PIXEL_FORMAT:
					return "PixelFormat";
				case COLOR_SPACE:
					return "ColorSpace";
				case CHROMA_SUBSAMPLING:
					return "ChromaSubsampling";
				case BITS_DEPTH:
					return "BitsDepth";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

