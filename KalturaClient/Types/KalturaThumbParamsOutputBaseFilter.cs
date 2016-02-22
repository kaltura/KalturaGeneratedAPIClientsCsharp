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
	public class KalturaThumbParamsOutputBaseFilter : KalturaThumbParamsFilter
	{
		#region Private Fields
		private int _ThumbParamsIdEqual = Int32.MinValue;
		private string _ThumbParamsVersionEqual = null;
		private string _ThumbAssetIdEqual = null;
		private string _ThumbAssetVersionEqual = null;
		#endregion

		#region Properties
		public int ThumbParamsIdEqual
		{
			get { return _ThumbParamsIdEqual; }
			set 
			{ 
				_ThumbParamsIdEqual = value;
				OnPropertyChanged("ThumbParamsIdEqual");
			}
		}
		public string ThumbParamsVersionEqual
		{
			get { return _ThumbParamsVersionEqual; }
			set 
			{ 
				_ThumbParamsVersionEqual = value;
				OnPropertyChanged("ThumbParamsVersionEqual");
			}
		}
		public string ThumbAssetIdEqual
		{
			get { return _ThumbAssetIdEqual; }
			set 
			{ 
				_ThumbAssetIdEqual = value;
				OnPropertyChanged("ThumbAssetIdEqual");
			}
		}
		public string ThumbAssetVersionEqual
		{
			get { return _ThumbAssetVersionEqual; }
			set 
			{ 
				_ThumbAssetVersionEqual = value;
				OnPropertyChanged("ThumbAssetVersionEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaThumbParamsOutputBaseFilter()
		{
		}

		public KalturaThumbParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbParamsIdEqual":
						this.ThumbParamsIdEqual = ParseInt(txt);
						continue;
					case "thumbParamsVersionEqual":
						this.ThumbParamsVersionEqual = txt;
						continue;
					case "thumbAssetIdEqual":
						this.ThumbAssetIdEqual = txt;
						continue;
					case "thumbAssetVersionEqual":
						this.ThumbAssetVersionEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaThumbParamsOutputBaseFilter");
			kparams.AddIfNotNull("thumbParamsIdEqual", this.ThumbParamsIdEqual);
			kparams.AddIfNotNull("thumbParamsVersionEqual", this.ThumbParamsVersionEqual);
			kparams.AddIfNotNull("thumbAssetIdEqual", this.ThumbAssetIdEqual);
			kparams.AddIfNotNull("thumbAssetVersionEqual", this.ThumbAssetVersionEqual);
			return kparams;
		}
		#endregion
	}
}

