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
// Copyright (C) 2006-2011  Kaltura Inc.
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
	public class KalturaPartnerUsageListResponse : KalturaObjectBase
	{
		#region Private Fields
		private KalturaVarPartnerUsageItem _Total;
		private IList<KalturaVarPartnerUsageItem> _Objects;
		private int _TotalCount = Int32.MinValue;
		#endregion

		#region Properties
		public KalturaVarPartnerUsageItem Total
		{
			get { return _Total; }
			set 
			{ 
				_Total = value;
				OnPropertyChanged("Total");
			}
		}
		public IList<KalturaVarPartnerUsageItem> Objects
		{
			get { return _Objects; }
			set 
			{ 
				_Objects = value;
				OnPropertyChanged("Objects");
			}
		}
		public int TotalCount
		{
			get { return _TotalCount; }
			set 
			{ 
				_TotalCount = value;
				OnPropertyChanged("TotalCount");
			}
		}
		#endregion

		#region CTor
		public KalturaPartnerUsageListResponse()
		{
		}

		public KalturaPartnerUsageListResponse(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "total":
						this.Total = (KalturaVarPartnerUsageItem)KalturaObjectFactory.Create(propertyNode, "KalturaVarPartnerUsageItem");
						continue;
					case "objects":
						this.Objects = new List<KalturaVarPartnerUsageItem>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.Objects.Add((KalturaVarPartnerUsageItem)KalturaObjectFactory.Create(arrayNode, "KalturaVarPartnerUsageItem"));
						}
						continue;
					case "totalCount":
						this.TotalCount = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPartnerUsageListResponse");
			if (this.Total != null)
				kparams.Add("total", this.Total.ToParams());
			if (this.Objects != null)
			{
				if (this.Objects.Count == 0)
				{
					kparams.Add("objects:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaVarPartnerUsageItem item in this.Objects)
					{
						kparams.Add("objects:" + i, item.ToParams());
						i++;
					}
				}
			}
			kparams.AddIntIfNotNull("totalCount", this.TotalCount);
			return kparams;
		}
		#endregion
	}
}

