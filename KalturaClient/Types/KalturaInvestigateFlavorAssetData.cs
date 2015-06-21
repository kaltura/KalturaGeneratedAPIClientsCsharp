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
	public class KalturaInvestigateFlavorAssetData : KalturaObjectBase
	{
		#region Private Fields
		private KalturaFlavorAsset _FlavorAsset;
		private KalturaFileSyncListResponse _FileSyncs;
		private KalturaMediaInfoListResponse _MediaInfos;
		private KalturaFlavorParams _FlavorParams;
		private KalturaFlavorParamsOutputListResponse _FlavorParamsOutputs;
		#endregion

		#region Properties
		public KalturaFlavorAsset FlavorAsset
		{
			get { return _FlavorAsset; }
			set 
			{ 
				_FlavorAsset = value;
				OnPropertyChanged("FlavorAsset");
			}
		}
		public KalturaFileSyncListResponse FileSyncs
		{
			get { return _FileSyncs; }
			set 
			{ 
				_FileSyncs = value;
				OnPropertyChanged("FileSyncs");
			}
		}
		public KalturaMediaInfoListResponse MediaInfos
		{
			get { return _MediaInfos; }
			set 
			{ 
				_MediaInfos = value;
				OnPropertyChanged("MediaInfos");
			}
		}
		public KalturaFlavorParams FlavorParams
		{
			get { return _FlavorParams; }
			set 
			{ 
				_FlavorParams = value;
				OnPropertyChanged("FlavorParams");
			}
		}
		public KalturaFlavorParamsOutputListResponse FlavorParamsOutputs
		{
			get { return _FlavorParamsOutputs; }
			set 
			{ 
				_FlavorParamsOutputs = value;
				OnPropertyChanged("FlavorParamsOutputs");
			}
		}
		#endregion

		#region CTor
		public KalturaInvestigateFlavorAssetData()
		{
		}

		public KalturaInvestigateFlavorAssetData(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAsset":
						this.FlavorAsset = (KalturaFlavorAsset)KalturaObjectFactory.Create(propertyNode, "KalturaFlavorAsset");
						continue;
					case "fileSyncs":
						this.FileSyncs = (KalturaFileSyncListResponse)KalturaObjectFactory.Create(propertyNode, "KalturaFileSyncListResponse");
						continue;
					case "mediaInfos":
						this.MediaInfos = (KalturaMediaInfoListResponse)KalturaObjectFactory.Create(propertyNode, "KalturaMediaInfoListResponse");
						continue;
					case "flavorParams":
						this.FlavorParams = (KalturaFlavorParams)KalturaObjectFactory.Create(propertyNode, "KalturaFlavorParams");
						continue;
					case "flavorParamsOutputs":
						this.FlavorParamsOutputs = (KalturaFlavorParamsOutputListResponse)KalturaObjectFactory.Create(propertyNode, "KalturaFlavorParamsOutputListResponse");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaInvestigateFlavorAssetData");
			if (this.FlavorAsset != null)
				kparams.Add("flavorAsset", this.FlavorAsset.ToParams());
			if (this.FileSyncs != null)
				kparams.Add("fileSyncs", this.FileSyncs.ToParams());
			if (this.MediaInfos != null)
				kparams.Add("mediaInfos", this.MediaInfos.ToParams());
			if (this.FlavorParams != null)
				kparams.Add("flavorParams", this.FlavorParams.ToParams());
			if (this.FlavorParamsOutputs != null)
				kparams.Add("flavorParamsOutputs", this.FlavorParamsOutputs.ToParams());
			return kparams;
		}
		#endregion
	}
}

