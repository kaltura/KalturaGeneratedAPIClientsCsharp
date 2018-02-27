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
	public class ESearchRange : ObjectBase
	{
		#region Constants
		public const string GREATER_THAN_OR_EQUAL = "greaterThanOrEqual";
		public const string LESS_THAN_OR_EQUAL = "lessThanOrEqual";
		public const string GREATER_THAN = "greaterThan";
		public const string LESS_THAN = "lessThan";
		#endregion

		#region Private Fields
		private int _GreaterThanOrEqual = Int32.MinValue;
		private int _LessThanOrEqual = Int32.MinValue;
		private int _GreaterThan = Int32.MinValue;
		private int _LessThan = Int32.MinValue;
		#endregion

		#region Properties
		public int GreaterThanOrEqual
		{
			get { return _GreaterThanOrEqual; }
			set 
			{ 
				_GreaterThanOrEqual = value;
				OnPropertyChanged("GreaterThanOrEqual");
			}
		}
		public int LessThanOrEqual
		{
			get { return _LessThanOrEqual; }
			set 
			{ 
				_LessThanOrEqual = value;
				OnPropertyChanged("LessThanOrEqual");
			}
		}
		public int GreaterThan
		{
			get { return _GreaterThan; }
			set 
			{ 
				_GreaterThan = value;
				OnPropertyChanged("GreaterThan");
			}
		}
		public int LessThan
		{
			get { return _LessThan; }
			set 
			{ 
				_LessThan = value;
				OnPropertyChanged("LessThan");
			}
		}
		#endregion

		#region CTor
		public ESearchRange()
		{
		}

		public ESearchRange(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "greaterThanOrEqual":
						this._GreaterThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "lessThanOrEqual":
						this._LessThanOrEqual = ParseInt(propertyNode.InnerText);
						continue;
					case "greaterThan":
						this._GreaterThan = ParseInt(propertyNode.InnerText);
						continue;
					case "lessThan":
						this._LessThan = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaESearchRange");
			kparams.AddIfNotNull("greaterThanOrEqual", this._GreaterThanOrEqual);
			kparams.AddIfNotNull("lessThanOrEqual", this._LessThanOrEqual);
			kparams.AddIfNotNull("greaterThan", this._GreaterThan);
			kparams.AddIfNotNull("lessThan", this._LessThan);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case GREATER_THAN_OR_EQUAL:
					return "GreaterThanOrEqual";
				case LESS_THAN_OR_EQUAL:
					return "LessThanOrEqual";
				case GREATER_THAN:
					return "GreaterThan";
				case LESS_THAN:
					return "LessThan";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

