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
	public class KalturaInvestigateThumbAssetData : KalturaObjectBase
	{
		#region Private Fields
		private KalturaThumbAsset _ThumbAsset;
		private KalturaFileSyncListResponse _FileSyncs;
		private KalturaThumbParams _ThumbParams;
		private KalturaThumbParamsOutputListResponse _ThumbParamsOutputs;
		#endregion

		#region Properties
		public KalturaThumbAsset ThumbAsset
		{
			get { return _ThumbAsset; }
			set 
			{ 
				_ThumbAsset = value;
				OnPropertyChanged("ThumbAsset");
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
		public KalturaThumbParams ThumbParams
		{
			get { return _ThumbParams; }
			set 
			{ 
				_ThumbParams = value;
				OnPropertyChanged("ThumbParams");
			}
		}
		public KalturaThumbParamsOutputListResponse ThumbParamsOutputs
		{
			get { return _ThumbParamsOutputs; }
			set 
			{ 
				_ThumbParamsOutputs = value;
				OnPropertyChanged("ThumbParamsOutputs");
			}
		}
		#endregion

		#region CTor
		public KalturaInvestigateThumbAssetData()
		{
		}

		public KalturaInvestigateThumbAssetData(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbAsset":
						this.ThumbAsset = (KalturaThumbAsset)KalturaObjectFactory.Create(propertyNode, "KalturaThumbAsset");
						continue;
					case "fileSyncs":
						this.FileSyncs = (KalturaFileSyncListResponse)KalturaObjectFactory.Create(propertyNode, "KalturaFileSyncListResponse");
						continue;
					case "thumbParams":
						this.ThumbParams = (KalturaThumbParams)KalturaObjectFactory.Create(propertyNode, "KalturaThumbParams");
						continue;
					case "thumbParamsOutputs":
						this.ThumbParamsOutputs = (KalturaThumbParamsOutputListResponse)KalturaObjectFactory.Create(propertyNode, "KalturaThumbParamsOutputListResponse");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaInvestigateThumbAssetData");
			if (this.ThumbAsset != null)
				kparams.Add("thumbAsset", this.ThumbAsset.ToParams());
			if (this.FileSyncs != null)
				kparams.Add("fileSyncs", this.FileSyncs.ToParams());
			if (this.ThumbParams != null)
				kparams.Add("thumbParams", this.ThumbParams.ToParams());
			if (this.ThumbParamsOutputs != null)
				kparams.Add("thumbParamsOutputs", this.ThumbParamsOutputs.ToParams());
			return kparams;
		}
		#endregion
	}
}

