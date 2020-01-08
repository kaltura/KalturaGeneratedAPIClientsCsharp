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
	public class ReportResponseOptions : ObjectBase
	{
		#region Constants
		public const string DELIMITER = "delimiter";
		public const string SKIP_EMPTY_DATES = "skipEmptyDates";
		#endregion

		#region Private Fields
		private string _Delimiter = null;
		private bool? _SkipEmptyDates = null;
		#endregion

		#region Properties
		[JsonProperty]
		public string Delimiter
		{
			get { return _Delimiter; }
			set 
			{ 
				_Delimiter = value;
				OnPropertyChanged("Delimiter");
			}
		}
		[JsonProperty]
		public bool? SkipEmptyDates
		{
			get { return _SkipEmptyDates; }
			set 
			{ 
				_SkipEmptyDates = value;
				OnPropertyChanged("SkipEmptyDates");
			}
		}
		#endregion

		#region CTor
		public ReportResponseOptions()
		{
		}

		public ReportResponseOptions(JToken node) : base(node)
		{
			if(node["delimiter"] != null)
			{
				this._Delimiter = node["delimiter"].Value<string>();
			}
			if(node["skipEmptyDates"] != null)
			{
				this._SkipEmptyDates = ParseBool(node["skipEmptyDates"].Value<string>());
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaReportResponseOptions");
			kparams.AddIfNotNull("delimiter", this._Delimiter);
			kparams.AddIfNotNull("skipEmptyDates", this._SkipEmptyDates);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case DELIMITER:
					return "Delimiter";
				case SKIP_EMPTY_DATES:
					return "SkipEmptyDates";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

