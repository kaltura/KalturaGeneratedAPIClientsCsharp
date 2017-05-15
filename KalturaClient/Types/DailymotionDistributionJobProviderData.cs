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
	public class DailymotionDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string VIDEO_ASSET_FILE_PATH = "videoAssetFilePath";
		public const string ACCESS_CONTROL_GEO_BLOCKING_OPERATION = "accessControlGeoBlockingOperation";
		public const string ACCESS_CONTROL_GEO_BLOCKING_COUNTRY_LIST = "accessControlGeoBlockingCountryList";
		public const string CAPTIONS_INFO = "captionsInfo";
		#endregion

		#region Private Fields
		private string _VideoAssetFilePath = null;
		private string _AccessControlGeoBlockingOperation = null;
		private string _AccessControlGeoBlockingCountryList = null;
		private IList<DailymotionDistributionCaptionInfo> _CaptionsInfo;
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
		public string AccessControlGeoBlockingOperation
		{
			get { return _AccessControlGeoBlockingOperation; }
			set 
			{ 
				_AccessControlGeoBlockingOperation = value;
				OnPropertyChanged("AccessControlGeoBlockingOperation");
			}
		}
		public string AccessControlGeoBlockingCountryList
		{
			get { return _AccessControlGeoBlockingCountryList; }
			set 
			{ 
				_AccessControlGeoBlockingCountryList = value;
				OnPropertyChanged("AccessControlGeoBlockingCountryList");
			}
		}
		public IList<DailymotionDistributionCaptionInfo> CaptionsInfo
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
		public DailymotionDistributionJobProviderData()
		{
		}

		public DailymotionDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "videoAssetFilePath":
						this._VideoAssetFilePath = propertyNode.InnerText;
						continue;
					case "accessControlGeoBlockingOperation":
						this._AccessControlGeoBlockingOperation = propertyNode.InnerText;
						continue;
					case "accessControlGeoBlockingCountryList":
						this._AccessControlGeoBlockingCountryList = propertyNode.InnerText;
						continue;
					case "captionsInfo":
						this._CaptionsInfo = new List<DailymotionDistributionCaptionInfo>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CaptionsInfo.Add(ObjectFactory.Create<DailymotionDistributionCaptionInfo>(arrayNode));
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
				kparams.AddReplace("objectType", "KalturaDailymotionDistributionJobProviderData");
			kparams.AddIfNotNull("videoAssetFilePath", this._VideoAssetFilePath);
			kparams.AddIfNotNull("accessControlGeoBlockingOperation", this._AccessControlGeoBlockingOperation);
			kparams.AddIfNotNull("accessControlGeoBlockingCountryList", this._AccessControlGeoBlockingCountryList);
			kparams.AddIfNotNull("captionsInfo", this._CaptionsInfo);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VIDEO_ASSET_FILE_PATH:
					return "VideoAssetFilePath";
				case ACCESS_CONTROL_GEO_BLOCKING_OPERATION:
					return "AccessControlGeoBlockingOperation";
				case ACCESS_CONTROL_GEO_BLOCKING_COUNTRY_LIST:
					return "AccessControlGeoBlockingCountryList";
				case CAPTIONS_INFO:
					return "CaptionsInfo";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

