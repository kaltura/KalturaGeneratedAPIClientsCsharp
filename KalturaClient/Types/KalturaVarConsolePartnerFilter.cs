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
	public class KalturaVarConsolePartnerFilter : KalturaPartnerFilter
	{
		#region Private Fields
		private KalturaPartnerGroupType _GroupTypeEq = (KalturaPartnerGroupType)Int32.MinValue;
		private string _GroupTypeIn = null;
		private string _PartnerPermissionsExist = null;
		#endregion

		#region Properties
		public KalturaPartnerGroupType GroupTypeEq
		{
			get { return _GroupTypeEq; }
			set 
			{ 
				_GroupTypeEq = value;
				OnPropertyChanged("GroupTypeEq");
			}
		}
		public string GroupTypeIn
		{
			get { return _GroupTypeIn; }
			set 
			{ 
				_GroupTypeIn = value;
				OnPropertyChanged("GroupTypeIn");
			}
		}
		public string PartnerPermissionsExist
		{
			get { return _PartnerPermissionsExist; }
			set 
			{ 
				_PartnerPermissionsExist = value;
				OnPropertyChanged("PartnerPermissionsExist");
			}
		}
		#endregion

		#region CTor
		public KalturaVarConsolePartnerFilter()
		{
		}

		public KalturaVarConsolePartnerFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "groupTypeEq":
						this.GroupTypeEq = (KalturaPartnerGroupType)ParseEnum(typeof(KalturaPartnerGroupType), txt);
						continue;
					case "groupTypeIn":
						this.GroupTypeIn = txt;
						continue;
					case "partnerPermissionsExist":
						this.PartnerPermissionsExist = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaVarConsolePartnerFilter");
			kparams.AddIfNotNull("groupTypeEq", this.GroupTypeEq);
			kparams.AddIfNotNull("groupTypeIn", this.GroupTypeIn);
			kparams.AddIfNotNull("partnerPermissionsExist", this.PartnerPermissionsExist);
			return kparams;
		}
		#endregion
	}
}

