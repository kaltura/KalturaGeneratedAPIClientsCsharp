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
	public class KalturaGeoTimeLiveStats : KalturaEntryLiveStats
	{
		#region Private Fields
		private KalturaCoordinate _City;
		private KalturaCoordinate _Country;
		#endregion

		#region Properties
		public KalturaCoordinate City
		{
			get { return _City; }
			set 
			{ 
				_City = value;
				OnPropertyChanged("City");
			}
		}
		public KalturaCoordinate Country
		{
			get { return _Country; }
			set 
			{ 
				_Country = value;
				OnPropertyChanged("Country");
			}
		}
		#endregion

		#region CTor
		public KalturaGeoTimeLiveStats()
		{
		}

		public KalturaGeoTimeLiveStats(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "city":
						this.City = (KalturaCoordinate)KalturaObjectFactory.Create(propertyNode, "KalturaCoordinate");
						continue;
					case "country":
						this.Country = (KalturaCoordinate)KalturaObjectFactory.Create(propertyNode, "KalturaCoordinate");
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaGeoTimeLiveStats");
			kparams.AddIfNotNull("city", this.City);
			kparams.AddIfNotNull("country", this.Country);
			return kparams;
		}
		#endregion
	}
}

