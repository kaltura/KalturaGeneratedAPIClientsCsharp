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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaCoordinate : KalturaObjectBase
	{
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
		public KalturaCoordinate()
		{
		}

		public KalturaCoordinate(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "latitude":
						this.Latitude = ParseFloat(txt);
						continue;
					case "longitude":
						this.Longitude = ParseFloat(txt);
						continue;
					case "name":
						this.Name = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCoordinate");
			kparams.AddFloatIfNotNull("latitude", this.Latitude);
			kparams.AddFloatIfNotNull("longitude", this.Longitude);
			kparams.AddStringIfNotNull("name", this.Name);
			return kparams;
		}
		#endregion
	}
}

