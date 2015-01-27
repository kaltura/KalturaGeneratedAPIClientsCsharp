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
	public class KalturaCondition : KalturaObjectBase
	{
		#region Private Fields
		private KalturaConditionType _Type = null;
		private string _Description = null;
		private bool? _Not = false;
		#endregion

		#region Properties
		public KalturaConditionType Type
		{
			get { return _Type; }
			set 
			{ 
				_Type = value;
				OnPropertyChanged("Type");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		public bool? Not
		{
			get { return _Not; }
			set 
			{ 
				_Not = value;
				OnPropertyChanged("Not");
			}
		}
		#endregion

		#region CTor
		public KalturaCondition()
		{
		}

		public KalturaCondition(XmlElement node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "type":
						this.Type = (KalturaConditionType)KalturaStringEnum.Parse(typeof(KalturaConditionType), txt);
						continue;
					case "description":
						this.Description = txt;
						continue;
					case "not":
						this.Not = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaCondition");
			kparams.AddStringEnumIfNotNull("type", this.Type);
			kparams.AddStringIfNotNull("description", this.Description);
			kparams.AddBoolIfNotNull("not", this.Not);
			return kparams;
		}
		#endregion
	}
}

