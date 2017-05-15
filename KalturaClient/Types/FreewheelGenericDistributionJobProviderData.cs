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
	public class FreewheelGenericDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string VIDEO_ASSET_FILE_PATHS = "videoAssetFilePaths";
		public const string THUMB_ASSET_FILE_PATH = "thumbAssetFilePath";
		public const string CUE_POINTS = "cuePoints";
		#endregion

		#region Private Fields
		private IList<String> _VideoAssetFilePaths;
		private string _ThumbAssetFilePath = null;
		private IList<CuePoint> _CuePoints;
		#endregion

		#region Properties
		public IList<String> VideoAssetFilePaths
		{
			get { return _VideoAssetFilePaths; }
			set 
			{ 
				_VideoAssetFilePaths = value;
				OnPropertyChanged("VideoAssetFilePaths");
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
		#endregion

		#region CTor
		public FreewheelGenericDistributionJobProviderData()
		{
		}

		public FreewheelGenericDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "videoAssetFilePaths":
						this._VideoAssetFilePaths = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._VideoAssetFilePaths.Add(ObjectFactory.Create<String>(arrayNode));
						}
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
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaFreewheelGenericDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePaths", this._VideoAssetFilePaths);
			kparams.AddIfNotNull("thumbAssetFilePath", this._ThumbAssetFilePath);
			kparams.AddIfNotNull("cuePoints", this._CuePoints);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_ASSET_FILE_PATHS:
					return "VideoAssetFilePaths";
				case THUMB_ASSET_FILE_PATH:
					return "ThumbAssetFilePath";
				case CUE_POINTS:
					return "CuePoints";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

