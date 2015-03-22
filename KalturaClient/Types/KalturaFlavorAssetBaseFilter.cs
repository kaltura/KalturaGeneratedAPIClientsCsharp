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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaFlavorAssetBaseFilter : KalturaAssetFilter
	{
		#region Private Fields
		private int _FlavorParamsIdEqual = Int32.MinValue;
		private string _FlavorParamsIdIn = null;
		private KalturaFlavorAssetStatus _StatusEqual = (KalturaFlavorAssetStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
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
		public string FlavorParamsIdIn
		{
			get { return _FlavorParamsIdIn; }
			set 
			{ 
				_FlavorParamsIdIn = value;
				OnPropertyChanged("FlavorParamsIdIn");
			}
		}
		public KalturaFlavorAssetStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public string StatusNotIn
		{
			get { return _StatusNotIn; }
			set 
			{ 
				_StatusNotIn = value;
				OnPropertyChanged("StatusNotIn");
			}
		}
		#endregion

		#region CTor
		public KalturaFlavorAssetBaseFilter()
		{
		}

		public KalturaFlavorAssetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorParamsIdEqual":
						this.FlavorParamsIdEqual = ParseInt(txt);
						continue;
					case "flavorParamsIdIn":
						this.FlavorParamsIdIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaFlavorAssetStatus)ParseEnum(typeof(KalturaFlavorAssetStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "statusNotIn":
						this.StatusNotIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFlavorAssetBaseFilter");
			kparams.AddIntIfNotNull("flavorParamsIdEqual", this.FlavorParamsIdEqual);
			kparams.AddStringIfNotNull("flavorParamsIdIn", this.FlavorParamsIdIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddStringIfNotNull("statusNotIn", this.StatusNotIn);
			return kparams;
		}
		#endregion
	}
}

