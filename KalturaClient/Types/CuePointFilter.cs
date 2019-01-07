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
// Copyright (C) 2006-2019  Kaltura Inc.
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
	public class CuePointFilter : CuePointBaseFilter
	{
		#region Constants
		public const string FREE_TEXT = "freeText";
		public const string USER_ID_EQUAL_CURRENT = "userIdEqualCurrent";
		public const string USER_ID_CURRENT = "userIdCurrent";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _FreeText = null;
		private NullableBoolean _UserIdEqualCurrent = (NullableBoolean)Int32.MinValue;
		private NullableBoolean _UserIdCurrent = (NullableBoolean)Int32.MinValue;
		private CuePointOrderBy _OrderBy = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string FreeText
		{
			get { return _FreeText; }
			set 
			{ 
				_FreeText = value;
				OnPropertyChanged("FreeText");
			}
		}
		[JsonProperty]
		public NullableBoolean UserIdEqualCurrent
		{
			get { return _UserIdEqualCurrent; }
			set 
			{ 
				_UserIdEqualCurrent = value;
				OnPropertyChanged("UserIdEqualCurrent");
			}
		}
		[JsonProperty]
		public NullableBoolean UserIdCurrent
		{
			get { return _UserIdCurrent; }
			set 
			{ 
				_UserIdCurrent = value;
				OnPropertyChanged("UserIdCurrent");
			}
		}
		[JsonProperty]
		public new CuePointOrderBy OrderBy
		{
			get { return _OrderBy; }
			set 
			{ 
				_OrderBy = value;
				OnPropertyChanged("OrderBy");
			}
		}
		#endregion

		#region CTor
		public CuePointFilter()
		{
		}

		public CuePointFilter(JToken node) : base(node)
		{
			if(node["freeText"] != null)
			{
				this._FreeText = node["freeText"].Value<string>();
			}
			if(node["userIdEqualCurrent"] != null)
			{
				this._UserIdEqualCurrent = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["userIdEqualCurrent"].Value<string>());
			}
			if(node["userIdCurrent"] != null)
			{
				this._UserIdCurrent = (NullableBoolean)ParseEnum(typeof(NullableBoolean), node["userIdCurrent"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (CuePointOrderBy)StringEnum.Parse(typeof(CuePointOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaCuePointFilter");
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("userIdEqualCurrent", this._UserIdEqualCurrent);
			kparams.AddIfNotNull("userIdCurrent", this._UserIdCurrent);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FREE_TEXT:
					return "FreeText";
				case USER_ID_EQUAL_CURRENT:
					return "UserIdEqualCurrent";
				case USER_ID_CURRENT:
					return "UserIdCurrent";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

