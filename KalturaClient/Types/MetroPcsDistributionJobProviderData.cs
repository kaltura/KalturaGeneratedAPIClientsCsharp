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
// Copyright (C) 2006-2018  Kaltura Inc.
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
	public class MetroPcsDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string ASSET_LOCAL_PATHS = "assetLocalPaths";
		public const string THUMB_URLS = "thumbUrls";
		#endregion

		#region Private Fields
		private string _AssetLocalPaths = null;
		private string _ThumbUrls = null;
		#endregion

		#region Properties
		public string AssetLocalPaths
		{
			get { return _AssetLocalPaths; }
			set 
			{ 
				_AssetLocalPaths = value;
				OnPropertyChanged("AssetLocalPaths");
			}
		}
		public string ThumbUrls
		{
			get { return _ThumbUrls; }
			set 
			{ 
				_ThumbUrls = value;
				OnPropertyChanged("ThumbUrls");
			}
		}
		#endregion

		#region CTor
		public MetroPcsDistributionJobProviderData()
		{
		}

		public MetroPcsDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "assetLocalPaths":
						this._AssetLocalPaths = propertyNode.InnerText;
						continue;
					case "thumbUrls":
						this._ThumbUrls = propertyNode.InnerText;
						continue;
				}
			}
		}

		public MetroPcsDistributionJobProviderData(IDictionary<string,object> data) : base(data)
		{
			    this._AssetLocalPaths = data.TryGetValueSafe<string>("assetLocalPaths");
			    this._ThumbUrls = data.TryGetValueSafe<string>("thumbUrls");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMetroPcsDistributionJobProviderData");
			kparams.AddIfNotNull("assetLocalPaths", this._AssetLocalPaths);
			kparams.AddIfNotNull("thumbUrls", this._ThumbUrls);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ASSET_LOCAL_PATHS:
					return "AssetLocalPaths";
				case THUMB_URLS:
					return "ThumbUrls";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

