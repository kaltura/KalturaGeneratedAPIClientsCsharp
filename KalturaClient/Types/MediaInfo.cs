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
		private float _VideoFrameRate = Single.MinValue;
		private float _VideoDar = Single.MinValue;
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
		private float _MaxGOP = Single.MinValue;
		#endregion

		#region Properties
		public int Id
		{
			get { return _Id; }
		}
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public int FileSize
		{
			get { return _FileSize; }
			set 
			{ 
				_FileSize = value;
				OnPropertyChanged("FileSize");
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
		public string ContainerId
		{
			get { return _ContainerId; }
			set 
			{ 
				_ContainerId = value;
				OnPropertyChanged("ContainerId");
			}
		}
		public string ContainerProfile
		{
			get { return _ContainerProfile; }
			set 
			{ 
				_ContainerProfile = value;
				OnPropertyChanged("ContainerProfile");
			}
		}
		public int ContainerDuration
		{
			get { return _ContainerDuration; }
			set 
			{ 
				_ContainerDuration = value;
				OnPropertyChanged("ContainerDuration");
			}
		}
		public int ContainerBitRate
		{
			get { return _ContainerBitRate; }
			set 
			{ 
				_ContainerBitRate = value;
				OnPropertyChanged("ContainerBitRate");
			}
		}
		public string VideoFormat
		{
			get { return _VideoFormat; }
			set 
			{ 
				_VideoFormat = value;
				OnPropertyChanged("VideoFormat");
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
		public int VideoDuration
		{
			get { return _VideoDuration; }
			set 
			{ 
				_VideoDuration = value;
				OnPropertyChanged("VideoDuration");
			}
		}
		public int VideoBitRate
		{
			get { return _VideoBitRate; }
			set 
			{ 
				_VideoBitRate = value;
				OnPropertyChanged("VideoBitRate");
			}
		}
		public BitRateMode VideoBitRateMode
		{
			get { return _VideoBitRateMode; }
			set 
			{ 
				_VideoBitRateMode = value;
				OnPropertyChanged("VideoBitRateMode");
			}
		}
		public int VideoWidth
		{
			get { return _VideoWidth; }
			set 
			{ 
				_VideoWidth = value;
				OnPropertyChanged("VideoWidth");
			}
		}
		public int VideoHeight
		{
			get { return _VideoHeight; }
			set 
			{ 
				_VideoHeight = value;
				OnPropertyChanged("VideoHeight");
			}
		}
		public float VideoFrameRate
		{
			get { return _VideoFrameRate; }
			set 
			{ 
				_VideoFrameRate = value;
				OnPropertyChanged("VideoFrameRate");
			}
		}
		public float VideoDar
		{
			get { return _VideoDar; }
			set 
			{ 
				_VideoDar = value;
				OnPropertyChanged("VideoDar");
			}
		}
		public int VideoRotation
		{
			get { return _VideoRotation; }
			set 
			{ 
				_VideoRotation = value;
				OnPropertyChanged("VideoRotation");
			}
		}
		public string AudioFormat
		{
			get { return _AudioFormat; }
			set 
			{ 
				_AudioFormat = value;
				OnPropertyChanged("AudioFormat");
			}
		}
		public string AudioCodecId
		{
			get { return _AudioCodecId; }
			set 
			{ 
				_AudioCodecId = value;
				OnPropertyChanged("AudioCodecId");
			}
		}
		public int AudioDuration
		{
			get { return _AudioDuration; }
			set 
			{ 
				_AudioDuration = value;
				OnPropertyChanged("AudioDuration");
			}
		}
		public int AudioBitRate
		{
			get { return _AudioBitRate; }
			set 
			{ 
				_AudioBitRate = value;
				OnPropertyChanged("AudioBitRate");
			}
		}
		public BitRateMode AudioBitRateMode
		{
			get { return _AudioBitRateMode; }
			set 
			{ 
				_AudioBitRateMode = value;
				OnPropertyChanged("AudioBitRateMode");
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
		public int AudioSamplingRate
		{
			get { return _AudioSamplingRate; }
			set 
			{ 
				_AudioSamplingRate = value;
				OnPropertyChanged("AudioSamplingRate");
			}
		}
		public int AudioResolution
		{
			get { return _AudioResolution; }
			set 
			{ 
				_AudioResolution = value;
				OnPropertyChanged("AudioResolution");
			}
		}
		public string WritingLib
		{
			get { return _WritingLib; }
			set 
			{ 
				_WritingLib = value;
				OnPropertyChanged("WritingLib");
			}
		}
		public string RawData
		{
			get { return _RawData; }
			set 
			{ 
				_RawData = value;
				OnPropertyChanged("RawData");
			}
		}
		public string MultiStreamInfo
		{
			get { return _MultiStreamInfo; }
			set 
			{ 
				_MultiStreamInfo = value;
				OnPropertyChanged("MultiStreamInfo");
			}
		}
		public int ScanType
		{
			get { return _ScanType; }
			set 
			{ 
				_ScanType = value;
				OnPropertyChanged("ScanType");
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
		public int IsFastStart
		{
			get { return _IsFastStart; }
			set 
			{ 
				_IsFastStart = value;
				OnPropertyChanged("IsFastStart");
			}
		}
		public string ContentStreams
		{
			get { return _ContentStreams; }
			set 
			{ 
				_ContentStreams = value;
				OnPropertyChanged("ContentStreams");
			}
		}
		public int ComplexityValue
		{
			get { return _ComplexityValue; }
			set 
			{ 
				_ComplexityValue = value;
				OnPropertyChanged("ComplexityValue");
			}
		}
		public float MaxGOP
		{
			get { return _MaxGOP; }
			set 
			{ 
				_MaxGOP = value;
				OnPropertyChanged("MaxGOP");
			}
		}
		#endregion

		#region CTor
		public MediaInfo()
		{
		}

		public MediaInfo(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "id":
						this._Id = ParseInt(propertyNode.InnerText);
						continue;
					case "flavorAssetId":
						this._FlavorAssetId = propertyNode.InnerText;
						continue;
					case "fileSize":
						this._FileSize = ParseInt(propertyNode.InnerText);
						continue;
					case "containerFormat":
						this._ContainerFormat = propertyNode.InnerText;
						continue;
					case "containerId":
						this._ContainerId = propertyNode.InnerText;
						continue;
					case "containerProfile":
						this._ContainerProfile = propertyNode.InnerText;
						continue;
					case "containerDuration":
						this._ContainerDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "containerBitRate":
						this._ContainerBitRate = ParseInt(propertyNode.InnerText);
						continue;
					case "videoFormat":
						this._VideoFormat = propertyNode.InnerText;
						continue;
					case "videoCodecId":
						this._VideoCodecId = propertyNode.InnerText;
						continue;
					case "videoDuration":
						this._VideoDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "videoBitRate":
						this._VideoBitRate = ParseInt(propertyNode.InnerText);
						continue;
					case "videoBitRateMode":
						this._VideoBitRateMode = (BitRateMode)ParseEnum(typeof(BitRateMode), propertyNode.InnerText);
						continue;
					case "videoWidth":
						this._VideoWidth = ParseInt(propertyNode.InnerText);
						continue;
					case "videoHeight":
						this._VideoHeight = ParseInt(propertyNode.InnerText);
						continue;
					case "videoFrameRate":
						this._VideoFrameRate = ParseFloat(propertyNode.InnerText);
						continue;
					case "videoDar":
						this._VideoDar = ParseFloat(propertyNode.InnerText);
						continue;
					case "videoRotation":
						this._VideoRotation = ParseInt(propertyNode.InnerText);
						continue;
					case "audioFormat":
						this._AudioFormat = propertyNode.InnerText;
						continue;
					case "audioCodecId":
						this._AudioCodecId = propertyNode.InnerText;
						continue;
					case "audioDuration":
						this._AudioDuration = ParseInt(propertyNode.InnerText);
						continue;
					case "audioBitRate":
						this._AudioBitRate = ParseInt(propertyNode.InnerText);
						continue;
					case "audioBitRateMode":
						this._AudioBitRateMode = (BitRateMode)ParseEnum(typeof(BitRateMode), propertyNode.InnerText);
						continue;
					case "audioChannels":
						this._AudioChannels = ParseInt(propertyNode.InnerText);
						continue;
					case "audioSamplingRate":
						this._AudioSamplingRate = ParseInt(propertyNode.InnerText);
						continue;
					case "audioResolution":
						this._AudioResolution = ParseInt(propertyNode.InnerText);
						continue;
					case "writingLib":
						this._WritingLib = propertyNode.InnerText;
						continue;
					case "rawData":
						this._RawData = propertyNode.InnerText;
						continue;
					case "multiStreamInfo":
						this._MultiStreamInfo = propertyNode.InnerText;
						continue;
					case "scanType":
						this._ScanType = ParseInt(propertyNode.InnerText);
						continue;
					case "multiStream":
						this._MultiStream = propertyNode.InnerText;
						continue;
					case "isFastStart":
						this._IsFastStart = ParseInt(propertyNode.InnerText);
						continue;
					case "contentStreams":
						this._ContentStreams = propertyNode.InnerText;
						continue;
					case "complexityValue":
						this._ComplexityValue = ParseInt(propertyNode.InnerText);
						continue;
					case "maxGOP":
						this._MaxGOP = ParseFloat(propertyNode.InnerText);
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
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

