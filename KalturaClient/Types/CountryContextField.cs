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
	public class CountryContextField : StringField
	{
		#region Constants
		public const string GEO_CODER_TYPE = "geoCoderType";
		#endregion

		#region Private Fields
		private GeoCoderType _GeoCoderType = null;
		#endregion

		#region Properties
		public GeoCoderType GeoCoderType
		{
			get { return _GeoCoderType; }
			set 
			{ 
				_GeoCoderType = value;
				OnPropertyChanged("GeoCoderType");
			}
		}
		#endregion

		#region CTor
		public CountryContextField()
		{
		}

		public CountryContextField(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "geoCoderType":
						this._GeoCoderType = (GeoCoderType)StringEnum.Parse(typeof(GeoCoderType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public CountryContextField(IDictionary<string,object> data) : base(data)
		{
			    this._GeoCoderType = (GeoCoderType)StringEnum.Parse(typeof(GeoCoderType), data.TryGetValueSafe<string>("geoCoderType"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCountryContextField");
			kparams.AddIfNotNull("geoCoderType", this._GeoCoderType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GEO_CODER_TYPE:
					return "GeoCoderType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

