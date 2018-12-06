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
	public class BeaconAbstractScheduledResourceItem : BeaconScheduledResourceBaseItem
	{
		#region Constants
		public const string SEARCH_TERM = "searchTerm";
		public const string ITEM_TYPE = "itemType";
		public const string RANGE = "range";
		#endregion

		#region Private Fields
		private string _SearchTerm = null;
		private ESearchItemType _ItemType = (ESearchItemType)Int32.MinValue;
		private ESearchRange _Range;
		#endregion

		#region Properties
		public string SearchTerm
		{
			get { return _SearchTerm; }
			set 
			{ 
				_SearchTerm = value;
				OnPropertyChanged("SearchTerm");
			}
		}
		public ESearchItemType ItemType
		{
			get { return _ItemType; }
			set 
			{ 
				_ItemType = value;
				OnPropertyChanged("ItemType");
			}
		}
		public ESearchRange Range
		{
			get { return _Range; }
			set 
			{ 
				_Range = value;
				OnPropertyChanged("Range");
			}
		}
		#endregion

		#region CTor
		public BeaconAbstractScheduledResourceItem()
		{
		}

		public BeaconAbstractScheduledResourceItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "searchTerm":
						this._SearchTerm = propertyNode.InnerText;
						continue;
					case "itemType":
						this._ItemType = (ESearchItemType)ParseEnum(typeof(ESearchItemType), propertyNode.InnerText);
						continue;
					case "range":
						this._Range = ObjectFactory.Create<ESearchRange>(propertyNode);
						continue;
				}
			}
		}

		public BeaconAbstractScheduledResourceItem(IDictionary<string,object> data) : base(data)
		{
			    this._SearchTerm = data.TryGetValueSafe<string>("searchTerm");
			    this._ItemType = (ESearchItemType)ParseEnum(typeof(ESearchItemType), data.TryGetValueSafe<int>("itemType"));
			    this._Range = ObjectFactory.Create<ESearchRange>(data.TryGetValueSafe<IDictionary<string,object>>("range"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBeaconAbstractScheduledResourceItem");
			kparams.AddIfNotNull("searchTerm", this._SearchTerm);
			kparams.AddIfNotNull("itemType", this._ItemType);
			kparams.AddIfNotNull("range", this._Range);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SEARCH_TERM:
					return "SearchTerm";
				case ITEM_TYPE:
					return "ItemType";
				case RANGE:
					return "Range";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

