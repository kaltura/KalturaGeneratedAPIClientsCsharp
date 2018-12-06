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
	public class BaseEntryCloneOptionComponent : BaseEntryCloneOptionItem
	{
		#region Constants
		public const string ITEM_TYPE = "itemType";
		public const string RULE = "rule";
		#endregion

		#region Private Fields
		private BaseEntryCloneOptions _ItemType = null;
		private CloneComponentSelectorType _Rule = null;
		#endregion

		#region Properties
		public BaseEntryCloneOptions ItemType
		{
			get { return _ItemType; }
			set 
			{ 
				_ItemType = value;
				OnPropertyChanged("ItemType");
			}
		}
		public CloneComponentSelectorType Rule
		{
			get { return _Rule; }
			set 
			{ 
				_Rule = value;
				OnPropertyChanged("Rule");
			}
		}
		#endregion

		#region CTor
		public BaseEntryCloneOptionComponent()
		{
		}

		public BaseEntryCloneOptionComponent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "itemType":
						this._ItemType = (BaseEntryCloneOptions)StringEnum.Parse(typeof(BaseEntryCloneOptions), propertyNode.InnerText);
						continue;
					case "rule":
						this._Rule = (CloneComponentSelectorType)StringEnum.Parse(typeof(CloneComponentSelectorType), propertyNode.InnerText);
						continue;
				}
			}
		}

		public BaseEntryCloneOptionComponent(IDictionary<string,object> data) : base(data)
		{
			    this._ItemType = (BaseEntryCloneOptions)StringEnum.Parse(typeof(BaseEntryCloneOptions), data.TryGetValueSafe<string>("itemType"));
			    this._Rule = (CloneComponentSelectorType)StringEnum.Parse(typeof(CloneComponentSelectorType), data.TryGetValueSafe<string>("rule"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaBaseEntryCloneOptionComponent");
			kparams.AddIfNotNull("itemType", this._ItemType);
			kparams.AddIfNotNull("rule", this._Rule);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ITEM_TYPE:
					return "ItemType";
				case RULE:
					return "Rule";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

