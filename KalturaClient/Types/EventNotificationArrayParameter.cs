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
	public class EventNotificationArrayParameter : EventNotificationParameter
	{
		#region Constants
		public const string VALUES = "values";
		public const string ALLOWED_VALUES = "allowedValues";
		#endregion

		#region Private Fields
		private IList<String> _Values;
		private IList<StringValue> _AllowedValues;
		#endregion

		#region Properties
		public IList<String> Values
		{
			get { return _Values; }
			set 
			{ 
				_Values = value;
				OnPropertyChanged("Values");
			}
		}
		public IList<StringValue> AllowedValues
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
		public EventNotificationArrayParameter()
		{
		}

		public EventNotificationArrayParameter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "values":
						this._Values = new List<String>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._Values.Add(ObjectFactory.Create<String>(arrayNode));
						}
						continue;
					case "allowedValues":
						this._AllowedValues = new List<StringValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._AllowedValues.Add(ObjectFactory.Create<StringValue>(arrayNode));
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
				kparams.AddReplace("objectType", "KalturaEventNotificationArrayParameter");
			kparams.AddIfNotNull("values", this._Values);
			kparams.AddIfNotNull("allowedValues", this._AllowedValues);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VALUES:
					return "Values";
				case ALLOWED_VALUES:
					return "AllowedValues";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

