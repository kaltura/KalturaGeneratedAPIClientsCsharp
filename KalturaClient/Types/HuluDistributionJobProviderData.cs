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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class HuluDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string VIDEO_ASSET_FILE_PATH = "videoAssetFilePath";
		public const string THUMB_ASSET_FILE_PATH = "thumbAssetFilePath";
		public const string CUE_POINTS = "cuePoints";
		public const string FILE_BASE_NAME = "fileBaseName";
		public const string CAPTION_LOCAL_PATHS = "captionLocalPaths";
		#endregion

		#region Private Fields
		private string _VideoAssetFilePath = null;
		private string _ThumbAssetFilePath = null;
		private IList<CuePoint> _CuePoints;
		private string _FileBaseName = null;
		private IList<String> _CaptionLocalPaths;
		#endregion

		#region Properties
		public string VideoAssetFilePath
		{
			get { return _VideoAssetFilePath; }
			set 
			{ 
				_VideoAssetFilePath = value;
				OnPropertyChanged("VideoAssetFilePath");
			}
		}
		public string ThumbAssetFilePath
		{
			get { return _ThumbAssetFilePath; }
			set 
			{ 
				_ThumbAssetFilePath = value;
				OnPropertyChanged("ThumbAssetFilePath");
			}
		}
		public IList<CuePoint> CuePoints
		{
			get { return _CuePoints; }
			set 
			{ 
				_CuePoints = value;
				OnPropertyChanged("CuePoints");
			}
		}
		public string FileBaseName
		{
			get { return _FileBaseName; }
			set 
			{ 
				_FileBaseName = value;
				OnPropertyChanged("FileBaseName");
			}
		}
		public IList<String> CaptionLocalPaths
		{
			get { return _CaptionLocalPaths; }
			set 
			{ 
				_CaptionLocalPaths = value;
				OnPropertyChanged("CaptionLocalPaths");
			}
		}
		#endregion

		#region CTor
		public HuluDistributionJobProviderData()
		{
		}

		public HuluDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "videoAssetFilePath":
						this._VideoAssetFilePath = propertyNode.InnerText;
						continue;
					case "thumbAssetFilePath":
						this._ThumbAssetFilePath = propertyNode.InnerText;
						continue;
					case "cuePoints":
						this._CuePoints = new List<CuePoint>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CuePoints.Add(ObjectFactory.Create<CuePoint>(arrayNode));
						}
						continue;
					case "fileBaseName":
						this._FileBaseName = propertyNode.InnerText;
						continue;
					case "captionLocalPaths":
						this._CaptionLocalPaths = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CaptionLocalPaths.Add(ObjectFactory.Create<String>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaHuluDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePath", this._VideoAssetFilePath);
			kparams.AddIfNotNull("thumbAssetFilePath", this._ThumbAssetFilePath);
			kparams.AddIfNotNull("cuePoints", this._CuePoints);
			kparams.AddIfNotNull("fileBaseName", this._FileBaseName);
			kparams.AddIfNotNull("captionLocalPaths", this._CaptionLocalPaths);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_ASSET_FILE_PATH:
					return "VideoAssetFilePath";
				case THUMB_ASSET_FILE_PATH:
					return "ThumbAssetFilePath";
				case CUE_POINTS:
					return "CuePoints";
				case FILE_BASE_NAME:
					return "FileBaseName";
				case CAPTION_LOCAL_PATHS:
					return "CaptionLocalPaths";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

