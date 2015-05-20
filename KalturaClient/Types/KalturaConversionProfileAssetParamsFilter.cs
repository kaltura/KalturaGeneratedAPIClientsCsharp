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
	public class KalturaConversionProfileAssetParamsFilter : KalturaConversionProfileAssetParamsBaseFilter
	{
		#region Private Fields
		private KalturaConversionProfileFilter _ConversionProfileIdFilter;
		private KalturaAssetParamsFilter _AssetParamsIdFilter;
		private KalturaConversionProfileAssetParamsOrderBy _OrderBy = null;
		#endregion

		#region Properties
		public KalturaConversionProfileFilter ConversionProfileIdFilter
		{
			get { return _ConversionProfileIdFilter; }
			set 
			{ 
				_ConversionProfileIdFilter = value;
				OnPropertyChanged("ConversionProfileIdFilter");
			}
		}
		public KalturaAssetParamsFilter AssetParamsIdFilter
		{
			get { return _AssetParamsIdFilter; }
			set 
			{ 
				_AssetParamsIdFilter = value;
				OnPropertyChanged("AssetParamsIdFilter");
			}
		}
		public new KalturaConversionProfileAssetParamsOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public KalturaConversionProfileAssetParamsFilter()
		{
		}

		public KalturaConversionProfileAssetParamsFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "conversionProfileIdFilter":
						this.ConversionProfileIdFilter = (KalturaConversionProfileFilter)KalturaObjectFactory.Create(propertyNode, "KalturaConversionProfileFilter");
						continue;
					case "assetParamsIdFilter":
						this.AssetParamsIdFilter = (KalturaAssetParamsFilter)KalturaObjectFactory.Create(propertyNode, "KalturaAssetParamsFilter");
						continue;
					case "orderBy":
						this.OrderBy = (KalturaConversionProfileAssetParamsOrderBy)KalturaStringEnum.Parse(typeof(KalturaConversionProfileAssetParamsOrderBy), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaConversionProfileAssetParamsFilter");
			if (this.ConversionProfileIdFilter != null)
				kparams.Add("conversionProfileIdFilter", this.ConversionProfileIdFilter.ToParams());
			if (this.AssetParamsIdFilter != null)
				kparams.Add("assetParamsIdFilter", this.AssetParamsIdFilter.ToParams());
			kparams.AddStringEnumIfNotNull("orderBy", this.OrderBy);
			return kparams;
		}
		#endregion
	}
}

