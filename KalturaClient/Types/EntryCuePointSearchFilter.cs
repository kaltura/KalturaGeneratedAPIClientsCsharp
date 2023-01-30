// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platforms allow them to do with
// text.
//
// Copyright (C) 2006-2023  Kaltura Inc.
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
	public class EntryCuePointSearchFilter : SearchItem
	{
		#region Constants
		public const string CUE_POINTS_FREE_TEXT = "cuePointsFreeText";
		public const string CUE_POINT_TYPE_IN = "cuePointTypeIn";
		public const string CUE_POINT_SUB_TYPE_EQUAL = "cuePointSubTypeEqual";
		#endregion

		#region Private Fields
		private string _CuePointsFreeText = null;
		private string _CuePointTypeIn = null;
		private int _CuePointSubTypeEqual = Int32.MinValue;
		#endregion

		#region Properties
		/// <summary>
		/// Use CuePointsFreeTextAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CuePointsFreeText
		{
			get { return _CuePointsFreeText; }
			set 
			{ 
				_CuePointsFreeText = value;
				OnPropertyChanged("CuePointsFreeText");
			}
		}
		/// <summary>
		/// Use CuePointTypeInAsDouble property instead
		/// </summary>
		[JsonProperty]
		public string CuePointTypeIn
		{
			get { return _CuePointTypeIn; }
			set 
			{ 
				_CuePointTypeIn = value;
				OnPropertyChanged("CuePointTypeIn");
			}
		}
		/// <summary>
		/// Use CuePointSubTypeEqualAsDouble property instead
		/// </summary>
		[JsonProperty]
		public int CuePointSubTypeEqual
		{
			get { return _CuePointSubTypeEqual; }
			set 
			{ 
				_CuePointSubTypeEqual = value;
				OnPropertyChanged("CuePointSubTypeEqual");
			}
		}
		#endregion

		#region CTor
		public EntryCuePointSearchFilter()
		{
		}

		public EntryCuePointSearchFilter(JToken node) : base(node)
		{
			if(node["cuePointsFreeText"] != null)
			{
				this._CuePointsFreeText = node["cuePointsFreeText"].Value<string>();
			}
			if(node["cuePointTypeIn"] != null)
			{
				this._CuePointTypeIn = node["cuePointTypeIn"].Value<string>();
			}
			if(node["cuePointSubTypeEqual"] != null)
			{
				this._CuePointSubTypeEqual = ParseInt(node["cuePointSubTypeEqual"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaEntryCuePointSearchFilter");
			kparams.AddIfNotNull("cuePointsFreeText", this._CuePointsFreeText);
			kparams.AddIfNotNull("cuePointTypeIn", this._CuePointTypeIn);
			kparams.AddIfNotNull("cuePointSubTypeEqual", this._CuePointSubTypeEqual);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case CUE_POINTS_FREE_TEXT:
					return "CuePointsFreeText";
				case CUE_POINT_TYPE_IN:
					return "CuePointTypeIn";
				case CUE_POINT_SUB_TYPE_EQUAL:
					return "CuePointSubTypeEqual";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

