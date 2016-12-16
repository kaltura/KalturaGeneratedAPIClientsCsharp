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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ThumbParamsOutputBaseFilter : ThumbParamsFilter
	{
		#region Constants
		public const string THUMB_PARAMS_ID_EQUAL = "thumbParamsIdEqual";
		public const string THUMB_PARAMS_VERSION_EQUAL = "thumbParamsVersionEqual";
		public const string THUMB_ASSET_ID_EQUAL = "thumbAssetIdEqual";
		public const string THUMB_ASSET_VERSION_EQUAL = "thumbAssetVersionEqual";
		#endregion

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
		public ThumbParamsOutputBaseFilter()
		{
		}

		public ThumbParamsOutputBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "thumbParamsIdEqual":
						this._ThumbParamsIdEqual = ParseInt(txt);
						continue;
					case "thumbParamsVersionEqual":
						this._ThumbParamsVersionEqual = txt;
						continue;
					case "thumbAssetIdEqual":
						this._ThumbAssetIdEqual = txt;
						continue;
					case "thumbAssetVersionEqual":
						this._ThumbAssetVersionEqual = txt;
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
				kparams.AddReplace("objectType", "KalturaThumbParamsOutputBaseFilter");
			kparams.AddIfNotNull("thumbParamsIdEqual", this._ThumbParamsIdEqual);
			kparams.AddIfNotNull("thumbParamsVersionEqual", this._ThumbParamsVersionEqual);
			kparams.AddIfNotNull("thumbAssetIdEqual", this._ThumbAssetIdEqual);
			kparams.AddIfNotNull("thumbAssetVersionEqual", this._ThumbAssetVersionEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case THUMB_PARAMS_ID_EQUAL:
					return "ThumbParamsIdEqual";
				case THUMB_PARAMS_VERSION_EQUAL:
					return "ThumbParamsVersionEqual";
				case THUMB_ASSET_ID_EQUAL:
					return "ThumbAssetIdEqual";
				case THUMB_ASSET_VERSION_EQUAL:
					return "ThumbAssetVersionEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

