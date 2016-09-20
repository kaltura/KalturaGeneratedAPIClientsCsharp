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
	public class KalturaCaptionAssetBaseFilter : KalturaAssetFilter
	{
		#region Private Fields
		private int _CaptionParamsIdEqual = Int32.MinValue;
		private string _CaptionParamsIdIn = null;
		private KalturaCaptionType _FormatEqual = null;
		private string _FormatIn = null;
		private KalturaCaptionAssetStatus _StatusEqual = (KalturaCaptionAssetStatus)Int32.MinValue;
		private string _StatusIn = null;
		private string _StatusNotIn = null;
		#endregion

		#region Properties
		public int CaptionParamsIdEqual
		{
			get { return _CaptionParamsIdEqual; }
			set 
			{ 
				_CaptionParamsIdEqual = value;
				OnPropertyChanged("CaptionParamsIdEqual");
			}
		}
		public string CaptionParamsIdIn
		{
			get { return _CaptionParamsIdIn; }
			set 
			{ 
				_CaptionParamsIdIn = value;
				OnPropertyChanged("CaptionParamsIdIn");
			}
		}
		public KalturaCaptionType FormatEqual
		{
			get { return _FormatEqual; }
			set 
			{ 
				_FormatEqual = value;
				OnPropertyChanged("FormatEqual");
			}
		}
		public string FormatIn
		{
			get { return _FormatIn; }
			set 
			{ 
				_FormatIn = value;
				OnPropertyChanged("FormatIn");
			}
		}
		public KalturaCaptionAssetStatus StatusEqual
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
		public KalturaCaptionAssetBaseFilter()
		{
		}

		public KalturaCaptionAssetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "captionParamsIdEqual":
						this._CaptionParamsIdEqual = ParseInt(txt);
						continue;
					case "captionParamsIdIn":
						this._CaptionParamsIdIn = txt;
						continue;
					case "formatEqual":
						this._FormatEqual = (KalturaCaptionType)KalturaStringEnum.Parse(typeof(KalturaCaptionType), txt);
						continue;
					case "formatIn":
						this._FormatIn = txt;
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaCaptionAssetStatus)ParseEnum(typeof(KalturaCaptionAssetStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "statusNotIn":
						this._StatusNotIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCaptionAssetBaseFilter");
			kparams.AddIfNotNull("captionParamsIdEqual", this.CaptionParamsIdEqual);
			kparams.AddIfNotNull("captionParamsIdIn", this.CaptionParamsIdIn);
			kparams.AddIfNotNull("formatEqual", this.FormatEqual);
			kparams.AddIfNotNull("formatIn", this.FormatIn);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("statusNotIn", this.StatusNotIn);
			return kparams;
		}
		#endregion
	}
}

