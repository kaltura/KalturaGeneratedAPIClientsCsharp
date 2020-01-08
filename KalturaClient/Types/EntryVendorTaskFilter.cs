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
	public class EntryVendorTaskFilter : EntryVendorTaskBaseFilter
	{
		#region Constants
		public const string FREE_TEXT = "freeText";
		public const string EXPECTED_FINISH_TIME_GREATER_THAN_OR_EQUAL = "expectedFinishTimeGreaterThanOrEqual";
		public const string EXPECTED_FINISH_TIME_LESS_THAN_OR_EQUAL = "expectedFinishTimeLessThanOrEqual";
		public new const string ORDER_BY = "orderBy";
		#endregion

		#region Private Fields
		private string _FreeText = null;
		private int _ExpectedFinishTimeGreaterThanOrEqual = Int32.MinValue;
		private int _ExpectedFinishTimeLessThanOrEqual = Int32.MinValue;
		private EntryVendorTaskOrderBy _OrderBy = null;
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
		public int ExpectedFinishTimeGreaterThanOrEqual
		{
			get { return _ExpectedFinishTimeGreaterThanOrEqual; }
			set 
			{ 
				_ExpectedFinishTimeGreaterThanOrEqual = value;
				OnPropertyChanged("ExpectedFinishTimeGreaterThanOrEqual");
			}
		}
		[JsonProperty]
		public int ExpectedFinishTimeLessThanOrEqual
		{
			get { return _ExpectedFinishTimeLessThanOrEqual; }
			set 
			{ 
				_ExpectedFinishTimeLessThanOrEqual = value;
				OnPropertyChanged("ExpectedFinishTimeLessThanOrEqual");
			}
		}
		[JsonProperty]
		public new EntryVendorTaskOrderBy OrderBy
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
		public EntryVendorTaskFilter()
		{
		}

		public EntryVendorTaskFilter(JToken node) : base(node)
		{
			if(node["freeText"] != null)
			{
				this._FreeText = node["freeText"].Value<string>();
			}
			if(node["expectedFinishTimeGreaterThanOrEqual"] != null)
			{
				this._ExpectedFinishTimeGreaterThanOrEqual = ParseInt(node["expectedFinishTimeGreaterThanOrEqual"].Value<string>());
			}
			if(node["expectedFinishTimeLessThanOrEqual"] != null)
			{
				this._ExpectedFinishTimeLessThanOrEqual = ParseInt(node["expectedFinishTimeLessThanOrEqual"].Value<string>());
			}
			if(node["orderBy"] != null)
			{
				this._OrderBy = (EntryVendorTaskOrderBy)StringEnum.Parse(typeof(EntryVendorTaskOrderBy), node["orderBy"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryVendorTaskFilter");
			kparams.AddIfNotNull("freeText", this._FreeText);
			kparams.AddIfNotNull("expectedFinishTimeGreaterThanOrEqual", this._ExpectedFinishTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("expectedFinishTimeLessThanOrEqual", this._ExpectedFinishTimeLessThanOrEqual);
			kparams.AddIfNotNull("orderBy", this._OrderBy);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FREE_TEXT:
					return "FreeText";
				case EXPECTED_FINISH_TIME_GREATER_THAN_OR_EQUAL:
					return "ExpectedFinishTimeGreaterThanOrEqual";
				case EXPECTED_FINISH_TIME_LESS_THAN_OR_EQUAL:
					return "ExpectedFinishTimeLessThanOrEqual";
				case ORDER_BY:
					return "OrderBy";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

