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
	public class KalturaIpAddressRestriction : KalturaBaseRestriction
	{
		#region Private Fields
		private KalturaIpAddressRestrictionType _IpAddressRestrictionType = (KalturaIpAddressRestrictionType)Int32.MinValue;
		private string _IpAddressList = null;
		#endregion

		#region Properties
		public KalturaIpAddressRestrictionType IpAddressRestrictionType
		{
			get { return _IpAddressRestrictionType; }
			set 
			{ 
				_IpAddressRestrictionType = value;
				OnPropertyChanged("IpAddressRestrictionType");
			}
		}
		public string IpAddressList
		{
			get { return _IpAddressList; }
			set 
			{ 
				_IpAddressList = value;
				OnPropertyChanged("IpAddressList");
			}
		}
		#endregion

		#region CTor
		public KalturaIpAddressRestriction()
		{
		}

		public KalturaIpAddressRestriction(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "ipAddressRestrictionType":
						this.IpAddressRestrictionType = (KalturaIpAddressRestrictionType)ParseEnum(typeof(KalturaIpAddressRestrictionType), txt);
						continue;
					case "ipAddressList":
						this.IpAddressList = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaIpAddressRestriction");
			kparams.AddIfNotNull("ipAddressRestrictionType", this.IpAddressRestrictionType);
			kparams.AddIfNotNull("ipAddressList", this.IpAddressList);
			return kparams;
		}
		#endregion
	}
}

