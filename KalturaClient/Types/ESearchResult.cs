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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ESearchResult : ObjectBase
	{
		#region Constants
		public const string OBJECT = "object";
		public const string HIGHLIGHT = "highlight";
		public const string ITEMS_DATA = "itemsData";
		#endregion

		#region Private Fields
		private ObjectBase _Object;
		private IList<ESearchHighlight> _Highlight;
		private IList<ESearchItemDataResult> _ItemsData;
		#endregion

		#region Properties
		public ObjectBase Object
		{
			get { return _Object; }
			set 
			{ 
				_Object = value;
				OnPropertyChanged("Object");
			}
		}
		public IList<ESearchHighlight> Highlight
		{
			get { return _Highlight; }
			set 
			{ 
				_Highlight = value;
				OnPropertyChanged("Highlight");
			}
		}
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

		public ESearchResult(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "object":
						this._Object = ObjectFactory.Create<ObjectBase>(propertyNode);
						continue;
					case "highlight":
						this._Highlight = new List<ESearchHighlight>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Highlight.Add(ObjectFactory.Create<ESearchHighlight>(arrayNode));
						}
						continue;
					case "itemsData":
						this._ItemsData = new List<ESearchItemDataResult>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._ItemsData.Add(ObjectFactory.Create<ESearchItemDataResult>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaESearchResult");
			kparams.AddIfNotNull("object", this._Object);
			kparams.AddIfNotNull("highlight", this._Highlight);
			kparams.AddIfNotNull("itemsData", this._ItemsData);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT:
					return "Object";
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

