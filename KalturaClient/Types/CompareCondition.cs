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
	public class CompareCondition : Condition
	{
		#region Constants
		public const string VALUE = "value";
		public const string COMPARISON = "comparison";
		#endregion

		#region Private Fields
		private IntegerValue _Value;
		private SearchConditionComparison _Comparison = null;
		#endregion

		#region Properties
		public IntegerValue Value
		{
			get { return _Value; }
			set 
			{ 
				_Value = value;
				OnPropertyChanged("Value");
			}
		}
		public SearchConditionComparison Comparison
		{
			get { return _Comparison; }
			set 
			{ 
				_Comparison = value;
				OnPropertyChanged("Comparison");
			}
		}
		#endregion

		#region CTor
		public CompareCondition()
		{
		}

		public CompareCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "value":
						this._Value = ObjectFactory.Create<IntegerValue>(propertyNode);
						continue;
					case "comparison":
						this._Comparison = (SearchConditionComparison)StringEnum.Parse(typeof(SearchConditionComparison), propertyNode.InnerText);
						continue;
				}
			}
		}

		public CompareCondition(IDictionary<string,object> data) : base(data)
		{
			    this._Value = ObjectFactory.Create<IntegerValue>(data.TryGetValueSafe<IDictionary<string,object>>("value"));
			    this._Comparison = (SearchConditionComparison)StringEnum.Parse(typeof(SearchConditionComparison), data.TryGetValueSafe<string>("comparison"));
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCompareCondition");
			kparams.AddIfNotNull("value", this._Value);
			kparams.AddIfNotNull("comparison", this._Comparison);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VALUE:
					return "Value";
				case COMPARISON:
					return "Comparison";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

