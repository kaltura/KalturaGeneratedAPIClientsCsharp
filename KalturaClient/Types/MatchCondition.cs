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
// Copyright (C) 2006-2020  Kaltura Inc.
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Kaltura.Types
{
	public class MatchCondition : Condition
	{
		#region Constants
		public const string VALUES = "values";
		public const string MATCH_TYPE = "matchType";
		#endregion

		#region Private Fields
		private IList<StringValue> _Values;
		private MatchConditionType _MatchType = null;
		#endregion

		#region Properties
		[JsonProperty]
		public IList<StringValue> Values
		{
			get { return _Values; }
			set 
			{ 
				_Values = value;
				OnPropertyChanged("Values");
			}
		}
		[JsonProperty]
		public MatchConditionType MatchType
		{
			get { return _MatchType; }
			set 
			{ 
				_MatchType = value;
				OnPropertyChanged("MatchType");
			}
		}
		#endregion

		#region CTor
		public MatchCondition()
		{
		}

		public MatchCondition(JToken node) : base(node)
		{
			if(node["values"] != null)
			{
				this._Values = new List<StringValue>();
				foreach(var arrayNode in node["values"].Children())
				{
					this._Values.Add(ObjectFactory.Create<StringValue>(arrayNode));
				}
			}
			if(node["matchType"] != null)
			{
				this._MatchType = (MatchConditionType)StringEnum.Parse(typeof(MatchConditionType), node["matchType"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaMatchCondition");
			kparams.AddIfNotNull("values", this._Values);
			kparams.AddIfNotNull("matchType", this._MatchType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case VALUES:
					return "Values";
				case MATCH_TYPE:
					return "MatchType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

