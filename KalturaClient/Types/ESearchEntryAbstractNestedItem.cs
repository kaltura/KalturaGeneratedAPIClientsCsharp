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
// Copyright (C) 2006-2021  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class ESearchEntryAbstractNestedItem : ESearchEntryNestedBaseItem
	{
		#region Constants
		public const string SEARCH_TERM = "searchTerm";
		public const string ITEM_TYPE = "itemType";
		public const string RANGE = "range";
		public const string ADD_HIGHLIGHT = "addHighlight";
		#endregion

		#region Private Fields
		private string _SearchTerm = null;
		private ESearchItemType _ItemType = (ESearchItemType)Int32.MinValue;
		private ESearchRange _Range;
		private bool? _AddHighlight = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string SearchTerm
		{
			get { return _SearchTerm; }
			set 
			{ 
				_SearchTerm = value;
				OnPropertyChanged("SearchTerm");
			}
		}
		[JsonProperty]
		public ESearchItemType ItemType
		{
			get { return _ItemType; }
			set 
			{ 
				_ItemType = value;
				OnPropertyChanged("ItemType");
			}
		}
		[JsonProperty]
		public ESearchRange Range
		{
			get { return _Range; }
			set 
			{ 
				_Range = value;
				OnPropertyChanged("Range");
			}
		}
		[JsonProperty]
		public bool? AddHighlight
		{
			get { return _AddHighlight; }
			set 
			{ 
				_AddHighlight = value;
				OnPropertyChanged("AddHighlight");
			}
		}
		#endregion

		#region CTor
		public ESearchEntryAbstractNestedItem()
		{
		}

		public ESearchEntryAbstractNestedItem(JToken node) : base(node)
		{
			if(node["searchTerm"] != null)
			{
				this._SearchTerm = node["searchTerm"].Value<string>();
			}
			if(node["itemType"] != null)
			{
				this._ItemType = (ESearchItemType)ParseEnum(typeof(ESearchItemType), node["itemType"].Value<string>());
			}
			if(node["range"] != null)
			{
				this._Range = ObjectFactory.Create<ESearchRange>(node["range"]);
			}
			if(node["addHighlight"] != null)
			{
				this._AddHighlight = ParseBool(node["addHighlight"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchEntryAbstractNestedItem");
			kparams.AddIfNotNull("searchTerm", this._SearchTerm);
			kparams.AddIfNotNull("itemType", this._ItemType);
			kparams.AddIfNotNull("range", this._Range);
			kparams.AddIfNotNull("addHighlight", this._AddHighlight);
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
				case ADD_HIGHLIGHT:
					return "AddHighlight";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

