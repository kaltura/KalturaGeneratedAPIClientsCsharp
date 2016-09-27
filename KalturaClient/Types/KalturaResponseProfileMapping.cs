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
	public class KalturaResponseProfileMapping : KalturaObjectBase
	{
		#region Private Fields
		private string _ParentProperty = null;
		private string _FilterProperty = null;
		private bool? _AllowNull = null;
		#endregion

		#region Properties
		public string ParentProperty
		{
			get { return _ParentProperty; }
			set 
			{ 
				_ParentProperty = value;
				OnPropertyChanged("ParentProperty");
			}
		}
		public string FilterProperty
		{
			get { return _FilterProperty; }
			set 
			{ 
				_FilterProperty = value;
				OnPropertyChanged("FilterProperty");
			}
		}
		public bool? AllowNull
		{
			get { return _AllowNull; }
			set 
			{ 
				_AllowNull = value;
				OnPropertyChanged("AllowNull");
			}
		}
		#endregion

		#region CTor
		public KalturaResponseProfileMapping()
		{
		}

		public KalturaResponseProfileMapping(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "parentProperty":
						this._ParentProperty = txt;
						continue;
					case "filterProperty":
						this._FilterProperty = txt;
						continue;
					case "allowNull":
						this._AllowNull = ParseBool(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaResponseProfileMapping");
			kparams.AddIfNotNull("parentProperty", this._ParentProperty);
			kparams.AddIfNotNull("filterProperty", this._FilterProperty);
			kparams.AddIfNotNull("allowNull", this._AllowNull);
			return kparams;
		}
		#endregion
	}
}

