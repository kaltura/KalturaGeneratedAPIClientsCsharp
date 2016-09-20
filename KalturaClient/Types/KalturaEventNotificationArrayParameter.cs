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
	public class KalturaEventNotificationArrayParameter : KalturaEventNotificationParameter
	{
		#region Private Fields
		private IList<KalturaString> _Values;
		private IList<KalturaStringValue> _AllowedValues;
		#endregion

		#region Properties
		public new IList<KalturaString> Values
		{
			get { return _Values; }
			set 
			{ 
				_Values = value;
				OnPropertyChanged("Values");
			}
		}
		public new IList<KalturaStringValue> AllowedValues
		{
			get { return _AllowedValues; }
			set 
			{ 
				_AllowedValues = value;
				OnPropertyChanged("AllowedValues");
			}
		}
		#endregion

		#region CTor
		public KalturaEventNotificationArrayParameter()
		{
		}

		public KalturaEventNotificationArrayParameter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "values":
						this._Values = new List<KalturaString>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Values.Add((KalturaString)KalturaObjectFactory.Create(arrayNode, "KalturaString"));
						}
						continue;
					case "allowedValues":
						this._AllowedValues = new List<KalturaStringValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AllowedValues.Add((KalturaStringValue)KalturaObjectFactory.Create(arrayNode, "KalturaStringValue"));
						}
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaEventNotificationArrayParameter");
			kparams.AddIfNotNull("values", this.Values);
			kparams.AddIfNotNull("allowedValues", this.AllowedValues);
			return kparams;
		}
		#endregion
	}
}

