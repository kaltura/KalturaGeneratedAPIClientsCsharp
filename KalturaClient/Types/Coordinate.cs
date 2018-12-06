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
	public class Coordinate : ObjectBase
	{
		#region Constants
		public const string LATITUDE = "latitude";
		public const string LONGITUDE = "longitude";
		public const string NAME = "name";
		#endregion

		#region Private Fields
		private float _Latitude = Single.MinValue;
		private float _Longitude = Single.MinValue;
		private string _Name = null;
		#endregion

		#region Properties
		public float Latitude
		{
			get { return _Latitude; }
			set 
			{ 
				_Latitude = value;
				OnPropertyChanged("Latitude");
			}
		}
		public float Longitude
		{
			get { return _Longitude; }
			set 
			{ 
				_Longitude = value;
				OnPropertyChanged("Longitude");
			}
		}
		public string Name
		{
			get { return _Name; }
			set 
			{ 
				_Name = value;
				OnPropertyChanged("Name");
			}
		}
		#endregion

		#region CTor
		public Coordinate()
		{
		}

		public Coordinate(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "latitude":
						this._Latitude = ParseFloat(propertyNode.InnerText);
						continue;
					case "longitude":
						this._Longitude = ParseFloat(propertyNode.InnerText);
						continue;
					case "name":
						this._Name = propertyNode.InnerText;
						continue;
				}
			}
		}

		public Coordinate(IDictionary<string,object> data) : base(data)
		{
			    this._Latitude = data.TryGetValueSafe<float>("latitude");
			    this._Longitude = data.TryGetValueSafe<float>("longitude");
			    this._Name = data.TryGetValueSafe<string>("name");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCoordinate");
			kparams.AddIfNotNull("latitude", this._Latitude);
			kparams.AddIfNotNull("longitude", this._Longitude);
			kparams.AddIfNotNull("name", this._Name);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case LATITUDE:
					return "Latitude";
				case LONGITUDE:
					return "Longitude";
				case NAME:
					return "Name";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

