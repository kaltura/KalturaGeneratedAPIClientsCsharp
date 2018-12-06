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
	public class CaptionParamsBaseFilter : AssetParamsFilter
	{
		#region Constants
		public const string FORMAT_EQUAL = "formatEqual";
		public const string FORMAT_IN = "formatIn";
		#endregion

		#region Private Fields
		private CaptionType _FormatEqual = null;
		private string _FormatIn = null;
		#endregion

		#region Properties
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
		#endregion

		#region CTor
		public CaptionParamsBaseFilter()
		{
		}

		public CaptionParamsBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "formatEqual":
						this._FormatEqual = (CaptionType)StringEnum.Parse(typeof(CaptionType), propertyNode.InnerText);
						continue;
					case "formatIn":
						this._FormatIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public CaptionParamsBaseFilter(IDictionary<string,object> data) : base(data)
		{
			    this._FormatEqual = (CaptionType)StringEnum.Parse(typeof(CaptionType), data.TryGetValueSafe<string>("formatEqual"));
			    this._FormatIn = data.TryGetValueSafe<string>("formatIn");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCaptionParamsBaseFilter");
			kparams.AddIfNotNull("formatEqual", this._FormatEqual);
			kparams.AddIfNotNull("formatIn", this._FormatIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FORMAT_EQUAL:
					return "FormatEqual";
				case FORMAT_IN:
					return "FormatIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

