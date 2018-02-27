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
	public class ESearchItemDataResult : ObjectBase
	{
		#region Constants
		public const string TOTAL_COUNT = "totalCount";
		public const string ITEMS = "items";
		public const string ITEMS_TYPE = "itemsType";
		#endregion

		#region Private Fields
		private int _TotalCount = Int32.MinValue;
		private IList<ESearchItemData> _Items;
		private string _ItemsType = null;
		#endregion

		#region Properties
		public int TotalCount
		{
			get { return _TotalCount; }
			set 
			{ 
				_TotalCount = value;
				OnPropertyChanged("TotalCount");
			}
		}
		public IList<ESearchItemData> Items
		{
			get { return _Items; }
			set 
			{ 
				_Items = value;
				OnPropertyChanged("Items");
			}
		}
		public string ItemsType
		{
			get { return _ItemsType; }
			set 
			{ 
				_ItemsType = value;
				OnPropertyChanged("ItemsType");
			}
		}
		#endregion

		#region CTor
		public ESearchItemDataResult()
		{
		}

		public ESearchItemDataResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "totalCount":
						this._TotalCount = ParseInt(propertyNode.InnerText);
						continue;
					case "items":
						this._Items = new List<ESearchItemData>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Items.Add(ObjectFactory.Create<ESearchItemData>(arrayNode));
						}
						continue;
					case "itemsType":
						this._ItemsType = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaESearchItemDataResult");
			kparams.AddIfNotNull("totalCount", this._TotalCount);
			kparams.AddIfNotNull("items", this._Items);
			kparams.AddIfNotNull("itemsType", this._ItemsType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TOTAL_COUNT:
					return "TotalCount";
				case ITEMS:
					return "Items";
				case ITEMS_TYPE:
					return "ItemsType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

