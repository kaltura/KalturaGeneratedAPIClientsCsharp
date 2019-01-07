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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class ESearchResult : ObjectBase
	{
		#region Constants
		public const string HIGHLIGHT = "highlight";
		public const string ITEMS_DATA = "itemsData";
		#endregion

		#region Private Fields
		private IList<ESearchHighlight> _Highlight;
		private IList<ESearchItemDataResult> _ItemsData;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<ESearchHighlight> Highlight
		{
			get { return _Highlight; }
			set 
			{ 
				_Highlight = value;
				OnPropertyChanged("Highlight");
			}
		}
		[JsonProperty]
		public IList<ESearchItemDataResult> ItemsData
		{
			get { return _ItemsData; }
			set 
			{ 
				_ItemsData = value;
				OnPropertyChanged("ItemsData");
			}
		}
		#endregion

		#region CTor
		public ESearchResult()
		{
		}

		public ESearchResult(JToken node) : base(node)
		{
			if(node["highlight"] != null)
			{
				this._Highlight = new List<ESearchHighlight>();
				foreach(var arrayNode in node["highlight"].Children())
				{
					this._Highlight.Add(ObjectFactory.Create<ESearchHighlight>(arrayNode));
				}
			}
			if(node["itemsData"] != null)
			{
				this._ItemsData = new List<ESearchItemDataResult>();
				foreach(var arrayNode in node["itemsData"].Children())
				{
					this._ItemsData.Add(ObjectFactory.Create<ESearchItemDataResult>(arrayNode));
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaESearchResult");
			kparams.AddIfNotNull("highlight", this._Highlight);
			kparams.AddIfNotNull("itemsData", this._ItemsData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HIGHLIGHT:
					return "Highlight";
				case ITEMS_DATA:
					return "ItemsData";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

