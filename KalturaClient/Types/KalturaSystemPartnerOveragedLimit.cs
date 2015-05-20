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
	public class KalturaSystemPartnerOveragedLimit : KalturaSystemPartnerLimit
	{
		#region Private Fields
		private float _OveragePrice = Single.MinValue;
		private float _OverageUnit = Single.MinValue;
		#endregion

		#region Properties
		public float OveragePrice
		{
			get { return _OveragePrice; }
			set 
			{ 
				_OveragePrice = value;
				OnPropertyChanged("OveragePrice");
			}
		}
		public float OverageUnit
		{
			get { return _OverageUnit; }
			set 
			{ 
				_OverageUnit = value;
				OnPropertyChanged("OverageUnit");
			}
		}
		#endregion

		#region CTor
		public KalturaSystemPartnerOveragedLimit()
		{
		}

		public KalturaSystemPartnerOveragedLimit(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "overagePrice":
						this.OveragePrice = ParseFloat(txt);
						continue;
					case "overageUnit":
						this.OverageUnit = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaSystemPartnerOveragedLimit");
			kparams.AddFloatIfNotNull("overagePrice", this.OveragePrice);
			kparams.AddFloatIfNotNull("overageUnit", this.OverageUnit);
			return kparams;
		}
		#endregion
	}
}

