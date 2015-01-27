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
	public class KalturaConfigurableDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private IList<KalturaDistributionFieldConfig> _FieldConfigArray;
		private IList<KalturaExtendingItemMrssParameter> _ItemXpathsToExtend;
		#endregion

		#region Properties
		public IList<KalturaDistributionFieldConfig> FieldConfigArray
		{
			get { return _FieldConfigArray; }
			set 
			{ 
				_FieldConfigArray = value;
				OnPropertyChanged("FieldConfigArray");
			}
		}
		public IList<KalturaExtendingItemMrssParameter> ItemXpathsToExtend
		{
			get { return _ItemXpathsToExtend; }
			set 
			{ 
				_ItemXpathsToExtend = value;
				OnPropertyChanged("ItemXpathsToExtend");
			}
		}
		#endregion

		#region CTor
		public KalturaConfigurableDistributionProfile()
		{
		}

		public KalturaConfigurableDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldConfigArray":
						this.FieldConfigArray = new List<KalturaDistributionFieldConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.FieldConfigArray.Add((KalturaDistributionFieldConfig)KalturaObjectFactory.Create(arrayNode, "KalturaDistributionFieldConfig"));
						}
						continue;
					case "itemXpathsToExtend":
						this.ItemXpathsToExtend = new List<KalturaExtendingItemMrssParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this.ItemXpathsToExtend.Add((KalturaExtendingItemMrssParameter)KalturaObjectFactory.Create(arrayNode, "KalturaExtendingItemMrssParameter"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConfigurableDistributionProfile");
			if (this.FieldConfigArray != null)
			{
				if (this.FieldConfigArray.Count == 0)
				{
					kparams.Add("fieldConfigArray:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaDistributionFieldConfig item in this.FieldConfigArray)
					{
						kparams.Add("fieldConfigArray:" + i, item.ToParams());
						i++;
					}
				}
			}
			if (this.ItemXpathsToExtend != null)
			{
				if (this.ItemXpathsToExtend.Count == 0)
				{
					kparams.Add("itemXpathsToExtend:-", "");
				}
				else
				{
					int i = 0;
					foreach (KalturaExtendingItemMrssParameter item in this.ItemXpathsToExtend)
					{
						kparams.Add("itemXpathsToExtend:" + i, item.ToParams());
						i++;
					}
				}
			}
			return kparams;
		}
		#endregion
	}
}

