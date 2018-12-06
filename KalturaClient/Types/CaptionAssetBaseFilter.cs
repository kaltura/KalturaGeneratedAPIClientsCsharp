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
	public class CaptionAssetBaseFilter : AssetFilter
	{
		#region Constants
		public const string CAPTION_PARAMS_ID_EQUAL = "captionParamsIdEqual";
		public const string CAPTION_PARAMS_ID_IN = "captionParamsIdIn";
		public const string FORMAT_EQUAL = "formatEqual";
		public const string FORMAT_IN = "formatIn";
		public const string STATUS_EQUAL = "statusEqual";
		public const string STATUS_IN = "statusIn";
		public const string STATUS_NOT_IN = "statusNotIn";
		#endregion

		#region Private Fields
		private int _CaptionParamsIdEqual = Int32.MinValue;
		private string _CaptionParamsIdIn = null;
		private CaptionType _FormatEqual = null;
		private string _FormatIn = null;
		private CaptionAssetStatus _StatusEqual = (CaptionAssetStatus)Int32.MinValue;
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
		public CaptionType FormatEqual
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
		public CaptionAssetStatus StatusEqual
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
		public CaptionAssetBaseFilter()
		{
		}

		public CaptionAssetBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "captionParamsIdEqual":
						this._CaptionParamsIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "captionParamsIdIn":
						this._CaptionParamsIdIn = propertyNode.InnerText;
						continue;
					case "formatEqual":
						this._FormatEqual = (CaptionType)StringEnum.Parse(typeof(CaptionType), propertyNode.InnerText);
						continue;
					case "formatIn":
						this._FormatIn = propertyNode.InnerText;
						continue;
					case "statusEqual":
						this._StatusEqual = (CaptionAssetStatus)ParseEnum(typeof(CaptionAssetStatus), propertyNode.InnerText);
						continue;
					case "statusIn":
						this._StatusIn = propertyNode.InnerText;
						continue;
					case "statusNotIn":
						this._StatusNotIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public CaptionAssetBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._CaptionParamsIdEqual = data.TryGetValueSafe<int>("captionParamsIdEqual");
			    this._CaptionParamsIdIn = data.TryGetValueSafe<string>("captionParamsIdIn");
			    this._FormatEqual = (CaptionType)StringEnum.Parse(typeof(CaptionType), data.TryGetValueSafe<string>("formatEqual"));
			    this._FormatIn = data.TryGetValueSafe<string>("formatIn");
			    this._StatusEqual = (CaptionAssetStatus)ParseEnum(typeof(CaptionAssetStatus), data.TryGetValueSafe<int>("statusEqual"));
			    this._StatusIn = data.TryGetValueSafe<string>("statusIn");
			    this._StatusNotIn = data.TryGetValueSafe<string>("statusNotIn");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionAssetBaseFilter");
			kparams.AddIfNotNull("captionParamsIdEqual", this._CaptionParamsIdEqual);
			kparams.AddIfNotNull("captionParamsIdIn", this._CaptionParamsIdIn);
			kparams.AddIfNotNull("formatEqual", this._FormatEqual);
			kparams.AddIfNotNull("formatIn", this._FormatIn);
			kparams.AddIfNotNull("statusEqual", this._StatusEqual);
			kparams.AddIfNotNull("statusIn", this._StatusIn);
			kparams.AddIfNotNull("statusNotIn", this._StatusNotIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CAPTION_PARAMS_ID_EQUAL:
					return "CaptionParamsIdEqual";
				case CAPTION_PARAMS_ID_IN:
					return "CaptionParamsIdIn";
				case FORMAT_EQUAL:
					return "FormatEqual";
				case FORMAT_IN:
					return "FormatIn";
				case STATUS_EQUAL:
					return "StatusEqual";
				case STATUS_IN:
					return "StatusIn";
				case STATUS_NOT_IN:
					return "StatusNotIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

