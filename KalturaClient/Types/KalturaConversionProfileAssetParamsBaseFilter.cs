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
	public class KalturaConversionProfileAssetParamsBaseFilter : KalturaRelatedFilter
	{
		#region Private Fields
		private int _ConversionProfileIdEqual = Int32.MinValue;
		private string _ConversionProfileIdIn = null;
		private int _AssetParamsIdEqual = Int32.MinValue;
		private string _AssetParamsIdIn = null;
		private KalturaFlavorReadyBehaviorType _ReadyBehaviorEqual = (KalturaFlavorReadyBehaviorType)Int32.MinValue;
		private string _ReadyBehaviorIn = null;
		private KalturaAssetParamsOrigin _OriginEqual = (KalturaAssetParamsOrigin)Int32.MinValue;
		private string _OriginIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		#endregion

		#region Properties
		public int ConversionProfileIdEqual
		{
			get { return _ConversionProfileIdEqual; }
			set 
			{ 
				_ConversionProfileIdEqual = value;
				OnPropertyChanged("ConversionProfileIdEqual");
			}
		}
		public string ConversionProfileIdIn
		{
			get { return _ConversionProfileIdIn; }
			set 
			{ 
				_ConversionProfileIdIn = value;
				OnPropertyChanged("ConversionProfileIdIn");
			}
		}
		public int AssetParamsIdEqual
		{
			get { return _AssetParamsIdEqual; }
			set 
			{ 
				_AssetParamsIdEqual = value;
				OnPropertyChanged("AssetParamsIdEqual");
			}
		}
		public string AssetParamsIdIn
		{
			get { return _AssetParamsIdIn; }
			set 
			{ 
				_AssetParamsIdIn = value;
				OnPropertyChanged("AssetParamsIdIn");
			}
		}
		public KalturaFlavorReadyBehaviorType ReadyBehaviorEqual
		{
			get { return _ReadyBehaviorEqual; }
			set 
			{ 
				_ReadyBehaviorEqual = value;
				OnPropertyChanged("ReadyBehaviorEqual");
			}
		}
		public string ReadyBehaviorIn
		{
			get { return _ReadyBehaviorIn; }
			set 
			{ 
				_ReadyBehaviorIn = value;
				OnPropertyChanged("ReadyBehaviorIn");
			}
		}
		public KalturaAssetParamsOrigin OriginEqual
		{
			get { return _OriginEqual; }
			set 
			{ 
				_OriginEqual = value;
				OnPropertyChanged("OriginEqual");
			}
		}
		public string OriginIn
		{
			get { return _OriginIn; }
			set 
			{ 
				_OriginIn = value;
				OnPropertyChanged("OriginIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileAssetParamsBaseFilter()
		{
		}

		public KalturaConversionProfileAssetParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileIdEqual":
						this._ConversionProfileIdEqual = ParseInt(txt);
						continue;
					case "conversionProfileIdIn":
						this._ConversionProfileIdIn = txt;
						continue;
					case "assetParamsIdEqual":
						this._AssetParamsIdEqual = ParseInt(txt);
						continue;
					case "assetParamsIdIn":
						this._AssetParamsIdIn = txt;
						continue;
					case "readyBehaviorEqual":
						this._ReadyBehaviorEqual = (KalturaFlavorReadyBehaviorType)ParseEnum(typeof(KalturaFlavorReadyBehaviorType), txt);
						continue;
					case "readyBehaviorIn":
						this._ReadyBehaviorIn = txt;
						continue;
					case "originEqual":
						this._OriginEqual = (KalturaAssetParamsOrigin)ParseEnum(typeof(KalturaAssetParamsOrigin), txt);
						continue;
					case "originIn":
						this._OriginIn = txt;
						continue;
					case "systemNameEqual":
						this._SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this._SystemNameIn = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfileAssetParamsBaseFilter");
			kparams.AddIfNotNull("conversionProfileIdEqual", this._ConversionProfileIdEqual);
			kparams.AddIfNotNull("conversionProfileIdIn", this._ConversionProfileIdIn);
			kparams.AddIfNotNull("assetParamsIdEqual", this._AssetParamsIdEqual);
			kparams.AddIfNotNull("assetParamsIdIn", this._AssetParamsIdIn);
			kparams.AddIfNotNull("readyBehaviorEqual", this._ReadyBehaviorEqual);
			kparams.AddIfNotNull("readyBehaviorIn", this._ReadyBehaviorIn);
			kparams.AddIfNotNull("originEqual", this._OriginEqual);
			kparams.AddIfNotNull("originIn", this._OriginIn);
			kparams.AddIfNotNull("systemNameEqual", this._SystemNameEqual);
			kparams.AddIfNotNull("systemNameIn", this._SystemNameIn);
			return kparams;
		}
		#endregion
	}
}

