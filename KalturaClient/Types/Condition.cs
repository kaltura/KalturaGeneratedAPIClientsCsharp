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
	public class Condition : ObjectBase
	{
		#region Constants
		public const string TYPE = "type";
		public const string DESCRIPTION = "description";
		public const string NOT = "not";
		#endregion

		#region Private Fields
		private ConditionType _Type = null;
		private string _Description = null;
		private bool? _Not = null;
		#endregion

		#region Properties
		public ConditionType Type
		{
			get { return _Type; }
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
		public Condition()
		{
		}

		public Condition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "type":
						this._Type = (ConditionType)StringEnum.Parse(typeof(ConditionType), propertyNode.InnerText);
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
						continue;
					case "not":
						this._Not = ParseBool(propertyNode.InnerText);
						continue;
				}
			}
		}

		public Condition(IDictionary<string,object> data) : base(data)
		{
			    this._Type = (ConditionType)StringEnum.Parse(typeof(ConditionType), data.TryGetValueSafe<string>("type"));
			    this._Description = data.TryGetValueSafe<string>("description");
			    this._Not = data.TryGetValueSafe<bool>("not");
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCondition");
			kparams.AddIfNotNull("type", this._Type);
			kparams.AddIfNotNull("description", this._Description);
			kparams.AddIfNotNull("not", this._Not);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case TYPE:
					return "Type";
				case DESCRIPTION:
					return "Description";
				case NOT:
					return "Not";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

