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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ConfigurableDistributionProfile : DistributionProfile
	{
		#region Constants
		public const string FIELD_CONFIG_ARRAY = "fieldConfigArray";
		public const string ITEM_XPATHS_TO_EXTEND = "itemXpathsToExtend";
		public const string USE_CATEGORY_ENTRIES = "useCategoryEntries";
		#endregion

		#region Private Fields
		private IList<DistributionFieldConfig> _FieldConfigArray;
		private IList<ExtendingItemMrssParameter> _ItemXpathsToExtend;
		private bool? _UseCategoryEntries = null;
		#endregion

		#region Properties
		public IList<DistributionFieldConfig> FieldConfigArray
		{
			get { return _FieldConfigArray; }
			set 
			{ 
				_FieldConfigArray = value;
				OnPropertyChanged("FieldConfigArray");
			}
		}
		public IList<ExtendingItemMrssParameter> ItemXpathsToExtend
		{
			get { return _ItemXpathsToExtend; }
			set 
			{ 
				_ItemXpathsToExtend = value;
				OnPropertyChanged("ItemXpathsToExtend");
			}
		}
		public bool? UseCategoryEntries
		{
			get { return _UseCategoryEntries; }
			set 
			{ 
				_UseCategoryEntries = value;
				OnPropertyChanged("UseCategoryEntries");
			}
		}
		#endregion

		#region CTor
		public ConfigurableDistributionProfile()
		{
		}

		public ConfigurableDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "fieldConfigArray":
						this._FieldConfigArray = new List<DistributionFieldConfig>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._FieldConfigArray.Add(ObjectFactory.Create<DistributionFieldConfig>(arrayNode));
						}
						continue;
					case "itemXpathsToExtend":
						this._ItemXpathsToExtend = new List<ExtendingItemMrssParameter>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ItemXpathsToExtend.Add(ObjectFactory.Create<ExtendingItemMrssParameter>(arrayNode));
						}
						continue;
					case "useCategoryEntries":
						this._UseCategoryEntries = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaConfigurableDistributionProfile");
			kparams.AddIfNotNull("fieldConfigArray", this._FieldConfigArray);
			kparams.AddIfNotNull("itemXpathsToExtend", this._ItemXpathsToExtend);
			kparams.AddIfNotNull("useCategoryEntries", this._UseCategoryEntries);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FIELD_CONFIG_ARRAY:
					return "FieldConfigArray";
				case ITEM_XPATHS_TO_EXTEND:
					return "ItemXpathsToExtend";
				case USE_CATEGORY_ENTRIES:
					return "UseCategoryEntries";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

