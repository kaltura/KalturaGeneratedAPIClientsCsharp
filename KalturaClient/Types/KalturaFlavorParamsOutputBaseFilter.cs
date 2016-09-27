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
	public class KalturaFlavorParamsOutputBaseFilter : KalturaFlavorParamsFilter
	{
		#region Private Fields
		private int _FlavorParamsIdEqual = Int32.MinValue;
		private string _FlavorParamsVersionEqual = null;
		private string _FlavorAssetIdEqual = null;
		private string _FlavorAssetVersionEqual = null;
		#endregion

		#region Properties
		public int FlavorParamsIdEqual
		{
			get { return _FlavorParamsIdEqual; }
			set 
			{ 
				_FlavorParamsIdEqual = value;
				OnPropertyChanged("FlavorParamsIdEqual");
			}
		}
		public string FlavorParamsVersionEqual
		{
			get { return _FlavorParamsVersionEqual; }
			set 
			{ 
				_FlavorParamsVersionEqual = value;
				OnPropertyChanged("FlavorParamsVersionEqual");
			}
		}
		public string FlavorAssetIdEqual
		{
			get { return _FlavorAssetIdEqual; }
			set 
			{ 
				_FlavorAssetIdEqual = value;
				OnPropertyChanged("FlavorAssetIdEqual");
			}
		}
		public string FlavorAssetVersionEqual
		{
			get { return _FlavorAssetVersionEqual; }
			set 
			{ 
				_FlavorAssetVersionEqual = value;
				OnPropertyChanged("FlavorAssetVersionEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorParamsOutputBaseFilter()
		{
		}

		public KalturaFlavorParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsIdEqual":
						this._FlavorParamsIdEqual = ParseInt(txt);
						continue;
					case "flavorParamsVersionEqual":
						this._FlavorParamsVersionEqual = txt;
						continue;
					case "flavorAssetIdEqual":
						this._FlavorAssetIdEqual = txt;
						continue;
					case "flavorAssetVersionEqual":
						this._FlavorAssetVersionEqual = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFlavorParamsOutputBaseFilter");
			kparams.AddIfNotNull("flavorParamsIdEqual", this._FlavorParamsIdEqual);
			kparams.AddIfNotNull("flavorParamsVersionEqual", this._FlavorParamsVersionEqual);
			kparams.AddIfNotNull("flavorAssetIdEqual", this._FlavorAssetIdEqual);
			kparams.AddIfNotNull("flavorAssetVersionEqual", this._FlavorAssetVersionEqual);
			return kparams;
		}
		#endregion
	}
}

