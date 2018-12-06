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
	public class SystemPartnerFilter : PartnerFilter
	{
		#region Constants
		public const string PARTNER_PARENT_ID_EQUAL = "partnerParentIdEqual";
		public const string PARTNER_PARENT_ID_IN = "partnerParentIdIn";
		#endregion

		#region Private Fields
		private int _PartnerParentIdEqual = Int32.MinValue;
		private string _PartnerParentIdIn = null;
		#endregion

		#region Properties
		public int PartnerParentIdEqual
		{
			get { return _PartnerParentIdEqual; }
			set 
			{ 
				_PartnerParentIdEqual = value;
				OnPropertyChanged("PartnerParentIdEqual");
			}
		}
		public string PartnerParentIdIn
		{
			get { return _PartnerParentIdIn; }
			set 
			{ 
				_PartnerParentIdIn = value;
				OnPropertyChanged("PartnerParentIdIn");
			}
		}
		#endregion

		#region CTor
		public SystemPartnerFilter()
		{
		}

		public SystemPartnerFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "partnerParentIdEqual":
						this._PartnerParentIdEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "partnerParentIdIn":
						this._PartnerParentIdIn = propertyNode.InnerText;
						continue;
				}
			}
		}

		public SystemPartnerFilter(IDictionary<string,object> data) : base(data)
		{
			    this._PartnerParentIdEqual = data.TryGetValueSafe<int>("partnerParentIdEqual");
			    this._PartnerParentIdIn = data.TryGetValueSafe<string>("partnerParentIdIn");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaSystemPartnerFilter");
			kparams.AddIfNotNull("partnerParentIdEqual", this._PartnerParentIdEqual);
			kparams.AddIfNotNull("partnerParentIdIn", this._PartnerParentIdIn);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case PARTNER_PARENT_ID_EQUAL:
					return "PartnerParentIdEqual";
				case PARTNER_PARENT_ID_IN:
					return "PartnerParentIdIn";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

