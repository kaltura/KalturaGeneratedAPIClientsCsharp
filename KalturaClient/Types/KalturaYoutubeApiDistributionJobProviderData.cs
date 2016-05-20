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
	public class KalturaYoutubeApiDistributionJobProviderData : KalturaConfigurableDistributionJobProviderData
	{
		#region Private Fields
		private string _VideoAssetFilePath = null;
		private string _ThumbAssetFilePath = null;
		private IList<KalturaYouTubeApiCaptionDistributionInfo> _CaptionsInfo;
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
		public IList<KalturaYouTubeApiCaptionDistributionInfo> CaptionsInfo
		{
			get { return _CaptionsInfo; }
			set 
			{ 
				_CaptionsInfo = value;
				OnPropertyChanged("CaptionsInfo");
			}
		}
		#endregion

		#region CTor
		public KalturaYoutubeApiDistributionJobProviderData()
		{
		}

		public KalturaYoutubeApiDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "videoAssetFilePath":
						this.VideoAssetFilePath = txt;
						continue;
					case "thumbAssetFilePath":
						this.ThumbAssetFilePath = txt;
						continue;
					case "captionsInfo":
						this.CaptionsInfo = new List<KalturaYouTubeApiCaptionDistributionInfo>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.CaptionsInfo.Add((KalturaYouTubeApiCaptionDistributionInfo)KalturaObjectFactory.Create(arrayNode, "KalturaYouTubeApiCaptionDistributionInfo"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaYoutubeApiDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePath", this.VideoAssetFilePath);
			kparams.AddIfNotNull("thumbAssetFilePath", this.ThumbAssetFilePath);
			kparams.AddIfNotNull("captionsInfo", this.CaptionsInfo);
			return kparams;
		}
		#endregion
	}
}

