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

namespace Kaltura
{
	public class KalturaBaseEntryCloneOptionComponent : KalturaBaseEntryCloneOptionItem
	{
		#region Private Fields
		private KalturaBaseEntryCloneOptions _ItemType = null;
		private KalturaCloneComponentSelectorType _Rule = null;
		#endregion

		#region Properties
		public KalturaBaseEntryCloneOptions ItemType
		{
			get { return _ItemType; }
			set 
			{ 
				_ItemType = value;
				OnPropertyChanged("ItemType");
			}
		}
		public KalturaCloneComponentSelectorType Rule
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
		public KalturaBaseEntryCloneOptionComponent()
		{
		}

		public KalturaBaseEntryCloneOptionComponent(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "itemType":
						this.ItemType = (KalturaBaseEntryCloneOptions)KalturaStringEnum.Parse(typeof(KalturaBaseEntryCloneOptions), txt);
						continue;
					case "rule":
						this.Rule = (KalturaCloneComponentSelectorType)KalturaStringEnum.Parse(typeof(KalturaCloneComponentSelectorType), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBaseEntryCloneOptionComponent");
			kparams.AddIfNotNull("itemType", this.ItemType);
			kparams.AddIfNotNull("rule", this.Rule);
			return kparams;
		}
		#endregion
	}
}

